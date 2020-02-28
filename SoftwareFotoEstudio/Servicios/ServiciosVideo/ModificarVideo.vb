Public Class ModificarVideo
    Private idVideo As String = ""
    Dim conexion As New conexionBDVideo
    Dim serviNuevo As ServiciosNuevo
    Dim servBuscar As ServicioBuscarTicket
    Dim v As Video

    Private Sub ModificarVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If idVideo <> "" Then
            Dim data As DataSet
            data = conexion.ObtenerVideo(idVideo)
            TextBoxEvento.Text = data.Tables(0).Rows(0).Item(2)
            TextBoxLocacion.Text = data.Tables(0).Rows(0).Item(3)
            TextBoxDuracion.Text = data.Tables(0).Rows(0).Item(4)
            TextBoxFormatoEntrega.Text = data.Tables(0).Rows(0).Item(5)
            TextBoxCopias.Text = data.Tables(0).Rows(0).Item(6)
            TextBoxCosto.Text = data.Tables(0).Rows(0).Item(7)
            DateTimePickerFechaHora.Value = data.Tables(0).Rows(0).Item(8)
            DateTimePickerFechaEntrega.Value = data.Tables(0).Rows(0).Item(9)
            TextBoxDetalles.Text = data.Tables(0).Rows(0).Item(10)
        Else
            TextBoxEvento.Text = v.evento
            TextBoxLocacion.Text = v.locacion
            TextBoxDuracion.Text = v.duracion
            TextBoxFormatoEntrega.Text = v.formatoEntrega
            TextBoxCopias.Text = v.copias
            TextBoxCosto.Text = v.costo
            DateTimePickerFechaHora.Text = v.fechaHoraEvento
            DateTimePickerFechaEntrega.Text = v.fechaEntrega
            TextBoxDetalles.Text = v.detalles
        End If

    End Sub

    Public Sub New(id As String, ref As ServicioBuscarTicket)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.idVideo = id
        Me.Owner = ref
        servBuscar = ref
    End Sub

    Public Sub New(ref As ServiciosNuevo, v As Video)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        serviNuevo = ref
        Me.v = v
        Me.Owner = ref
    End Sub


    Private Sub BottonAceptar_Click(sender As Object, e As EventArgs) Handles BottonAceptar.Click
        'Valida si los campos estan vacios'
        If TextBoxEvento.Text = "" Or TextBoxLocacion.Text = "" Or TextBoxDuracion.Text = "" Or
            TextBoxFormatoEntrega.Text = "" Or TextBoxCopias.Text = "" Or TextBoxCosto.Text = "" Then
            LabelError.Text = "DEBE LLENAR TODOS LOS CAMPOS"
            LabelError.Visible = True
            Return
        End If

        'Si ingresa un valor numerico nvalido'
        If Not IsNumeric(TextBoxCosto.Text) Then
            LabelError.Text = "EL VALOR DEBE SER NUMÉRICO"
            LabelError.Visible = True
            Return
        End If
        'Si el valor es muy grande'
        If TextBoxCosto.Text.Length > 6 Then
            LabelError.Text = "EL COSTO ES DEMACIADO GRANDE"
            LabelError.Visible = True
            Return
        End If
        'Si la duracion es demaciado extensa'
        If TextBoxCosto.Text.Length > 10 Then
            LabelError.Text = "LA DURACION ES DEMACIADO GRANDE"
            LabelError.Visible = True
            Return
        End If
        'Si el numerode copias es muy grnde'
        If TextBoxDuracion.Text.Length > 10 Then
            LabelError.Text = "EL NUMERO DE COPIAS ES DEMACIADO GRANDE"
            LabelError.Visible = True
            Return
        End If

        ModificarVideo()
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub ModificarVideo()
        Dim evento As String = TextBoxEvento.Text
        Dim locacion As String = TextBoxLocacion.Text
        Dim duracion As Integer = TextBoxDuracion.Text
        Dim formatoEntrega As String = TextBoxFormatoEntrega.Text
        Dim copias As Integer = TextBoxCopias.Text
        Dim costo As Integer = TextBoxCosto.Text
        Dim fechaHora As String = Format(DateTimePickerFechaHora.Value.Date, "yyyy/MM/dd")
        Dim fechaEntrega As String = Format(DateTimePickerFechaEntrega.Value.Date, "yyyy/MM/dd")
        Dim detalles As String = TextBoxDetalles.Text
        If idVideo <> "" Then
            Dim resultado As Integer
            resultado = conexion.ActualizarVideo(idVideo, evento, locacion, duracion, formatoEntrega, copias, costo, fechaHora, fechaEntrega, detalles)
        Else
            serviNuevo.ModificarVideo(New Video(evento, locacion, duracion, formatoEntrega, copias,
                                            costo, fechaHora, fechaEntrega, detalles))
        End If
        Me.Close()
    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles  TextBoxEvento.KeyDown, TextBoxLocacion.KeyDown, TextBoxCosto.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            ModificarVideo()
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


