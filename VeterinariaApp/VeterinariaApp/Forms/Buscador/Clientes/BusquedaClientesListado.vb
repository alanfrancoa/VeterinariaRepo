Imports VeterinariaServices.Models

Public Class BusquedaClientesListado
    Public Sub New(clientes As List(Of Cliente))
        ' Esta llamada es requerida por el diseñador.
        InitializeComponent()
        ' Añada cualquier inicialización después de la llamada a InitializeComponent().
        CargarClientes(clientes)
    End Sub

    Private Sub CargarClientes(clientes As List(Of Cliente))
        DataGridViewClientesBusqueda.DataSource = clientes
        DataGridViewClientesBusqueda.AutoResizeColumns()
    End Sub
End Class
