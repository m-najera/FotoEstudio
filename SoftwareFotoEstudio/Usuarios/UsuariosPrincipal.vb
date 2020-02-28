
' Autor: Miguel Angel Nájera
' Descripción: Ventana Principal del Módulo Usuarios. Muestra una lista de Usuarios y permite
'   ver detalles de cada uno, así como modificarlos o eliminarlos
' Fecha de última modificación: 30/10/2018

Public Class UsuariosPrincipal
    Dim conexiones As New BDConexiones
    Dim usuariosAgregar As New UsuariosAgregar
    Dim usuariosMod As UsuariosModificar
    Private Const ID_ADMIN_PRINCIPAL As Integer = 1

    Private Sub BotonNuevoUsuario_Click(sender As Object, e As EventArgs) Handles BotonNuevoUsuario.Click
        If usuariosAgregar.IsDisposed Then
            usuariosAgregar = New UsuariosAgregar

        End If
        usuariosAgregar.Owner = Me
        usuariosAgregar.Show()
        usuariosAgregar.Focus()
    End Sub

    Private Sub BotonBuscar_Click(sender As Object, e As EventArgs) Handles BotonBuscar.Click
        BuscarUsuarios()
    End Sub

    Private Sub UsuariosPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim idUsuario As String

        If DataGridUsuarios.SelectedCells.Count > 0 Then
            idUsuario = DataGridUsuarios.SelectedRows.Item(0).Cells(0).Value.ToString
            If idUsuario = ID_ADMIN_PRINCIPAL Then
                MsgBox("No se puede eliminar la cuenta principal de administrador", MsgBoxStyle.Critical)
                Return
            End If
            Dim nombre As String = DataGridUsuarios.SelectedRows.Item(0).Cells(1).Value.ToString
            If MsgBox("¿Eliminar la cuenta del usuario: " & nombre & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim resultado As Integer = conexiones.EliminarUsuario(idUsuario)
                If resultado = 1 Then
                    MsgBox("Usuario eliminado", MsgBoxStyle.OkOnly)
                    BuscarUsuarios()
                End If
            End If

        End If

    End Sub

    Sub BuscarUsuarios()
        Dim consulta As String
        consulta = CajaBuscar.Text
        Try
            Cursor = Cursors.WaitCursor
            Application.DoEvents()
            Dim datos As New DataSet
            datos = conexiones.BuscarUsuarios(consulta)
            DataGridUsuarios.DataSource = datos.Tables(0)
            DataGridUsuarios.Columns(0).FillWeight = 30
            DataGridUsuarios.Refresh()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox("Error " & ex.Message)
        End Try
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        If DataGridUsuarios.SelectedRows.Count > 0 Then
            Dim ID_USUARIO As String = DataGridUsuarios.SelectedRows(0).Cells(0).Value
            If usuariosMod Is Nothing Then
                usuariosMod = New UsuariosModificar(ID_USUARIO)
                usuariosMod.Owner = Me
                usuariosMod.Show()
            End If
            If usuariosMod.IsDisposed Then
                usuariosMod = New UsuariosModificar(ID_USUARIO)
                usuariosMod.Owner = Me
                usuariosMod.Show()
            Else
                usuariosMod.Show()
            End If
            usuariosMod.Focus()
        End If

    End Sub

    Private Sub CajaBuscar_TextChanged(sender As Object, e As EventArgs) Handles CajaBuscar.TextChanged

    End Sub

    Private Sub CajaBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles CajaBuscar.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            BuscarUsuarios()
        End If
    End Sub
End Class