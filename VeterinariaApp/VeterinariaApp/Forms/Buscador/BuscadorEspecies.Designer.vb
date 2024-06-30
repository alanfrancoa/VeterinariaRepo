<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscadorEspecies
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonBusquedaMascotasEspecie = New System.Windows.Forms.Button()
        Me.ButtonBusquedaEspecieDetalle = New System.Windows.Forms.Button()
        Me.LabelBusquedaID = New System.Windows.Forms.Label()
        Me.LabelBuscadorEspecies = New System.Windows.Forms.Label()
        Me.TextBoxEspecieMascotas = New System.Windows.Forms.TextBox()
        Me.TextBoxEspecieDetalle = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 15)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Nombre de especie (mascotas)"
        '
        'ButtonBusquedaMascotasEspecie
        '
        Me.ButtonBusquedaMascotasEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBusquedaMascotasEspecie.Location = New System.Drawing.Point(430, 192)
        Me.ButtonBusquedaMascotasEspecie.Name = "ButtonBusquedaMascotasEspecie"
        Me.ButtonBusquedaMascotasEspecie.Size = New System.Drawing.Size(35, 40)
        Me.ButtonBusquedaMascotasEspecie.TabIndex = 25
        Me.ButtonBusquedaMascotasEspecie.Text = "🔍"
        Me.ButtonBusquedaMascotasEspecie.UseVisualStyleBackColor = True
        '
        'ButtonBusquedaEspecieDetalle
        '
        Me.ButtonBusquedaEspecieDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBusquedaEspecieDetalle.Location = New System.Drawing.Point(430, 128)
        Me.ButtonBusquedaEspecieDetalle.Name = "ButtonBusquedaEspecieDetalle"
        Me.ButtonBusquedaEspecieDetalle.Size = New System.Drawing.Size(35, 40)
        Me.ButtonBusquedaEspecieDetalle.TabIndex = 24
        Me.ButtonBusquedaEspecieDetalle.Text = "🔍"
        Me.ButtonBusquedaEspecieDetalle.UseVisualStyleBackColor = True
        '
        'LabelBusquedaID
        '
        Me.LabelBusquedaID.AutoSize = True
        Me.LabelBusquedaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBusquedaID.Location = New System.Drawing.Point(119, 128)
        Me.LabelBusquedaID.Name = "LabelBusquedaID"
        Me.LabelBusquedaID.Size = New System.Drawing.Size(169, 15)
        Me.LabelBusquedaID.TabIndex = 23
        Me.LabelBusquedaID.Text = "Nombre de especie (detalles)"
        '
        'LabelBuscadorEspecies
        '
        Me.LabelBuscadorEspecies.AutoSize = True
        Me.LabelBuscadorEspecies.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBuscadorEspecies.Location = New System.Drawing.Point(235, 72)
        Me.LabelBuscadorEspecies.Name = "LabelBuscadorEspecies"
        Me.LabelBuscadorEspecies.Size = New System.Drawing.Size(144, 16)
        Me.LabelBuscadorEspecies.TabIndex = 22
        Me.LabelBuscadorEspecies.Text = "Buscador de Especies"
        '
        'TextBoxEspecieMascotas
        '
        Me.TextBoxEspecieMascotas.Location = New System.Drawing.Point(119, 212)
        Me.TextBoxEspecieMascotas.Name = "TextBoxEspecieMascotas"
        Me.TextBoxEspecieMascotas.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxEspecieMascotas.TabIndex = 21
        '
        'TextBoxEspecieDetalle
        '
        Me.TextBoxEspecieDetalle.Location = New System.Drawing.Point(119, 144)
        Me.TextBoxEspecieDetalle.Name = "TextBoxEspecieDetalle"
        Me.TextBoxEspecieDetalle.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxEspecieDetalle.TabIndex = 20
        '
        'BuscadorEspecies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 336)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonBusquedaMascotasEspecie)
        Me.Controls.Add(Me.ButtonBusquedaEspecieDetalle)
        Me.Controls.Add(Me.LabelBusquedaID)
        Me.Controls.Add(Me.LabelBuscadorEspecies)
        Me.Controls.Add(Me.TextBoxEspecieMascotas)
        Me.Controls.Add(Me.TextBoxEspecieDetalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BuscadorEspecies"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscador de Especies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonBusquedaMascotasEspecie As Button
    Friend WithEvents ButtonBusquedaEspecieDetalle As Button
    Friend WithEvents LabelBusquedaID As Label
    Friend WithEvents LabelBuscadorEspecies As Label
    Friend WithEvents TextBoxEspecieMascotas As TextBox
    Friend WithEvents TextBoxEspecieDetalle As TextBox
End Class
