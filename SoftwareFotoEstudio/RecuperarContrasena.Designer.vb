<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecuperarContrasena
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecuperarContrasena))
        Me.LabelError = New System.Windows.Forms.Label()
        Me.ComboBoxPregunta = New System.Windows.Forms.ComboBox()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxConfirmarContr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxContr = New System.Windows.Forms.TextBox()
        Me.TextBoxRespuesta = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(17, 219)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(85, 13)
        Me.LabelError.TabIndex = 87
        Me.LabelError.Text = "TEXTO ERROR"
        Me.LabelError.Visible = False
        '
        'ComboBoxPregunta
        '
        Me.ComboBoxPregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPregunta.FormattingEnabled = True
        Me.ComboBoxPregunta.Items.AddRange(New Object() {"¿Cuál es tu comida favorita?", "¿Cuál es tu película favorita?", "¿Nombre de tu primer mascota?", "¿Cuál es tu canción favorita?", "¿Cómo se llamaba tu escuela primaria?"})
        Me.ComboBoxPregunta.Location = New System.Drawing.Point(131, 85)
        Me.ComboBoxPregunta.Name = "ComboBoxPregunta"
        Me.ComboBoxPregunta.Size = New System.Drawing.Size(186, 21)
        Me.ComboBoxPregunta.TabIndex = 78
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.Color.White
        Me.ButtonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelar.Location = New System.Drawing.Point(188, 249)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 86
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Nueva Contraseña"
        '
        'TextBoxConfirmarContr
        '
        Me.TextBoxConfirmarContr.Location = New System.Drawing.Point(131, 186)
        Me.TextBoxConfirmarContr.Name = "TextBoxConfirmarContr"
        Me.TextBoxConfirmarContr.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxConfirmarContr.TabIndex = 77
        Me.TextBoxConfirmarContr.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Pregunta de Seguridad"
        '
        'TextBoxContr
        '
        Me.TextBoxContr.Location = New System.Drawing.Point(131, 154)
        Me.TextBoxContr.Name = "TextBoxContr"
        Me.TextBoxContr.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxContr.TabIndex = 76
        Me.TextBoxContr.UseSystemPasswordChar = True
        '
        'TextBoxRespuesta
        '
        Me.TextBoxRespuesta.Location = New System.Drawing.Point(130, 118)
        Me.TextBoxRespuesta.Name = "TextBoxRespuesta"
        Me.TextBoxRespuesta.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxRespuesta.TabIndex = 79
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(131, 50)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxNombre.TabIndex = 75
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.BackColor = System.Drawing.Color.White
        Me.ButtonAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAceptar.Location = New System.Drawing.Point(59, 249)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 83
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Respuesta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Confirmar Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Nombre de Usuario"
        '
        'RecuperarContrasena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(335, 293)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.ComboBoxPregunta)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxConfirmarContr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxContr)
        Me.Controls.Add(Me.TextBoxRespuesta)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RecuperarContrasena"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RecuperarContrasena"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelError As Label
    Friend WithEvents ComboBoxPregunta As ComboBox
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxConfirmarContr As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxContr As TextBox
    Friend WithEvents TextBoxRespuesta As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
