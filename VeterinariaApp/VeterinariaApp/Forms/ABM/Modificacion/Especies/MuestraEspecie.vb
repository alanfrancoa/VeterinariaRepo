Imports VeterinariaServices.Models

Public Class MuestraEspecie
    Private _especie As Especie
    Public Sub New(especie As Especie)
        InitializeComponent()
        _especie = especie
    End Sub
    Private Sub MuestraEspecie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosEspecie()
    End Sub
    Private Sub CargarDatosEspecie()
        LabelIDEspecie.Text = _especie.Id
        LabelNombreEspecie.Text = _especie.Nombre
        LabelE_Madurez.Text = _especie.EdadMadurez
        LabelTelefonoCliente.Text = _especie.PesoPromedio
    End Sub

    Private Sub ButtonEditarCliente_Click(sender As Object, e As EventArgs) Handles ButtonEditarCliente.Click
        Dim formEditarEspecie As New EditarEspecie(_especie)
        Me.Close()
        formEditarEspecie.Show()
    End Sub
End Class