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
                MessageBox.Show("Todos los campos deben ser completados.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Return
            End If

            If Not Integer.TryParse(TextBoxE_Madurez.Text, EdadMadurez) Then
                MessageBox.Show("Los valores numericos no son válidos.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Return
            End If

            ' NO SE CARGA COMO DECIMAL EN LA DB ARREGLARLO...(X)
            If Not Decimal.TryParse(TextBoxPesoProm.Text, PesoProm) Then
                MessageBox.Show("Los valores numericos no son válidos.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Return
            End If

            If EdadMadurez <= 0 Or PesoProm <= 0 Then
                MessageBox.Show("No se pueden ingresar valores negativos o cero.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Return
            End If

            Dim EspecieBuscada As Especie = Nothing
            EspecieBuscada = ContainerEspecie.BuscarPorNombre(Nombre)

            If EspecieBuscada IsNot Nothing Then
                MessageBox.Show("La especie ingresada ya existe.", "Dato existente", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Return
            End If

            Dim nuevaEspecie As New Especie(Nombre, EdadMadurez, PesoProm)
            Dim Insert = _daoEspecies.Insert(nuevaEspecie)


            If Insert Then
                MessageBox.Show("Especie agregada exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Else
                MessageBox.Show("No se ha podido agregar la especie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, CType(MessageBoxOptions.RightAlign, MessageBoxDefaultButton))
            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"ERROR {ex}")
        End Try

    End Sub
End Class