Public Class TArc

    Inherits Arc

    Public Property PathList As New List(Of String())

    Public Sub New()

    End Sub

    Public Sub New(t As Node, h As Node)
        MyBase.New(t, h, 0, 0)
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString & ", Trans Paths: " & PathList.Count
    End Function

End Class
