﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaMascotaListado
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
        Me.DataGridViewMascotasBusqueda = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewMascotasBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewMascotasBusqueda
        '
        Me.DataGridViewMascotasBusqueda.AllowUserToAddRows = False
        Me.DataGridViewMascotasBusqueda.AllowUserToDeleteRows = False
        Me.DataGridViewMascotasBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMascotasBusqueda.Location = New System.Drawing.Point(13, 54)
        Me.DataGridViewMascotasBusqueda.Name = "DataGridViewMascotasBusqueda"
        Me.DataGridViewMascotasBusqueda.ReadOnly = True
        Me.DataGridViewMascotasBusqueda.Size = New System.Drawing.Size(774, 381)
        Me.DataGridViewMascotasBusqueda.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(310, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Resultado de Busqueda"
        '
        'BusquedaMascotaListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridViewMascotasBusqueda)
        Me.Controls.Add(Me.Label7)
        Me.Name = "BusquedaMascotaListado"
        Me.Text = "Listado de Mascotas"
        CType(Me.DataGridViewMascotasBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewMascotasBusqueda As DataGridView
    Friend WithEvents Label7 As Label
End Class
