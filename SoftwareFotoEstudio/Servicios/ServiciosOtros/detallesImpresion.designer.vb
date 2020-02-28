<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detallesImpresion
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTamanio = New System.Windows.Forms.TextBox()
        Me.txtDetalles = New System.Windows.Forms.TextBox()
        Me.txtFechaEntrega = New System.Windows.Forms.TextBox()
        Me.txtPapel = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(28, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tamaño"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(28, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Detalles"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(15, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha Entrega"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(28, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Papel"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(28, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Costo          $"
        '
        'txtTamanio
        '
        Me.txtTamanio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtTamanio.Location = New System.Drawing.Point(98, 32)
        Me.txtTamanio.Name = "txtTamanio"
        Me.txtTamanio.Size = New System.Drawing.Size(100, 21)
        Me.txtTamanio.TabIndex = 3
        '
        'txtDetalles
        '
        Me.txtDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtDetalles.Location = New System.Drawing.Point(98, 59)
        Me.txtDetalles.Multiline = True
        Me.txtDetalles.Name = "txtDetalles"
        Me.txtDetalles.Size = New System.Drawing.Size(100, 60)
        Me.txtDetalles.TabIndex = 4
        '
        'txtFechaEntrega
        '
        Me.txtFechaEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtFechaEntrega.Location = New System.Drawing.Point(98, 133)
        Me.txtFechaEntrega.Name = "txtFechaEntrega"
        Me.txtFechaEntrega.Size = New System.Drawing.Size(100, 21)
        Me.txtFechaEntrega.TabIndex = 5
        '
        'txtPapel
        '
        Me.txtPapel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtPapel.Location = New System.Drawing.Point(98, 164)
        Me.txtPapel.Name = "txtPapel"
        Me.txtPapel.Size = New System.Drawing.Size(100, 21)
        Me.txtPapel.TabIndex = 6
        '
        'txtCosto
        '
        Me.txtCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtCosto.Location = New System.Drawing.Point(98, 193)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(100, 21)
        Me.txtCosto.TabIndex = 7
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.White
        Me.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnRegresar.Location = New System.Drawing.Point(110, 250)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 9
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'detallesImpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(250, 311)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.txtPapel)
        Me.Controls.Add(Me.txtFechaEntrega)
        Me.Controls.Add(Me.txtDetalles)
        Me.Controls.Add(Me.txtTamanio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "detallesImpresion"
        Me.Text = "detallesImpresion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTamanio As TextBox
    Friend WithEvents txtDetalles As TextBox
    Friend WithEvents txtFechaEntrega As TextBox
    Friend WithEvents txtPapel As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents btnRegresar As Button
End Class
