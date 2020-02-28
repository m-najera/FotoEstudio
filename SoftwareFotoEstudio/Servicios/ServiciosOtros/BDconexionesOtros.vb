Imports MySql.Data.MySqlClient

Public Class BDconexionesOtros

    Dim cadena As String = "DATABASE=fotoEstudio;DATASOURCE=localhost;USERID=root;PWD=sistemas"
    Dim conexion As New MySqlConnection(cadena)

    Public Function buscarInvitacion(texto As String) As DataSet
        Dim consulta As New MySqlDataAdapter(
            "SELECT * FROM servicioOtrosInvitaciones WHERE idServicioOtrosInvitaciones LIKE '%" & texto & "%'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function buscarEdicion(texto As String) As DataSet
        Dim consulta As New MySqlDataAdapter(
            "SELECT idServicioOtrosEdicion AS ID, detalles AS DETALLES FROM servicioOtrosEdicion WHERE idServicioOtrosEdicion LIKE '%" & texto &
            "%' OR detalles LIKE '%" & texto & "%'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function obtenerEdicion(idEdicion As String) As DataSet
        Dim consulta As New MySqlDataAdapter(
           "SELECT * FROM servicioOtrosEdicion WHERE idServicioOtrosEdicion = '" & idEdicion & "'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function agregarEdicion(idTicket As Integer, detalles As String, fechaEntrega As String, tamanio As String, costo As Integer) As Integer
        Dim comando As New MySqlCommand(
           "INSERT INTO servicioOtrosEdicion VALUES(null," & idTicket & ",'" & detalles & "', '" & fechaEntrega &
           "', '" & tamanio & "', '" & costo & "')", conexion)
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
    Public Function eliminarEdicion(idEdicion As String) As Integer
        Dim comando As New MySqlCommand(
           "DELETE FROM servicioOtrosEdicion WHERE idServicioOtrosEdicion = " & idEdicion, conexion)
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
    Public Function actualizarEdicion(idEdicion As String, detalles As String, fecha As String, tamanio As String, costo As String) As Integer
        Dim comando As New MySqlCommand(
           "UPDATE servicioOtrosEdicion SET" &
           " detalles= '" & detalles &
           "', fechaEntrega= '" & fecha &
           "', tamanio= '" & tamanio &
           "', costo= '" & costo &
           "' WHERE idServicioOtrosEdicion = " & idEdicion, conexion)
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

    Public Function obtenerInvitacion(idinvitacion As String) As DataSet
        Dim consulta As New MySqlDataAdapter(
           "SELECT * FROM servicioOtrosInvitaciones WHERE idServicioOtrosInvitaciones = '" & idinvitacion & "'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function agregarInvitacion(idTicket As Integer, detalles As String, papel As String, cantidad As Integer, costo As Integer) As Integer
        Dim comando As New MySqlCommand(
           "INSERT INTO servicioOtrosInvitaciones VALUES(NULL," & idTicket & ", '" & detalles & "','" & papel & "', " & cantidad &
           ", " & costo & ")", conexion)
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
    Public Function eliminarInvitacion(idInvitacion As String) As Integer
        Dim comando As New MySqlCommand(
           "DELETE FROM servicioOtrosInvitaciones WHERE idServicioOtrosInvitaciones = " & idInvitacion, conexion)
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
    Public Function actualizarInvitacion(idInvitacion As String, detalles As String, papel As String, cantidad As String, costo As String) As Integer
        Dim comando As New MySqlCommand(
           "UPDATE servicioOtrosInvitaciones SET" &
           " detalles= '" & detalles &
           "', papel= '" & papel &
           "', cantidad= '" & cantidad &
           "', costo= '" & costo &
           "' WHERE idServicioOtrosInvitaciones = " & idInvitacion, conexion)
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

    Public Function agregarImpresion(idTicket As Integer, tamanio As String, detalles As String, fechaEntrega As String, papel As String, costo As Integer) As Integer
        Dim comando As New MySqlCommand(
           "INSERT INTO servicioOtrosImpresion VALUES(NULL," & idTicket & ", '" & tamanio & "','" &
           detalles & "','" & fechaEntrega & "', '" &
           papel & "'," & costo & ")", conexion)
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

    Public Function obtenerImpresion(idImpresion As String) As DataSet
        Dim consulta As New MySqlDataAdapter(
           "SELECT * FROM servicioOtrosImpresion WHERE idServicioOtrosImpresion = '" & idImpresion & "'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function
    Public Function eliminarImpresion(idImpresion As String) As Integer
        Dim comando As New MySqlCommand(
           "DELETE FROM servicioOtrosImpresion WHERE idServicioOtrosImpresion = " & idImpresion, conexion)
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
    Public Function actualizarImpresion(idImpresion As String, tamanio As String, detalles As String, fecha As String, papel As String, costo As String) As Integer
        Dim comando As New MySqlCommand(
           "UPDATE servicioOtrosImpresion SET" &
           " tamanio= '" & tamanio &
           "', detalles= '" & detalles &
           "', fechaEntrega= '" & fecha &
           "', papel= '" & papel &
           "', costo= '" & costo &
           "' WHERE idServicioOtrosImpresion = " & idImpresion, conexion)
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

    Public Function agregarAlbum(idTicket As Integer, detalles As String, cantidadFotos As Integer, disenio As String, costo As Integer) As Integer
        Dim comando As New MySqlCommand(
           "INSERT INTO servicioOtrosAlbum VALUES(NULL," & idTicket & ", '" & detalles & "','" & cantidadFotos & "', '" & disenio &
           "','" & costo & "')", conexion)
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
    Public Function buscarAlbum(texto As String) As DataSet
        Dim consulta As New MySqlDataAdapter(
            "SELECT * FROM servicioOtrosAlbum WHERE idServicioOtrosAlbum LIKE '%" & texto & "%'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function
    Public Function obtenerDetallesAlbum(idAlbum As String) As DataSet
        Dim consulta As New MySqlDataAdapter(
           "SELECT * FROM servicioOtrosAlbum WHERE idServicioOtrosAlbum = '" & idAlbum & "'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function
    Public Function eliminarAlbum(idAlbum As String) As Integer
        Dim comando As New MySqlCommand(
           "DELETE FROM servicioOtrosAlbum WHERE idServicioOtrosAlbum = " & idAlbum, conexion)
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
    Public Function actualizarAlbum(idAlbum As String, detalles As String, cantidad As String, disenio As String, costo As String) As Integer
        Dim comando As New MySqlCommand(
           "UPDATE servicioOtrosAlbum SET" &
           " detalles= '" & detalles &
           "', cantidadFotos= '" & cantidad &
           "', disenio= '" & disenio &
           "', costo= '" & costo &
           "' WHERE idServicioOtrosAlbum = " & idAlbum, conexion)
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

    Public Function obtenerDetallesInvitacion(idInvitacion As String) As DataSet
        Dim consulta As New MySqlDataAdapter(
           "SELECT * FROM servicioOtrosInvitaciones WHERE idServicioOtrosInvitaciones = '" & idInvitacion & "'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function obtenerDetallesEdicion(idEdicion As String) As DataSet
        Dim consulta As New MySqlDataAdapter(
           "SELECT * FROM servicioOtrosEdicion WHERE idServicioOtrosEdicion = '" & idEdicion & "'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function obtenerDetallesImpresion(idImpresion As String) As DataSet
        Dim consulta As New MySqlDataAdapter(
           "SELECT * FROM servicioOtrosImpresion WHERE idServicioOtrosImpresion = '" & idImpresion & "'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function
End Class
