Public Class Arc
    Public Property ID As String
    Public Property TailNode As Node
    Public Property HeadNode As Node
    Public Property Distance As Decimal
    Public Property Cost As Decimal
    Public Property Capacity As Integer
    Public Property Flow As Integer

    Public Sub New()

    End Sub

    'Sets the node's properties upon creation
    Public Sub New(tail As Node, head As Node, dist As Decimal, arcCost As Decimal)
        'Checks for errors
        Try
            If tail Is Nothing Or head Is Nothing Then
                Throw New Exception("Tail or head node does not exist.")
            End If
            TailNode = tail
            HeadNode = head
            Distance = dist
            Cost = arcCost
            ID = TailNode.ID & "-TO-" & HeadNode.ID
            Flow = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Arc error")
        End Try
    End Sub

    'Displays the tail and head nodes as a string
    Public Overrides Function ToString() As String
        Dim str As String = TailNode.ToString & "-TO-" & HeadNode.ToString
        Return str
    End Function

    Public Function toTArc() As TArc
        Dim newTArc As New TArc(TailNode, HeadNode)
        newTArc.ID = ID
        newTArc.Distance = Distance
        newTArc.Cost = Cost
        newTArc.Capacity = Capacity
        newTArc.Flow = Flow

        Return newTArc
    End Function
End Class
