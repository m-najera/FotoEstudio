' Autor: Miguel Angel Nájera
' Descripción: Ventana de inicio de sesión de la aplicacion
' Fecha de última modificación: 30/12/2018

Public Class IniciarSesion
    Dim iniciado As Boolean = False
    Dim rec As New RecuperarContrasena

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        Autenticar()

    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not iniciado Then
            If MsgBox("¿Seguro de que desea salir?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                e.Cancel() = True
            End If
        End If
    End Sub

    Private Sub Caja_TextChanged(sender As Object, e As EventArgs) Handles CajaContrasena.TextChanged, CajaUsuario.TextChanged
        TextoError.Visible = False
    End Sub



    Private Sub Autenticar()
        Dim conexion As New BDConexiones
        Dim usuario, contrasena As String
        usuario = CajaUsuario.Text
        contrasena = CajaContrasena.Text
        TextoError.Visible = False

        Dim nivel As String
        nivel = conexion.AutenticarUsuario(usuario, contrasena)
        Cursor = Cursors.WaitCursor
        Threading.Thread.Sleep(300)

        If nivel = "" Then
            TextoError.Visible = True
        Else
            iniciado = True
            Dim PP As New PaginaPrincipal(nivel)
            PP.Show()
            Me.Close()
        End If

        'If usuario = "admin" And contrasena = "admin" Then
        '    iniciado = True
        '    Dim nivel As Integer = 0
        '    Dim PP As New PaginaPrincipal(nivel)
        '    PP.Show()
        '    Me.Close()
        'Else
        '    TextoError.Visible = True
        'End If

        Cursor = Cursors.Default
    End Sub

    Private Sub CajaUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles CajaUsuario.KeyDown, CajaContrasena.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            Autenticar()
        End If
    End Sub

    Private Sub IniciarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CajaUsuario.Select()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If rec.IsDisposed Then
            rec = New RecuperarContrasena
        End If
        rec.Show()
        rec.Focus()
    End Sub
End Class
