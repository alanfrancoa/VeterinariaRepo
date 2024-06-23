Imports VeterinariaServices.Models
Public Class FormListadoUsuarios
    Private lista As List(Of Usuario)

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
End Class
