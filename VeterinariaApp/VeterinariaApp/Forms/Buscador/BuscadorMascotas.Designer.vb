<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscadorMascotas
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
        Me.ButtonBusquedaMascotaNombre = New System.Windows.Forms.Button()
        Me.ButtonBusquedaDNIClienteMasota = New System.Windows.Forms.Button()
        Me.ButtonBusquedaIDMascota = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelBusquedaID = New System.Windows.Forms.Label()
        Me.LabelBuscadorClientes = New System.Windows.Forms.Label()
        Me.TextBoxBusquedaNombreMascota = New System.Windows.Forms.TextBox()
        Me.TextBoxBusquedaClienteDNIMascota = New System.Windows.Forms.TextBox()
        Me.TextBoxIDBusquedaMascota = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonBusquedaMascotaNombre
        '
        Me.ButtonBusquedaMascotaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBusquedaMascotaNombre.Location = New System.Drawing.Point(437, 274)
        Me.ButtonBusquedaMascotaNombre.Name = "ButtonBusquedaMascotaNombre"
        Me.ButtonBusquedaMascotaNombre.Size = New System.Drawing.Size(35, 40)
        Me.ButtonBusquedaMascotaNombre.TabIndex = 29
        Me.ButtonBusquedaMascotaNombre.Text = "🔍"
        Me.ButtonBusquedaMascotaNombre.UseVisualStyleBackColor = True
        '
        'ButtonBusquedaDNIClienteMasota
        '
        Me.ButtonBusquedaDNIClienteMasota.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBusquedaDNIClienteMasota.Location = New System.Drawing.Point(437, 206)
        Me.ButtonBusquedaDNIClienteMasota.Name = "ButtonBusquedaDNIClienteMasota"
        Me.ButtonBusquedaDNIClienteMasota.Size = New System.Drawing.Size(35, 40)
        Me.ButtonBusquedaDNIClienteMasota.TabIndex = 28
        Me.ButtonBusquedaDNIClienteMasota.Text = "🔍"
        Me.ButtonBusquedaDNIClienteMasota.UseVisualStyleBackColor = True
        '
        'ButtonBusquedaIDMascota
        '
        Me.ButtonBusquedaIDMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBusquedaIDMascota.Location = New System.Drawing.Point(437, 142)
        Me.ButtonBusquedaIDMascota.Name = "ButtonBusquedaIDMascota"
        Me.ButtonBusquedaIDMascota.Size = New System.Drawing.Size(35, 40)
        Me.ButtonBusquedaIDMascota.TabIndex = 27
        Me.ButtonBusquedaIDMascota.Text = "🔍"
        Me.ButtonBusquedaIDMascota.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(126, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Por Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Por DNI de Cliente:"
        '
        'LabelBusquedaID
        '
        Me.LabelBusquedaID.AutoSize = True
        Me.LabelBusquedaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBusquedaID.Location = New System.Drawing.Point(126, 142)
        Me.LabelBusquedaID.Name = "LabelBusquedaID"
        Me.LabelBusquedaID.Size = New System.Drawing.Size(44, 15)
        Me.LabelBusquedaID.TabIndex = 24
        Me.LabelBusquedaID.Text = "Por ID:"
        '
        'LabelBuscadorClientes
        '
        Me.LabelBuscadorClientes.AutoSize = True
        Me.LabelBuscadorClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBuscadorClientes.Location = New System.Drawing.Point(226, 51)
        Me.LabelBuscadorClientes.Name = "LabelBuscadorClientes"
        Me.LabelBuscadorClientes.Size = New System.Drawing.Size(146, 16)
        Me.LabelBuscadorClientes.TabIndex = 23
        Me.LabelBuscadorClientes.Text = "Buscador de Mascotas"
        '
        'TextBoxBusquedaNombreMascota
        '
        Me.TextBoxBusquedaNombreMascota.Location = New System.Drawing.Point(126, 294)
        Me.TextBoxBusquedaNombreMascota.Name = "TextBoxBusquedaNombreMascota"
        Me.TextBoxBusquedaNombreMascota.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxBusquedaNombreMascota.TabIndex = 22
        '
        'TextBoxBusquedaClienteDNIMascota
        '
        Me.TextBoxBusquedaClienteDNIMascota.Location = New System.Drawing.Point(126, 226)
        Me.TextBoxBusquedaClienteDNIMascota.Name = "TextBoxBusquedaClienteDNIMascota"
        Me.TextBoxBusquedaClienteDNIMascota.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxBusquedaClienteDNIMascota.TabIndex = 21
        '
        'TextBoxIDBusquedaMascota
        '
        Me.TextBoxIDBusquedaMascota.Location = New System.Drawing.Point(126, 158)
        Me.TextBoxIDBusquedaMascota.Name = "TextBoxIDBusquedaMascota"
        Me.TextBoxIDBusquedaMascota.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxIDBusquedaMascota.TabIndex = 20
        '
        'BuscadorMascotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 450)
        Me.Controls.Add(Me.ButtonBusquedaMascotaNombre)
        Me.Controls.Add(Me.ButtonBusquedaDNIClienteMasota)
        Me.Controls.Add(Me.ButtonBusquedaIDMascota)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelBusquedaID)
        Me.Controls.Add(Me.LabelBuscadorClientes)
        Me.Controls.Add(Me.TextBoxBusquedaNombreMascota)
        Me.Controls.Add(Me.TextBoxBusquedaClienteDNIMascota)
        Me.Controls.Add(Me.TextBoxIDBusquedaMascota)
        Me.Name = "BuscadorMascotas"
        Me.Text = "Buscador de Mascotas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonBusquedaMascotaNombre As Button
    Friend WithEvents ButtonBusquedaDNIClienteMasota As Button
    Friend WithEvents ButtonBusquedaIDMascota As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelBusquedaID As Label
    Friend WithEvents LabelBuscadorClientes As Label
    Friend WithEvents TextBoxBusquedaNombreMascota As TextBox
    Friend WithEvents TextBoxBusquedaClienteDNIMascota As TextBox
    Friend WithEvents TextBoxIDBusquedaMascota As TextBox
End Class
