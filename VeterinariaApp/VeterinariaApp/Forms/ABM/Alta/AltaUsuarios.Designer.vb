<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaUsuarios
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelAltaUsuarios = New System.Windows.Forms.Label()
        Me.TextBoxConfirmClave = New System.Windows.Forms.TextBox()
        Me.TextBoxClave = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button1.Location = New System.Drawing.Point(282, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 47)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelAltaUsuarios
        '
        Me.LabelAltaUsuarios.AutoSize = True
        Me.LabelAltaUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAltaUsuarios.Location = New System.Drawing.Point(278, 42)
        Me.LabelAltaUsuarios.Name = "LabelAltaUsuarios"
        Me.LabelAltaUsuarios.Size = New System.Drawing.Size(117, 20)
        Me.LabelAltaUsuarios.TabIndex = 20
        Me.LabelAltaUsuarios.Text = "Alta Usuarios"
        '
        'TextBoxConfirmClave
        '
        Me.TextBoxConfirmClave.Location = New System.Drawing.Point(215, 224)
        Me.TextBoxConfirmClave.Name = "TextBoxConfirmClave"
        Me.TextBoxConfirmClave.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxConfirmClave.TabIndex = 19
        '
        'TextBoxClave
        '
        Me.TextBoxClave.Location = New System.Drawing.Point(215, 181)
        Me.TextBoxClave.Name = "TextBoxClave"
        Me.TextBoxClave.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxClave.TabIndex = 18
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(215, 141)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxNombre.TabIndex = 17
        '
        'TextBoxUser
        '
        Me.TextBoxUser.Location = New System.Drawing.Point(215, 100)
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxUser.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Confirmar Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(212, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Username:"
        '
        'AltaUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 375)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelAltaUsuarios)
        Me.Controls.Add(Me.TextBoxConfirmClave)
        Me.Controls.Add(Me.TextBoxClave)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.TextBoxUser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AltaUsuarios"
        Me.Text = "AltaUsuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents LabelAltaUsuarios As Label
    Friend WithEvents TextBoxConfirmClave As TextBox
    Friend WithEvents TextBoxClave As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
