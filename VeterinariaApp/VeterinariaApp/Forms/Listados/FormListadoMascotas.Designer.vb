<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListadoMascotas
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
        Me.LabelListado = New System.Windows.Forms.Label()
        Me.DataGridMascotas = New System.Windows.Forms.DataGridView()
        Me.ButtonVerAll = New System.Windows.Forms.Button()
        Me.ButtonVerActivos = New System.Windows.Forms.Button()
        Me.ButtonVerInactivos = New System.Windows.Forms.Button()
        CType(Me.DataGridMascotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelListado
        '
        Me.LabelListado.AutoSize = True
        Me.LabelListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelListado.Location = New System.Drawing.Point(313, 9)
        Me.LabelListado.Name = "LabelListado"
        Me.LabelListado.Size = New System.Drawing.Size(175, 20)
        Me.LabelListado.TabIndex = 2
        Me.LabelListado.Text = "Listado de Mascotas"
        '
        'DataGridMascotas
        '
        Me.DataGridMascotas.AllowUserToAddRows = False
        Me.DataGridMascotas.AllowUserToDeleteRows = False
        Me.DataGridMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMascotas.Location = New System.Drawing.Point(12, 50)
        Me.DataGridMascotas.Name = "DataGridMascotas"
        Me.DataGridMascotas.ReadOnly = True
        Me.DataGridMascotas.Size = New System.Drawing.Size(776, 368)
        Me.DataGridMascotas.TabIndex = 3
        '
        'ButtonVerAll
        '
        Me.ButtonVerAll.Location = New System.Drawing.Point(246, 424)
        Me.ButtonVerAll.Name = "ButtonVerAll"
        Me.ButtonVerAll.Size = New System.Drawing.Size(99, 20)
        Me.ButtonVerAll.TabIndex = 4
        Me.ButtonVerAll.Text = "Ver Todos"
        Me.ButtonVerAll.UseVisualStyleBackColor = True
        '
        'ButtonVerActivos
        '
        Me.ButtonVerActivos.Location = New System.Drawing.Point(351, 424)
        Me.ButtonVerActivos.Name = "ButtonVerActivos"
        Me.ButtonVerActivos.Size = New System.Drawing.Size(99, 20)
        Me.ButtonVerActivos.TabIndex = 5
        Me.ButtonVerActivos.Text = "Ver Activos"
        Me.ButtonVerActivos.UseVisualStyleBackColor = True
        '
        'ButtonVerInactivos
        '
        Me.ButtonVerInactivos.Location = New System.Drawing.Point(456, 424)
        Me.ButtonVerInactivos.Name = "ButtonVerInactivos"
        Me.ButtonVerInactivos.Size = New System.Drawing.Size(99, 20)
        Me.ButtonVerInactivos.TabIndex = 6
        Me.ButtonVerInactivos.Text = "Ver Inactivos"
        Me.ButtonVerInactivos.UseVisualStyleBackColor = True
        '
        'FormListadoMascotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonVerInactivos)
        Me.Controls.Add(Me.ButtonVerActivos)
        Me.Controls.Add(Me.ButtonVerAll)
        Me.Controls.Add(Me.DataGridMascotas)
        Me.Controls.Add(Me.LabelListado)
        Me.Name = "FormListadoMascotas"
        Me.Text = "FormListadoMascotas"
        CType(Me.DataGridMascotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelListado As Label
    Friend WithEvents DataGridMascotas As DataGridView
    Friend WithEvents ButtonVerAll As Button
    Friend WithEvents ButtonVerActivos As Button
    Friend WithEvents ButtonVerInactivos As Button
End Class
