Imports VeterinariaServices.Containers
Imports VeterinariaServices.Models

Public Class SelectorEspecie
    Private _contenedorEspecies As ContenedorEspecies
    Private _especieSeleccionada As Especie

    Public Sub New()
        InitializeComponent()
        _contenedorEspecies = New ContenedorEspecies()
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim nombre As String = TextBoxNombre.Text

        If nombre <> "" Then
            _especieSeleccionada = _contenedorEspecies.BuscarPorNombre(nombre)
            If _especieSeleccionada IsNot Nothing Then
                MessageBox.Show($"Especie encontrada: {_especieSeleccionada.Nombre}", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Dim formMuestra As New MuestraEspecie(_especieSeleccionada)
                formMuestra.Show()
            Else
                MessageBox.Show("Especie no encontrada.", "Dato no existente", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            End If
        Else
            MessageBox.Show("Ingrese un nombre válido.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        End If
    End Sub
End Class