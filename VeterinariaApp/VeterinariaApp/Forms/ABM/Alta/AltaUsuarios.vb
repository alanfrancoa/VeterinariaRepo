Imports VeterinariaServices.Containers
Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class AltaUsuarios
    Private _daoUsuarios As New DAOUsuarios
    Private ContainerUsuarios As New ContenedorUsuarios
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

            If ContainerUsuarios.ExisteUsername(Username) Then
                MessageBox.Show("EL USERNAME YA EXISTE.")
                Return
            End If

            If Clave <> ConfimClave Then
                MessageBox.Show("LA CONTRASEÑAS NO COINCIDEN.")
                Return
            End If

            Dim nuevoUsuario As New Usuario(Username, Nombre, Clave)
            Dim Insert = _daoUsuarios.Insert(nuevoUsuario)

            If Insert Then
                MessageBox.Show("USUARIO AGREGADO.")
            Else
                MessageBox.Show("NO SE HA PODIDO AGREGAR EL USUARIO.")
            End If


        Catch ex As Exception
            MessageBox.Show($"ERROR {ex}")
        End Try
    End Sub
End Class