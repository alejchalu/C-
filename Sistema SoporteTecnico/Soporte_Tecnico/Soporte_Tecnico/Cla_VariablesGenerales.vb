Public Class Cla_VariablesGenerales
#Region "Cobro"
    Public SuscriptorID As String = "SuscriptorID" 'variable para tomar del registro el id del suscriptor
    Public SuscripcionHabilitada As Integer = 0
    Public SuscripcionAdvertencia As Integer = 1
    Public SuscripcionTerminada As Integer = 0
#End Region
#Region "Conexion y base de datos"
    Public NombreServidor As String = "NombreServidor"
    Public NombreBaseDatos As String = "NombreBaseDatos"
    Public UsuarioConexion As String = "UsuarioConexion"
    Public ContraseñaConexion As String = "ContraseñaConexion"
#End Region
#Region "Tablas"
    Public TablaConfiguracion As String = "Configuracion"
    Public TablaClientes As String = "Clientes"
    Public TablaColaboradores As String = "Colaboradores"
    Public TablaReporteSoporte As String = "ReporteSoporte"
    Public TablaReporteSoporteID As String = "ReporteSoporteID"
#End Region
#Region "Manipulacion de datos"
    Public Insertar As String = "Insertar"
    Public Actualizar As String = "Actualizar"
    Public RutaScripts As String = "RutaScripts"
    Public CantidadScripts As String = "CantidadScripts"
#End Region


End Class
