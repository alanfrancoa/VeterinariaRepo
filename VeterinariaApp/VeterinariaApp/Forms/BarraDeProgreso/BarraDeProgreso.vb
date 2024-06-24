Public Class BarraDeProgreso
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Close()
            'Si el timer llega a su maximo, se cierra el Form'
        Else
            Dim nuevoValor = ProgressBar1.Value + 10
            'va sumando de a 10'
            ProgressBar1.Value = Math.Min(nuevoValor, ProgressBar1.Maximum)
            'Se establece el techo con el Math, se usa bastante.'

        End If

    End Sub

    Private Sub BarraDeProgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class