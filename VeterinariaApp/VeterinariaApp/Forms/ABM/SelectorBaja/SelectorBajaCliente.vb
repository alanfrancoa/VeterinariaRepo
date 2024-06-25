Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models

Public Class SelectorBajaCliente
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
    ''' Método para buscar cliente por DNI
    ''' </summary>
    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim dni As Integer

        If Integer.TryParse(TextBoxDNI.Text, dni) Then
            _clienteSeleccionado = _contenedorClientes.buscarPorDni(dni)
            If _clienteSeleccionado IsNot Nothing Then
                Me.Close()
                MessageBox.Show($"Cliente encontrado: {_clienteSeleccionado.Nombre}")
                ' Llamar al formulario de eliminacion de clientes
                Dim formMuestraBajaCliente As New MuestraClienteBaja(_clienteSeleccionado)
                formMuestraBajaCliente.Show()
            Else
                MessageBox.Show("Cliente no encontrado.")
            End If
        Else
            MessageBox.Show("Por favor, ingrese un DNI válido.")
        End If
    End Sub
End Class