Imports VeterinariaServices.Containers
Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class BusquedaMascota
    Private _mascota As Mascota 'Objeto mascota que se va a editar
    Private _cliente As Cliente
    Private _daoMascotas As DAOMascotas
    Private _daoClientes As DAOClientes
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
        _cliente = New Cliente()
        _daoClientes = New DAOClientes()
        _daoMascotas = New DAOMascotas()
        contenedorEspecies = New ContenedorEspecies()
        contenedorClientes = New ContenedorClientes()
    End Sub

    Private Sub BusquedaMascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        _cliente = contenedorClientes.BuscarClientePorID(_mascota.IdCliente)

        Dim infoCliente = contenedorClientes.datosDeClientePorID(_mascota.IdCliente)
        LabelInfoCliente.Text = infoCliente

        If _mascota.Estado = "ACTIVO" Then
            ButtonEliminarMascota.Text = "Dar de Baja"
        Else
            ButtonEliminarMascota.Text = "Dar de Alta Nuevamente"
        End If
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

    Private Sub ButtonEliminarMascota_Click(sender As Object, e As EventArgs) Handles ButtonEliminarMascota.Click
        Me.Close()
        If _mascota IsNot Nothing Then
            If _mascota.Estado = "ACTIVO" Then
                'Si la mascota tiene estado activo, tendremos que pasarlo a inactivo, esto se podra hacer unicamente si el estado del Cliente de la mascota es ACTIVO.
                If _cliente.Estado = "ACTIVO" Then
                    Dim exitoBajaMascota = _daoMascotas.Delete(_mascota.Id)
                    If exitoBajaMascota Then
                        MessageBox.Show("Mascota dada de baja exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

                    Else
                        MessageBox.Show("No se ha podido realizar la baja de la mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, CType(MessageBoxOptions.RightAlign, MessageBoxDefaultButton))

                    End If
                Else
                    MessageBox.Show("No se puede dar de baja porque el cliente asociado es inactivo.", "Coherencia de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                End If
            Else
                'Si la mascota tiene estado inactivo, deberemos activarla, unicamente se puede si el cliente es activo.
                If _cliente.Estado = "ACTIVO" Then
                    Dim exitoAltaMascota = _daoMascotas.Activar(_mascota.Id)
                    If exitoAltaMascota Then
                        MessageBox.Show("Mascotra dada de alta exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

                    Else
                        MessageBox.Show("No se ha podido realizar el alta de la mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, CType(MessageBoxOptions.RightAlign, MessageBoxDefaultButton))

                    End If
                Else
                    MessageBox.Show("No se puede dar de alta porque el cliente es inactivo.", "Coherencia de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                End If
            End If
        End If
    End Sub
End Class