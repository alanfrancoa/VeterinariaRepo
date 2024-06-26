Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models

Public Class BuscadorEspecies
    Private _contenedorEspecies As ContenedorEspecies
    Private _contenedorMascotas As ContenedorMascotas
    Private _especieSeleccionada As Especie

    ''' <summary>
    ''' Constructor del formulario
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        _contenedorEspecies = New ContenedorEspecies()
        _contenedorMascotas = New ContenedorMascotas()

    End Sub

    ''' <summary>
    ''' Método para buscar especie por nombre
    ''' </summary>
    Private Sub ButtonBusquedaEspecieDetalle_Click(sender As Object, e As EventArgs) Handles ButtonBusquedaEspecieDetalle.Click
        Dim nombreABuscar = TextBoxEspecieDetalle.Text

        If String.IsNullOrEmpty(nombreABuscar) Then
            MessageBox.Show("Ingrese un valor a buscar")
        Else
            _especieSeleccionada = _contenedorEspecies.BuscarPorNombre(nombreABuscar)
            If _especieSeleccionada IsNot Nothing Then
                Me.Close()
                MessageBox.Show($"Especie encontrada: {_especieSeleccionada.Nombre} ")
                'llamamos al form de muestra de informacion
                Dim formMuestraEspecie As New BusquedaEspecie(_especieSeleccionada)
                formMuestraEspecie.Show()
            End If
        End If
    End Sub

    Private Sub ButtonBusquedaMascotasEspecie_Click(sender As Object, e As EventArgs) Handles ButtonBusquedaMascotasEspecie.Click
        Dim nombreDeEspecieABuscar = TextBoxEspecieMascotas.Text

        If String.IsNullOrEmpty(nombreDeEspecieABuscar) Then
            MessageBox.Show("Ingrese un valor a buscar")
        Else
            Dim especie = _contenedorEspecies.BuscarPorNombre(nombreDeEspecieABuscar)

            If especie IsNot Nothing Then
                Dim listadoMascotasEspecie As List(Of Mascota) = _contenedorMascotas.BuscarMascotasPorIdEspecie(especie.Id)

                If listadoMascotasEspecie IsNot Nothing AndAlso listadoMascotasEspecie.Count > 0 Then
                    Dim formListadoMascotasEspecie As New BusquedaMascotaListado(listadoMascotasEspecie)
                    formListadoMascotasEspecie.Show()
                Else
                    MessageBox.Show("No hay mascotas con el texto ingresado.")
                End If
            End If
        End If
    End Sub


End Class