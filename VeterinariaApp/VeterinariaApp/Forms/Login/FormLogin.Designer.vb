<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.TextBoxContrasena = New System.Windows.Forms.TextBox()
        Me.ButtonIr = New System.Windows.Forms.Button()
        Me.ButtonRegistro = New System.Windows.Forms.Button()
        Me.ProgressBarLogin = New System.Windows.Forms.ProgressBar()
        Me.TimerBar = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.Location = New System.Drawing.Point(85, 78)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(238, 20)
        Me.TextBoxUsuario.TabIndex = 2
        '
        'TextBoxContrasena
        '
        Me.TextBoxContrasena.Location = New System.Drawing.Point(85, 140)
        Me.TextBoxContrasena.Name = "TextBoxContrasena"
        Me.TextBoxContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxContrasena.Size = New System.Drawing.Size(238, 20)
        Me.TextBoxContrasena.TabIndex = 3
        '
        'ButtonIr
        '
        Me.ButtonIr.Location = New System.Drawing.Point(103, 205)
        Me.ButtonIr.Name = "ButtonIr"
        Me.ButtonIr.Size = New System.Drawing.Size(176, 44)
        Me.ButtonIr.TabIndex = 4
        Me.ButtonIr.Text = "Ir"
        Me.ButtonIr.UseVisualStyleBackColor = True
        '
        'ButtonRegistro
        '
        Me.ButtonRegistro.Location = New System.Drawing.Point(103, 255)
        Me.ButtonRegistro.Name = "ButtonRegistro"
        Me.ButtonRegistro.Size = New System.Drawing.Size(176, 44)
        Me.ButtonRegistro.TabIndex = 5
        Me.ButtonRegistro.Text = "Registro"
        Me.ButtonRegistro.UseVisualStyleBackColor = True
        '
        'ProgressBarLogin
        '
        Me.ProgressBarLogin.Location = New System.Drawing.Point(85, 228)
        Me.ProgressBarLogin.Name = "ProgressBarLogin"
        Me.ProgressBarLogin.Size = New System.Drawing.Size(238, 44)
        Me.ProgressBarLogin.TabIndex = 6
        Me.ProgressBarLogin.Visible = False
        '
        'TimerBar
        '
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 361)
        Me.Controls.Add(Me.ProgressBarLogin)
        Me.Controls.Add(Me.ButtonRegistro)
        Me.Controls.Add(Me.ButtonIr)
        Me.Controls.Add(Me.TextBoxContrasena)
        Me.Controls.Add(Me.TextBoxUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents TextBoxContrasena As TextBox
    Friend WithEvents ButtonIr As Button
    Friend WithEvents ButtonRegistro As Button
    Friend WithEvents ProgressBarLogin As ProgressBar
    Friend WithEvents TimerBar As Timer
End Class
