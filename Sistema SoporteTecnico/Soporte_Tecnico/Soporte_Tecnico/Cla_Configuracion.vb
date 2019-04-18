Public Class Cla_Configuracion
#Region "Variables"
    Private SMTP_ As String
    Private ContraseñaSMTP_ As String
    Private UsuarioSMTP_ As String
    Private Puerto_ As Integer
    Private SSL_ As Boolean
    Private CorreoDe_ As String
    Private Asunto_ As String
    Private Cuerpo_ As String
    Private CopiaCorreos_ As String
    Private RutaArchivo_ As String

#End Region
#Region "Propiedades"
    Public Property SMTP As String
        Get
            Return SMTP_
        End Get
        Set(value As String)
            SMTP_ = value
        End Set
    End Property

    Public Property ContraseñaSMTP As String
        Get
            Return ContraseñaSMTP_
        End Get
        Set(value As String)
            ContraseñaSMTP_ = value
        End Set
    End Property

    Public Property UsuarioSMTP As String
        Get
            Return UsuarioSMTP_
        End Get
        Set(value As String)
            UsuarioSMTP_ = value
        End Set
    End Property

    Public Property Puerto As Integer
        Get
            Return Puerto_
        End Get
        Set(value As Integer)
            Puerto_ = value
        End Set
    End Property

    Public Property SSL As Boolean
        Get
            Return SSL_
        End Get
        Set(value As Boolean)
            SSL_ = value
        End Set
    End Property

    Public Property CorreoDe As String
        Get
            Return CorreoDe_
        End Get
        Set(value As String)
            CorreoDe_ = value
        End Set
    End Property

    Public Property Asunto As String
        Get
            Return Asunto_
        End Get
        Set(value As String)
            Asunto_ = value
        End Set
    End Property

    Public Property Cuerpo As String
        Get
            Return Cuerpo_
        End Get
        Set(value As String)
            Cuerpo_ = value
        End Set
    End Property

    Public Property CopiaCorreos As String
        Get
            Return CopiaCorreos_
        End Get
        Set(value As String)
            CopiaCorreos_ = value
        End Set
    End Property

    Public Property RutaArchivo As String
        Get
            Return RutaArchivo_
        End Get
        Set(value As String)
            RutaArchivo_ = value
        End Set
    End Property
#End Region
#Region "Metodos"

    Public Function CargarDatosTabla(ByRef Tabla As DataTable) As String
        Try
            Script = "select * from Configuracion"
            TextoMetodo = Conexion.ObtenerDatatable(Script, Tabla)
            MG.ValidaMetodo(TextoMetodo)
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function CargarDatos() As String
        Try
            Script = "select * from Configuracion"
            TextoMetodo = Conexion.EjecutarScriptLD(Script)
            MG.ValidaMetodo(TextoMetodo)

            If Conexion.Lector.HasRows Then
                SMTP = MG.AStr(Conexion.Lector("SMTP"))
                ContraseñaSMTP = MG.AStr(Conexion.Lector("ContraseñaSMTP"))
                UsuarioSMTP = MG.AStr(Conexion.Lector("UsuarioSMTP"))
                Puerto = Conexion.Lector("Puerto")
                SSL = MG.IntaBoolean(Conexion.Lector("SSL"))
                CorreoDe = MG.AStr(Conexion.Lector("CorreoDe"))
                Asunto = MG.AStr(Conexion.Lector("Asunto"))
                Cuerpo = MG.AStr(Conexion.Lector("Cuerpo"))
                CopiaCorreos = MG.AStr(Conexion.Lector("CopiaCorreos"))
                RutaArchivo = MG.AStr(Conexion.Lector("RutaArchivo"))
            End If
            Return ""
        Catch ex As Exception
            Return ex.Message
        Finally
            Conexion.Lector.Close()
        End Try
    End Function
    Public Function Guardar() As String
        Try
            Script = MG.GeneraScriptEliminarInsertar(VG.TablaConfiguracion, SMTP, ContraseñaSMTP, UsuarioSMTP,
                                                     Puerto, MG.BooleanaInt(SSL), CorreoDe, Asunto, Cuerpo, CopiaCorreos, RutaArchivo)
            TextoMetodo = Conexion.EjecutarScript(Script)
            MG.ValidaMetodo(TextoMetodo)

        Catch ex As Exception

        End Try
        Return ""
    End Function

#End Region
End Class
