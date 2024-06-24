Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models

Public Class FormListadoEspecies
    Private lista As List(Of Especie)
    Private ContainerEspecies As New ContenedorEspecies

    Public Sub New(lista As List(Of Especie))

        ' This call is required by the designer.
        InitializeComponent()

        ' Inicializa las propiedades con los parámetros recibidos.
        Me.lista = lista

    End Sub

    Private Sub FormListadoEspecies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridListado.DataSource = lista
    End Sub


End Class