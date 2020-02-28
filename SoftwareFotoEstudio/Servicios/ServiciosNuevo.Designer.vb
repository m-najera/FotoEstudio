<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiciosNuevo
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCliente = New System.Windows.Forms.TextBox()
        Me.ButtonBuscarCliente = New System.Windows.Forms.Button()
        Me.ButtonAVideo = New System.Windows.Forms.Button()
        Me.ButtonAFoto = New System.Windows.Forms.Button()
        Me.ButtonAAlbum = New System.Windows.Forms.Button()
        Me.CheckBoxCotizacion = New System.Windows.Forms.CheckBox()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.ButtonImprimir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.DateTimePickerEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePickerSegundo = New System.Windows.Forms.DateTimePicker()
        Me.ButtonAEdicion = New System.Windows.Forms.Button()
        Me.ButtonAInvitaciones = New System.Windows.Forms.Button()
        Me.ButtonAImpresion = New System.Windows.Forms.Button()
        Me.CheckBoxEvento = New System.Windows.Forms.CheckBox()
        Me.TextBoxDesc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePickerFechaEvento = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxLugar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelAdeudo = New System.Windows.Forms.Label()
        Me.TextBoxAnticipo = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightCyan
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(307, 379)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente"
        '
        'TextBoxCliente
        '
        Me.TextBoxCliente.BackColor = System.Drawing.Color.White
        Me.TextBoxCliente.Enabled = False
        Me.TextBoxCliente.Location = New System.Drawing.Point(73, 22)
        Me.TextBoxCliente.Name = "TextBoxCliente"
        Me.TextBoxCliente.ReadOnly = True
        Me.TextBoxCliente.Size = New System.Drawing.Size(218, 20)
        Me.TextBoxCliente.TabIndex = 2
        '
        'ButtonBuscarCliente
        '
        Me.ButtonBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonBuscarCliente.Location = New System.Drawing.Point(310, 20)
        Me.ButtonBuscarCliente.Name = "ButtonBuscarCliente"
        Me.ButtonBuscarCliente.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBuscarCliente.TabIndex = 3
        Me.ButtonBuscarCliente.Text = "Cambiar"
        Me.ButtonBuscarCliente.UseVisualStyleBackColor = True
        '
        'ButtonAVideo
        '
        Me.ButtonAVideo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonAVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonAVideo.Location = New System.Drawing.Point(344, 53)
        Me.ButtonAVideo.Name = "ButtonAVideo"
        Me.ButtonAVideo.Size = New System.Drawing.Size(110, 62)
        Me.ButtonAVideo.TabIndex = 4
        Me.ButtonAVideo.Text = "Agregar Servicio Video"
        Me.ButtonAVideo.UseVisualStyleBackColor = True
        '
        'ButtonAFoto
        '
        Me.ButtonAFoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonAFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonAFoto.Location = New System.Drawing.Point(344, 119)
        Me.ButtonAFoto.Name = "ButtonAFoto"
        Me.ButtonAFoto.Size = New System.Drawing.Size(110, 62)
        Me.ButtonAFoto.TabIndex = 5
        Me.ButtonAFoto.Text = "Agregar Servicio Foto"
        Me.ButtonAFoto.UseVisualStyleBackColor = True
        '
        'ButtonAAlbum
        '
        Me.ButtonAAlbum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonAAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonAAlbum.Location = New System.Drawing.Point(344, 316)
        Me.ButtonAAlbum.Name = "ButtonAAlbum"
        Me.ButtonAAlbum.Size = New System.Drawing.Size(110, 62)
        Me.ButtonAAlbum.TabIndex = 6
        Me.ButtonAAlbum.Text = "Agregar Servicio Album"
        Me.ButtonAAlbum.UseVisualStyleBackColor = True
        '
        'CheckBoxCotizacion
        '
        Me.CheckBoxCotizacion.AutoSize = True
        Me.CheckBoxCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCotizacion.Location = New System.Drawing.Point(587, 335)
        Me.CheckBoxCotizacion.Name = "CheckBoxCotizacion"
        Me.CheckBoxCotizacion.Size = New System.Drawing.Size(83, 19)
        Me.CheckBoxCotizacion.TabIndex = 7
        Me.CheckBoxCotizacion.Text = "Cotizacion"
        Me.CheckBoxCotizacion.UseVisualStyleBackColor = True
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardar.Location = New System.Drawing.Point(613, 448)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(103, 38)
        Me.ButtonGuardar.TabIndex = 8
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'ButtonImprimir
        '
        Me.ButtonImprimir.Enabled = False
        Me.ButtonImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImprimir.Location = New System.Drawing.Point(489, 448)
        Me.ButtonImprimir.Name = "ButtonImprimir"
        Me.ButtonImprimir.Size = New System.Drawing.Size(103, 38)
        Me.ButtonImprimir.TabIndex = 9
        Me.ButtonImprimir.Text = "Imprimir"
        Me.ButtonImprimir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(484, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "TOTAL:"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(487, 334)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(38, 15)
        Me.LabelTotal.TabIndex = 11
        Me.LabelTotal.Text = "$0.00"
        '
        'DateTimePickerEntrega
        '
        Me.DateTimePickerEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerEntrega.Location = New System.Drawing.Point(490, 279)
        Me.DateTimePickerEntrega.Name = "DateTimePickerEntrega"
        Me.DateTimePickerEntrega.Size = New System.Drawing.Size(103, 21)
        Me.DateTimePickerEntrega.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(487, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Fecha de Entrega"
        '
        'ButtonModificar
        '
        Me.ButtonModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificar.Location = New System.Drawing.Point(73, 448)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(75, 38)
        Me.ButtonModificar.TabIndex = 14
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminar.Location = New System.Drawing.Point(216, 448)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(75, 40)
        Me.ButtonEliminar.TabIndex = 15
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(486, 370)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Anticipo: $"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(610, 394)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Segundo pago:"
        '
        'DateTimePickerSegundo
        '
        Me.DateTimePickerSegundo.Enabled = False
        Me.DateTimePickerSegundo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerSegundo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerSegundo.Location = New System.Drawing.Point(613, 410)
        Me.DateTimePickerSegundo.Name = "DateTimePickerSegundo"
        Me.DateTimePickerSegundo.Size = New System.Drawing.Size(91, 21)
        Me.DateTimePickerSegundo.TabIndex = 19
        '
        'ButtonAEdicion
        '
        Me.ButtonAEdicion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonAEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAEdicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonAEdicion.Location = New System.Drawing.Point(344, 250)
        Me.ButtonAEdicion.Name = "ButtonAEdicion"
        Me.ButtonAEdicion.Size = New System.Drawing.Size(110, 62)
        Me.ButtonAEdicion.TabIndex = 22
        Me.ButtonAEdicion.Text = "Agregar Servicio Edicion"
        Me.ButtonAEdicion.UseVisualStyleBackColor = True
        '
        'ButtonAInvitaciones
        '
        Me.ButtonAInvitaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonAInvitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAInvitaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonAInvitaciones.Location = New System.Drawing.Point(344, 382)
        Me.ButtonAInvitaciones.Name = "ButtonAInvitaciones"
        Me.ButtonAInvitaciones.Size = New System.Drawing.Size(110, 62)
        Me.ButtonAInvitaciones.TabIndex = 23
        Me.ButtonAInvitaciones.Text = "Agregar Servicio Invitaciones"
        Me.ButtonAInvitaciones.UseVisualStyleBackColor = True
        '
        'ButtonAImpresion
        '
        Me.ButtonAImpresion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonAImpresion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAImpresion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonAImpresion.Location = New System.Drawing.Point(344, 184)
        Me.ButtonAImpresion.Name = "ButtonAImpresion"
        Me.ButtonAImpresion.Size = New System.Drawing.Size(110, 62)
        Me.ButtonAImpresion.TabIndex = 24
        Me.ButtonAImpresion.Text = "Agregar Servicio Impresion"
        Me.ButtonAImpresion.UseVisualStyleBackColor = True
        '
        'CheckBoxEvento
        '
        Me.CheckBoxEvento.AutoSize = True
        Me.CheckBoxEvento.Checked = True
        Me.CheckBoxEvento.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxEvento.Location = New System.Drawing.Point(487, 17)
        Me.CheckBoxEvento.Name = "CheckBoxEvento"
        Me.CheckBoxEvento.Size = New System.Drawing.Size(63, 19)
        Me.CheckBoxEvento.TabIndex = 25
        Me.CheckBoxEvento.Text = "Evento"
        Me.CheckBoxEvento.UseVisualStyleBackColor = True
        '
        'TextBoxDesc
        '
        Me.TextBoxDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDesc.Location = New System.Drawing.Point(487, 53)
        Me.TextBoxDesc.Multiline = True
        Me.TextBoxDesc.Name = "TextBoxDesc"
        Me.TextBoxDesc.Size = New System.Drawing.Size(218, 53)
        Me.TextBoxDesc.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(486, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 15)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Descripcion del Evento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(484, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 15)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Fecha del Evento"
        '
        'DateTimePickerFechaEvento
        '
        Me.DateTimePickerFechaEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFechaEvento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFechaEvento.Location = New System.Drawing.Point(487, 128)
        Me.DateTimePickerFechaEvento.Name = "DateTimePickerFechaEvento"
        Me.DateTimePickerFechaEvento.Size = New System.Drawing.Size(103, 21)
        Me.DateTimePickerFechaEvento.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(487, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 15)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Lugar del Evento"
        '
        'TextBoxLugar
        '
        Me.TextBoxLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLugar.Location = New System.Drawing.Point(490, 177)
        Me.TextBoxLugar.Multiline = True
        Me.TextBoxLugar.Name = "TextBoxLugar"
        Me.TextBoxLugar.Size = New System.Drawing.Size(215, 68)
        Me.TextBoxLugar.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(487, 399)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 15)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Adeudo:"
        '
        'LabelAdeudo
        '
        Me.LabelAdeudo.AutoSize = True
        Me.LabelAdeudo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdeudo.Location = New System.Drawing.Point(487, 418)
        Me.LabelAdeudo.Name = "LabelAdeudo"
        Me.LabelAdeudo.Size = New System.Drawing.Size(38, 15)
        Me.LabelAdeudo.TabIndex = 34
        Me.LabelAdeudo.Text = "$0.00"
        '
        'TextBoxAnticipo
        '
        Me.TextBoxAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAnticipo.Location = New System.Drawing.Point(546, 366)
        Me.TextBoxAnticipo.Name = "TextBoxAnticipo"
        Me.TextBoxAnticipo.Size = New System.Drawing.Size(91, 21)
        Me.TextBoxAnticipo.TabIndex = 35
        Me.TextBoxAnticipo.Text = "0"
        '
        'ServiciosNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(762, 541)
        Me.Controls.Add(Me.TextBoxAnticipo)
        Me.Controls.Add(Me.LabelAdeudo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxLugar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePickerFechaEvento)
        Me.Controls.Add(Me.TextBoxDesc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBoxEvento)
        Me.Controls.Add(Me.ButtonAImpresion)
        Me.Controls.Add(Me.ButtonAInvitaciones)
        Me.Controls.Add(Me.ButtonAEdicion)
        Me.Controls.Add(Me.DateTimePickerSegundo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePickerEntrega)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonImprimir)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.Controls.Add(Me.CheckBoxCotizacion)
        Me.Controls.Add(Me.ButtonAAlbum)
        Me.Controls.Add(Me.ButtonAFoto)
        Me.Controls.Add(Me.ButtonAVideo)
        Me.Controls.Add(Me.ButtonBuscarCliente)
        Me.Controls.Add(Me.TextBoxCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ServiciosNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ServiciosNuevo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxCliente As TextBox
    Friend WithEvents ButtonBuscarCliente As Button
    Friend WithEvents ButtonAVideo As Button
    Friend WithEvents ButtonAFoto As Button
    Friend WithEvents ButtonAAlbum As Button
    Friend WithEvents CheckBoxCotizacion As CheckBox
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents ButtonImprimir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents DateTimePickerEntrega As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePickerSegundo As DateTimePicker
    Friend WithEvents ButtonAEdicion As Button
    Friend WithEvents ButtonAInvitaciones As Button
    Friend WithEvents ButtonAImpresion As Button
    Friend WithEvents CheckBoxEvento As CheckBox
    Friend WithEvents TextBoxDesc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePickerFechaEvento As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxLugar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LabelAdeudo As Label
    Friend WithEvents TextBoxAnticipo As TextBox
End Class
