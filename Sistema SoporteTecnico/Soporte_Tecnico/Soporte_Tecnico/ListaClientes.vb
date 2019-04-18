Public Class ListaClientes
#Region "Variables"
    Dim Clientes As New Cla_Clientes
    Dim Cliente As New Clientes
    Dim TablaClientes As New DataTable
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
        TextoMetodo = Clientes.CargarLista(GcClientes, RgActivos.EditValue)
        MG.ValidaMetodo(TextoMetodo)
        TablaClientes = GcClientes.DataSource
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Cliente.StartPosition = FormStartPosition.CenterScreen
        Cliente.Inicio()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Cliente.StartPosition = FormStartPosition.CenterScreen
        Dim ID As Integer = GvClientes.GetRowCellValue(GvClientes.FocusedRowHandle, "ID")
        If ID <= 0 Then
            MG.MensajeError("Debe selecionar un cliente")
        Else
            Cliente.Inicio(ID)
        End If
    End Sub

    Private Sub TxtBuscar_EditValueChanged(sender As Object, e As EventArgs) Handles TxtBuscar.EditValueChanged
        Dim TablaResultado As New DataTable
        TablaResultado = TablaClientes.Clone()
        For Each Row In TablaClientes.Select("Nombre like'%" & TxtBuscar.EditValue & "%'").Clone()

            TablaResultado.Rows.Add(Row(0), Row(1), Row(2), Row(3))
        Next
        GcClientes.DataSource = TablaResultado
    End Sub

    Private Sub ListaClientes_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TextoMetodo = Clientes.CargarLista(GcClientes, RgActivos.EditValue)
        MG.ValidaMetodo(TextoMetodo)
        TablaClientes = GcClientes.DataSource
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

#End Region
End Class