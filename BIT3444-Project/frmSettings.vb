Public Class frmSettings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Apply the settings input by the user
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        If rdoLinearOptimization.Checked Then
            frmOrderQueue.solveOption = True
        Else
            frmOrderQueue.solveOption = False
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class