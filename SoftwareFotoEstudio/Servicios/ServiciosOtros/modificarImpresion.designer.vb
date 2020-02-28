<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificarImpresion
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
        Me.LabelError = New System.Windows.Forms.Label()
        Me.textBoxTamanio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textBoxPapel = New System.Windows.Forms.TextBox()
        Me.textBoxFecha = New System.Windows.Forms.TextBox()
        Me.textBoxDetalles = New System.Windows.Forms.TextBox()
        Me.BottonAceptar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textBoxCosto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(64, 237)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(85, 13)
        Me.LabelError.TabIndex = 85
        Me.LabelError.Text = "TEXTO ERROR"
        Me.LabelError.Visible = False
        '
        'textBoxTamanio
        '
        Me.textBoxTamanio.Location = New System.Drawing.Point(178, 69)
        Me.textBoxTamanio.Name = "textBoxTamanio"
        Me.textBoxTamanio.Size = New System.Drawing.Size(186, 20)
        Me.textBoxTamanio.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Tamaño"
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonCancelar.Location = New System.Drawing.Point(235, 263)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 7
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Fecha de Entrega"
        '
        'textBoxPapel
        '
        Me.textBoxPapel.Location = New System.Drawing.Point(178, 163)
        Me.textBoxPapel.Name = "textBoxPapel"
        Me.textBoxPapel.Size = New System.Drawing.Size(186, 20)
        Me.textBoxPapel.TabIndex = 4
        '
        'textBoxFecha
        '
        Me.textBoxFecha.Location = New System.Drawing.Point(178, 131)
        Me.textBoxFecha.Name = "textBoxFecha"
        Me.textBoxFecha.Size = New System.Drawing.Size(186, 20)
        Me.textBoxFecha.TabIndex = 3
        '
        'textBoxDetalles
        '
        Me.textBoxDetalles.Location = New System.Drawing.Point(178, 99)
        Me.textBoxDetalles.Name = "textBoxDetalles"
        Me.textBoxDetalles.Size = New System.Drawing.Size(186, 20)
        Me.textBoxDetalles.TabIndex = 2
        '
        'BottonAceptar
        '
        Me.BottonAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.BottonAceptar.Location = New System.Drawing.Point(106, 263)
        Me.BottonAceptar.Name = "BottonAceptar"
        Me.BottonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BottonAceptar.TabIndex = 6
        Me.BottonAceptar.Text = "Aceptar"
        Me.BottonAceptar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Papel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Detalles"
        '
        'textBoxCosto
        '
        Me.textBoxCosto.Location = New System.Drawing.Point(178, 195)
        Me.textBoxCosto.Name = "textBoxCosto"
        Me.textBoxCosto.Size = New System.Drawing.Size(186, 20)
        Me.textBoxCosto.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Costo"
        '
        'modificarImpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 409)
        Me.Controls.Add(Me.textBoxCosto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.textBoxTamanio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textBoxPapel)
        Me.Controls.Add(Me.textBoxFecha)
        Me.Controls.Add(Me.textBoxDetalles)
        Me.Controls.Add(Me.BottonAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "modificarImpresion"
        Me.Text = "modificarImpresion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelError As Label
    Friend WithEvents textBoxTamanio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents textBoxPapel As TextBox
    Friend WithEvents textBoxFecha As TextBox
    Friend WithEvents textBoxDetalles As TextBox
    Friend WithEvents BottonAceptar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents textBoxCosto As TextBox
    Friend WithEvents Label3 As Label
End Class
