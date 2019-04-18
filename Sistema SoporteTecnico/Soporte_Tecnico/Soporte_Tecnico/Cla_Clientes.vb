Public Class Cla_Clientes
#Region "Variables"
    Private ID_ As Integer
    Private Nombre_ As String
    Private Correo_ As String
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

    Public Property Correo As String
        Get
            Return Correo_
        End Get
        Set(value As String)
            Correo_ = value
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
#End Region
#Region "Metodos"
    Public Function InsertarActualizar(ByRef Accion As String) As String
        Try
            Script = MG.GeneraScriptInsertarActualizar(VG.TablaClientes, Accion, ID, Nombre, Correo, MG.BooleanaInt(Activo))
            TextoMetodo = Conexion.EjecutarScript(Script)
            MG.ValidaMetodo(TextoMetodo)
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function CargarCliente(ByRef ClienteID As Integer) As String
        Try
            Script = "Select * from Clientes where ID = " + ClienteID.ToString
            TextoMetodo = Conexion.EjecutarScriptLD(Script)
            MG.ValidaMetodo(TextoMetodo)
            If Conexion.Lector.HasRows Then
                Nombre = MG.AStr(Conexion.Lector("Nombre"))
                Correo = MG.AStr(Conexion.Lector("Correo"))
                Activo = MG.IntaBoolean(Conexion.Lector("Activo"))
            End If
            Return ""
        Catch ex As Exception
            Return ex.Message
        Finally
            Conexion.Lector.Close()
        End Try
    End Function
    Public Function CargarLista(ByRef GridView As DevExpress.XtraGrid.GridControl, ByRef Activo As Boolean) As String
        Try
            Dim TablaClientes As New DataTable
            Script = "select * from Clientes where activo = " + MG.BooleanaInt(Activo).ToString
            TextoMetodo = Conexion.ObtenerDatatable(Script, TablaClientes)
            MG.ValidaMetodo(TextoMetodo)

            GridView.DataSource = TablaClientes
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
#End Region
End Class
