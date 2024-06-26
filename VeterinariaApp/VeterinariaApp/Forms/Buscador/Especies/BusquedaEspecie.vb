Imports VeterinariaServices.Containers
Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class BusquedaEspecie
    Private _especie As Especie
    Private contenedorEspecies As ContenedorEspecies
    Private _daoEspecies As DAOEspecies

    ''' <summary>
    ''' Constructor que recibe un objeto Especie y configura el formulario.
    ''' </summary>
    ''' <param name="especie">La especie que se va a editar.</param>
    Public Sub New(especie As Especie)

        ' This call is required by the designer.
        InitializeComponent()
        _especie = especie
        contenedorEspecies = New ContenedorEspecies()
        _daoEspecies = New DAOEspecies()
    End Sub

    Private Sub BusquedaEspecie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosEspecie()
    End Sub

    Private Sub CargarDatosEspecie()
        LabelIDEspecie.Text = _especie.Id.ToString
        LabelNombreEspecie.Text = _especie.Nombre
        LabelMadurezEspecie.Text = _especie.EdadMadurez.ToString
        LabelPesoPromedioEspecie.Text = _especie.PesoPromedio.ToString
    End Sub

    Private Sub ButtonEditarEspecie_Click(sender As Object, e As EventArgs) Handles ButtonEditarEspecie.Click
        MessageBox.Show("Aqui va logica de edicion.")
        If _especie IsNot Nothing Then
            ' Instanciar el formulario EditarEspecie con la especie seleccionada
            ''Dim formEditarUsuario As New EditarUsuarios(_usuario)
            ' Mostrar el formulario
            Me.Close()
            ''formEditarUsuario.Show()
        End If
    End Sub
End Class