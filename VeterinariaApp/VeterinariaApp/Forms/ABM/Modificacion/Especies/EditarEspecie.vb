Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class EditarEspecie
    Private _especie As Especie
    Private _daoEspecie As DAOEspecies
    Private _isNombreEditable As Boolean = False
    Private _isEMadurez As Boolean = False
    Private _isPProm As Boolean = False

    Public Sub New(especie As Especie)
        InitializeComponent()
        _especie = especie
        _daoEspecie = New DAOEspecies
    End Sub
    ''' <summary>
    ''' Evento que se ejecuta cuando el formulario se carga.
    ''' </summary>
    Private Sub EditarEspecie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosEspecie()
    End Sub
    ''' <summary>
    ''' Método para cargar los datos de la especie en los campos de texto.
    ''' </summary>
    Private Sub CargarDatosEspecie()
        TextBoxNombre.Text = _especie.Nombre
        TextBoxE_Madurez.Text = _especie.EdadMadurez.ToString()
        TextBoxP_Prom.Text = _especie.PesoPromedio.ToString()

        TextBoxNombre.ReadOnly = True
        TextBoxE_Madurez.ReadOnly = True
        TextBoxP_Prom.ReadOnly = True

    End Sub

    ''' <summary>
    ''' Métodos para habilitar/deshabilitar la edición de los campos de texto.
    ''' </summary>
    Private Sub ButtonEditNombre_Click(sender As Object, e As EventArgs) Handles ButtonEditNombre.Click
        _isNombreEditable = Not _isNombreEditable
        TextBoxNombre.ReadOnly = Not _isNombreEditable
    End Sub

    Private Sub ButtonEditE_Madurez_Click(sender As Object, e As EventArgs) Handles ButtonEditE_Madurez.Click
        _isEMadurez = Not _isEMadurez
        TextBoxE_Madurez.ReadOnly = Not _isEMadurez
    End Sub

    Private Sub ButtonEditP_Prom_Click(sender As Object, e As EventArgs) Handles ButtonEditP_Prom.Click
        _isPProm = Not _isPProm
        TextBoxP_Prom.ReadOnly = Not _isPProm
    End Sub

    ''' <summary>
    ''' Método que se ejecuta al hacer clic en el botón de Editar.
    ''' </summary>
    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        Dim query As String = "UPDATE ESPECIES SET "
        Dim primerCampo As Boolean = True
        If _isNombreEditable Then
            query += $"NOMBRE '{TextBoxNombre.Text}'"
            primerCampo = False
        End If

        If _isEMadurez Then
            If Not primerCampo Then query += ", "
            query += $"EDAD_MADUREZ = {TextBoxE_Madurez.Text}"
            primerCampo = False
        End If

        If _isPProm Then
            If Not primerCampo Then query += ", "
            query += $"PESO_PROMEDIO = {TextBoxP_Prom.Text}"
            primerCampo = False
        End If
        query += $" WHERE ID = {_especie.Id}"

        Dim exito As Boolean = _daoEspecie.Edit(query)

        If exito Then
            MessageBox.Show("Especie editada correctamente.")
        Else
            MessageBox.Show("Hubo un error al editar la Especie.")
        End If

    End Sub

End Class