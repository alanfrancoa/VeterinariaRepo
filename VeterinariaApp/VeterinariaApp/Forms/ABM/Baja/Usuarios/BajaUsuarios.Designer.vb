<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BajaUsuarios
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
        Me.LabelEstadoUsuario = New System.Windows.Forms.Label()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelNombreUsuario = New System.Windows.Forms.Label()
        Me.LabelIDUsuario = New System.Windows.Forms.Label()
        Me.LabelEstadoCliente = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelUserNameBusqueda = New System.Windows.Forms.Label()
        Me.LabelNombreUsuarioBusqueda = New System.Windows.Forms.Label()
        Me.LabelIDUsuarioBusqueda = New System.Windows.Forms.Label()
        Me.ButtonBajarUsuario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelEstadoUsuario
        '
        Me.LabelEstadoUsuario.AutoSize = True
        Me.LabelEstadoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstadoUsuario.Location = New System.Drawing.Point(405, 311)
        Me.LabelEstadoUsuario.Name = "LabelEstadoUsuario"
        Me.LabelEstadoUsuario.Size = New System.Drawing.Size(0, 18)
        Me.LabelEstadoUsuario.TabIndex = 39
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.Location = New System.Drawing.Point(405, 255)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(0, 18)
        Me.LabelUsername.TabIndex = 38
        '
        'LabelNombreUsuario
        '
        Me.LabelNombreUsuario.AutoSize = True
        Me.LabelNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreUsuario.Location = New System.Drawing.Point(405, 199)
        Me.LabelNombreUsuario.Name = "LabelNombreUsuario"
        Me.LabelNombreUsuario.Size = New System.Drawing.Size(0, 18)
        Me.LabelNombreUsuario.TabIndex = 37
        '
        'LabelIDUsuario
        '
        Me.LabelIDUsuario.AutoSize = True
        Me.LabelIDUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIDUsuario.Location = New System.Drawing.Point(405, 143)
        Me.LabelIDUsuario.Name = "LabelIDUsuario"
        Me.LabelIDUsuario.Size = New System.Drawing.Size(0, 18)
        Me.LabelIDUsuario.TabIndex = 36
        '
        'LabelEstadoCliente
        '
        Me.LabelEstadoCliente.AutoSize = True
        Me.LabelEstadoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstadoCliente.Location = New System.Drawing.Point(180, 311)
        Me.LabelEstadoCliente.Name = "LabelEstadoCliente"
        Me.LabelEstadoCliente.Size = New System.Drawing.Size(59, 18)
        Me.LabelEstadoCliente.TabIndex = 35
        Me.LabelEstadoCliente.Text = "Estado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(191, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(202, 20)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Resultado de Busqueda"
        '
        'LabelUserNameBusqueda
        '
        Me.LabelUserNameBusqueda.AutoSize = True
        Me.LabelUserNameBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserNameBusqueda.Location = New System.Drawing.Point(180, 255)
        Me.LabelUserNameBusqueda.Name = "LabelUserNameBusqueda"
        Me.LabelUserNameBusqueda.Size = New System.Drawing.Size(139, 18)
        Me.LabelUserNameBusqueda.TabIndex = 33
        Me.LabelUserNameBusqueda.Text = "Nombre de usuario:"
        '
        'LabelNombreUsuarioBusqueda
        '
        Me.LabelNombreUsuarioBusqueda.AutoSize = True
        Me.LabelNombreUsuarioBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreUsuarioBusqueda.Location = New System.Drawing.Point(180, 199)
        Me.LabelNombreUsuarioBusqueda.Name = "LabelNombreUsuarioBusqueda"
        Me.LabelNombreUsuarioBusqueda.Size = New System.Drawing.Size(66, 18)
        Me.LabelNombreUsuarioBusqueda.TabIndex = 32
        Me.LabelNombreUsuarioBusqueda.Text = "Nombre:"
        '
        'LabelIDUsuarioBusqueda
        '
        Me.LabelIDUsuarioBusqueda.AutoSize = True
        Me.LabelIDUsuarioBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIDUsuarioBusqueda.Location = New System.Drawing.Point(180, 143)
        Me.LabelIDUsuarioBusqueda.Name = "LabelIDUsuarioBusqueda"
        Me.LabelIDUsuarioBusqueda.Size = New System.Drawing.Size(26, 18)
        Me.LabelIDUsuarioBusqueda.TabIndex = 31
        Me.LabelIDUsuarioBusqueda.Text = "ID:"
        '
        'ButtonBajarUsuario
        '
        Me.ButtonBajarUsuario.Location = New System.Drawing.Point(232, 480)
        Me.ButtonBajarUsuario.Name = "ButtonBajarUsuario"
        Me.ButtonBajarUsuario.Size = New System.Drawing.Size(121, 44)
        Me.ButtonBajarUsuario.TabIndex = 42
        Me.ButtonBajarUsuario.Text = "Bajar"
        Me.ButtonBajarUsuario.UseVisualStyleBackColor = True
        '
        'BajaUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 536)
        Me.Controls.Add(Me.ButtonBajarUsuario)
        Me.Controls.Add(Me.LabelEstadoUsuario)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.LabelNombreUsuario)
        Me.Controls.Add(Me.LabelIDUsuario)
        Me.Controls.Add(Me.LabelEstadoCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelUserNameBusqueda)
        Me.Controls.Add(Me.LabelNombreUsuarioBusqueda)
        Me.Controls.Add(Me.LabelIDUsuarioBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BajaUsuarios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BajaUsuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelEstadoUsuario As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelNombreUsuario As Label
    Friend WithEvents LabelIDUsuario As Label
    Friend WithEvents LabelEstadoCliente As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelUserNameBusqueda As Label
    Friend WithEvents LabelNombreUsuarioBusqueda As Label
    Friend WithEvents LabelIDUsuarioBusqueda As Label
    Friend WithEvents ButtonBajarUsuario As Button
End Class
