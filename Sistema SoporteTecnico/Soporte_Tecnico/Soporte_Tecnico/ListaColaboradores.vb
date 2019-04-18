Public Class ListaColaboradores
#Region "Variables"
    Dim Colaboradores As New Cla_Colaboradores
    Dim Colaborador As New Colaboradores
    Dim TablaColaboradores As New DataTable
#End Region
#Region "Metodos"
    Public Sub Inicio()
        Try
            RgActivos.EditValue = True
            Me.ShowDialog()
        Catch ex As Exception
            MG.MensajeError(ex.Message)
        End Try
    End Sub
#End Region
#Region "Eventos"
    Private Sub RgActivos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RgActivos.SelectedIndexChanged
        TextoMetodo = Colaboradores.CargarLista(GcColaboradores, RgActivos.EditValue)
        MG.ValidaMetodo(TextoMetodo)
        TablaColaboradores = GcColaboradores.DataSource
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Colaborador.StartPosition = FormStartPosition.CenterScreen
        Colaborador.Inicio()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Colaborador.StartPosition = FormStartPosition.CenterScreen
        Dim ID As Integer = GvColaboradores.GetRowCellValue(GvColaboradores.FocusedRowHandle, "ID")
        If ID <= 0 Then
            MG.MensajeError("Debe seleccionar un colaborador")
        Else
            Colaborador.Inicio(ID)
        End If
    End Sub

    Private Sub TxtBuscar_EditValueChanged(sender As Object, e As EventArgs) Handles TxtBuscar.EditValueChanged
        Dim TablaResultado As New DataTable
        TablaResultado = TablaColaboradores.Clone()
        For Each Row In TablaColaboradores.Select("Nombre like'%" & TxtBuscar.EditValue & "%'").Clone()

            TablaResultado.Rows.Add(Row(0), Row(1), Row(2), Row(3))
        Next
        GcColaboradores.DataSource = TablaResultado
    End Sub

    Private Sub ListaColaboradores_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TextoMetodo = Colaboradores.CargarLista(GcColaboradores, RgActivos.EditValue)
        MG.ValidaMetodo(TextoMetodo)
        TablaColaboradores = GcColaboradores.DataSource
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

#End Region
End Class