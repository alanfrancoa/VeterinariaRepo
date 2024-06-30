Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class BajaUsuarios

    Private _usuario As Usuario
    Private _daoUsuario As DAOUsuarios

    Public Sub New(usuario As Usuario)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _usuario = usuario
        _daoUsuario = New DAOUsuarios()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub BajaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosUsuario()
    End Sub

    Private Sub CargarDatosUsuario()
        LabelIDUsuario.Text = _usuario.Id
        LabelNombreUsuario.Text = _usuario.Nombre
        LabelUsername.Text = _usuario.Username
        LabelEstadoUsuario.Text = _usuario.Estado

        If _usuario.Estado = "ACTIVO" Then
            ButtonBajarUsuario.Text = "Dar de Baja"
        Else
            ButtonBajarUsuario.Text = "Dar de Alta Nuevamente"
        End If

    End Sub

    Private Sub ButtonBajarUsuario_Click(sender As Object, e As EventArgs) Handles ButtonBajarUsuario.Click
        Me.Close()
        If _usuario IsNot Nothing Then
            If _usuario.Estado = "ACTIVO" Then
                'Si el cliente es activo y lo queremos dar de baja tambien deberiamos dar de baja sus mascotas.'
                Dim exitoBaja = _daoUsuario.Delete(_usuario.Id)

                If exitoBaja Then
                    MessageBox.Show("Cliente dado de baja exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

                Else
                    MessageBox.Show("No se ha podido realizar la baja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, CType(MessageBoxOptions.RightAlign, MessageBoxDefaultButton))
                End If
            Else
                Dim exitoActivar = _daoUsuario.Activar(_usuario.Id)

                If exitoActivar Then
                    MessageBox.Show("Cliente dado de alta exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

                Else
                    MessageBox.Show("No se ha podido realizar el alta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, CType(MessageBoxOptions.RightAlign, MessageBoxDefaultButton))
                End If
            End If
        End If
    End Sub
End Class