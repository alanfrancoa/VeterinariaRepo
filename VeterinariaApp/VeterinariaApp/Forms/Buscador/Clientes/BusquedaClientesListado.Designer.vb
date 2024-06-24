<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaClientesListado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridViewClientesBusqueda = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewClientesBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewClientesBusqueda
        '
        Me.DataGridViewClientesBusqueda.AllowUserToAddRows = False
        Me.DataGridViewClientesBusqueda.AllowUserToDeleteRows = False
        Me.DataGridViewClientesBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClientesBusqueda.Location = New System.Drawing.Point(13, 54)
        Me.DataGridViewClientesBusqueda.Name = "DataGridViewClientesBusqueda"
        Me.DataGridViewClientesBusqueda.ReadOnly = True
        Me.DataGridViewClientesBusqueda.Size = New System.Drawing.Size(774, 381)
        Me.DataGridViewClientesBusqueda.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(310, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Resultado de Busqueda"
        '
        'BusquedaClientesListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridViewClientesBusqueda)
        Me.Controls.Add(Me.Label7)
        Me.Name = "BusquedaClientesListado"
        Me.Text = "Listado de Clientes por Nombre"
        CType(Me.DataGridViewClientesBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewClientesBusqueda As DataGridView
    Friend WithEvents Label7 As Label
End Class
