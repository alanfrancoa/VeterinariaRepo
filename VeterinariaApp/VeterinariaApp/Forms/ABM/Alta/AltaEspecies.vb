Imports System.Globalization
Imports VeterinariaServices.Containers
Imports VeterinariaServices.DAOs
Imports VeterinariaServices.Models

Public Class AltaEspecies
    Private ContainerEspecie As New ContenedorEspecies
    Private _daoEspecies As New DAOEspecies
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim Nombre = TextBoxNombre.Text
            Dim EdadMadurez As Integer
            Dim PesoProm As Decimal

            If Nombre = "" Or TextBoxE_Madurez.Text = "" Or TextBoxPesoProm.Text = "" Then
                MessageBox.Show("TODOS LOS CAMPOS DEBEN SER COMPLETADOS.")
                Return
            End If

            If Not Integer.TryParse(TextBoxE_Madurez.Text, EdadMadurez) Then
                MessageBox.Show("LOS VALORES NUMERICOS NO SON VALIDOS.")
                Return
            End If

            ' NO SE CARGA COMO DECIMAL EN LA DB ARREGLARLO...(X)
            If Not Decimal.TryParse(TextBoxPesoProm.Text, PesoProm) Then
                MessageBox.Show("LOS VALORES NUMERICOS NO SON VALIDOS.")
                Return
            End If

            If EdadMadurez <= 0 Or PesoProm <= 0 Then
                MessageBox.Show("NO PUEDE HABER VALORES NEGATIVOS O CERO.")
                Return
            End If

            Dim EspecieBuscada As Especie = Nothing
            EspecieBuscada = ContainerEspecie.BuscarPorNombre(Nombre)

            If EspecieBuscada IsNot Nothing Then
                MessageBox.Show("ESPECIE YA EXISTENTE.")
                Return
            End If

            Dim nuevaEspecie As New Especie(Nombre, EdadMadurez, PesoProm)
            Dim Insert = _daoEspecies.Insert(nuevaEspecie)

            If Insert Then
                MessageBox.Show("ESPECIE AGREGADA.")
            Else
                MessageBox.Show("NO SE HA PODIDO AGREGAR LA ESPECIE.")
            End If

        Catch ex As Exception
            MessageBox.Show($"ERROR {ex}")
        End Try

    End Sub
End Class