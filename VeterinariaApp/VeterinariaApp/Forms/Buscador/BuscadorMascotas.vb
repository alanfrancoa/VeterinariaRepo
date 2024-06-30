Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models

Public Class BuscadorMascotas
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
    ''' Método para buscar cliente por ID
    ''' </summary>
    Private Sub ButtonBusquedaIDMascota_Click(sender As Object, e As EventArgs) Handles ButtonBusquedaIDMascota.Click
        Dim id As Integer

        If Integer.TryParse(TextBoxIDBusquedaMascota.Text, id) Then
            _mascotaSeleccionada = _contenedorMascotas.buscarPorID(id)
            If _mascotaSeleccionada IsNot Nothing Then
                Me.Close()
                MessageBox.Show($"Cliente encontrado: {_mascotaSeleccionada.Nombre}", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                'llamamos al form de muestra de informacion
                Dim formMuestraMascota As New BusquedaMascota(_mascotaSeleccionada)
                formMuestraMascota.Show()
            Else
                MessageBox.Show("Cliente no encontrado.", "Dato no existente", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            End If
        Else
            MessageBox.Show("Por favor, ingrese un ID válido.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        End If
    End Sub

    Private Sub ButtonBusquedaDNIClienteMasota_Click(sender As Object, e As EventArgs) Handles ButtonBusquedaDNIClienteMasota.Click
        Dim dni As Integer

        If Integer.TryParse(TextBoxBusquedaClienteDNIMascota.Text, dni) Then
            Dim listadoMascotasPorDNI As List(Of Mascota) = _contenedorMascotas.BuscarMascotasPorDNICliente(_mascotaSeleccionada.IdCliente)
            If listadoMascotasPorDNI IsNot Nothing AndAlso listadoMascotasPorDNI.Count > 0 Then
                Dim formListadoDeMascotasDNI As New BusquedaMascotaListado(listadoMascotasPorDNI)
                formListadoDeMascotasDNI.Show()
            Else
                MessageBox.Show("No hay clientes con el nombre ingresado.", "Dato no existente", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            End If

        Else
            MessageBox.Show("Por favor, ingrese un DNI válido.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        End If
        Me.Close()
    End Sub

    Private Sub ButtonBusquedaMascotaNombre_Click(sender As Object, e As EventArgs) Handles ButtonBusquedaMascotaNombre.Click
        Dim nombreABuscar = TextBoxBusquedaNombreMascota.Text.Trim()


        If String.IsNullOrEmpty(nombreABuscar) Then
            MessageBox.Show("Ingrese un valor a buscar.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Else
            Dim listadoMascotasNombre As List(Of Mascota) = _contenedorMascotas.BuscarMascotasPorNombre(nombreABuscar)

            If listadoMascotasNombre IsNot Nothing AndAlso listadoMascotasNombre.Count > 0 Then
                Dim formListadoMascotasNombre As New BusquedaMascotaListado(listadoMascotasNombre)
                formListadoMascotasNombre.Show()
            Else
                MessageBox.Show("No hay clientes con el nombre ingresado.", "Dato no existente", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

            End If
        End If
        Me.Close()
    End Sub
End Class