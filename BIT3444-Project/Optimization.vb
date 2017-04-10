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
End Class
