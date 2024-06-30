Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models

Public Class BuscadorUsuarios
    Private _contenedorUsuarios As ContenedorUsuarios
    Private _usuarioSeleccionado As Usuario

    ''' <summary>
    ''' Constructor del formulario
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        _contenedorUsuarios = New ContenedorUsuarios()
    End Sub

    ''' <summary>
    ''' Método para buscar usuario por nombre de usuario.
    ''' </summary>
    Private Sub ButtonBusquedaID_Click(sender As Object, e As EventArgs) Handles ButtonBusquedaUsername.Click
        Dim usernameABuscar = TextBoxBusquedaUsuario.Text

        If String.IsNullOrEmpty(usernameABuscar) Then
            MessageBox.Show("Ingrese un valor a buscar.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Else
            _usuarioSeleccionado = _contenedorUsuarios.GetUsuarioByUsername(usernameABuscar)
            If _usuarioSeleccionado IsNot Nothing Then
                Me.Close()
                MessageBox.Show($"Usuario encontrado: {_usuarioSeleccionado.Nombre} ", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

                'llamamos al form de muestra de informacion
                Dim formMuestraUsuario As New BusquedaUsuario(_usuarioSeleccionado)
                formMuestraUsuario.Show()
            End If
        End If
    End Sub



End Class