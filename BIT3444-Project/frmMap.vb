Public Class frmMap
    Public MapImage As Image = My.Resources.map
    Public Net As Network
    Public Origin As String
    Public Destination As String
    Public Path As List(Of TArc)

    ' Draws a node with given size and text at given coordinates, 
    ' and with given border, fill and text format
    Public Sub DrawNode(size As Integer, text As String,
                        xcoord As Integer, ycoord As Integer, filled As Boolean,
                        borderpen As Pen, fillbrush As Brush, textbrush As Brush,
                        e As PaintEventArgs)

        ' offsetting the center of the node to be the coordinates of the node
        Dim x As Integer = xcoord - size / 2
        Dim y As Integer = ycoord - size / 2

        ' creating the borders and the fill for the node
        e.Graphics.FillEllipse(fillbrush, x, y, size, size)
        e.Graphics.DrawEllipse(borderpen, x, y, size, size)


        ' setting font properties of the text
        Dim fontsize As Integer = size / 3
        Dim aFont As New System.Drawing.Font("Courier New", fontsize, FontStyle.Bold)

        ' offsetting the center of text to match the middle of node
        Dim textwidth As Integer = text.Count * (fontsize)
        Dim tx As Integer = xcoord - textwidth / 2
        Dim ty As Integer = ycoord - aFont.GetHeight() / 2

        ' creating text
        e.Graphics.DrawString(text, aFont, textbrush, tx, ty)

    End Sub

    ' the Paint event for the form
    Private Sub frmMap_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        ' resize ratios for scaling x and y coordinates
        Dim xscale As Decimal = Me.ClientRectangle.Width / MapImage.Width
        Dim yscale As Decimal = Me.ClientRectangle.Height / MapImage.Height

        e.Graphics.Clear(Color.White) 'clearing the background map
        Dim rect As New Rectangle(0, 0, MapImage.Width, MapImage.Height)
        e.Graphics.DrawImage(MapImage, Me.ClientRectangle, rect, GraphicsUnit.Pixel)
        Me.BackgroundImageLayout = ImageLayout.Stretch

        If Net Is Nothing Then
            Exit Sub
        End If

        ' setting properties of pen to draw arcs
        Dim arcpen As New Pen(Color.Gray)
        arcpen.Width = 2

        ' creating all arcs in Network
        For Each a As Arc In Net.ArcList.Values
            e.Graphics.DrawLine(arcpen, xscale * a.TailNode.Xcoord, yscale * a.TailNode.Ycoord,
                xscale * a.HeadNode.Xcoord, yscale * a.HeadNode.Ycoord)
        Next

        ' setting properties of pen to draw flow arcs
        Dim flowpen As New Pen(Color.Black)
        flowpen.Width = 6

        ' creating flow arcs from the flows list
        For Each a In Path
            e.Graphics.DrawLine(flowpen, xscale * a.TailNode.Xcoord, yscale * a.TailNode.Ycoord,
            xscale * a.HeadNode.Xcoord, yscale * a.HeadNode.Ycoord)
        Next

        ' IMPORTANT NODE: Nodes should be created after ALL arcs are created.
        ' setting properties of border pen
        Dim borderpen As New Pen(Color.Black)
        borderpen.Width = 2

        ' setting properties of fill brush and font brush
        Dim fillbrush As New SolidBrush(Color.White)
        Dim fontbrush As New SolidBrush(Color.Black)


        Dim orig = Net.NodeList(Origin)
        Dim dest = Net.NodeList(Destination)

        ' creating all nodes
        For Each n As Node In Net.NodeList.Values
            If n.ID = orig.ID Then ' source node is blue with white font
                fillbrush.Color = Color.Blue
                fontbrush.Color = Color.Black
            ElseIf n.ID = dest.ID Then ' destination node is red with white font
                fillbrush.Color = Color.Red
                fontbrush.Color = Color.Black
            End If

            Dim minscale As Decimal = xscale
            If yscale < xscale Then
                minscale = yscale
            End If
            ' creating the node by calling DrawNode
            DrawNode(minscale * 30, n.ID, xscale * n.Xcoord, yscale * n.Ycoord, False,
            borderpen, fillbrush, fontbrush, e)
            ' resetting fill brush to white and font brush to black 

            fillbrush.Color = Color.White
            fontbrush.Color = Color.Black
        Next
    End Sub

    Private Sub frmMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class