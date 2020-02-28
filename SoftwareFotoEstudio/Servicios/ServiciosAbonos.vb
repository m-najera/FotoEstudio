' AUTOR: Misael Santana Correa
' DESCRIPCION: Modulo de guardar abono, Modifica los parametros de las tablas "tickets" y "abonos".
'              Su funcion es buscar por medio del nombre un cliente al cual guardara en una tabla 
'              el abono y actualizara el adeudo y la fechas de pago de la tabla "tickets".
'FECHA DE MODIFICACION: 22 DE NOVIEMBRE DE 2018
Public Class ServiciosAbonos
    Private consultasBD As New BDConexiones


    Private Sub ButtonBuscarCli_Click(sender As Object, e As EventArgs) Handles ButtonBuscarCli.Click
        MetodoBuscarCliente()
    End Sub
    Private Sub MetodoBuscarCliente()
        Dim nombreBuscar As String = TextBoxNombreCli.Text
        Dim cnt As Byte
        Dim datos As DataSet
        If nombreBuscar <> "" Then
            datos = consultasBD.BuscarClientesAbonos(nombreBuscar)
            cnt = datos.Tables(0).Rows.Count
            If cnt <> 0 Then
                Cursor = Cursors.WaitCursor
                Application.DoEvents()
                DataGridViewResultado.DataSource = datos.Tables(0)
                DataGridViewResultado.DataMember = ""
                DataGridViewResultado.Refresh()
                Cursor = Cursors.Default
            Else
                MsgBox("No se encontraron registros")
            End If
        End If

    End Sub

    Private Sub ButtonAbonar_Click(sender As Object, e As EventArgs) Handles ButtonAbonar.Click
        MetodoAbonar()
    End Sub

    Private Sub MetodoAbonar()
        Dim cantidadAbonar As Integer
        Dim deuda As Integer
        Dim cantidadRestante As Integer
        Dim respuesta As Object
        If DataGridViewResultado.RowCount <= 0 Then
            MsgBox("No hay datos seleccionados")
        Else
            Dim clienteId As String
            Dim idTicket As String
            idTicket = DataGridViewResultado.CurrentRow.Cells.Item(12).Value.ToString
            clienteId = DataGridViewResultado.CurrentRow.Cells.Item(0).Value.ToString
            deuda = CInt(DataGridViewResultado.CurrentRow.Cells.Item(9).Value.ToString)
            If TextBoxCantidadAbonar.TextLength > 0 Then
                If IsNumeric(TextBoxCantidadAbonar.Text) Then
                    cantidadAbonar = CInt(TextBoxCantidadAbonar.Text)
                    If deuda <= 0 Or cantidadAbonar < 0 Then
                        MsgBox("NO HAY ADEUDO!  Y/O LA CANTIDAD INGRESADA NO ES VALIDA ")
                    Else
                        cantidadRestante = deuda - cantidadAbonar
                        If cantidadRestante <= 0 Then
                            MsgBox("La cantidad ingresada no es valida" + vbLf + "Ingrese una cantidad igual o menor a: " & deuda)

                        Else
                            respuesta = MsgBox("CONFIRMAR ABONO." + vbLf + " " + vbLf + " Abonará un total de: " & cantidadAbonar & " el adeudo total será de: " & cantidadRestante, MsgBoxStyle.OkCancel)
                            TextBoxRestante.Text = "" & cantidadRestante
                            If respuesta = MsgBoxResult.Ok Then
                                Dim fechaPago As String = Format(Me.DateTimePickerPagSig.Value, "yyyy/MM/dd")
                                consultasBD.operacionesAbonos(clienteId, idTicket, cantidadRestante, fechaPago, cantidadAbonar)

                            Else
                                ' NO HACER NADA
                            End If


                        End If

                    End If

                Else
                    MsgBox("INGRESE UN NUMERO!")
                End If
            Else
                MsgBox("CAMPO VACIO!")
            End If
        End If
    End Sub

    Private Sub DataGridViewResultado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewResultado.CellContentClick

    End Sub

    Private Sub TextBoxCantidadAbonar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCantidadAbonar.TextChanged

    End Sub

    Private Sub TextBoxNombreCli_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombreCli.TextChanged

    End Sub
End Class