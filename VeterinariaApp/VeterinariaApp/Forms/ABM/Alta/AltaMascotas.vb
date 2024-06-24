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
                MessageBox.Show("TODOS LOS CAMPOS DEBEN SER COMPLETADOS.")
                Return
            End If

            If Not DateTime.TryParse(DateTimePicker1.Value, FechaNacimiento) Then
                MessageBox.Show("LOLETE")
            End If '

            If Not Decimal.TryParse(TextBoxPeso.Text, Peso) Or Not Integer.TryParse(TextBoxDni.Text, DniCliente) Then
                MessageBox.Show("LOS VALORES NUMERICOS NO SON VALIDOS.")
                Return
            End If

            If Peso <= 0 Or DniCliente <= 0 Then
                MessageBox.Show("NO PUEDE HABER VALORES NEGATIVOS O CERO.")
                Return
            End If

            Dim fechaActual As DateTime = DateTime.Today

            If FechaNacimiento > fechaActual OrElse FechaNacimiento = DateTime.MinValue Then
                MessageBox.Show("LA FECHA INGRESADA NO ES VALIDA")
                Return
            End If

            clienteBuscado = ContainerClientes.buscarPorDni(DniCliente)
            Dim IdCliente = clienteBuscado.Id

            If clienteBuscado Is Nothing Then
                MessageBox.Show("EL CLIENTE BUSCADO NO EXISTE.")
                Return
            End If

            especieBuscada = ContainerEspecies.BuscarPorNombre(NombreEspecie)
            Dim IdEspecie = especieBuscada.Id

            If especieBuscada Is Nothing Then
                MessageBox.Show("LA ESPECIE NO EXISTE.")
                Return
            End If

            Dim nuevaMascota As New Mascota(Nombre, Peso, FechaNacimiento, IdCliente, IdEspecie)
            Dim Insert = _daoMascotas.Insert(nuevaMascota)

            If Insert Then
                MessageBox.Show("MASCOTA AGREGADA.")
            Else
                MessageBox.Show("NO SE HA PODIDO AGREGAR LA MASCOTA.")
            End If

        Catch ex As Exception
            MessageBox.Show($"ERROR {ex}")
        End Try

    End Sub
End Class