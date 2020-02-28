Public Class Modificar_Fotos
    Private idServicioFoto As String = ""
    Private idTicket As String = ""
    Dim conexion As New BDConexionesFotos
    Dim serviNuevo As ServiciosNuevo
    Dim servBuscar As ServicioBuscarTicket
    Dim f As Foto

    Private Sub FotosModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If idServicioFoto <> "" Then
            Try
                Dim data As DataSet
                data = conexion.ObtenerFotos(idServicioFoto)
                ComboBoxTamañoMidificar.Text = data.Tables(0).Rows(0).Item(2)
                TextBoxCantidadModificar.Text = data.Tables(0).Rows(0).Item(3)
                DateTimePickerFechaEntrega.Value = data.Tables(0).Rows(0).Item(4)
                ComboBoxPapelModificar.Text = data.Tables(0).Rows(0).Item(4)
                If data.Tables(0).Rows(0).Item(6) = 1 Then
                    CheckBoxBN.Checked = True
                Else
                    CheckBoxBN.Checked = False
                End If
                TextBoxCostoModificar.Text = data.Tables(0).Rows(0).Item(7)
                TextBoxDetallesModificar.Text = data.Tables(0).Rows(0).Item(8)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            ComboBoxPapelModificar.Text = f.papel
            ComboBoxTamañoMidificar.Text = f.tamanio
            TextBoxCantidadModificar.Text = f.cantidad
            DateTimePickerFechaEntrega.Value = f.fechaEntrega
            CheckBoxBN.Checked = f.bn
            TextBoxCostoModificar.Text = f.costo
            TextBoxDetallesModificar.Text = f.detalles
        End If
    End Sub
    Public Sub New(idF As String, ref As ServicioBuscarTicket)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.idServicioFoto = idF
        Me.Owner = ref
        Me.servBuscar = ref
    End Sub

    Public Sub New(serv As ServiciosNuevo, f As Foto)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.f = f
        Me.Owner = serv
        Me.serviNuevo = serv
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelarModificar.Click
        Me.Close()
    End Sub

    Private Sub ButtonAceptarModificar_Click(sender As Object, e As EventArgs) Handles ButtonAceptarModificar.Click
        Modificar()

    End Sub

    Private Sub Modificar()
        If TextBoxCantidadModificar.Text = "" Or TextBoxCostoModificar.Text = "" Or
        ComboBoxTamañoMidificar.Text = "" Or ComboBoxPapelModificar.Text = "" Then
            LabelErrorModificar.Text = "DEBE LLENAR TODOS LOS CAMPOS"
            LabelErrorModificar.Visible = True
            Return
        End If

        'validar los campos numericos
        If Not IsNumeric(TextBoxCantidadModificar.Text) Or Not IsNumeric(TextBoxCostoModificar.Text) Then
            LabelErrorModificar.Text = "EL VALOR DEBE SER NUMERICO"
            LabelErrorModificar.Visible = True
            Return
        End If

        'validar el tamaño de los enteros
        If TextBoxCantidadModificar.Text.Length > 10 Or TextBoxCostoModificar.Text.Length > 10 Then
            LabelErrorModificar.Text = "EL VALOR ES DEMASIADO GRANDE"
            LabelErrorModificar.Visible = True
            Return
        End If

        Dim tamanio As String = ComboBoxTamañoMidificar.Text
        Dim cantidad As String = TextBoxCantidadModificar.Text
        Dim fechaEntrega As String = Format(DateTimePickerFechaEntrega.Value, "yyyy/MM/dd")
        Dim papel As String = ComboBoxPapelModificar.Text
        Dim bn As Integer = 0
        If CheckBoxBN.Checked Then
            bn = 1
        End If
        Dim costo As String = TextBoxCostoModificar.Text
        Dim detalles As String = TextBoxDetallesModificar.Text

        If idServicioFoto <> "" Then
            Dim resultado As Integer
            resultado = conexion.Modificar_fotos(idServicioFoto, cantidad, fechaEntrega, bn, costo, detalles)
            If resultado = -1 Then
                LabelErrorModificar.Text = "ERROR AL MODIFICAR"
                LabelErrorModificar.Visible = True
            Else
                MsgBox("Modificado")
                Me.Close()
            End If
        Else
            Dim newFoto As New Foto(tamanio, cantidad, fechaEntrega, papel, bn, costo, detalles)
            newFoto.idDataGrid = f.idDataGrid
            serviNuevo.ModificarFoto(newFoto)
        End If
        Me.Close()

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