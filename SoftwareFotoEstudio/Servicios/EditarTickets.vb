' AUTOR: Misael Santana Correa
' DESCRIPCION: Modulo de editar ticket, Modifica los parametros de la tabla "tickets".
'              Su funcion es obtener y mostrar los datos del ticket seleccionado y 
'              permitir modificar los datos.
'FECHA DE MODIFICACION: 28 DE NOVIEMBRE DE 2018 

Public Class EditarTickets
    Private buscarTicket As ServicioBuscarTicket
    Private Sub ButtonEditTicket_Click(sender As Object, e As EventArgs) Handles ButtonEditTicket.Click
        funcionEditarTickets()
    End Sub

    Public Sub New(ref As ServicioBuscarTicket)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.buscarTicket = ref
    End Sub
    Dim clienteID As String
    Dim ticketID As String

    Private Sub funcionEditarTickets()
        Dim nombreEvento As String = TextBoxNombreEven.Text
        Dim lugarEvento As String = TextBoxLugarEven.Text
        Dim total As String = TextBoxTotal.Text
        Dim adeudo As String = TextBoxAdeudo.Text
        Dim estadoServicio As String = TextBoxEstado.Text

        If nombreEvento = String.Empty And lugarEvento = String.Empty And total = String.Empty And adeudo = String.Empty And estadoServicio = String.Empty Then
            MsgBox("Se han encontrado campos vacion!!")
        Else

            If IsNumeric(adeudo) And IsNumeric(total) And adeudo.Length <= 8 And total.Length <= 8 Then
                Dim numTotal As Integer = CInt(total)
                Dim numAdeudo As Integer = CInt(adeudo)
                If numTotal >= 0 And numAdeudo >= 0 Then
                    Try
                        Dim consultasDB As New BDConexiones
                        consultasDB.actualizarTicket(nombreEvento, lugarEvento,
                                                     "" & Format(Me.DateTimePickerFechaEntr.Value, "yyyy/MM/dd"),
                                                     "" & Format(Me.DateTimePickerFechaEven.Value, "yyyy/MM/dd"),
                                                     total, adeudo,
                                                     "" & Format(Me.DateTimePickerPagoSig.Value, "yyyy/MM/dd"),
                                                     estadoServicio, clienteID, ticketID)
                        Me.Hide()
                    Catch ex As Exception
                        MsgBox("ERROR: " & ex.Message)
                    End Try
                Else
                    MsgBox("ERROR: valor no valido")
                End If


            Else
                MsgBox("Solo se aceptan numeros en los campos de 'total' y 'adeudo'")

            End If
        End If
    End Sub

    Private Sub EditarTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatosTicket()
    End Sub

    Private Sub cargarDatosTicket()
        ticketID = buscarTicket.DataGridTickets.SelectedRows.Item(0).Cells(0).Value
        clienteID = buscarTicket.DataGridTickets.SelectedRows.Item(0).Cells(1).Value
        TextBoxNombreEven.Text = buscarTicket.DataGridTickets.SelectedRows.Item(0).Cells(2).Value
        TextBoxLugarEven.Text = buscarTicket.DataGridTickets.SelectedRows.Item(0).Cells(3).Value
        DateTimePickerFechaCont.Value = buscarTicket.DataGridTickets.SelectedRows.Item(0).Cells(4).Value
        DateTimePickerFechaEntr.Value = buscarTicket.DataGridTickets.SelectedRows.Item(0).Cells(5).Value
        DateTimePickerFechaEven.Value = buscarTicket.DataGridTickets.SelectedRows.Item(0).Cells(6).Value
        TextBoxTotal.Text = buscarTicket.DataGridTickets.SelectedRows.Item(0).Cells(7).Value
        TextBoxAdeudo.Text = buscarTicket.DataGridTickets.SelectedRows.Item(0).Cells(8).Value
        DateTimePickerPagoSig.Value = buscarTicket.DataGridTickets.SelectedRows.Item(0).Cells(9).Value
        TextBoxEstado.Text = buscarTicket.DataGridTickets.SelectedRows.Item(0).Cells(10).Value
    End Sub
End Class