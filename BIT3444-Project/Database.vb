Imports System.Data.OleDb

Public Class Database
    Private myDataSet As New DataSet
    Private nodesDA As OleDbDataAdapter
    Private arcsDA As OleDbDataAdapter
    Private ordersDA As OleDbDataAdapter

    Public Sub New()
        nodesDA = GetDataAdapter("SELECT * FROM Cities")
        nodesDA.Fill(myDataSet, "Cities")

        arcsDA = GetDataAdapter("SELECT * FROM Arcs")
        arcsDA.Fill(myDataSet, "Arcs")

        ordersDA = GetDataAdapter("SELECT * FROM Orders")
        ordersDA.Fill(myDataSet, "Orders")
    End Sub

    'Returns the data adapter for accessing the database
    Public Function GetDataAdapter(mySQL As String) As OleDbDataAdapter
        Dim conStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
            Application.StartupPath & "\Database.accdb"
        Return New OleDbDataAdapter(mySQL, conStr)
    End Function

    'Returns the list of cities that can be visited
    Public Function GetNodes() As SortedList(Of String, Node)
        Dim nodeSList As New SortedList(Of String, Node)
        For i As Integer = 0 To (myDataSet.Tables("Cities").Rows.Count - 1)
            Dim nodeName As String = myDataSet.Tables("Cities").Rows(i)("City")
            Dim newNode As New Node(nodeName)
            'newNode.Xcoord = myDataSet.Tables("Cities").Rows(i)("X-Coord")
            'newNode.Ycoord = myDataSet.Tables("Cities").Rows(i)("Y-Coord")
            nodeSList.Add(nodeName, newNode)
        Next

        Return nodeSList
    End Function

    Public Function GetOrders() As List(Of Order)
        Dim orders As New List(Of Order)
        For i As Integer = 0 To (myDataSet.Tables("Orders").Rows.Count - 1)
            orders.Add(New Order(myDataSet.Tables("Orders").Rows(i)("From"),
                                 myDataSet.Tables("Orders").Rows(i)("Destination"),
                                 New List(Of TArc)))
        Next
        Return orders
    End Function

    'Returns a list of all arcs on the map
    Public Function GetArcs(nodeList As SortedList(Of String, Node)) As SortedList(Of String, Arc)
        Dim arcSList As New SortedList(Of String, Arc)
        For i As Integer = 0 To (myDataSet.Tables("Arcs").Rows.Count - 1)
            Dim headNode As Node = nodeList(myDataSet.Tables("Arcs").Rows(i)("Head"))
            Dim tailNode As Node = nodeList(myDataSet.Tables("Arcs").Rows(i)("Tail"))
            Dim distance As Double = myDataSet.Tables("Arcs").Rows(i)("Distance")
            Dim cost As Double = myDataSet.Tables("Arcs").Rows(i)("Cost")
            'Dim capacity As Integer = myDataSet.Tables("Arcs").Rows(i)("Capacity")
            Dim newArc As New Arc(tailNode, headNode, distance, cost)

            tailNode.ArcsOut.Add(newArc)
            headNode.ArcsIn.Add(newArc)
            arcSList.Add(newArc.ID, newArc)
        Next

        Return arcSList
    End Function

    Public Function GetNumNodes() As Integer
        Return myDataSet.Tables("Cities").Rows.Count
    End Function

    Public Function GetNumArcs() As Integer
        Return myDataSet.Tables("Arcs").Rows.Count
    End Function

    Public Function GetNodeName(id As Integer) As String
        Dim r() As DataRow = myDataSet.Tables("Cities").Select("ID = " & id)
        If r.Length > 0 Then
            Return r(0)("City")
        Else
            Return Nothing
        End If
    End Function

    Public Function GetNodeID(name As String) As Integer
        Dim r() As DataRow = myDataSet.Tables("Cities").Select("City = '" & name & "'")
        If r.Length > 0 Then
            Return r(0)("ID")
        Else
            Return -1
        End If
    End Function

    Public Function GetDistance(name1 As String, name2 As String) As Decimal
        Dim i1 As Integer = GetNodeID(name1)
        Dim i2 As Integer = GetNodeID(name2)
        Dim r() As DataRow = myDataSet.Tables("Arcs").Select("Tail = '" & i1 & "' AND Head = '" & i2 & "'")
        If r.Length > 0 Then
            Return r(0)("Distance")
        Else
            Return -1
        End If
    End Function

    Public Sub ModifyArc(name1 As String, name2 As String, dist As Decimal)
        Dim i1 As Integer = GetNodeID(name1)
        Dim i2 As Integer = GetNodeID(name2)
        Dim r() As DataRow = myDataSet.Tables("Arcs").Select("Tail = " & i1 & " AND Head = " & i2)
        r(0).BeginEdit()
        r(0)("Distance") = dist
        r(0).EndEdit()
    End Sub

    Public Sub UpdateDatabase()
        Dim myCommandBuilder As New OleDbCommandBuilder(arcsDA)

        arcsDA.UpdateCommand = myCommandBuilder.GetUpdateCommand
        arcsDA.InsertCommand = myCommandBuilder.GetInsertCommand
        arcsDA.DeleteCommand = myCommandBuilder.GetDeleteCommand

        Dim updateCount As Integer = arcsDA.Update(myDataSet.Tables("Arcs"))
        MessageBox.Show(updateCount & " records updated.")

    End Sub
End Class

