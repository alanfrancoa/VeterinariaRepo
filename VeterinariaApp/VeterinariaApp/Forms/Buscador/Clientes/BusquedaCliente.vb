Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models

Public Class BusquedaCliente
    Private _cliente As Cliente 'Objeto cliente que se va a ver
    Private contenedorMascotas As ContenedorMascotas

    ''' <summary>
    ''' Constructor que recibe un objeto Cliente y configura el formulario.
    ''' </summary>
    ''' <param name="cliente">El cliente que se va a editar.</param>
    Public Sub New(cliente As Cliente)

        ' This call is required by the designer.
        InitializeComponent()
        _cliente = cliente
        contenedorMascotas = New ContenedorMascotas()

    End Sub
    Private Sub MuestraCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosCliente() 'Carga los datos del cliente en los campos del Formulario.
    End Sub

    Private Sub CargarDatosCliente()
        LabelIDCliente.Text = _cliente.Id
        LabelNombreCliente.Text = _cliente.Nombre
        LabelDNICliente.Text = _cliente.Dni
        LabelTelefonoCliente.Text = _cliente.Telefono
        LabelEMailCliente.Text = _cliente.Email
        LabelEstadoCliente.Text = _cliente.Estado
    End Sub

    Private Sub ButtonVerMascotasCliente_Click(sender As Object, e As EventArgs) Handles ButtonVerMascotasCliente.Click
        Dim listaMascotas As List(Of Mascota) = contenedorMascotas.BuscarMascotasPorIdCliente(_cliente.Id)

        If listaMascotas IsNot Nothing AndAlso listaMascotas.Count > 0 Then
            Dim formListadoDeMascotasCliente As New BusquedaMascotaListado(listaMascotas)
            formListadoDeMascotasCliente.Show()
        Else
            MessageBox.Show("No hay clientes con el nombre ingresado.")
        End If
    End Sub
End Class