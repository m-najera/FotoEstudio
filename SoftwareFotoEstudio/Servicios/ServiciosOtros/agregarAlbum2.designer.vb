<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarAlbum2
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
        Me.textBoxCosto = New System.Windows.Forms.TextBox()
        Me.textBoxDisenio = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textBoxDetalle = New System.Windows.Forms.TextBox()
        Me.textBoxCantidad = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'textBoxCosto
        '
        Me.textBoxCosto.Location = New System.Drawing.Point(126, 162)
        Me.textBoxCosto.Name = "textBoxCosto"
        Me.textBoxCosto.Size = New System.Drawing.Size(186, 20)
        Me.textBoxCosto.TabIndex = 4
        '
        'textBoxDisenio
        '
        Me.textBoxDisenio.Location = New System.Drawing.Point(126, 130)
        Me.textBoxDisenio.Name = "textBoxDisenio"
        Me.textBoxDisenio.Size = New System.Drawing.Size(186, 20)
        Me.textBoxDisenio.TabIndex = 3
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(191, 238)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 109
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Diseño"
        '
        'textBoxDetalle
        '
        Me.textBoxDetalle.Location = New System.Drawing.Point(126, 18)
        Me.textBoxDetalle.Multiline = True
        Me.textBoxDetalle.Name = "textBoxDetalle"
        Me.textBoxDetalle.Size = New System.Drawing.Size(186, 69)
        Me.textBoxDetalle.TabIndex = 1
        '
        'textBoxCantidad
        '
        Me.textBoxCantidad.Location = New System.Drawing.Point(126, 93)
        Me.textBoxCantidad.Name = "textBoxCantidad"
        Me.textBoxCantidad.Size = New System.Drawing.Size(186, 20)
        Me.textBoxCantidad.TabIndex = 2
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(56, 238)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 108
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Detalles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Costo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Cantidad"
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(46, 196)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(85, 13)
        Me.LabelError.TabIndex = 117
        Me.LabelError.Text = "TEXTO ERROR"
        Me.LabelError.Visible = False
        '
        'agregarAlbum2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(355, 309)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.textBoxCosto)
        Me.Controls.Add(Me.textBoxDisenio)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textBoxDetalle)
        Me.Controls.Add(Me.textBoxCantidad)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "agregarAlbum2"
        Me.Text = "agregarAlbum2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textBoxCosto As TextBox
    Friend WithEvents textBoxDisenio As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents textBoxDetalle As TextBox
    Friend WithEvents textBoxCantidad As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelError As Label
End Class
