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
        Me.ButtonBusquedaID = New System.Windows.Forms.Button()
        Me.LabelBusquedaID = New System.Windows.Forms.Label()
        Me.LabelBuscadorClientes = New System.Windows.Forms.Label()
        Me.TextBoxIDBusquedaCliente = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonBusquedaID
        '
        Me.ButtonBusquedaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBusquedaID.Location = New System.Drawing.Point(413, 175)
        Me.ButtonBusquedaID.Name = "ButtonBusquedaID"
        Me.ButtonBusquedaID.Size = New System.Drawing.Size(35, 40)
        Me.ButtonBusquedaID.TabIndex = 15
        Me.ButtonBusquedaID.Text = "🔍"
        Me.ButtonBusquedaID.UseVisualStyleBackColor = True
        '
        'LabelBusquedaID
        '
        Me.LabelBusquedaID.AutoSize = True
        Me.LabelBusquedaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBusquedaID.Location = New System.Drawing.Point(102, 175)
        Me.LabelBusquedaID.Name = "LabelBusquedaID"
        Me.LabelBusquedaID.Size = New System.Drawing.Size(116, 15)
        Me.LabelBusquedaID.TabIndex = 14
        Me.LabelBusquedaID.Text = "Nombre de usuario:"
        '
        'LabelBuscadorClientes
        '
        Me.LabelBuscadorClientes.AutoSize = True
        Me.LabelBuscadorClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBuscadorClientes.Location = New System.Drawing.Point(208, 73)
        Me.LabelBuscadorClientes.Name = "LabelBuscadorClientes"
        Me.LabelBuscadorClientes.Size = New System.Drawing.Size(141, 16)
        Me.LabelBuscadorClientes.TabIndex = 13
        Me.LabelBuscadorClientes.Text = "Buscador de Usuarios"
        '
        'TextBoxIDBusquedaCliente
        '
        Me.TextBoxIDBusquedaCliente.Location = New System.Drawing.Point(102, 191)
        Me.TextBoxIDBusquedaCliente.Name = "TextBoxIDBusquedaCliente"
        Me.TextBoxIDBusquedaCliente.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxIDBusquedaCliente.TabIndex = 12
        '
        'BuscadorUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 390)
        Me.Controls.Add(Me.ButtonBusquedaID)
        Me.Controls.Add(Me.LabelBusquedaID)
        Me.Controls.Add(Me.LabelBuscadorClientes)
        Me.Controls.Add(Me.TextBoxIDBusquedaCliente)
        Me.Name = "BuscadorUsuarios"
        Me.Text = "Buscador de Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonBusquedaID As Button
    Friend WithEvents LabelBusquedaID As Label
    Friend WithEvents LabelBuscadorClientes As Label
    Friend WithEvents TextBoxIDBusquedaCliente As TextBox
End Class
