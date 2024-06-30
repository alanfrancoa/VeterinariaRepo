<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectorUsuario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelBuscadorClientes = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscar.Location = New System.Drawing.Point(380, 118)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(35, 40)
        Me.ButtonBuscar.TabIndex = 35
        Me.ButtonBuscar.Text = "🔍"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 15)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Nombre de Usuario:"
        '
        'LabelBuscadorClientes
        '
        Me.LabelBuscadorClientes.AutoSize = True
        Me.LabelBuscadorClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBuscadorClientes.Location = New System.Drawing.Point(149, 52)
        Me.LabelBuscadorClientes.Name = "LabelBuscadorClientes"
        Me.LabelBuscadorClientes.Size = New System.Drawing.Size(186, 20)
        Me.LabelBuscadorClientes.TabIndex = 33
        Me.LabelBuscadorClientes.Text = "Buscador de Usuarios"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(69, 138)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxUsername.TabIndex = 32
        '
        'SelectorUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 211)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelBuscadorClientes)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectorUsuario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edicion  de Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelBuscadorClientes As Label
    Friend WithEvents TextBoxUsername As TextBox
End Class
