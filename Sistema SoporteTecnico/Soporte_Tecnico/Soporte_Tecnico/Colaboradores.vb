Public Class Colaboradores
#Region "Variables"
    Dim Colaborador As New Cla_Colaboradores
#End Region
#Region "Metodos"
    Public Sub Inicio(Optional ByRef ColaboradorID As Integer = 0)
        Try
            Colaborador.ID = ColaboradorID
            If ColaboradorID <> 0 Then
                TextoMetodo = Colaborador.CargarColaborador(ColaboradorID)
                MG.ValidaMetodo(TextoMetodo)

                TxtNombre.EditValue = Colaborador.Nombre
                CePredeterminado.EditValue = MG.IntaBoolean(Colaborador.Predeterminado)
                CeActivo.EditValue = MG.IntaBoolean(Colaborador.Activo)
                TxtIdEquipo.EditValue = Colaborador.IdEquipo
            End If
            Me.ShowDialog()
        Catch ex As Exception
            MG.MensajeError(ex.Message)
        End Try
    End Sub

    Public Sub Guardar()
        Try
            Colaborador.Nombre = TxtNombre.EditValue
            Colaborador.Predeterminado = CePredeterminado.Checked
            Colaborador.Activo = CeActivo.Checked
            Colaborador.IdEquipo = TxtIdEquipo.EditValue

            If Colaborador.ID = 0 Then
                TextoMetodo = Colaborador.InsertarActualizar(VG.Insertar)
                MG.ValidaMetodo(TextoMetodo)
            Else
                TextoMetodo = Colaborador.InsertarActualizar(VG.Actualizar)
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
            If TxtNombre.EditValue = "" Then
                Errores = "Debe digitar el nombre del colaborador"
                MG.MensajeError(Errores)
            ElseIf CePredeterminado.Checked Then
                If Colaborador.ValidaPredetermiando Then
                    Errores = "Ya hay un colaborador predeterminado"
                    MG.MensajeError(Errores)
                End If
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

    Private Sub Colaborador_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        TxtNombre.EditValue = ""
        CePredeterminado.EditValue = False
        CeActivo.EditValue = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidaErrores() = "" Then
            Guardar()
        End If
    End Sub
#End Region
End Class