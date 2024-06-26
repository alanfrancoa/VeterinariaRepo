Imports VeterinariaServices.DAOs

Public Class CantidadDeAnimales
    Private Sub CantidadDeAnimales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub
    Private Sub CargarDatos()

        Dim daoReportes As New DAOReportes()
        Dim dataTable As DataTable = daoReportes.GetAllListadoCantidadMascotas()

        DataGridViewCantidadMascotas.DataSource = dataTable
        DataGridViewCantidadMascotas.AutoResizeColumns()
    End Sub
End Class