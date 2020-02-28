' Autor: Urivan Rubio Garcia
' Descripción: Ventana para seleccionar el cliente al que se le hara el servicio del Módulo Servicios. 
'Muestra una lista de clientes y permite seleccionar uno.
' Fecha de última modificación: 16/11/2018

Imports MySql.Data

Public Class ClienteServicio
    Private conexiones As New BDConexiones
    Dim main As ServiciosNuevo
    Private Sub ClienteServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridClientes.MultiSelect = False
        DataGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Public Sub New(parent As ServiciosNuevo)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        main = parent
        Me.Owner = parent
    End Sub

    Private Sub BotonBuscar_Click(sender As Object, e As EventArgs) Handles BotonBuscar.Click
        BuscarClientes()
    End Sub

    Sub BuscarClientes()
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

    Private Sub ButtonSeleccionar_Click(sender As Object, e As EventArgs) Handles ButtonSeleccionar.Click
        If DataGridClientes.SelectedRows.Count > 0 Then
            main.ActualizarCliente(DataGridClientes.SelectedRows(0).Cells(0).Value,
                                   DataGridClientes.SelectedRows(0).Cells(1).Value & " " &
                                   DataGridClientes.SelectedRows(0).Cells(2).Value)
            Me.Close()

        End If
    End Sub

    Private Sub form_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Me.Owner.Enabled = True
        Me.Owner.Focus()
    End Sub

    Private Sub form_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Owner.Enabled = False
    End Sub
End Class