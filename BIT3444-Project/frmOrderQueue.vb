Public Class frmOrderQueue

    Dim myNet As New Network
    Dim myDatabase As Database
    Dim opt As New Optimization
    Dim arcSortedList As SortedList(Of String, Arc)
    Dim nodeSortedList As SortedList(Of String, Node)
    Public Shared orderList As SortedList(Of String, Order)
    Dim waiting As List(Of Order)
    Dim delivered As List(Of Order)
    Dim settingsForm As New frmSettings
    Public Shared solveOption As Boolean = False
    Public Shared IsAscending As Boolean = True

    'Initializes the class variables
    Private Sub frmOrderQueue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myDatabase = New Database
        nodeSortedList = myDatabase.GetNodes()
        arcSortedList = myDatabase.GetArcs(nodeSortedList)
        orderList = myDatabase.GetOrders(nodeSortedList)
        waiting = New List(Of Order)
        delivered = New List(Of Order)

        For Each o In orderList.Values
            waiting.Add(o)
            lstWaiting.Items.Add(o.ToString)
        Next
    End Sub

    ' Causes close button to stop the program
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmContainer.Close()
    End Sub

    ' Causes solve button to solve an optimization for routes based on orders
    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        If solveOption Then
            SendOrdersLabelCorrecting()
        Else
            SendOrdersSolver()
        End If

        SortWaitingList()
    End Sub

    ' Opens a form that allows the user to add an order
    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs)

    End Sub

    Public Function SolverOptimization(orig As String, dest As String, ByRef length As Double) As List(Of TArc)

        Dim inf As Decimal = 1000000000

        If orig = dest Then
            length = inf
            Return Nothing
        End If

        ' initialize network
        For Each a In myNet.ArcList.Values
            a.Flow = 0
        Next

        ' Initialize Solver
        opt.InitSolver()

        ' Create variables
        For Each a In myNet.ArcList.Values
            opt.AddVar(a.ID, 0, 1)
        Next

        ' Create Constraints
        For Each n In myNet.NodeList.Values
            Dim rhs As Integer
            Select Case n.ID
                Case orig
                    rhs = -1
                Case dest
                    rhs = 1
                Case Else
                    rhs = 0
            End Select
            opt.AddFun(n.ID, rhs, rhs)
            For Each a In n.ArcsIn
                opt.SetCoef(n.ID, a.ID, 1)
            Next
            For Each a In n.ArcsOut
                opt.SetCoef(n.ID, a.ID, -1)
            Next
        Next

        ' Create objective and solve model
        opt.AddObj("obj")
        For Each a In myNet.ArcList.Values
            opt.SetCoef("obj", a.ID, a.Cost)
        Next
        opt.SolveModel("obj", True)

        ' Get results
        If opt.IsOptimal() Then
            Dim list As New List(Of TArc)
            Dim n As Node = myNet.NodeList(dest)
            length = 0
            Do While n.ID <> orig
                For Each a In n.ArcsIn
                    If opt.GetVarValue(a.ID) > 0.01 Then
                        list.Insert(0, a.toTArc)
                        length += 1
                        n = a.TailNode
                        Exit For
                    End If
                Next
            Loop
            Return list
        Else
            length = inf
            Return Nothing
        End If

    End Function

    'creates the network of nodes and arcs
    Public Sub BuildNetwork()
        myDatabase = New Database()
        myNet.NodeList.Clear()
        myNet.ArcList.Clear()

        For i As Integer = 1 To myDatabase.GetNumNodes
            myNet += myDatabase.GetNodeName(i)
        Next
        For Each c1 In myNet.NodeList.Keys
            For Each c2 In myNet.NodeList.Keys
                Dim dist As Decimal = myDatabase.GetDistance(c1, c2)
                If c1 <> c2 And dist > 0 Then
                    myNet.AddArc(c1, c2)
                    Dim a As Arc = myNet.GetArc(c1, c2)
                    a.Distance = dist
                    a.Capacity = 1
                End If
            Next
        Next
    End Sub

    'Sorts the waiting list in ascending or descending order based on length
    Public Sub SortWaitingList()
        Dim sortedWait
        Dim sortedDeiliver

        If IsAscending Then
            sortedWait = From o In orderList.Values
                         Where o.Delivered = False
                         Order By o.Length Ascending, o.ID Ascending

            sortedDeiliver = From o In orderList.Values
                             Where o.Delivered = True
                             Order By o.Length Ascending, o.ID Ascending
        Else
            sortedWait = From o In orderList.Values
                         Where o.Delivered = False
                         Order By o.Length Descending, o.ID Ascending

            sortedDeiliver = From o In orderList.Values
                             Where o.Delivered = True
                             Order By o.Length Descending, o.ID Ascending
        End If

        waiting.Clear()
        delivered.Clear()
        For Each o In sortedWait
            waiting.Add(o)
        Next

        For Each o In sortedDeiliver
            delivered.Add(o)
        Next

        lstWaiting.Items.Clear()
        lstDelivered.Items.Clear()
        For Each o In waiting
            lstWaiting.Items.Add(o.ToString)
        Next

        For Each o In delivered
            lstDelivered.Items.Add(o.ToString)
        Next

        frmContainer.Refresh()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs)
        settingsForm.Show()
    End Sub

    ' Function that sends all orders using the solver method
    Private Sub SendOrdersSolver()

        ' lists to keep the original shortest paths
        Dim origPaths As New SortedList(Of String, List(Of TArc))

        ' find and keep original shortest paths
        For Each o In orderList.Values
            Dim length As Integer
            Dim path As List(Of TArc) = SolverOptimization(o.Origin, o.Destination, length)
            origPaths.Add(o.ID, path)
        Next

        ' initialize waiting list size
        Dim numWaiting As Integer = orderList.Count

        ' main loop for finding 
        Do While True

            ' Find shortest path for each order with current network
            For Each o In orderList.Values
                o.Path = SolverOptimization(o.Origin, o.Destination, o.Length)
            Next

            ' sort ascending or descending order of length
            Dim sorted
            If IsAscending Then
                sorted = From o In orderList.Values
                         Where o.Delivered = False
                         Order By o.Length Ascending
            Else
                sorted = From o In orderList.Values
                         Where o.Delivered = False
                         Order By o.Length Descending
            End If

            ' mark deliverable orders
            For Each o In sorted
                Dim deliverable As Boolean = True
                For Each a In o.Path
                    If Not myNet.ArcList.ContainsKey(a.ID) Then
                        deliverable = False
                        Exit For
                    End If
                Next
                If deliverable Then
                    o.Delivered = True
                    For Each a In o.Path
                        a.Capacity -= 1
                        ' remove arc if capacity drops to 0
                        If a.Capacity = 0 Then
                            a.Tail.ArcsOut.Remove(a)
                            a.Head.ArcsIn.Remove(a)
                            myNet.ArcList.Remove(a.ID)
                        End If
                    Next
                End If
            Next

            ' use LINQ to find the length of the waiting list
            Dim waiting = From o In orderList.Values
                          Where o.Delivered = False

            ' if number of waiting orders did not change, then exit do loop	
            ' otherwise update number of waiting orders
            If waiting.Count = numWaiting Then
                Exit Do
            Else
                numWaiting = waiting.Count
            End If
        Loop
    End Sub

    ' Function that sends all orders using the label correcting method
    Private Sub SendOrdersLabelCorrecting()
        ' lists to keep the original shortest paths
        Dim origPaths As New SortedList(Of String, List(Of TArc))

        ' find and keep original shortest paths
        For Each o In orderList.Values
            Dim length As Integer
            Dim path As List(Of TArc) = SolverOptimization(o.Origin, o.Destination, length)
            origPaths.Add(o.ID, path)
        Next

        ' initialize waiting list size
        Dim numWaiting As Integer = orderList.Count

        ' main loop for finding 
        Do While True

            ' Find shortest path for each order with current network
            For Each o In orderList.Values
                o.Path = SolverOptimization(o.Origin, o.Destination, o.Length)
            Next

            ' sort ascending or descending order of length
            Dim sorted
            If IsAscending Then
                sorted = From o In orderList.Values
                         Where o.Delivered = False
                         Order By o.Length Ascending
            Else
                sorted = From o In orderList.Values
                         Where o.Delivered = False
                         Order By o.Length Descending
            End If

            ' mark deliverable orders
            For Each o In sorted
                Dim deliverable As Boolean = True
                For Each a In o.Path
                    If Not myNet.ArcList.ContainsKey(a.ID) Then
                        deliverable = False
                        Exit For
                    End If
                Next
                If deliverable Then
                    o.Delivered = True
                    For Each a In o.Path
                        a.Capacity -= 1
                        ' remove arc if capacity drops to 0
                        If a.Capacity = 0 Then
                            a.Tail.ArcsOut.Remove(a)
                            a.Head.ArcsIn.Remove(a)
                            myNet.ArcList.Remove(a.ID)
                        End If
                    Next
                End If
            Next

            ' use LINQ to find the length of the waiting list
            Dim waiting = From o In orderList.Values
                          Where o.Delivered = False

            ' if number of waiting orders did not change, then exit do loop	
            ' otherwise update number of waiting orders
            If waiting.Count = numWaiting Then
                Exit Do
            Else
                numWaiting = waiting.Count
            End If
        Loop
    End Sub

    Private Sub lstDelivered_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDelivered.SelectedIndexChanged
        Dim order As Order = Nothing
        For Each o In delivered
            If o.ID = Strings.Replace(lstDelivered.SelectedItem, "Order #", "") Then
                order = o
                Exit For
            End If
        Next
        Dim str As String = "Length: " & order.Length & vbCrLf
        For Each path In order.Path
            str &= "Path: " & path.TailNode.ID & " -> " & path.HeadNode.ID & vbCrLf
            For Each arc In path.PathList
                str &= arc.ToString
            Next
        Next

        txtTotalCost.Text = order.getTotalCost()

        Dim newMap As New frmMap
        newMap.Net = myNet
        newMap.Origin = order.Origin
        newMap.Destination = order.Destination
        newMap.Path = order.Path
        newMap.MdiParent = frmContainer
        My.Forms.frmContainer.spcMain.Panel2.Controls.Add(newMap)
        newMap.WindowState = FormWindowState.Maximized
        newMap.Show()

        txtOutput.Text = str
    End Sub

    Public Shared Function GetForm(text As String) As Form
        For Each f In Application.OpenForms
            If f.text = text Then
                Return f
            End If
        Next
    End Function

    Private Sub AscendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AscendingToolStripMenuItem.Click
        IsAscending = True
        SortWaitingList()
    End Sub

    Private Sub DescendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescendingToolStripMenuItem.Click
        IsAscending = False
        SortWaitingList()
    End Sub

    Private Sub LabelCorrectingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabelCorrectingToolStripMenuItem.Click
        solveOption = True
        SendOrdersLabelCorrecting()
        SortWaitingList()
    End Sub

    Private Sub LinearOptimizationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinearOptimizationToolStripMenuItem.Click
        solveOption = False
        SendOrdersSolver()
        SortWaitingList()
    End Sub

    Private Sub btnEditOrder_Click(sender As Object, e As EventArgs) Handles btnEditOrder.Click
        frmDatabase.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ContactInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactInfoToolStripMenuItem.Click
        frmContact.Show()
    End Sub
End Class
