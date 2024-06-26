Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class EditarUsuarios
    Private _usuario As Usuario
    Private _daoUsuarios As DAOUsuarios
    Private _isNombre As Boolean = False
    Private _isUsername As Boolean = False
    Public Sub New(usuario As Usuario)
        InitializeComponent()
        _usuario = usuario
        _daoUsuarios = New DAOUsuarios()
    End Sub

    Private Sub EditarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosUsuario()
    End Sub
    Private Sub CargarDatosUsuario()
        TextBoxNombre.Text = _usuario.Nombre
        TextBoxUser.Text = _usuario.Username

        TextBoxNombre.ReadOnly = True
        TextBoxUser.ReadOnly = True
    End Sub

    Private Sub ButtonEditNombre_Click(sender As Object, e As EventArgs) Handles ButtonEditNombre.Click
        _isNombre = Not _isNombre
        TextBoxNombre.ReadOnly = Not _isNombre
    End Sub

    Private Sub ButtonEditUser_Click(sender As Object, e As EventArgs) Handles ButtonEditUser.Click
        _isUsername = Not _isUsername
        TextBoxUser.ReadOnly = Not _isUsername
    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        Dim query As String = "UPDATE USUARIOS SET "
        Dim primerCampo As Boolean = True

        If _isNombre Then
            query += $"NOMBRE = '{TextBoxNombre.Text}'"
            primerCampo = False
        End If
        If _isUsername Then
            If Not primerCampo Then query += ", "
            query += $"USERNAME = '{TextBoxUser.Text}'"
        End If

        query += $" WHERE ID = {_usuario.Id}"
        Dim exito As Boolean = _daoUsuarios.Edit(query)
        If exito Then
            MessageBox.Show("Cliente editado correctamente.")
        Else
            MessageBox.Show("Hubo un error al editar el cliente.")
        End If
    End Sub
End Class