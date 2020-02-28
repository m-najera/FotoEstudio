Imports MySql.Data.MySqlClient

Public Class BDConexionesFotos
    Dim cadena As String = "DATABASE=fotoEstudio;DATASOURCE=localhost;USERID=root;PWD=sistemas"
    Dim conexion As New MySqlConnection(cadena)




    Public Function ObtenerFotos(idTicket As String) As DataSet
        Dim consulta As New MySqlDataAdapter(
           "SELECT * FROM servicioFoto WHERE idServicioFoto = '" & idTicket & "'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function



    Friend Function AgregarFotos(idticket As Integer, tamaño As String, cantidad As String, fechaEntrega As String, papel As String, bn As String, costo As String, detalles As String) As Integer
        Dim comando As New MySqlCommand(
           "INSERT INTO servicioFoto VALUES(NULL, '" & idticket & "', '" & tamaño & "', '" & cantidad & "', '" & fechaEntrega & "', '" & papel & "', '" & bn & "','" & costo & "','" & detalles & "')", conexion)
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
    Public Function BuscarServicioFoto(texto As String) As DataSet
        Dim consulta As New MySqlDataAdapter(
            "SELECT idTicket AS IDTic, tamanio AS TAMAÑO, cantidad AS CANTIDAD, fechaEntrega AS FECHAENTREGA, papel AS PAPEL, costo AS COSTO FROM serviciofoto", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function Modificar_fotos(idServicioFoto As String, cantidad As String, fechaEntrega As String, bn As String, costo As String, detalles As String) As Integer
        Dim comando As New MySqlCommand(
           "UPDATE serviciofoto SET " &
           " cantidad=" & cantidad &
           ", fechaEntrega='" & fechaEntrega &
           "', bn='" & bn & "', costo=" & costo &
            ", detalles='" & detalles &
           "' WHERE idServiciofoto=" & idServicioFoto, conexion)

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
