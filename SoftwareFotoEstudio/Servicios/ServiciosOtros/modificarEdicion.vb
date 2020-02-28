Public Class modificarEdicion
    Private idEdicion As String = ""
    Dim conexion As New BDconexionesOtros
    Dim serviNuevo As ServiciosNuevo
    Dim servBuscar As ServicioBuscarTicket
    Dim ed As Edicion

    Private Sub modificarEdicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If idEdicion <> "" Then
            Dim data As DataSet
            data = conexion.obtenerDetallesEdicion(idEdicion)
            textBoxDetalles.Text = data.Tables(0).Rows(0).Item(2)
            textBoxFecha.Text = data.Tables(0).Rows(0).Item(3)
            textBoxTamanio.Text = data.Tables(0).Rows(0).Item(4)
            textBoxCosto.Text = data.Tables(0).Rows(0).Item(5)
        Else
            textBoxDetalles.Text = ed.detalles
            textBoxFecha.Text = ed.fechaEntrega
            textBoxTamanio.Text = ed.tamanio
            textBoxCosto.Text = ed.costo

        End If

    End Sub

    Public Sub New(idE As String, ref As ServicioBuscarTicket)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.idEdicion = idE
        Me.Owner = ref
        servBuscar = ref
    End Sub

    Public Sub New(serv As ServiciosNuevo, ed As Edicion)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ed = ed
        Me.Owner = serv
        serviNuevo = serv
    End Sub

    Private Sub BottonAceptar_Click(sender As Object, e As EventArgs) Handles BottonAceptar.Click
        modificarEdicion()
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub modificarEdicion()
        If textBoxDetalles.Text = "" Or
            textBoxFecha.Text = "" Or
            textBoxTamanio.Text = "" Or
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

        Dim detalles As String = textBoxDetalles.Text
        Dim fecha As String = textBoxFecha.Text
        Dim tamanio As String = textBoxTamanio.Text
        Dim costo As String = textBoxCosto.Text

        If idEdicion <> "" Then
            Dim resultado As Integer
            resultado = conexion.actualizarEdicion(idEdicion, detalles, fecha, tamanio, costo)
            If resultado = -1 Then
                LabelError.Text = "ERROR AL ACTUALIZAR LA INFORMACION"
            Else
                MsgBox("Información actualizada")
                Me.Close()
            End If
        Else
            Dim edi As New Edicion(detalles, fecha, tamanio, costo)
            edi.idDataGrid = ed.idDataGrid
            serviNuevo.ModificarEdicion(edi)
            Me.Close()
        End If
    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles textBoxDetalles.KeyDown, textBoxFecha.KeyDown, textBoxTamanio.KeyDown, textBoxCosto.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            modificarEdicion()
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