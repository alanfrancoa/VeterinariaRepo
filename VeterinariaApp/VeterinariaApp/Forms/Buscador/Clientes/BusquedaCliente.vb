Imports VeterinariaServices.Containers
Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class BusquedaCliente
    Private clienteSeleccionado As Cliente
    Private _daoCliente As DAOClientes
    Private contenedorMascotas As ContenedorMascotas
    Public Sub New(clienteSeleccionado As Cliente)
        InitializeComponent()
        Me.clienteSeleccionado = clienteSeleccionado
        _daoCliente = New DAOClientes
        contenedorMascotas = New ContenedorMascotas()
    End Sub

    Private Sub BusquedaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosMascota()
    End Sub

    Private Sub CargarDatosMascota()
        LabelIDCliente.Text = clienteSeleccionado.Id
        LabelNombreCliente.Text = clienteSeleccionado.Nombre
        LabelDNICliente.Text = clienteSeleccionado.Dni
        LabelEMailCliente.Text = clienteSeleccionado.Email
        LabelEstadoCliente.Text = clienteSeleccionado.Estado

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
                'Si la mascota tiene estado activo, tendremos que pasarlo a inactivo, esto se podra hacer unicamente si el estado del Cliente de la mascota es ACTIVO.
                If clienteSeleccionado.Estado = "ACTIVO" Then
                    Dim exitoBajaMascota = _daoCliente.Delete(clienteSeleccionado.Id)
                    If exitoBajaMascota Then
                        MessageBox.Show("Mascota dada de baja exitosamente")
                    Else
                        MessageBox.Show("No se pudo realizar la baja de la mascota")
                    End If
                Else
                    MessageBox.Show("No se pudo realizar la baja de la mascota, porque el cliente es Inactivo")
                End If
            Else
                'Si la mascota tiene estado inactivo, deberemos activarla, unicamente se puede si el cliente es activo.
                If clienteSeleccionado.Estado = "ACTIVO" Then
                    Dim exitoAltaMascota = _daoCliente.Activar(clienteSeleccionado.Id)
                    If exitoAltaMascota Then
                        MessageBox.Show("Mascota dada de alta exitosamente")
                    Else
                        MessageBox.Show("No se pudo realizar el alta de la mascota")
                    End If
                Else
                    MessageBox.Show("No se pudo realizar el alta de la mascota, porque el cliente es Inactivo")
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