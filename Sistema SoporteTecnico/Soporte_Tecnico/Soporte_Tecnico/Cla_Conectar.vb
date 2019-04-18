Imports System.Data.SqlClient

Public Class Cla_Conectar
#Region "Variables"
    Private Conexion_ As New SqlConnection 'variable para la coneccion con el sql
    Private Comando_ As New SqlCommand 'varibale para ejecutar scripts
    Private Lector_ As SqlDataReader 'variable para leer datos que vienen de un script
    Private Adaptar_ As New SqlDataAdapter
    Private Transaccion_ As SqlTransaction
#End Region
#Region "Propiedades"
    Public Property Conexion As SqlConnection
        Get
            Return Conexion_
        End Get
        Set(value As SqlConnection)
            Conexion_ = value
        End Set
    End Property

    Public Property Comando As SqlCommand
        Get
            Return Comando_
        End Get
        Set(value As SqlCommand)
            Comando_ = value
        End Set
    End Property

    Public Property Lector As SqlDataReader
        Get
            Return Lector_
        End Get
        Set(value As SqlDataReader)
            Lector_ = value
        End Set
    End Property

    Public Property Adaptar As SqlDataAdapter
        Get
            Return Adaptar_
        End Get
        Set(value As SqlDataAdapter)
            Adaptar_ = value
        End Set
    End Property

    Public Property Transaccion As SqlTransaction
        Get
            Return Transaccion_
        End Get
        Set(value As SqlTransaction)
            Transaccion_ = value
        End Set
    End Property
#End Region
#Region "Metodos"

    'Verificamos que la conexion este cerrada y si es asi la abrimos
    Public Sub AbrirConexion()
        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.ConnectionString = ObtenerConexionBD()
                Conexion.Open()
            End If
        Catch ex As Exception
            If ex.Message.Contains("Login failed") Then
                Conexion.ConnectionString = ObtenerConexionBDAutentificacion()
                Conexion.Open()
            End If
        End Try
    End Sub
    'Verificamos que la conexion este abierta y si es asi la cerramos
    Public Sub CerrarConexion()
        Try
            If Conexion.State = ConnectionState.Open Then
                Conexion.ConnectionString = ObtenerConexionBD()
                Conexion.Close()
            End If
        Catch ex As Exception
            If ex.Message.Contains("Login failed") Then
                Conexion.ConnectionString = ObtenerConexionBDAutentificacion()
                Conexion.Open()
            End If
        End Try
    End Sub
    Private Function ObtenerConexionBDAutentificacion() As String
        Try
            Return "Data Source=" & MG.ObtenerValorRegistro(VG.NombreServidor) &
                   ";Initial Catalog=" & MG.ObtenerValorRegistro(VG.NombreBaseDatos) &
                   ";Integrated Security = true"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    'Este metodo nos sirve para obtener los valores necesarios para conectarnos a la bd
    Private Function ObtenerConexionBD() As String
        Try
            Return "Data Source=" & MG.ObtenerValorRegistro(VG.NombreServidor) &
                   ";Initial Catalog=" & MG.ObtenerValorRegistro(VG.NombreBaseDatos) &
                   ";User ID=" & MG.ObtenerValorRegistro(VG.UsuarioConexion) &
                   ";Password = " & MG.ObtenerValorRegistro(VG.ContraseñaConexion)
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    'este metodo funciona para ejecutar scripts
    Public Function EjecutarScript(ByRef Script As String) As String
        Try
            Comando.CommandType = CommandType.Text
            Comando.CommandTimeout = 0
            Comando.CommandText = Script
            Comando.ExecuteNonQuery()
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    'este metodo funciona para ejecutar un script y leer lo que devuelve
    Public Function EjecutarScriptLD(ByRef Script As String) As String
        Try
            AbrirConexion()
            Comando.CommandText = Script
            Comando.Connection = Conexion
            Lector = Comando.ExecuteReader
            Lector.Read()
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function ObtenerDatatable(ByRef Script As String, ByRef Tabla As DataTable) As String
        Try
            AbrirConexion()
            Comando.CommandText = Script
            Comando.Connection = Conexion
            Adaptar.SelectCommand = Comando
            Adaptar.Fill(Tabla)
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    '** METODO PARA VERIFICAR SI EXISTE LA DB **
    Public Function existe_db() As String
        Try
            Dim Existe As Boolean = False
            Dim BD As New DataTable
            Dim rows, i As Integer
            Script = "SHOW DATABASES"
            TextoMetodo = ObtenerDatatable(Script, BD)
            MG.ValidaMetodo(TextoMetodo)
            rows = BD.Rows.Count()
            i = 0
            Do While i < rows
                If BD.Rows(i).Item("DATABASE").ToString() = MG.ObtenerValorRegistro(VG.NombreBaseDatos) Then
                    Existe = True
                    Exit Do
                End If
                i = i + 1
            Loop
            If Existe = False Then
                TextoMetodo = crear_db()
                MG.ValidaMetodo(TextoMetodo)
            End If
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    '** METODO PARA CREAR LA DB **
    Public Function crear_db() As String
        Try
            Dim Cantidad As Integer = CInt(MG.ObtenerValorRegistro(VG.CantidadScripts))
            Dim Contador As Integer = 0
            Dim cmd As ProcessStartInfo
            Dim Ejecutarcmd As Process
            Do While Cantidad >= Contador
                cmd = New ProcessStartInfo("sqlcmd", "-S " + MG.ObtenerValorRegistro(VG.NombreServidor) + " -i " + MG.ObtenerValorRegistro(VG.RutaScripts) + Contador.ToString)
                cmd.UseShellExecute = False
                cmd.CreateNoWindow = True
                cmd.RedirectStandardOutput = True
                Ejecutarcmd = New Process
                Ejecutarcmd.StartInfo = cmd
                Ejecutarcmd.Start()
                Contador = Contador + 1
            Loop
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

#End Region
End Class
