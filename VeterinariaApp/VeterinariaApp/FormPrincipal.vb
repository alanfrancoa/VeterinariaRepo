Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models

Public Class FormPrincipal
    Private usuariosContainer As ContenedorUsuarios
    Private clientesContainer As ContenedorClientes
    Private mascotasContainer As ContenedorMascotas
    Private WithEvents _loginForm As FormLogin
    Private _usuarioLogueado As Usuario

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Crear instancia de UsuariosContainer y obtener la lista de usuarios
        Dim usuariosContainer As New ContenedorUsuarios()
        Dim listaUsuarios = usuariosContainer.GetAllActivos()

        ' Crear y configurar el formulario de login
        _loginForm = New FormLogin(listaUsuarios)
        _loginForm.MdiParent = Me
        _loginForm.StartPosition = FormStartPosition.CenterScreen
        _loginForm.Show() ' Mostrar el formulario de login
    End Sub

    ' Manejar el evento de login exitoso
    Private Sub LoginForm_LoginSuccessful(ByVal usuarioLogueado As Usuario) Handles _loginForm.LoginSuccessful
        _usuarioLogueado = usuarioLogueado

        ' Mostrar información del usuario
        LabelBienvenido.Text = $"Bienvenido: {_usuarioLogueado.Nombre}"
        LabelBienvenido.Visible = True
        MenuStripFormPrincipal.Visible = True

        ' Mostrar un mensaje de login exitoso
        MessageBox.Show($"Login exitoso para usuario: {_usuarioLogueado.Username}")
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim usuariosContainer As New ContenedorUsuarios()
        Dim listaUsuarios = usuariosContainer.GetUsuariosListadoCompleto()
        ' Reutilizar la instancia de UsuariosContainer
        Dim formUsuarios As New FormListadoUsuarios(listaUsuarios)
        formUsuarios.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim clientesContainer As New ContenedorClientes()
        Dim listaClientes = clientesContainer.GetAllClientes()

        Dim formClientes As New FormListadoClientes(listaClientes)
        formClientes.Show()
    End Sub

    Private Sub MascotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MascotasToolStripMenuItem.Click
        Dim mascotasContainer As New ContenedorMascotas()
        Dim listaMascotas = mascotasContainer.GetAllMascotas()

        Dim formMascotas As New FormListadoMascotas(listaMascotas)
        formMascotas.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem2.Click
        Dim formClientes As New AltaClientes()
        AltaClientes.Show()
    End Sub


    Private Sub EspeciesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspeciesToolStripMenuItem.Click
        Dim especiesContainer As New ContenedorEspecies()
        Dim listaEspecies = especiesContainer.GetAllEspecies()

        Dim formEspecies As New FormListadoEspecies(listaEspecies)
        formEspecies.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem2.Click
        Dim formUsuarios As New AltaUsuarios()
        formUsuarios.Show()
    End Sub


    Private Sub EspeciesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EspeciesToolStripMenuItem2.Click
        Dim formEspecies As New AltaEspecies()
        formEspecies.Show()
    End Sub

    Private Sub MascotasToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MascotasToolStripMenuItem2.Click
        Dim formMascotas As New AltaMascotas()
        formMascotas.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem3.Click
        Dim FormEditarCliente As New SelectorClientes()
        FormEditarCliente.Show()
    End Sub

    Private Sub MascotasToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles MascotasToolStripMenuItem3.Click
        Dim FormEditarMascota As New SelectorMascota()
        FormEditarMascota.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim FormBajaCliente As New SelectorBajaCliente()
        FormBajaCliente.Show()
    End Sub

    Private Sub MToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MToolStripMenuItem.Click
        Dim FormBajaMascota As New SelectorBajaMascotas()
        FormBajaMascota.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        Dim FormBuscadorClientes As New BuscadorClientes()
        FormBuscadorClientes.Show()
    End Sub

    Private Sub MascotasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MascotasToolStripMenuItem1.Click
        Dim FormBuscadorMascotas As New BuscadorMascotas()
        FormBuscadorMascotas.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem1.Click
        Dim FormBuscadorUsuarios As New BuscadorUsuarios()
        FormBuscadorUsuarios.Show()
    End Sub
End Class
