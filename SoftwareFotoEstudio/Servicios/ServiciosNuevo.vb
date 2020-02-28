Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop.Excel
Imports System.Data
Imports Microsoft.Office.Interop

Public Class ServiciosNuevo

    Private idCliente As String = ""
    Dim conexion As New BDConexiones
    Dim clienteS As New ClienteServicio(Me)
    Dim videoA As New AgregarVideo(Me)
    Dim videoM As ModificarVideo()
    Dim fotosA As New Agregar_Fotos(Me)
    Dim fotosM As Modificar_Fotos
    Dim impresionA As New agregarImpresion2(Me)
    Dim impresionM As modificarImpresion()
    Dim edicionA As New agregarEdicion2(Me)
    Dim edicionM As modificarEdicion()
    Dim albumA As New agregarAlbum2(Me)
    Dim albumM As modificarAlbum()
    Dim invitacionA As New agregarInvitaciones2(Me)
    Dim invitacionM As modificarInvitacion()
    Dim conexionFoto As New BDConexionesFotos
    Dim conexionOtros As New BDconexionesOtros
    Dim conexionVideo As New conexionBDVideo
    Dim idTicket As Integer
    Dim ev As String
    Dim descripcionEvento As String
    Dim fechaEvento, fechaEntrega, fechaContratacion As String
    Dim lugarEvento As String
    Dim total As Integer = 0
    Dim anticipo As Integer = 0
    Dim adeudo As Integer = 0
    Dim segundoPago As String
    Dim estadoServicio As String
    Dim fecha As String
    Dim ct As String

    Dim arregloFotos As New List(Of Foto)
    Dim arregloVideo As New List(Of Video)
    Dim arregloImpresion As New ArrayList()
    Dim arregloEdicion As New ArrayList()
    Dim arregloAlbum As New ArrayList()
    Dim arregloInvitacion As New ArrayList()
    Public Property ActiveSheet As Object

    Private Sub ServiciosNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Al iniciar la ventana, inicializar los datepicker en la fecha del dia de hoy
        DateTimePickerFechaEvento.Value = DateTime.Now.Date
        DateTimePickerEntrega.Value = DateTime.Now.Date
        DateTimePickerSegundo.Value = DateTime.Now.Date

    End Sub

    Private Sub TextBoxAbono_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        If idCliente = "" Then
            MsgBox("Debe seleccionar un cliente", MsgBoxStyle.Exclamation)
            Return
        End If
        fechaEvento = Format(DateTimePickerFechaEvento.Value.Date, "yyyy/MM/dd")
        fechaEntrega = Format(DateTimePickerEntrega.Value.Date, "yyyy/MM/dd")
        segundoPago = Format(DateTimePickerSegundo.Value.Date, "yyyy/MM/dd")
        fechaContratacion = Format(DateTime.Now.Date, "yyyy/MM/dd")

        descripcionEvento = TextBoxDesc.Text.ToString
        lugarEvento = TextBoxLugar.Text.ToString
        total = LabelTotal.Text.ToString
        anticipo = TextBoxAnticipo.Text.ToString
        adeudo = LabelAdeudo.Text.ToString
        If CheckBoxEvento.Checked = True Then
            ev = "Evento"
        Else
            ev = "N/A"
        End If

        If CheckBoxCotizacion.Checked = True Then
            ct = "Cotizacion"

        Else
            ct = "Contratado"

        End If

        Dim resultado As Integer
        resultado = conexion.InsertarTicket(idCliente, ev, lugarEvento, fechaContratacion, fechaEntrega, fechaEvento, total, adeudo, segundoPago, ct)

        If resultado <> -1 Then
            idTicket = conexion.CargarIDTicket()
            InsercionDatos()
            MsgBox("Reporte Guardado", MsgBoxStyle.OkOnly)
            ButtonImprimir.Enabled = True
            ButtonGuardar.Enabled = False

        End If


    End Sub

    Private Sub InsercionDatos()

        For Each foto As Foto In arregloFotos
            conexionFoto.AgregarFotos(idTicket, foto.tamanio, foto.cantidad, foto.fechaEntrega, foto.papel, foto.bn, foto.costo, foto.detalles)
        Next

        For Each video As Video In arregloVideo
            conexionVideo.AgregarVideo(idTicket, video.evento, video.locacion, video.duracion, video.formatoEntrega,
                                       video.copias, video.costo, video.fechaHoraEvento, video.fechaEntrega, video.detalles)
        Next

        For Each impresion As Impresion In arregloImpresion
            conexionOtros.agregarImpresion(idTicket, impresion.tamanio, impresion.detalles, impresion.fechaEntrega,
                                          impresion.papel, impresion.costo)
        Next

        For Each edicion As Edicion In arregloEdicion
            conexionOtros.agregarEdicion(idTicket, edicion.detalles, edicion.fechaEntrega, edicion.tamanio, edicion.costo)
        Next

        For Each album As Album In arregloAlbum
            conexionOtros.agregarAlbum(idTicket, album.detalles, album.cantidad, album.diseno, album.costo)
        Next

        For Each invitacion As Invitacion In arregloInvitacion
            conexionOtros.agregarInvitacion(idTicket, invitacion.detalles, invitacion.papel, invitacion.cantidad, invitacion.costo)
        Next


    End Sub

    Public Sub New(idcliente As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.idCliente = idcliente
    End Sub

    Private Sub ButtonBuscarCliente_Click(sender As Object, e As EventArgs) Handles ButtonBuscarCliente.Click

        If clienteS.IsDisposed Then
            clienteS = New ClienteServicio(Me)
        End If
        clienteS.Show()
        clienteS.Focus()

    End Sub

    Public Sub ActualizarCliente(idC As String, nomC As String)
        idCliente = idC
        TextBoxCliente.Text = nomC
    End Sub

    Private Sub ButtonImprimir_Click(sender As Object, e As EventArgs) Handles ButtonImprimir.Click
        fechaEvento = Format(DateTimePickerFechaEvento.Value.Date, "yyyy/MM/dd")
        fechaEntrega = Format(DateTimePickerEntrega.Value.Date, "yyyy/MM/dd")
        segundoPago = Format(DateTimePickerSegundo.Value.Date, "yyyy/MM/dd")
        fecha = Format(DateTime.Now.Date, "yyyy/MM/dd")

        Dim Ticket As New DataSet

        Dim fileSaver As New SaveFileDialog()
        fileSaver.Filter = "Archivo Excel|*.xls"
        fileSaver.Title = "Guardar Reporte"
        fileSaver.InitialDirectory = Environment.SpecialFolder.Desktop
        fileSaver.FileName = "Reporte_" & Format(DateTime.Now.Date)
        fileSaver.OverwritePrompt = False

        If fileSaver.ShowDialog = DialogResult.OK And fileSaver.FileName <> "" Then ''Si se confirma la ubicacion de almacenamiento, se genera el archivo de Excel
            'Inicializar referencias a objetos
            Dim appXL As Excel.Application = New Excel.Application()
            Dim wbXl As Excel.Workbook
            Dim shXL As Excel.Worksheet
            Dim raXL As Excel.Range
            Dim totalReporte As Decimal = 0


            ' Crear un nuevo workbook.
            wbXl = appXL.Workbooks.Add

            shXL = wbXl.ActiveSheet

            ' Agregando las cabeceras de la tabla
            'shXL.Cells(1, 1).Value = ActiveSheet.Pictures.Insert("logo.png").Select
            shXL.Cells(2, 1).Value = "Direccion"
            shXL.Cells(2, 2).Value = My.Settings.dir
            shXL.Cells(3, 1).Value = "ID Ticket"
            shXL.Cells(3, 2).Value = idTicket
            shXL.Cells(4, 1).Value = "Nombre del cliente"
            shXL.Cells(4, 2).Value = TextBoxCliente.Text.ToString
            shXL.Cells(5, 1).Value = "Fecha"
            shXL.Cells(5, 2).Value = Format(DateTime.Now.Date)
            shXL.Cells(6, 1).Value = "Adeudo"
            shXL.Cells(6, 2).Value = LabelAdeudo.Text.ToString
            shXL.Cells(7, 1).Value = "Abono"
            shXL.Cells(7, 2).Value = TextBoxAnticipo.Text.ToString
            shXL.Cells(8, 1).Value = "Restante a pagar"
            shXL.Cells(8, 2).Value = LabelTotal.Text.ToString
            shXL.Cells(9, 1).Value = "Fecha de pago siguente"
            shXL.Cells(9, 2).Value = DateTimePickerSegundo.Text.ToString


            ' Dar formato a las celdas de cabecera. Negritas, centradas y con bordes
            With shXL.Range("A1", "G1")
                .Font.Bold = True
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .Borders.Value = True
            End With

            ' AutoFit columnas A:G.
            raXL = shXL.Range("A1", "B1")
            raXL.EntireColumn.AutoFit()
            ' Guardar el archivo en el directorio seleccionado
            wbXl.SaveAs(fileSaver.FileName, Excel.XlFileFormat.xlWorkbookNormal,,,,, Excel.XlSaveAsAccessMode.xlExclusive,,,,,)
            ' Limpiar referencias a los objetos
            raXL = Nothing
            shXL = Nothing
            wbXl = Nothing
            appXL.Quit()
            appXL = Nothing
            MsgBox("Reporte Guardado", MsgBoxStyle.OkOnly)
            Me.Close()
        End If

    End Sub

    Public Sub agregarFoto(f As Foto)
        arregloFotos.Add(f)
        cargarListas()
    End Sub

    Public Sub ModificarFoto(f As Foto)
        Dim id As Integer = f.idDataGrid
        Dim i As Integer = 0
        While i < arregloFotos.Count
            Dim foto As Foto
            foto = arregloFotos.Item(i)
            If foto.idDataGrid = id Then
                arregloFotos.RemoveAt(i)
                arregloFotos.Insert(i, f)
                cargarListas()
                Return
            End If
            i = i + 1
        End While
    End Sub

    Public Sub agregarVideo(v As Video)
        arregloVideo.Add(v)
        cargarListas()
    End Sub

    Public Sub ModificarVideo(v As Video)
        Dim id As Integer = v.idDataGrid
        Dim i As Integer = 0
        While i < arregloVideo.Count
            Dim video As Video
            video = arregloVideo.Item(i)
            If video.idDataGrid = id Then
                arregloVideo.RemoveAt(i)
                arregloVideo.Insert(i, v)
                cargarListas()
                Return
            End If
            i = i + 1
        End While
    End Sub

    Public Sub ModificarImpresion(i As Impresion)
        Dim id As Integer = i.idDataGrid
        Dim x As Integer = 0
        While x < arregloImpresion.Count
            Dim impresion As Impresion
            impresion = arregloImpresion.Item(x)
            If impresion.idDataGrid = id Then
                arregloImpresion.RemoveAt(x)
                arregloImpresion.Insert(x, i)
                cargarListas()
                Return
            End If
            x = x + 1
        End While
    End Sub

    Public Sub ModificarEdicion(e As Edicion)
        Dim id As Integer = e.idDataGrid
        Dim x As Integer = 0
        While x < arregloEdicion.Count
            Dim edicion As Edicion
            edicion = arregloEdicion.Item(x)
            If edicion.idDataGrid = id Then
                arregloEdicion.RemoveAt(x)
                arregloEdicion.Insert(x, e)
                cargarListas()
                Return
            End If
            x = x + 1
        End While
    End Sub

    Public Sub ModificarAlbum(a As Album)
        Dim id As Integer = a.idDataGrid
        Dim x As Integer = 0
        While x < arregloAlbum.Count
            Dim album As Album
            album = arregloAlbum.Item(x)
            If album.idDataGrid = id Then
                arregloAlbum.RemoveAt(x)
                arregloAlbum.Insert(x, a)
                cargarListas()
                Return
            End If
            x = x + 1
        End While
    End Sub

    Public Sub ModificarInvitacion(i As Invitacion)
        Dim id As Integer = i.idDataGrid
        Dim x As Integer = 0
        While x < arregloInvitacion.Count
            Dim invitacion As Invitacion
            invitacion = arregloInvitacion.Item(x)
            If invitacion.idDataGrid = id Then
                arregloInvitacion.RemoveAt(x)
                arregloInvitacion.Insert(x, i)
                cargarListas()
                Return
            End If
            x = x + 1
        End While
    End Sub


    Private Sub ButtonAFoto_Click(sender As Object, e As EventArgs) Handles ButtonAFoto.Click
        If fotosA.IsDisposed Then
            fotosA = New Agregar_Fotos(Me)
        End If
        fotosA.Show()
    End Sub

    Public Sub agregarImpresion(i As Impresion)
        arregloImpresion.Add(i)
        cargarListas()
    End Sub

    Private Sub ButtonAImpresion_Click(sender As Object, e As EventArgs) Handles ButtonAImpresion.Click
        If impresionA.IsDisposed Then
            impresionA = New agregarImpresion2(Me)
        End If
        impresionA.Show()
    End Sub

    Public Sub agregarEdicion(e As Edicion)
        arregloEdicion.Add(e)
        cargarListas()
    End Sub

    Private Sub ButtonAEdicion_Click(sender As Object, e As EventArgs) Handles ButtonAEdicion.Click
        If edicionA.IsDisposed Then
            edicionA = New agregarEdicion2(Me)
        End If
        edicionA.Show()
    End Sub

    Public Sub agregarAlbum(a As Album)
        arregloAlbum.Add(a)
        cargarListas()
    End Sub

    Private Sub ButtonAAlbum_Click(sender As Object, e As EventArgs) Handles ButtonAAlbum.Click
        If albumA.IsDisposed Then
            albumA = New agregarAlbum2(Me)
        End If
        albumA.Show()
    End Sub

    Public Sub agregarInvitacion(i As Invitacion)
        arregloInvitacion.Add(i)
        cargarListas()
    End Sub

    Private Sub ButtonAInvitaciones_Click(sender As Object, e As EventArgs) Handles ButtonAInvitaciones.Click
        If invitacionA.IsDisposed Then
            invitacionA = New agregarInvitaciones2(Me)
        End If
        invitacionA.Show()
    End Sub



    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If DataGridView1.Rows.Count < 1 Then
            Return
        End If
        Dim tipo As String = DataGridView1.SelectedRows.Item(0).Cells(0).Value.ToString
        Dim id As Integer
        If tipo = "FOTO" Then
            id = DataGridView1.SelectedRows.Item(0).Cells(3).Value.ToString
            For Each foto As Foto In arregloFotos
                If id = foto.idDataGrid Then
                    arregloFotos.Remove(foto)
                    cargarListas()
                    Return
                End If
            Next
        End If

        If tipo = "IMPRESION" Then
            id = DataGridView1.SelectedRows.Item(0).Cells(3).Value.ToString
            For Each impresion As Impresion In arregloImpresion
                If id = impresion.idDataGrid Then
                    arregloImpresion.Remove(impresion)
                    cargarListas()
                    Return
                End If
            Next
        End If

        If tipo = "EDICION" Then
            id = DataGridView1.SelectedRows.Item(0).Cells(3).Value.ToString
            For Each edicion As Edicion In arregloEdicion
                If id = edicion.idDataGrid Then
                    arregloEdicion.Remove(edicion)
                    cargarListas()
                    Return
                End If
            Next
        End If

        If tipo = "ALBUM" Then
            id = DataGridView1.SelectedRows.Item(0).Cells(3).Value.ToString
            For Each album As Album In arregloAlbum
                If id = album.idDataGrid Then
                    arregloAlbum.Remove(album)
                    cargarListas()
                    Return
                End If
            Next
        End If

        If tipo = "INVITACION" Then
            id = DataGridView1.SelectedRows.Item(0).Cells(3).Value.ToString
            For Each invitacion As Invitacion In arregloInvitacion
                If id = invitacion.idDataGrid Then
                    arregloInvitacion.Remove(invitacion)
                    cargarListas()
                    Return
                End If
            Next
        End If
    End Sub


    Private Sub cargarListas()
        Dim dat As New Data.DataTable("Servicios")
        Dim id As Integer = 0
        dat.Columns.Add("Servicio")
        dat.Columns.Add("Info")
        dat.Columns.Add("Costo")
        dat.Columns.Add("ID")
        For Each foto As Foto In arregloFotos
            Dim row As DataRow = dat.NewRow
            row.Item(0) = "FOTO"
            row.Item(1) = foto.detalles
            row.Item(2) = foto.costo
            row.Item(3) = id
            foto.idDataGrid = id
            dat.Rows.Add(row)
            id = id + 1
            total += foto.costo

        Next

        For Each video As Video In arregloVideo
            Dim row As DataRow = dat.NewRow
            row.Item(0) = "VIDEO"
            row.Item(1) = video.detalles
            row.Item(2) = video.costo
            row.Item(3) = id
            video.idDataGrid = id
            dat.Rows.Add(row)
            id = id + 1
            total += video.costo
        Next

        For Each impresion As Impresion In arregloImpresion
            Dim row As DataRow = dat.NewRow
            row.Item(0) = "IMPRESION"
            row.Item(1) = impresion.detalles
            row.Item(2) = impresion.costo
            row.Item(3) = id
            impresion.idDataGrid = id
            dat.Rows.Add(row)
            id = id + 1
            total += impresion.costo
        Next

        For Each edicion As Edicion In arregloEdicion
            Dim row As DataRow = dat.NewRow
            row.Item(0) = "EDICION"
            row.Item(1) = edicion.detalles
            row.Item(2) = edicion.costo
            row.Item(3) = id
            edicion.idDataGrid = id
            dat.Rows.Add(row)
            id = id + 1
            total += edicion.costo
        Next

        For Each album As Album In arregloAlbum
            Dim row As DataRow = dat.NewRow
            row.Item(0) = "ALBUM"
            row.Item(1) = album.detalles
            row.Item(2) = album.costo
            row.Item(3) = id
            album.idDataGrid = id
            dat.Rows.Add(row)
            id = id + 1
            total += album.costo
        Next

        For Each invitacion As Invitacion In arregloInvitacion
            Dim row As DataRow = dat.NewRow
            row.Item(0) = "INVITACION"
            row.Item(1) = invitacion.detalles
            row.Item(2) = invitacion.costo
            row.Item(3) = id
            invitacion.idDataGrid = id
            dat.Rows.Add(row)
            id = id + 1
            total += invitacion.costo
        Next
        DataGridView1.DataSource = dat
        LabelTotal.Text = total
        ActualizarAdeudo()
    End Sub

    Private Sub ButtonAVideo_Click(sender As Object, e As EventArgs) Handles ButtonAVideo.Click
        If videoA.IsDisposed Then
            videoA = New AgregarVideo(Me)
        End If
        videoA.Show()
    End Sub

    Private Sub ActualizarAdeudo()
        adeudo = total - anticipo
        LabelAdeudo.Text = adeudo
    End Sub

    Private Sub TextBoxAnticipo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAnticipo.TextChanged
        If TextBoxAnticipo.Text = "" Then
            TextBoxAnticipo.Text = 0
            anticipo = 0
            ActualizarAdeudo()
            Return
        End If

        If Not IsNumeric(TextBoxAnticipo.Text) Then
            Return
        End If
        anticipo = Integer.Parse(TextBoxAnticipo.Text)
        ActualizarAdeudo()
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        If DataGridView1.Rows.Count < 1 Then
            Return
        End If
        Dim tipo As String = DataGridView1.SelectedRows.Item(0).Cells(0).Value.ToString
        Dim id As Integer
        If tipo = "FOTO" Then
            id = DataGridView1.SelectedRows.Item(0).Cells(3).Value.ToString
            For Each foto As Foto In arregloFotos
                If id = foto.idDataGrid Then
                    'Enviar objeto a ModificarFoto
                    Dim window As New Modificar_Fotos(Me, foto)
                    window.Show()
                    Return
                End If
            Next
        End If

        If tipo = "VIDEO" Then
            id = DataGridView1.SelectedRows.Item(0).Cells(3).Value.ToString
            For Each video As Video In arregloVideo
                If id = video.idDataGrid Then
                    'Enviar objeto a ModificarFoto
                    Dim window As New ModificarVideo(Me, video)
                    window.Show()
                    Return
                End If
            Next
        End If

        If tipo = "IMPRESION" Then
            id = DataGridView1.SelectedRows.Item(0).Cells(3).Value.ToString
            For Each impresion As Impresion In arregloImpresion
                If id = impresion.idDataGrid Then
                    'Enviar objeto a modificarImpresion
                    Dim window As New modificarImpresion(Me, impresion)
                    window.Show()
                    Return
                End If
            Next
        End If

        If tipo = "EDICION" Then
            id = DataGridView1.SelectedRows.Item(0).Cells(3).Value.ToString
            For Each edicion As Edicion In arregloEdicion
                If id = edicion.idDataGrid Then
                    'Enviar objeto a modificarEdicion
                    Dim window As New modificarEdicion(Me, edicion)
                    window.Show()
                    Return
                End If
            Next
        End If

        If tipo = "ALBUM" Then
            id = DataGridView1.SelectedRows.Item(0).Cells(3).Value.ToString
            For Each album As Album In arregloAlbum
                If id = album.idDataGrid Then
                    'Enviar objeto a modificarAlbum
                    Dim window As New modificarAlbum(Me, album)
                    window.Show()
                    Return
                End If
            Next
        End If

        If tipo = "INVITACION" Then
            id = DataGridView1.SelectedRows.Item(0).Cells(3).Value.ToString
            For Each invitacion As Invitacion In arregloInvitacion
                If id = invitacion.idDataGrid Then
                    'Enviar objeto a modificarInvitacion
                    Dim window As New modificarInvitacion(Me, invitacion)
                    window.Show()
                    Return
                End If
            Next
        End If

    End Sub

End Class