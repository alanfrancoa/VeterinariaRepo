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
                MessageBox.Show("Todos los campos deben ser completados.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Return
            End If

            If _contenedorUsuarios.ExisteUsername(Username) Then
                MessageBox.Show("El nombre de usuario ingresado ya existe.", "Dato existente", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Return
            End If

            If Clave <> ConfimClave Then
                MessageBox.Show("Las claves no coinciden.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
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
                    MessageBox.Show("Cliente agregado.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

                Else
                    MessageBox.Show("No se ha podido agregar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                End If
            Else
                Dim BarraDeProgreso As New BarraDeProgreso
                BarraDeProgreso.Show()
                ' Lógica para cuando las credenciales son inválidas o el usuario no es administrador
                MessageBox.Show("Acceso denegado. Las credenciales no son correctas o el usuario no es administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            End If

        Catch ex As Exception
            MessageBox.Show($"ERROR {ex}")
        End Try
    End Sub
End Class
