<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscadorClientes
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
        Me.ButtonBusquedaDNICliente = New System.Windows.Forms.Button()
        Me.ButtonBusquedaNombreCliente = New System.Windows.Forms.Button()
        Me.ButtonBusquedaID = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelBusquedaID = New System.Windows.Forms.Label()
        Me.LabelBuscadorClientes = New System.Windows.Forms.Label()
        Me.TextBoxBusquedaDNICliente = New System.Windows.Forms.TextBox()
        Me.TextBoxBusquedaNombreCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxIDBusquedaCliente = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonBusquedaDNICliente
        '
        Me.ButtonBusquedaDNICliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBusquedaDNICliente.Location = New System.Drawing.Point(432, 265)
        Me.ButtonBusquedaDNICliente.Name = "ButtonBusquedaDNICliente"
        Me.ButtonBusquedaDNICliente.Size = New System.Drawing.Size(35, 40)
        Me.ButtonBusquedaDNICliente.TabIndex = 19
        Me.ButtonBusquedaDNICliente.Text = "🔍"
        Me.ButtonBusquedaDNICliente.UseVisualStyleBackColor = True
        '
        'ButtonBusquedaNombreCliente
        '
        Me.ButtonBusquedaNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBusquedaNombreCliente.Location = New System.Drawing.Point(432, 197)
        Me.ButtonBusquedaNombreCliente.Name = "ButtonBusquedaNombreCliente"
        Me.ButtonBusquedaNombreCliente.Size = New System.Drawing.Size(35, 40)
        Me.ButtonBusquedaNombreCliente.TabIndex = 18
        Me.ButtonBusquedaNombreCliente.Text = "🔍"
        Me.ButtonBusquedaNombreCliente.UseVisualStyleBackColor = True
        '
        'ButtonBusquedaID
        '
        Me.ButtonBusquedaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBusquedaID.Location = New System.Drawing.Point(432, 133)
        Me.ButtonBusquedaID.Name = "ButtonBusquedaID"
        Me.ButtonBusquedaID.Size = New System.Drawing.Size(35, 40)
        Me.ButtonBusquedaID.TabIndex = 17
        Me.ButtonBusquedaID.Text = "🔍"
        Me.ButtonBusquedaID.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Por DNI:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Por Nombre:"
        '
        'LabelBusquedaID
        '
        Me.LabelBusquedaID.AutoSize = True
        Me.LabelBusquedaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBusquedaID.Location = New System.Drawing.Point(121, 133)
        Me.LabelBusquedaID.Name = "LabelBusquedaID"
        Me.LabelBusquedaID.Size = New System.Drawing.Size(44, 15)
        Me.LabelBusquedaID.TabIndex = 14
        Me.LabelBusquedaID.Text = "Por ID:"
        '
        'LabelBuscadorClientes
        '
        Me.LabelBuscadorClientes.AutoSize = True
        Me.LabelBuscadorClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBuscadorClientes.Location = New System.Drawing.Point(202, 69)
        Me.LabelBuscadorClientes.Name = "LabelBuscadorClientes"
        Me.LabelBuscadorClientes.Size = New System.Drawing.Size(180, 20)
        Me.LabelBuscadorClientes.TabIndex = 13
        Me.LabelBuscadorClientes.Text = "Buscador de Clientes"
        '
        'TextBoxBusquedaDNICliente
        '
        Me.TextBoxBusquedaDNICliente.Location = New System.Drawing.Point(121, 285)
        Me.TextBoxBusquedaDNICliente.Name = "TextBoxBusquedaDNICliente"
        Me.TextBoxBusquedaDNICliente.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxBusquedaDNICliente.TabIndex = 12
        '
        'TextBoxBusquedaNombreCliente
        '
        Me.TextBoxBusquedaNombreCliente.Location = New System.Drawing.Point(121, 217)
        Me.TextBoxBusquedaNombreCliente.Name = "TextBoxBusquedaNombreCliente"
        Me.TextBoxBusquedaNombreCliente.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxBusquedaNombreCliente.TabIndex = 11
        '
        'TextBoxIDBusquedaCliente
        '
        Me.TextBoxIDBusquedaCliente.Location = New System.Drawing.Point(121, 149)
        Me.TextBoxIDBusquedaCliente.Name = "TextBoxIDBusquedaCliente"
        Me.TextBoxIDBusquedaCliente.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxIDBusquedaCliente.TabIndex = 10
        '
        'BuscadorClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 436)
        Me.Controls.Add(Me.ButtonBusquedaDNICliente)
        Me.Controls.Add(Me.ButtonBusquedaNombreCliente)
        Me.Controls.Add(Me.ButtonBusquedaID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelBusquedaID)
        Me.Controls.Add(Me.LabelBuscadorClientes)
        Me.Controls.Add(Me.TextBoxBusquedaDNICliente)
        Me.Controls.Add(Me.TextBoxBusquedaNombreCliente)
        Me.Controls.Add(Me.TextBoxIDBusquedaCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BuscadorClientes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscador de Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonBusquedaDNICliente As Button
    Friend WithEvents ButtonBusquedaNombreCliente As Button
    Friend WithEvents ButtonBusquedaID As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelBusquedaID As Label
    Friend WithEvents LabelBuscadorClientes As Label
    Friend WithEvents TextBoxBusquedaDNICliente As TextBox
    Friend WithEvents TextBoxBusquedaNombreCliente As TextBox
    Friend WithEvents TextBoxIDBusquedaCliente As TextBox
End Class
