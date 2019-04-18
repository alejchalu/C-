Imports System.Globalization
Imports System.IO
Imports System.Text
Imports Microsoft.Win32
Public Class Cla_MetodosGenerales
#Region "Variables"

#End Region

#Region "Metodos"
    'Esta función nos permite acceder al registro de la maquina y obtener un valor
    Public Function ObtenerValorRegistro(ByVal value As String) As String
        Try
            Dim Registro As RegistryKey = Registry.LocalMachine
            Registro = Registro.OpenSubKey("Software")
            Registro = Registro.OpenSubKey("SoporteTecnico")
            Return Registro.GetValue(value)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    'Esta funcion provoca una exepcion en caso de haber un error
    Public Sub ValidaMetodo(ByRef Texto As String)
        If Texto <> "" Then
            Throw New Exception(Texto)
        End If
    End Sub
    'Funcion para mostrar mensajes de advertencia
    Public Sub MensajeAdvertencia(ByRef Texto As String)
        If Texto <> "" Then
            MessageBox.Show(Texto, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    'Funcion para mostrar mensajes de error y hacer una accion luego de que el usuario le de en "ok"
    Public Function MensajeErrorDR(ByRef Texto As String) As DialogResult
        MessageBox.Show(Texto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return DialogResult.OK
    End Function
    'Funcion para mostrar mensajes de error
    Public Sub MensajeError(ByRef Texto As String)
        If Texto <> "" Then
            MessageBox.Show(Texto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Sub MensajeInformacion(ByRef Texto As String)
        If Texto <> "" Then
            MessageBox.Show(Texto, "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    'Funcion para pasar correctamente los datos a la base de datps
    Public Function ConvertirDatosBD(ByRef Dato As Object) As String
        If IsNumeric(Dato) Then
            Dato = Dato.ToString
        ElseIf TypeOf Dato Is String Then
            Dato = "'" + Dato + "'"
        ElseIf TypeOf Dato Is Byte() Then
            Dato = "0x" + BitConverter.ToString(Dato).Replace("-", "")
        ElseIf IsNothing(Dato) Then
            Dato = "null"
        ElseIf TypeOf Dato Is DateTime And Dato.ToString.Contains("/") And Not Dato.ToString.Contains("0001") Then
            Dato = "'" + Convert.ToDateTime(Dato).ToString("dd/MM/yyyy").ToString + "'"
        ElseIf TypeOf Dato Is DateTime Then
            Dato = "'" + Convert.ToDateTime(Dato).ToString("hh:mm:ss").ToString + "'"
        End If
        Return Dato
    End Function
    'Funcion que genera script para insertar en la base de datos
    Public Function GeneraScriptInsertarActualizar(ByRef NombreTabla As String, ParamArray Valores() As Object) As String
        Try
            Script = "Exec InsertarActualizar_" + NombreTabla + " "

            For Each Valor In Valores
                Script = Script + ConvertirDatosBD(Valor) + ","
            Next

            Script = Script.Substring(0, Script.Length - 1)
            Return Script
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function GeneraScriptEliminarInsertar(ByRef NombreTabla As String, ParamArray Valores() As Object) As String
        Try
            Script = "Exec EliminarInsertar_" + NombreTabla + " "

            For Each Valor In Valores
                Script = Script + ConvertirDatosBD(Valor) + ","
            Next

            Script = Script.Substring(0, Script.Length - 1)
            Return Script
        Catch ex As Exception
            Return ""
        End Try
    End Function
    'Funcion para cargar imagenes que vienen de la base de datos en un picturebox
    Public Function CargarImagen(ByRef PictureBox As DevExpress.XtraEditors.PictureEdit, ByRef ImagenSql As Byte()) As String
        Try
            If Not IsNothing(ImagenSql) Then
                Dim MS As New MemoryStream(ImagenSql)
                PictureBox.Image = Image.FromStream(MS)
            End If
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    'Funcion para guardar imagen de un picturebox en una variable de tipo byte()
    Public Function GuardarImagen(ByRef PictureBox As DevExpress.XtraEditors.PictureEdit, ByRef ImagenSql As Byte()) As String
        Try
            If Not IsNothing(PictureBox.Image) Then
                Dim MS As New IO.MemoryStream
                PictureBox.Image.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
                ImagenSql = MS.GetBuffer
            End If
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function CargarDatosCombo(ByRef Combo As DevExpress.XtraEditors.LookUpEdit, ByRef NombreTabla As String,
                                     ByRef ColumnaID As String, ByRef ColumnaNombre As String, Optional ByRef Where As String = "")
        Try
            Dim DataTable As New DataTable
            Script = "Select " + ColumnaID + "," + ColumnaNombre +
                     " From " + NombreTabla + Where
            Conexion.ObtenerDatatable(Script, DataTable)
            Combo.Properties.DataSource = DataTable
            Combo.Properties.ValueMember = ColumnaID
            Combo.Properties.DisplayMember = ColumnaNombre

            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function CargarDatosComboGrid(ByRef Combo As DevExpress.XtraEditors.GridLookUpEdit, ByRef NombreTabla As String,
                                         ByRef ColumnaID As String, ByRef ColumnaNombre As String, Optional ByRef Where As String = "") As String
        Try
            Dim DataTable As New DataTable
            Script = "Select " + ColumnaID + "," + ColumnaNombre +
                     " From " + NombreTabla + Where
            Conexion.ObtenerDatatable(Script, DataTable)
            Combo.Properties.DataSource = DataTable
            Combo.Properties.ValueMember = ColumnaID
            Combo.Properties.DisplayMember = ColumnaNombre

            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Metodo para encryitar contraseña'
    Public Function Encriptar(ByRef Texto As String)
        Try
            Texto = Convert.ToBase64String(ASCIIEncoding.UTF8.GetBytes(Texto))
            Return Texto
        Catch ex As Exception
            Return ""
        End Try
    End Function
    'Metodo para desencriptar contraseña'
    Public Function Desencriptar(ByRef Texto As String)
        Try
            Texto = ASCIIEncoding.UTF8.GetString(Convert.FromBase64String(Texto))
            Return Texto
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function IntaBoolean(ByRef pValor As Object) As Boolean
        If IsDBNull(pValor) Then
            Return False
        ElseIf IsNothing(pValor) Then
            Return False
        ElseIf pValor = 0 Then
            Return False
        ElseIf pValor = 1 Then
            Return True
        Else Return pValor
        End If
    End Function
    Public Function BooleanaInt(ByRef pValor As Object) As Integer
        If IsDBNull(pValor) Then
            Return 0
        ElseIf IsNothing(pValor) Then
            Return 0
        ElseIf pValor = False Then
            Return 0
        ElseIf pValor = True Then
            Return 1
        Else
            Return pValor
        End If
    End Function

    Public Function AStr(ByRef pValor As Object) As String
        If IsDBNull(pValor) Then
            Return ""
        ElseIf IsNothing(pValor) Then
            Return ""
        ElseIf IsNumeric(pValor) Then
            Return pValor.ToString
        Else
            Return pValor
        End If
    End Function


#End Region
End Class
