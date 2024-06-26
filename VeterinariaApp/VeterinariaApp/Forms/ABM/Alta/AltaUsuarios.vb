Imports VeterinariaServices.Containers
Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class AltaUsuarios
    Private _contenedorUsuarios As ContenedorUsuarios

    Public Sub New(contenedorUsuarios As ContenedorUsuarios)
        InitializeComponent()
        _contenedorUsuarios = contenedorUsuarios
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Username = TextBoxUser.Text
            Dim Nombre = TextBoxNombre.Text
            Dim Clave = TextBoxClave.Text
            Dim ConfimClave = TextBoxConfirmClave.Text

            If Nombre = "" Or Username = "" Or Clave = "" Or ConfimClave = "" Then
                MessageBox.Show("TODOS LOS CAMPOS DEBEN SER COMPLETADOS.")
                Return
            End If

            If _contenedorUsuarios.ExisteUsername(Username) Then
                MessageBox.Show("EL USERNAME YA EXISTE.")
                Return
            End If

            If Clave <> ConfimClave Then
                MessageBox.Show("LA CONTRASEÑAS NO COINCIDEN.")
                Return
            End If

            Dim loginAdminForm As New DialogoAdministrador
            Dim isAdmin As Boolean = loginAdminForm.ShowAndVerifyCredentials()

            If isAdmin Then
                ' Lógica para cuando el usuario es un administrador válido
                Console.WriteLine("Acceso concedido: El usuario es Administrador.")
                Dim nuevoUsuario As New Usuario(Username, Nombre, Clave)
                Dim Insert = _contenedorUsuarios.AddUsuario(nuevoUsuario)
                Me.Close()
                Dim BarraDeProgreso As New BarraDeProgreso
                BarraDeProgreso.Show()

                If Insert Then
                    MessageBox.Show("USUARIO AGREGADO.")
                Else
                    MessageBox.Show("NO SE HA PODIDO AGREGAR EL USUARIO.")
                End If
            Else
                Dim BarraDeProgreso As New BarraDeProgreso
                BarraDeProgreso.Show()
                ' Lógica para cuando las credenciales son inválidas o el usuario no es administrador
                Console.WriteLine("Acceso denegado: Credenciales inválidas o el usuario no es Administrador.")
            End If

        Catch ex As Exception
            MessageBox.Show($"ERROR {ex}")
        End Try
    End Sub
End Class
