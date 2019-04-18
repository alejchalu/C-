Public Class Reporte
#Region "Variables"
    Private TablaClientes As DataTable
    Private TablaColaboradores As DataTable
    Private TablaReporte As DataTable
    Private TablaCasos As DataTable
    Dim Reporte As New Cla_Reportes
    Dim Config_Correo As New Cla_Configuracion
    Dim ReporteSoporte As New Cry_ReporteSoporte

#End Region
#Region "Metodos"
    Public Sub Inicio(Optional ByRef ReporteID As Integer = 0, Optional ByRef Solucionado As Integer = 0)
        Try
            TablaClientes = New DataTable
            TablaColaboradores = New DataTable
            TablaCasos = New DataTable

            If Solucionado Then
                CbeAtendido.Enabled = False
                CbeNombreCliente.Enabled = False
                TxtCorreoCliente.Enabled = False
                DeFechaInforme.Enabled = False
                DeFechaSolucion.Enabled = False
                TeHoraReporte.Enabled = False
                TxtReportado.Enabled = False
                MeCaso.Enabled = False
                MeSolucion.Enabled = False
                TeHoraSolucion.Enabled = False
                BtnEnviar.Enabled = False
                BtnGuardar.Enabled = False
                MePendiente.Enabled = False
                CbeCasoSolucion.Enabled = False
                BtnReenviar.Visible = True
            Else
                BtnReenviar.Visible = False
                CbeAtendido.Enabled = True
                CbeNombreCliente.Enabled = True
                TxtCorreoCliente.Enabled = True
                DeFechaInforme.Enabled = True
                DeFechaSolucion.Enabled = True
                TeHoraReporte.Enabled = True
                TxtReportado.Enabled = True
                MeCaso.Enabled = True
                MeSolucion.Enabled = True
                TeHoraSolucion.Enabled = True
                BtnEnviar.Enabled = True
                BtnGuardar.Enabled = True
                MePendiente.Enabled = True
                CbeCasoSolucion.Enabled = True
            End If

            TextoMetodo = Config_Correo.CargarDatos
            MG.ValidaMetodo(TextoMetodo)

            TablaClientes.Clear()
            Script = "Select * from clientes where Activo = 1"
            TextoMetodo = Conexion.ObtenerDatatable(Script, TablaClientes)
            MG.ValidaMetodo(TextoMetodo)

            CbeNombreCliente.Properties.DataSource = TablaClientes
            CbeNombreCliente.Properties.ValueMember = "ID"
            CbeNombreCliente.Properties.DisplayMember = "Nombre"

            TablaColaboradores.Clear()
            Script = "Select * from Colaboradores where Activo = 1"
            TextoMetodo = Conexion.ObtenerDatatable(Script, TablaColaboradores)
            MG.ValidaMetodo(TextoMetodo)

            CbeAtendido.Properties.DataSource = TablaColaboradores
            CbeAtendido.Properties.ValueMember = "ID"
            CbeAtendido.Properties.DisplayMember = "Nombre"

            TablaCasos.Clear()
            Script = "Select ID,TemaPendiente from ReporteSoporte where TemaPendienteCheck = 0"
            TextoMetodo = Conexion.ObtenerDatatable(Script, TablaCasos)
            MG.ValidaMetodo(TextoMetodo)

            CbeCasoSolucion.Properties.DataSource = TablaCasos
            CbeCasoSolucion.Properties.ValueMember = "ID"
            CbeCasoSolucion.Properties.DisplayMember = "TemaPendiente"


            Reporte.ID = ReporteID

            CbeNombreCliente.Focus()

            If ReporteID <> 0 Then
                CbeNombreCliente.Enabled = False
                CbeAtendido.Enabled = False
                TxtCorreoCliente.Enabled = False

                TextoMetodo = Reporte.CargarReportes(ReporteID)
                MG.ValidaMetodo(TextoMetodo)

                For Each Row In TablaClientes.Select("ID = " + Reporte.ClienteID.ToString)
                    CbeNombreCliente.SelectedText = Row(1).ToString
                    CbeNombreCliente.EditValue = Row(0)
                Next

                For Each Row In TablaClientes.Select("Nombre like'%" & CbeNombreCliente.Text & "%'")
                    TxtCorreoCliente.EditValue = Row(2).ToString
                Next

                For Each Row In TablaColaboradores.Select("ID = " + Reporte.ColaboradorID.ToString)
                    CbeAtendido.SelectedText = Row(1).ToString
                    CbeAtendido.EditValue = Row(0)
                Next

                For Each Row In TablaCasos.Select("ID = " + Reporte.CasoSolucion.ToString)
                    CbeCasoSolucion.SelectedText = Row(1).ToString
                    CbeCasoSolucion.EditValue = Row(0)
                Next

                DeFechaInforme.EditValue = Reporte.FechaInforme
                DeFechaSolucion.EditValue = Reporte.FechaSolucion
                TeHoraReporte.EditValue = Reporte.HoraReporte
                TxtReportado.EditValue = Reporte.ReportadoPor
                MeCaso.EditValue = Reporte.Caso
                MeSolucion.EditValue = Reporte.Solucion
                MePendiente.EditValue = Reporte.TemaPendiente
                TeHoraSolucion.EditValue = Reporte.HoraSolucion

                MeSolucion.Focus()
            End If

            Me.ShowDialog()
        Catch ex As Exception
            MG.MensajeError(ex.Message)
        End Try
    End Sub
    Public Sub Enviar()
        Try
            Try
                BarEnviando.EditValue = 0
                BarEnviando.Visible = True
                LblEnviando.Visible = True

                If Reporte.ID = 0 Then
                    GuardarID()
                End If

                BarEnviando.PerformStep()
                BarEnviando.Update()

                TablaReporte = New DataTable
                Script = "exec SeleccionarReportes " + Reporte.ID.ToString + ", 1"
                TextoMetodo = Conexion.ObtenerDatatable(Script, TablaReporte)
                MG.ValidaMetodo(TextoMetodo)

                ReporteSoporte.SetDataSource(TablaReporte)
                ReporteSoporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Config_Correo.RutaArchivo)

                BarEnviando.PerformStep()
                BarEnviando.Update()

                Dim archivo As New System.Net.Mail.Attachment(Config_Correo.RutaArchivo)
                Dim correo As New System.Net.Mail.MailMessage()
                Dim Servidor As New System.Net.Mail.SmtpClient

                correo.From = New System.Net.Mail.MailAddress(Config_Correo.CorreoDe)
                correo.Subject = Config_Correo.Asunto
                correo.To.Add(TxtCorreoCliente.EditValue)
                For Each mail As String In Config_Correo.CopiaCorreos.Split(";")
                    correo.CC.Add(mail)
                Next
                correo.Attachments.Add(archivo)
                correo.Body = Config_Correo.Cuerpo

                Servidor.Host = Config_Correo.SMTP
                Servidor.Port = Config_Correo.Puerto
                Servidor.EnableSsl = Config_Correo.SSL
                Servidor.Credentials = New System.Net.NetworkCredential(Config_Correo.UsuarioSMTP, Config_Correo.ContraseñaSMTP)
                Servidor.Send(correo)
                correo.Dispose()

                My.Computer.FileSystem.DeleteFile(Config_Correo.RutaArchivo)

                BarEnviando.PerformStep()
                BarEnviando.Update()

                Reporte.ClienteID = CbeNombreCliente.EditValue
                Reporte.ColaboradorID = CbeAtendido.EditValue
                TextoMetodo = Reporte.ActualizarEstado()
                MG.ValidaMetodo(TextoMetodo)

                BarEnviando.PerformStep()
                BarEnviando.Update()

                MG.MensajeInformacion("Proceso realizado con exito")
                Limpiar()

                TablaCasos.Clear()
                Script = "Select ID,TemaPendiente from ReporteSoporte where TemaPendienteCheck = 0"
                TextoMetodo = Conexion.ObtenerDatatable(Script, TablaCasos)
                MG.ValidaMetodo(TextoMetodo)

                CbeCasoSolucion.Properties.DataSource = TablaCasos
                CbeCasoSolucion.Properties.ValueMember = "ID"
                CbeCasoSolucion.Properties.DisplayMember = "TemaPendiente"

                BarEnviando.Visible = False
                LblEnviando.Visible = False

                CbeNombreCliente.Focus()

            Catch ex As Exception
                BarEnviando.EditValue = 0
                BarEnviando.Visible = False
                LblEnviando.Visible = False
                MG.ValidaMetodo(ex.Message)
            End Try
        Catch ex As Exception
            MG.MensajeError(ex.Message)
        End Try
    End Sub
    Public Sub Limpiar()
        Try
            Reporte.ID = 0
            CbeAtendido.EditValue = ""
            CbeNombreCliente.EditValue = ""
            TxtCorreoCliente.Text = ""
            DeFechaInforme.Text = ""
            DeFechaSolucion.Text = ""
            TeHoraReporte.EditValue = "00:00:00"
            TxtReportado.Text = ""
            MeCaso.Text = ""
            MeSolucion.Text = ""
            MePendiente.Text = ""
            TeHoraSolucion.EditValue = "00:00:00"
            CbeAtendido.Enabled = True
            CbeNombreCliente.Enabled = True
            CbeAtendido.Enabled = True
            TxtCorreoCliente.Enabled = True
            CbeCasoSolucion.EditValue = ""
        Catch ex As Exception
            MG.MensajeError(ex.Message)
        End Try
    End Sub
    Public Sub Guardar()
        Try
            Reporte.ClienteID = CbeNombreCliente.EditValue
            Reporte.ColaboradorID = CbeAtendido.EditValue
            Reporte.FechaInforme = Convert.ToDateTime(DeFechaInforme.EditValue).ToString("dd/MM/yyyy")
            Reporte.FechaSolucion = Convert.ToDateTime(DeFechaSolucion.EditValue).ToString("dd/MM/yyyy")
            Reporte.HoraReporte = Convert.ToDateTime(TeHoraReporte.EditValue).ToString("hh:mm:ss")
            Reporte.ReportadoPor = TxtReportado.EditValue
            Reporte.Caso = MeCaso.EditValue
            Reporte.Solucion = MeSolucion.EditValue
            Reporte.TemaPendiente = MePendiente.EditValue
            Reporte.HoraSolucion = Convert.ToDateTime(TeHoraSolucion.EditValue).ToString("hh:mm:ss")
            Reporte.Solucionado = 0
            If CbeCasoSolucion.EditValue.ToString <> "" Then
                Reporte.CasoSolucion = CbeCasoSolucion.EditValue
            Else
                Reporte.CasoSolucion = 0
            End If

            If Reporte.TemaPendiente <> "" Then
                Reporte.TemaPendienteCheck = False
            Else
                Reporte.TemaPendienteCheck = True
            End If

            If Reporte.ID = 0 Then
                TextoMetodo = Reporte.InsertarActualizar(VG.Insertar)
                MG.ValidaMetodo(TextoMetodo)
            Else
                TextoMetodo = Reporte.InsertarActualizar(VG.Actualizar)
                MG.ValidaMetodo(TextoMetodo)
            End If
            MG.MensajeInformacion("Proceso realizado con exito")
            Limpiar()
            Me.Close()
        Catch ex As Exception
            MG.MensajeError(ex.Message)
        End Try
    End Sub
    Public Sub GuardarID()
        Try
            Reporte.ClienteID = CbeNombreCliente.EditValue
            Reporte.ColaboradorID = CbeAtendido.EditValue
            Reporte.FechaInforme = Convert.ToDateTime(DeFechaInforme.EditValue).ToString("dd/MM/yyyy")
            Reporte.FechaSolucion = Convert.ToDateTime(DeFechaSolucion.EditValue).ToString("dd/MM/yyyy")
            Reporte.HoraReporte = Convert.ToDateTime(TeHoraReporte.EditValue).ToString("hh:mm:ss")
            Reporte.ReportadoPor = TxtReportado.EditValue
            Reporte.Caso = MeCaso.EditValue
            Reporte.Solucion = MeSolucion.EditValue
            Reporte.TemaPendiente = MePendiente.EditValue
            Reporte.HoraSolucion = Convert.ToDateTime(TeHoraSolucion.EditValue).ToString("hh:mm:ss")
            Reporte.Solucionado = 1
            If CbeCasoSolucion.EditValue.ToString <> "" Then
                Reporte.CasoSolucion = CbeCasoSolucion.EditValue
            Else
                Reporte.CasoSolucion = 0
            End If


            If Reporte.TemaPendiente <> "" Then
                Reporte.TemaPendienteCheck = False
            Else
                Reporte.TemaPendienteCheck = True
            End If

            TextoMetodo = Reporte.InsertarID()
            MG.ValidaMetodo(TextoMetodo)

            CbeCasoSolucion.EditValue = ""
        Catch ex As Exception
            MG.MensajeError(ex.Message)
        End Try
    End Sub
    Public Function ValidaErrores() As String
        Try
            Dim Errores As String = ""
            If CbeNombreCliente.EditValue.ToString = "" OrElse
                MeCaso.Text = "" OrElse
                (MeSolucion.Text = "" And MePendiente.Text = "") Then
                Errores = "Debe digitar todo lo que se le solicita"
                MG.MensajeError(Errores)
            End If
            Return Errores
        Catch ex As Exception
            MG.MensajeError(ex.Message)
            Return ex.Message
        End Try
    End Function

#End Region
#Region "Eventos"
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
    Private Sub CbeNombreCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CbeNombreCliente.KeyPress
        If e.KeyChar.Equals(Convert.ToChar(13)) Then
            CbeAtendido.SelectedText = ""
            CbeAtendido.EditValue = ""
            CbeAtendido.Properties.GetIndexByKeyValue("Predeterminado")
            DeFechaInforme.EditValue = DateTime.Now.ToString("dd/MM/yyyy")
            DeFechaSolucion.EditValue = DateTime.Now.ToString("dd/MM/yyyy")
            TeHoraReporte.EditValue = DateTime.Now.ToString("hh:mm:ss")
            For Each Row In TablaClientes.Select("Nombre like'%" & CbeNombreCliente.Text & "%'")
                TxtCorreoCliente.EditValue = Row(2)
            Next
            For Each Row In TablaColaboradores.Select("Predeterminado = True and IdEquipo = " + MG.ObtenerValorRegistro("IdEquipo"))
                CbeAtendido.EditValue = Row(0)
            Next

            TxtReportado.Focus()
        Else
            If CbeNombreCliente.Text = "" Then
                TxtCorreoCliente.EditValue = ""
            Else
                For Each Row In TablaClientes.Select("Nombre like'%" & CbeNombreCliente.Text & "%'")
                    TxtCorreoCliente.EditValue = Row(2)
                Next
            End If
        End If
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        If ValidaErrores() = "" Then
            Enviar()
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidaErrores() = "" Then
            Guardar()
        End If
    End Sub

    Private Sub Reporte_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Limpiar()
    End Sub

    Private Sub BtnReenviar_Click(sender As Object, e As EventArgs) Handles BtnReenviar.Click
        Enviar()
        Close()
    End Sub
#End Region
End Class