<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaginaPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaginaPrincipal))
        Me.ButtonClientes = New System.Windows.Forms.Button()
        Me.ButtonPedidos = New System.Windows.Forms.Button()
        Me.ButtonCalendario = New System.Windows.Forms.Button()
        Me.ButtonUsuarios = New System.Windows.Forms.Button()
        Me.LabelNivel = New System.Windows.Forms.Label()
        Me.BotonCerrarSesion = New System.Windows.Forms.Button()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.ButtonConfig = New System.Windows.Forms.Button()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonClientes
        '
        Me.ButtonClientes.BackgroundImage = CType(resources.GetObject("ButtonClientes.BackgroundImage"), System.Drawing.Image)
        Me.ButtonClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonClientes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonClientes.FlatAppearance.BorderSize = 0
        Me.ButtonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.ButtonClientes.ForeColor = System.Drawing.Color.Navy
        Me.ButtonClientes.Location = New System.Drawing.Point(56, 19)
        Me.ButtonClientes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonClientes.Name = "ButtonClientes"
        Me.ButtonClientes.Size = New System.Drawing.Size(260, 141)
        Me.ButtonClientes.TabIndex = 2
        Me.ButtonClientes.UseVisualStyleBackColor = True
        '
        'ButtonPedidos
        '
        Me.ButtonPedidos.BackgroundImage = CType(resources.GetObject("ButtonPedidos.BackgroundImage"), System.Drawing.Image)
        Me.ButtonPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonPedidos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPedidos.Location = New System.Drawing.Point(56, 193)
        Me.ButtonPedidos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonPedidos.Name = "ButtonPedidos"
        Me.ButtonPedidos.Size = New System.Drawing.Size(260, 141)
        Me.ButtonPedidos.TabIndex = 3
        Me.ButtonPedidos.UseVisualStyleBackColor = True
        '
        'ButtonCalendario
        '
        Me.ButtonCalendario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCalendario.Image = CType(resources.GetObject("ButtonCalendario.Image"), System.Drawing.Image)
        Me.ButtonCalendario.Location = New System.Drawing.Point(63, 510)
        Me.ButtonCalendario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonCalendario.Name = "ButtonCalendario"
        Me.ButtonCalendario.Size = New System.Drawing.Size(288, 121)
        Me.ButtonCalendario.TabIndex = 4
        Me.ButtonCalendario.UseVisualStyleBackColor = True
        Me.ButtonCalendario.Visible = False
        '
        'ButtonUsuarios
        '
        Me.ButtonUsuarios.BackgroundImage = CType(resources.GetObject("ButtonUsuarios.BackgroundImage"), System.Drawing.Image)
        Me.ButtonUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUsuarios.Location = New System.Drawing.Point(56, 366)
        Me.ButtonUsuarios.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonUsuarios.Name = "ButtonUsuarios"
        Me.ButtonUsuarios.Size = New System.Drawing.Size(260, 141)
        Me.ButtonUsuarios.TabIndex = 5
        Me.ButtonUsuarios.UseVisualStyleBackColor = True
        '
        'LabelNivel
        '
        Me.LabelNivel.AutoSize = True
        Me.LabelNivel.BackColor = System.Drawing.Color.Transparent
        Me.LabelNivel.Location = New System.Drawing.Point(738, 576)
        Me.LabelNivel.Name = "LabelNivel"
        Me.LabelNivel.Size = New System.Drawing.Size(56, 13)
        Me.LabelNivel.TabIndex = 0
        Me.LabelNivel.Text = "USUARIO"
        '
        'BotonCerrarSesion
        '
        Me.BotonCerrarSesion.BackColor = System.Drawing.Color.White
        Me.BotonCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BotonCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BotonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonCerrarSesion.Location = New System.Drawing.Point(852, 567)
        Me.BotonCerrarSesion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BotonCerrarSesion.Name = "BotonCerrarSesion"
        Me.BotonCerrarSesion.Size = New System.Drawing.Size(100, 30)
        Me.BotonCerrarSesion.TabIndex = 6
        Me.BotonCerrarSesion.Text = "Cerrar Sesión"
        Me.BotonCerrarSesion.UseVisualStyleBackColor = False
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.ImageLocation = "logo.png"
        Me.PictureBoxLogo.Location = New System.Drawing.Point(777, 9)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(220, 152)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 7
        Me.PictureBoxLogo.TabStop = False
        '
        'ButtonConfig
        '
        Me.ButtonConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonConfig.ForeColor = System.Drawing.Color.Black
        Me.ButtonConfig.Location = New System.Drawing.Point(819, 242)
        Me.ButtonConfig.Name = "ButtonConfig"
        Me.ButtonConfig.Size = New System.Drawing.Size(147, 64)
        Me.ButtonConfig.TabIndex = 8
        Me.ButtonConfig.Text = "Configuraciones de Sucursal"
        Me.ButtonConfig.UseVisualStyleBackColor = True
        '
        'LabelDireccion
        '
        Me.LabelDireccion.AutoSize = True
        Me.LabelDireccion.Location = New System.Drawing.Point(788, 170)
        Me.LabelDireccion.Name = "LabelDireccion"
        Me.LabelDireccion.Size = New System.Drawing.Size(52, 13)
        Me.LabelDireccion.TabIndex = 9
        Me.LabelDireccion.Text = "Direccion"
        '
        'PaginaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1022, 602)
        Me.Controls.Add(Me.LabelDireccion)
        Me.Controls.Add(Me.ButtonConfig)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.BotonCerrarSesion)
        Me.Controls.Add(Me.ButtonUsuarios)
        Me.Controls.Add(Me.ButtonCalendario)
        Me.Controls.Add(Me.ButtonPedidos)
        Me.Controls.Add(Me.ButtonClientes)
        Me.Controls.Add(Me.LabelNivel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PaginaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Foto Estudio - Pagina Principal"
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonClientes As Button
    Friend WithEvents ButtonPedidos As Button
    Friend WithEvents ButtonCalendario As Button
    Friend WithEvents ButtonUsuarios As Button
    Friend WithEvents LabelNivel As Label
    Friend WithEvents BotonCerrarSesion As Button
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents ButtonConfig As Button
    Friend WithEvents LabelDireccion As Label
End Class
