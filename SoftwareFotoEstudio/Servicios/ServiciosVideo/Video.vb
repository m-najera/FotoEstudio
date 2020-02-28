Public Class Video
    Public idDataGrid As Integer
    Public evento As String
    Public locacion As String
    Public duracion As String
    Public formatoEntrega As String
    Public copias As Integer
    Public costo As Integer
    Public fechaHoraEvento As String
    Public fechaEntrega As String
    Public detalles As String

    Public Sub New(evento As String, locacion As String, duracion As String, formatoEntrega As String,
                   copias As Integer, costo As Integer, fechaHoraEvento As String, fechaEntrega As String,
                   detalles As String)
        Me.evento = evento
        Me.locacion = locacion
        Me.duracion = duracion
        Me.formatoEntrega = formatoEntrega
        Me.copias = copias
        Me.costo = costo
        Me.fechaHoraEvento = fechaHoraEvento
        Me.fechaEntrega = fechaEntrega
        Me.detalles = detalles
    End Sub

End Class
