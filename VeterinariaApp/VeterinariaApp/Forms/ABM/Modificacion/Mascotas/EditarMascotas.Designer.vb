<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarMascotas
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
        Me.ButtonBuscarEspecie = New System.Windows.Forms.Button()
        Me.ButtonEditFecha = New System.Windows.Forms.Button()
        Me.ButtonEditPeso = New System.Windows.Forms.Button()
        Me.ButtonEditNombre = New System.Windows.Forms.Button()
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.LabelAltaClientes = New System.Windows.Forms.Label()
        Me.TextBoxEspecieID = New System.Windows.Forms.TextBox()
        Me.TextBoxFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.TextBoxPeso = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonBuscarCliente = New System.Windows.Forms.Button()
        Me.TextBoxClienteID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonEditarEspecie = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonBuscarEspecie
        '
        Me.ButtonBuscarEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscarEspecie.Location = New System.Drawing.Point(359, 241)
        Me.ButtonBuscarEspecie.Name = "ButtonBuscarEspecie"
        Me.ButtonBuscarEspecie.Size = New System.Drawing.Size(35, 40)
        Me.ButtonBuscarEspecie.TabIndex = 41
        Me.ButtonBuscarEspecie.Text = "🔍"
        Me.ButtonBuscarEspecie.UseVisualStyleBackColor = True
        '
        'ButtonEditFecha
        '
        Me.ButtonEditFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditFecha.Location = New System.Drawing.Point(400, 186)
        Me.ButtonEditFecha.Name = "ButtonEditFecha"
        Me.ButtonEditFecha.Size = New System.Drawing.Size(35, 40)
        Me.ButtonEditFecha.TabIndex = 40
        Me.ButtonEditFecha.Text = "✏️"
        Me.ButtonEditFecha.UseVisualStyleBackColor = True
        '
        'ButtonEditPeso
        '
        Me.ButtonEditPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditPeso.Location = New System.Drawing.Point(400, 131)
        Me.ButtonEditPeso.Name = "ButtonEditPeso"
        Me.ButtonEditPeso.Size = New System.Drawing.Size(35, 40)
        Me.ButtonEditPeso.TabIndex = 39
        Me.ButtonEditPeso.Text = "✏️"
        Me.ButtonEditPeso.UseVisualStyleBackColor = True
        '
        'ButtonEditNombre
        '
        Me.ButtonEditNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditNombre.Location = New System.Drawing.Point(400, 76)
        Me.ButtonEditNombre.Name = "ButtonEditNombre"
        Me.ButtonEditNombre.Size = New System.Drawing.Size(35, 40)
        Me.ButtonEditNombre.TabIndex = 38
        Me.ButtonEditNombre.Text = "✏️"
        Me.ButtonEditNombre.UseVisualStyleBackColor = True
        '
        'ButtonEditar
        '
        Me.ButtonEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.ButtonEditar.Location = New System.Drawing.Point(231, 377)
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
        Me.LabelAltaClientes.Size = New System.Drawing.Size(130, 20)
        Me.LabelAltaClientes.TabIndex = 36
        Me.LabelAltaClientes.Text = "Editar Mascota"
        '
        'TextBoxEspecieID
        '
        Me.TextBoxEspecieID.Location = New System.Drawing.Point(152, 256)
        Me.TextBoxEspecieID.Name = "TextBoxEspecieID"
        Me.TextBoxEspecieID.Size = New System.Drawing.Size(190, 20)
        Me.TextBoxEspecieID.TabIndex = 35
        '
        'TextBoxFechaNacimiento
        '
        Me.TextBoxFechaNacimiento.Location = New System.Drawing.Point(152, 201)
        Me.TextBoxFechaNacimiento.Name = "TextBoxFechaNacimiento"
        Me.TextBoxFechaNacimiento.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxFechaNacimiento.TabIndex = 34
        '
        'TextBoxPeso
        '
        Me.TextBoxPeso.Location = New System.Drawing.Point(152, 146)
        Me.TextBoxPeso.Name = "TextBoxPeso"
        Me.TextBoxPeso.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxPeso.TabIndex = 33
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(152, 91)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxNombre.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Especie:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Fecha de Nacimiento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Peso:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nombre:"
        '
        'ButtonBuscarCliente
        '
        Me.ButtonBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscarCliente.Location = New System.Drawing.Point(359, 300)
        Me.ButtonBuscarCliente.Name = "ButtonBuscarCliente"
        Me.ButtonBuscarCliente.Size = New System.Drawing.Size(35, 40)
        Me.ButtonBuscarCliente.TabIndex = 44
        Me.ButtonBuscarCliente.Text = "🔍"
        Me.ButtonBuscarCliente.UseVisualStyleBackColor = True
        '
        'TextBoxClienteID
        '
        Me.TextBoxClienteID.Location = New System.Drawing.Point(152, 315)
        Me.TextBoxClienteID.Name = "TextBoxClienteID"
        Me.TextBoxClienteID.Size = New System.Drawing.Size(190, 20)
        Me.TextBoxClienteID.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Cliente:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(400, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 40)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "✏️"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtonEditarEspecie
        '
        Me.ButtonEditarEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditarEspecie.Location = New System.Drawing.Point(400, 241)
        Me.ButtonEditarEspecie.Name = "ButtonEditarEspecie"
        Me.ButtonEditarEspecie.Size = New System.Drawing.Size(35, 40)
        Me.ButtonEditarEspecie.TabIndex = 45
        Me.ButtonEditarEspecie.Text = "✏️"
        Me.ButtonEditarEspecie.UseVisualStyleBackColor = True
        '
        'EditarMascotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 436)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonEditarEspecie)
        Me.Controls.Add(Me.ButtonBuscarCliente)
        Me.Controls.Add(Me.TextBoxClienteID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonBuscarEspecie)
        Me.Controls.Add(Me.ButtonEditFecha)
        Me.Controls.Add(Me.ButtonEditPeso)
        Me.Controls.Add(Me.ButtonEditNombre)
        Me.Controls.Add(Me.ButtonEditar)
        Me.Controls.Add(Me.LabelAltaClientes)
        Me.Controls.Add(Me.TextBoxEspecieID)
        Me.Controls.Add(Me.TextBoxFechaNacimiento)
        Me.Controls.Add(Me.TextBoxPeso)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditarMascotas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edición de Mascotas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonBuscarEspecie As Button
    Friend WithEvents ButtonEditFecha As Button
    Friend WithEvents ButtonEditPeso As Button
    Friend WithEvents ButtonEditNombre As Button
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents LabelAltaClientes As Label
    Friend WithEvents TextBoxEspecieID As TextBox
    Friend WithEvents TextBoxFechaNacimiento As TextBox
    Friend WithEvents TextBoxPeso As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonBuscarCliente As Button
    Friend WithEvents TextBoxClienteID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ButtonEditarEspecie As Button
End Class
