<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarEspecie
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxE_Madurez = New System.Windows.Forms.TextBox()
        Me.TextBoxP_Prom = New System.Windows.Forms.TextBox()
        Me.LabelAltaClientes = New System.Windows.Forms.Label()
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.ButtonEditNombre = New System.Windows.Forms.Button()
        Me.ButtonEditE_Madurez = New System.Windows.Forms.Button()
        Me.ButtonEditP_Prom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Edad Madurez:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Peso Promedio:"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(152, 111)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxNombre.TabIndex = 32
        '
        'TextBoxE_Madurez
        '
        Me.TextBoxE_Madurez.Location = New System.Drawing.Point(152, 166)
        Me.TextBoxE_Madurez.Name = "TextBoxE_Madurez"
        Me.TextBoxE_Madurez.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxE_Madurez.TabIndex = 33
        '
        'TextBoxP_Prom
        '
        Me.TextBoxP_Prom.Location = New System.Drawing.Point(152, 221)
        Me.TextBoxP_Prom.Name = "TextBoxP_Prom"
        Me.TextBoxP_Prom.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxP_Prom.TabIndex = 34
        '
        'LabelAltaClientes
        '
        Me.LabelAltaClientes.AutoSize = True
        Me.LabelAltaClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAltaClientes.Location = New System.Drawing.Point(212, 25)
        Me.LabelAltaClientes.Name = "LabelAltaClientes"
        Me.LabelAltaClientes.Size = New System.Drawing.Size(118, 20)
        Me.LabelAltaClientes.TabIndex = 36
        Me.LabelAltaClientes.Text = "Editar Cliente"
        '
        'ButtonEditar
        '
        Me.ButtonEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.ButtonEditar.Location = New System.Drawing.Point(237, 290)
        Me.ButtonEditar.Name = "ButtonEditar"
        Me.ButtonEditar.Size = New System.Drawing.Size(111, 47)
        Me.ButtonEditar.TabIndex = 37
        Me.ButtonEditar.Text = "Editar"
        Me.ButtonEditar.UseVisualStyleBackColor = True
        '
        'ButtonEditNombre
        '
        Me.ButtonEditNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditNombre.Location = New System.Drawing.Point(400, 96)
        Me.ButtonEditNombre.Name = "ButtonEditNombre"
        Me.ButtonEditNombre.Size = New System.Drawing.Size(35, 40)
        Me.ButtonEditNombre.TabIndex = 38
        Me.ButtonEditNombre.Text = "✏️"
        Me.ButtonEditNombre.UseVisualStyleBackColor = True
        '
        'ButtonEditE_Madurez
        '
        Me.ButtonEditE_Madurez.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditE_Madurez.Location = New System.Drawing.Point(400, 151)
        Me.ButtonEditE_Madurez.Name = "ButtonEditE_Madurez"
        Me.ButtonEditE_Madurez.Size = New System.Drawing.Size(35, 40)
        Me.ButtonEditE_Madurez.TabIndex = 39
        Me.ButtonEditE_Madurez.Text = "✏️"
        Me.ButtonEditE_Madurez.UseVisualStyleBackColor = True
        '
        'ButtonEditP_Prom
        '
        Me.ButtonEditP_Prom.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditP_Prom.Location = New System.Drawing.Point(400, 206)
        Me.ButtonEditP_Prom.Name = "ButtonEditP_Prom"
        Me.ButtonEditP_Prom.Size = New System.Drawing.Size(35, 40)
        Me.ButtonEditP_Prom.TabIndex = 40
        Me.ButtonEditP_Prom.Text = "✏️"
        Me.ButtonEditP_Prom.UseVisualStyleBackColor = True
        '
        'EditarEspecie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 386)
        Me.Controls.Add(Me.ButtonEditP_Prom)
        Me.Controls.Add(Me.ButtonEditE_Madurez)
        Me.Controls.Add(Me.ButtonEditNombre)
        Me.Controls.Add(Me.ButtonEditar)
        Me.Controls.Add(Me.LabelAltaClientes)
        Me.Controls.Add(Me.TextBoxP_Prom)
        Me.Controls.Add(Me.TextBoxE_Madurez)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditarEspecie"
        Me.Text = "EditarEspecie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxE_Madurez As TextBox
    Friend WithEvents TextBoxP_Prom As TextBox
    Friend WithEvents LabelAltaClientes As Label
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonEditNombre As Button
    Friend WithEvents ButtonEditE_Madurez As Button
    Friend WithEvents ButtonEditP_Prom As Button
End Class
