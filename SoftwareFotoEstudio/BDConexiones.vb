Imports MySql.Data.MySqlClient
Public Class BDConexiones
    ' Dim pass As String = ""
    Dim cadena As String = "DATABASE=fotoEstudio;DATASOURCE=localhost;USERID=root;PWD=sistemas"
    Dim conexion As New MySqlConnection(cadena)

    Public Function AutenticarUsuario(usuario As String, contrasena As String) As String
        Try
            Dim consulta As New MySqlDataAdapter("SELECT * FROM usuarios WHERE BINARY nombreUsuario='" & usuario &
                                             "' AND BINARY contrasena='" & contrasena + "'", conexion)
            Dim resultado As New DataSet
            consulta.Fill(resultado)
            If resultado.Tables(0).Rows.Count > 0 Then
                Dim nivel As String
                nivel = resultado.Tables(0).Rows(0).Item(4).ToString
                Return nivel
            End If
        Catch ex As Exception
            MsgBox("ERROR: " + ex.Message.ToString + ex.Source.ToString)
        End Try
        Return ""
    End Function

    Public Function BuscarClientes(texto As String) As DataSet
        Dim consulta As New MySqlDataAdapter(
            "SELECT * FROM clientes WHERE idclientes LIKE '%" & texto &
            "%' OR nombre LIKE '%" & texto & "%'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function
    ' FUNCION PARA BUSCAR CLIENTE EN EL MODULO "servicioAbonos" y MOSTRAR LOS DATOS DEL CLIENTE Y DE LA TABLA "tickets"
    ' AUTOR: Misael Santana Correa    FECHA: 22/11/2018
    Public Function BuscarClientesAbonos(textoNombre As String) As DataSet
        Dim consulta As New MySqlDataAdapter("SELECT c.idclientes, c.nombre, c.apellidos, t.evento, t.lugarEvento, t.fechaContratacion, t.fechaEntrega, t.fechaEvento, t.total, t.adeudo, t.fechaPagoSig, t.estadoServicio, t.idTicket FROM clientes c INNER JOIN tickets t ON c.idclientes=t.idclientes AND c.nombre LIKE '%" & textoNombre & "%'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function BuscarTickes(texto As String) As DataSet
        ' Dim consulta As New MySqlDataAdapter("SELECT * FROM tickets", conexion)
        Dim consulta As New MySqlDataAdapter("SELECT * FROM tickets WHERE fechaContratacion= '" & texto & "'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function DetallesTickets(texto As String) As DataSet
        Dim consulta As New MySqlDataAdapter("SELECT * FROM tickets where idticket= '" & texto & "'", conexion)
        ' Dim consulta As New MySqlDataAdapter("SELECT * FROM tickets WHERE fechaContratacion= '" & texto & "'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function DetallesTicketsVideo(texto As String) As DataSet
        Dim consulta As New MySqlDataAdapter("SELECT v.idTicket AS 'ID TICKET', v.idServicioVideo AS 'ID SERVICIO', v.costo AS 'COSTO', 'VIDEO' AS 'SERVICIO' FROM servicioVideo v JOIN tickets t WHERE v.idTicket = '" & texto & "' and v.idTicket=t.idTicket", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function


    Public Function DetallesTicketsFoto(texto As String) As DataSet
        Dim consulta As New MySqlDataAdapter("SELECT v.idTicket AS 'ID TICKET', v.idServicioFoto AS 'ID SERVICIO', v.costo AS 'COSTO', 'FOTO' AS 'SERVICIO' FROM servicioFoto v JOIN tickets t WHERE v.idTicket = '" & texto & "' and v.idTicket=t.idTicket", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function DetallesTicketsOtrosAlbum(texto As String) As DataSet
        Dim consulta As New MySqlDataAdapter("SELECT v.idTicket AS 'ID TICKET', v.idServicioOtrosAlbum AS 'ID SERVICIO', v.costo AS 'COSTO', 'ALBUM' AS 'SERVICIO' FROM servicioOtrosAlbum v JOIN tickets t WHERE v.idTicket = '" & texto & "' and v.idTicket=t.idTicket", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function DetallesTicketsOtrosImpresion(texto As String) As DataSet
        Dim consulta As New MySqlDataAdapter("SELECT v.idTicket AS 'ID TICKET', v.idServicioOtrosImpresion AS 'ID SERVICIO', v.costo AS 'COSTO', 'IMPRESION' AS 'SERVICIO' FROM servicioOtrosImpresion v JOIN tickets t WHERE v.idTicket = '" & texto & "' and v.idTicket=t.idTicket", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function DetallesTicketsOtrosInvitaciones(texto As String) As DataSet
        Dim consulta As New MySqlDataAdapter("SELECT v.idTicket AS 'ID TICKET', v.idServicioOtrosInvitaciones AS 'ID SERVICIO', v.costo AS 'COSTO', 'INVITACION' AS 'SERVICIO' FROM servicioOtrosInvitaciones v JOIN tickets t WHERE v.idTicket = '" & texto & "' and v.idTicket=t.idTicket", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function DetallesTicketsOtrosEdicion(texto As String) As DataSet
        Dim consulta As New MySqlDataAdapter("SELECT v.idTicket AS 'ID TICKET', v.idServicioOtrosEdicion AS 'ID SERVICIO', v.costo AS 'COSTO', 'EDICION' AS 'SERVICIO' FROM servicioOtrosEdicion v JOIN tickets t WHERE v.idTicket = '" & texto & "' and v.idTicket=t.idTicket", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function NombreCliente(texto As String) As DataSet
        Dim consulta As New MySqlDataAdapter("SELECT c.idClientes AS 'ID', CONCAT(c.nombre,' ',c.apellidos) AS 'Nombre' FROM clientes c WHERE c.idClientes = '" & texto & "'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function


    Public Function BuscarUsuarios(texto As String) As DataSet
        Dim consulta As New MySqlDataAdapter(
            "SELECT idUsuarios AS ID, nombreCompleto AS NOMBRE, nombreUsuario AS USUARIO, " &
            "tipoUsuario AS NIVEL FROM usuarios WHERE idusuarios LIKE '%" & texto &
            "%' OR nombreCompleto LIKE '%" & texto & "%'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function ObtenerUsuario(idUsuario As String) As DataSet
        Dim consulta As New MySqlDataAdapter(
           "SELECT * FROM usuarios WHERE idUsuarios = '" & idUsuario & "'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function AgregarUsuario(nombreCompleto As String, usuario As String, contrasena As String, tipoUsuario As String, preguntaSeguridad As String, respuestaSeguridad As String) As Integer
        Dim comando As New MySqlCommand(
           "INSERT INTO usuarios VALUES(NULL, '" & nombreCompleto & "', '" & usuario &
           "', '" & contrasena & "', '" & tipoUsuario & "', '" & preguntaSeguridad & "', '" & respuestaSeguridad & "')", conexion)
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

    Public Function ObtenerCliente(idCliente As String) As DataSet
        Dim consulta As New MySqlDataAdapter(
           "SELECT * FROM clientes WHERE idclientes = '" & idCliente & "'", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos
    End Function

    Public Function AgregarCliente(nombreCliente As String, apellidosCliente As String, domicilioCliente As String, telefonoCliente As String, correoCliente As String) As Integer
        Dim comando As New MySqlCommand(
           "INSERT INTO clientes VALUES(NULL, '" & nombreCliente & "','" & apellidosCliente & "','" & domicilioCliente & "', '" & telefonoCliente & "','" & correoCliente & "')", conexion)
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

    Public Function EliminarUsuario(idUsuario As String) As Integer
        Dim comando As New MySqlCommand(
           "DELETE FROM usuarios WHERE idUsuarios = " & idUsuario, conexion)
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

    Public Function EliminarCliente(idCliente As String) As Integer
        Dim comando As New MySqlCommand(
           "DELETE FROM clientes WHERE idClientes = " & idCliente, conexion)
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

    Public Function ActualizarUsuario(idUsuario As String, nombreCompleto As String, usuario As String, contrasena As String, tipoUsuario As String, preguntaSeguridad As String, respuestaSeguridad As String) As Integer
        Dim comando As New MySqlCommand(
           "UPDATE usuarios SET" &
           " nombreCompleto= '" & nombreCompleto &
           "', nombreUsuario= '" & usuario &
           "', contrasena= '" & contrasena &
           "', tipoUsuario= '" & tipoUsuario &
           "', preguntaSeguridad=" & preguntaSeguridad &
           ", respuestaSeguridad= '" & respuestaSeguridad &
           "' WHERE idUsuarios = " & idUsuario, conexion)
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

    Public Function ActualizarUsuarioContrasena(idUsuario As String, contrasena As String) As Integer
        Dim comando As New MySqlCommand(
           "UPDATE usuarios SET" &
           " contrasena= '" & contrasena &
           "' WHERE idUsuarios = " & idUsuario, conexion)
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

    Public Function ActualizarCliente(idCliente As String, nombreCliente As String, apellidosCliente As String, domicilioCliente As String, telefonoCliente As String, correoCliente As String) As Integer
        Dim comando As New MySqlCommand(
           "UPDATE clientes SET" &
           " nombre= '" & nombreCliente &
           "', apellidos= '" & apellidosCliente &
           "', domicilio= '" & domicilioCliente &
           "', telefono= '" & telefonoCliente &
           "', correo= '" & correoCliente &
           "' WHERE idclientes = " & idCliente, conexion)
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

    Public Function CargarIDTicket() As Integer
        Dim consulta As New MySqlDataAdapter(
          "SELECT MAX(idTicket) FROM tickets", conexion)
        Dim datos As New DataSet
        consulta.Fill(datos)
        Return datos.Tables(0).Rows(0).Item(0).ToString

    End Function

    Public Function InsertarTicket(idCliente As String, evento As String, lugarEvento As String, fechaContratacion As String, fechaEntrega As String, fechaEvento As String, total As String, adeudo As String, fechaPago As String, estadoServicio As String) As Integer
        Dim comando As New MySqlCommand(
           "INSERT INTO tickets VALUES(NULL, '" & idCliente & "', '" & evento & "', '" & lugarEvento & "', '" & fechaContratacion & "', '" &
           fechaEntrega & "', '" & fechaEvento & "', '" & total & "', '" & adeudo & "', '" & fechaPago & "', '" & estadoServicio & "')", conexion)
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

    ' FUNCION PARA EDITAR LA TABLA "tickets" DESDE EL MODULO "EditarTickets"
    ' ' AUTOR: Misael Santana Correa    FECHA: 20/11/2018
    Public Function actualizarTicket(evento As String, lugar As String, fechaEnt As String, fechaEven As String, total As String, adeudo As String, pagoSig As String, estadoServ As String, clienteId As String, ticketID As String) As String
        Dim resultado As String = ""
        Try
            conexion.Open()
            Dim updateTickets As New MySqlCommand("UPDATE tickets SET evento='" & evento & "', lugarEvento='" & lugar & "', fechaEntrega='" & fechaEnt & "', fechaEvento='" & fechaEven & "', total='" & total & "', adeudo='" & adeudo & "', fechaPagoSig='" & pagoSig & "', estadoServicio='" & estadoServ & "' WHERE idTicket=" & ticketID, conexion)
            updateTickets.ExecuteNonQuery()
            MsgBox("Ticket Actualizado!!")
            conexion.Close()
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
            conexion.Close()
            Return ""
        End Try
        Return resultado
    End Function
    ' FUNCION PARA ACTUALIZAR LOS CAMPOS "adeudo" Y "fechaPagoSig"  DE LA TABLA "tickets" E INSERTAR LOS DATOS EN LA TABLA "abonos"
    ' AUTOR: Misael Santana Correa    FECHA: 21/11/2018
    Public Sub operacionesAbonos(clienteId As String, ticketID As String, cntRestante As String, pagoSig As String, montoAbono As String)
        conexion.Open()
        Try
            'Dim cnslt As New MySqlCommand("SELECT idTicket FROM tickets WHERE idClientes = " & clienteId, conexion)
            'ticketID = cnslt.ExecuteScalar
            ' ACTUALIZAR LOS CAMPOS "adeudo" Y "fechaPagoSig" DE LA TABLA "tickets"
            Dim updateAdeudo As New MySqlCommand("UPDATE tickets SET adeudo=" & cntRestante & " WHERE idTicket=" & ticketID, conexion)
            updateAdeudo.ExecuteNonQuery()
            Dim updateFecha As New MySqlCommand("UPDATE tickets SET fechaPagoSig='" & pagoSig & "' WHERE idTicket=" & ticketID, conexion)
            updateFecha.ExecuteNonQuery()

            ' INSERTAR EN LA TABLA "abonos"
            Dim fechaAbono As String = Format(Now, "yyyy/MM/dd")
            Dim insertaAbono As New MySqlCommand("INSERT INTO abonos(idTicket, fechaAbono, monto) VALUES (" & ticketID & ",'" & fechaAbono & "'," & montoAbono & ")", conexion)
            insertaAbono.ExecuteNonQuery()
            MsgBox("Abono registrado!!")
            conexion.Close()
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    ' FUNCIONE PARA CONSULTAR LOS DATOS DE LA TABLA "abonos"
    ' AUTOR: Misael Santana Correa    FECHA: 25/11/2018
    Public Function ConsultaAbonos(buscarIdTicket As String) As DataSet
        Dim datos As DataSet
        Try
            conexion.Open()
            Dim consulta As New MySqlDataAdapter("SELECT * FROM abonos WHERE idTicket=" & buscarIdTicket, conexion)
            datos = New DataSet
            consulta.Fill(datos)
            conexion.Close()
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
        Return datos
    End Function
    ' FUNCION PARA BUSCAR EL ID DEL TICKET POR MEDIO DE LOS DATOS DE "nombre" Y "apellido"
    ' AUTOR: Misael Santana Correa    FECHA: 25/11/2018
    Public Function ConsultaAbonosNombre(nombre As String, apellidos As String) As String
        Dim idTickets As String
        Try
            conexion.Open()
            Dim cmdTicketid As New MySqlCommand("SELECT idTicket FROM tickets t INNER JOIN clientes c ON t.idClientes=c.idclientes AND c.nombre='" & nombre & "' AND c.apellidos='" & apellidos & "'", conexion)
            idTickets = cmdTicketid.ExecuteScalar
            conexion.Close()
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
        Return idTickets
    End Function

    Public Function ValidarPregunta(nombreUsuario As String, preguntaSeguridad As Integer, respuestaSeguridad As String) As Integer
        Dim consulta As New MySqlDataAdapter(
           "SELECT idUsuarios FROM usuarios WHERE" &
           " nombreUsuario= '" & nombreUsuario &
           "' AND preguntaSeguridad=" & preguntaSeguridad &
           " AND respuestaSeguridad= '" & respuestaSeguridad &
           "'", conexion)
        Dim resultado As Integer = -1
        Dim datos As New DataSet
        Dim id As String
        consulta.Fill(datos)

        If datos.Tables(0).Rows.Count < 1 Then
            Return -1
        End If
        id = datos.Tables(0).Rows(0).Item(0)
        resultado = Integer.Parse(id)
        Return resultado
    End Function

    Public Function CrearRespaldo(path As String) As Boolean
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            cmd.Connection = conexion
            conexion.Open()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(path)
            conexion.Close()
        Catch e As Exception
            Return False
        End Try

        Return True
    End Function

    Public Function CargarRespaldo(path As String) As Boolean
        Try
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = conexion
            conexion.Open()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ImportFromFile(path)
            conexion.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
