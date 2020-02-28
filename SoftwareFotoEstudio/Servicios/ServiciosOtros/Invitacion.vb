Public Class Invitacion
    Public idDataGrid As Integer = -1
    Public detalles As String
    Public papel As String
    Public cantidad As String
    Public costo As Integer


    Public Sub New(detalles As String, papel As String, cantidad As String,
                   costo As Integer)
        Me.cantidad = cantidad
        Me.papel = papel
        Me.costo = costo
        Me.detalles = detalles
    End Sub
End Class
