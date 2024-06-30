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
                MessageBox.Show("Todos los campos deben ser completados.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

                Return
            End If

            ' Intentar convertir los valores de Dni y Telefono a números
            If Not Long.TryParse(TextBoxDni.Text, Dni) Or Not Long.TryParse(TextBoxTelefono.Text, Telefono) Then
                MessageBox.Show("El DNI y el teléfono deben ser números.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

                Return
            End If

            ' Verificar que Dni y Telefono no sean negativos
            If Dni <= 0 Or Telefono <= 0 Then
                MessageBox.Show("El DNI y el teléfono no pueden ser números negativos.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

                Return
            End If

            ' Verificar si el DNI ya existe
            If ContainerCliente.ExisteDni(Dni) Then
                MessageBox.Show("El DNI existe en la base.", "Dato existente", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

                Return
            End If

            Dim nuevoCliente As New Cliente(Nombre, Dni, Telefono, Email)

            Dim Insert = _daoClientes.Insert(nuevoCliente)

            'Llamar al progress bar

            If Insert Then
                MessageBox.Show("Cliente agregado.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

            Else
                MessageBox.Show("No se ha podido agregar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"ERROR {ex}")
        End Try
    End Sub
End Class