Public Class modificarImpresion
    Private idImpresion As String = ""
    Dim conexion As New BDconexionesOtros
    Dim serviNuevo As ServiciosNuevo
    Dim servBuscar As ServicioBuscarTicket
    Dim i As Impresion

    Private Sub modificarImpresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If idImpresion <> "" Then
            Try
                Dim data As DataSet
                data = conexion.obtenerDetallesImpresion(idImpresion)
                textBoxTamanio.Text = data.Tables(0).Rows(0).Item(2)
                textBoxDetalles.Text = data.Tables(0).Rows(0).Item(3)
                textBoxFecha.Text = data.Tables(0).Rows(0).Item(4)
                textBoxPapel.Text = data.Tables(0).Rows(0).Item(5)
                textBoxCosto.Text = data.Tables(0).Rows(0).Item(6)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            textBoxTamanio.Text = i.tamanio
            textBoxDetalles.Text = i.detalles
            textBoxFecha.Text = i.fechaEntrega
            textBoxPapel.Text = i.papel
            textBoxCosto.Text = i.costo
        End If

    End Sub

    Public Sub New(idI As String, ref As ServicioBuscarTicket)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.idImpresion = idI
        Me.Owner = ref
        servBuscar = ref
    End Sub

    Public Sub New(serv As ServiciosNuevo, i As Impresion)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.i = i
        Me.Owner = serv
        serviNuevo = serv
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs)
        textBoxTamanio.Enabled = True
        textBoxTamanio.ReadOnly = False
        textBoxDetalles.Enabled = True
        textBoxDetalles.ReadOnly = False
        textBoxFecha.Enabled = True
        textBoxFecha.ReadOnly = False
        textBoxPapel.Enabled = True
        textBoxPapel.ReadOnly = False
        textBoxCosto.Enabled = True
        textBoxCosto.ReadOnly = False
    End Sub

    Private Sub BottonAceptar_Click(sender As Object, e As EventArgs) Handles BottonAceptar.Click
        modificarImpresion()
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub modificarImpresion()
        If textBoxDetalles.Text = "" Or
            textBoxTamanio.Text = "" Or
            textBoxFecha.Text = "" Or
            textBoxPapel.Text = "" Or
            textBoxCosto.Text = "" Then
            LabelError.Text = "DEBE LLENAR TODOS LOS CAMPOS"
            Return
        End If

        If Not IsNumeric(textBoxTamanio.Text & textBoxCosto.Text) Then
            LabelError.Text = "EL VALOR DEBE SER NUMERICO"
            LabelError.Visible = True
            Return
        End If

        If textBoxTamanio.Text.Length > 10 Then
            LabelError.Text = "LA CANTIDAD ES DEMASIADO GRANDE"
            LabelError.Visible = True
            Return
        End If

        If textBoxCosto.Text.Length > 6 Then
            LabelError.Text = "EL COSTO ES DEMASIADO GRANDE"
            LabelError.Visible = True
            Return
        End If
        Dim tamanio As String = textBoxTamanio.Text
        Dim detalles As String = textBoxDetalles.Text
        Dim fecha As String = textBoxFecha.Text
        Dim papel As String = textBoxPapel.Text
        Dim costo As String = textBoxCosto.Text

        If idImpresion <> "" Then
            Dim resultado As Integer
            resultado = conexion.actualizarImpresion(idImpresion, tamanio, detalles, fecha, papel, costo)

            If resultado = -1 Then
                LabelError.Text = "ERROR AL ACTUALIZAR LA INFORMACION"
            Else
                MsgBox("Información actualizada")
                Me.Close()
            End If
        Else
            Dim im As New Impresion(tamanio, detalles, fecha, papel, costo)
            im.idDataGrid = i.idDataGrid
            serviNuevo.ModificarImpresion(im)
            Me.Close()
        End If
    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles textBoxDetalles.KeyDown, textBoxFecha.KeyDown, textBoxTamanio.KeyDown, textBoxCosto.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            modificarImpresion()
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