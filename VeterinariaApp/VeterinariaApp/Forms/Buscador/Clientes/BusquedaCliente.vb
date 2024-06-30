Imports VeterinariaServices.Containers
Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class BusquedaCliente
    Private clienteSeleccionado As Cliente
    Private _daoCliente As DAOClientes
    Private _daoMascotas As DAOMascotas
    Private contenedorMascotas As ContenedorMascotas
    Public Sub New(clienteSeleccionado As Cliente)
        InitializeComponent()
        Me.clienteSeleccionado = clienteSeleccionado
        _daoCliente = New DAOClientes
        contenedorMascotas = New ContenedorMascotas()
        _daoMascotas = New DAOMascotas
    End Sub

    Private Sub BusquedaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosCliente()
    End Sub

    Private Sub CargarDatosCliente()
        LabelIDCliente.Text = clienteSeleccionado.Id
        LabelNombreCliente.Text = clienteSeleccionado.Nombre
        LabelDNICliente.Text = clienteSeleccionado.Dni
        LabelEMailCliente.Text = clienteSeleccionado.Email
        LabelEstadoCliente.Text = clienteSeleccionado.Estado
        LabelTelefonoCliente.Text = clienteSeleccionado.Telefono

        If clienteSeleccionado.Estado = "ACTIVO" Then
            ButtonBajaCliente.Text = "Dar de Baja"
        Else
            ButtonBajaCliente.Text = "Dar de Alta Nuevamente"
        End If
    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        If clienteSeleccionado IsNot Nothing Then
            Dim editarClienteForm As New EditarClientes(clienteSeleccionado)

            editarClienteForm.Show()

        End If
    End Sub

    Private Sub ButtonBajaCliente_Click(sender As Object, e As EventArgs) Handles ButtonBajaCliente.Click
        Me.Close()
        If clienteSeleccionado IsNot Nothing Then
            If clienteSeleccionado.Estado = "ACTIVO" Then
                'Si el cliente es activo y lo queremos dar de baja tambien deberiamos dar de baja sus mascotas.'
                Dim exitoBaja = _daoCliente.Delete(clienteSeleccionado.Id)
                Dim exitoBajaMascotas = _daoMascotas.BajaPorIDCliente(clienteSeleccionado.Id)

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
                Dim exitoActivar = _daoCliente.Activar(clienteSeleccionado.Id)
                Dim exitoActivarMascotas = _daoMascotas.ActivarPorIDCliente(clienteSeleccionado.Id)

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

    Private Sub ButtonVerMascotasCliente_Click(sender As Object, e As EventArgs) Handles ButtonVerMascotasCliente.Click
        Dim listaDeMascotas As List(Of Mascota) = contenedorMascotas.BuscarMascotasPorIdCliente(clienteSeleccionado.Id)
        Me.Close()

        If listaDeMascotas IsNot Nothing AndAlso listaDeMascotas.Count > 0 Then
            Dim formListadoDeMascotas As New BusquedaMascotaListado(listaDeMascotas)
            formListadoDeMascotas.Show()

        Else
            MessageBox.Show("El cliente seleccionado, no posee mascotas.")
        End If
    End Sub
End Class