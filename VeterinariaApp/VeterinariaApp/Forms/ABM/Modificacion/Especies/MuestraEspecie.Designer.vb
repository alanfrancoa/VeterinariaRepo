<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MuestraEspecie
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonEditarCliente = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelTelefonoCliente = New System.Windows.Forms.Label()
        Me.LabelE_Madurez = New System.Windows.Forms.Label()
        Me.LabelNombreEspecie = New System.Windows.Forms.Label()
        Me.LabelIDEspecie = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 18)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Peso Promedio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(142, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Edad Madurez:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(142, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Nombre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(142, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 18)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "ID:"
        '
        'ButtonEditarCliente
        '
        Me.ButtonEditarCliente.Location = New System.Drawing.Point(262, 444)
        Me.ButtonEditarCliente.Name = "ButtonEditarCliente"
        Me.ButtonEditarCliente.Size = New System.Drawing.Size(121, 44)
        Me.ButtonEditarCliente.TabIndex = 41
        Me.ButtonEditarCliente.Text = "Editar"
        Me.ButtonEditarCliente.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(217, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Resultado de Busqueda"
        '
        'LabelTelefonoCliente
        '
        Me.LabelTelefonoCliente.AutoSize = True
        Me.LabelTelefonoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTelefonoCliente.Location = New System.Drawing.Point(417, 304)
        Me.LabelTelefonoCliente.Name = "LabelTelefonoCliente"
        Me.LabelTelefonoCliente.Size = New System.Drawing.Size(0, 16)
        Me.LabelTelefonoCliente.TabIndex = 37
        '
        'LabelE_Madurez
        '
        Me.LabelE_Madurez.AutoSize = True
        Me.LabelE_Madurez.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelE_Madurez.Location = New System.Drawing.Point(417, 247)
        Me.LabelE_Madurez.Name = "LabelE_Madurez"
        Me.LabelE_Madurez.Size = New System.Drawing.Size(0, 16)
        Me.LabelE_Madurez.TabIndex = 36
        '
        'LabelNombreEspecie
        '
        Me.LabelNombreEspecie.AutoSize = True
        Me.LabelNombreEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreEspecie.Location = New System.Drawing.Point(417, 190)
        Me.LabelNombreEspecie.Name = "LabelNombreEspecie"
        Me.LabelNombreEspecie.Size = New System.Drawing.Size(0, 16)
        Me.LabelNombreEspecie.TabIndex = 35
        '
        'LabelIDEspecie
        '
        Me.LabelIDEspecie.AutoSize = True
        Me.LabelIDEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIDEspecie.Location = New System.Drawing.Point(417, 133)
        Me.LabelIDEspecie.Name = "LabelIDEspecie"
        Me.LabelIDEspecie.Size = New System.Drawing.Size(0, 16)
        Me.LabelIDEspecie.TabIndex = 34
        '
        'MuestraEspecie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 536)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonEditarCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelTelefonoCliente)
        Me.Controls.Add(Me.LabelE_Madurez)
        Me.Controls.Add(Me.LabelNombreEspecie)
        Me.Controls.Add(Me.LabelIDEspecie)
        Me.Name = "MuestraEspecie"
        Me.Text = "Resultado de la Busqueda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonEditarCliente As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelTelefonoCliente As Label
    Friend WithEvents LabelE_Madurez As Label
    Friend WithEvents LabelNombreEspecie As Label
    Friend WithEvents LabelIDEspecie As Label
End Class
