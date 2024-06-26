Imports VeterinariaServices.Models

Public Class MuestraUsuarios
    Private _usuario As Usuario
    Public Sub New(usuario As Usuario)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _usuario = usuario
    End Sub

    Private Sub MuestraUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosUsuario()
    End Sub
    Private Sub CargarDatosUsuario()
        LabelID.Text = _usuario.Id
        LabelNombre.Text = _usuario.Nombre
        LabelUser.Text = _usuario.Username
        LabelEstado.Text = _usuario.Estado
    End Sub

    Private Sub ButtonEditarCliente_Click(sender As Object, e As EventArgs) Handles ButtonEditarCliente.Click
        If _usuario IsNot Nothing Then
            Dim formEditarUsuario As New EditarUsuarios(_usuario)
            ' Mostrar el formulario
            Me.Close()
            formEditarUsuario.Show()
        End If
    End Sub
End Class