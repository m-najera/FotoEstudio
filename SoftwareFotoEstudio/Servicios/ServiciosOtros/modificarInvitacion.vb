Public Class modificarInvitacion
    Private idInvitacion As String = ""
    Dim conexion As New BDconexionesOtros
    Dim serviNuevo As ServiciosNuevo
    Dim servBuscar As ServicioBuscarTicket
    Dim i As Invitacion

    Private Sub modificarInvitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If idInvitacion <> "" Then
            Dim data As DataSet
            data = conexion.obtenerDetallesInvitacion(idInvitacion)
            textBoxDetalles.Text = data.Tables(0).Rows(0).Item(2)
            textBoxPapel.Text = data.Tables(0).Rows(0).Item(3)
            textBoxCantidad.Text = data.Tables(0).Rows(0).Item(4)
            textBoxCosto.Text = data.Tables(0).Rows(0).Item(5)
        Else
            textBoxDetalles.Text = i.detalles
            textBoxPapel.Text = i.papel
            textBoxCantidad.Text = i.cantidad
            textBoxCosto.Text = i.costo
        End If

    End Sub

    Public Sub New(idI As String, ref As ServicioBuscarTicket)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.idInvitacion = idI
        Me.Owner = ref
        servBuscar = ref
    End Sub

    Public Sub New(serv As ServiciosNuevo, i As Invitacion)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.i = i
        Me.Owner = serv
        serviNuevo = serv
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs)
        textBoxDetalles.Enabled = True
        textBoxDetalles.ReadOnly = False
        textBoxCantidad.Enabled = True
        textBoxCantidad.ReadOnly = False
        textBoxPapel.Enabled = True
        textBoxPapel.ReadOnly = False
        textBoxCosto.Enabled = True
        textBoxCosto.ReadOnly = False
    End Sub

    Private Sub BottonAceptar_Click(sender As Object, e As EventArgs) Handles BottonAceptar.Click
        modificarInvitacion()
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub modificarInvitacion()
        If textBoxDetalles.Text = "" Or
            textBoxPapel.Text = "" Or
            textBoxCantidad.Text = "" Or
            textBoxCosto.Text = "" Then
            LabelError.Text = "DEBE LLENAR TODOS LOS CAMPOS"
            Return
        End If

        If Not IsNumeric(textBoxCantidad.Text & textBoxCosto.Text) Then
            LabelError.Text = "EL VALOR DEBE SER NUMERICO"
            LabelError.Visible = True
            Return
        End If

        If textBoxCantidad.Text.Length > 10 Then
            LabelError.Text = "LA CANTIDAD ES DEMASIADO GRANDE"
            LabelError.Visible = True
            Return
        End If

        If textBoxCosto.Text.Length > 6 Then
            LabelError.Text = "EL COSTO ES DEMASIADO GRANDE"
            LabelError.Visible = True
            Return
        End If

        Dim detalles As String = textBoxDetalles.Text
        Dim cantidad As String = textBoxCantidad.Text
        Dim papel As String = textBoxPapel.Text
        Dim costo As String = textBoxCosto.Text

        If idInvitacion <> "" Then
            Dim resultado As Integer
            resultado = conexion.actualizarInvitacion(idInvitacion, detalles, papel, cantidad, costo)
            If resultado = -1 Then
                LabelError.Text = "ERROR AL ACTUALIZAR LA INFORMACION"
            Else
                MsgBox("Información actualizada")
                Me.Close()
            End If
        Else
            Dim inv As New Invitacion(detalles, papel, cantidad, costo)
            inv.idDataGrid = i.idDataGrid
            serviNuevo.ModificarInvitacion(inv)
            Me.Close()
        End If
    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles textBoxDetalles.KeyDown, textBoxPapel.KeyDown, textBoxCantidad.KeyDown, textBoxCosto.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            modificarInvitacion()
        End If
    End Sub

    Private Sub Form_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Owner.Enabled = False
        Me.Focus()
    End Sub

    Private Sub Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If Not servBuscar Is Nothing Then
            servBuscar.ListarServicios()
        End If
        Owner.Enabled = True
    End Sub
End Class