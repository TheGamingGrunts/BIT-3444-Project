Public Class frmOutput

    Dim myDatabase As Database
    Dim arcSortedList As SortedList(Of String, Arc)
    Dim nodeSortedList As SortedList(Of String, Node)
    Dim orderList As List(Of Order)
    Dim waiting As List(Of Order)
    Dim delivered As List(Of Order)

    'Initializes the class variables
    Private Sub frmMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myDatabase = New Database
        nodeSortedList = myDatabase.GetNodes()
        arcSortedList = myDatabase.GetArcs(nodeSortedList)
    End Sub

    ' Causes close button to stop the program
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    ' Causes solve button to solve an optimization for routes based on orders
    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click

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
                opt.SetCoef("obj", a.ID, a.Distance)
            Next

            opt.SolveModel("obj", True)

            If opt.IsOptimal() Then
                Dim list As New List(Of TArc)
                Dim node As Node = nodeSortedList(orig)
                Do While n.ID <> dest
                    For Each a In n.ArcsOut
                        If opt.GetVarValue(a.ID) > 0.1 Then
                            list.Add(a)
                            length += a.Distance
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
End Class
