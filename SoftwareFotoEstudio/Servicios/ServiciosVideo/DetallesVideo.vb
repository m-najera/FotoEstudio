Public Class DetallesVideo

    Private idVideo As String
    Dim mensaje As String
    Dim conexion As New conexionBDVideo


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Me.Close()
    End Sub

    Public Sub New(id As String, ref As Form)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Owner = ref
        Me.idVideo = id
    End Sub

    Private Sub DetallesVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If idVideo <> "" Then
            Try
                Dim data As DataSet
                MsgBox(idVideo)
                data = conexion.ObtenerVideo(idVideo)
                LabelEvento.Text = data.Tables(0).Rows(0).Item(2)
                LabelLocacion.Text = data.Tables(0).Rows(0).Item(3)
                LabelDuracion.Text = data.Tables(0).Rows(0).Item(4)
                LabelFormato.Text = data.Tables(0).Rows(0).Item(5)
                LabelCopias.Text = data.Tables(0).Rows(0).Item(6)
                LabelCosto.Text = data.Tables(0).Rows(0).Item(7)
                LabelDate.Text = data.Tables(0).Rows(0).Item(8)
                LabelEntrega.Text = data.Tables(0).Rows(0).Item(9)
                LabelDetalles.Text = data.Tables(0).Rows(0).Item(10)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Form_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Owner.Enabled = False
        Me.Focus()
    End Sub

    Private Sub Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim a As ServicioBuscarTicket = Me.Owner
        a.ListarServicios()
        Owner.Enabled = True
    End Sub
End Class