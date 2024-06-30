Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models

Public Class FormListadoClientes
    Private lista As List(Of Cliente)
    Private ContainerCliente As New ContenedorClientes
    Public Sub New(lista As List(Of Cliente))

        ' Esta llamada es exigida por el diseñador.'
        InitializeComponent()
        'Inicializa las propiedades con los parametros recibidos'
        Me.lista = lista
    End Sub
    Private Sub FormListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Configurar el DataGridView y el Label
        DataGridClientes.DataSource = lista
    End Sub

    Private Sub ButtonVerAll_Click(sender As Object, e As EventArgs) Handles ButtonVerAll.Click
        DataGridClientes.DataSource = lista
    End Sub

    Private Sub ButtonVerActivos_Click(sender As Object, e As EventArgs) Handles ButtonVerActivos.Click
        Dim listaActivos As List(Of Cliente) = ContainerCliente.GetAllClientesActivos()
        DataGridClientes.DataSource = listaActivos
    End Sub

    Private Sub ButtonVerInactivos_Click(sender As Object, e As EventArgs) Handles ButtonVerInactivos.Click
        Dim listaInactivos As List(Of Cliente) = ContainerCliente.GetAllClientesInactivos()
        DataGridClientes.DataSource = listaInactivos
    End Sub

End Class