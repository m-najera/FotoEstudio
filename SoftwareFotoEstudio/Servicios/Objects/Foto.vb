Public Class Foto
    Dim tamanio As String
    Dim cantidad As Integer
    Dim fechaEntrega As Date
    Dim papel As String
    Dim bn As Boolean
    Dim costo As Integer
    Dim detalles As String

    Public Sub New(tamanio As String, cantidad As Integer, fechaEntrega As Date, papel As String,
                   bn As Boolean, costo As Integer, detalles As String)
        Me.tamanio = tamanio
        Me.cantidad = cantidad
        Me.fechaEntrega = fechaEntrega
        Me.papel = papel
        Me.bn = bn
        Me.costo = costo
        Me.detalles = detalles
    End Sub
End Class
