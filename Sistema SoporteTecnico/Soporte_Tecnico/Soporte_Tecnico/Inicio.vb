Public Class Inicio

#Region "Eventos"

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        Dim ListaReportes As New ListaReportes
        ListaReportes.StartPosition = FormStartPosition.CenterScreen
        ListaReportes.Inicio()
    End Sub

    Private Sub BtnConfiguracion_Click(sender As Object, e As EventArgs) Handles BtnConfiguracion.Click
        Dim Configuracion As New Configuracion
        Configuracion.StartPosition = FormStartPosition.CenterScreen
        Configuracion.Inicio()
    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Dim ListaClientes As New ListaClientes
        ListaClientes.StartPosition = FormStartPosition.CenterScreen
        ListaClientes.Inicio()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub BtnColaboradores_Click(sender As Object, e As EventArgs) Handles BtnColaboradores.Click
        Dim ListaColaboradores As New ListaColaboradores
        ListaColaboradores.StartPosition = FormStartPosition.CenterScreen
        ListaColaboradores.Inicio()
    End Sub

#End Region
End Class
