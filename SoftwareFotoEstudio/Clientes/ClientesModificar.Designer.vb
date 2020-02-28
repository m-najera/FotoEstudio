<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesModificar
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CajaTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CajaApellidos = New System.Windows.Forms.TextBox()
        Me.CajaEmail = New System.Windows.Forms.TextBox()
        Me.CajaDomicilio = New System.Windows.Forms.TextBox()
        Me.CajaNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.BottonAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 69)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Apellidos"
        '
        'CajaTelefono
        '
        Me.CajaTelefono.BackColor = System.Drawing.Color.White
        Me.CajaTelefono.Location = New System.Drawing.Point(125, 153)
        Me.CajaTelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CajaTelefono.Name = "CajaTelefono"
        Me.CajaTelefono.ReadOnly = True
        Me.CajaTelefono.Size = New System.Drawing.Size(208, 22)
        Me.CajaTelefono.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 156)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Telefono"
        '
        'CajaApellidos
        '
        Me.CajaApellidos.BackColor = System.Drawing.Color.White
        Me.CajaApellidos.Location = New System.Drawing.Point(125, 65)
        Me.CajaApellidos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CajaApellidos.Name = "CajaApellidos"
        Me.CajaApellidos.ReadOnly = True
        Me.CajaApellidos.Size = New System.Drawing.Size(208, 22)
        Me.CajaApellidos.TabIndex = 2
        '
        'CajaEmail
        '
        Me.CajaEmail.BackColor = System.Drawing.Color.White
        Me.CajaEmail.Location = New System.Drawing.Point(125, 199)
        Me.CajaEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CajaEmail.Name = "CajaEmail"
        Me.CajaEmail.ReadOnly = True
        Me.CajaEmail.Size = New System.Drawing.Size(208, 22)
        Me.CajaEmail.TabIndex = 5
        '
        'CajaDomicilio
        '
        Me.CajaDomicilio.BackColor = System.Drawing.Color.White
        Me.CajaDomicilio.Location = New System.Drawing.Point(125, 108)
        Me.CajaDomicilio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CajaDomicilio.Name = "CajaDomicilio"
        Me.CajaDomicilio.ReadOnly = True
        Me.CajaDomicilio.Size = New System.Drawing.Size(208, 22)
        Me.CajaDomicilio.TabIndex = 3
        '
        'CajaNombre
        '
        Me.CajaNombre.BackColor = System.Drawing.Color.White
        Me.CajaNombre.Location = New System.Drawing.Point(125, 26)
        Me.CajaNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CajaNombre.Name = "CajaNombre"
        Me.CajaNombre.ReadOnly = True
        Me.CajaNombre.Size = New System.Drawing.Size(208, 22)
        Me.CajaNombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 203)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Domicilio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nombre"
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(41, 247)
        Me.LabelError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(109, 17)
        Me.LabelError.TabIndex = 60
        Me.LabelError.Text = "TEXTO ERROR"
        Me.LabelError.Visible = False
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.Color.White
        Me.ButtonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelar.Location = New System.Drawing.Point(235, 292)
        Me.ButtonCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(100, 28)
        Me.ButtonCancelar.TabIndex = 7
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'BottonAceptar
        '
        Me.BottonAceptar.BackColor = System.Drawing.Color.White
        Me.BottonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BottonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BottonAceptar.Location = New System.Drawing.Point(63, 292)
        Me.BottonAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BottonAceptar.Name = "BottonAceptar"
        Me.BottonAceptar.Size = New System.Drawing.Size(100, 28)
        Me.BottonAceptar.TabIndex = 6
        Me.BottonAceptar.Text = "Aceptar"
        Me.BottonAceptar.UseVisualStyleBackColor = False
        '
        'ClientesModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(367, 352)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.BottonAceptar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CajaTelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CajaApellidos)
        Me.Controls.Add(Me.CajaEmail)
        Me.Controls.Add(Me.CajaDomicilio)
        Me.Controls.Add(Me.CajaNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ClientesModificar"
        Me.Text = "ClientesModificar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents CajaTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CajaApellidos As TextBox
    Friend WithEvents CajaEmail As TextBox
    Friend WithEvents CajaDomicilio As TextBox
    Friend WithEvents CajaNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelError As Label
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents BottonAceptar As Button
End Class
