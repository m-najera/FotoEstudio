' Autor: Urivan Rubio Garcia
' Descripción: Ventana Agregar del módulo Clientes. Permite registrar un nuevo cliente del sistema
' Fecha de última modificación: 04/11/2018

Imports MySql.Data

Public Class ClientesAgregar
    Private conexion As New BDConexiones
    Dim nombre As String
    Dim apellidos As String
    Dim domicilio As String
    Dim telefono As String
    Dim email As String

    Private Sub BottonGuardar_Click(sender As Object, e As EventArgs) Handles BottonGuardar.Click
        nombre = CajaNombre.Text.ToString
        apellidos = CajaApellidos.Text.ToString
        domicilio = CajaDomicilio.Text.ToString
        telefono = CajaTelefono.Text.ToString
        email = CajaEmail.Text.ToString

        If nombre = "" Or apellidos = "" Or domicilio = "" Or telefono = "" Or email = "" Then
            TextoError.Visible = True
            TextoError.Text = "DEBE LLENAR TODOS LOS CAMPOS"
            Return
        Else
            'agregar cliente
            Dim resultado As Integer
            resultado = conexion.AgregarCliente(nombre, apellidos, domicilio, telefono, email)
            Me.Close()
        End If


    End Sub

    Public Sub New(parent As ClientesPrincipal)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Owner = parent
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
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