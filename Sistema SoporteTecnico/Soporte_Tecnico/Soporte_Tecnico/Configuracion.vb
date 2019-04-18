Public Class Configuracion
#Region "Variables"
    Private Configuracion As New Cla_Configuracion
#End Region
#Region "Metodos"
    Public Sub Inicio()
        Try
            TxtSMTP.Enabled = False
            TxtAsunto.Enabled = False
            TxtContraseñaSMTP.Enabled = False
            TxtDeCorreo.Enabled = False
            TxtUsuarioSMTP.Enabled = False
            SePuerto.Enabled = False
            MeCopiaCorreos.Enabled = False
            MeCuerpo.Enabled = False
            CeSSL.Enabled = False
            TxtRutaArchivo.Enabled = False
            BtnBuscar.Enabled = False

            TextoMetodo = Configuracion.CargarDatos()
            MG.ValidaMetodo(TextoMetodo)

            TxtAsunto.EditValue = Configuracion.Asunto
            TxtContraseñaSMTP.EditValue = Configuracion.ContraseñaSMTP
            TxtDeCorreo.EditValue = Configuracion.CorreoDe
            TxtSMTP.EditValue = Configuracion.SMTP
            TxtUsuarioSMTP.EditValue = Configuracion.UsuarioSMTP
            SePuerto.EditValue = Configuracion.Puerto
            CeSSL.EditValue = Configuracion.SSL
            MeCopiaCorreos.EditValue = Configuracion.CopiaCorreos
            MeCuerpo.EditValue = Configuracion.Cuerpo
            TxtRutaArchivo.EditValue = Configuracion.RutaArchivo

            Me.ShowDialog()
        Catch ex As Exception
            MG.MensajeError(ex.Message)
        End Try
    End Sub
    Public Sub Guardar()
        Try
            Configuracion.Asunto = TxtAsunto.EditValue
            Configuracion.ContraseñaSMTP = TxtContraseñaSMTP.EditValue
            Configuracion.CorreoDe = TxtDeCorreo.EditValue
            Configuracion.SMTP = TxtSMTP.EditValue
            Configuracion.UsuarioSMTP = TxtUsuarioSMTP.EditValue
            Configuracion.Puerto = SePuerto.EditValue
            Configuracion.SSL = CeSSL.EditValue
            Configuracion.CopiaCorreos = MeCopiaCorreos.EditValue
            Configuracion.Cuerpo = MeCuerpo.EditValue
            Configuracion.RutaArchivo = TxtRutaArchivo.EditValue

            TextoMetodo = Configuracion.Guardar()
            MG.ValidaMetodo(TextoMetodo)
            MG.MensajeInformacion("Proceso realizado con exito")
            Me.Close()
        Catch ex As Exception
            MG.MensajeError(ex.Message)
        End Try
    End Sub
#End Region
#Region "Eventos"

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TxtSMTP.Enabled = True Then
            TxtSMTP.Enabled = False
            TxtAsunto.Enabled = False
            TxtContraseñaSMTP.Enabled = False
            TxtDeCorreo.Enabled = False
            TxtUsuarioSMTP.Enabled = False
            SePuerto.Enabled = False
            MeCopiaCorreos.Enabled = False
            MeCuerpo.Enabled = False
            CeSSL.Enabled = False
            TxtRutaArchivo.Enabled = False
            BtnBuscar.Enabled = False
        Else
            TxtSMTP.Enabled = True
            TxtAsunto.Enabled = True
            TxtContraseñaSMTP.Enabled = True
            TxtDeCorreo.Enabled = True
            TxtUsuarioSMTP.Enabled = True
            SePuerto.Enabled = True
            MeCopiaCorreos.Enabled = True
            MeCuerpo.Enabled = True
            CeSSL.Enabled = True
            TxtRutaArchivo.Enabled = True
            BtnBuscar.Enabled = True
            TxtSMTP.Focus()
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Guardar()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub Configuracion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        TxtSMTP.EditValue = Nothing
        TxtSMTP.EditValue = Nothing
        TxtAsunto.EditValue = Nothing
        TxtContraseñaSMTP.EditValue = Nothing
        TxtDeCorreo.EditValue = Nothing
        TxtUsuarioSMTP.EditValue = Nothing
        SePuerto.EditValue = Nothing
        MeCopiaCorreos.EditValue = Nothing
        MeCuerpo.EditValue = Nothing
        CeSSL.EditValue = Nothing
        TxtRutaArchivo.EditValue = Nothing
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If (OfBuscar.ShowDialog() = DialogResult.OK) Then
            TxtRutaArchivo.EditValue = OfBuscar.FileName
        End If
    End Sub
#End Region
End Class