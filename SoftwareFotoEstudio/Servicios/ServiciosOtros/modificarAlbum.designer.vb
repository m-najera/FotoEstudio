<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificarAlbum
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textBoxDisenio = New System.Windows.Forms.TextBox()
        Me.textBoxCantidad = New System.Windows.Forms.TextBox()
        Me.textBoxDetalles = New System.Windows.Forms.TextBox()
        Me.BottonAceptar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'textBoxCosto
        '
        Me.textBoxCosto.Location = New System.Drawing.Point(139, 141)
        Me.textBoxCosto.Name = "textBoxCosto"
        Me.textBoxCosto.Size = New System.Drawing.Size(186, 20)
        Me.textBoxCosto.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Costo"
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(25, 175)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(85, 13)
        Me.LabelError.TabIndex = 98
        Me.LabelError.Text = "TEXTO ERROR"
        Me.LabelError.Visible = False
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.Color.White
        Me.ButtonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonCancelar.Location = New System.Drawing.Point(249, 208)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 6
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Cantidad"
        '
        'textBoxDisenio
        '
        Me.textBoxDisenio.Location = New System.Drawing.Point(139, 110)
        Me.textBoxDisenio.Name = "textBoxDisenio"
        Me.textBoxDisenio.Size = New System.Drawing.Size(186, 20)
        Me.textBoxDisenio.TabIndex = 3
        '
        'textBoxCantidad
        '
        Me.textBoxCantidad.Location = New System.Drawing.Point(139, 77)
        Me.textBoxCantidad.Name = "textBoxCantidad"
        Me.textBoxCantidad.Size = New System.Drawing.Size(186, 20)
        Me.textBoxCantidad.TabIndex = 2
        '
        'textBoxDetalles
        '
        Me.textBoxDetalles.Location = New System.Drawing.Point(139, 46)
        Me.textBoxDetalles.Name = "textBoxDetalles"
        Me.textBoxDetalles.Size = New System.Drawing.Size(186, 20)
        Me.textBoxDetalles.TabIndex = 1
        '
        'BottonAceptar
        '
        Me.BottonAceptar.BackColor = System.Drawing.Color.White
        Me.BottonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BottonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BottonAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BottonAceptar.Location = New System.Drawing.Point(139, 208)
        Me.BottonAceptar.Name = "BottonAceptar"
        Me.BottonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BottonAceptar.TabIndex = 5
        Me.BottonAceptar.Text = "Aceptar"
        Me.BottonAceptar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Diseño"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Detalles"
        '
        'modificarAlbum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(348, 306)
        Me.Controls.Add(Me.textBoxCosto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textBoxDisenio)
        Me.Controls.Add(Me.textBoxCantidad)
        Me.Controls.Add(Me.textBoxDetalles)
        Me.Controls.Add(Me.BottonAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "modificarAlbum"
        Me.Text = "modificarAlbum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textBoxCosto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelError As Label
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents textBoxDisenio As TextBox
    Friend WithEvents textBoxCantidad As TextBox
    Friend WithEvents textBoxDetalles As TextBox
    Friend WithEvents BottonAceptar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
