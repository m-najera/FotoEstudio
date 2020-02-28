<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarVideo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxEvento = New System.Windows.Forms.TextBox()
        Me.TextBoxLocacion = New System.Windows.Forms.TextBox()
        Me.TextBoxDuracion = New System.Windows.Forms.TextBox()
        Me.TextBoxFormato = New System.Windows.Forms.TextBox()
        Me.TextBoxCopias = New System.Windows.Forms.TextBox()
        Me.TextBoxCosto = New System.Windows.Forms.TextBox()
        Me.TextBoxDetalles = New System.Windows.Forms.TextBox()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimeFechaHora = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha de entrega"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = " Detalles"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Evento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(23, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Locacion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(23, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Formato de entrega"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(23, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Fecha del evento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(23, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Costo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(23, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 15)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Numero de copias"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(23, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Duracion"
        '
        'TextBoxEvento
        '
        Me.TextBoxEvento.Location = New System.Drawing.Point(168, 26)
        Me.TextBoxEvento.Name = "TextBoxEvento"
        Me.TextBoxEvento.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxEvento.TabIndex = 1
        '
        'TextBoxLocacion
        '
        Me.TextBoxLocacion.Location = New System.Drawing.Point(168, 59)
        Me.TextBoxLocacion.Name = "TextBoxLocacion"
        Me.TextBoxLocacion.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxLocacion.TabIndex = 2
        '
        'TextBoxDuracion
        '
        Me.TextBoxDuracion.Location = New System.Drawing.Point(168, 92)
        Me.TextBoxDuracion.Name = "TextBoxDuracion"
        Me.TextBoxDuracion.Size = New System.Drawing.Size(87, 21)
        Me.TextBoxDuracion.TabIndex = 3
        '
        'TextBoxFormato
        '
        Me.TextBoxFormato.Location = New System.Drawing.Point(168, 125)
        Me.TextBoxFormato.Name = "TextBoxFormato"
        Me.TextBoxFormato.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxFormato.TabIndex = 4
        '
        'TextBoxCopias
        '
        Me.TextBoxCopias.Location = New System.Drawing.Point(167, 158)
        Me.TextBoxCopias.Name = "TextBoxCopias"
        Me.TextBoxCopias.Size = New System.Drawing.Size(201, 21)
        Me.TextBoxCopias.TabIndex = 5
        '
        'TextBoxCosto
        '
        Me.TextBoxCosto.Location = New System.Drawing.Point(167, 191)
        Me.TextBoxCosto.Name = "TextBoxCosto"
        Me.TextBoxCosto.Size = New System.Drawing.Size(201, 21)
        Me.TextBoxCosto.TabIndex = 6
        '
        'TextBoxDetalles
        '
        Me.TextBoxDetalles.Location = New System.Drawing.Point(166, 290)
        Me.TextBoxDetalles.Multiline = True
        Me.TextBoxDetalles.Name = "TextBoxDetalles"
        Me.TextBoxDetalles.Size = New System.Drawing.Size(202, 62)
        Me.TextBoxDetalles.TabIndex = 9
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardar.Location = New System.Drawing.Point(107, 418)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(87, 27)
        Me.ButtonGuardar.TabIndex = 10
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelar.Location = New System.Drawing.Point(224, 418)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(87, 27)
        Me.ButtonCancelar.TabIndex = 11
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(25, 374)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelError.Size = New System.Drawing.Size(109, 17)
        Me.LabelError.TabIndex = 29
        Me.LabelError.Text = "TEXTO ERROR"
        Me.LabelError.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(261, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Horas"
        '
        'DateTimeFechaHora
        '
        Me.DateTimeFechaHora.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFechaHora.Location = New System.Drawing.Point(166, 224)
        Me.DateTimeFechaHora.Name = "DateTimeFechaHora"
        Me.DateTimeFechaHora.Size = New System.Drawing.Size(202, 21)
        Me.DateTimeFechaHora.TabIndex = 7
        '
        'DateTimeFechaEntrega
        '
        Me.DateTimeFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFechaEntrega.Location = New System.Drawing.Point(166, 257)
        Me.DateTimeFechaEntrega.Name = "DateTimeFechaEntrega"
        Me.DateTimeFechaEntrega.Size = New System.Drawing.Size(202, 21)
        Me.DateTimeFechaEntrega.TabIndex = 8
        '
        'AgregarVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(411, 465)
        Me.Controls.Add(Me.DateTimeFechaEntrega)
        Me.Controls.Add(Me.DateTimeFechaHora)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.Controls.Add(Me.TextBoxDetalles)
        Me.Controls.Add(Me.TextBoxCosto)
        Me.Controls.Add(Me.TextBoxCopias)
        Me.Controls.Add(Me.TextBoxFormato)
        Me.Controls.Add(Me.TextBoxDuracion)
        Me.Controls.Add(Me.TextBoxLocacion)
        Me.Controls.Add(Me.TextBoxEvento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "AgregarVideo"
        Me.Text = "AgregarVideo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxEvento As TextBox
    Friend WithEvents TextBoxLocacion As TextBox
    Friend WithEvents TextBoxDuracion As TextBox
    Friend WithEvents TextBoxFormato As TextBox
    Friend WithEvents TextBoxCopias As TextBox
    Friend WithEvents TextBoxCosto As TextBox
    Friend WithEvents TextBoxDetalles As TextBox
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents LabelError As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimeFechaHora As DateTimePicker
    Friend WithEvents DateTimeFechaEntrega As DateTimePicker
End Class
