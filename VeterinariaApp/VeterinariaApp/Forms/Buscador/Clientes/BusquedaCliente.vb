Imports VeterinariaServices.Containers
Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class BusquedaCliente
    Private _cliente As Cliente 'Objeto cliente que se va a ver
    Private contenedorMascotas As ContenedorMascotas
    Private _daoClientes As DAOClientes
    Private _daoMascotas As DAOMascotas

    ''' <summary>
    ''' Constructor que recibe un objeto Cliente y configura el formulario.
    ''' </summary>
    ''' <param name="cliente">El cliente que se va a editar.</param>
    Public Sub New(cliente As Cliente)

        ' This call is required by the designer.
        InitializeComponent()
        _cliente = cliente
        contenedorMascotas = New ContenedorMascotas()
        _daoClientes = New DAOClientes()
        _daoMascotas = New DAOMascotas()

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

        If _cliente.Estado = "ACTIVO" Then
            ButtonBajaCliente.Text = "Dar de Baja"
        Else
            ButtonBajaCliente.Text = "Dar de Alta Nuevamente"
        End If
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

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        If _cliente IsNot Nothing Then
            ' Instanciar el formulario EditarClientes con el cliente seleccionado
            Dim formEditarCliente As New EditarClientes(_cliente)
            ' Mostrar el formulario
            Me.Close()
            formEditarCliente.Show()
        End If
    End Sub

    Private Sub ButtonBajaCliente_Click(sender As Object, e As EventArgs) Handles ButtonBajaCliente.Click
        Me.Close()
        If _cliente IsNot Nothing Then
            If _cliente.Estado = "ACTIVO" Then
                'Si el cliente es activo y lo queremos dar de baja tambien deberiamos dar de baja sus mascotas.'
                Dim exitoBaja = _daoClientes.Delete(_cliente.Id)
                Dim exitoBajaMascotas = _daoMascotas.BajaPorIDCliente(_cliente.Id)

                If exitoBaja Then
                    MessageBox.Show("Cliente dado de baja exitosamente.")
                Else
                    MessageBox.Show("No se pudo realizar la baja del Cliente.")
                End If
                If exitoBajaMascotas Then
                    MessageBox.Show("Mascotas del cliente dadas de baja exitosamente.")
                Else
                    MessageBox.Show("No se pudo realizar la baja de las mascotas.")
                End If
            Else
                Dim exitoActivar = _daoClientes.Activar(_cliente.Id)
                Dim exitoActivarMascotas = _daoMascotas.ActivarPorIDCliente(_cliente.Id)

                If exitoActivar Then
                    MessageBox.Show("Cliente dado de alta exitosamente.")
                Else
                    MessageBox.Show("No se pudo realizar el alta.")
                End If
                If exitoActivarMascotas Then
                    MessageBox.Show("Mascotas del cliente dadas de alta exitosamente.")
                Else
                    MessageBox.Show("No se pudo realizar el alta de las mascotas.")
                End If
            End If
        End If
    End Sub
End Class