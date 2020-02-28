<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiciosAbonos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServiciosAbonos))
        Me.LabelFechaPagoSig = New System.Windows.Forms.Label()
        Me.DateTimePickerPagSig = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewResultado = New System.Windows.Forms.DataGridView()
        Me.ButtonAbonar = New System.Windows.Forms.Button()
        Me.FrmAbonosLbResto = New System.Windows.Forms.Label()
        Me.FrmAbonosLbAbonado = New System.Windows.Forms.Label()
        Me.TextBoxRestante = New System.Windows.Forms.TextBox()
        Me.TextBoxCantidadAbonar = New System.Windows.Forms.TextBox()
        Me.TextBoxNombreCli = New System.Windows.Forms.TextBox()
        Me.FrmAbonosLbNombre = New System.Windows.Forms.Label()
        Me.LabelTituloAbono = New System.Windows.Forms.Label()
        Me.ButtonBuscarCli = New System.Windows.Forms.Button()
        CType(Me.DataGridViewResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelFechaPagoSig
        '
        Me.LabelFechaPagoSig.AutoSize = True
        Me.LabelFechaPagoSig.BackColor = System.Drawing.Color.White
        Me.LabelFechaPagoSig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LabelFechaPagoSig.Location = New System.Drawing.Point(407, 292)
        Me.LabelFechaPagoSig.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFechaPagoSig.Name = "LabelFechaPagoSig"
        Me.LabelFechaPagoSig.Size = New System.Drawing.Size(168, 18)
        Me.LabelFechaPagoSig.TabIndex = 22
        Me.LabelFechaPagoSig.Text = "Fecha de pago siguiente"
        '
        'DateTimePickerPagSig
        '
        Me.DateTimePickerPagSig.CustomFormat = "yyyy/dd/MM"
        Me.DateTimePickerPagSig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.DateTimePickerPagSig.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerPagSig.Location = New System.Drawing.Point(393, 320)
        Me.DateTimePickerPagSig.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerPagSig.Name = "DateTimePickerPagSig"
        Me.DateTimePickerPagSig.Size = New System.Drawing.Size(232, 24)
        Me.DateTimePickerPagSig.TabIndex = 21
        '
        'DataGridViewResultado
        '
        Me.DataGridViewResultado.BackgroundColor = System.Drawing.Color.LightCyan
        Me.DataGridViewResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewResultado.Location = New System.Drawing.Point(33, 95)
        Me.DataGridViewResultado.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewResultado.MultiSelect = False
        Me.DataGridViewResultado.Name = "DataGridViewResultado"
        Me.DataGridViewResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewResultado.Size = New System.Drawing.Size(996, 162)
        Me.DataGridViewResultado.TabIndex = 20
        '
        'ButtonAbonar
        '
        Me.ButtonAbonar.BackColor = System.Drawing.Color.White
        Me.ButtonAbonar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonAbonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAbonar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAbonar.ForeColor = System.Drawing.Color.Black
        Me.ButtonAbonar.Location = New System.Drawing.Point(659, 308)
        Me.ButtonAbonar.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonAbonar.Name = "ButtonAbonar"
        Me.ButtonAbonar.Size = New System.Drawing.Size(133, 34)
        Me.ButtonAbonar.TabIndex = 19
        Me.ButtonAbonar.Text = "ABONAR"
        Me.ButtonAbonar.UseVisualStyleBackColor = False
        '
        'FrmAbonosLbResto
        '
        Me.FrmAbonosLbResto.AutoSize = True
        Me.FrmAbonosLbResto.BackColor = System.Drawing.Color.White
        Me.FrmAbonosLbResto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FrmAbonosLbResto.Location = New System.Drawing.Point(236, 292)
        Me.FrmAbonosLbResto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FrmAbonosLbResto.Name = "FrmAbonosLbResto"
        Me.FrmAbonosLbResto.Size = New System.Drawing.Size(98, 18)
        Me.FrmAbonosLbResto.TabIndex = 18
        Me.FrmAbonosLbResto.Text = "Total restante"
        '
        'FrmAbonosLbAbonado
        '
        Me.FrmAbonosLbAbonado.AutoSize = True
        Me.FrmAbonosLbAbonado.BackColor = System.Drawing.Color.White
        Me.FrmAbonosLbAbonado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FrmAbonosLbAbonado.Location = New System.Drawing.Point(32, 292)
        Me.FrmAbonosLbAbonado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FrmAbonosLbAbonado.Name = "FrmAbonosLbAbonado"
        Me.FrmAbonosLbAbonado.Size = New System.Drawing.Size(128, 18)
        Me.FrmAbonosLbAbonado.TabIndex = 17
        Me.FrmAbonosLbAbonado.Text = "Cantidad a abonar"
        '
        'TextBoxRestante
        '
        Me.TextBoxRestante.Enabled = False
        Me.TextBoxRestante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TextBoxRestante.Location = New System.Drawing.Point(221, 320)
        Me.TextBoxRestante.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxRestante.Name = "TextBoxRestante"
        Me.TextBoxRestante.Size = New System.Drawing.Size(132, 24)
        Me.TextBoxRestante.TabIndex = 16
        '
        'TextBoxCantidadAbonar
        '
        Me.TextBoxCantidadAbonar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TextBoxCantidadAbonar.Location = New System.Drawing.Point(31, 320)
        Me.TextBoxCantidadAbonar.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCantidadAbonar.Name = "TextBoxCantidadAbonar"
        Me.TextBoxCantidadAbonar.Size = New System.Drawing.Size(132, 24)
        Me.TextBoxCantidadAbonar.TabIndex = 15
        '
        'TextBoxNombreCli
        '
        Me.TextBoxNombreCli.Location = New System.Drawing.Point(192, 57)
        Me.TextBoxNombreCli.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNombreCli.Name = "TextBoxNombreCli"
        Me.TextBoxNombreCli.Size = New System.Drawing.Size(257, 22)
        Me.TextBoxNombreCli.TabIndex = 13
        '
        'FrmAbonosLbNombre
        '
        Me.FrmAbonosLbNombre.AutoSize = True
        Me.FrmAbonosLbNombre.BackColor = System.Drawing.Color.White
        Me.FrmAbonosLbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FrmAbonosLbNombre.Location = New System.Drawing.Point(39, 57)
        Me.FrmAbonosLbNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FrmAbonosLbNombre.Name = "FrmAbonosLbNombre"
        Me.FrmAbonosLbNombre.Size = New System.Drawing.Size(131, 18)
        Me.FrmAbonosLbNombre.TabIndex = 12
        Me.FrmAbonosLbNombre.Text = "Nombre del cliente"
        '
        'LabelTituloAbono
        '
        Me.LabelTituloAbono.AutoSize = True
        Me.LabelTituloAbono.BackColor = System.Drawing.Color.White
        Me.LabelTituloAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTituloAbono.Location = New System.Drawing.Point(475, 11)
        Me.LabelTituloAbono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTituloAbono.Name = "LabelTituloAbono"
        Me.LabelTituloAbono.Size = New System.Drawing.Size(119, 29)
        Me.LabelTituloAbono.TabIndex = 23
        Me.LabelTituloAbono.Text = "ABONAR"
        '
        'ButtonBuscarCli
        '
        Me.ButtonBuscarCli.BackColor = System.Drawing.Color.White
        Me.ButtonBuscarCli.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonBuscarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuscarCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscarCli.ForeColor = System.Drawing.Color.Black
        Me.ButtonBuscarCli.Location = New System.Drawing.Point(479, 54)
        Me.ButtonBuscarCli.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonBuscarCli.Name = "ButtonBuscarCli"
        Me.ButtonBuscarCli.Size = New System.Drawing.Size(133, 34)
        Me.ButtonBuscarCli.TabIndex = 14
        Me.ButtonBuscarCli.Text = "BUSCAR"
        Me.ButtonBuscarCli.UseVisualStyleBackColor = False
        '
        'ServiciosAbonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1094, 675)
        Me.Controls.Add(Me.LabelTituloAbono)
        Me.Controls.Add(Me.LabelFechaPagoSig)
        Me.Controls.Add(Me.DateTimePickerPagSig)
        Me.Controls.Add(Me.DataGridViewResultado)
        Me.Controls.Add(Me.ButtonAbonar)
        Me.Controls.Add(Me.FrmAbonosLbResto)
        Me.Controls.Add(Me.FrmAbonosLbAbonado)
        Me.Controls.Add(Me.TextBoxRestante)
        Me.Controls.Add(Me.TextBoxCantidadAbonar)
        Me.Controls.Add(Me.ButtonBuscarCli)
        Me.Controls.Add(Me.TextBoxNombreCli)
        Me.Controls.Add(Me.FrmAbonosLbNombre)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ServiciosAbonos"
        Me.Text = "ServiciosAbonos"
        CType(Me.DataGridViewResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelFechaPagoSig As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerPagSig As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewResultado As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonAbonar As System.Windows.Forms.Button
    Friend WithEvents FrmAbonosLbResto As System.Windows.Forms.Label
    Friend WithEvents FrmAbonosLbAbonado As System.Windows.Forms.Label
    Friend WithEvents TextBoxRestante As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCantidadAbonar As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNombreCli As System.Windows.Forms.TextBox
    Friend WithEvents FrmAbonosLbNombre As System.Windows.Forms.Label
    Friend WithEvents LabelTituloAbono As System.Windows.Forms.Label
    Friend WithEvents ButtonBuscarCli As Button
End Class
