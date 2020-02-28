﻿Public Class detallesImpresion
    Private idImpresion As String
    Dim conexion As New BDconexionesOtros

    Public Sub New(id As String, ref As Form)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Owner = ref
        idImpresion = id
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub

    Private Sub detallesImpresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As DataSet
        data = conexion.obtenerDetallesImpresion(idImpresion)
        txtTamanio.Text = data.Tables(0).Rows(0).Item(2)
        txtDetalles.Text = data.Tables(0).Rows(0).Item(3)
        txtFechaEntrega.Text = data.Tables(0).Rows(0).Item(4)
        txtPapel.Text = data.Tables(0).Rows(0).Item(5)
        txtCosto.Text = data.Tables(0).Rows(0).Item(6)
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