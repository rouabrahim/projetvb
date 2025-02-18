<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgvVols = New DataGridView()
        txtNumero = New TextBox()
        txtPlaces = New TextBox()
        dtpDateHeure = New TextBox()
        txtDestination = New TextBox()
        btnAjouter = New Button()
        btnModifier = New Button()
        btnSupprimer = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(dgvVols, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvVols
        ' 
        dgvVols.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVols.Location = New Point(95, 283)
        dgvVols.Name = "dgvVols"
        dgvVols.RowHeadersWidth = 51
        dgvVols.Size = New Size(454, 188)
        dgvVols.TabIndex = 0
        ' 
        ' txtNumero
        ' 
        txtNumero.Location = New Point(114, 52)
        txtNumero.Name = "txtNumero"
        txtNumero.Size = New Size(125, 27)
        txtNumero.TabIndex = 1
        ' 
        ' txtPlaces
        ' 
        txtPlaces.Location = New Point(114, 200)
        txtPlaces.Name = "txtPlaces"
        txtPlaces.Size = New Size(125, 27)
        txtPlaces.TabIndex = 2
        ' 
        ' dtpDateHeure
        ' 
        dtpDateHeure.Location = New Point(114, 150)
        dtpDateHeure.Name = "dtpDateHeure"
        dtpDateHeure.Size = New Size(125, 27)
        dtpDateHeure.TabIndex = 3
        ' 
        ' txtDestination
        ' 
        txtDestination.Location = New Point(114, 99)
        txtDestination.Name = "txtDestination"
        txtDestination.Size = New Size(125, 27)
        txtDestination.TabIndex = 4
        ' 
        ' btnAjouter
        ' 
        btnAjouter.Location = New Point(125, 502)
        btnAjouter.Name = "btnAjouter"
        btnAjouter.Size = New Size(94, 29)
        btnAjouter.TabIndex = 5
        btnAjouter.Text = "Ajouter"
        btnAjouter.UseVisualStyleBackColor = True
        ' 
        ' btnModifier
        ' 
        btnModifier.Location = New Point(268, 502)
        btnModifier.Name = "btnModifier"
        btnModifier.Size = New Size(94, 29)
        btnModifier.TabIndex = 6
        btnModifier.Text = "Modifier"
        btnModifier.UseVisualStyleBackColor = True
        ' 
        ' btnSupprimer
        ' 
        btnSupprimer.Location = New Point(428, 502)
        btnSupprimer.Name = "btnSupprimer"
        btnSupprimer.Size = New Size(94, 29)
        btnSupprimer.TabIndex = 7
        btnSupprimer.Text = "Supprimer"
        btnSupprimer.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 8
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 9
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 10
        Label3.Text = "Label3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 11
        Label4.Text = "Label4"
        ' 
        ' FormAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 585)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSupprimer)
        Controls.Add(btnModifier)
        Controls.Add(btnAjouter)
        Controls.Add(txtDestination)
        Controls.Add(dtpDateHeure)
        Controls.Add(txtPlaces)
        Controls.Add(txtNumero)
        Controls.Add(dgvVols)
        Name = "FormAdmin"
        Text = "FormAdmin"
        CType(dgvVols, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvVols As DataGridView
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtPlaces As TextBox
    Friend WithEvents dtpDateHeure As TextBox
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
