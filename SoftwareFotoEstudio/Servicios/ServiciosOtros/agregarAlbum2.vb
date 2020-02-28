Public Class agregarAlbum2
    Private conexion As New BDconexionesOtros
    Private contenidoNivel As New ArrayList
    Public serviNuevo As ServiciosNuevo

    Public Sub New(ref As ServiciosNuevo)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Owner = ref
        serviNuevo = ref
    End Sub

    Private Sub botonAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If textBoxDisenio.Text = "" Or textBoxCantidad.Text = "" Or textBoxCosto.Text = "" Then
            LabelError.Text = "DEBE LLENAR TODOS LOS CAMPOS"
            Return
        End If
        If Not IsNumeric(textBoxCantidad.Text) Or Not IsNumeric(textBoxCosto.Text) Then
            LabelError.Text = "EL VALOR DEBE DE SER NUMERICO"
            LabelError.Visible = True
            Return
        End If

        Dim detalles As String = textBoxDetalle.Text
        Dim cantidad As String = textBoxCantidad.Text
        Dim disenio As String = textBoxDisenio.Text
        Dim costo As Integer = textBoxCosto.Text
        'Dim resultado As Integer
        'resultado = conexion.agregarAlbum(detalles, cantidad, disenio, costo)

        Dim a As New Album(detalles, cantidad, disenio, costo)
        serviNuevo.agregarAlbum(a)
        Me.Close()


    End Sub

    Private Sub botonCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub agregarAlbum2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub form_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Me.Owner.Enabled = True
        Me.Owner.Focus()
    End Sub

    Private Sub form_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Owner.Enabled = False
    End Sub
End Class