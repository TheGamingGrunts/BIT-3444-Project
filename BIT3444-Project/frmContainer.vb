Public Class frmContainer
    Public Property map As New frmMap

    Private Sub frmContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spcMain.Dock = DockStyle.Fill

        Dim output As New frmOrderQueue
        output.MdiParent = Me
        spcMain.Panel1.Controls.Add(output)
        output.WindowState = FormWindowState.Maximized
        output.Show()

        map.MdiParent = Me
        spcMain.Panel2.Controls.Add(map)
        map.WindowState = FormWindowState.Maximized
        map.Show()
    End Sub

End Class