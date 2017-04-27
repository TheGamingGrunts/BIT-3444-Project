Public Class frmOrderQueue

    Dim myNet As New Network
    Dim myDatabase As Database
    Dim arcSortedList As SortedList(Of String, Arc)
    Dim nodeSortedList As SortedList(Of String, Node)
    Public Shared orderList As List(Of Order)
    Dim waiting As List(Of Order)
    Dim delivered As List(Of Order)
    Dim settingsForm As New frmSettings
    Public Shared solveOption As Boolean = True

    'Initializes the class variables
    Private Sub frmMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myDatabase = New Database
        nodeSortedList = myDatabase.GetNodes()
        arcSortedList = myDatabase.GetArcs(nodeSortedList)
    End Sub

    ' Causes close button to stop the program
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' Causes solve button to solve an optimization for routes based on orders
    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        If solveOption Then
            LabelCorrecting()
            SortWaitingList()
        Else
            'SolverOptimization()
        End If
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
                Do While n.ID <> dest
                    For Each a In n.ArcsOut
                        If opt.GetVarValue(a.ID) > 0.1 Then
                            list.Add(a)
                            length += a.Cost 'a.distance
                            n = a.HeadNode
                            Exit For
                        End If
                    Next
                Loop
                Return list
            Else
                length = inf
                Return Nothing
            End If
        Next
        Return Nothing
    End Function

    Private Sub LabelCorrecting()
        BuildNetwork()
        lstWaiting.Items.Clear()
        Dim newOrderList As New List(Of Order)

        Dim cityList = From city In myNet.NodeList.Values
                       Order By city.ArcsOut.Count Descending, city.ID

        For Each o In orderList
            For Each city In cityList
                Dim c1 As String = city.ID
                Dim origTNode As New TreeNode(c1)
                For Each c2 In myNet.NodeList.Keys
                    Dim length As Decimal
                    Dim list As List(Of TArc) = myNet.ShortestPath(c1, c2, length)
                    If list IsNot Nothing Then
                        newOrderList.Add(New Order(c1, c2, list, length))
                        Dim destTNode As New TreeNode(c2)
                        origTNode.Nodes.Add(destTNode)
                    End If
                Next
            Next
        Next

        orderList.Clear()
        orderList = newOrderList

        For Each o In orderList
            lstWaiting.Items.Add(o)
        Next
    End Sub

    Public Sub BuildNetwork()
        myDatabase = New Database()
        myNet.NodeList.Clear()
        myNet.ArcList.Clear()

        MessageBox.Show(myDatabase.GetNumNodes)

        For i As Integer = 1 To myDatabase.GetNumNodes

            MessageBox.Show("before " & i)

            myNet += myDatabase.GetNodeName(i)

            MessageBox.Show("after " & i)

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

        MessageBox.Show("Network has been created with " & myDatabase.GetNumNodes &
                        " nodes and " & myDatabase.GetNumArcs & " arcs.")
    End Sub

    'Sorts the waiting list in ascending or descending order based on length
    Private Sub SortWaitingList()
    Dim newWaiting As List(Of Order)
    If settingsForm.rdoAscending.Checked Then
        newWaiting = From orders In waiting
                     Order By orders.length Ascending, orders.Origin
    Else
        newWaiting = From orders In waiting
                     Order By orders.length Descending, orders.Origin
    End If
    waiting = newWaiting

    lstWaiting.Items.Clear()
    For Each o In waiting
        lstWaiting.Items.Add(o)
    Next
End Sub

'goes through the waiting list and moves orders to the delivered list if they path is clear
Private Sub deliverOrders()
    Dim pathIsClear As Boolean

    For Each o In waiting
        pathIsClear = True
        For Each a In o.Path
            If myNet.GetArc(a.TailNode.ToString, a.HeadNode.ToString).Capacity <= 0 Then
                pathIsClear = False
            End If

            If pathIsClear = False Then
                Exit For
            End If
        Next

        If pathIsClear Then
            delivered.Add(o)
            For Each a In o.Path
                myNet.GetArc(a.TailNode.ToString, a.HeadNode.ToString).Capacity -= 1
            Next
            waiting.Remove(o)
        End If
    Next

    For Each a In myNet.ArcList.Values
        If myNet.GetArc(a.TailNode.ToString, a.HeadNode.ToString).Capacity = 0 Then
            myNet.ArcList.Remove(a.ID)
        End If
    Next
End Sub

Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        settingsForm.Show()
    End Sub
End Class
