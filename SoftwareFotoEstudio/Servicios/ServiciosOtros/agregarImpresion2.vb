Public Class agregarImpresion2
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
        Dim tamanio As String = textBoxTamanio.Text
        Dim detalles As String = textBoxDetalle.Text
        Dim fecha As String = Format(DateTimePicker1.Value, "yyyy/MM/dd")
        Dim papel As String = textBoxPapel.Text

        Dim costo As Integer = textBoxCosto.Text
        'Dim resultado As Integer
        'resultado = conexion.agregarImpresion(tamanio, detalles, fecha, papel, costo)

        Dim i As New Impresion(tamanio, detalles, fecha, papel, costo)
        serviNuevo.agregarImpresion(i)
        Me.Close()


    End Sub

    Private Sub botonCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
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