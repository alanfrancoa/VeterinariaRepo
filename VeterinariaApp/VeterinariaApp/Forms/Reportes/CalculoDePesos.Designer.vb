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
        Me.ButtonBusqueda = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownHasta = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownDesde = New System.Windows.Forms.NumericUpDown()
        CType(Me.DataGridViewCalculoPesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDownHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewCalculoPesos
        '
        Me.DataGridViewCalculoPesos.AllowUserToAddRows = False
        Me.DataGridViewCalculoPesos.AllowUserToDeleteRows = False
        Me.DataGridViewCalculoPesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewCalculoPesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCalculoPesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCalculoPesos.Location = New System.Drawing.Point(16, 117)
        Me.DataGridViewCalculoPesos.Name = "DataGridViewCalculoPesos"
        Me.DataGridViewCalculoPesos.ReadOnly = True
        Me.DataGridViewCalculoPesos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridViewCalculoPesos.Size = New System.Drawing.Size(950, 450)
        Me.DataGridViewCalculoPesos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cálculo de Pesos en Mascotas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonBusqueda)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownHasta)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownDesde)
        Me.GroupBox1.Location = New System.Drawing.Point(684, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 97)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrado de Edad"
        '
        'ButtonBusqueda
        '
        Me.ButtonBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBusqueda.Location = New System.Drawing.Point(227, 34)
        Me.ButtonBusqueda.Name = "ButtonBusqueda"
        Me.ButtonBusqueda.Size = New System.Drawing.Size(35, 40)
        Me.ButtonBusqueda.TabIndex = 18
        Me.ButtonBusqueda.Text = "🔍"
        Me.ButtonBusqueda.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hasta:"
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
        'NumericUpDownHasta
        '
        Me.NumericUpDownHasta.Location = New System.Drawing.Point(130, 51)
        Me.NumericUpDownHasta.Name = "NumericUpDownHasta"
        Me.NumericUpDownHasta.Size = New System.Drawing.Size(76, 20)
        Me.NumericUpDownHasta.TabIndex = 1
        '
        'NumericUpDownDesde
        '
        Me.NumericUpDownDesde.Location = New System.Drawing.Point(31, 51)
        Me.NumericUpDownDesde.Name = "NumericUpDownDesde"
        Me.NumericUpDownDesde.Size = New System.Drawing.Size(76, 20)
        Me.NumericUpDownDesde.TabIndex = 0
        '
        'CalculoDePesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 586)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewCalculoPesos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CalculoDePesos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cálculo de Pesos"
        CType(Me.DataGridViewCalculoPesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDownHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownDesde, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ButtonBusqueda As Button
End Class
