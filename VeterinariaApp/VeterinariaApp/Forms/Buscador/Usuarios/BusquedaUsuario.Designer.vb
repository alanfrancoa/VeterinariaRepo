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
        Me.ButtonEditarUsuario = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelUserNameBusqueda = New System.Windows.Forms.Label()
        Me.LabelNombreUsuarioBusqueda = New System.Windows.Forms.Label()
        Me.LabelIDUsuarioBusqueda = New System.Windows.Forms.Label()
        Me.LabelEstadoUsuario = New System.Windows.Forms.Label()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelNombreUsuario = New System.Windows.Forms.Label()
        Me.LabelIDUsuario = New System.Windows.Forms.Label()
        Me.ButtonResetPass = New System.Windows.Forms.Button()
        Me.ButtonDeshabilitar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelEstadoCliente
        '
        Me.LabelEstadoCliente.AutoSize = True
        Me.LabelEstadoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstadoCliente.Location = New System.Drawing.Point(180, 343)
        Me.LabelEstadoCliente.Name = "LabelEstadoCliente"
        Me.LabelEstadoCliente.Size = New System.Drawing.Size(59, 18)
        Me.LabelEstadoCliente.TabIndex = 26
        Me.LabelEstadoCliente.Text = "Estado:"
        '
        'ButtonEditarUsuario
        '
        Me.ButtonEditarUsuario.Location = New System.Drawing.Point(61, 480)
        Me.ButtonEditarUsuario.Name = "ButtonEditarUsuario"
        Me.ButtonEditarUsuario.Size = New System.Drawing.Size(121, 44)
        Me.ButtonEditarUsuario.TabIndex = 24
        Me.ButtonEditarUsuario.Text = "Editar"
        Me.ButtonEditarUsuario.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(190, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(202, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Resultado de Busqueda"
        '
        'LabelUserNameBusqueda
        '
        Me.LabelUserNameBusqueda.AutoSize = True
        Me.LabelUserNameBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserNameBusqueda.Location = New System.Drawing.Point(180, 287)
        Me.LabelUserNameBusqueda.Name = "LabelUserNameBusqueda"
        Me.LabelUserNameBusqueda.Size = New System.Drawing.Size(139, 18)
        Me.LabelUserNameBusqueda.TabIndex = 22
        Me.LabelUserNameBusqueda.Text = "Nombre de usuario:"
        '
        'LabelNombreUsuarioBusqueda
        '
        Me.LabelNombreUsuarioBusqueda.AutoSize = True
        Me.LabelNombreUsuarioBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreUsuarioBusqueda.Location = New System.Drawing.Point(180, 231)
        Me.LabelNombreUsuarioBusqueda.Name = "LabelNombreUsuarioBusqueda"
        Me.LabelNombreUsuarioBusqueda.Size = New System.Drawing.Size(66, 18)
        Me.LabelNombreUsuarioBusqueda.TabIndex = 21
        Me.LabelNombreUsuarioBusqueda.Text = "Nombre:"
        '
        'LabelIDUsuarioBusqueda
        '
        Me.LabelIDUsuarioBusqueda.AutoSize = True
        Me.LabelIDUsuarioBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIDUsuarioBusqueda.Location = New System.Drawing.Point(180, 175)
        Me.LabelIDUsuarioBusqueda.Name = "LabelIDUsuarioBusqueda"
        Me.LabelIDUsuarioBusqueda.Size = New System.Drawing.Size(26, 18)
        Me.LabelIDUsuarioBusqueda.TabIndex = 20
        Me.LabelIDUsuarioBusqueda.Text = "ID:"
        '
        'LabelEstadoUsuario
        '
        Me.LabelEstadoUsuario.AutoSize = True
        Me.LabelEstadoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstadoUsuario.Location = New System.Drawing.Point(405, 343)
        Me.LabelEstadoUsuario.Name = "LabelEstadoUsuario"
        Me.LabelEstadoUsuario.Size = New System.Drawing.Size(0, 18)
        Me.LabelEstadoUsuario.TabIndex = 30
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.Location = New System.Drawing.Point(405, 287)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(0, 18)
        Me.LabelUsername.TabIndex = 29
        '
        'LabelNombreUsuario
        '
        Me.LabelNombreUsuario.AutoSize = True
        Me.LabelNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreUsuario.Location = New System.Drawing.Point(405, 231)
        Me.LabelNombreUsuario.Name = "LabelNombreUsuario"
        Me.LabelNombreUsuario.Size = New System.Drawing.Size(0, 18)
        Me.LabelNombreUsuario.TabIndex = 28
        '
        'LabelIDUsuario
        '
        Me.LabelIDUsuario.AutoSize = True
        Me.LabelIDUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIDUsuario.Location = New System.Drawing.Point(405, 175)
        Me.LabelIDUsuario.Name = "LabelIDUsuario"
        Me.LabelIDUsuario.Size = New System.Drawing.Size(0, 18)
        Me.LabelIDUsuario.TabIndex = 27
        '
        'ButtonResetPass
        '
        Me.ButtonResetPass.Location = New System.Drawing.Point(237, 480)
        Me.ButtonResetPass.Name = "ButtonResetPass"
        Me.ButtonResetPass.Size = New System.Drawing.Size(121, 44)
        Me.ButtonResetPass.TabIndex = 31
        Me.ButtonResetPass.Text = "Resetear Contraseña"
        Me.ButtonResetPass.UseVisualStyleBackColor = True
        '
        'ButtonDeshabilitar
        '
        Me.ButtonDeshabilitar.Location = New System.Drawing.Point(402, 480)
        Me.ButtonDeshabilitar.Name = "ButtonDeshabilitar"
        Me.ButtonDeshabilitar.Size = New System.Drawing.Size(121, 44)
        Me.ButtonDeshabilitar.TabIndex = 32
        Me.ButtonDeshabilitar.Text = "Bajar"
        Me.ButtonDeshabilitar.UseVisualStyleBackColor = True
        '
        'BusquedaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 536)
        Me.Controls.Add(Me.ButtonDeshabilitar)
        Me.Controls.Add(Me.ButtonResetPass)
        Me.Controls.Add(Me.LabelEstadoUsuario)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.LabelNombreUsuario)
        Me.Controls.Add(Me.LabelIDUsuario)
        Me.Controls.Add(Me.LabelEstadoCliente)
        Me.Controls.Add(Me.ButtonEditarUsuario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelUserNameBusqueda)
        Me.Controls.Add(Me.LabelNombreUsuarioBusqueda)
        Me.Controls.Add(Me.LabelIDUsuarioBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BusquedaUsuario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelEstadoCliente As Label
    Friend WithEvents ButtonEditarUsuario As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelUserNameBusqueda As Label
    Friend WithEvents LabelNombreUsuarioBusqueda As Label
    Friend WithEvents LabelIDUsuarioBusqueda As Label
    Friend WithEvents LabelEstadoUsuario As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelNombreUsuario As Label
    Friend WithEvents LabelIDUsuario As Label
    Friend WithEvents ButtonResetPass As Button
    Friend WithEvents ButtonDeshabilitar As Button
End Class
