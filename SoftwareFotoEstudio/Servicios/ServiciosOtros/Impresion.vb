Public Class Impresion
    Public idDataGrid As Integer = -1
    Public tamanio As String
    Public detalles As String
    Public fechaEntrega As String
    Public papel As String
    Public costo As Integer


    Public Sub New(tamanio As String, detalles As String, fechaEntrega As String, papel As String,
                   costo As Integer)
        Me.tamanio = tamanio
        Me.fechaEntrega = fechaEntrega
        Me.papel = papel
        Me.costo = costo
        Me.detalles = detalles
    End Sub
End Class
