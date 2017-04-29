Public Class Order
    Public Property ID As String
    Public Property Origin As String
    Public Property Destination As String
    Public Property Path As List(Of TArc)
    Public Property Length As Double
    Public Property Delivered As Boolean

    Public Sub New(idNum As String, orig As String, dest As String)
        ID = idNum
        Origin = orig
        Destination = dest
        delivered = False
    End Sub

    Public Sub New(idNum As String, orig As String, dest As String, p As List(Of TArc), len As Double)
        Origin = orig
        Destination = dest
        Path = p
        Length = len
    End Sub
    Public Sub New(orig As String, dest As String, p As List(Of TArc))
        Origin = orig
        Destination = dest
        Path = p
    End Sub

    Public Overrides Function ToString() As String
        Dim str As String = "Order #" & ID
        Return str
    End Function
End Class
