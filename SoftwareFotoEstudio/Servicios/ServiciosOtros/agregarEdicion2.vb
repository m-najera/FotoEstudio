Public Class agregarEdicion2

    Private conexion As New BDconexionesOtros
    Public serviNuevo As ServiciosNuevo

    Public Sub New(ref As ServiciosNuevo)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Owner = ref
        serviNuevo = ref
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If textBoxDetalle.Text = "" Or textBoxTamanio.Text = "" Or textBoxCosto.Text = "" Then
            LabelError.Text = "DEBE LLENAR TODOS LOS CAMPOS"
            Return
        End If
        If Not IsNumeric(textBoxCosto.Text) Or Not IsNumeric(textBoxCosto.Text) Then
            LabelError.Text = "COSTO DEBE SER UN NUMERO"
            Return
        End If

        Dim detalles As String = textBoxDetalle.Text
        Dim fechaEntrega As String = Format(DateTimePickerEntrega.Value, "yyyy/MM/dd")
        Dim tamanio As String = textBoxTamanio.Text
        Dim costo As Integer = textBoxCosto.Text
        'Dim resultado As Integer
        'resultado = conexion.agregarEdicion(detalles, fechaEntrega, tamanio, costo)

        Dim ed As New Edicion(detalles, fechaEntrega, tamanio, costo)
        serviNuevo.agregarEdicion(ed)
        Me.Close()


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub form_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Me.Owner.Enabled = True
        Me.Owner.Focus()
    End Sub

    Private Sub form_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Owner.Enabled = False
    End Sub
End Class

