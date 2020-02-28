' Autor: Miguel Angel Nájera
' Descripción: Ventana para reestablecer la contraseña de un usuario que la haya olvidado
' Fecha de última modificación: 30/12/2018

Public Class RecuperarContrasena

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxContr.KeyDown, TextBoxConfirmarContr.KeyDown, TextBoxNombre.KeyDown, TextBoxRespuesta.KeyDown
        LabelError.Visible = False
        If e.KeyCode.Equals(Keys.Enter) Then
            recuperarContrasena()
        End If
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        recuperarContrasena()
    End Sub

    Private Sub recuperarContrasena()
        Dim nombre As String = TextBoxNombre.Text
        Dim contrasena1 As String = TextBoxContr.Text
        Dim contrasena2 As String = TextBoxConfirmarContr.Text
        Dim pregunta As Integer = ComboBoxPregunta.SelectedIndex
        Dim respuesta As String = TextBoxRespuesta.Text

        If nombre = "" Or contrasena1 = "" Or contrasena2 = "" Or respuesta = "" Then
            LabelError.Visible = True
            LabelError.Text = "DEBE LLENAR TODOS LOS CAMPOS"
            Return
        End If

        If contrasena1 <> contrasena2 Then
            LabelError.Visible = True
            LabelError.Text = "LAS CONTRASEÑAS NO COINCIDEN"
            Return
        End If

        Dim conexion As New BDConexiones
        Dim resultado As Integer
        resultado = conexion.ValidarPregunta(nombre, pregunta, respuesta)
        MsgBox(resultado & "pregunta: " & pregunta & " Resp: " & respuesta)
        If resultado <> -1 Then
            Dim r As Integer = conexion.ActualizarUsuarioContrasena(resultado, contrasena1)
            MsgBox(r)
            If r <> -1 Then
                MsgBox("CONTRASEÑA REESTABLECIDA")
                Me.Close()
            End If
        Else
            LabelError.Text = "LOS DATOS NO COINCIDEN"
        End If
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub RecuperarContrasena_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxPregunta.SelectedIndex = 0
    End Sub

End Class