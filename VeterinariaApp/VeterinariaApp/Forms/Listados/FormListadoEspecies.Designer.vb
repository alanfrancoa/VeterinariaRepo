﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListadoEspecies
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
        Me.DataGridListado = New System.Windows.Forms.DataGridView()
        Me.LabelListado = New System.Windows.Forms.Label()
        CType(Me.DataGridListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridListado
        '
        Me.DataGridListado.AllowUserToAddRows = False
        Me.DataGridListado.AllowUserToDeleteRows = False
        Me.DataGridListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridListado.Location = New System.Drawing.Point(12, 59)
        Me.DataGridListado.Name = "DataGridListado"
        Me.DataGridListado.ReadOnly = True
        Me.DataGridListado.Size = New System.Drawing.Size(776, 368)
        Me.DataGridListado.TabIndex = 10
        '
        'LabelListado
        '
        Me.LabelListado.AutoSize = True
        Me.LabelListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelListado.Location = New System.Drawing.Point(316, 9)
        Me.LabelListado.Name = "LabelListado"
        Me.LabelListado.Size = New System.Drawing.Size(171, 20)
        Me.LabelListado.TabIndex = 9
        Me.LabelListado.Text = "Listado de Especies"
        '
        'FormListadoEspecies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridListado)
        Me.Controls.Add(Me.LabelListado)
        Me.Name = "FormListadoEspecies"
        Me.Text = "FormListadoEspecies"
        CType(Me.DataGridListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridListado As DataGridView
    Friend WithEvents LabelListado As Label
End Class