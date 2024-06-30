Imports VeterinariaServices.Containers
Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class EditarMascotas
    Private _mascota As Mascota ' Objeto mascota que se va a editar
    Private _daoMascotas As DAOMascotas ' Objeto para interactuar con la base de datos

    Private _contenedorEspecies As ContenedorEspecies
    Private _contenedorClientes As ContenedorClientes

    Private _isNombreEditable As Boolean = False
    Private _isPesoEditable As Boolean = False
    Private _isFechaEditable As Boolean = False
    Private _isEspecieEditable As Boolean = False
    Private _isClienteEditable As Boolean = False

    ''' <summary>
    ''' Constructor que recibe un objeto Mascota y configura el formulario.
    ''' </summary>
    ''' <param name="mascota">La mascota que se va a editar.</param>
    Public Sub New(mascota As Mascota)
        InitializeComponent() ' Método que inicializa los componentes del formulario
        _mascota = mascota
        _daoMascotas = New DAOMascotas()
        _contenedorEspecies = New ContenedorEspecies()
        _contenedorClientes = New ContenedorClientes()
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cuando el formulario se carga.
    ''' </summary>
    Private Sub EditarMascotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosMascotas()
    End Sub

    ''' <summary>
    ''' Método para cargar los datos de la mascota en los campos de texto.
    ''' </summary>
    Private Sub CargarDatosMascotas()
        TextBoxNombre.Text = _mascota.Nombre
        TextBoxPeso.Text = _mascota.Peso.ToString()
        TextBoxFechaNacimiento.Text = _mascota.FechaNacimiento.ToString()
        TextBoxEspecieID.Text = _mascota.IdEspecie.ToString()
        TextBoxClienteID.Text = _mascota.IdCliente.ToString()

        TextBoxNombre.ReadOnly = True
        TextBoxPeso.ReadOnly = True
        TextBoxFechaNacimiento.ReadOnly = True
        TextBoxEspecieID.ReadOnly = True
        TextBoxClienteID.ReadOnly = True
        ButtonBuscarEspecie.Enabled = False
        ButtonBuscarCliente.Enabled = False
    End Sub

    ''' <summary>
    ''' Método para habilitar/deshabilitar la edición del campo Nombre.
    ''' </summary>
    Private Sub ButtonEditNombre_Click(sender As Object, e As EventArgs) Handles ButtonEditNombre.Click
        _isNombreEditable = Not _isNombreEditable
        TextBoxNombre.ReadOnly = Not _isNombreEditable
    End Sub

    ''' <summary>
    ''' Método para habilitar/deshabilitar la edición del campo Peso.
    ''' </summary>
    Private Sub ButtonEditPeso_Click(sender As Object, e As EventArgs) Handles ButtonEditPeso.Click
        _isPesoEditable = Not _isPesoEditable
        TextBoxPeso.ReadOnly = Not _isPesoEditable
    End Sub

    ''' <summary>
    ''' Método para habilitar/deshabilitar la edición del campo fecha de nacimiento.
    ''' </summary>
    Private Sub ButtonEditFecha_Click(sender As Object, e As EventArgs) Handles ButtonEditFecha.Click
        _isFechaEditable = Not _isFechaEditable
        TextBoxFechaNacimiento.ReadOnly = Not _isFechaEditable
    End Sub

    ''' <summary>
    ''' Método para habilitar/deshabilitar la edición del campo especie y boton de busqueda.
    ''' </summary>
    Private Sub ButtonEditarEspecie_Click(sender As Object, e As EventArgs) Handles ButtonEditarEspecie.Click
        _isEspecieEditable = Not _isEspecieEditable
        TextBoxEspecieID.ReadOnly = Not _isEspecieEditable
        ButtonBuscarEspecie.Enabled = _isEspecieEditable
    End Sub

    ''' <summary>
    ''' Método para habilitar/deshabilitar la edición del campo especie y boton de busqueda.
    ''' </summary>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _isClienteEditable = Not _isClienteEditable
        TextBoxClienteID.ReadOnly = Not _isClienteEditable
        ButtonBuscarCliente.Enabled = _isClienteEditable
    End Sub

    Private Sub ButtonBuscarEspecie_Click(sender As Object, e As EventArgs) Handles ButtonBuscarEspecie.Click
        Dim idEspecie As Integer
        If Integer.TryParse(TextBoxEspecieID.Text, idEspecie) Then
            Dim nombreEspecie As String = _contenedorEspecies.NombrePorID(idEspecie)
            If Not String.IsNullOrEmpty(nombreEspecie) Then
                MessageBox.Show($"Nombre de Especie: {nombreEspecie}", "Especie Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Especie no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Por favor, ingrese un ID de especie válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonBuscarCliente_Click(sender As Object, e As EventArgs) Handles ButtonBuscarCliente.Click
        Dim idCliente As Integer
        If Integer.TryParse(TextBoxClienteID.Text, idCliente) Then
            Dim cliente As Cliente = _contenedorClientes.BuscarClientePorID(idCliente)
            If cliente IsNot Nothing Then
                MessageBox.Show($"Nombre: {cliente.Nombre}, DNI: {cliente.Dni}", "Cliente Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Por favor, ingrese un ID de cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        Try
            Dim query As String = "UPDATE MASCOTAS SET"
            Dim primerCampo As Boolean = True

            If _isNombreEditable Then
                If Not primerCampo Then query += ", "
                query += $" NOMBRE = '{TextBoxNombre.Text}'"
                primerCampo = False
            End If

            If _isPesoEditable Then
                If Not primerCampo Then query += ", "
                query += $" PESO = '{TextBoxPeso.Text}'"
                primerCampo = False
            End If

            If _isFechaEditable Then
                If Not primerCampo Then query += ", "
                query += $" FECHA_NACIMIENTO = '{TextBoxFechaNacimiento.Text}'"
                primerCampo = False
            End If

            If _isClienteEditable Then
                If Not primerCampo Then query += ", "
                query += $" ID_CLIENTE = '{TextBoxClienteID.Text}'"
                primerCampo = False
            End If

            If _isEspecieEditable Then
                If Not primerCampo Then query += ", "
                query += $" ID_ESPECIE = '{TextBoxEspecieID.Text}'"
                primerCampo = False
            End If

            If Not primerCampo Then
                query += $" WHERE ID = {_mascota.Id}"
                Dim exito As Boolean = _daoMascotas.Edit(query)

                If exito Then
                    MessageBox.Show("Mascota editada correctamente.")
                Else
                    MessageBox.Show("Hubo un error al editar la mascota.")
                End If
            Else
                MessageBox.Show("No se realizaron cambios.")
            End If

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("ERROR.")
        End Try
    End Sub

End Class