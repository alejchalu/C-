Public Class Clientes
#Region "Variables"
    Dim Cliente As New Cla_Clientes
#End Region
#Region "Metodos"
    Public Sub Inicio(Optional ByRef ClienteID As Integer = 0)
        Try
            Cliente.ID = ClienteID
            If ClienteID <> 0 Then
                TextoMetodo = Cliente.CargarCliente(ClienteID)
                MG.ValidaMetodo(TextoMetodo)

                TxtNombre.EditValue = Cliente.Nombre
                TxtCorreo.EditValue = Cliente.Correo
                CeActivo.EditValue = MG.IntaBoolean(Cliente.Activo)
            End If
            Me.ShowDialog()
        Catch ex As Exception
            MG.MensajeError(ex.Message)
        End Try
    End Sub

    Public Sub Guardar()
        Try
            Cliente.Nombre = TxtNombre.EditValue
            Cliente.Correo = TxtCorreo.EditValue
            Cliente.Activo = CeActivo.Checked

            If Cliente.ID = 0 Then
                TextoMetodo = Cliente.InsertarActualizar(VG.Insertar)
                MG.ValidaMetodo(TextoMetodo)
            Else
                TextoMetodo = Cliente.InsertarActualizar(VG.Actualizar)
                MG.ValidaMetodo(TextoMetodo)
            End If
            MG.MensajeInformacion("Proceso realizado con exito")
            Me.Close()
        Catch ex As Exception
            MG.MensajeError(ex.Message)
        End Try
    End Sub
    Public Function ValidaErrores() As String
        Try
            Dim Errores As String = ""
            If TxtNombre.EditValue = "" Or TxtCorreo.EditValue = "" Then
                Errores = "Debe digitar todo lo que se le solicita"
                MG.MensajeError(Errores)
            ElseIf Not TxtCorreo.EditValue.Contains("@") Or Not TxtCorreo.EditValue.Contains(".") Then
                Errores = "Debe digitar un correo valido"
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

    Private Sub Clientes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        TxtNombre.EditValue = ""
        TxtCorreo.EditValue = ""
        CeActivo.EditValue = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidaErrores() = "" Then
            Guardar()
        End If
    End Sub

#End Region
End Class