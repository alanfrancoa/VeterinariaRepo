<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscadorUsuarios
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
        Me.ButtonBusquedaUsername = New System.Windows.Forms.Button()
        Me.LabelBusquedaID = New System.Windows.Forms.Label()
        Me.LabelBuscadorUsuario = New System.Windows.Forms.Label()
        Me.TextBoxBusquedaUsuario = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonBusquedaUsername
        '
        Me.ButtonBusquedaUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBusquedaUsername.Location = New System.Drawing.Point(430, 98)
        Me.ButtonBusquedaUsername.Name = "ButtonBusquedaUsername"
        Me.ButtonBusquedaUsername.Size = New System.Drawing.Size(35, 40)
        Me.ButtonBusquedaUsername.TabIndex = 15
        Me.ButtonBusquedaUsername.Text = "🔍"
        Me.ButtonBusquedaUsername.UseVisualStyleBackColor = True
        '
        'LabelBusquedaID
        '
        Me.LabelBusquedaID.AutoSize = True
        Me.LabelBusquedaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBusquedaID.Location = New System.Drawing.Point(119, 98)
        Me.LabelBusquedaID.Name = "LabelBusquedaID"
        Me.LabelBusquedaID.Size = New System.Drawing.Size(116, 15)
        Me.LabelBusquedaID.TabIndex = 14
        Me.LabelBusquedaID.Text = "Nombre de usuario:"
        '
        'LabelBuscadorUsuario
        '
        Me.LabelBuscadorUsuario.AutoSize = True
        Me.LabelBuscadorUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBuscadorUsuario.Location = New System.Drawing.Point(199, 34)
        Me.LabelBuscadorUsuario.Name = "LabelBuscadorUsuario"
        Me.LabelBuscadorUsuario.Size = New System.Drawing.Size(186, 20)
        Me.LabelBuscadorUsuario.TabIndex = 13
        Me.LabelBuscadorUsuario.Text = "Buscador de Usuarios"
        '
        'TextBoxBusquedaUsuario
        '
        Me.TextBoxBusquedaUsuario.Location = New System.Drawing.Point(119, 114)
        Me.TextBoxBusquedaUsuario.Name = "TextBoxBusquedaUsuario"
        Me.TextBoxBusquedaUsuario.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxBusquedaUsuario.TabIndex = 12
        '
        'BuscadorUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 236)
        Me.Controls.Add(Me.ButtonBusquedaUsername)
        Me.Controls.Add(Me.LabelBusquedaID)
        Me.Controls.Add(Me.LabelBuscadorUsuario)
        Me.Controls.Add(Me.TextBoxBusquedaUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BuscadorUsuarios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscador de Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonBusquedaUsername As Button
    Friend WithEvents LabelBusquedaID As Label
    Friend WithEvents LabelBuscadorUsuario As Label
    Friend WithEvents TextBoxBusquedaUsuario As TextBox
End Class
