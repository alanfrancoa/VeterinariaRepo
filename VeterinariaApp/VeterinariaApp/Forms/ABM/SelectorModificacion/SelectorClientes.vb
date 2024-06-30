Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models

Public Class SelectorClientes
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
                MessageBox.Show($"Cliente encontrado: {_clienteSeleccionado.Nombre}", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                ' Llamar al formulario de edición de clientes
                Dim formMuestra As New MuestraCliente(_clienteSeleccionado)
                formMuestra.Show()
            Else
                MessageBox.Show("Cliente no encontrado", "Dato no existente", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            End If
        Else
            MessageBox.Show("Ingrese un DNI válido.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

        End If
    End Sub
End Class