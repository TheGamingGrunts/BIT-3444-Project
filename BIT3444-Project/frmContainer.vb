Public Class frmContainer
    Private Sub frmContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spcMain.Dock = DockStyle.Fill

        Dim output As New frmOrderQueue
        output.MdiParent = Me
        spcMain.Panel1.Controls.Add(output)
        output.WindowState = FormWindowState.Maximized
        output.Show()

        Dim map As New frmMap
        map.MdiParent = Me
        spcMain.Panel2.Controls.Add(map)
        map.WindowState = FormWindowState.Maximized
        map.Show()
    End Sub
End Class