<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Agregar_Fotos
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
        Me.TextBoxCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxDetalles = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxCosto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.DateTimePickerFecEntrega = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxTamaño = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPapel = New System.Windows.Forms.ComboBox()
        Me.LabelErrorAgregar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBoxBN = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.Location = New System.Drawing.Point(164, 58)
        Me.TextBoxCantidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.Size = New System.Drawing.Size(203, 22)
        Me.TextBoxCantidad.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Papel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Fecha de Entrega"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tamaño"
        '
        'TextBoxDetalles
        '
        Me.TextBoxDetalles.Location = New System.Drawing.Point(164, 193)
        Me.TextBoxDetalles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxDetalles.Name = "TextBoxDetalles"
        Me.TextBoxDetalles.Size = New System.Drawing.Size(203, 22)
        Me.TextBoxDetalles.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Detalles"
        '
        'TextBoxCosto
        '
        Me.TextBoxCosto.Location = New System.Drawing.Point(164, 165)
        Me.TextBoxCosto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxCosto.Name = "TextBoxCosto"
        Me.TextBoxCosto.Size = New System.Drawing.Size(203, 22)
        Me.TextBoxCosto.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Costo"
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAceptar.Location = New System.Drawing.Point(135, 290)
        Me.ButtonAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(83, 32)
        Me.ButtonAceptar.TabIndex = 8
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelar.Location = New System.Drawing.Point(260, 290)
        Me.ButtonCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(83, 32)
        Me.ButtonCancelar.TabIndex = 9
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'DateTimePickerFecEntrega
        '
        Me.DateTimePickerFecEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFecEntrega.Location = New System.Drawing.Point(164, 86)
        Me.DateTimePickerFecEntrega.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerFecEntrega.Name = "DateTimePickerFecEntrega"
        Me.DateTimePickerFecEntrega.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerFecEntrega.TabIndex = 3
        '
        'ComboBoxTamaño
        '
        Me.ComboBoxTamaño.FormattingEnabled = True
        Me.ComboBoxTamaño.Items.AddRange(New Object() {"Infantil", "Diplomado", "Cartilla"})
        Me.ComboBoxTamaño.Location = New System.Drawing.Point(164, 28)
        Me.ComboBoxTamaño.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxTamaño.Name = "ComboBoxTamaño"
        Me.ComboBoxTamaño.Size = New System.Drawing.Size(203, 24)
        Me.ComboBoxTamaño.TabIndex = 1
        '
        'ComboBoxPapel
        '
        Me.ComboBoxPapel.FormattingEnabled = True
        Me.ComboBoxPapel.Items.AddRange(New Object() {"Mate", "Fotografico"})
        Me.ComboBoxPapel.Location = New System.Drawing.Point(164, 114)
        Me.ComboBoxPapel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxPapel.Name = "ComboBoxPapel"
        Me.ComboBoxPapel.Size = New System.Drawing.Size(200, 24)
        Me.ComboBoxPapel.TabIndex = 4
        '
        'LabelErrorAgregar
        '
        Me.LabelErrorAgregar.AutoSize = True
        Me.LabelErrorAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorAgregar.ForeColor = System.Drawing.Color.Red
        Me.LabelErrorAgregar.Location = New System.Drawing.Point(57, 250)
        Me.LabelErrorAgregar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelErrorAgregar.Name = "LabelErrorAgregar"
        Me.LabelErrorAgregar.Size = New System.Drawing.Size(109, 17)
        Me.LabelErrorAgregar.TabIndex = 74
        Me.LabelErrorAgregar.Text = "TEXTO ERROR"
        Me.LabelErrorAgregar.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Blanco y Negro"
        '
        'CheckBoxBN
        '
        Me.CheckBoxBN.AutoSize = True
        Me.CheckBoxBN.Location = New System.Drawing.Point(164, 144)
        Me.CheckBoxBN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxBN.Name = "CheckBoxBN"
        Me.CheckBoxBN.Size = New System.Drawing.Size(18, 17)
        Me.CheckBoxBN.TabIndex = 5
        Me.CheckBoxBN.UseVisualStyleBackColor = True
        '
        'Agregar_Fotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(435, 361)
        Me.Controls.Add(Me.CheckBoxBN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelErrorAgregar)
        Me.Controls.Add(Me.ComboBoxPapel)
        Me.Controls.Add(Me.ComboBoxTamaño)
        Me.Controls.Add(Me.DateTimePickerFecEntrega)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.TextBoxCosto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxDetalles)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxCantidad)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Agregar_Fotos"
        Me.Text = "FotosAgregar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxCantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxDetalles As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxCosto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents DateTimePickerFecEntrega As DateTimePicker
    Friend WithEvents ComboBoxTamaño As ComboBox
    Friend WithEvents ComboBoxPapel As ComboBox
    Friend WithEvents LabelErrorAgregar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBoxBN As CheckBox
End Class
