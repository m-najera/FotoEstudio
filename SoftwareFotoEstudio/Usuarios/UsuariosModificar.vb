Public Class UsuariosModificar
    Private idUsuario As String
    Dim conexion As New BDConexiones

    Private Sub UsuariosModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim data As DataSet
        data = conexion.ObtenerUsuario(idUsuario)
        TextBoxNombre.Text = data.Tables(0).Rows(0).Item(1)
        TextBoxUsuario.Text = data.Tables(0).Rows(0).Item(2)
        TextBoxContr.Text = data.Tables(0).Rows(0).Item(3)
        TextBoxConfirmarContr.Text = data.Tables(0).Rows(0).Item(3)
        Dim nivel As Integer = 1
        If data.Tables(0).Rows(0).Item(4).ToString = "ADMINISTRADOR" Then
            nivel = 0
        End If
        ComboBoxNivel.SelectedIndex = nivel
        ComboBoxPregunta.SelectedIndex = Integer.Parse(data.Tables(0).Rows(0).Item(5))
        TextBoxRespuesta.Text = data.Tables(0).Rows(0).Item(6)
        If idUsuario = 1 Then
            ComboBoxNivel.Enabled = False
        End If

    End Sub

    Public Sub New(idU As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.idUsuario = idU
    End Sub

    Private Sub BottonAceptar_Click(sender As Object, e As EventArgs) Handles BottonAceptar.Click
        ModificarUsuario()
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub ModificarUsuario()
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

            Dim resultado As Integer
            resultado = conexion.ActualizarUsuario(idUsuario, nombre, usuario, contrasena1, tipoUsuario, pregunta, respuesta)
            If resultado = -1 Then
                LabelError.Text = "ERROR AL ACTUALIZAR LA INFORMACION"
            Else
                MsgBox("Información actualizada")
                Me.Close()
            End If

        Else
            LabelError.Visible = True
            LabelError.Text = "LAS CONTRASEÑAS NO COINCIDEN"
            Return
        End If
    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxUsuario.KeyDown, TextBoxContr.KeyDown, TextBoxConfirmarContr.KeyDown, TextBoxNombre.KeyDown, TextBoxRespuesta.KeyDown
        LabelError.Visible = False
        If e.KeyCode.Equals(Keys.Enter) Then
            ModificarUsuario()
        End If
    End Sub

    Private Sub UsuariosModificar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Owner.Enabled = True
        Me.Owner.Focus()
    End Sub

    Private Sub UsuariosModificar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Focus()
        Me.Owner.Enabled = False
    End Sub
End Class