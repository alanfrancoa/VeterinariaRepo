<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaMascota
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
        Me.ButtonEliminarMascota = New System.Windows.Forms.Button()
        Me.ButtonEditarMascota = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelEstadoMascota = New System.Windows.Forms.Label()
        Me.LabelClienteMascota = New System.Windows.Forms.Label()
        Me.LabelFechaNacimientoMascota = New System.Windows.Forms.Label()
        Me.LabelPesoMascota = New System.Windows.Forms.Label()
        Me.LabelNombreMascota = New System.Windows.Forms.Label()
        Me.LabelIDMascota = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonEliminarMascota
        '
        Me.ButtonEliminarMascota.Location = New System.Drawing.Point(314, 463)
        Me.ButtonEliminarMascota.Name = "ButtonEliminarMascota"
        Me.ButtonEliminarMascota.Size = New System.Drawing.Size(121, 44)
        Me.ButtonEliminarMascota.TabIndex = 27
        Me.ButtonEliminarMascota.Text = "Eliminar"
        Me.ButtonEliminarMascota.UseVisualStyleBackColor = True
        '
        'ButtonEditarMascota
        '
        Me.ButtonEditarMascota.Location = New System.Drawing.Point(148, 463)
        Me.ButtonEditarMascota.Name = "ButtonEditarMascota"
        Me.ButtonEditarMascota.Size = New System.Drawing.Size(121, 44)
        Me.ButtonEditarMascota.TabIndex = 26
        Me.ButtonEditarMascota.Text = "Editar"
        Me.ButtonEditarMascota.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(204, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Resultado de Busqueda"
        '
        'LabelEstadoMascota
        '
        Me.LabelEstadoMascota.AutoSize = True
        Me.LabelEstadoMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstadoMascota.Location = New System.Drawing.Point(145, 400)
        Me.LabelEstadoMascota.Name = "LabelEstadoMascota"
        Me.LabelEstadoMascota.Size = New System.Drawing.Size(59, 18)
        Me.LabelEstadoMascota.TabIndex = 24
        Me.LabelEstadoMascota.Text = "Estado:"
        '
        'LabelClienteMascota
        '
        Me.LabelClienteMascota.AutoSize = True
        Me.LabelClienteMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClienteMascota.Location = New System.Drawing.Point(145, 343)
        Me.LabelClienteMascota.Name = "LabelClienteMascota"
        Me.LabelClienteMascota.Size = New System.Drawing.Size(57, 18)
        Me.LabelClienteMascota.TabIndex = 23
        Me.LabelClienteMascota.Text = "Cliente:"
        '
        'LabelFechaNacimientoMascota
        '
        Me.LabelFechaNacimientoMascota.AutoSize = True
        Me.LabelFechaNacimientoMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaNacimientoMascota.Location = New System.Drawing.Point(145, 286)
        Me.LabelFechaNacimientoMascota.Name = "LabelFechaNacimientoMascota"
        Me.LabelFechaNacimientoMascota.Size = New System.Drawing.Size(149, 18)
        Me.LabelFechaNacimientoMascota.TabIndex = 22
        Me.LabelFechaNacimientoMascota.Text = "Fecha de nacimiento:"
        '
        'LabelPesoMascota
        '
        Me.LabelPesoMascota.AutoSize = True
        Me.LabelPesoMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPesoMascota.Location = New System.Drawing.Point(145, 229)
        Me.LabelPesoMascota.Name = "LabelPesoMascota"
        Me.LabelPesoMascota.Size = New System.Drawing.Size(47, 18)
        Me.LabelPesoMascota.TabIndex = 21
        Me.LabelPesoMascota.Text = "Peso:"
        '
        'LabelNombreMascota
        '
        Me.LabelNombreMascota.AutoSize = True
        Me.LabelNombreMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreMascota.Location = New System.Drawing.Point(145, 172)
        Me.LabelNombreMascota.Name = "LabelNombreMascota"
        Me.LabelNombreMascota.Size = New System.Drawing.Size(66, 18)
        Me.LabelNombreMascota.TabIndex = 20
        Me.LabelNombreMascota.Text = "Nombre:"
        '
        'LabelIDMascota
        '
        Me.LabelIDMascota.AutoSize = True
        Me.LabelIDMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIDMascota.Location = New System.Drawing.Point(145, 115)
        Me.LabelIDMascota.Name = "LabelIDMascota"
        Me.LabelIDMascota.Size = New System.Drawing.Size(26, 18)
        Me.LabelIDMascota.TabIndex = 19
        Me.LabelIDMascota.Text = "ID:"
        '
        'BusquedaMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 533)
        Me.Controls.Add(Me.ButtonEliminarMascota)
        Me.Controls.Add(Me.ButtonEditarMascota)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelEstadoMascota)
        Me.Controls.Add(Me.LabelClienteMascota)
        Me.Controls.Add(Me.LabelFechaNacimientoMascota)
        Me.Controls.Add(Me.LabelPesoMascota)
        Me.Controls.Add(Me.LabelNombreMascota)
        Me.Controls.Add(Me.LabelIDMascota)
        Me.Name = "BusquedaMascota"
        Me.Text = "Busqueda de Mascota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonEliminarMascota As Button
    Friend WithEvents ButtonEditarMascota As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelEstadoMascota As Label
    Friend WithEvents LabelClienteMascota As Label
    Friend WithEvents LabelFechaNacimientoMascota As Label
    Friend WithEvents LabelPesoMascota As Label
    Friend WithEvents LabelNombreMascota As Label
    Friend WithEvents LabelIDMascota As Label
End Class
