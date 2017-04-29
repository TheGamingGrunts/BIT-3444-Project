Public Class frmOrderQueue

    Dim myNet As New Network
    Dim myDatabase As Database
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
            'lstWaiting.Items.Add(o.ToString)
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
    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click

    End Sub

    Public Function SolverOptimization(orig As String, dest As String, ByRef length As Double) As List(Of TArc)
        Dim opt As New Optimization
        opt.InitSolver()

        Dim inf As Double = Double.MaxValue

        For Each a In arcSortedList.Values
            opt.AddVar(a.ID, 0, 1)
        Next

        For Each n In nodeSortedList.Values
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

            'create objective
            opt.AddObj("obj")
            For Each a In arcSortedList.Values
                opt.SetCoef("obj", a.ID, a.Cost) 'a.distance
            Next

            opt.SolveModel("obj", True)
            If opt.IsOptimal() Then
                Dim list As New List(Of TArc)
                Dim node As Node = nodeSortedList(orig)
                If n.ID <> dest Then

                    For Each a In n.ArcsOut
                        If opt.GetVarValue(a.ID) > 0.1 Then
                            list.Add(a)
                            length += a.Cost 'a.distance
                            n = a.HeadNode
                            Exit For
                        End If
                    Next
                End If
                Return list
                Else
                    length = inf
                Return Nothing
            End If
        Next
        Return Nothing
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
    Private Sub SortWaitingList()
        Dim sortedWait
        Dim sortedDeiliver

        If IsAscending Then
            sortedWait = From o In orderList.Values
                         Where o.Delivered = False
                         Order By o.Length Ascending

            sortedDeiliver = From o In orderList.Values
                             Where o.Delivered = True
                             Order By o.Length Ascending
        Else
            sortedWait = From o In orderList.Values
                         Where o.Delivered = False
                         Order By o.Length Descending

            sortedDeiliver = From o In orderList.Values
                             Where o.Delivered = True
                             Order By o.Length Descending
        End If

        For Each o In sortedWait
            waiting.Add(o)
        Next

        For Each o In sortedDeiliver
            delivered.Add(o)
        Next

        lstWaiting.Items.Clear()
        For Each o In waiting
            lstWaiting.Items.Add(o.ToString)
        Next

        For Each o In delivered
            lstDelivered.Items.Add(o.ToString)
        Next

        frmContainer.Refresh()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
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
End Class
