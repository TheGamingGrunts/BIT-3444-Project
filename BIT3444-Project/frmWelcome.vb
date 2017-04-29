Public Class frmWelcome

    Private users As SortedList(Of String, String)
    Dim myDatabase As Database

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myDatabase = New Database
        users = myDatabase.getUsers()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        For Each u In users
            If txtUsername.Text = u.Key Then
                If txtPassword.Text = u.Value Then
                    frmContainer.Show()
                    Exit Sub
                End If
            End If
        Next

        MessageBox.Show("Invalid User Information", "Login Error")
    End Sub
End Class