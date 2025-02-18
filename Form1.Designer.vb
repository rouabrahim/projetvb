<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnLogin = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(164, 45)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(125, 27)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(164, 104)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(125, 27)
        txtPassword.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 20)
        Label1.TabIndex = 2
        Label1.Text = "Nom d'utilisateur"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(39, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 20)
        Label2.TabIndex = 3
        Label2.Text = "Mot de Passe"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(101, 314)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Connecter"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(241, 314)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 5
        Button2.Text = "Quitter"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(btnLogin)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Name = "FormLogin"
        Text = "FormLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Button2 As Button

End Class
