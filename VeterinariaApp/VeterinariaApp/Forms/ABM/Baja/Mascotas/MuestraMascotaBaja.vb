Imports VeterinariaServices.Containers
Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class MuestraMascotaBaja
    Private _mascota As Mascota 'Objeto cliente que se va a editar
    Private _cliente As Cliente
    Private _daoMascotas As DAOMascotas
    Private _daoClientes As DAOClientes
    Private contenedorEspecie As ContenedorEspecies
    Private contenedorCliente As ContenedorClientes

    ''' <summary>
    ''' Constructor que recibe un objeto Mascota y configura el formulario.
    ''' </summary>
    ''' <param name="mascota">El mascota que se va a editar.</param>
    Public Sub New(mascota As Mascota)

        ' This call is required by the designer.
        InitializeComponent()
        _mascota = mascota
        _cliente = New Cliente()
        _daoClientes = New DAOClientes()
        _daoMascotas = New DAOMascotas()
        contenedorEspecie = New ContenedorEspecies()
        contenedorCliente = New ContenedorClientes()


    End Sub

    Private Sub MuestraMascotaBaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosMascota()
    End Sub

    Private Sub CargarDatosMascota()
        LabelIDMascota.Text = _mascota.Id
        LabelNombreMascota.Text = _mascota.Nombre
        LabelPesoMascota.Text = _mascota.Peso.ToString
        LabelFechaNacimiento.Text = _mascota.FechaNacimiento.ToString()

        Dim nombreEspecie = contenedorEspecie.NombrePorID(_mascota.IdEspecie)
        LabelNombreEspecie.Text = nombreEspecie

        _cliente = contenedorCliente.BuscarClientePorID(_mascota.IdCliente)
        Dim infoCliente = contenedorCliente.datosDeClientePorID(_mascota.IdCliente)
        LabelInfoCliente.Text = infoCliente
        LabelEstadoMascota.Text = _mascota.Estado

        If _mascota.Estado = "ACTIVO" Then
            ButtonBajarMascota.Text = "Dar de Baja"
        Else
            ButtonBajarMascota.Text = "Dar de Alta Nuevamente"
        End If
    End Sub

    Private Sub ButtonBajarMascota_Click(sender As Object, e As EventArgs) Handles ButtonBajarMascota.Click
        Me.Close()
        If _mascota IsNot Nothing Then
            If _mascota.Estado = "ACTIVO" Then
                'Si la mascota tiene estado activo, tendremos que pasarlo a inactivo, esto se podra hacer unicamente si el estado del Cliente de la mascota es ACTIVO.
                If _cliente.Estado = "ACTIVO" Then
                    Dim exitoBajaMascota = _daoMascotas.Delete(_mascota.Id)
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
                If _cliente.Estado = "ACTIVO" Then
                    Dim exitoAltaMascota = _daoMascotas.Activar(_mascota.Id)
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
End Class