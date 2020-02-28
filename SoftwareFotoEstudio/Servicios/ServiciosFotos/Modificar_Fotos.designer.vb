<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Fotos
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
        Me.ButtonCancelarModificar = New System.Windows.Forms.Button()
        Me.ButtonAceptarModificar = New System.Windows.Forms.Button()
        Me.TextBoxCostoModificar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxDetallesModificar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCantidadModificar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxTamañoMidificar = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPapelModificar = New System.Windows.Forms.ComboBox()
        Me.LabelErrorModificar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBoxBN = New System.Windows.Forms.CheckBox()
        Me.DateTimePickerFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'ButtonCancelarModificar
        '
        Me.ButtonCancelarModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonCancelarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelarModificar.Location = New System.Drawing.Point(192, 228)
        Me.ButtonCancelarModificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonCancelarModificar.Name = "ButtonCancelarModificar"
        Me.ButtonCancelarModificar.Size = New System.Drawing.Size(70, 28)
        Me.ButtonCancelarModificar.TabIndex = 9
        Me.ButtonCancelarModificar.Text = "Cancelar"
        Me.ButtonCancelarModificar.UseVisualStyleBackColor = True
        '
        'ButtonAceptarModificar
        '
        Me.ButtonAceptarModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonAceptarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAceptarModificar.Location = New System.Drawing.Point(85, 228)
        Me.ButtonAceptarModificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonAceptarModificar.Name = "ButtonAceptarModificar"
        Me.ButtonAceptarModificar.Size = New System.Drawing.Size(70, 28)
        Me.ButtonAceptarModificar.TabIndex = 8
        Me.ButtonAceptarModificar.Text = "Aceptar"
        Me.ButtonAceptarModificar.UseVisualStyleBackColor = True
        '
        'TextBoxCostoModificar
        '
        Me.TextBoxCostoModificar.Location = New System.Drawing.Point(121, 140)
        Me.TextBoxCostoModificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxCostoModificar.Name = "TextBoxCostoModificar"
        Me.TextBoxCostoModificar.Size = New System.Drawing.Size(151, 20)
        Me.TextBoxCostoModificar.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 140)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Costo"
        '
        'TextBoxDetallesModificar
        '
        Me.TextBoxDetallesModificar.Location = New System.Drawing.Point(121, 162)
        Me.TextBoxDetallesModificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxDetallesModificar.Multiline = True
        Me.TextBoxDetallesModificar.Name = "TextBoxDetallesModificar"
        Me.TextBoxDetallesModificar.Size = New System.Drawing.Size(151, 19)
        Me.TextBoxDetallesModificar.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 162)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Detalles"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Tamaño"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 75)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Fecha de Entrega"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 94)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Papel"
        '
        'TextBoxCantidadModificar
        '
        Me.TextBoxCantidadModificar.Location = New System.Drawing.Point(121, 49)
        Me.TextBoxCantidadModificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxCantidadModificar.Name = "TextBoxCantidadModificar"
        Me.TextBoxCantidadModificar.Size = New System.Drawing.Size(151, 20)
        Me.TextBoxCantidadModificar.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Cantidad"
        '
        'ComboBoxTamañoMidificar
        '
        Me.ComboBoxTamañoMidificar.FormattingEnabled = True
        Me.ComboBoxTamañoMidificar.Items.AddRange(New Object() {"Infantil", "Diplomado", "Cartilla"})
        Me.ComboBoxTamañoMidificar.Location = New System.Drawing.Point(121, 23)
        Me.ComboBoxTamañoMidificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxTamañoMidificar.Name = "ComboBoxTamañoMidificar"
        Me.ComboBoxTamañoMidificar.Size = New System.Drawing.Size(151, 21)
        Me.ComboBoxTamañoMidificar.TabIndex = 1
        '
        'ComboBoxPapelModificar
        '
        Me.ComboBoxPapelModificar.FormattingEnabled = True
        Me.ComboBoxPapelModificar.Items.AddRange(New Object() {"Mate", "Fotografico"})
        Me.ComboBoxPapelModificar.Location = New System.Drawing.Point(121, 94)
        Me.ComboBoxPapelModificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxPapelModificar.Name = "ComboBoxPapelModificar"
        Me.ComboBoxPapelModificar.Size = New System.Drawing.Size(151, 21)
        Me.ComboBoxPapelModificar.TabIndex = 4
        '
        'LabelErrorModificar
        '
        Me.LabelErrorModificar.AutoSize = True
        Me.LabelErrorModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorModificar.ForeColor = System.Drawing.Color.Red
        Me.LabelErrorModificar.Location = New System.Drawing.Point(43, 196)
        Me.LabelErrorModificar.Name = "LabelErrorModificar"
        Me.LabelErrorModificar.Size = New System.Drawing.Size(85, 13)
        Me.LabelErrorModificar.TabIndex = 74
        Me.LabelErrorModificar.Text = "TEXTO ERROR"
        Me.LabelErrorModificar.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 117)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Blanco y Negro"
        '
        'CheckBoxBN
        '
        Me.CheckBoxBN.AutoSize = True
        Me.CheckBoxBN.Location = New System.Drawing.Point(121, 120)
        Me.CheckBoxBN.Name = "CheckBoxBN"
        Me.CheckBoxBN.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxBN.TabIndex = 5
        Me.CheckBoxBN.UseVisualStyleBackColor = True
        '
        'DateTimePickerFechaEntrega
        '
        Me.DateTimePickerFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFechaEntrega.Location = New System.Drawing.Point(121, 74)
        Me.DateTimePickerFechaEntrega.Name = "DateTimePickerFechaEntrega"
        Me.DateTimePickerFechaEntrega.Size = New System.Drawing.Size(151, 20)
        Me.DateTimePickerFechaEntrega.TabIndex = 3
        '
        'Modificar_Fotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(311, 279)
        Me.Controls.Add(Me.DateTimePickerFechaEntrega)
        Me.Controls.Add(Me.CheckBoxBN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelErrorModificar)
        Me.Controls.Add(Me.ComboBoxPapelModificar)
        Me.Controls.Add(Me.ComboBoxTamañoMidificar)
        Me.Controls.Add(Me.ButtonCancelarModificar)
        Me.Controls.Add(Me.ButtonAceptarModificar)
        Me.Controls.Add(Me.TextBoxCostoModificar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxDetallesModificar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxCantidadModificar)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Modificar_Fotos"
        Me.Text = "Modificar_Fotos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCancelarModificar As Button
    Friend WithEvents ButtonAceptarModificar As Button
    Friend WithEvents TextBoxCostoModificar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxDetallesModificar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCantidadModificar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxTamañoMidificar As ComboBox
    Friend WithEvents ComboBoxPapelModificar As ComboBox
    Friend WithEvents LabelErrorModificar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBoxBN As CheckBox
    Friend WithEvents DateTimePickerFechaEntrega As DateTimePicker
End Class
