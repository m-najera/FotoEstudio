Public Class Album
    Public idDataGrid As Integer = -1
    Public detalles As String
    Public cantidad As String
    Public diseno As String
    Public costo As Integer


    Public Sub New(detalles As String, cantidad As String, diseno As String,
                   costo As Integer)
        Me.cantidad = cantidad
        Me.diseno = diseno
        Me.costo = costo
        Me.detalles = detalles
    End Sub
End Class
