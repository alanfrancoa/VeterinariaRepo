Imports VeterinariaServices.Models

Public Class BusquedaCliente
    Private clienteSeleccionado As Cliente

    Public Sub New(clienteSeleccionado As Cliente)
        Me.clienteSeleccionado = clienteSeleccionado
    End Sub
End Class