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
        Me.ButtonEditarMascota = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonEliminarMascota = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelEstadoMascota = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelInfoCliente = New System.Windows.Forms.Label()
        Me.LabelNombreEspecie = New System.Windows.Forms.Label()
        Me.LabelFechaNacimiento = New System.Windows.Forms.Label()
        Me.LabelPesoMascota = New System.Windows.Forms.Label()
        Me.LabelNombreMascota = New System.Windows.Forms.Label()
        Me.LabelIDMascota = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonEditarMascota
        '
        Me.ButtonEditarMascota.Location = New System.Drawing.Point(139, 477)
        Me.ButtonEditarMascota.Name = "ButtonEditarMascota"
        Me.ButtonEditarMascota.Size = New System.Drawing.Size(121, 44)
        Me.ButtonEditarMascota.TabIndex = 26
        Me.ButtonEditarMascota.Text = "Editar"
        Me.ButtonEditarMascota.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(191, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(202, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Resultado de Busqueda"
        '
        'ButtonEliminarMascota
        '
        Me.ButtonEliminarMascota.Location = New System.Drawing.Point(324, 477)
        Me.ButtonEliminarMascota.Name = "ButtonEliminarMascota"
        Me.ButtonEliminarMascota.Size = New System.Drawing.Size(121, 44)
        Me.ButtonEliminarMascota.TabIndex = 27
        Me.ButtonEliminarMascota.Text = "Eliminar"
        Me.ButtonEliminarMascota.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(151, 400)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 18)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Estado:"
        '
        'LabelEstadoMascota
        '
        Me.LabelEstadoMascota.AutoSize = True
        Me.LabelEstadoMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstadoMascota.Location = New System.Drawing.Point(382, 411)
        Me.LabelEstadoMascota.Name = "LabelEstadoMascota"
        Me.LabelEstadoMascota.Size = New System.Drawing.Size(0, 16)
        Me.LabelEstadoMascota.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(151, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Especie:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(151, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 18)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Fecha de Nacimiento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(151, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Peso:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(151, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Nombre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(151, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 18)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "ID:"
        '
        'LabelInfoCliente
        '
        Me.LabelInfoCliente.AutoSize = True
        Me.LabelInfoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfoCliente.Location = New System.Drawing.Point(382, 357)
        Me.LabelInfoCliente.Name = "LabelInfoCliente"
        Me.LabelInfoCliente.Size = New System.Drawing.Size(0, 16)
        Me.LabelInfoCliente.TabIndex = 55
        '
        'LabelNombreEspecie
        '
        Me.LabelNombreEspecie.AutoSize = True
        Me.LabelNombreEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreEspecie.Location = New System.Drawing.Point(382, 311)
        Me.LabelNombreEspecie.Name = "LabelNombreEspecie"
        Me.LabelNombreEspecie.Size = New System.Drawing.Size(0, 16)
        Me.LabelNombreEspecie.TabIndex = 54
        '
        'LabelFechaNacimiento
        '
        Me.LabelFechaNacimiento.AutoSize = True
        Me.LabelFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaNacimiento.Location = New System.Drawing.Point(382, 265)
        Me.LabelFechaNacimiento.Name = "LabelFechaNacimiento"
        Me.LabelFechaNacimiento.Size = New System.Drawing.Size(0, 16)
        Me.LabelFechaNacimiento.TabIndex = 53
        '
        'LabelPesoMascota
        '
        Me.LabelPesoMascota.AutoSize = True
        Me.LabelPesoMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPesoMascota.Location = New System.Drawing.Point(382, 219)
        Me.LabelPesoMascota.Name = "LabelPesoMascota"
        Me.LabelPesoMascota.Size = New System.Drawing.Size(0, 16)
        Me.LabelPesoMascota.TabIndex = 52
        '
        'LabelNombreMascota
        '
        Me.LabelNombreMascota.AutoSize = True
        Me.LabelNombreMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreMascota.Location = New System.Drawing.Point(382, 173)
        Me.LabelNombreMascota.Name = "LabelNombreMascota"
        Me.LabelNombreMascota.Size = New System.Drawing.Size(0, 16)
        Me.LabelNombreMascota.TabIndex = 51
        '
        'LabelIDMascota
        '
        Me.LabelIDMascota.AutoSize = True
        Me.LabelIDMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIDMascota.Location = New System.Drawing.Point(382, 127)
        Me.LabelIDMascota.Name = "LabelIDMascota"
        Me.LabelIDMascota.Size = New System.Drawing.Size(0, 16)
        Me.LabelIDMascota.TabIndex = 50
        '
        'BusquedaMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 536)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabelEstadoMascota)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelInfoCliente)
        Me.Controls.Add(Me.LabelNombreEspecie)
        Me.Controls.Add(Me.LabelFechaNacimiento)
        Me.Controls.Add(Me.LabelPesoMascota)
        Me.Controls.Add(Me.LabelNombreMascota)
        Me.Controls.Add(Me.LabelIDMascota)
        Me.Controls.Add(Me.ButtonEliminarMascota)
        Me.Controls.Add(Me.ButtonEditarMascota)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BusquedaMascota"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mascota Encontrada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonEditarMascota As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonEliminarMascota As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelEstadoMascota As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelInfoCliente As Label
    Friend WithEvents LabelNombreEspecie As Label
    Friend WithEvents LabelFechaNacimiento As Label
    Friend WithEvents LabelPesoMascota As Label
    Friend WithEvents LabelNombreMascota As Label
    Friend WithEvents LabelIDMascota As Label
End Class
