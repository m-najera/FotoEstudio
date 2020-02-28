Public Class Foto
    Public idDataGrid As Integer
    Public tamanio As String
    Public cantidad As Integer
    Public fechaEntrega As Date
    Public papel As String
    Public bn As Integer
    Public costo As Integer
    Public detalles As String

    Public Sub New(tamanio As String, cantidad As Integer, fechaEntrega As Date, papel As String,
                   bn As Integer, costo As Integer, detalles As String)
        Me.tamanio = tamanio
        Me.cantidad = cantidad
        Me.fechaEntrega = fechaEntrega
        Me.papel = papel
        Me.bn = bn
        Me.costo = costo
        Me.detalles = detalles
    End Sub
End Class
