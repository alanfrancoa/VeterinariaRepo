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
                MessageBox.Show($"Especie encontrada: {_especieSeleccionada.Nombre}")
                Dim formMuestra As New MuestraEspecie(_especieSeleccionada)
                formMuestra.Show()
            Else
                MessageBox.Show("Especie no encontrada")
            End If
        Else
            MessageBox.Show("Por favor, ingrese un Nombre valido")
        End If
    End Sub
End Class