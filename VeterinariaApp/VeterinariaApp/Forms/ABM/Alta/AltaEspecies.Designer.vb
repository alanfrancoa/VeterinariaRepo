<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaEspecies
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelAltaEspecies = New System.Windows.Forms.Label()
        Me.TextBoxPesoProm = New System.Windows.Forms.TextBox()
        Me.TextBoxE_Madurez = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button1.Location = New System.Drawing.Point(348, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 47)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelAltaEspecies
        '
        Me.LabelAltaEspecies.AutoSize = True
        Me.LabelAltaEspecies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAltaEspecies.Location = New System.Drawing.Point(344, 57)
        Me.LabelAltaEspecies.Name = "LabelAltaEspecies"
        Me.LabelAltaEspecies.Size = New System.Drawing.Size(119, 20)
        Me.LabelAltaEspecies.TabIndex = 30
        Me.LabelAltaEspecies.Text = "Alta Especies"
        '
        'TextBoxPesoProm
        '
        Me.TextBoxPesoProm.Location = New System.Drawing.Point(281, 208)
        Me.TextBoxPesoProm.Name = "TextBoxPesoProm"
        Me.TextBoxPesoProm.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxPesoProm.TabIndex = 29
        '
        'TextBoxE_Madurez
        '
        Me.TextBoxE_Madurez.Location = New System.Drawing.Point(281, 165)
        Me.TextBoxE_Madurez.Name = "TextBoxE_Madurez"
        Me.TextBoxE_Madurez.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxE_Madurez.TabIndex = 28
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(281, 125)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxNombre.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(278, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Peso Promedio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Edad Madurez:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nombre:"
        '
        'AltaEspecies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelAltaEspecies)
        Me.Controls.Add(Me.TextBoxPesoProm)
        Me.Controls.Add(Me.TextBoxE_Madurez)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "AltaEspecies"
        Me.Text = "AltaEspecies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents LabelAltaEspecies As Label
    Friend WithEvents TextBoxPesoProm As TextBox
    Friend WithEvents TextBoxE_Madurez As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
