' Autor: Urivan Rubio Garcia
' Descripción: Ventana Principal del Módulo clientes. Muestra una lista de clientes y permite
'   ver detalles de cada uno, así como modificarlos o eliminarlos
' Fecha de última modificación: 04/11/2018

Imports MySql.Data

Public Class ClientesPrincipal
    Private conexiones As New BDConexiones
    Private clientesAgregar As New ClientesAgregar(Me)
    Dim clientesMod As ClientesModificar

    Private Sub ClientesPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridClientes.MultiSelect = False
        DataGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles BotonBuscar.Click
        BuscarClientes()
    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles BotonNuevoCliente.Click
        If clientesAgregar.IsDisposed Then
            clientesAgregar = New ClientesAgregar(Me)
        End If
        clientesAgregar.Show()
        clientesAgregar.Focus()
    End Sub



    Private Sub BotonEliminar_Click(sender As Object, e As EventArgs) Handles BotonEliminar.Click
        Dim idCliente As String

        If DataGridClientes.SelectedCells.Count > 0 Then
            idCliente = DataGridClientes.SelectedRows.Item(0).Cells(0).Value.ToString
            Dim nombre As String = DataGridClientes.SelectedRows.Item(0).Cells(1).Value.ToString
            If MsgBox("¿Eliminar la cuenta del cliente: " & nombre & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim resultado As Integer = conexiones.EliminarCliente(idCliente)
                If resultado = 1 Then
                    MsgBox("Usuario eliminado", MsgBoxStyle.OkOnly)
                    BuscarClientes()
                End If
            End If

        End If
    End Sub

    Private Sub BuscarClientes()
        Dim consulta As String
        consulta = CajaBuscar.Text
        Try
            Cursor = Cursors.WaitCursor
            Application.DoEvents()
            Dim datos As New DataSet
            datos = conexiones.BuscarClientes(consulta)
            DataGridClientes.DataSource = datos.Tables(0)
            DataGridClientes.Columns(0).FillWeight = 30
            DataGridClientes.Refresh()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox("Error " & ex.Message)
        End Try
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        If DataGridClientes.SelectedRows.Count > 0 Then
            Dim ID_CLIENTE As String = DataGridClientes.SelectedRows(0).Cells(0).Value
            If clientesMod Is Nothing Then
                clientesMod = New ClientesModificar(ID_CLIENTE, Me)
                clientesMod.Owner = Me
                clientesMod.Show()
            End If
            If clientesMod.IsDisposed Then
                clientesMod = New ClientesModificar(ID_CLIENTE, Me)
                clientesMod.Owner = Me
                clientesMod.Show()
            Else
                clientesMod.Show()
            End If
            clientesMod.Focus()
        End If
    End Sub

    Private Sub CajaBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles CajaBuscar.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            BuscarClientes()
        End If
    End Sub
End Class