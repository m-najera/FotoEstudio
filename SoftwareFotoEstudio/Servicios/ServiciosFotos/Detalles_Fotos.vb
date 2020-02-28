Public Class Detalles_Fotos
    Private idServicioFoto As String

    Dim conexion As New BDConexionesFotos



    Private Sub Detalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As DataSet
        data = conexion.ObtenerFotos(idServicioFoto)
        LabelIdTicket.Text = data.Tables(0).Rows(0).Item(1)
        LabelTamaño.Text = data.Tables(0).Rows(0).Item(2)
        LabelCantidad.Text = data.Tables(0).Rows(0).Item(3)
        LabelFecEntrega.Text = data.Tables(0).Rows(0).Item(4)
        LabelPapel.Text = data.Tables(0).Rows(0).Item(5)
        Labelcolor.Text = data.Tables(0).Rows(0).Item(6)
        LabelCosto.Text = data.Tables(0).Rows(0).Item(7)
        LabelDetalles.Text = data.Tables(0).Rows(0).Item(8)

    End Sub
    Public Sub New(idfoto As String, ref As Form)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.idServicioFoto = idfoto
        Me.Owner = ref
    End Sub

    Private Sub form_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Me.Owner.Enabled = True
        Me.Owner.Focus()
    End Sub

    Private Sub form_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Owner.Enabled = False
    End Sub

End Class