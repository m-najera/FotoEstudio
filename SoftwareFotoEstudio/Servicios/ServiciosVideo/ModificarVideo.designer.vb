<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModificarVideo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxLocacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxEvento = New System.Windows.Forms.TextBox()
        Me.TextBoxCosto = New System.Windows.Forms.TextBox()
        Me.BottonAceptar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxFormatoEntrega = New System.Windows.Forms.TextBox()
        Me.TextBoxCopias = New System.Windows.Forms.TextBox()
        Me.TextBoxDetalles = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxDuracion = New System.Windows.Forms.TextBox()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.DateTimePickerFechaHora = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(21, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 15)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Formato de Entrega"
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.Color.White
        Me.ButtonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelar.ForeColor = System.Drawing.Color.Black
        Me.ButtonCancelar.Location = New System.Drawing.Point(231, 458)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(87, 27)
        Me.ButtonCancelar.TabIndex = 11
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(21, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Evento"
        '
        'TextBoxLocacion
        '
        Me.TextBoxLocacion.Location = New System.Drawing.Point(188, 61)
        Me.TextBoxLocacion.Name = "TextBoxLocacion"
        Me.TextBoxLocacion.Size = New System.Drawing.Size(173, 21)
        Me.TextBoxLocacion.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(21, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Copias"
        '
        'TextBoxEvento
        '
        Me.TextBoxEvento.Location = New System.Drawing.Point(188, 23)
        Me.TextBoxEvento.Name = "TextBoxEvento"
        Me.TextBoxEvento.Size = New System.Drawing.Size(173, 21)
        Me.TextBoxEvento.TabIndex = 1
        '
        'TextBoxCosto
        '
        Me.TextBoxCosto.Location = New System.Drawing.Point(188, 213)
        Me.TextBoxCosto.Name = "TextBoxCosto"
        Me.TextBoxCosto.Size = New System.Drawing.Size(173, 21)
        Me.TextBoxCosto.TabIndex = 6
        '
        'BottonAceptar
        '
        Me.BottonAceptar.BackColor = System.Drawing.Color.White
        Me.BottonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BottonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BottonAceptar.ForeColor = System.Drawing.Color.Black
        Me.BottonAceptar.Location = New System.Drawing.Point(102, 458)
        Me.BottonAceptar.Name = "BottonAceptar"
        Me.BottonAceptar.Size = New System.Drawing.Size(87, 27)
        Me.BottonAceptar.TabIndex = 10
        Me.BottonAceptar.Text = "Aceptar"
        Me.BottonAceptar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Costo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Locación"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(21, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 15)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Fecha y Hora del Evento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(21, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 15)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Fecha de Entrega"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(21, 330)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 15)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Detalles"
        '
        'TextBoxFormatoEntrega
        '
        Me.TextBoxFormatoEntrega.Location = New System.Drawing.Point(188, 137)
        Me.TextBoxFormatoEntrega.Name = "TextBoxFormatoEntrega"
        Me.TextBoxFormatoEntrega.Size = New System.Drawing.Size(173, 21)
        Me.TextBoxFormatoEntrega.TabIndex = 4
        '
        'TextBoxCopias
        '
        Me.TextBoxCopias.Location = New System.Drawing.Point(188, 175)
        Me.TextBoxCopias.Name = "TextBoxCopias"
        Me.TextBoxCopias.Size = New System.Drawing.Size(173, 21)
        Me.TextBoxCopias.TabIndex = 5
        '
        'TextBoxDetalles
        '
        Me.TextBoxDetalles.Location = New System.Drawing.Point(185, 330)
        Me.TextBoxDetalles.Multiline = True
        Me.TextBoxDetalles.Name = "TextBoxDetalles"
        Me.TextBoxDetalles.Size = New System.Drawing.Size(173, 73)
        Me.TextBoxDetalles.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(21, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 15)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Duracion"
        '
        'TextBoxDuracion
        '
        Me.TextBoxDuracion.Location = New System.Drawing.Point(188, 99)
        Me.TextBoxDuracion.Name = "TextBoxDuracion"
        Me.TextBoxDuracion.Size = New System.Drawing.Size(126, 21)
        Me.TextBoxDuracion.TabIndex = 3
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(21, 392)
        Me.LabelError.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(0, 15)
        Me.LabelError.TabIndex = 85
        '
        'DateTimePickerFechaHora
        '
        Me.DateTimePickerFechaHora.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFechaHora.Location = New System.Drawing.Point(188, 249)
        Me.DateTimePickerFechaHora.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePickerFechaHora.Name = "DateTimePickerFechaHora"
        Me.DateTimePickerFechaHora.Size = New System.Drawing.Size(173, 21)
        Me.DateTimePickerFechaHora.TabIndex = 7
        '
        'DateTimePickerFechaEntrega
        '
        Me.DateTimePickerFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFechaEntrega.Location = New System.Drawing.Point(188, 287)
        Me.DateTimePickerFechaEntrega.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePickerFechaEntrega.Name = "DateTimePickerFechaEntrega"
        Me.DateTimePickerFechaEntrega.Size = New System.Drawing.Size(170, 21)
        Me.DateTimePickerFechaEntrega.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(21, 419)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "TEXTO ERROR"
        Me.Label1.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(321, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 15)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Horas"
        '
        'ModificarVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 498)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePickerFechaEntrega)
        Me.Controls.Add(Me.DateTimePickerFechaHora)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.TextBoxDuracion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBoxDetalles)
        Me.Controls.Add(Me.TextBoxCopias)
        Me.Controls.Add(Me.TextBoxFormatoEntrega)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxLocacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxEvento)
        Me.Controls.Add(Me.TextBoxCosto)
        Me.Controls.Add(Me.BottonAceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ModificarVideo"
        Me.Text = "ModificarVideo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxLocacion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxEvento As TextBox
    Friend WithEvents TextBoxCosto As TextBox
    Friend WithEvents BottonAceptar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxFormatoEntrega As TextBox
    Friend WithEvents TextBoxCopias As TextBox
    Friend WithEvents TextBoxDetalles As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxDuracion As TextBox
    Friend WithEvents LabelError As Label
    Friend WithEvents DateTimePickerFechaHora As DateTimePicker
    Friend WithEvents DateTimePickerFechaEntrega As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
End Class
