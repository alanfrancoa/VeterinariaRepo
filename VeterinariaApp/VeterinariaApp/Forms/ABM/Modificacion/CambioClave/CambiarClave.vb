Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class CambiarClave
    Private _usuario As Usuario
    Private _daoUsuarios As DAOUsuarios

    Public Sub New(usuario As Usuario)
        InitializeComponent()
        _usuario = usuario
        _daoUsuarios = New DAOUsuarios
    End Sub
    Private Sub ButtonSubir_Click(sender As Object, e As EventArgs) Handles ButtonSubir.Click

        Try
            If TextBoxActual.Text = "" Or TextBoxNueva.Text = "" Or TextBoxRepetir.Text = "" Then
                MessageBox.Show("No pueden quedar valores en blanco")
            Else
                If _usuario.Password = TextBoxActual.Text And TextBoxNueva.Text = TextBoxRepetir.Text Then
                    Dim query = $"UPDATE USUARIOS SET CLAVE = '{TextBoxNueva.Text}' WHERE ID = {_usuario.Id}"
                    Dim exito As Boolean = _daoUsuarios.Edit(query)
                    If exito Then
                        MessageBox.Show("Cliente editado correctamente.")
                    Else
                        MessageBox.Show("Hubo un error al editar el cliente.")
                    End If
                Else
                    MessageBox.Show("DATOS INCORRECTOS.")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR.")
        End Try

    End Sub
End Class