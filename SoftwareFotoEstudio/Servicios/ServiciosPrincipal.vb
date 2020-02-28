Public Class ServiciosPrincipal
    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        Dim servi As New ServiciosNuevo(-1)
        servi.Show()

    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim servi As New ServicioBuscarTicket
        servi.Show()

    End Sub

    Private Sub ButtonServicioAbonos_Click(sender As Object, e As EventArgs) Handles ButtonServicioAbonos.Click
        Dim servicioAbono As New ServiciosAbonos
        servicioAbono.Show()
    End Sub

    Private Sub ButtonHistoricoAbonos_Click(sender As Object, e As EventArgs) Handles ButtonHistoricoAbonos.Click
        Dim historicoAbonos As New HistorialAbonos
        historicoAbonos.Show()
    End Sub
End Class