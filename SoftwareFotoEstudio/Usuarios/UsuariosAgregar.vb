
' Autor: Miguel Angel Nájera
' Descripción: Ventana Agregar del módulo Usuiarios. Permite registrar un nuevo usuario del sistema
' Fecha de última modificación: 30/10/2018


Public Class UsuariosAgregar
    Private conexion As New BDConexiones
    Private contenidoNivel As New ArrayList



    Private Sub BottonAceptar_Click(sender As Object, e As EventArgs) Handles BottonAceptar.Click

        Dim nombre As String = TextBoxNombre.Text
        Dim usuario As String = TextBoxUsuario.Text
        Dim contrasena1 As String = TextBoxContr.Text
        Dim contrasena2 As String = TextBoxConfirmarContr.Text
        Dim nivel As Integer = ComboBoxNivel.SelectedIndex
        Dim pregunta As Integer = ComboBoxPregunta.SelectedIndex
        Dim respuesta As String = TextBoxRespuesta.Text
        Dim tipoUsuario As String = ""

        If nivel = 0 Then
            tipoUsuario = "ADMINISTRADOR"
        Else
            tipoUsuario = "USUARIO GENERAL"
        End If

        If nombre = "" Or contrasena1 = "" Or contrasena2 = "" Or respuesta = "" Then
            LabelError.Visible = True
            LabelError.Text = "DEBE LLENAR TODOS LOS CAMPOS"
            Return
        End If

        If contrasena1 = contrasena2 Then
            'Agregar Usuario
            Dim resultado As Integer
            resultado = conexion.AgregarUsuario(nombre, usuario, contrasena1, tipoUsuario, pregunta, respuesta)

            If resultado = -1 Then
                LabelError.Text = "ERROR AL AGREGAR"
                LabelError.Visible = True
            Else
                Me.Close()
            End If


        Else
            LabelError.Visible = True
            LabelError.Text = "LAS CONTRASEÑAS NO COINCIDEN"
            Return
        End If
    End Sub

    Private Sub Caja_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuario.TextChanged,
        TextBoxRespuesta.TextChanged, TextBoxContr.TextChanged, TextBoxConfirmarContr.TextChanged, TextBoxNombre.TextChanged
        LabelError.Visible = False
    End Sub

    Private Sub UsuariosAgregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxNivel.SelectedIndex = 1
        ComboBoxPregunta.SelectedIndex = 1

    End Sub

    Private Sub UsuariosAgregar_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Owner.Enabled = False
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub UsuariosAgregar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Owner.Enabled = True
        Me.Owner.Focus()
    End Sub
End Class