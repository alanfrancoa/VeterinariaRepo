Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models

Public Class DialogoAdministrador
    Private contenedorUsuarios As ContenedorUsuarios

    ''' <summary>
    ''' Constructor del formulario.
    ''' Inicializa los componentes del formulario y el contenedor de usuarios.
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        contenedorUsuarios = New ContenedorUsuarios()
    End Sub

    ''' <summary>
    ''' Maneja el evento Click del botón para verificar las credenciales.
    ''' </summary>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBoxUsuarioAdmin.Text
        Dim password As String = TextBoxContrasenaAdmin.Text
        Dim isAdmin As Boolean = VerifyAdminCredentials(username, password)
        Me.Close()
        If isAdmin Then

            MessageBox.Show("Credenciales válidas. El usuario es Administrador.")
        Else
            MessageBox.Show("Credenciales inválidas o el usuario no es Administrador.")
        End If
    End Sub

    ''' <summary>
    ''' Verifica las credenciales del usuario y su tipo.
    ''' </summary>
    ''' <param name="username">Nombre de usuario a verificar</param>
    ''' <param name="password">Contraseña del usuario</param>
    ''' <returns>True si las credenciales son válidas y el usuario es Administrador, False en caso contrario</returns>
    Public Function VerifyAdminCredentials(username As String, password As String) As Boolean
        Dim user As Usuario = contenedorUsuarios.GetUsuarioByUsername(username)

        If user IsNot Nothing AndAlso user.Password = password AndAlso user.TipoUsuario = "ADMINISTRADOR" Then
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Muestra el formulario como un cuadro de diálogo modal y verifica las credenciales del usuario.
    ''' </summary>
    ''' <returns>True si las credenciales son válidas y el usuario es Administrador, False en caso contrario</returns>
    Public Function ShowAndVerifyCredentials() As Boolean
        Me.ShowDialog() ' Muestra el formulario como un cuadro de diálogo modal

        Dim username As String = TextBoxUsuarioAdmin.Text
        Dim password As String = TextBoxContrasenaAdmin.Text
        Return VerifyAdminCredentials(username, password)
    End Function

End Class