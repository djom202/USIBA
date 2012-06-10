Imports MySql.Data.MySqlClient

Public Class Conexion

    Private conexion2 As New MySqlConnection

    Public Function SuperConexionMySQL() As Boolean
        Try
            Conexion2 = New MySqlConnection()
            Conexion2.ConnectionString = "server=" & My.Settings.server & ";" & " port=" & My.Settings.port & ";" & " user id=" & My.Settings.usuario & ";" & " password=" & My.Settings.password & ";" & " database=" & My.Settings.basedatos & ";"
            Conexion2.Open()
            Return vbTrue
        Catch ex As MySqlException
            Debug.Items.Add("")
            Debug.Items.Add(ex.Message)
            Debug.Items.Add("")
            archivos.Log("[" & DateTime.Now.ToLongTimeString & "] >> " & ex.Message)
            Return vbFalse
        End Try
    End Function

    Public Function ConexionMySQL(ByRef deb As System.Windows.Forms.ListBox, ByVal server As String, ByVal port As String, ByVal user As String, ByVal pass As String, ByVal db As String) As Boolean
        Try
            Debug = deb
            Conexion2 = New MySqlConnection()
            Conexion2.ConnectionString = "server=" & server & ";" & " port=" & port & ";" & " user id=" & user & ";" & " password=" & pass & ";" & " database=" & db & ";"
            Conexion2.Open()

            If Conexion2.State = System.Data.ConnectionState.Open Then
                Return vbTrue
            Else
                Return False
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
            archivos.Log("[" & DateTime.Now.ToLongTimeString & "] >> " & ex.Message)
            Return vbFalse
        End Try
    End Function

    Public Function ConexionMysqlEstado() As System.Data.ConnectionState
        Try
            Select Case Conexion2.State
                Case System.Data.ConnectionState.Open
                    Return System.Data.ConnectionState.Open
                Case System.Data.ConnectionState.Broken
                    Return System.Data.ConnectionState.Broken
                Case System.Data.ConnectionState.Closed
                    Return System.Data.ConnectionState.Closed
                Case System.Data.ConnectionState.Connecting
                    Return System.Data.ConnectionState.Connecting
                Case System.Data.ConnectionState.Executing
                    Return System.Data.ConnectionState.Executing
                Case System.Data.ConnectionState.Fetching
                    Return System.Data.ConnectionState.Fetching
            End Select

            Return Nothing
        Catch ex As Exception
            archivos.Log("[" & DateTime.Now.ToLongTimeString & "] >> " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub DesconexionMySQL()
        Try
            Conexion2.Close()
        Catch ex As MySqlException
            archivos.Log("[" & DateTime.Now.ToLongTimeString & "] >> " & ex.Message)
        End Try
    End Sub

    Public Function DDL(ByVal Query As String) As MySql.Data.MySqlClient.MySqlDataReader
        Try
            If Not conexion2 Is Nothing Then
                Dim comandos As New MySqlCommand
                comandos.Connection = conexion2
                comandos.CommandText = Query
                Return comandos.ExecuteReader()
            End If
        Catch ex As MySqlException
            archivos.Backup(Query)
            archivos.Log("[" & DateTime.Now.ToLongTimeString & "] >> " & ex.Message)
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function DML(ByVal Query As String) As Integer 'no regresa un resultado
        Try
            If Not conexion2 Is Nothing Then
                Dim comandos As New MySqlCommand
                comandos.Connection = conexion2
                comandos.CommandText = Query
                Return comandos.ExecuteNonQuery
            End If
        Catch ex As MySqlException
            archivos.Backup(Query)
            archivos.Log("[" & DateTime.Now.ToLongTimeString & "] >> " & ex.Message)
            Return Nothing
        End Try
        Return Nothing
    End Function
End Class
