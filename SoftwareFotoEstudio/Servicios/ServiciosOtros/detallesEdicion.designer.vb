<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detallesEdicion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDetalles = New System.Windows.Forms.TextBox()
        Me.txtFechaEntrega = New System.Windows.Forms.TextBox()
        Me.txtTamanio = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Detalles"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de Entrega"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tamaño"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Costo         $"
        '
        'txtDetalles
        '
        Me.txtDetalles.Location = New System.Drawing.Point(111, 32)
        Me.txtDetalles.Multiline = True
        Me.txtDetalles.Name = "txtDetalles"
        Me.txtDetalles.Size = New System.Drawing.Size(100, 77)
        Me.txtDetalles.TabIndex = 3
        '
        'txtFechaEntrega
        '
        Me.txtFechaEntrega.Location = New System.Drawing.Point(111, 118)
        Me.txtFechaEntrega.Name = "txtFechaEntrega"
        Me.txtFechaEntrega.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaEntrega.TabIndex = 4
        '
        'txtTamanio
        '
        Me.txtTamanio.Location = New System.Drawing.Point(111, 144)
        Me.txtTamanio.Name = "txtTamanio"
        Me.txtTamanio.Size = New System.Drawing.Size(100, 20)
        Me.txtTamanio.TabIndex = 5
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(111, 170)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(100, 20)
        Me.txtCosto.TabIndex = 6
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(111, 226)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 8
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'detallesEdicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 268)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.txtTamanio)
        Me.Controls.Add(Me.txtFechaEntrega)
        Me.Controls.Add(Me.txtDetalles)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "detallesEdicion"
        Me.Text = "Detalles Edicion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDetalles As TextBox
    Friend WithEvents txtFechaEntrega As TextBox
    Friend WithEvents txtTamanio As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents btnRegresar As Button
End Class
