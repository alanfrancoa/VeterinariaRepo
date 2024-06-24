<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CantidadDeAnimales
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
        Me.DataGridViewCantidadMascotas = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewCantidadMascotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cantidad de Mascotas por Dueño"
        '
        'DataGridViewCantidadMascotas
        '
        Me.DataGridViewCantidadMascotas.AllowUserToAddRows = False
        Me.DataGridViewCantidadMascotas.AllowUserToDeleteRows = False
        Me.DataGridViewCantidadMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCantidadMascotas.Location = New System.Drawing.Point(12, 91)
        Me.DataGridViewCantidadMascotas.Name = "DataGridViewCantidadMascotas"
        Me.DataGridViewCantidadMascotas.ReadOnly = True
        Me.DataGridViewCantidadMascotas.Size = New System.Drawing.Size(776, 408)
        Me.DataGridViewCantidadMascotas.TabIndex = 3
        '
        'CantidadDeAnimales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 510)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewCantidadMascotas)
        Me.Name = "CantidadDeAnimales"
        Me.Text = "CantidadDeAnimales"
        CType(Me.DataGridViewCantidadMascotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewCantidadMascotas As DataGridView
End Class
