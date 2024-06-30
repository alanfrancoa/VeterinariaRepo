Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models

Public Class SelectorUsuario
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
                MessageBox.Show($"Usuario encontrado: {_usuarioSeleccionado.Nombre}", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

                Dim formMuestraUsuario As New MuestraUsuarios(_usuarioSeleccionado)
                formMuestraUsuario.Show()
            Else
                MessageBox.Show("Usuario no encontrado", "Dato no existente", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            End If
        Else
            MessageBox.Show("Ingrese nombre de usuario correctamente.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        End If
    End Sub
End Class