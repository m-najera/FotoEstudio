Public Class agregarInvitaciones2
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
        Dim detalles As String = textBoxDetalle.Text
        Dim papel As String = textBoxPapel.Text
        Dim cantidad As String = textBoxCantidad.Text
        Dim costo As Integer = textBoxCosto.Text
        'Dim resultado As Integer
        'resultado = conexion.agregarInvitacion(detalles, papel, cantidad, costo)

        Dim i As New Invitacion(detalles, papel, cantidad, costo)
        serviNuevo.agregarInvitacion(i)
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

    Private Sub agregarInvitaciones2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class