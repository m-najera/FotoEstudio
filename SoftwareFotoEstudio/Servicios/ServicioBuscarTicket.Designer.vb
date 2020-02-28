<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServicioBuscarTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServicioBuscarTicket))
        Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.DataGridTickets = New System.Windows.Forms.DataGridView()
        Me.BotonBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridDetalles = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BotonDetalles = New System.Windows.Forms.Button()
        Me.LabelNombreCliente = New System.Windows.Forms.Label()
        Me.LabelEvento = New System.Windows.Forms.Label()
        Me.LabelLugarEvento = New System.Windows.Forms.Label()
        Me.LabelFechaContratacion = New System.Windows.Forms.Label()
        Me.LabelFechaEntrega = New System.Windows.Forms.Label()
        Me.LabelFechaEvento = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelAdeudo = New System.Windows.Forms.Label()
        Me.LabelEstadoServ = New System.Windows.Forms.Label()
        Me.LabelFechaPagoSig = New System.Windows.Forms.Label()
        Me.ButtonEditTickets = New System.Windows.Forms.Button()
        Me.ButtonServDet = New System.Windows.Forms.Button()
        Me.ButtonServMod = New System.Windows.Forms.Button()
        CType(Me.DataGridTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePickerFecha
        '
        Me.DateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFecha.Location = New System.Drawing.Point(101, 9)
        Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
        Me.DateTimePickerFecha.Size = New System.Drawing.Size(206, 20)
        Me.DateTimePickerFecha.TabIndex = 0
        '
        'DataGridTickets
        '
        Me.DataGridTickets.AllowUserToAddRows = False
        Me.DataGridTickets.AllowUserToDeleteRows = False
        Me.DataGridTickets.AllowUserToResizeRows = False
        Me.DataGridTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridTickets.BackgroundColor = System.Drawing.Color.LightCyan
        Me.DataGridTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTickets.Location = New System.Drawing.Point(15, 50)
        Me.DataGridTickets.MultiSelect = False
        Me.DataGridTickets.Name = "DataGridTickets"
        Me.DataGridTickets.ReadOnly = True
        Me.DataGridTickets.RowHeadersVisible = False
        Me.DataGridTickets.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridTickets.Size = New System.Drawing.Size(292, 154)
        Me.DataGridTickets.TabIndex = 0
        '
        'BotonBuscar
        '
        Me.BotonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonBuscar.Location = New System.Drawing.Point(313, 9)
        Me.BotonBuscar.Name = "BotonBuscar"
        Me.BotonBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BotonBuscar.TabIndex = 1
        Me.BotonBuscar.Text = "Buscar"
        Me.BotonBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha del ticket"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tickets"
        '
        'DataGridDetalles
        '
        Me.DataGridDetalles.AllowUserToAddRows = False
        Me.DataGridDetalles.AllowUserToDeleteRows = False
        Me.DataGridDetalles.AllowUserToResizeRows = False
        Me.DataGridDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridDetalles.BackgroundColor = System.Drawing.Color.LightCyan
        Me.DataGridDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridDetalles.Location = New System.Drawing.Point(12, 257)
        Me.DataGridDetalles.MultiSelect = False
        Me.DataGridDetalles.Name = "DataGridDetalles"
        Me.DataGridDetalles.ReadOnly = True
        Me.DataGridDetalles.RowHeadersVisible = False
        Me.DataGridDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridDetalles.Size = New System.Drawing.Size(435, 135)
        Me.DataGridDetalles.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Detalles"
        '
        'BotonDetalles
        '
        Me.BotonDetalles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BotonDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonDetalles.Location = New System.Drawing.Point(332, 181)
        Me.BotonDetalles.Name = "BotonDetalles"
        Me.BotonDetalles.Size = New System.Drawing.Size(75, 23)
        Me.BotonDetalles.TabIndex = 6
        Me.BotonDetalles.Text = "Detalles"
        Me.BotonDetalles.UseVisualStyleBackColor = True
        '
        'LabelNombreCliente
        '
        Me.LabelNombreCliente.AutoSize = True
        Me.LabelNombreCliente.Location = New System.Drawing.Point(329, 50)
        Me.LabelNombreCliente.Name = "LabelNombreCliente"
        Me.LabelNombreCliente.Size = New System.Drawing.Size(50, 13)
        Me.LabelNombreCliente.TabIndex = 7
        Me.LabelNombreCliente.Text = "Nombre: "
        '
        'LabelEvento
        '
        Me.LabelEvento.AutoSize = True
        Me.LabelEvento.Location = New System.Drawing.Point(329, 77)
        Me.LabelEvento.Name = "LabelEvento"
        Me.LabelEvento.Size = New System.Drawing.Size(47, 13)
        Me.LabelEvento.TabIndex = 8
        Me.LabelEvento.Text = "Evento: "
        '
        'LabelLugarEvento
        '
        Me.LabelLugarEvento.AutoSize = True
        Me.LabelLugarEvento.Location = New System.Drawing.Point(329, 104)
        Me.LabelLugarEvento.Name = "LabelLugarEvento"
        Me.LabelLugarEvento.Size = New System.Drawing.Size(34, 13)
        Me.LabelLugarEvento.TabIndex = 9
        Me.LabelLugarEvento.Text = "Lugar"
        '
        'LabelFechaContratacion
        '
        Me.LabelFechaContratacion.AutoSize = True
        Me.LabelFechaContratacion.Location = New System.Drawing.Point(329, 131)
        Me.LabelFechaContratacion.Name = "LabelFechaContratacion"
        Me.LabelFechaContratacion.Size = New System.Drawing.Size(100, 13)
        Me.LabelFechaContratacion.TabIndex = 10
        Me.LabelFechaContratacion.Text = "Fecha Contratacion"
        '
        'LabelFechaEntrega
        '
        Me.LabelFechaEntrega.AutoSize = True
        Me.LabelFechaEntrega.Location = New System.Drawing.Point(329, 158)
        Me.LabelFechaEntrega.Name = "LabelFechaEntrega"
        Me.LabelFechaEntrega.Size = New System.Drawing.Size(92, 13)
        Me.LabelFechaEntrega.TabIndex = 11
        Me.LabelFechaEntrega.Text = "Fecha de Entrega"
        '
        'LabelFechaEvento
        '
        Me.LabelFechaEvento.AutoSize = True
        Me.LabelFechaEvento.Location = New System.Drawing.Point(530, 50)
        Me.LabelFechaEvento.Name = "LabelFechaEvento"
        Me.LabelFechaEvento.Size = New System.Drawing.Size(93, 13)
        Me.LabelFechaEvento.TabIndex = 12
        Me.LabelFechaEvento.Text = "Fecha Del Evento"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(530, 77)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(31, 13)
        Me.LabelTotal.TabIndex = 13
        Me.LabelTotal.Text = "Total"
        '
        'LabelAdeudo
        '
        Me.LabelAdeudo.AutoSize = True
        Me.LabelAdeudo.Location = New System.Drawing.Point(530, 104)
        Me.LabelAdeudo.Name = "LabelAdeudo"
        Me.LabelAdeudo.Size = New System.Drawing.Size(44, 13)
        Me.LabelAdeudo.TabIndex = 14
        Me.LabelAdeudo.Text = "Adeudo"
        '
        'LabelEstadoServ
        '
        Me.LabelEstadoServ.AutoSize = True
        Me.LabelEstadoServ.Location = New System.Drawing.Point(530, 158)
        Me.LabelEstadoServ.Name = "LabelEstadoServ"
        Me.LabelEstadoServ.Size = New System.Drawing.Size(94, 13)
        Me.LabelEstadoServ.TabIndex = 15
        Me.LabelEstadoServ.Text = "Estado de servicio"
        '
        'LabelFechaPagoSig
        '
        Me.LabelFechaPagoSig.AutoSize = True
        Me.LabelFechaPagoSig.Location = New System.Drawing.Point(530, 131)
        Me.LabelFechaPagoSig.Name = "LabelFechaPagoSig"
        Me.LabelFechaPagoSig.Size = New System.Drawing.Size(77, 13)
        Me.LabelFechaPagoSig.TabIndex = 16
        Me.LabelFechaPagoSig.Text = "Pago Siguente"
        '
        'ButtonEditTickets
        '
        Me.ButtonEditTickets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonEditTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditTickets.Location = New System.Drawing.Point(429, 180)
        Me.ButtonEditTickets.Name = "ButtonEditTickets"
        Me.ButtonEditTickets.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEditTickets.TabIndex = 17
        Me.ButtonEditTickets.Text = "Editar Ticket"
        Me.ButtonEditTickets.UseVisualStyleBackColor = True
        '
        'ButtonServDet
        '
        Me.ButtonServDet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonServDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonServDet.Location = New System.Drawing.Point(12, 407)
        Me.ButtonServDet.Name = "ButtonServDet"
        Me.ButtonServDet.Size = New System.Drawing.Size(75, 23)
        Me.ButtonServDet.TabIndex = 18
        Me.ButtonServDet.Text = "Detalles"
        Me.ButtonServDet.UseVisualStyleBackColor = True
        '
        'ButtonServMod
        '
        Me.ButtonServMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonServMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonServMod.Location = New System.Drawing.Point(101, 407)
        Me.ButtonServMod.Name = "ButtonServMod"
        Me.ButtonServMod.Size = New System.Drawing.Size(75, 23)
        Me.ButtonServMod.TabIndex = 19
        Me.ButtonServMod.Text = "Modificar"
        Me.ButtonServMod.UseVisualStyleBackColor = True
        '
        'ServicioBuscarTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(788, 504)
        Me.Controls.Add(Me.ButtonServMod)
        Me.Controls.Add(Me.ButtonServDet)
        Me.Controls.Add(Me.ButtonEditTickets)
        Me.Controls.Add(Me.LabelFechaPagoSig)
        Me.Controls.Add(Me.LabelEstadoServ)
        Me.Controls.Add(Me.LabelAdeudo)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.LabelFechaEvento)
        Me.Controls.Add(Me.LabelFechaEntrega)
        Me.Controls.Add(Me.LabelFechaContratacion)
        Me.Controls.Add(Me.LabelLugarEvento)
        Me.Controls.Add(Me.LabelEvento)
        Me.Controls.Add(Me.LabelNombreCliente)
        Me.Controls.Add(Me.BotonDetalles)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridDetalles)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BotonBuscar)
        Me.Controls.Add(Me.DataGridTickets)
        Me.Controls.Add(Me.DateTimePickerFecha)
        Me.Name = "ServicioBuscarTicket"
        Me.Text = "ServicioBuscarTicket"
        CType(Me.DataGridTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridTickets As System.Windows.Forms.DataGridView
    Friend WithEvents BotonBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BotonDetalles As System.Windows.Forms.Button
    Friend WithEvents LabelNombreCliente As System.Windows.Forms.Label
    Friend WithEvents LabelEvento As System.Windows.Forms.Label
    Friend WithEvents LabelLugarEvento As System.Windows.Forms.Label
    Friend WithEvents LabelFechaContratacion As System.Windows.Forms.Label
    Friend WithEvents LabelFechaEntrega As System.Windows.Forms.Label
    Friend WithEvents LabelFechaEvento As System.Windows.Forms.Label
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents LabelAdeudo As System.Windows.Forms.Label
    Friend WithEvents LabelEstadoServ As System.Windows.Forms.Label
    Friend WithEvents LabelFechaPagoSig As System.Windows.Forms.Label
    Friend WithEvents ButtonEditTickets As System.Windows.Forms.Button
    Friend WithEvents ButtonServDet As Button
    Friend WithEvents ButtonServMod As Button
End Class
