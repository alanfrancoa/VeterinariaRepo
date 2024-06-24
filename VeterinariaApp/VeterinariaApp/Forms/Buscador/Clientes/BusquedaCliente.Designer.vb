<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaCliente
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
        Me.ButtonVerMascotasCliente = New System.Windows.Forms.Button()
        Me.ButtonEliminarCliente = New System.Windows.Forms.Button()
        Me.ButtonEditarCliente = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelEstadoCliente = New System.Windows.Forms.Label()
        Me.LabelEMailCliente = New System.Windows.Forms.Label()
        Me.LabelTelefonoCliente = New System.Windows.Forms.Label()
        Me.LabelDNICliente = New System.Windows.Forms.Label()
        Me.LabelNombreCliente = New System.Windows.Forms.Label()
        Me.LabelIDCliente = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonVerMascotasCliente
        '
        Me.ButtonVerMascotasCliente.Location = New System.Drawing.Point(399, 461)
        Me.ButtonVerMascotasCliente.Name = "ButtonVerMascotasCliente"
        Me.ButtonVerMascotasCliente.Size = New System.Drawing.Size(121, 44)
        Me.ButtonVerMascotasCliente.TabIndex = 19
        Me.ButtonVerMascotasCliente.Text = "Ver Mascotas"
        Me.ButtonVerMascotasCliente.UseVisualStyleBackColor = True
        '
        'ButtonEliminarCliente
        '
        Me.ButtonEliminarCliente.Location = New System.Drawing.Point(233, 461)
        Me.ButtonEliminarCliente.Name = "ButtonEliminarCliente"
        Me.ButtonEliminarCliente.Size = New System.Drawing.Size(121, 44)
        Me.ButtonEliminarCliente.TabIndex = 18
        Me.ButtonEliminarCliente.Text = "Eliminar"
        Me.ButtonEliminarCliente.UseVisualStyleBackColor = True
        '
        'ButtonEditarCliente
        '
        Me.ButtonEditarCliente.Location = New System.Drawing.Point(67, 461)
        Me.ButtonEditarCliente.Name = "ButtonEditarCliente"
        Me.ButtonEditarCliente.Size = New System.Drawing.Size(121, 44)
        Me.ButtonEditarCliente.TabIndex = 17
        Me.ButtonEditarCliente.Text = "Editar"
        Me.ButtonEditarCliente.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(203, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Resultado de Busqueda"
        '
        'LabelEstadoCliente
        '
        Me.LabelEstadoCliente.AutoSize = True
        Me.LabelEstadoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstadoCliente.Location = New System.Drawing.Point(126, 402)
        Me.LabelEstadoCliente.Name = "LabelEstadoCliente"
        Me.LabelEstadoCliente.Size = New System.Drawing.Size(59, 18)
        Me.LabelEstadoCliente.TabIndex = 15
        Me.LabelEstadoCliente.Text = "Estado:"
        '
        'LabelEMailCliente
        '
        Me.LabelEMailCliente.AutoSize = True
        Me.LabelEMailCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEMailCliente.Location = New System.Drawing.Point(126, 345)
        Me.LabelEMailCliente.Name = "LabelEMailCliente"
        Me.LabelEMailCliente.Size = New System.Drawing.Size(54, 18)
        Me.LabelEMailCliente.TabIndex = 14
        Me.LabelEMailCliente.Text = "E-mail:"
        '
        'LabelTelefonoCliente
        '
        Me.LabelTelefonoCliente.AutoSize = True
        Me.LabelTelefonoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTelefonoCliente.Location = New System.Drawing.Point(126, 288)
        Me.LabelTelefonoCliente.Name = "LabelTelefonoCliente"
        Me.LabelTelefonoCliente.Size = New System.Drawing.Size(70, 18)
        Me.LabelTelefonoCliente.TabIndex = 13
        Me.LabelTelefonoCliente.Text = "Telefono:"
        '
        'LabelDNICliente
        '
        Me.LabelDNICliente.AutoSize = True
        Me.LabelDNICliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDNICliente.Location = New System.Drawing.Point(126, 231)
        Me.LabelDNICliente.Name = "LabelDNICliente"
        Me.LabelDNICliente.Size = New System.Drawing.Size(37, 18)
        Me.LabelDNICliente.TabIndex = 12
        Me.LabelDNICliente.Text = "DNI:"
        '
        'LabelNombreCliente
        '
        Me.LabelNombreCliente.AutoSize = True
        Me.LabelNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreCliente.Location = New System.Drawing.Point(126, 174)
        Me.LabelNombreCliente.Name = "LabelNombreCliente"
        Me.LabelNombreCliente.Size = New System.Drawing.Size(66, 18)
        Me.LabelNombreCliente.TabIndex = 11
        Me.LabelNombreCliente.Text = "Nombre:"
        '
        'LabelIDCliente
        '
        Me.LabelIDCliente.AutoSize = True
        Me.LabelIDCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIDCliente.Location = New System.Drawing.Point(126, 117)
        Me.LabelIDCliente.Name = "LabelIDCliente"
        Me.LabelIDCliente.Size = New System.Drawing.Size(26, 18)
        Me.LabelIDCliente.TabIndex = 10
        Me.LabelIDCliente.Text = "ID:"
        '
        'BusquedaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 537)
        Me.Controls.Add(Me.ButtonVerMascotasCliente)
        Me.Controls.Add(Me.ButtonEliminarCliente)
        Me.Controls.Add(Me.ButtonEditarCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelEstadoCliente)
        Me.Controls.Add(Me.LabelEMailCliente)
        Me.Controls.Add(Me.LabelTelefonoCliente)
        Me.Controls.Add(Me.LabelDNICliente)
        Me.Controls.Add(Me.LabelNombreCliente)
        Me.Controls.Add(Me.LabelIDCliente)
        Me.Name = "BusquedaCliente"
        Me.Text = "Busqueda de Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonVerMascotasCliente As Button
    Friend WithEvents ButtonEliminarCliente As Button
    Friend WithEvents ButtonEditarCliente As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelEstadoCliente As Label
    Friend WithEvents LabelEMailCliente As Label
    Friend WithEvents LabelTelefonoCliente As Label
    Friend WithEvents LabelDNICliente As Label
    Friend WithEvents LabelNombreCliente As Label
    Friend WithEvents LabelIDCliente As Label
End Class
