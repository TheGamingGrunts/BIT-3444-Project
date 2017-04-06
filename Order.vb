Public Class Order
    Public Property Origin As String
    Public Property Destination As String
    Public Property Path As List(Of Arc)
    Public Property length As Double

    Public Sub New()

    End Sub

    Public Sub New(orig As String, dest As String, p As List(Of Arc), len As Double)
        Origin = orig
        Destination = dest
        Path = p
        length = len
    End Sub
End Class
