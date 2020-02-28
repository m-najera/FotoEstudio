<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarTickets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarTickets))
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.LabelNomEven = New System.Windows.Forms.Label()
        Me.LabelLugarEven = New System.Windows.Forms.Label()
        Me.LabelFechaCont = New System.Windows.Forms.Label()
        Me.LabelFechaEnt = New System.Windows.Forms.Label()
        Me.LabelFechaEven = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelAdeudo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelEstadoServ = New System.Windows.Forms.Label()
        Me.TextBoxNombreEven = New System.Windows.Forms.TextBox()
        Me.TextBoxLugarEven = New System.Windows.Forms.TextBox()
        Me.DateTimePickerFechaCont = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFechaEntr = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFechaEven = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerPagoSig = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.TextBoxAdeudo = New System.Windows.Forms.TextBox()
        Me.TextBoxEstado = New System.Windows.Forms.TextBox()
        Me.ButtonEditTicket = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.Location = New System.Drawing.Point(120, 9)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(162, 24)
        Me.LabelTitulo.TabIndex = 0
        Me.LabelTitulo.Text = "EDITAR TICKET"
        '
        'LabelNomEven
        '
        Me.LabelNomEven.AutoSize = True
        Me.LabelNomEven.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNomEven.Location = New System.Drawing.Point(12, 63)
        Me.LabelNomEven.Name = "LabelNomEven"
        Me.LabelNomEven.Size = New System.Drawing.Size(111, 15)
        Me.LabelNomEven.TabIndex = 1
        Me.LabelNomEven.Text = "Nombre del evento"
        '
        'LabelLugarEven
        '
        Me.LabelLugarEven.AutoSize = True
        Me.LabelLugarEven.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLugarEven.Location = New System.Drawing.Point(12, 98)
        Me.LabelLugarEven.Name = "LabelLugarEven"
        Me.LabelLugarEven.Size = New System.Drawing.Size(98, 15)
        Me.LabelLugarEven.TabIndex = 2
        Me.LabelLugarEven.Text = "Lugar del evento"
        '
        'LabelFechaCont
        '
        Me.LabelFechaCont.AutoSize = True
        Me.LabelFechaCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaCont.Location = New System.Drawing.Point(12, 133)
        Me.LabelFechaCont.Name = "LabelFechaCont"
        Me.LabelFechaCont.Size = New System.Drawing.Size(74, 30)
        Me.LabelFechaCont.TabIndex = 3
        Me.LabelFechaCont.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "contratacion"
        '
        'LabelFechaEnt
        '
        Me.LabelFechaEnt.AutoSize = True
        Me.LabelFechaEnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaEnt.Location = New System.Drawing.Point(12, 177)
        Me.LabelFechaEnt.Name = "LabelFechaEnt"
        Me.LabelFechaEnt.Size = New System.Drawing.Size(103, 15)
        Me.LabelFechaEnt.TabIndex = 4
        Me.LabelFechaEnt.Text = "Fecha de entrega"
        '
        'LabelFechaEven
        '
        Me.LabelFechaEven.AutoSize = True
        Me.LabelFechaEven.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaEven.Location = New System.Drawing.Point(13, 215)
        Me.LabelFechaEven.Name = "LabelFechaEven"
        Me.LabelFechaEven.Size = New System.Drawing.Size(101, 15)
        Me.LabelFechaEven.TabIndex = 5
        Me.LabelFechaEven.Text = "Fecha del Evento"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(17, 258)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(34, 15)
        Me.LabelTotal.TabIndex = 6
        Me.LabelTotal.Text = "Total"
        '
        'LabelAdeudo
        '
        Me.LabelAdeudo.AutoSize = True
        Me.LabelAdeudo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdeudo.Location = New System.Drawing.Point(15, 297)
        Me.LabelAdeudo.Name = "LabelAdeudo"
        Me.LabelAdeudo.Size = New System.Drawing.Size(49, 15)
        Me.LabelAdeudo.TabIndex = 7
        Me.LabelAdeudo.Text = "Adeudo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Fecha de pago" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " siguiente"
        '
        'LabelEstadoServ
        '
        Me.LabelEstadoServ.AutoSize = True
        Me.LabelEstadoServ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstadoServ.Location = New System.Drawing.Point(15, 400)
        Me.LabelEstadoServ.Name = "LabelEstadoServ"
        Me.LabelEstadoServ.Size = New System.Drawing.Size(65, 30)
        Me.LabelEstadoServ.TabIndex = 9
        Me.LabelEstadoServ.Text = "Estado del" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "servicio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBoxNombreEven
        '
        Me.TextBoxNombreEven.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombreEven.Location = New System.Drawing.Point(126, 63)
        Me.TextBoxNombreEven.Name = "TextBoxNombreEven"
        Me.TextBoxNombreEven.Size = New System.Drawing.Size(159, 21)
        Me.TextBoxNombreEven.TabIndex = 10
        '
        'TextBoxLugarEven
        '
        Me.TextBoxLugarEven.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLugarEven.Location = New System.Drawing.Point(125, 96)
        Me.TextBoxLugarEven.Name = "TextBoxLugarEven"
        Me.TextBoxLugarEven.Size = New System.Drawing.Size(159, 21)
        Me.TextBoxLugarEven.TabIndex = 11
        '
        'DateTimePickerFechaCont
        '
        Me.DateTimePickerFechaCont.Enabled = False
        Me.DateTimePickerFechaCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFechaCont.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFechaCont.Location = New System.Drawing.Point(126, 133)
        Me.DateTimePickerFechaCont.Name = "DateTimePickerFechaCont"
        Me.DateTimePickerFechaCont.Size = New System.Drawing.Size(159, 21)
        Me.DateTimePickerFechaCont.TabIndex = 12
        '
        'DateTimePickerFechaEntr
        '
        Me.DateTimePickerFechaEntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFechaEntr.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFechaEntr.Location = New System.Drawing.Point(126, 172)
        Me.DateTimePickerFechaEntr.Name = "DateTimePickerFechaEntr"
        Me.DateTimePickerFechaEntr.Size = New System.Drawing.Size(159, 21)
        Me.DateTimePickerFechaEntr.TabIndex = 13
        '
        'DateTimePickerFechaEven
        '
        Me.DateTimePickerFechaEven.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFechaEven.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFechaEven.Location = New System.Drawing.Point(124, 211)
        Me.DateTimePickerFechaEven.Name = "DateTimePickerFechaEven"
        Me.DateTimePickerFechaEven.Size = New System.Drawing.Size(159, 21)
        Me.DateTimePickerFechaEven.TabIndex = 14
        '
        'DateTimePickerPagoSig
        '
        Me.DateTimePickerPagoSig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerPagoSig.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerPagoSig.Location = New System.Drawing.Point(124, 343)
        Me.DateTimePickerPagoSig.Name = "DateTimePickerPagoSig"
        Me.DateTimePickerPagoSig.Size = New System.Drawing.Size(159, 21)
        Me.DateTimePickerPagoSig.TabIndex = 18
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotal.Location = New System.Drawing.Point(123, 252)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(159, 21)
        Me.TextBoxTotal.TabIndex = 16
        '
        'TextBoxAdeudo
        '
        Me.TextBoxAdeudo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAdeudo.Location = New System.Drawing.Point(123, 291)
        Me.TextBoxAdeudo.Name = "TextBoxAdeudo"
        Me.TextBoxAdeudo.Size = New System.Drawing.Size(159, 21)
        Me.TextBoxAdeudo.TabIndex = 17
        '
        'TextBoxEstado
        '
        Me.TextBoxEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEstado.Location = New System.Drawing.Point(123, 397)
        Me.TextBoxEstado.Name = "TextBoxEstado"
        Me.TextBoxEstado.Size = New System.Drawing.Size(159, 21)
        Me.TextBoxEstado.TabIndex = 19
        '
        'ButtonEditTicket
        '
        Me.ButtonEditTicket.BackColor = System.Drawing.Color.White
        Me.ButtonEditTicket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonEditTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditTicket.ForeColor = System.Drawing.Color.Black
        Me.ButtonEditTicket.Location = New System.Drawing.Point(16, 441)
        Me.ButtonEditTicket.Name = "ButtonEditTicket"
        Me.ButtonEditTicket.Size = New System.Drawing.Size(150, 42)
        Me.ButtonEditTicket.TabIndex = 20
        Me.ButtonEditTicket.Text = "ACEPTAR"
        Me.ButtonEditTicket.UseVisualStyleBackColor = False
        '
        'EditarTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(586, 552)
        Me.Controls.Add(Me.ButtonEditTicket)
        Me.Controls.Add(Me.TextBoxEstado)
        Me.Controls.Add(Me.TextBoxAdeudo)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.DateTimePickerPagoSig)
        Me.Controls.Add(Me.DateTimePickerFechaEven)
        Me.Controls.Add(Me.DateTimePickerFechaEntr)
        Me.Controls.Add(Me.DateTimePickerFechaCont)
        Me.Controls.Add(Me.TextBoxLugarEven)
        Me.Controls.Add(Me.TextBoxNombreEven)
        Me.Controls.Add(Me.LabelEstadoServ)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelAdeudo)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.LabelFechaEven)
        Me.Controls.Add(Me.LabelFechaEnt)
        Me.Controls.Add(Me.LabelFechaCont)
        Me.Controls.Add(Me.LabelLugarEven)
        Me.Controls.Add(Me.LabelNomEven)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Name = "EditarTickets"
        Me.Text = "EditarTickets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTitulo As System.Windows.Forms.Label
    Friend WithEvents LabelNomEven As System.Windows.Forms.Label
    Friend WithEvents LabelLugarEven As System.Windows.Forms.Label
    Friend WithEvents LabelFechaCont As System.Windows.Forms.Label
    Friend WithEvents LabelFechaEnt As System.Windows.Forms.Label
    Friend WithEvents LabelFechaEven As System.Windows.Forms.Label
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents LabelAdeudo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelEstadoServ As System.Windows.Forms.Label
    Friend WithEvents TextBoxNombreEven As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLugarEven As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerFechaCont As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerFechaEntr As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerFechaEven As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerPagoSig As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAdeudo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEstado As System.Windows.Forms.TextBox
    Friend WithEvents ButtonEditTicket As System.Windows.Forms.Button
End Class
