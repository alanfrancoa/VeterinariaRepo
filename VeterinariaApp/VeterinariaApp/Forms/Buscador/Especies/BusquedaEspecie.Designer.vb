<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaEspecie
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
        Me.ButtonEditarEspecie = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelPesoPromedioEspecie = New System.Windows.Forms.Label()
        Me.LabelMadurezEspecie = New System.Windows.Forms.Label()
        Me.LabelNombreEspecie = New System.Windows.Forms.Label()
        Me.LabelIDEspecie = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonEditarEspecie
        '
        Me.ButtonEditarEspecie.Location = New System.Drawing.Point(218, 361)
        Me.ButtonEditarEspecie.Name = "ButtonEditarEspecie"
        Me.ButtonEditarEspecie.Size = New System.Drawing.Size(121, 44)
        Me.ButtonEditarEspecie.TabIndex = 23
        Me.ButtonEditarEspecie.Text = "Editar"
        Me.ButtonEditarEspecie.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(188, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Resultado de Busqueda"
        '
        'LabelPesoPromedioEspecie
        '
        Me.LabelPesoPromedioEspecie.AutoSize = True
        Me.LabelPesoPromedioEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPesoPromedioEspecie.Location = New System.Drawing.Point(121, 291)
        Me.LabelPesoPromedioEspecie.Name = "LabelPesoPromedioEspecie"
        Me.LabelPesoPromedioEspecie.Size = New System.Drawing.Size(116, 18)
        Me.LabelPesoPromedioEspecie.TabIndex = 21
        Me.LabelPesoPromedioEspecie.Text = "Peso Promedio:"
        '
        'LabelMadurezEspecie
        '
        Me.LabelMadurezEspecie.AutoSize = True
        Me.LabelMadurezEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMadurezEspecie.Location = New System.Drawing.Point(121, 234)
        Me.LabelMadurezEspecie.Name = "LabelMadurezEspecie"
        Me.LabelMadurezEspecie.Size = New System.Drawing.Size(128, 18)
        Me.LabelMadurezEspecie.TabIndex = 20
        Me.LabelMadurezEspecie.Text = "Edad de Madurez:"
        '
        'LabelNombreEspecie
        '
        Me.LabelNombreEspecie.AutoSize = True
        Me.LabelNombreEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreEspecie.Location = New System.Drawing.Point(121, 177)
        Me.LabelNombreEspecie.Name = "LabelNombreEspecie"
        Me.LabelNombreEspecie.Size = New System.Drawing.Size(66, 18)
        Me.LabelNombreEspecie.TabIndex = 19
        Me.LabelNombreEspecie.Text = "Nombre:"
        '
        'LabelIDEspecie
        '
        Me.LabelIDEspecie.AutoSize = True
        Me.LabelIDEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIDEspecie.Location = New System.Drawing.Point(121, 120)
        Me.LabelIDEspecie.Name = "LabelIDEspecie"
        Me.LabelIDEspecie.Size = New System.Drawing.Size(26, 18)
        Me.LabelIDEspecie.TabIndex = 18
        Me.LabelIDEspecie.Text = "ID:"
        '
        'BusquedaEspecie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 450)
        Me.Controls.Add(Me.ButtonEditarEspecie)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelPesoPromedioEspecie)
        Me.Controls.Add(Me.LabelMadurezEspecie)
        Me.Controls.Add(Me.LabelNombreEspecie)
        Me.Controls.Add(Me.LabelIDEspecie)
        Me.Name = "BusquedaEspecie"
        Me.Text = "BusquedaEspecie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonEditarEspecie As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelPesoPromedioEspecie As Label
    Friend WithEvents LabelMadurezEspecie As Label
    Friend WithEvents LabelNombreEspecie As Label
    Friend WithEvents LabelIDEspecie As Label
End Class
