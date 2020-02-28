<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariosAgregar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsuariosAgregar))
        Me.ComboBoxNivel = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxPregunta = New System.Windows.Forms.ComboBox()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxConfirmarContr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxContr = New System.Windows.Forms.TextBox()
        Me.TextBoxRespuesta = New System.Windows.Forms.TextBox()
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.BottonAceptar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ComboBoxNivel
        '
        Me.ComboBoxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxNivel.FormattingEnabled = True
        Me.ComboBoxNivel.Items.AddRange(New Object() {"ADMINISTRADOR", "USUARIO GENERAL"})
        Me.ComboBoxNivel.Location = New System.Drawing.Point(151, 142)
        Me.ComboBoxNivel.Name = "ComboBoxNivel"
        Me.ComboBoxNivel.Size = New System.Drawing.Size(186, 23)
        Me.ComboBoxNivel.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 15)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Tipo de Usuario"
        '
        'ComboBoxPregunta
        '
        Me.ComboBoxPregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPregunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPregunta.FormattingEnabled = True
        Me.ComboBoxPregunta.Items.AddRange(New Object() {"¿Cuál es tu comida favorita?", "¿Cuál es tu película favorita?", "¿Nombre de tu primer mascota?", "¿Cuál es tu canción favorita?", "¿Cómo se llamaba tu escuela primaria?"})
        Me.ComboBoxPregunta.Location = New System.Drawing.Point(151, 175)
        Me.ComboBoxPregunta.Name = "ComboBoxPregunta"
        Me.ComboBoxPregunta.Size = New System.Drawing.Size(186, 23)
        Me.ComboBoxPregunta.TabIndex = 6
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.Color.White
        Me.ButtonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelar.Location = New System.Drawing.Point(196, 276)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 9
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Contraseña"
        '
        'TextBoxConfirmarContr
        '
        Me.TextBoxConfirmarContr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxConfirmarContr.Location = New System.Drawing.Point(151, 110)
        Me.TextBoxConfirmarContr.Name = "TextBoxConfirmarContr"
        Me.TextBoxConfirmarContr.Size = New System.Drawing.Size(186, 21)
        Me.TextBoxConfirmarContr.TabIndex = 4
        Me.TextBoxConfirmarContr.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 15)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Pregunta de Seguridad"
        '
        'TextBoxContr
        '
        Me.TextBoxContr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxContr.Location = New System.Drawing.Point(151, 78)
        Me.TextBoxContr.Name = "TextBoxContr"
        Me.TextBoxContr.Size = New System.Drawing.Size(186, 21)
        Me.TextBoxContr.TabIndex = 3
        Me.TextBoxContr.UseSystemPasswordChar = True
        '
        'TextBoxRespuesta
        '
        Me.TextBoxRespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRespuesta.Location = New System.Drawing.Point(151, 208)
        Me.TextBoxRespuesta.Name = "TextBoxRespuesta"
        Me.TextBoxRespuesta.Size = New System.Drawing.Size(186, 21)
        Me.TextBoxRespuesta.TabIndex = 7
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsuario.Location = New System.Drawing.Point(151, 44)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(186, 21)
        Me.TextBoxUsuario.TabIndex = 2
        '
        'BottonAceptar
        '
        Me.BottonAceptar.BackColor = System.Drawing.Color.White
        Me.BottonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BottonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BottonAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottonAceptar.Location = New System.Drawing.Point(67, 276)
        Me.BottonAceptar.Name = "BottonAceptar"
        Me.BottonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BottonAceptar.TabIndex = 8
        Me.BottonAceptar.Text = "Aceptar"
        Me.BottonAceptar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Respuesta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 15)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Confirmar Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 15)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Nombre de Usuario"
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(26, 242)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(93, 15)
        Me.LabelError.TabIndex = 56
        Me.LabelError.Text = "TEXTO ERROR"
        Me.LabelError.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 15)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Nombre Completo"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(151, 12)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(186, 21)
        Me.TextBoxNombre.TabIndex = 1
        '
        'UsuariosAgregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(354, 311)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.ComboBoxNivel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBoxPregunta)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxConfirmarContr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxContr)
        Me.Controls.Add(Me.TextBoxRespuesta)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.TextBoxUsuario)
        Me.Controls.Add(Me.BottonAceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UsuariosAgregar"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxNivel As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxPregunta As ComboBox
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxConfirmarContr As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxContr As TextBox
    Friend WithEvents TextBoxRespuesta As TextBox
    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents BottonAceptar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelError As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxNombre As TextBox
End Class
