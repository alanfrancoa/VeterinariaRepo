<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarUsuarios
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
        Me.ButtonEditUser = New System.Windows.Forms.Button()
        Me.ButtonEditNombre = New System.Windows.Forms.Button()
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.LabelAltaClientes = New System.Windows.Forms.Label()
        Me.TextBoxUser = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonEditUser
        '
        Me.ButtonEditUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditUser.Location = New System.Drawing.Point(400, 181)
        Me.ButtonEditUser.Name = "ButtonEditUser"
        Me.ButtonEditUser.Size = New System.Drawing.Size(35, 40)
        Me.ButtonEditUser.TabIndex = 39
        Me.ButtonEditUser.Text = "✏️"
        Me.ButtonEditUser.UseVisualStyleBackColor = True
        '
        'ButtonEditNombre
        '
        Me.ButtonEditNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditNombre.Location = New System.Drawing.Point(400, 126)
        Me.ButtonEditNombre.Name = "ButtonEditNombre"
        Me.ButtonEditNombre.Size = New System.Drawing.Size(35, 40)
        Me.ButtonEditNombre.TabIndex = 38
        Me.ButtonEditNombre.Text = "✏️"
        Me.ButtonEditNombre.UseVisualStyleBackColor = True
        '
        'ButtonEditar
        '
        Me.ButtonEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.ButtonEditar.Location = New System.Drawing.Point(237, 377)
        Me.ButtonEditar.Name = "ButtonEditar"
        Me.ButtonEditar.Size = New System.Drawing.Size(111, 47)
        Me.ButtonEditar.TabIndex = 37
        Me.ButtonEditar.Text = "Editar"
        Me.ButtonEditar.UseVisualStyleBackColor = True
        '
        'LabelAltaClientes
        '
        Me.LabelAltaClientes.AutoSize = True
        Me.LabelAltaClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAltaClientes.Location = New System.Drawing.Point(212, 25)
        Me.LabelAltaClientes.Name = "LabelAltaClientes"
        Me.LabelAltaClientes.Size = New System.Drawing.Size(124, 20)
        Me.LabelAltaClientes.TabIndex = 36
        Me.LabelAltaClientes.Text = "Editar Usuario"
        '
        'TextBoxUser
        '
        Me.TextBoxUser.Location = New System.Drawing.Point(152, 196)
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxUser.TabIndex = 33
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(152, 141)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxNombre.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nombre:"
        '
        'EditarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 436)
        Me.Controls.Add(Me.ButtonEditUser)
        Me.Controls.Add(Me.ButtonEditNombre)
        Me.Controls.Add(Me.ButtonEditar)
        Me.Controls.Add(Me.LabelAltaClientes)
        Me.Controls.Add(Me.TextBoxUser)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditarUsuarios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edición de Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonEditUser As Button
    Friend WithEvents ButtonEditNombre As Button
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents LabelAltaClientes As Label
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
