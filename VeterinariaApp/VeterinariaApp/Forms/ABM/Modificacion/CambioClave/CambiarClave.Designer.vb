<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarClave
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxActual = New System.Windows.Forms.TextBox()
        Me.TextBoxNueva = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxRepetir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonSubir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cambiar Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(166, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña Actual:"
        '
        'TextBoxActual
        '
        Me.TextBoxActual.Location = New System.Drawing.Point(169, 135)
        Me.TextBoxActual.Name = "TextBoxActual"
        Me.TextBoxActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxActual.Size = New System.Drawing.Size(250, 20)
        Me.TextBoxActual.TabIndex = 2
        '
        'TextBoxNueva
        '
        Me.TextBoxNueva.Location = New System.Drawing.Point(169, 202)
        Me.TextBoxNueva.Name = "TextBoxNueva"
        Me.TextBoxNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxNueva.Size = New System.Drawing.Size(250, 20)
        Me.TextBoxNueva.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(166, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nueva Contraseña:"
        '
        'TextBoxRepetir
        '
        Me.TextBoxRepetir.Location = New System.Drawing.Point(169, 266)
        Me.TextBoxRepetir.Name = "TextBoxRepetir"
        Me.TextBoxRepetir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxRepetir.Size = New System.Drawing.Size(250, 20)
        Me.TextBoxRepetir.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(166, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Repetir Nueva Contraseña:"
        '
        'ButtonSubir
        '
        Me.ButtonSubir.Location = New System.Drawing.Point(236, 377)
        Me.ButtonSubir.Name = "ButtonSubir"
        Me.ButtonSubir.Size = New System.Drawing.Size(113, 47)
        Me.ButtonSubir.TabIndex = 7
        Me.ButtonSubir.Text = "Cambiar Contraseña"
        Me.ButtonSubir.UseVisualStyleBackColor = True
        '
        'CambiarClave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 436)
        Me.Controls.Add(Me.ButtonSubir)
        Me.Controls.Add(Me.TextBoxRepetir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxNueva)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxActual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CambiarClave"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Clave"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxActual As TextBox
    Friend WithEvents TextBoxNueva As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxRepetir As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonSubir As Button
End Class
