Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class CalculoDePesos
    Private _daoMascotas As DAOMascotas
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _daoMascotas = New DAOMascotas
    End Sub

    Private Sub ButtonBusqueda_Click(sender As Object, e As EventArgs) Handles ButtonBusqueda.Click
        Dim edad1 As Integer = NumericUpDownDesde.Value
        Dim edad2 As Integer = NumericUpDownHasta.Value
        Dim listaAMostrar As New List(Of Mascota)
        listaAMostrar = _daoMascotas.GetPorRango(edad1, edad2)

        DataGridViewCalculoPesos.DataSource = listaAMostrar
    End Sub
End Class