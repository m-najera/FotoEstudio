<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuraciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuraciones))
        Me.ButtonGuardarR = New System.Windows.Forms.Button()
        Me.ButtonCargarR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonCambiarImg = New System.Windows.Forms.Button()
        Me.TextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.ButtonCambiarDir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonGuardarDir = New System.Windows.Forms.Button()
        Me.ButtonCancelarDir = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonGuardarR
        '
        Me.ButtonGuardarR.BackColor = System.Drawing.Color.White
        Me.ButtonGuardarR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonGuardarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardarR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonGuardarR.Location = New System.Drawing.Point(475, 99)
        Me.ButtonGuardarR.Name = "ButtonGuardarR"
        Me.ButtonGuardarR.Size = New System.Drawing.Size(88, 68)
        Me.ButtonGuardarR.TabIndex = 0
        Me.ButtonGuardarR.Text = "Guardar Respaldo"
        Me.ButtonGuardarR.UseVisualStyleBackColor = False
        '
        'ButtonCargarR
        '
        Me.ButtonCargarR.BackColor = System.Drawing.Color.White
        Me.ButtonCargarR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonCargarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCargarR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonCargarR.Location = New System.Drawing.Point(596, 99)
        Me.ButtonCargarR.Name = "ButtonCargarR"
        Me.ButtonCargarR.Size = New System.Drawing.Size(88, 68)
        Me.ButtonCargarR.TabIndex = 1
        Me.ButtonCargarR.Text = "Cargar Respaldo"
        Me.ButtonCargarR.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(472, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Base de Datos"
        '
        'PictureBox1
        '
        Me.PictureBox1.ImageLocation = "logo.png"
        Me.PictureBox1.Location = New System.Drawing.Point(22, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(20, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Logo"
        '
        'ButtonCambiarImg
        '
        Me.ButtonCambiarImg.BackColor = System.Drawing.Color.White
        Me.ButtonCambiarImg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonCambiarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCambiarImg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonCambiarImg.Location = New System.Drawing.Point(75, 212)
        Me.ButtonCambiarImg.Name = "ButtonCambiarImg"
        Me.ButtonCambiarImg.Size = New System.Drawing.Size(75, 44)
        Me.ButtonCambiarImg.TabIndex = 5
        Me.ButtonCambiarImg.Text = "Cambiar Logo"
        Me.ButtonCambiarImg.UseVisualStyleBackColor = False
        '
        'TextBoxDireccion
        '
        Me.TextBoxDireccion.Enabled = False
        Me.TextBoxDireccion.Location = New System.Drawing.Point(248, 60)
        Me.TextBoxDireccion.Multiline = True
        Me.TextBoxDireccion.Name = "TextBoxDireccion"
        Me.TextBoxDireccion.Size = New System.Drawing.Size(193, 130)
        Me.TextBoxDireccion.TabIndex = 6
        '
        'ButtonCambiarDir
        '
        Me.ButtonCambiarDir.BackColor = System.Drawing.Color.White
        Me.ButtonCambiarDir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonCambiarDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCambiarDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonCambiarDir.Location = New System.Drawing.Point(304, 212)
        Me.ButtonCambiarDir.Name = "ButtonCambiarDir"
        Me.ButtonCambiarDir.Size = New System.Drawing.Size(75, 44)
        Me.ButtonCambiarDir.TabIndex = 7
        Me.ButtonCambiarDir.Text = "Cambiar Direccion"
        Me.ButtonCambiarDir.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(244, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Dirección"
        '
        'ButtonGuardarDir
        '
        Me.ButtonGuardarDir.BackColor = System.Drawing.Color.White
        Me.ButtonGuardarDir.Enabled = False
        Me.ButtonGuardarDir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonGuardarDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardarDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonGuardarDir.Location = New System.Drawing.Point(259, 212)
        Me.ButtonGuardarDir.Name = "ButtonGuardarDir"
        Me.ButtonGuardarDir.Size = New System.Drawing.Size(75, 44)
        Me.ButtonGuardarDir.TabIndex = 9
        Me.ButtonGuardarDir.Text = "Aceptar"
        Me.ButtonGuardarDir.UseVisualStyleBackColor = False
        Me.ButtonGuardarDir.Visible = False
        '
        'ButtonCancelarDir
        '
        Me.ButtonCancelarDir.BackColor = System.Drawing.Color.White
        Me.ButtonCancelarDir.Enabled = False
        Me.ButtonCancelarDir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonCancelarDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelarDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonCancelarDir.Location = New System.Drawing.Point(352, 212)
        Me.ButtonCancelarDir.Name = "ButtonCancelarDir"
        Me.ButtonCancelarDir.Size = New System.Drawing.Size(75, 44)
        Me.ButtonCancelarDir.TabIndex = 10
        Me.ButtonCancelarDir.Text = "Cancelar"
        Me.ButtonCancelarDir.UseVisualStyleBackColor = False
        Me.ButtonCancelarDir.Visible = False
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.White
        Me.ButtonClose.Enabled = False
        Me.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonClose.Location = New System.Drawing.Point(316, 316)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(125, 44)
        Me.ButtonClose.TabIndex = 11
        Me.ButtonClose.Text = "Terminar"
        Me.ButtonClose.UseVisualStyleBackColor = False
        Me.ButtonClose.Visible = False
        '
        'Configuraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(794, 550)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonCancelarDir)
        Me.Controls.Add(Me.ButtonGuardarDir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonCambiarDir)
        Me.Controls.Add(Me.TextBoxDireccion)
        Me.Controls.Add(Me.ButtonCambiarImg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCargarR)
        Me.Controls.Add(Me.ButtonGuardarR)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Configuraciones"
        Me.Text = "Configuraciones"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonGuardarR As Button
    Friend WithEvents ButtonCargarR As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonCambiarImg As Button
    Friend WithEvents TextBoxDireccion As TextBox
    Friend WithEvents ButtonCambiarDir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonGuardarDir As Button
    Friend WithEvents ButtonCancelarDir As Button
    Friend WithEvents ButtonClose As Button
End Class
