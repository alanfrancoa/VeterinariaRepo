<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaUsuario
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
        Me.LabelEstadoCliente = New System.Windows.Forms.Label()
        Me.ButtonEliminarUsuario = New System.Windows.Forms.Button()
        Me.ButtonEditarUsuario = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelUserNameBusqueda = New System.Windows.Forms.Label()
        Me.LabelNombreUsuarioBusqueda = New System.Windows.Forms.Label()
        Me.LabelIDUsuarioBusqueda = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelEstadoCliente
        '
        Me.LabelEstadoCliente.AutoSize = True
        Me.LabelEstadoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstadoCliente.Location = New System.Drawing.Point(191, 302)
        Me.LabelEstadoCliente.Name = "LabelEstadoCliente"
        Me.LabelEstadoCliente.Size = New System.Drawing.Size(59, 18)
        Me.LabelEstadoCliente.TabIndex = 26
        Me.LabelEstadoCliente.Text = "Estado:"
        '
        'ButtonEliminarUsuario
        '
        Me.ButtonEliminarUsuario.Location = New System.Drawing.Point(303, 375)
        Me.ButtonEliminarUsuario.Name = "ButtonEliminarUsuario"
        Me.ButtonEliminarUsuario.Size = New System.Drawing.Size(121, 44)
        Me.ButtonEliminarUsuario.TabIndex = 25
        Me.ButtonEliminarUsuario.Text = "Eliminar"
        Me.ButtonEliminarUsuario.UseVisualStyleBackColor = True
        '
        'ButtonEditarUsuario
        '
        Me.ButtonEditarUsuario.Location = New System.Drawing.Point(137, 375)
        Me.ButtonEditarUsuario.Name = "ButtonEditarUsuario"
        Me.ButtonEditarUsuario.Size = New System.Drawing.Size(121, 44)
        Me.ButtonEditarUsuario.TabIndex = 24
        Me.ButtonEditarUsuario.Text = "Editar"
        Me.ButtonEditarUsuario.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(190, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Resultado de Busqueda"
        '
        'LabelUserNameBusqueda
        '
        Me.LabelUserNameBusqueda.AutoSize = True
        Me.LabelUserNameBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserNameBusqueda.Location = New System.Drawing.Point(191, 246)
        Me.LabelUserNameBusqueda.Name = "LabelUserNameBusqueda"
        Me.LabelUserNameBusqueda.Size = New System.Drawing.Size(139, 18)
        Me.LabelUserNameBusqueda.TabIndex = 22
        Me.LabelUserNameBusqueda.Text = "Nombre de usuario:"
        '
        'LabelNombreUsuarioBusqueda
        '
        Me.LabelNombreUsuarioBusqueda.AutoSize = True
        Me.LabelNombreUsuarioBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreUsuarioBusqueda.Location = New System.Drawing.Point(191, 190)
        Me.LabelNombreUsuarioBusqueda.Name = "LabelNombreUsuarioBusqueda"
        Me.LabelNombreUsuarioBusqueda.Size = New System.Drawing.Size(66, 18)
        Me.LabelNombreUsuarioBusqueda.TabIndex = 21
        Me.LabelNombreUsuarioBusqueda.Text = "Nombre:"
        '
        'LabelIDUsuarioBusqueda
        '
        Me.LabelIDUsuarioBusqueda.AutoSize = True
        Me.LabelIDUsuarioBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIDUsuarioBusqueda.Location = New System.Drawing.Point(191, 134)
        Me.LabelIDUsuarioBusqueda.Name = "LabelIDUsuarioBusqueda"
        Me.LabelIDUsuarioBusqueda.Size = New System.Drawing.Size(26, 18)
        Me.LabelIDUsuarioBusqueda.TabIndex = 20
        Me.LabelIDUsuarioBusqueda.Text = "ID:"
        '
        'BusquedaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 450)
        Me.Controls.Add(Me.LabelEstadoCliente)
        Me.Controls.Add(Me.ButtonEliminarUsuario)
        Me.Controls.Add(Me.ButtonEditarUsuario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelUserNameBusqueda)
        Me.Controls.Add(Me.LabelNombreUsuarioBusqueda)
        Me.Controls.Add(Me.LabelIDUsuarioBusqueda)
        Me.Name = "BusquedaUsuario"
        Me.Text = "Busqueda de Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelEstadoCliente As Label
    Friend WithEvents ButtonEliminarUsuario As Button
    Friend WithEvents ButtonEditarUsuario As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelUserNameBusqueda As Label
    Friend WithEvents LabelNombreUsuarioBusqueda As Label
    Friend WithEvents LabelIDUsuarioBusqueda As Label
End Class
