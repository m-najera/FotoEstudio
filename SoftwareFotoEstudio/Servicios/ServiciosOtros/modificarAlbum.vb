Public Class modificarAlbum
    Private idAlbum As String
    Dim conexion As New BDconexionesOtros
    Dim serviNuevo As ServiciosNuevo
    Dim servBuscar As ServicioBuscarTicket
    Dim a As Album

    Private Sub modificarAlbum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If idAlbum <> "" Then
            Dim data As DataSet
            data = conexion.obtenerDetallesAlbum(idAlbum)
            textBoxDetalles.Text = data.Tables(0).Rows(0).Item(2)
            textBoxCantidad.Text = data.Tables(0).Rows(0).Item(3)
            textBoxDisenio.Text = data.Tables(0).Rows(0).Item(4)
            textBoxCosto.Text = data.Tables(0).Rows(0).Item(5)
        Else
            textBoxDetalles.Text = a.detalles
            textBoxCantidad.Text = a.cantidad
            textBoxDisenio.Text = a.diseno
            textBoxCosto.Text = a.costo
        End If

    End Sub

    Public Sub New(idA As String, ref As ServicioBuscarTicket)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.idAlbum = idA
        Me.Owner = ref
        servBuscar = ref
    End Sub

    Public Sub New(serv As ServiciosNuevo, a As Album)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.a = a
        Me.Owner = serv
        serviNuevo = serv
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs)
        textBoxDetalles.Enabled = True
        textBoxDetalles.ReadOnly = False
        textBoxCantidad.Enabled = True
        textBoxCantidad.ReadOnly = False
        textBoxDisenio.Enabled = True
        textBoxDisenio.ReadOnly = False
        textBoxCosto.Enabled = True
        textBoxCosto.ReadOnly = False
    End Sub

    Private Sub BottonAceptar_Click(sender As Object, e As EventArgs) Handles BottonAceptar.Click
        modificarAlbum()
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub modificarAlbum()
        If textBoxDetalles.Text = "" Or
            textBoxCantidad.Text = "" Or
            textBoxDisenio.Text = "" Or
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
        Dim disenio As String = textBoxDisenio.Text
        Dim costo As String = textBoxCosto.Text

        If idAlbum <> "" Then
            Dim resultado As Integer
            resultado = conexion.actualizarAlbum(idAlbum, detalles, cantidad, disenio, costo)
            If resultado = -1 Then
                LabelError.Text = "ERROR AL ACTUALIZAR LA INFORMACION"
            Else
                MsgBox("Información actualizada")
                Me.Close()
            End If
        Else
            Dim al As New Album(detalles, cantidad, disenio, costo)
            al.idDataGrid = a.idDataGrid
            serviNuevo.ModificarAlbum(al)
            Me.Close()
        End If


    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles textBoxDetalles.KeyDown, textBoxCantidad.KeyDown, textBoxDisenio.KeyDown, textBoxCosto.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            modificarAlbum()
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