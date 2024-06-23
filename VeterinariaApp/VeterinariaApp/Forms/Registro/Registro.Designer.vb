<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.UsuarioLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContraseniaLabel = New System.Windows.Forms.Label()
        Me.TextBoxContrasenia = New System.Windows.Forms.TextBox()
        Me.RepetirLabel = New System.Windows.Forms.Label()
        Me.TextBoxRepetir = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BotonLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(255, 90)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(280, 20)
        Me.TextBoxNombre.TabIndex = 0
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(252, 74)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(47, 13)
        Me.NombreLabel.TabIndex = 1
        Me.NombreLabel.Text = "Nombre:"
        '
        'UsuarioLabel
        '
        Me.UsuarioLabel.AutoSize = True
        Me.UsuarioLabel.Location = New System.Drawing.Point(252, 121)
        Me.UsuarioLabel.Name = "UsuarioLabel"
        Me.UsuarioLabel.Size = New System.Drawing.Size(103, 13)
        Me.UsuarioLabel.TabIndex = 3
        Me.UsuarioLabel.Text = "Nombre De Usuario:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(255, 137)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 20)
        Me.TextBox1.TabIndex = 2
        '
        'ContraseniaLabel
        '
        Me.ContraseniaLabel.AutoSize = True
        Me.ContraseniaLabel.Location = New System.Drawing.Point(252, 167)
        Me.ContraseniaLabel.Name = "ContraseniaLabel"
        Me.ContraseniaLabel.Size = New System.Drawing.Size(64, 13)
        Me.ContraseniaLabel.TabIndex = 5
        Me.ContraseniaLabel.Text = "Contraseña:"
        '
        'TextBoxContrasenia
        '
        Me.TextBoxContrasenia.Location = New System.Drawing.Point(255, 183)
        Me.TextBoxContrasenia.Name = "TextBoxContrasenia"
        Me.TextBoxContrasenia.Size = New System.Drawing.Size(280, 20)
        Me.TextBoxContrasenia.TabIndex = 4
        '
        'RepetirLabel
        '
        Me.RepetirLabel.AutoSize = True
        Me.RepetirLabel.Location = New System.Drawing.Point(252, 211)
        Me.RepetirLabel.Name = "RepetirLabel"
        Me.RepetirLabel.Size = New System.Drawing.Size(101, 13)
        Me.RepetirLabel.TabIndex = 7
        Me.RepetirLabel.Text = "Repetir Contraseña:"
        '
        'TextBoxRepetir
        '
        Me.TextBoxRepetir.Location = New System.Drawing.Point(255, 227)
        Me.TextBoxRepetir.Name = "TextBoxRepetir"
        Me.TextBoxRepetir.Size = New System.Drawing.Size(280, 20)
        Me.TextBoxRepetir.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(316, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 52)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BotonLogin
        '
        Me.BotonLogin.Location = New System.Drawing.Point(349, 341)
        Me.BotonLogin.Name = "BotonLogin"
        Me.BotonLogin.Size = New System.Drawing.Size(92, 38)
        Me.BotonLogin.TabIndex = 9
        Me.BotonLogin.Text = "Iniciar Sesión"
        Me.BotonLogin.UseVisualStyleBackColor = True
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BotonLogin)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RepetirLabel)
        Me.Controls.Add(Me.TextBoxRepetir)
        Me.Controls.Add(Me.ContraseniaLabel)
        Me.Controls.Add(Me.TextBoxContrasenia)
        Me.Controls.Add(Me.UsuarioLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.NombreLabel)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Name = "Registro"
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents NombreLabel As Label
    Friend WithEvents UsuarioLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ContraseniaLabel As Label
    Friend WithEvents TextBoxContrasenia As TextBox
    Friend WithEvents RepetirLabel As Label
    Friend WithEvents TextBoxRepetir As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BotonLogin As Button
End Class
