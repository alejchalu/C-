Public Class Cla_Colaboradores
#Region "Variables"
    Private ID_ As Integer
    Private Nombre_ As String
    Private Predeterminado_ As Boolean
    Private IdEquipo_ As Integer
    Private Activo_ As Boolean

#End Region
#Region "Propiedades"
    Public Property Nombre As String
        Get
            Return Nombre_
        End Get
        Set(value As String)
            Nombre_ = value
        End Set
    End Property

    Public Property Predeterminado As Boolean
        Get
            Return Predeterminado_
        End Get
        Set(value As Boolean)
            Predeterminado_ = value
        End Set
    End Property

    Public Property Activo As Boolean
        Get
            Return Activo_
        End Get
        Set(value As Boolean)
            Activo_ = value
        End Set
    End Property

    Public Property ID As Integer
        Get
            Return ID_
        End Get
        Set(value As Integer)
            ID_ = value
        End Set
    End Property

    Public Property IdEquipo As Integer
        Get
            Return IdEquipo_
        End Get
        Set(value As Integer)
            IdEquipo_ = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Function InsertarActualizar(ByRef Accion As String) As String
        Try
            Script = MG.GeneraScriptInsertarActualizar(VG.TablaColaboradores, Accion, ID, Nombre, MG.BooleanaInt(Predeterminado), MG.BooleanaInt(Activo), IdEquipo)
            TextoMetodo = Conexion.EjecutarScript(Script)
            MG.ValidaMetodo(TextoMetodo)
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function CargarColaborador(ByRef ColaboradorID As Integer) As String
        Try
            Script = "Select * from Colaboradores where ID = " + ColaboradorID.ToString
            TextoMetodo = Conexion.EjecutarScriptLD(Script)
            If Conexion.Lector.HasRows Then
                Nombre = MG.AStr(Conexion.Lector("Nombre"))
                Predeterminado = MG.IntaBoolean(Conexion.Lector("Predeterminado"))
                Activo = MG.IntaBoolean(Conexion.Lector("Activo"))
                IdEquipo = Conexion.Lector("IdEquipo")
            End If
            Return ""
        Catch ex As Exception
            Return ex.Message
        Finally
            Conexion.Lector.Close()
        End Try
    End Function
    Public Function ValidaPredetermiando() As Boolean
        Try
            If ID <> 0 Then
                Script = "Select * from Colaboradores where predeterminado = 1 and IdEquipo = " + IdEquipo.ToString +
                " and ID <> " + ID.ToString
                TextoMetodo = Conexion.EjecutarScriptLD(Script)
                If Conexion.Lector.HasRows Then
                    Return True
                End If
            Else
                Script = "Select * from Colaboradores where predeterminado = 1 and IdEquipo = " + IdEquipo.ToString
                TextoMetodo = Conexion.EjecutarScriptLD(Script)
                If Conexion.Lector.HasRows Then
                    Return True
                End If
            End If

            Return False
        Catch ex As Exception
            Return True
        Finally
            Conexion.Lector.Close()
        End Try
    End Function
    Public Function CargarLista(ByRef GridView As DevExpress.XtraGrid.GridControl, ByRef Activo As Boolean) As String
        Try
            Dim TablaColaboradores As New DataTable
            Script = "select * from Colaboradores where activo = " + MG.BooleanaInt(Activo).ToString
            TextoMetodo = Conexion.ObtenerDatatable(Script, TablaColaboradores)
            MG.ValidaMetodo(TextoMetodo)

            GridView.DataSource = TablaColaboradores
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
#End Region
End Class
