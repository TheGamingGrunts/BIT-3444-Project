Public Class Arc
    Public Property ID As String
    Public Property TailNode As Node
    Public Property HeadNode As Node
    Public Property Distance As Decimal
    Public Property Cost As Decimal
    Public Property Capacity As Integer

    'Empty/Unused default constructor
    Public Sub New()

    End Sub

    'Sets the node's properties upon creation
    Public Sub New(tail As Node, head As Node, dist As Decimal, cost As Decimal)
        'Checks for errors
        Try
            If tail Is Nothing Or head Is Nothing Then
                Throw New Exception("Tail or head node does not exist.")
            End If
            TailNode = tail
            HeadNode = head
            Distance = dist
            cost = cost
            ID = TailNode.ID & "-TO-" & HeadNode.ID
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Arc error")
        End Try
    End Sub

    'Displays the tail and head nodes as a string
    Public Overrides Function ToString() As String
        Dim str As String = TailNode.ToString & "-TO-" & HeadNode.ToString
        Return str
    End Function
End Class
