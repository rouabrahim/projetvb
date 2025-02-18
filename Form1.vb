Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Exemple de validation basique
        If username = "admin" AndAlso password = "admin123" Then
            MessageBox.Show("Connexion réussie en tant qu'Admin")
            Dim adminForm As New FormAdmin()
            adminForm.Show()
            Me.Hide()
        ElseIf username = "user" AndAlso password = "user123" Then
            MessageBox.Show("Connexion réussie en tant qu'Utilisateur")
            Dim userForm As New FormUser()
            userForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.")
        End If
    End Sub
End Class
