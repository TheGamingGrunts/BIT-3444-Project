Public Class frmAddOrder
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'frmOutput.orderList.Add(New Order(txtOrigin, txtDestination, t))
        Me.Close()
    End Sub
End Class