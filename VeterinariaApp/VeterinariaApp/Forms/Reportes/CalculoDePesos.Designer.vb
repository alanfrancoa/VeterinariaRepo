<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculoDePesos
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
        Me.DataGridViewCalculoPesos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDownDesde = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownHasta = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewCalculoPesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDownDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewCalculoPesos
        '
        Me.DataGridViewCalculoPesos.AllowUserToAddRows = False
        Me.DataGridViewCalculoPesos.AllowUserToDeleteRows = False
        Me.DataGridViewCalculoPesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCalculoPesos.Location = New System.Drawing.Point(12, 122)
        Me.DataGridViewCalculoPesos.Name = "DataGridViewCalculoPesos"
        Me.DataGridViewCalculoPesos.ReadOnly = True
        Me.DataGridViewCalculoPesos.Size = New System.Drawing.Size(776, 408)
        Me.DataGridViewCalculoPesos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cálculo de Pesos en Mascotas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownHasta)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownDesde)
        Me.GroupBox1.Location = New System.Drawing.Point(505, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 97)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrado de Edad"
        '
        'NumericUpDownDesde
        '
        Me.NumericUpDownDesde.Location = New System.Drawing.Point(31, 51)
        Me.NumericUpDownDesde.Name = "NumericUpDownDesde"
        Me.NumericUpDownDesde.Size = New System.Drawing.Size(76, 20)
        Me.NumericUpDownDesde.TabIndex = 0
        '
        'NumericUpDownHasta
        '
        Me.NumericUpDownHasta.Location = New System.Drawing.Point(170, 51)
        Me.NumericUpDownHasta.Name = "NumericUpDownHasta"
        Me.NumericUpDownHasta.Size = New System.Drawing.Size(76, 20)
        Me.NumericUpDownHasta.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hasta:"
        '
        'CalculoDePesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 542)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewCalculoPesos)
        Me.Name = "CalculoDePesos"
        Me.Text = "Cálculo de Pesos"
        CType(Me.DataGridViewCalculoPesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDownDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownHasta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewCalculoPesos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDownHasta As NumericUpDown
    Friend WithEvents NumericUpDownDesde As NumericUpDown
End Class
