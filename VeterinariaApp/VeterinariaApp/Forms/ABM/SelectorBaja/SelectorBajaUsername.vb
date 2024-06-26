Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models

Public Class SelectorBajaUsername
    Private _contenedorUsuarios As ContenedorUsuarios
    Private _usuarioSeleccionado As Usuario

    Public Sub New()
        InitializeComponent()
        _contenedorUsuarios = New ContenedorUsuarios()
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim username As String = TextBoxUsername.Text

        If username <> "" Then
            _usuarioSeleccionado = _contenedorUsuarios.GetUsuarioByUsername(username)
            If _usuarioSeleccionado IsNot Nothing Then
                Me.Close()
                MessageBox.Show($"Usuario encontrado: {_usuarioSeleccionado.Nombre}")

                Dim formMuestraBajaUsuario As New BajaUsuarios(_usuarioSeleccionado)
                formMuestraBajaUsuario.Show()
            Else
                MessageBox.Show("Usuario no encontrado.")
            End If
        Else
            MessageBox.Show("Por favor, Ingrese el nombre de usuario correctamente.")
        End If
    End Sub
End Class