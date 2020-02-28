Public Class ServicioBuscarTicket
    Private conexiones As New BDConexiones
    Dim openEditTicket As EditarTickets
    Dim id As String
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFecha.ValueChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridTickets.CellContentClick

    End Sub

    Private Sub BotonBuscar_Click(sender As Object, e As EventArgs) Handles BotonBuscar.Click
        BuscarTickets()
        DataGridDetalles.DataSource = vbNull
    End Sub




    Sub BuscarTickets()
        Dim consulta As String
        consulta = DateTimePickerFecha.Value.Year.ToString & "-" & DateTimePickerFecha.Value.Month.ToString & "-" & DateTimePickerFecha.Value.Day.ToString
        Try
            Cursor = Cursors.WaitCursor
            Application.DoEvents()
            Dim datos As New DataSet
            datos = conexiones.BuscarTickes(consulta)
            DataGridTickets.DataSource = datos.Tables(0)
            DataGridTickets.Columns(0).FillWeight = 300
            DataGridTickets.Refresh()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox("Error " & ex.Message)
        End Try
    End Sub

    Sub BotonDetalles_Click(sender As Object, e As EventArgs) Handles BotonDetalles.Click
        If DataGridTickets.SelectedRows.Count > 0 Then
            Try
                Dim idTicket As String = DataGridTickets.CurrentRow.Cells(0).Value.ToString
                id = idTicket
                ListarServicios(id)
            Catch ex As Exception
                Cursor = Cursors.Default
                MsgBox("Error " & ex.Message)
            End Try

        End If
        CargarDetallesLabels()
    End Sub

    Public Sub ListarServicios(idTicket As String)
        Cursor = Cursors.WaitCursor
        Application.DoEvents()
        Dim datosVideo As New DataSet
        datosVideo = conexiones.DetallesTicketsVideo(idTicket)
        datosVideo = AgregarFilas(datosVideo, conexiones.DetallesTicketsFoto(idTicket))
        datosVideo = AgregarFilas(datosVideo, conexiones.DetallesTicketsOtrosAlbum(idTicket))
        datosVideo = AgregarFilas(datosVideo, conexiones.DetallesTicketsOtrosEdicion(idTicket))
        datosVideo = AgregarFilas(datosVideo, conexiones.DetallesTicketsOtrosImpresion(idTicket))
        datosVideo = AgregarFilas(datosVideo, conexiones.DetallesTicketsOtrosInvitaciones(idTicket))
        DataGridDetalles.DataSource = datosVideo.Tables(0)
        DataGridDetalles.Refresh()
        Cursor = Cursors.Default
    End Sub

    Public Sub ListarServicios()
        ListarServicios(id)
        DataGridDetalles.Refresh()
    End Sub

    Private Function AgregarFilas(resultado As DataSet, data As DataSet) As DataSet
        Dim i As Integer
        Dim j As Integer
        For i = 0 To data.Tables(0).Rows.Count - 1
            Dim newRows As DataRow = resultado.Tables(0).NewRow()
            For j = 0 To data.Tables(0).Columns.Count - 1
                newRows(j) = data.Tables(0).Rows(i).Item(j)
            Next j
            resultado.Tables(0).Rows.Add(newRows)
        Next i
        Return resultado
    End Function

    Private Sub CargarDetallesLabels()
        Try
            Dim ID_Cliente As String = Convert.ToString(DataGridTickets.CurrentRow.Cells(1).Value)
            Dim ConsultaCliente As String
            ConsultaCliente = ID_Cliente
            Application.DoEvents()
            Dim NombreCliente As New DataSet
            NombreCliente = conexiones.NombreCliente(ConsultaCliente)
            LabelNombreCliente.Text = "Nombre: " + NombreCliente.Tables(0).Rows(0).Item(1).ToString
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox("Error " & ex.Message)
        End Try

        Try
            LabelEvento.Text = "Evento: " & DataGridTickets.SelectedRows.Item(0).Cells(2).Value
            LabelLugarEvento.Text = "Lugar: " & DataGridTickets.SelectedRows.Item(0).Cells(3).Value
            LabelFechaContratacion.Text = "Fecha de contratacion: " & DataGridTickets.SelectedRows.Item(0).Cells(4).Value
            LabelFechaEntrega.Text = "Fecha de entrega: " & DataGridTickets.SelectedRows.Item(0).Cells(5).Value
            LabelEvento.Text = "Fecha del evento: " & DataGridTickets.SelectedRows.Item(0).Cells(6).Value
            LabelTotal.Text = "Total: " & DataGridTickets.SelectedRows.Item(0).Cells(7).Value
            LabelAdeudo.Text = "Adeudo: " & DataGridTickets.SelectedRows.Item(0).Cells(8).Value
            LabelFechaPagoSig.Text = "Fecha del pago siguiente: " & DataGridTickets.SelectedRows.Item(0).Cells(9).Value
            LabelEstadoServ.Text = "Estado del servicio: " & DataGridTickets.SelectedRows.Item(0).Cells(10).Value

        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox("Error " & ex.Message)
        End Try
    End Sub

    Private Sub ButtonEditTickets_Click(sender As Object, e As EventArgs) Handles ButtonEditTickets.Click
        abrirEditarTickets()
    End Sub

    Private Sub abrirEditarTickets()
        If DataGridTickets.CurrentRow IsNot Nothing Then
            openEditTicket = New EditarTickets(Me)
            openEditTicket.Show()
        Else
            MsgBox("No hay datos seleccionados")
        End If

    End Sub

    Private Sub DataGridTickets_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridTickets.SelectionChanged
        Cursor = Cursors.WaitCursor
        Application.DoEvents()
        LabelEvento.Text = "Evento: "
        LabelLugarEvento.Text = "Lugar: "
        LabelFechaContratacion.Text = "Fecha de contratacion: "
        LabelFechaEntrega.Text = "Fecha de entrega: "
        LabelEvento.Text = "Fecha del evento: "
        LabelTotal.Text = "Total: "
        LabelAdeudo.Text = "Adeudo: "
        LabelFechaPagoSig.Text = "Fecha del pago siguiente: "
        LabelEstadoServ.Text = "Estado del servicio: "
        DataGridDetalles.DataSource = vbNull
        Cursor = Cursors.Default
    End Sub

    Private Sub ButtonServDet_Click(sender As Object, e As EventArgs) Handles ButtonServDet.Click
        If DataGridDetalles.SelectedRows.Count > 0 Then
            Dim servicio As String = DataGridDetalles.SelectedRows(0).Cells(3).Value
            Dim id As String = DataGridDetalles.SelectedRows(0).Cells(1).Value
            If servicio = "FOTO" Then
                Dim w As New Detalles_Fotos(id, Me)
                w.Show()
            ElseIf servicio = "VIDEO" Then
                Dim w As New DetallesVideo(id, Me)
                w.Show()
            ElseIf servicio = "ALBUM" Then
                Dim w As New detallesAlbum(id, Me)
                w.Show()
            ElseIf servicio = "EDICION" Then
                Dim w As New detallesEdicion(id, Me)
                w.Show()
            ElseIf servicio = "IMPRESION" Then
                Dim w As New detallesImpresion(id, Me)
                w.Show()
            ElseIf servicio = "INVITACION" Then
                Dim w As New detallesInvitacion(id, Me)
                w.Show()
            End If
        End If
    End Sub

    Private Sub ButtonServMod_Click(sender As Object, e As EventArgs) Handles ButtonServMod.Click
        If DataGridDetalles.SelectedRows.Count > 0 Then
            Dim servicio As String = DataGridDetalles.SelectedRows(0).Cells(3).Value
            Dim id As String = DataGridDetalles.SelectedRows(0).Cells(1).Value
            If servicio = "FOTO" Then
                Dim w As New Modificar_Fotos(id, Me)
                w.Show()
            ElseIf servicio = "VIDEO" Then
                Dim w As New ModificarVideo(id, Me)
                w.Show()
            ElseIf servicio = "ALBUM" Then
                Dim w As New modificarAlbum(id, Me)
                w.Show()
            ElseIf servicio = "EDICION" Then
                Dim w As New modificarEdicion(id, Me)
                w.Show()
            ElseIf servicio = "IMPRESION" Then
                Dim w As New modificarImpresion(id, Me)
                w.Show()
            ElseIf servicio = "INVITACION" Then
                Dim w As New modificarInvitacion(id, Me)
                w.Show()
            End If
        End If
    End Sub
End Class