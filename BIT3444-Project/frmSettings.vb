Public Class frmSettings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        If rdoLinearOptimization.Checked Then
            frmOutput.solveOption = True
        Else
            frmOutput.solveOption = False
        End If
    End Sub
End Class