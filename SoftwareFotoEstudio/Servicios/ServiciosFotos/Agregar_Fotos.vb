Public Class Agregar_Fotos
    Private conexion As New BDConexionesFotos
    Public serviNuevo As ServiciosNuevo

    Public Sub New(ref As ServiciosNuevo)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Owner = ref
        serviNuevo = ref
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        'Validar que los campos no esten vacios antes de registrar un servicio de fotos
        If TextBoxCantidad.Text = "" Or TextBoxCosto.Text = "" Then
            LabelErrorAgregar.Text = "DEBE LLENAR TODOS LOS CAMPOS"
            LabelErrorAgregar.Visible = True
            Return
        End If
        'Validar que los campos sean numericos
        If Not IsNumeric(TextBoxCantidad.Text) Or Not IsNumeric(TextBoxCosto.Text) Then
            LabelErrorAgregar.Text = "EL VALOR DEBE SER NUMERICO"
            LabelErrorAgregar.Visible = True
            Return
        End If
        If TextBoxCantidad.Text.Length > 10 Or TextBoxCosto.Text.Length > 10 Then
            LabelErrorAgregar.Text = "EL VALOR ES DEMASIADO GRANDE"
            LabelErrorAgregar.Visible = True
            Return
        End If

        Dim tamanio As String = ComboBoxTamaño.Text
        Dim cantidad As String = TextBoxCantidad.Text
        Dim fechaEntrega As String = Format(DateTimePickerFecEntrega.Value, "yyyy/MM/dd")
        Dim papel As String = ComboBoxPapel.Text
        Dim bn As Integer = CheckBoxBN.Checked
        Dim costo As String = TextBoxCosto.Text
        Dim detalles As String = TextBoxDetalles.Text
        If CheckBoxBN.Checked = True Then
            bn = 1
        Else
            bn = 0
        End If

        Dim f As New Foto(tamanio, cantidad, fechaEntrega, papel, bn, costo, detalles)
        serviNuevo.agregarFoto(f)
        Me.Close()
        'Agregar fotos
        'Dim resultado As Integer
        'resultado = conexion.AgregarFotos(idticket, tamaño, cantidad, fechaEntrega, papelselect, bn, costo, detalles)

        'If resultado = -1 Then
        '    LabelErrorAgregar.Text = "ERROR AL AGREGAR"
        '    LabelErrorAgregar.Visible = True
        'Else
        '    Me.Close()
        'End If
    End Sub
    Private Sub Agregar_Fotos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxPapel.SelectedIndex = 0
        ComboBoxTamaño.SelectedIndex = 0

    End Sub
    Private Sub Agregar_Fotos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Me.TopMost = True
        Me.Owner.Enabled = False
    End Sub
    Private Sub Agregar_Fotos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Owner.Enabled = True
        Me.Owner.Focus()
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

End Class