<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectorBajaCliente
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
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelBuscadorClientes = New System.Windows.Forms.Label()
        Me.TextBoxDNI = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscar.Location = New System.Drawing.Point(380, 118)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(35, 40)
        Me.ButtonBuscar.TabIndex = 27
        Me.ButtonBuscar.Text = "🔍"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Por DNI:"
        '
        'LabelBuscadorClientes
        '
        Me.LabelBuscadorClientes.AutoSize = True
        Me.LabelBuscadorClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBuscadorClientes.Location = New System.Drawing.Point(175, 52)
        Me.LabelBuscadorClientes.Name = "LabelBuscadorClientes"
        Me.LabelBuscadorClientes.Size = New System.Drawing.Size(135, 16)
        Me.LabelBuscadorClientes.TabIndex = 25
        Me.LabelBuscadorClientes.Text = "Buscador de Clientes"
        '
        'TextBoxDNI
        '
        Me.TextBoxDNI.Location = New System.Drawing.Point(69, 138)
        Me.TextBoxDNI.Name = "TextBoxDNI"
        Me.TextBoxDNI.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxDNI.TabIndex = 24
        '
        'SelectorBajaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 211)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelBuscadorClientes)
        Me.Controls.Add(Me.TextBoxDNI)
        Me.Name = "SelectorBajaCliente"
        Me.Text = "Baja de Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelBuscadorClientes As Label
    Friend WithEvents TextBoxDNI As TextBox
End Class
