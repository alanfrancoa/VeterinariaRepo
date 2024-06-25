Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models

Public Class MuestraMascota
    Private _mascota As Mascota 'Objeto mascota que se va a editar
    Private contenedorEspecies As ContenedorEspecies
    Private contenedorClientes As ContenedorClientes
    ''' <summary>
    ''' Constructor que recibe un objeto Mascota y configura el formulario.
    ''' </summary>
    ''' <param name="mascota">El cliente que se va a editar.</param>
    Public Sub New(mascota As Mascota)

        ' This call is required by the designer.
        InitializeComponent()
        _mascota = mascota
        ' Add any initialization after the InitializeComponent() call.
        contenedorEspecies = New ContenedorEspecies()
        contenedorClientes = New ContenedorClientes()
    End Sub

    Private Sub MuestraMascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosMascota()
    End Sub

    Private Sub CargarDatosMascota()
        LabelIDMascota.Text = _mascota.Id
        LabelNombreMascota.Text = _mascota.Nombre
        LabelPesoMascota.Text = _mascota.Peso
        LabelFechaNacimiento.Text = _mascota.FechaNacimiento
        LabelEstadoMascota.Text = _mascota.Estado

        Dim nombreEspecie = contenedorEspecies.NombrePorID(_mascota.IdEspecie)
        LabelNombreEspecie.Text = nombreEspecie

        Dim infoCliente = contenedorClientes.datosDeClientePorID(_mascota.IdCliente)
        LabelInfoCliente.Text = infoCliente
    End Sub

    Private Sub ButtonEditarMascota_Click(sender As Object, e As EventArgs) Handles ButtonEditarMascota.Click
        If _mascota IsNot Nothing Then
            ' Instanciar el formulario EditarMascotas con la mascota seleccionada
            Dim formEditarMascota As New EditarMascotas(_mascota)
            ' Mostrar el formulario
            Me.Close()
            formEditarMascota.Show()
        End If
    End Sub
End Class