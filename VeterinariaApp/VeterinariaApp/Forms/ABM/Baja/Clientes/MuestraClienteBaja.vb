Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class MuestraClienteBaja
    Private _cliente As Cliente 'Objeto cliente que se va a editar
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
        _daoClientes = New DAOClientes()
        _daoMascotas = New DAOMascotas()
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

        If _cliente.Estado = "ACTIVO" Then
            ButtonBajarCliente.Text = "Dar de Baja"
        Else
            ButtonBajarCliente.Text = "Dar de Alta Nuevamente"
        End If

    End Sub

    Private Sub ButtonBajarCliente_Click(sender As Object, e As EventArgs) Handles ButtonBajarCliente.Click
        Me.Close()
        If _cliente IsNot Nothing Then
            If _cliente.Estado = "ACTIVO" Then
                'Si el cliente es activo y lo queremos dar de baja tambien deberiamos dar de baja sus mascotas.'
                Dim exitoBaja = _daoClientes.Delete(_cliente.Id)
                Dim exitoBajaMascotas = _daoMascotas.BajaPorIDCliente(_cliente.Id)

                If exitoBaja Then
                    MessageBox.Show("Cliente dado de baja exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Else
                    MessageBox.Show("No se ha podido realizar la baja del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, CType(MessageBoxOptions.RightAlign, MessageBoxDefaultButton))

                End If
                If exitoBajaMascotas Then
                    MessageBox.Show("Mascotas dadas de baja exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Else
                    MessageBox.Show("No se ha podido realizar la baja de las masotas asoiadas al cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, CType(MessageBoxOptions.RightAlign, MessageBoxDefaultButton))

                End If
            Else
                Dim exitoActivar = _daoClientes.Activar(_cliente.Id)
                Dim exitoActivarMascotas = _daoMascotas.ActivarPorIDCliente(_cliente.Id)

                If exitoActivar Then
                    MessageBox.Show("Cliente dado de alta exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Else
                    MessageBox.Show("No se ha podido realizar el alta del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, CType(MessageBoxOptions.RightAlign, MessageBoxDefaultButton))

                End If
                If exitoActivarMascotas Then
                    MessageBox.Show("Mascotas del cliente dadas de alta exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Else
                    MessageBox.Show("No se ha podido realizar el alta de las mascotas asociadas al cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, CType(MessageBoxOptions.RightAlign, MessageBoxDefaultButton))

                End If
            End If
        End If
    End Sub
End Class