Imports MySql.Data.MySqlClient

Public Class conexionBDVideo
    Dim cadena As String = "DATABASE=fotoEstudio;DATASOURCE=localhost;USERID=root;PWD=sistemas"
    Dim conexion As New MySqlConnection(cadena)
    Public Function ActualizarVideo(idServicioVideo As Integer, evento As String, locacion As String,
                                    duracion As Integer, formatoEntega As String, copias As Integer,
                                    costo As Integer, fechaHora As String, fechaEntrega As String, detalles As String) As Integer
        Dim comando As New MySqlCommand(
           "UPDATE servicioVideo SET" &
           " evento   = '" & evento &
           "', locacion  = '" & locacion &
           "', duracion = '" & duracion &
           "', formatoEntrega  ='" & formatoEntega &
           "', copias  = " & copias &
           ", costo  =" & costo &
           ", fechaHoraEvento = '" & fechaHora &
           "', fechaEntrega  ='" & fechaEntrega &
           "', detalles  ='" & detalles &
           "' WHERE idServicioVideo = " & idServicioVideo, conexion)
        Dim resultado As Integer = -1
        Try
            conexion.Open()
            resultado = comando.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            MsgBox("ERROR " & ex.Message)
            conexion.Close()
            Return -1
        End Try
        Return resultado
    End Function

    Public Function ObtenerVideo(idVideo As String) As DataSet
        Dim consulta As New MySqlDataAdapter(
           "SELECT * FROM servicioVideo WHERE idServicioVideo = " & idVideo, conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function
    Public Function AgregarVideo(idTicket As Integer, evento As String, locacion As String,
                                    duracion As Integer, formatoEntega As String, copias As Integer,
                                    costo As Integer, fechaHoraEvento As String, fechaEntrega As String, detalles As String) As Integer
        Dim comando As New MySqlCommand(
           "INSERT INTO serviciovideo VALUES(NULL, '" & idTicket & "', '" & evento &
           "', '" & locacion & "', '" & duracion & "', '" & formatoEntega & "', '" & copias & "','" & costo & "',
           '" & fechaHoraEvento & "', '" & fechaEntrega & "', '" & detalles & "')", conexion)

        Dim resultado As Integer = -1
        Try
            conexion.Open()
            resultado = comando.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            MsgBox("ERROR " & ex.Message)
            conexion.Close()
            Return -1
        End Try
        Return resultado

    End Function
End Class
