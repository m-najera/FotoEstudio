Public Class Edicion
    Public idDataGrid As Integer = -1
    Public detalles As String
    Public fechaEntrega As String
    Public tamanio As String
    Public costo As Integer


    Public Sub New(detalles As String, fechaEntrega As String, tamanio As String,
                   costo As Integer)
        Me.detalles = detalles
        Me.fechaEntrega = fechaEntrega
        Me.tamanio = tamanio
        Me.costo = costo

    End Sub
End Class
