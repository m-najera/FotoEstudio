Public Class ClientesModificar
    Private idCliente As String
    Dim conexion As New BDConexiones

    Private Sub ClientesModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As DataSet
        data = conexion.ObtenerCliente(idCliente)
        CajaNombre.Text = data.Tables(0).Rows(0).Item(1)
        CajaApellidos.Text = data.Tables(0).Rows(0).Item(2)
        CajaDomicilio.Text = data.Tables(0).Rows(0).Item(3)
        CajaTelefono.Text = data.Tables(0).Rows(0).Item(4)
        CajaEmail.Text = data.Tables(0).Rows(0).Item(5)

        CajaNombre.Enabled = True
        CajaNombre.ReadOnly = False
        CajaApellidos.Enabled = True
        CajaApellidos.ReadOnly = False
        CajaDomicilio.Enabled = True
        CajaDomicilio.ReadOnly = False
        CajaTelefono.Enabled = True
        CajaTelefono.ReadOnly = False
        CajaEmail.Enabled = True
        CajaEmail.ReadOnly = False
    End Sub

    Public Sub New(idC As String, parent As ClientesPrincipal)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.idCliente = idC
        Me.Owner = parent
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BottonAceptar_Click(sender As Object, e As EventArgs) Handles BottonAceptar.Click
        ModificarCliente()
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub ModificarCliente()
        Dim nombre As String = CajaNombre.Text
        Dim apellidos As String = CajaApellidos.Text
        Dim domicilio As String = CajaDomicilio.Text
        Dim telefono As String = CajaTelefono.Text
        Dim correo As String = CajaEmail.Text

        If nombre = "" Or apellidos = "" Or domicilio = "" Or telefono = "" Or correo = "" Then
            LabelError.Visible = True
            LabelError.Text = "DEBE LLENAR TODOS LOS CAMPOS"
            Return
        Else
            'modificar
            Dim resultado As Integer
            resultado = conexion.ActualizarCliente(idCliente, nombre, apellidos, domicilio, telefono, correo)
            If resultado = -1 Then
                LabelError.Text = "ERROR AL ACTUALIZAR LA INFORMACION"
            Else
                LabelError.Text = "Información actualizada"
                Me.Close()
            End If
        End If
    End Sub

    Private Sub form_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Me.Owner.Enabled = True
        Me.Owner.Focus()
    End Sub

    Private Sub form_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Owner.Enabled = False
    End Sub
End Class