Public Class Cla_Reportes
#Region "Variables"
    Private ID_ As Integer
    Private ClienteID_ As Integer
    Private ColaboradorID_ As Integer
    Private FechaInforme_ As DateTime
    Private FechaSolucion_ As DateTime
    Private HoraReporte_ As DateTime
    Private ReportadoPor_ As String
    Private Caso_ As String
    Private Solucion_ As String
    Private TemaPendiente_ As String
    Private HoraSolucion_ As DateTime
    Private Solucionado_ As Boolean
    Private TemaPendienteCheck_ As Boolean
    Private CasoSolucion_ As Integer
#End Region
#Region "Propiedades"
    Public Property ID As Integer
        Get
            Return ID_
        End Get
        Set(value As Integer)
            ID_ = value
        End Set
    End Property

    Public Property ClienteID As Integer
        Get
            Return ClienteID_
        End Get
        Set(value As Integer)
            ClienteID_ = value
        End Set
    End Property

    Public Property ColaboradorID As Integer
        Get
            Return ColaboradorID_
        End Get
        Set(value As Integer)
            ColaboradorID_ = value
        End Set
    End Property

    Public Property FechaInforme As Date
        Get
            Return FechaInforme_
        End Get
        Set(value As Date)
            FechaInforme_ = value
        End Set
    End Property

    Public Property FechaSolucion As Date
        Get
            Return FechaSolucion_
        End Get
        Set(value As Date)
            FechaSolucion_ = value
        End Set
    End Property

    Public Property HoraReporte As Date
        Get
            Return HoraReporte_
        End Get
        Set(value As Date)
            HoraReporte_ = value
        End Set
    End Property

    Public Property ReportadoPor As String
        Get
            Return ReportadoPor_
        End Get
        Set(value As String)
            ReportadoPor_ = value
        End Set
    End Property

    Public Property Caso As String
        Get
            Return Caso_
        End Get
        Set(value As String)
            Caso_ = value
        End Set
    End Property

    Public Property Solucion As String
        Get
            Return Solucion_
        End Get
        Set(value As String)
            Solucion_ = value
        End Set
    End Property

    Public Property TemaPendiente As String
        Get
            Return TemaPendiente_
        End Get
        Set(value As String)
            TemaPendiente_ = value
        End Set
    End Property

    Public Property HoraSolucion As Date
        Get
            Return HoraSolucion_
        End Get
        Set(value As Date)
            HoraSolucion_ = value
        End Set
    End Property

    Public Property Solucionado As Boolean
        Get
            Return Solucionado_
        End Get
        Set(value As Boolean)
            Solucionado_ = value
        End Set
    End Property

    Public Property TemaPendienteCheck As Boolean
        Get
            Return TemaPendienteCheck_
        End Get
        Set(value As Boolean)
            TemaPendienteCheck_ = value
        End Set
    End Property

    Public Property CasoSolucion As Integer
        Get
            Return CasoSolucion_
        End Get
        Set(value As Integer)
            CasoSolucion_ = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Function InsertarActualizar(ByRef Accion As String) As String
        Try
            Script = MG.GeneraScriptInsertarActualizar(VG.TablaReporteSoporte,
                                                        Accion,
                                                        ID,
                                                        ClienteID,
                                                        ColaboradorID,
                                                        FechaInforme,
                                                        FechaSolucion,
                                                        HoraReporte,
                                                        ReportadoPor,
                                                        Caso,
                                                        Solucion,
                                                        TemaPendiente,
                                                        HoraSolucion,
                                                        MG.BooleanaInt(Solucionado),
                                                        MG.BooleanaInt(TemaPendienteCheck),
                                                       CasoSolucion)
            TextoMetodo = Conexion.EjecutarScript(Script)
            MG.ValidaMetodo(TextoMetodo)
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function InsertarID() As String
        Try
            Script = MG.GeneraScriptInsertarActualizar(VG.TablaReporteSoporteID,
                                                        ClienteID,
                                                        ColaboradorID,
                                                        FechaInforme,
                                                        FechaSolucion,
                                                        HoraReporte,
                                                        ReportadoPor,
                                                        Caso,
                                                        Solucion,
                                                        TemaPendiente,
                                                        HoraSolucion,
                                                        MG.BooleanaInt(Solucionado),
                                                       MG.BooleanaInt(TemaPendienteCheck),
                                                       CasoSolucion)
            TextoMetodo = Conexion.EjecutarScriptLD(Script)
            MG.ValidaMetodo(TextoMetodo)

            If Conexion.Lector.HasRows Then
                ID = MG.AStr(Conexion.Lector("ID"))
            End If

            Return ""
        Catch ex As Exception
            Return ex.Message
        Finally
            Conexion.Lector.Close()
        End Try
    End Function
    Public Function ActualizarEstado() As String
        Try
            Script = "Exec ActualizarEstadosReporte " + ID.ToString +
                      ", " + ClienteID.ToString +
                      ", " + ColaboradorID.ToString
            TextoMetodo = Conexion.EjecutarScript(Script)
            MG.ValidaMetodo(TextoMetodo)
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function CargarReportes(ByRef ReporteID As Integer) As String
        Try
            Script = "Select * from ReporteSoporte where ID = " + ReporteID.ToString
            TextoMetodo = Conexion.EjecutarScriptLD(Script)
            If Conexion.Lector.HasRows Then
                ID = MG.AStr(Conexion.Lector("ID"))
                ClienteID = MG.AStr(Conexion.Lector("ClienteID"))
                ColaboradorID = MG.AStr(Conexion.Lector("ColaboradorID"))
                FechaInforme = MG.AStr(Conexion.Lector("FechaInforme"))
                FechaSolucion = MG.AStr(Conexion.Lector("FechaSolucion"))
                HoraReporte = MG.AStr(Conexion.Lector("HoraReporte"))
                ReportadoPor = MG.AStr(Conexion.Lector("ReportadoPor"))
                Caso = MG.AStr(Conexion.Lector("Caso"))
                Solucion = MG.AStr(Conexion.Lector("Solucion"))
                TemaPendiente = MG.AStr(Conexion.Lector("TemaPendiente"))
                HoraSolucion = MG.AStr(Conexion.Lector("HoraSolucion"))
                Solucionado = MG.IntaBoolean(Conexion.Lector("Solucionado"))
                TemaPendienteCheck = MG.IntaBoolean(Conexion.Lector("TemaPendienteCheck"))
                CasoSolucion = MG.AStr(Conexion.Lector("CasoSolucionID"))
            End If
            Return ""
        Catch ex As Exception
            Return ex.Message
        Finally
            Conexion.Lector.Close()
        End Try
    End Function
    Public Function CargarLista(ByRef GridView As DevExpress.XtraGrid.GridControl, ByRef Solucionado As Boolean) As String
        Try
            Dim TablaReporteSoporte As New DataTable
            Script = "exec SeleccionarReportes 0," + MG.BooleanaInt(Solucionado).ToString
            TextoMetodo = Conexion.ObtenerDatatable(Script, TablaReporteSoporte)
            MG.ValidaMetodo(TextoMetodo)

            GridView.DataSource = TablaReporteSoporte
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
#End Region
End Class
