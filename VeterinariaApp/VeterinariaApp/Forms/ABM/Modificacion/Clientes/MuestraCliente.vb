Imports VeterinariaServices.Models

Public Class MuestraCliente
    Private _cliente As Cliente 'Objeto cliente que se va a editar

    ''' <summary>
    ''' Constructor que recibe un objeto Cliente y configura el formulario.
    ''' </summary>
    ''' <param name="cliente">El cliente que se va a editar.</param>
    Public Sub New(cliente As Cliente)

        ' This call is required by the designer.
        InitializeComponent()
        _cliente = cliente
        ' Add any initialization after the InitializeComponent() call.

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

    Private Sub ButtonEditarCliente_Click(sender As Object, e As EventArgs) Handles ButtonEditarCliente.Click
        If _cliente IsNot Nothing Then
            ' Instanciar el formulario EditarClientes con el cliente seleccionado
            Dim formEditarCliente As New EditarClientes(_cliente)
            ' Mostrar el formulario
            Me.Close()
            formEditarCliente.Show()
        End If
    End Sub
End Class