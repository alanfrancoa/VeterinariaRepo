﻿Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models

Public Class SelectorMascota
    Private _contenedorMascotas As ContenedorMascotas
    Private _mascotaSeleccionada As Mascota
    ''' <summary>
    ''' Constructor del formulario
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        _contenedorMascotas = New ContenedorMascotas()
    End Sub
    ''' <summary>
    ''' Método para buscar mascota por ID
    ''' </summary>
    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim id As Integer

        If Integer.TryParse(TextBoxID.Text, id) Then
            _mascotaSeleccionada = _contenedorMascotas.buscarPorID(id)
            If _mascotaSeleccionada IsNot Nothing Then
                Me.Close()
                MessageBox.Show($"Mascota encontrada: {_mascotaSeleccionada.Nombre}", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                ' Llamar al formulario de edición de clientes
                Dim formMuestra As New MuestraMascota(_mascotaSeleccionada)
                formMuestra.Show()
            Else
                MessageBox.Show("Mascota no encontrada.", "Dato no existente", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            End If
        Else
            MessageBox.Show("Ingrese un ID válido.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        End If
    End Sub
End Class