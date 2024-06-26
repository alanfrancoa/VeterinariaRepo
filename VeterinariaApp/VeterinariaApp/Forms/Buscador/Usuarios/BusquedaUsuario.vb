﻿Imports VeterinariaServices.Containers
Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class BusquedaUsuario
    Private _usuario As Usuario 'Objeto mascota que se va a editar
    Private contenedorUsuarios As ContenedorUsuarios
    Private _daoUsuarios As DAOUsuarios

    ''' <summary>
    ''' Constructor que recibe un objeto Usuario y configura el formulario.
    ''' </summary>
    ''' <param name="usuario">El usuario que se va a editar.</param>
    Public Sub New(usuario As Usuario)

        ' This call is required by the designer.
        InitializeComponent()
        _usuario = usuario
        contenedorUsuarios = New ContenedorUsuarios()
        _daoUsuarios = New DAOUsuarios()

    End Sub

    Private Sub BusquedaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosUsuario() 'Carga los datos del cliente en los campos del formulario
    End Sub

    Private Sub CargarDatosUsuario()
        LabelIDUsuario.Text = _usuario.Id
        LabelNombreUsuario.Text = _usuario.Nombre
        LabelUsername.Text = _usuario.Username

        If _usuario.Estado = "ACTIVO" Then
            ButtonDeshabilitar.Text = "Dar de Baja"
        Else
            ButtonDeshabilitar.Text = "Dar de Alta Nuevamente"
        End If
    End Sub

    Private Sub ButtonResetPass_Click(sender As Object, e As EventArgs) Handles ButtonResetPass.Click
        Me.Close()
        If _usuario IsNot Nothing Then
            If _usuario.Estado = "ACTIVO" Then
                Dim dialogoAdmin As New DialogoAdministrador()
                Dim esAdmin As Boolean = dialogoAdmin.ShowAndVerifyCredentials()

                If esAdmin Then
                    MessageBox.Show("Acceso concedido. El usuario es Administrador.")
                    Dim exitoCambioPass = _daoUsuarios.ResetPassword(_usuario.Id)
                    If exitoCambioPass Then
                        MessageBox.Show("Contraseña reseteada exitosamente, ahora es igual a su nombre de usuario.")
                    Else
                        MessageBox.Show("No pudo resetearse la contraseña.")
                    End If
                Else
                    MessageBox.Show("Acceso denegado. El usuario no es Administrador o las credenciales son incorrectas.")
                End If
            Else
                MessageBox.Show("Funcion disponible unicamente en usuarios activos.")
            End If
        End If
    End Sub

    Private Sub ButtonEditarUsuario_Click(sender As Object, e As EventArgs) Handles ButtonEditarUsuario.Click
        MessageBox.Show("Aqui va logica de edicion.")
        If _usuario IsNot Nothing Then
            ' Instanciar el formulario EditarMascotas con la mascota seleccionada
            ''Dim formEditarUsuario As New EditarUsuarios(_usuario)
            ' Mostrar el formulario
            Me.Close()
            ''formEditarUsuario.Show()
        End If
    End Sub

    Private Sub ButtonDeshabilitar_Click(sender As Object, e As EventArgs) Handles ButtonDeshabilitar.Click
        Me.Close()
        If _usuario IsNot Nothing Then
            If _usuario.Estado = "ACTIVO" Then
                'Si el cliente es activo y lo queremos dar de baja tambien deberiamos dar de baja sus mascotas.'
                Dim exitoBaja = _daoUsuarios.Delete(_usuario.Id)

                If exitoBaja Then
                    MessageBox.Show("Cliente dado de baja exitosamente.")
                Else
                    MessageBox.Show("No se pudo realizar la baja del Cliente.")
                End If
            Else
                Dim exitoActivar = _daoUsuarios.Activar(_usuario.Id)

                If exitoActivar Then
                    MessageBox.Show("Cliente dado de alta exitosamente.")
                Else
                    MessageBox.Show("No se pudo realizar el alta.")
                End If
            End If
        End If
    End Sub
End Class