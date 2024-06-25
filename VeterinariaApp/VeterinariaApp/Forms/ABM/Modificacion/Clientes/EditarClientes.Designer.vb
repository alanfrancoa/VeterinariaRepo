<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarClientes
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
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.LabelAltaClientes = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.TextBoxDNI = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonEditNombre = New System.Windows.Forms.Button()
        Me.ButtonEditDNI = New System.Windows.Forms.Button()
        Me.ButtonEditTelefono = New System.Windows.Forms.Button()
        Me.ButtonEditMail = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonEditar
        '
        Me.ButtonEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.ButtonEditar.Location = New System.Drawing.Point(233, 320)
        Me.ButtonEditar.Name = "ButtonEditar"
        Me.ButtonEditar.Size = New System.Drawing.Size(111, 47)
        Me.ButtonEditar.TabIndex = 21
        Me.ButtonEditar.Text = "Editar"
        Me.ButtonEditar.UseVisualStyleBackColor = True
        '
        'LabelAltaClientes
        '
        Me.LabelAltaClientes.AutoSize = True
        Me.LabelAltaClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAltaClientes.Location = New System.Drawing.Point(229, 30)
        Me.LabelAltaClientes.Name = "LabelAltaClientes"
        Me.LabelAltaClientes.Size = New System.Drawing.Size(118, 20)
        Me.LabelAltaClientes.TabIndex = 20
        Me.LabelAltaClientes.Text = "Editar Cliente"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(169, 267)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxEmail.TabIndex = 19
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(169, 212)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxTelefono.TabIndex = 18
        '
        'TextBoxDNI
        '
        Me.TextBoxDNI.Location = New System.Drawing.Point(169, 157)
        Me.TextBoxDNI.Name = "TextBoxDNI"
        Me.TextBoxDNI.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxDNI.TabIndex = 17
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(169, 102)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxNombre.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "E-Mail:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Telefono:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "DNI:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre:"
        '
        'ButtonEditNombre
        '
        Me.ButtonEditNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditNombre.Location = New System.Drawing.Point(417, 87)
        Me.ButtonEditNombre.Name = "ButtonEditNombre"
        Me.ButtonEditNombre.Size = New System.Drawing.Size(35, 40)
        Me.ButtonEditNombre.TabIndex = 24
        Me.ButtonEditNombre.Text = "✏️"
        Me.ButtonEditNombre.UseVisualStyleBackColor = True
        '
        'ButtonEditDNI
        '
        Me.ButtonEditDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditDNI.Location = New System.Drawing.Point(417, 142)
        Me.ButtonEditDNI.Name = "ButtonEditDNI"
        Me.ButtonEditDNI.Size = New System.Drawing.Size(35, 40)
        Me.ButtonEditDNI.TabIndex = 25
        Me.ButtonEditDNI.Text = "✏️"
        Me.ButtonEditDNI.UseVisualStyleBackColor = True
        '
        'ButtonEditTelefono
        '
        Me.ButtonEditTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditTelefono.Location = New System.Drawing.Point(417, 197)
        Me.ButtonEditTelefono.Name = "ButtonEditTelefono"
        Me.ButtonEditTelefono.Size = New System.Drawing.Size(35, 40)
        Me.ButtonEditTelefono.TabIndex = 26
        Me.ButtonEditTelefono.Text = "✏️"
        Me.ButtonEditTelefono.UseVisualStyleBackColor = True
        '
        'ButtonEditMail
        '
        Me.ButtonEditMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditMail.Location = New System.Drawing.Point(417, 252)
        Me.ButtonEditMail.Name = "ButtonEditMail"
        Me.ButtonEditMail.Size = New System.Drawing.Size(35, 40)
        Me.ButtonEditMail.TabIndex = 27
        Me.ButtonEditMail.Text = "✏️"
        Me.ButtonEditMail.UseVisualStyleBackColor = True
        '
        'EditarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 386)
        Me.Controls.Add(Me.ButtonEditMail)
        Me.Controls.Add(Me.ButtonEditTelefono)
        Me.Controls.Add(Me.ButtonEditDNI)
        Me.Controls.Add(Me.ButtonEditNombre)
        Me.Controls.Add(Me.ButtonEditar)
        Me.Controls.Add(Me.LabelAltaClientes)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxTelefono)
        Me.Controls.Add(Me.TextBoxDNI)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditarClientes"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonEditar As Button
    Friend WithEvents LabelAltaClientes As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents TextBoxDNI As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonEditNombre As Button
    Friend WithEvents ButtonEditDNI As Button
    Friend WithEvents ButtonEditTelefono As Button
    Friend WithEvents ButtonEditMail As Button
End Class
