<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariosDetalles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.ComboBoxNivel = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPregunta = New System.Windows.Forms.ComboBox()
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxRespuesta = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxContr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxConfirmarContr = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(27, 289)
        Me.LabelError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(117, 18)
        Me.LabelError.TabIndex = 74
        Me.LabelError.Text = "TEXTO ERROR"
        Me.LabelError.Visible = False
        '
        'ComboBoxNivel
        '
        Me.ComboBoxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxNivel.FormattingEnabled = True
        Me.ComboBoxNivel.Items.AddRange(New Object() {"ADMINISTRADOR", "USUARIO GENERAL"})
        Me.ComboBoxNivel.Location = New System.Drawing.Point(195, 172)
        Me.ComboBoxNivel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxNivel.Name = "ComboBoxNivel"
        Me.ComboBoxNivel.Size = New System.Drawing.Size(247, 26)
        Me.ComboBoxNivel.TabIndex = 62
        '
        'ComboBoxPregunta
        '
        Me.ComboBoxPregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPregunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPregunta.FormattingEnabled = True
        Me.ComboBoxPregunta.Items.AddRange(New Object() {"¿Cuál es tu comida favorita?", "¿Cuál es tu película favorita?", "¿Nombre de tu primer mascota?", "¿Cuál es tu canción favorita?", "¿Cómo se llamaba tu escuela primaria?"})
        Me.ComboBoxPregunta.Location = New System.Drawing.Point(195, 213)
        Me.ComboBoxPregunta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxPregunta.Name = "ComboBoxPregunta"
        Me.ComboBoxPregunta.Size = New System.Drawing.Size(247, 26)
        Me.ComboBoxPregunta.TabIndex = 63
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsuario.Location = New System.Drawing.Point(194, 17)
        Me.TextBoxUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(247, 24)
        Me.TextBoxUsuario.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 21)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 18)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Nombre de Usuario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 176)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 18)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Tipo de Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 217)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 18)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Pregunta de Seguridad"
        '
        'TextBoxRespuesta
        '
        Me.TextBoxRespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRespuesta.Location = New System.Drawing.Point(194, 254)
        Me.TextBoxRespuesta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxRespuesta.Name = "TextBoxRespuesta"
        Me.TextBoxRespuesta.Size = New System.Drawing.Size(247, 24)
        Me.TextBoxRespuesta.TabIndex = 64
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(194, 54)
        Me.TextBoxNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(247, 24)
        Me.TextBoxNombre.TabIndex = 59
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.BackColor = System.Drawing.Color.White
        Me.ButtonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCerrar.Location = New System.Drawing.Point(179, 325)
        Me.ButtonCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(100, 28)
        Me.ButtonCerrar.TabIndex = 68
        Me.ButtonCerrar.Text = "Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 257)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Respuesta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 18)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Nombre Completo"
        '
        'TextBoxContr
        '
        Me.TextBoxContr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxContr.Location = New System.Drawing.Point(194, 94)
        Me.TextBoxContr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxContr.Name = "TextBoxContr"
        Me.TextBoxContr.Size = New System.Drawing.Size(247, 24)
        Me.TextBoxContr.TabIndex = 60
        Me.TextBoxContr.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 97)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 18)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 137)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 18)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Confirmar Contraseña"
        '
        'TextBoxConfirmarContr
        '
        Me.TextBoxConfirmarContr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxConfirmarContr.Location = New System.Drawing.Point(194, 133)
        Me.TextBoxConfirmarContr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxConfirmarContr.Name = "TextBoxConfirmarContr"
        Me.TextBoxConfirmarContr.Size = New System.Drawing.Size(247, 24)
        Me.TextBoxConfirmarContr.TabIndex = 61
        Me.TextBoxConfirmarContr.UseSystemPasswordChar = True
        '
        'UsuariosDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(481, 368)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.ComboBoxNivel)
        Me.Controls.Add(Me.ComboBoxPregunta)
        Me.Controls.Add(Me.TextBoxUsuario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxConfirmarContr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxContr)
        Me.Controls.Add(Me.TextBoxRespuesta)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UsuariosDetalles"
        Me.ShowIcon = False
        Me.Text = "Detalles de Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelError As Label
    Friend WithEvents ComboBoxNivel As ComboBox
    Friend WithEvents ComboBoxPregunta As ComboBox
    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxRespuesta As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxContr As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxConfirmarContr As TextBox
End Class
