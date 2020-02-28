<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarInvitaciones2
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
        Me.textBoxCantidad = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textBoxDetalle = New System.Windows.Forms.TextBox()
        Me.textBoxPapel = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'textBoxCosto
        '
        Me.textBoxCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.textBoxCosto.Location = New System.Drawing.Point(101, 171)
        Me.textBoxCosto.Name = "textBoxCosto"
        Me.textBoxCosto.Size = New System.Drawing.Size(186, 21)
        Me.textBoxCosto.TabIndex = 4
        '
        'textBoxCantidad
        '
        Me.textBoxCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.textBoxCantidad.Location = New System.Drawing.Point(101, 137)
        Me.textBoxCantidad.Name = "textBoxCantidad"
        Me.textBoxCantidad.Size = New System.Drawing.Size(186, 21)
        Me.textBoxCantidad.TabIndex = 3
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnCancelar.Location = New System.Drawing.Point(212, 248)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 30)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(34, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Cantidad"
        '
        'textBoxDetalle
        '
        Me.textBoxDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.textBoxDetalle.Location = New System.Drawing.Point(101, 33)
        Me.textBoxDetalle.Multiline = True
        Me.textBoxDetalle.Name = "textBoxDetalle"
        Me.textBoxDetalle.Size = New System.Drawing.Size(186, 58)
        Me.textBoxDetalle.TabIndex = 1
        '
        'textBoxPapel
        '
        Me.textBoxPapel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.textBoxPapel.Location = New System.Drawing.Point(101, 104)
        Me.textBoxPapel.Name = "textBoxPapel"
        Me.textBoxPapel.Size = New System.Drawing.Size(186, 21)
        Me.textBoxPapel.TabIndex = 2
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnAgregar.Location = New System.Drawing.Point(101, 248)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 30)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(34, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 15)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Detalles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(34, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Costo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(34, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Papel"
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(54, 209)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(85, 13)
        Me.LabelError.TabIndex = 94
        Me.LabelError.Text = "TEXTO ERROR"
        Me.LabelError.Visible = False
        '
        'agregarInvitaciones2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(364, 290)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.textBoxCosto)
        Me.Controls.Add(Me.textBoxCantidad)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textBoxDetalle)
        Me.Controls.Add(Me.textBoxPapel)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "agregarInvitaciones2"
        Me.Text = "agregarInvitaciones2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textBoxCosto As TextBox
    Friend WithEvents textBoxCantidad As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents textBoxDetalle As TextBox
    Friend WithEvents textBoxPapel As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelError As Label
End Class
