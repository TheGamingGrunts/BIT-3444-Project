﻿Public Class frmOutput

    Dim myDatabase As Database
    Dim arcSortedList As SortedList(Of String, Arc)
    Dim nodeSortedList As SortedList(Of String, Node)
    Dim orderList As List(Of Order)

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
End Class