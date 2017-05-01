Imports Microsoft.SolverFoundation.Solvers
Imports Microsoft.SolverFoundation.Common

Public Class Optimization
    Private VarSList As New SortedList(Of String, Integer)
    Private FunSList As New SortedList(Of String, Integer)
    Private myModel As SimplexSolver

    Public Inf As Decimal = 999999999

    Public Sub New()

    End Sub

    ' Initialization of variable and function lists, and solver
    Public Sub InitSolver()
        VarSList.Clear()
        FunSList.Clear()
        myModel = New SimplexSolver
    End Sub

    ' Add a new variale to model
    Public Sub AddVar(varstr As String, lb As Decimal, ub As Decimal)
        VarSList.Add(varstr, 0)
        myModel.AddVariable(varstr, VarSList(varstr))
        If lb = -Inf And ub = Inf Then
            myModel.SetBounds(VarSList(varstr), Rational.NegativeInfinity, Rational.PositiveInfinity)
        ElseIf lb = -Inf Then
            myModel.SetBounds(VarSList(varstr), Rational.NegativeInfinity, ub)
        ElseIf ub = Inf Then
            myModel.SetBounds(VarSList(varstr), lb, Rational.PositiveInfinity)
        Else
            myModel.SetBounds(VarSList(varstr), lb, ub)
        End If

    End Sub

    ' Add a new function to model
    Public Sub AddFun(funstr As String, lb As Decimal, ub As Decimal)
        FunSList.Add(funstr, 0)
        myModel.AddRow(funstr, FunSList(funstr))
        If lb = -Inf And ub = Inf Then
            myModel.SetBounds(FunSList(funstr), Rational.NegativeInfinity, Rational.PositiveInfinity)
        ElseIf lb = -Inf Then
            myModel.SetBounds(FunSList(funstr), Rational.NegativeInfinity, ub)
        ElseIf ub = Inf Then
            myModel.SetBounds(FunSList(funstr), lb, Rational.PositiveInfinity)
        Else
            myModel.SetBounds(FunSList(funstr), lb, ub)
        End If
    End Sub

    ' Add an objective function
    Public Sub AddObj(funstr As String)
        FunSList.Add(funstr, 0)
        myModel.AddRow(funstr, FunSList(funstr))
    End Sub

    ' Set coefficient of a variable in a function
    Public Sub SetCoef(funstr As String, varstr As String, coef As Decimal)
        myModel.SetCoefficient(FunSList(funstr), VarSList(varstr), coef)
    End Sub

    ' Solve optimization model
    Public Sub SolveModel(funstr As String, isMin As Boolean)
        myModel.AddGoal(FunSList(funstr), 0, isMin)
        myModel.Solve(New SimplexSolverParams())
    End Sub

    'Get value of variable
    Public Function GetVarValue(varstr As String) As Decimal
        Return myModel.GetValue(VarSList(varstr)).ToDouble
    End Function

    ' Get value of function
    Public Function GetFunValue(funstr As String) As Decimal
        Return myModel.GetValue(FunSList(funstr)).ToDouble
    End Function

    ' Check optimality
    Public Function IsOptimal() As Boolean
        Return myModel.LpResult = 2
    End Function

    Public Function ShortestPath(net As Network, orig As String, dest As String,
                                      ByRef length As Decimal) As List(Of TArc)

        Dim inf As Decimal = 1000000000

        If orig = dest Then
            length = inf
            Return Nothing
        End If

        ' initialize network
        For Each a In net.ArcList.Values
            a.Flow = 0
        Next

        ' Initialize Solver
        InitSolver()

        ' Create variables
        For Each a In net.ArcList.Values
            AddVar(a.ID, 0, 1)
        Next

        ' Create Constraints
        For Each n In net.NodeList.Values
            Dim rhs As Integer
            Select Case n.ID
                Case orig
                    rhs = -1
                Case dest
                    rhs = 1
                Case Else
                    rhs = 0
            End Select
            AddFun(n.ID, rhs, rhs)
            For Each a In n.ArcsIn
                SetCoef(n.ID, a.ID, 1)
            Next
            For Each a In n.ArcsOut
                SetCoef(n.ID, a.ID, -1)
            Next
        Next

        ' Create objective and solve model
        AddObj("obj")
        For Each a In net.ArcList.Values
            SetCoef("obj", a.ID, a.Cost)
        Next
        SolveModel("obj", True)

        ' Get results
        If IsOptimal() Then
            Dim list As New List(Of TArc)
            Dim n As Node = net.NodeList(dest)
            length = 0
            Do While n.ID <> orig
                For Each a In n.ArcsIn
                    If GetVarValue(a.ID) > 0.01 Then
                        list.Insert(0, a.toTArc)
                        length += a.Cost
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
End Class
