Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models

Public Class BuscadorClientes
    Private _contenedorClientes As ContenedorClientes
    Private _clienteSeleccionado As Cliente
    ''' <summary>
    ''' Constructor del formulario
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        _contenedorClientes = New ContenedorClientes()
    End Sub

    ''' <summary>
    ''' Método para buscar cliente por ID
    ''' </summary>
    Private Sub ButtonBusquedaID_Click(sender As Object, e As EventArgs) Handles ButtonBusquedaID.Click
        Dim id As Integer

        If Integer.TryParse(TextBoxIDBusquedaCliente.Text, id) Then
            _clienteSeleccionado = _contenedorClientes.BuscarClientePorID(id)
            If _clienteSeleccionado IsNot Nothing Then
                Me.Close()
                MessageBox.Show($"Cliente encontrado: {_clienteSeleccionado.Nombre}")
                'llamamos al form de muestra de informacion
                Dim formMuestra As New BusquedaCliente(_clienteSeleccionado)
                formMuestra.Show()
            Else
                MessageBox.Show("Cliente no encontrado.")
            End If
        Else
            MessageBox.Show("Por favor, ingrese un ID válido.")
        End If
    End Sub

    ''' <summary>
    ''' Método para buscar cliente por DNI
    ''' 
    ''' </summary>
    Private Sub ButtonBusquedaDNICliente_Click(sender As Object, e As EventArgs) Handles ButtonBusquedaDNICliente.Click
        Dim dni As Integer

        If Integer.TryParse(TextBoxBusquedaDNICliente.Text, dni) Then
            _clienteSeleccionado = _contenedorClientes.buscarPorDni(dni)
            If _clienteSeleccionado IsNot Nothing Then
                Me.Close()
                MessageBox.Show($"Cliente encontrado: {_clienteSeleccionado.Nombre}")
                'llamamos al form de muestra de informacion
                Dim formMuestra As New BusquedaCliente(_clienteSeleccionado)
                formMuestra.Show()
            Else
                MessageBox.Show("Cliente no encontrado.")
            End If
        Else
            MessageBox.Show("Por favor, ingrese un DNI válido.")
        End If
    End Sub

    ''' <summary>
    ''' Método para buscar cliente por nombre
    ''' </summary>
    Private Sub ButtonBusquedaNombreCliente_Click(sender As Object, e As EventArgs) Handles ButtonBusquedaNombreCliente.Click
        Dim nombreABuscar = TextBoxBusquedaNombreCliente.Text.Trim()

        If String.IsNullOrEmpty(nombreABuscar) Then
            MessageBox.Show("Ingrese un valor a buscar")
        Else
            Dim listadoClientesNombre As List(Of Cliente) = _contenedorClientes.BuscarClientesPorNombre(nombreABuscar)

            If listadoClientesNombre IsNot Nothing AndAlso listadoClientesNombre.Count > 0 Then
                Dim formListadoDeClientesNombre As New BusquedaClientesListado(listadoClientesNombre)
                formListadoDeClientesNombre.Show()
            Else
                MessageBox.Show("No hay clientes con el nombre ingresado.")
            End If
        End If
    End Sub
End Class