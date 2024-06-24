Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models
Public Class FormListadoUsuarios
    Private lista As List(Of Usuario)
    Private ContainerUsuarios As New ContenedorUsuarios
    Public Sub New(lista As List(Of Usuario))
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Inicializa las propiedades con los parámetros recibidos.
        Me.lista = lista
    End Sub

    Private Sub FormListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el DataGridView y el Label.
        DataGridListado.DataSource = lista
    End Sub

    Private Sub ButtonVerAll_Click(sender As Object, e As EventArgs) Handles ButtonVerAll.Click
        ' Configurar el DataGridView y el Label.
        DataGridListado.DataSource = lista
    End Sub

    Private Sub ButtonVerActivos_Click(sender As Object, e As EventArgs) Handles ButtonVerActivos.Click
        Dim listadoDeActivos As List(Of Usuario) = ContainerUsuarios.GetUsuariosListadoActivos()
        DataGridListado.DataSource = listadoDeActivos
    End Sub

    Private Sub ButtonVerInactivos_Click(sender As Object, e As EventArgs) Handles ButtonVerInactivos.Click
        Dim listadoDeInactivos As List(Of Usuario) = ContainerUsuarios.GetUsuariosListadoInactivos()
        DataGridListado.DataSource = listadoDeInactivos
    End Sub
End Class
