<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListadoClientes
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
        Me.DataGridClientes = New System.Windows.Forms.DataGridView()
        Me.ButtonVerAll = New System.Windows.Forms.Button()
        Me.ButtonVerInactivos = New System.Windows.Forms.Button()
        Me.ButtonVerActivos = New System.Windows.Forms.Button()
        CType(Me.DataGridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelListado
        '
        Me.LabelListado.AutoSize = True
        Me.LabelListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelListado.Location = New System.Drawing.Point(319, 9)
        Me.LabelListado.Name = "LabelListado"
        Me.LabelListado.Size = New System.Drawing.Size(163, 20)
        Me.LabelListado.TabIndex = 1
        Me.LabelListado.Text = "Listado de Clientes"
        '
        'DataGridClientes
        '
        Me.DataGridClientes.AllowUserToAddRows = False
        Me.DataGridClientes.AllowUserToDeleteRows = False
        Me.DataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridClientes.Location = New System.Drawing.Point(12, 70)
        Me.DataGridClientes.Name = "DataGridClientes"
        Me.DataGridClientes.ReadOnly = True
        Me.DataGridClientes.Size = New System.Drawing.Size(776, 368)
        Me.DataGridClientes.TabIndex = 2
        '
        'ButtonVerAll
        '
        Me.ButtonVerAll.Location = New System.Drawing.Point(246, 444)
        Me.ButtonVerAll.Name = "ButtonVerAll"
        Me.ButtonVerAll.Size = New System.Drawing.Size(99, 20)
        Me.ButtonVerAll.TabIndex = 3
        Me.ButtonVerAll.Text = "Ver Todos"
        Me.ButtonVerAll.UseVisualStyleBackColor = True
        '
        'ButtonVerInactivos
        '
        Me.ButtonVerInactivos.Location = New System.Drawing.Point(456, 444)
        Me.ButtonVerInactivos.Name = "ButtonVerInactivos"
        Me.ButtonVerInactivos.Size = New System.Drawing.Size(99, 20)
        Me.ButtonVerInactivos.TabIndex = 4
        Me.ButtonVerInactivos.Text = "Ver Inactivos"
        Me.ButtonVerInactivos.UseVisualStyleBackColor = True
        '
        'ButtonVerActivos
        '
        Me.ButtonVerActivos.Location = New System.Drawing.Point(351, 444)
        Me.ButtonVerActivos.Name = "ButtonVerActivos"
        Me.ButtonVerActivos.Size = New System.Drawing.Size(99, 20)
        Me.ButtonVerActivos.TabIndex = 5
        Me.ButtonVerActivos.Text = "Ver Activos"
        Me.ButtonVerActivos.UseVisualStyleBackColor = True
        '
        'FormListadoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 470)
        Me.Controls.Add(Me.ButtonVerActivos)
        Me.Controls.Add(Me.ButtonVerInactivos)
        Me.Controls.Add(Me.ButtonVerAll)
        Me.Controls.Add(Me.DataGridClientes)
        Me.Controls.Add(Me.LabelListado)
        Me.Name = "FormListadoClientes"
        Me.Text = "FormListadoClientes"
        CType(Me.DataGridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelListado As Label
    Friend WithEvents DataGridClientes As DataGridView
    Friend WithEvents ButtonVerAll As Button
    Friend WithEvents ButtonVerInactivos As Button
    Friend WithEvents ButtonVerActivos As Button
End Class
