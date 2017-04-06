Public Class Node
    Public Property ID As String
    Public Property ArcsIn As List(Of Arc)
    Public Property ArcsOut As List(Of Arc)

    'Empty/Unused default constructor
    Public Sub New()

    End Sub

    'Sets the ID property and initializes the ArcsIn and ArcsOut lists upon creation
    Public Sub New(value As String)
        ID = value
        ArcsIn = New List(Of Arc)
        ArcsOut = New List(Of Arc)
    End Sub

    'Displays the Node's ID as a string
    Public Overrides Function ToString() As String
        Dim str As String = ID
        Return str
    End Function

End Class
