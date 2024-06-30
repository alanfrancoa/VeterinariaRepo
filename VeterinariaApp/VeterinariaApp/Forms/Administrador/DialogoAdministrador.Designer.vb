<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogoAdministrador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxContrasenaAdmin = New System.Windows.Forms.TextBox()
        Me.TextBoxUsuarioAdmin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Por favor, ingrese usuario y contraseña de administrador para proceder."
        '
        'TextBoxContrasenaAdmin
        '
        Me.TextBoxContrasenaAdmin.Location = New System.Drawing.Point(148, 209)
        Me.TextBoxContrasenaAdmin.Name = "TextBoxContrasenaAdmin"
        Me.TextBoxContrasenaAdmin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxContrasenaAdmin.Size = New System.Drawing.Size(238, 20)
        Me.TextBoxContrasenaAdmin.TabIndex = 7
        '
        'TextBoxUsuarioAdmin
        '
        Me.TextBoxUsuarioAdmin.Location = New System.Drawing.Point(148, 147)
        Me.TextBoxUsuarioAdmin.Name = "TextBoxUsuarioAdmin"
        Me.TextBoxUsuarioAdmin.Size = New System.Drawing.Size(238, 20)
        Me.TextBoxUsuarioAdmin.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Usuario"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(187, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 48)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Proceder"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DialogoAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 361)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxContrasenaAdmin)
        Me.Controls.Add(Me.TextBoxUsuarioAdmin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogoAdministrador"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorizacion de Administrador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxContrasenaAdmin As TextBox
    Friend WithEvents TextBoxUsuarioAdmin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
