Imports VeterinariaServices.Models

Public Class BusquedaMascotaListado
    Public Sub New(mascotas As List(Of Mascota))
        ' Esta llamada es requerida por el diseñador.
        InitializeComponent()
        ' Añada cualquier inicialización después de la llamada a InitializeComponent().
        CargarMascotas(mascotas)
    End Sub

    Private Sub CargarMascotas(mascotas As List(Of Mascota))
        DataGridViewMascotasBusqueda.DataSource = mascotas
        DataGridViewMascotasBusqueda.AutoResizeColumns()
    End Sub

End Class