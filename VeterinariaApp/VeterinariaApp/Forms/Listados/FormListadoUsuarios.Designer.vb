<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListadoUsuarios
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
        Me.DataGridListado = New System.Windows.Forms.DataGridView()
        Me.ButtonVerActivos = New System.Windows.Forms.Button()
        Me.ButtonVerInactivos = New System.Windows.Forms.Button()
        Me.ButtonVerAll = New System.Windows.Forms.Button()
        CType(Me.DataGridListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelListado
        '
        Me.LabelListado.AutoSize = True
        Me.LabelListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelListado.Location = New System.Drawing.Point(316, 9)
        Me.LabelListado.Name = "LabelListado"
        Me.LabelListado.Size = New System.Drawing.Size(169, 20)
        Me.LabelListado.TabIndex = 0
        Me.LabelListado.Text = "Listado de Usuarios"
        '
        'DataGridListado
        '
        Me.DataGridListado.AllowUserToAddRows = False
        Me.DataGridListado.AllowUserToDeleteRows = False
        Me.DataGridListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridListado.Location = New System.Drawing.Point(12, 70)
        Me.DataGridListado.Name = "DataGridListado"
        Me.DataGridListado.ReadOnly = True
        Me.DataGridListado.Size = New System.Drawing.Size(776, 368)
        Me.DataGridListado.TabIndex = 1
        '
        'ButtonVerActivos
        '
        Me.ButtonVerActivos.Location = New System.Drawing.Point(356, 444)
        Me.ButtonVerActivos.Name = "ButtonVerActivos"
        Me.ButtonVerActivos.Size = New System.Drawing.Size(99, 20)
        Me.ButtonVerActivos.TabIndex = 8
        Me.ButtonVerActivos.Text = "Ver Activos"
        Me.ButtonVerActivos.UseVisualStyleBackColor = True
        '
        'ButtonVerInactivos
        '
        Me.ButtonVerInactivos.Location = New System.Drawing.Point(461, 444)
        Me.ButtonVerInactivos.Name = "ButtonVerInactivos"
        Me.ButtonVerInactivos.Size = New System.Drawing.Size(99, 20)
        Me.ButtonVerInactivos.TabIndex = 7
        Me.ButtonVerInactivos.Text = "Ver Inactivos"
        Me.ButtonVerInactivos.UseVisualStyleBackColor = True
        '
        'ButtonVerAll
        '
        Me.ButtonVerAll.Location = New System.Drawing.Point(251, 444)
        Me.ButtonVerAll.Name = "ButtonVerAll"
        Me.ButtonVerAll.Size = New System.Drawing.Size(99, 20)
        Me.ButtonVerAll.TabIndex = 6
        Me.ButtonVerAll.Text = "Ver Todos"
        Me.ButtonVerAll.UseVisualStyleBackColor = True
        '
        'FormListadoUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 475)
        Me.Controls.Add(Me.ButtonVerActivos)
        Me.Controls.Add(Me.ButtonVerInactivos)
        Me.Controls.Add(Me.ButtonVerAll)
        Me.Controls.Add(Me.DataGridListado)
        Me.Controls.Add(Me.LabelListado)
        Me.Name = "FormListadoUsuarios"
        Me.Text = "Listado de Usuarios"
        CType(Me.DataGridListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelListado As Label
    Friend WithEvents DataGridListado As DataGridView
    Friend WithEvents ButtonVerActivos As Button
    Friend WithEvents ButtonVerInactivos As Button
    Friend WithEvents ButtonVerAll As Button
End Class
