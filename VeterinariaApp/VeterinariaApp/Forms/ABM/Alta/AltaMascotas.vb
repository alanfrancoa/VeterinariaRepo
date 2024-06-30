Imports System.Globalization
Imports VeterinariaServices.Containers
Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class AltaMascotas
    Private ContainerEspecies As New ContenedorEspecies
    Private ContainerClientes As New ContenedorClientes
    Private _daoMascotas As New DAOMascotas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Nombre = TextBoxNombre.Text
            Dim Peso As Decimal
            Dim FechaNacimiento As DateTime
            Dim DniCliente As Integer
            Dim NombreEspecie = TextBoxEspecie.Text

            Dim clienteBuscado As Cliente = Nothing
            Dim especieBuscada As Especie = Nothing

            If Nombre = "" Or TextBoxPeso.Text = "" Or TextBoxDni.Text = "" Or NombreEspecie = "" Then
                MessageBox.Show("Todos los campos deben ser completados.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Return
            End If

            If Not DateTime.TryParse(DateTimePicker1.Value, FechaNacimiento) Then
                MessageBox.Show("La fecha ingresada no es válida.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Return
            End If

            If Not Decimal.TryParse(TextBoxPeso.Text, Peso) Or Not Integer.TryParse(TextBoxDni.Text, DniCliente) Then
                MessageBox.Show("Los valores numericos no son válidos.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Return
            End If

            If Peso <= 0 Or DniCliente <= 0 Then
                MessageBox.Show("No se pueden ingresar valores negativos o cero.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Return
            End If


            Dim fechaActual As DateTime = DateTime.Today


            If fechaActual.Year < FechaNacimiento.Year Then
                MessageBox.Show("La fecha ingresada no es válida.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Return
            ElseIf fechaActual.Year = FechaNacimiento.Year Then
                If fechaActual.DayOfYear < FechaNacimiento.DayOfYear Then
                    MessageBox.Show("La fecha ingresada no es válida.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                    Return
                End If
            End If


            clienteBuscado = ContainerClientes.buscarPorDni(DniCliente)


            If clienteBuscado Is Nothing Then
                MessageBox.Show("El cliente buscado no existe.", "Dato no existente", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Return
            End If
            Dim IdCliente = clienteBuscado.Id

            especieBuscada = ContainerEspecies.BuscarPorNombre(NombreEspecie)

            If especieBuscada Is Nothing Then
                MessageBox.Show("La especie buscada no existe.", "Dato no existente.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Return
            End If
            Dim IdEspecie = especieBuscada.Id

            Dim nuevaMascota As New Mascota(Nombre, Peso, FechaNacimiento, IdCliente, IdEspecie)
            Dim Insert = _daoMascotas.Insert(nuevaMascota)

            If Insert Then
                MessageBox.Show("Mascota agregada.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Else
                MessageBox.Show("No se ha podido agregar la mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"ERROR {ex}")
        End Try

    End Sub
End Class