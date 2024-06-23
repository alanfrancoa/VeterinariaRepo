﻿Imports VeterinariaServices.Models
Imports System.Threading.Tasks

Public Class FormLogin
    Private _usuarios As List(Of Usuario)
    Private _loginTask As Task(Of Usuario)
    Private _loginSuccessfulUser As Usuario

    Public Event LoginSuccessful(ByVal usuarioLogueado As Usuario)

    Public Sub New(usuarios As List(Of Usuario))
        InitializeComponent()
        _usuarios = usuarios
        Me.StartPosition = FormStartPosition.CenterScreen
        ProgressBarLogin.Visible = False
        TimerBar.Interval = 100 ' Ajusta el intervalo según sea necesario
    End Sub

    Public ReadOnly Property LoggedUser As Usuario
        Get
            Return _loginSuccessfulUser
        End Get
    End Property

    Private Sub ButtonIr_Click(sender As Object, e As EventArgs) Handles ButtonIr.Click
        ' Ocultar botones y mostrar progress bar
        ButtonIr.Visible = False
        ButtonRegistro.Visible = False
        TextBoxUsuario.Enabled = False
        TextBoxContrasena.Enabled = False
        ProgressBarLogin.Visible = True
        ProgressBarLogin.Value = 0
        TimerBar.Start()

        ' Obtener credenciales de usuario
        Dim username As String = TextBoxUsuario.Text
        Dim password As String = TextBoxContrasena.Text

        ' Iniciar el proceso de login en un hilo separado
        _loginTask = Task.Run(Function() Login(username, password))
    End Sub

    Private Async Sub TimerBar_Tick(sender As Object, e As EventArgs) Handles TimerBar.Tick
        ' Avanzar la progress bar
        If ProgressBarLogin.Value >= ProgressBarLogin.Maximum Then
            TimerBar.Stop()
            Me.Close()
        Else
            Dim nuevoValor = ProgressBarLogin.Value + 10
            ProgressBarLogin.Value = Math.Min(nuevoValor, ProgressBarLogin.Maximum)
        End If

        ' Verificar si el login ha terminado
        If _loginTask IsNot Nothing AndAlso _loginTask.IsCompleted Then
            ' Obtener el resultado del login
            _loginSuccessfulUser = Await _loginTask

            ' Detener el timer
            TimerBar.Stop()

            ' Mostrar el resultado del login
            If _loginSuccessfulUser IsNot Nothing Then
                MessageBox.Show("Login exitoso!")
                RaiseEvent LoginSuccessful(_loginSuccessfulUser) ' Disparar el evento de login exitoso con el usuario logueado
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.")
            End If

            ' Restaurar botones y ocultar progress bar
            ProgressBarLogin.Visible = False
            ButtonIr.Visible = True
            ButtonRegistro.Visible = True
            TextBoxUsuario.Enabled = True
            TextBoxContrasena.Enabled = True
        End If
    End Sub

    Private Function Login(username As String, password As String) As Usuario
        Return _usuarios.FirstOrDefault(Function(u) u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) AndAlso u.Password = password)
    End Function

End Class
