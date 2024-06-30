Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class EditarClientes
    Private _cliente As Cliente ' Objeto cliente que se va a editar
    Private _daoClientes As DAOClientes ' Objeto para interactuar con la base de datos
    Private _isNombreEditable As Boolean = False
    Private _isDniEditable As Boolean = False
    Private _isTelefonoEditable As Boolean = False
    Private _isEmailEditable As Boolean = False

    ''' <summary>
    ''' Constructor que recibe un objeto Cliente y configura el formulario.
    ''' </summary>
    ''' <param name="cliente">El cliente que se va a editar.</param>
    Public Sub New(cliente As Cliente)
        InitializeComponent() ' Método que inicializa los componentes del formulario
        _cliente = cliente
        _daoClientes = New DAOClientes()
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cuando el formulario se carga.
    ''' </summary>
    Private Sub EditarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosCliente() ' Carga los datos del cliente en los campos del formulario
    End Sub

    ''' <summary>
    ''' Método para cargar los datos del cliente en los campos de texto.
    ''' </summary>
    Private Sub CargarDatosCliente()
        TextBoxNombre.Text = _cliente.Nombre
        TextBoxDNI.Text = _cliente.Dni.ToString()
        TextBoxTelefono.Text = _cliente.Telefono.ToString()
        TextBoxEmail.Text = _cliente.Email

        TextBoxNombre.ReadOnly = True
        TextBoxDNI.ReadOnly = True
        TextBoxTelefono.ReadOnly = True
        TextBoxEmail.ReadOnly = True
    End Sub

    ''' <summary>
    ''' Método para habilitar/deshabilitar la edición del campo Nombre.
    ''' </summary>
    Private Sub ButtonEditNombre_Click(sender As Object, e As EventArgs) Handles ButtonEditNombre.Click
        _isNombreEditable = Not _isNombreEditable
        TextBoxNombre.ReadOnly = Not _isNombreEditable
    End Sub

    ''' <summary>
    ''' Método para habilitar/deshabilitar la edición del campo DNI.
    ''' </summary>
    Private Sub ButtonEditDNI_Click(sender As Object, e As EventArgs) Handles ButtonEditDNI.Click
        _isDniEditable = Not _isDniEditable
        TextBoxDNI.ReadOnly = Not _isDniEditable
    End Sub

    ''' <summary>
    ''' Método para habilitar/deshabilitar la edición del campo Teléfono.
    ''' </summary>
    Private Sub ButtonEditTelefono_Click(sender As Object, e As EventArgs) Handles ButtonEditTelefono.Click
        _isTelefonoEditable = Not _isTelefonoEditable
        TextBoxTelefono.ReadOnly = Not _isTelefonoEditable
    End Sub

    ''' <summary>
    ''' Método para habilitar/deshabilitar la edición del campo Email.
    ''' </summary>
    Private Sub ButtonEditMail_Click(sender As Object, e As EventArgs) Handles ButtonEditMail.Click
        _isEmailEditable = Not _isEmailEditable
        TextBoxEmail.ReadOnly = Not _isEmailEditable
    End Sub

    ''' <summary>
    ''' Método que se ejecuta al hacer clic en el botón de Editar.
    ''' </summary>
    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        Try
            Dim query As String = "UPDATE CLIENTES SET "
            Dim primerCampo As Boolean = True

            If _isNombreEditable Then
                query += $"NOMBRE = '{TextBoxNombre.Text}'"
                primerCampo = False
            End If

            If _isDniEditable Then
                If Not primerCampo Then query += ", "
                query += $"DNI = {TextBoxDNI.Text}"
                primerCampo = False
            End If

            If _isTelefonoEditable Then
                If Not primerCampo Then query += ", "
                query += $"TELEFONO = {TextBoxTelefono.Text}"
                primerCampo = False
            End If

            If _isEmailEditable Then
                If Not primerCampo Then query += ", "
                query += $"E_MAIL = '{TextBoxEmail.Text}'"
            End If

            query += $" WHERE ID = {_cliente.Id}"

            Dim exito As Boolean = _daoClientes.Edit(query)

            If exito Then
                MessageBox.Show("Cliente editado correctamente.")
            Else
                MessageBox.Show("Hubo un error al editar el cliente.")
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR.")
        End Try
    End Sub

End Class