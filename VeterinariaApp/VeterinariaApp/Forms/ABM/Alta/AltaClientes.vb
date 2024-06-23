Imports System.Security.AccessControl
Imports VeterinariaServices.Containers
Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class AltaClientes
    Private _daoClientes As New DAOClientes
    Private ContainerCliente As New ContenedorClientes
    Private Sub AltaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Nombre = TextBoxNombre.Text
            Dim Dni As Long
            Dim Telefono As Long
            Dim Email = TextBoxEmail.Text

            ' Verificar que todos los campos estén completados
            If Nombre = "" Or TextBoxDni.Text = "" Or TextBoxTelefono.Text = "" Or Email = "" Then
                MessageBox.Show("TODOS LOS CAMPOS DEBEN SER COMPLETADOS.")
                Return
            End If

            ' Intentar convertir los valores de Dni y Telefono a números
            If Not Long.TryParse(TextBoxDni.Text, Dni) Or Not Long.TryParse(TextBoxTelefono.Text, Telefono) Then
                MessageBox.Show("DNI y TELÉFONO DEBEN SER NÚMEROS VÁLIDOS.")
                Return
            End If

            ' Verificar que Dni y Telefono no sean negativos
            If Dni <= 0 Or Telefono <= 0 Then
                MessageBox.Show("NO PUEDE HABER VALORES NEGATIVOS O CERO.")
                Return
            End If

            ' Verificar si el DNI ya existe
            If ContainerCliente.ExisteDni(Dni) Then
                MessageBox.Show("EL DNI TIENE QUE SER UNICO.")
                Return
            End If

            Dim nuevoCliente As New Cliente(Nombre, Dni, Telefono, Email)

            Dim Insert = _daoClientes.Insert(nuevoCliente)

            'Llamar al progress bar

            If Insert Then
                MessageBox.Show("CLIENTE AGREGADO")
            Else
                MessageBox.Show("NO SE HA PODIDO AGREGAR EL CLIENTE")
            End If

        Catch ex As Exception
            MessageBox.Show($"ERROR {ex}")
        End Try
    End Sub
End Class