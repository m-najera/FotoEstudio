' AUTOR: Misael Santana Correa
' DESCRIPCION: Modulo de historial de abonos, Consulta la tabla "abonos".
'              Su funcion es buscar por medio del nombre un cliente o del id del ticket
'              los datos alojados en la tabla "abonos" y mostralos de acuerdo con los criterios de busqueda.
'FECHA DE MODIFICACION: 29 DE NOVIEMBRE DE 2018

Public Class HistorialAbonos
    Private consultasBD As New BDConexiones
    Private tipoBusqueda As String
    Private Sub HistorialAbonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxApellidosCli.Enabled = False
        TextBoxNombreCli.Enabled = False
        TextBoxIDticket.Enabled = False
    End Sub

    Private Sub ComboBoxBuscarPor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBuscarPor.SelectedIndexChanged
        tipoBusqueda = ComboBoxBuscarPor.Text
        If tipoBusqueda = "id ticket" Then
            TextBoxIDticket.Text = ""
            TextBoxApellidosCli.Text = ""
            TextBoxNombreCli.Text = ""
            TextBoxIDticket.Enabled = True
            TextBoxApellidosCli.Enabled = False
            TextBoxNombreCli.Enabled = False
        ElseIf tipoBusqueda = "nombre del cliente" Then
            TextBoxApellidosCli.Text = ""
            TextBoxNombreCli.Text = ""
            TextBoxIDticket.Text = ""
            TextBoxApellidosCli.Enabled = True
            TextBoxNombreCli.Enabled = True
            TextBoxIDticket.Enabled = False

        Else
            TextBoxApellidosCli.Enabled = False
            TextBoxNombreCli.Enabled = False
            TextBoxIDticket.Enabled = False
        End If
    End Sub

    Private Sub ButtonConsultar_Click(sender As Object, e As EventArgs) Handles ButtonConsultar.Click
        If tipoBusqueda = "id ticket" Then
            BuscarIDTickets()
        ElseIf tipoBusqueda = "nombre del cliente" Then
            BuscarNombreCliente()

        End If
    End Sub

    Private Sub BuscarIDTickets()
        Dim buscaIdticket As String
        buscaIdticket = TextBoxIDticket.Text
        If buscaIdticket.Length > 0 Then
            If IsNumeric(buscaIdticket) And buscaIdticket.Length < 9 Then
                Dim numBuscaticket As Integer = CInt(buscaIdticket)
                If numBuscaticket > 0 Then
                    Dim cantidadRes As Byte
                    Dim datos As New DataSet
                    datos = consultasBD.ConsultaAbonos(buscaIdticket)
                    cantidadRes = datos.Tables(0).Rows.Count
                    If cantidadRes <> 0 Then
                        Cursor = Cursors.WaitCursor
                        Application.DoEvents()
                        DataGridViewHistorialAbonos.DataSource = datos.Tables(0)
                        DataGridViewHistorialAbonos.DataMember = ""
                        DataGridViewHistorialAbonos.Refresh()
                        Cursor = Cursors.Default

                    Else
                        MsgBox("ERROR EN LOS DATOS!!")
                    End If


                Else
                    If numBuscaticket < 0 Then
                        MsgBox("No se aceptan numeros negativos")
                    Else
                        MsgBox("No se encontraron registros")
                    End If
                End If

            Else
                    MsgBox("EL ID DEL TICKET DEBE SER NUMERICO!!")
            End If
        End If
    End Sub

    Private Sub BuscarNombreCliente()
        Dim buscaNombre As String
        Dim buscaApellido As String
        buscaNombre = TextBoxNombreCli.Text
        buscaApellido = TextBoxApellidosCli.Text
        If buscaNombre <> "" And buscaApellido <> "" Then
            Dim buscaIdTickets As String
            Dim cantidadRes As Byte
            buscaIdTickets = consultasBD.ConsultaAbonosNombre(buscaNombre, buscaApellido)
            If buscaIdTickets <> "" Then
                Dim datos As New DataSet
                datos = consultasBD.ConsultaAbonos(buscaIdTickets)
                cantidadRes = datos.Tables(0).Rows.Count
                If cantidadRes <> 0 Then
                    Cursor = Cursors.WaitCursor
                    Application.DoEvents()
                    DataGridViewHistorialAbonos.DataSource = datos.Tables(0)
                    DataGridViewHistorialAbonos.DataMember = ""
                    DataGridViewHistorialAbonos.Refresh()
                    Cursor = Cursors.Default
                Else
                    MsgBox("No se encontraron registros")
                End If
            Else
                MsgBox("No hay resultados")
            End If

        End If



    End Sub

End Class