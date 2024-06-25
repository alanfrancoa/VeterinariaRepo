Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models

Public Class SelectorBajaMascotas
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
                MessageBox.Show($"Mascota encontrada: {_mascotaSeleccionada.Nombre}")
                ' Llamar al formulario de eliminacion de clientes
                Dim formMuestraBajaMascota As New MuestraMascotaBaja(_mascotaSeleccionada)
                formMuestraBajaMascota.Show()
            Else
                MessageBox.Show("Cliente no encontrado.")
            End If
        Else
            MessageBox.Show("Por favor, ingrese un DNI válido.")
        End If

    End Sub


End Class