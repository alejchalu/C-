Public Class ListaReportes
#Region "Variables"
    Dim Reportes As New Cla_Reportes
    Dim Reporte As New Reporte
    Dim TablaReportes As New DataTable
#End Region
#Region "Metodos"
    Public Sub Inicio()
        Try
            RgSolucionados.EditValue = True
            Me.ShowDialog()
        Catch ex As Exception
            MG.MensajeError(ex.Message)
        End Try
    End Sub
    Public Sub Exportar()
        Try

            SfExportar.RestoreDirectory = True
            SfExportar.CheckPathExists = True
            SfExportar.InitialDirectory = "C:\"

            If GvReportes.DataRowCount <= 0 Then
                Throw New System.Exception("No hay datos para exportar")
            Else
                If RgFormatos.EditValue = "PDF" Then

                    SfExportar.Filter = "pdf files (*.pdf)|*.pdf"
                    If (SfExportar.ShowDialog() = DialogResult.OK) Then
                        GvReportes.ExportToPdf(SfExportar.FileName)

                    End If

                ElseIf RgFormatos.EditValue = "XLSX" Then

                    SfExportar.Filter = "xlsx files (*.xlsx)|*.xlsx"
                    If (SfExportar.ShowDialog() = DialogResult.OK) Then
                        GvReportes.ExportToXlsx(SfExportar.FileName)

                    End If

                Else
                    Throw New System.Exception("Debe seleccionar un formato primero")
                End If
            End If
            MG.MensajeInformacion("Proceso exitoso")
        Catch ex As Exception
            MG.MensajeError(ex.Message)
        Finally
            SfExportar.FileName = ""
        End Try
    End Sub
#End Region
#Region "Eventos"
    Private Sub RgSolucionados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RgSolucionados.SelectedIndexChanged
        TextoMetodo = Reportes.CargarLista(GcReportes, RgSolucionados.EditValue)
        MG.ValidaMetodo(TextoMetodo)
        TablaReportes = GcReportes.DataSource
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Reporte.StartPosition = FormStartPosition.CenterScreen
        Reporte.Inicio()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Reporte.StartPosition = FormStartPosition.CenterScreen
        Dim ID As Integer = GvReportes.GetRowCellValue(GvReportes.FocusedRowHandle, "ID")
        Dim Solucionado As Integer = GvReportes.GetRowCellValue(GvReportes.FocusedRowHandle, "Solucionado")
        If ID <= 0 Then
            MG.MensajeError("Debe seleccionar un reporte")
        Else
            Reporte.Inicio(ID, Solucionado)
        End If
    End Sub

    Private Sub TxtBuscar_EditValueChanged(sender As Object, e As EventArgs) Handles TxtCliente.EditValueChanged
        Dim TablaResultado As New DataTable
        TablaResultado = TablaReportes.Clone()
        For Each Row In TablaReportes.Select("[Nombre del cliente] like'%" & TxtCliente.EditValue & "%'").Clone()

            TablaResultado.Rows.Add(Row(0), Row(1), Row(2), Row(3), Row(4), Row(5), Row(6), Row(7), Row(8), Row(9), Row(10), Row(11))
        Next
        GcReportes.DataSource = TablaResultado
    End Sub

    Private Sub ListaClientes_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TextoMetodo = Reportes.CargarLista(GcReportes, RgSolucionados.EditValue)
        MG.ValidaMetodo(TextoMetodo)
        TablaReportes = GcReportes.DataSource
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Exportar()
    End Sub

    Private Sub TxtColaborador_EditValueChanged(sender As Object, e As EventArgs) Handles TxtColaborador.EditValueChanged
        Dim TablaResultado As New DataTable
        TablaResultado = TablaReportes.Clone()
        For Each Row In TablaReportes.Select("[Nombre del colaborador] like'%" & TxtColaborador.EditValue & "%'").Clone()

            TablaResultado.Rows.Add(Row(0), Row(1), Row(2), Row(3), Row(4), Row(5), Row(6), Row(7), Row(8), Row(9), Row(10), Row(11))
        Next
        GcReportes.DataSource = TablaResultado
    End Sub

#End Region
End Class