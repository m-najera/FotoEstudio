<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariosModificar
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
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.BottonAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxRespuesta = New System.Windows.Forms.TextBox()
        Me.TextBoxContr = New System.Windows.Forms.TextBox()
        Me.TextBoxConfirmarContr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxNivel = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPregunta = New System.Windows.Forms.ComboBox()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.Color.White
        Me.ButtonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelar.Location = New System.Drawing.Point(348, 325)
        Me.ButtonCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(100, 28)
        Me.ButtonCancelar.TabIndex = 39
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(200, 58)
        Me.TextBoxNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(247, 22)
        Me.TextBoxNombre.TabIndex = 2
        '
        'BottonAceptar
        '
        Me.BottonAceptar.BackColor = System.Drawing.Color.White
        Me.BottonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BottonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BottonAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottonAceptar.Location = New System.Drawing.Point(200, 327)
        Me.BottonAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BottonAceptar.Name = "BottonAceptar"
        Me.BottonAceptar.Size = New System.Drawing.Size(100, 28)
        Me.BottonAceptar.TabIndex = 31
        Me.BottonAceptar.Text = "Aceptar"
        Me.BottonAceptar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nombre Completo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 180)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 18)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Tipo de Usuario"
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.Location = New System.Drawing.Point(200, 21)
        Me.TextBoxUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(247, 22)
        Me.TextBoxUsuario.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 25)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 18)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Nombre de Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 261)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Respuesta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 220)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 18)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Pregunta de Seguridad"
        '
        'TextBoxRespuesta
        '
        Me.TextBoxRespuesta.Location = New System.Drawing.Point(200, 257)
        Me.TextBoxRespuesta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxRespuesta.Name = "TextBoxRespuesta"
        Me.TextBoxRespuesta.Size = New System.Drawing.Size(247, 22)
        Me.TextBoxRespuesta.TabIndex = 7
        '
        'TextBoxContr
        '
        Me.TextBoxContr.Location = New System.Drawing.Point(200, 97)
        Me.TextBoxContr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxContr.Name = "TextBoxContr"
        Me.TextBoxContr.Size = New System.Drawing.Size(247, 22)
        Me.TextBoxContr.TabIndex = 3
        Me.TextBoxContr.UseSystemPasswordChar = True
        '
        'TextBoxConfirmarContr
        '
        Me.TextBoxConfirmarContr.Location = New System.Drawing.Point(200, 137)
        Me.TextBoxConfirmarContr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxConfirmarContr.Name = "TextBoxConfirmarContr"
        Me.TextBoxConfirmarContr.Size = New System.Drawing.Size(247, 22)
        Me.TextBoxConfirmarContr.TabIndex = 4
        Me.TextBoxConfirmarContr.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 18)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Confirmar Contraseña"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 101)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 18)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Contraseña"
        '
        'ComboBoxNivel
        '
        Me.ComboBoxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNivel.FormattingEnabled = True
        Me.ComboBoxNivel.Items.AddRange(New Object() {"ADMINISTRADOR", "USUARIO GENERAL"})
        Me.ComboBoxNivel.Location = New System.Drawing.Point(201, 176)
        Me.ComboBoxNivel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxNivel.Name = "ComboBoxNivel"
        Me.ComboBoxNivel.Size = New System.Drawing.Size(247, 24)
        Me.ComboBoxNivel.TabIndex = 5
        '
        'ComboBoxPregunta
        '
        Me.ComboBoxPregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPregunta.FormattingEnabled = True
        Me.ComboBoxPregunta.Items.AddRange(New Object() {"¿Cuál es tu comida favorita?", "¿Cuál es tu película favorita?", "¿Nombre de tu primer mascota?", "¿Cuál es tu canción favorita?", "¿Cómo se llamaba tu escuela primaria?"})
        Me.ComboBoxPregunta.Location = New System.Drawing.Point(201, 217)
        Me.ComboBoxPregunta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxPregunta.Name = "ComboBoxPregunta"
        Me.ComboBoxPregunta.Size = New System.Drawing.Size(247, 24)
        Me.ComboBoxPregunta.TabIndex = 6
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(36, 293)
        Me.LabelError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(117, 18)
        Me.LabelError.TabIndex = 57
        Me.LabelError.Text = "TEXTO ERROR"
        Me.LabelError.Visible = False
        '
        'UsuariosModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 368)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.ComboBoxNivel)
        Me.Controls.Add(Me.ComboBoxPregunta)
        Me.Controls.Add(Me.TextBoxUsuario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxConfirmarContr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxContr)
        Me.Controls.Add(Me.TextBoxRespuesta)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.BottonAceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UsuariosModificar"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents BottonAceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxRespuesta As TextBox
    Friend WithEvents TextBoxContr As TextBox
    Friend WithEvents TextBoxConfirmarContr As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxNivel As ComboBox
    Friend WithEvents ComboBoxPregunta As ComboBox
    Friend WithEvents LabelError As Label
End Class
