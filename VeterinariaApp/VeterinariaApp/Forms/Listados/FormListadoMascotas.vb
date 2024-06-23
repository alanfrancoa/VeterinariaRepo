Imports VeterinariaServices.Containers
Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class FormListadoMascotas
    Private VariableDeArreglo As String = "Arreglate loquete"
    Private lista As List(Of Mascota)
    Private ContainerMascota As New ContenedorMascotas
    Private _daoMascotas As New DAOMascotas

    Public Sub New(lista As List(Of Mascota))

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        'Inicializa las propiedades con los parametros recibidos'
        Me.lista = lista
    End Sub
    Private Sub FormListadoMascotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Configurar el DataGridView y el Label
        Dim dt As DataTable = _daoMascotas.GetAllListasdo()
        DataGridMascotas.DataSource = dt
    End Sub

    Private Sub ButtonVerAll_Click(sender As Object, e As EventArgs) Handles ButtonVerAll.Click
        Dim dt As DataTable = _daoMascotas.GetAllListasdo()
        DataGridMascotas.DataSource = dt
    End Sub

    Private Sub ButtonVerActivos_Click(sender As Object, e As EventArgs) Handles ButtonVerActivos.Click
        Dim dt As DataTable = _daoMascotas.GetAllListasdoActivos
        DataGridMascotas.DataSource = dt
    End Sub

    Private Sub ButtonVerInactivos_Click(sender As Object, e As EventArgs) Handles ButtonVerInactivos.Click
        Dim dt As DataTable = _daoMascotas.GetAllListadoInactivos()
        DataGridMascotas.DataSource = dt
    End Sub
End Class