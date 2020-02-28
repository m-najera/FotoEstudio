Public Class PaginaPrincipal
    Public NIVEL As String
    Private cerrandoSesion As Boolean
    Private configurar As Boolean
    Public clientesPrincipal As New ClientesPrincipal
    Public usuariosPrincipal As New UsuariosPrincipal
    Public serviciosPrincipal As New ServiciosPrincipal
    Public configuraciones As New Configuraciones

    Private confirmacionSalir As Integer
    Private Sub PaginaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelDireccion.Text = My.Settings.dir
        If NIVEL = "ADMINISTRADOR" Then
            LabelNivel.Text = NIVEL
        Else
            LabelNivel.Text = NIVEL
            ButtonUsuarios.Enabled = False
            ButtonUsuarios.Visible = False
            ButtonConfig.Enabled = False
            ButtonConfig.Visible = False
        End If

        confirmacionSalir = -1
    End Sub

    Public Sub New(nivel As String)
        ' This call is required by the designer.
        InitializeComponent()
        '    Add any initialization after the InitializeComponent() call.
        Me.NIVEL = nivel
        Me.cerrandoSesion = False
        Me.configurar = False
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If cerrandoSesion Then
            confirmacionSalir = MsgBox("¿Seguro de que desea cerrar su sesión?", MsgBoxStyle.OkCancel)
            If confirmacionSalir = MsgBoxResult.Ok Then
                ''Cerrar todas las ventanas abiertas, excepto IniciarSesion
                My.Application.OpenForms.Cast(Of Form)() _
              .Except({Me}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())
                IniciarSesion.Show()
            Else
                cerrandoSesion = False
                e.Cancel() = True
                confirmacionSalir = -1
            End If
        ElseIf configurar Then
            confirmacionSalir = MsgBox("Al terminar la configuración se cerrará su sesión ¿Continuar?", MsgBoxStyle.OkCancel)
            If confirmacionSalir = MsgBoxResult.Ok Then
                ''Cerrar todas las ventanas abiertas, excepto Configurar
                My.Application.OpenForms.Cast(Of Form)() _
              .Except({Me}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())
                configuraciones.Show()
            Else
                configurar = False
                e.Cancel() = True
                confirmacionSalir = -1
            End If
        Else
            If confirmacionSalir = -1 Then
                confirmacionSalir = MsgBox("¿Seguro de que desea cerrar completamente el programa?", MsgBoxStyle.OkCancel)
                If confirmacionSalir = MsgBoxResult.Ok Then
                    Try
                        Application.Exit()
                    Catch ex As Exception

                    End Try

                Else
                    e.Cancel() = True
                    confirmacionSalir = -1
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBoxLogo.Click

    End Sub

    Private Sub BotonClientes_Click(sender As Object, e As EventArgs) Handles ButtonClientes.Click
        If clientesPrincipal.IsDisposed Then
            clientesPrincipal = New ClientesPrincipal

        End If
        clientesPrincipal.Show()
        clientesPrincipal.Focus()
    End Sub

    Private Sub BotonUsuarios_Click(sender As Object, e As EventArgs) Handles ButtonUsuarios.Click
        If usuariosPrincipal.IsDisposed Then
            usuariosPrincipal = New UsuariosPrincipal

        End If
        usuariosPrincipal.Show()
        usuariosPrincipal.Focus()
    End Sub

    Private Sub BotonCerrarSesion_Click(sender As Object, e As EventArgs) Handles BotonCerrarSesion.Click
        cerrandoSesion = True
        Me.Close()
    End Sub

    Private Sub ButtonPedidos_Click(sender As Object, e As EventArgs) Handles ButtonPedidos.Click
        If serviciosPrincipal.IsDisposed Then
            serviciosPrincipal = New ServiciosPrincipal
        End If
        serviciosPrincipal.StartPosition = FormStartPosition.CenterScreen
        serviciosPrincipal.Show()
        serviciosPrincipal.Focus()

    End Sub

    Private Sub ButtonConfig_Click(sender As Object, e As EventArgs) Handles ButtonConfig.Click
        configurar = True
        Me.Close()
    End Sub

End Class