Public Class Order
    Public Property Origin As String
    Public Property Destination As String
    Public Property Path As List(Of TArc)
    Public Property length As Double

    Public Sub New()

    End Sub

    Public Sub New(orig As String, dest As String, p As List(Of TArc))
        Origin = orig
        Destination = dest
        Path = p
    End Sub
End Class
