Imports System.Data.OleDb

Public Class Database
    Private myDataSet As New DataSet

    'Empty/Unused default constructor
    Public Sub New()

    End Sub

    'Returns the data adapter for accessing the database
    Public Function GetDataAdapter(mySQL As String) As OleDbDataAdapter
        Dim conStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
            Application.StartupPath & "\Database.accdb"
        Return New OleDbDataAdapter(mySQL, conStr)
    End Function

    'Returns the list of cities that can be visited
    Public Function GetNodes() As SortedList(Of String, Node)
        Dim nodes As OleDbDataAdapter
        nodes = GetDataAdapter("SELECT * FROM Cities")
        nodes.Fill(myDataSet, "Cities")

        Dim nodeSList As New SortedList(Of String, Node)
        For i As Integer = 0 To (myDataSet.Tables("Cities").Rows.Count - 1)
            Dim nodeName As String = myDataSet.Tables("Cities").Rows(i)("City")
            Dim newNode As New Node(nodeName)
            nodeSList.Add(nodeName, newNode)
        Next

        Return nodeSList
    End Function

    'Returns a list of all arcs on the map
    Public Function GetArcs(nodeList As SortedList(Of String, Node)) As SortedList(Of String, Arc)
        Dim arcs As OleDbDataAdapter
        arcs = GetDataAdapter("SELECT * FROM Arcs")
        arcs.Fill(myDataSet, "Arcs")

        Dim arcSList As New SortedList(Of String, Arc)
        For i As Integer = 0 To (myDataSet.Tables("Arcs").Rows.Count - 1)
            Dim headNode As Node = nodeList(myDataSet.Tables("Arcs").Rows(i)("Head City"))
            Dim tailNode As Node = nodeList(myDataSet.Tables("Arcs").Rows(i)("Tail City"))
            Dim distance As Double = myDataSet.Tables("Arcs").Rows(i)("Distance")
            Dim cost As Double = myDataSet.Tables("Arcs").Rows(i)("Cost")
            Dim capacity As Integer = myDataSet.Tables("Arcs").Rows(i)("Capacity")
            Dim newArc As New Arc(tailNode, headNode, distance, cost)

            tailNode.ArcsOut.Add(newArc)
            headNode.ArcsIn.Add(newArc)
            arcSList.Add(newArc.ID, newArc)
        Next

        Return arcSList
    End Function
End Class
