<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialAbonos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistorialAbonos))
        Me.LabelTituloHistoAbono = New System.Windows.Forms.Label()
        Me.LabelBucarPor = New System.Windows.Forms.Label()
        Me.ComboBoxBuscarPor = New System.Windows.Forms.ComboBox()
        Me.LabelTicketId = New System.Windows.Forms.Label()
        Me.TextBoxIDticket = New System.Windows.Forms.TextBox()
        Me.TextBoxNombreCli = New System.Windows.Forms.TextBox()
        Me.TextBoxApellidosCli = New System.Windows.Forms.TextBox()
        Me.LabelBuscaNombre = New System.Windows.Forms.Label()
        Me.LabelBuscaApellido = New System.Windows.Forms.Label()
        Me.ButtonConsultar = New System.Windows.Forms.Button()
        Me.DataGridViewHistorialAbonos = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewHistorialAbonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTituloHistoAbono
        '
        Me.LabelTituloHistoAbono.AutoSize = True
        Me.LabelTituloHistoAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTituloHistoAbono.Location = New System.Drawing.Point(376, 37)
        Me.LabelTituloHistoAbono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTituloHistoAbono.Name = "LabelTituloHistoAbono"
        Me.LabelTituloHistoAbono.Size = New System.Drawing.Size(346, 31)
        Me.LabelTituloHistoAbono.TabIndex = 0
        Me.LabelTituloHistoAbono.Text = "HISTORIAL DE ABONOS"
        '
        'LabelBucarPor
        '
        Me.LabelBucarPor.AutoSize = True
        Me.LabelBucarPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LabelBucarPor.Location = New System.Drawing.Point(58, 109)
        Me.LabelBucarPor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelBucarPor.Name = "LabelBucarPor"
        Me.LabelBucarPor.Size = New System.Drawing.Size(85, 18)
        Me.LabelBucarPor.TabIndex = 1
        Me.LabelBucarPor.Text = "Buscar por:"
        '
        'ComboBoxBuscarPor
        '
        Me.ComboBoxBuscarPor.FormattingEnabled = True
        Me.ComboBoxBuscarPor.Items.AddRange(New Object() {"id ticket", "nombre del cliente"})
        Me.ComboBoxBuscarPor.Location = New System.Drawing.Point(144, 105)
        Me.ComboBoxBuscarPor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxBuscarPor.Name = "ComboBoxBuscarPor"
        Me.ComboBoxBuscarPor.Size = New System.Drawing.Size(199, 24)
        Me.ComboBoxBuscarPor.TabIndex = 2
        Me.ComboBoxBuscarPor.Text = "TIPO DE BUSQUEDA"
        '
        'LabelTicketId
        '
        Me.LabelTicketId.AutoSize = True
        Me.LabelTicketId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LabelTicketId.Location = New System.Drawing.Point(62, 186)
        Me.LabelTicketId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTicketId.Name = "LabelTicketId"
        Me.LabelTicketId.Size = New System.Drawing.Size(89, 18)
        Me.LabelTicketId.TabIndex = 3
        Me.LabelTicketId.Text = "ID del Ticket"
        '
        'TextBoxIDticket
        '
        Me.TextBoxIDticket.Location = New System.Drawing.Point(58, 208)
        Me.TextBoxIDticket.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxIDticket.Name = "TextBoxIDticket"
        Me.TextBoxIDticket.Size = New System.Drawing.Size(176, 22)
        Me.TextBoxIDticket.TabIndex = 4
        '
        'TextBoxNombreCli
        '
        Me.TextBoxNombreCli.Location = New System.Drawing.Point(58, 270)
        Me.TextBoxNombreCli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxNombreCli.Name = "TextBoxNombreCli"
        Me.TextBoxNombreCli.Size = New System.Drawing.Size(176, 22)
        Me.TextBoxNombreCli.TabIndex = 5
        '
        'TextBoxApellidosCli
        '
        Me.TextBoxApellidosCli.Location = New System.Drawing.Point(58, 336)
        Me.TextBoxApellidosCli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxApellidosCli.Name = "TextBoxApellidosCli"
        Me.TextBoxApellidosCli.Size = New System.Drawing.Size(176, 22)
        Me.TextBoxApellidosCli.TabIndex = 6
        '
        'LabelBuscaNombre
        '
        Me.LabelBuscaNombre.AutoSize = True
        Me.LabelBuscaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LabelBuscaNombre.Location = New System.Drawing.Point(62, 249)
        Me.LabelBuscaNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelBuscaNombre.Name = "LabelBuscaNombre"
        Me.LabelBuscaNombre.Size = New System.Drawing.Size(134, 18)
        Me.LabelBuscaNombre.TabIndex = 7
        Me.LabelBuscaNombre.Text = "Nombre del Cliente"
        '
        'LabelBuscaApellido
        '
        Me.LabelBuscaApellido.AutoSize = True
        Me.LabelBuscaApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LabelBuscaApellido.Location = New System.Drawing.Point(62, 313)
        Me.LabelBuscaApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelBuscaApellido.Name = "LabelBuscaApellido"
        Me.LabelBuscaApellido.Size = New System.Drawing.Size(131, 18)
        Me.LabelBuscaApellido.TabIndex = 8
        Me.LabelBuscaApellido.Text = "Apellido del Cliente"
        '
        'ButtonConsultar
        '
        Me.ButtonConsultar.BackColor = System.Drawing.Color.White
        Me.ButtonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConsultar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonConsultar.Location = New System.Drawing.Point(60, 407)
        Me.ButtonConsultar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonConsultar.Name = "ButtonConsultar"
        Me.ButtonConsultar.Size = New System.Drawing.Size(167, 43)
        Me.ButtonConsultar.TabIndex = 9
        Me.ButtonConsultar.Text = "Consultar"
        Me.ButtonConsultar.UseVisualStyleBackColor = False
        '
        'DataGridViewHistorialAbonos
        '
        Me.DataGridViewHistorialAbonos.AllowUserToAddRows = False
        Me.DataGridViewHistorialAbonos.AllowUserToDeleteRows = False
        Me.DataGridViewHistorialAbonos.BackgroundColor = System.Drawing.Color.LightCyan
        Me.DataGridViewHistorialAbonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewHistorialAbonos.Location = New System.Drawing.Point(270, 150)
        Me.DataGridViewHistorialAbonos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridViewHistorialAbonos.Name = "DataGridViewHistorialAbonos"
        Me.DataGridViewHistorialAbonos.ReadOnly = True
        Me.DataGridViewHistorialAbonos.Size = New System.Drawing.Size(536, 340)
        Me.DataGridViewHistorialAbonos.TabIndex = 10
        '
        'HistorialAbonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1184, 792)
        Me.Controls.Add(Me.DataGridViewHistorialAbonos)
        Me.Controls.Add(Me.ButtonConsultar)
        Me.Controls.Add(Me.LabelBuscaApellido)
        Me.Controls.Add(Me.LabelBuscaNombre)
        Me.Controls.Add(Me.TextBoxApellidosCli)
        Me.Controls.Add(Me.TextBoxNombreCli)
        Me.Controls.Add(Me.TextBoxIDticket)
        Me.Controls.Add(Me.LabelTicketId)
        Me.Controls.Add(Me.ComboBoxBuscarPor)
        Me.Controls.Add(Me.LabelBucarPor)
        Me.Controls.Add(Me.LabelTituloHistoAbono)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "HistorialAbonos"
        Me.Text = "HistorialAbonos"
        CType(Me.DataGridViewHistorialAbonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTituloHistoAbono As System.Windows.Forms.Label
    Friend WithEvents LabelBucarPor As System.Windows.Forms.Label
    Friend WithEvents ComboBoxBuscarPor As System.Windows.Forms.ComboBox
    Friend WithEvents LabelTicketId As System.Windows.Forms.Label
    Friend WithEvents TextBoxIDticket As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNombreCli As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxApellidosCli As System.Windows.Forms.TextBox
    Friend WithEvents LabelBuscaNombre As System.Windows.Forms.Label
    Friend WithEvents LabelBuscaApellido As System.Windows.Forms.Label
    Friend WithEvents ButtonConsultar As System.Windows.Forms.Button
    Friend WithEvents DataGridViewHistorialAbonos As System.Windows.Forms.DataGridView
End Class
