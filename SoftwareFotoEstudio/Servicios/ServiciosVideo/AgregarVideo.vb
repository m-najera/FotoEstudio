' Autor: Adriana Hernendez
' Descripción: Ventana Agregar del módulo Video. Permite registrar un nuevo pedido en el sistema
' Fecha de última modificación: 30/11/2018

Public Class AgregarVideo
    Private conexion As New conexionBDVideo
    Private serviNuevo As ServiciosNuevo

    Public Sub New(ref As ServiciosNuevo)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        serviNuevo = ref
        Me.Owner = ref
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        'Valida si los campos estan vacios
        If TextBoxEvento.Text = "" Or
            TextBoxLocacion.Text = "" Or TextBoxDuracion.Text = "" Or TextBoxFormato.Text = "" Or
            TextBoxCopias.Text = "" Or TextBoxCosto.Text = "" Then
            LabelError.Visible = True
            LabelError.Text = "DEBE LLENAR TODOS LOS CAMPOS"
            Return
        End If

        'Si ingresa un valor numérico invalido(Ej.100a)
        If Not IsNumeric(TextBoxCosto.Text) Then
            LabelError.Text = "EL COSTO DEBE SER NUMERICO"
            LabelError.Visible = True
            Return
        End If
        'Si el valor es muy grande
        If TextBoxCosto.Text.Length > 6 Then
            LabelError.Text = "EL COSTO ES DEMACIADO GRANDE"
            LabelError.Visible = True
            Return
        End If

        If TextBoxDuracion.Text.Length > 10 Then
            LabelError.Text = "LA DURACIÓN ES DEMACIADO GRANDE"
            LabelError.Visible = True
            Return

        End If
        If TextBoxCopias.Text.Length > 10 Then
            LabelError.Text = "EL NÚMERO COPIAS ES DEMACIADO GRANDE"
            LabelError.Visible = True
            Return
        End If

        Dim evento As String = TextBoxEvento.Text
        Dim locacion As String = TextBoxLocacion.Text
        Dim duracion As Integer = TextBoxDuracion.Text
        Dim formatoEntrega As String = TextBoxFormato.Text
        Dim copias As Integer = TextBoxCopias.Text
        Dim costo As Integer = TextBoxCosto.Text
        Dim fechaHoraEvento As String = DateTimeFechaHora.Text
        Dim fechaEntrega As String = DateTimeFechaEntrega.Text
        Dim detalles As String = TextBoxDetalles.Text

        fechaHoraEvento = DateTimeFechaHora.Value.Year.ToString & "-" &
            DateTimeFechaHora.Value.Month.ToString & "-" &
            DateTimeFechaHora.Value.Day.ToString

        fechaEntrega = DateTimeFechaEntrega.Value.Year.ToString & "-" &
            DateTimeFechaEntrega.Value.Month.ToString & "-" &
            DateTimeFechaEntrega.Value.Day.ToString

        Dim v As New Video(evento, locacion, duracion,
                           formatoEntrega, copias, costo, fechaHoraEvento, fechaEntrega, detalles)
        serviNuevo.agregarVideo(v)
        Me.Close()


        'Agregar Video
        'Dim resultado As Integer
        'resultado = conexion.AgregarVideo(idservicioVideo, idticket, evento,
        '                                  locacion, duracion, formatoEntrega,
        '                                  copias, costo, fechaHoraEvento, fechaEntrega, detalles)

        'If resultado = -1 Then
        '    LabelError.Text = "ERROR AL AGREGAR"
        '    LabelError.Visible = True
        'Else
        '    MessageBox.Show("Video Agregado")
        '    Me.Close()
        'End If
    End Sub

    Private Sub FormActivated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Me.TopMost = True
        Me.Owner.Enabled = False
    End Sub
    Private Sub aFormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Owner.Enabled = True
        Me.Owner.Focus()
    End Sub
End Class