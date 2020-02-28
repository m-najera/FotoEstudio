<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClientesAgregar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BottonGuardar = New System.Windows.Forms.Button()
        Me.CajaNombre = New System.Windows.Forms.TextBox()
        Me.CajaDomicilio = New System.Windows.Forms.TextBox()
        Me.CajaEmail = New System.Windows.Forms.TextBox()
        Me.CajaApellidos = New System.Windows.Forms.TextBox()
        Me.CajaTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.TextoError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Domicilio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 204)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email"
        '
        'BottonGuardar
        '
        Me.BottonGuardar.BackColor = System.Drawing.Color.White
        Me.BottonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BottonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BottonGuardar.Location = New System.Drawing.Point(16, 274)
        Me.BottonGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BottonGuardar.Name = "BottonGuardar"
        Me.BottonGuardar.Size = New System.Drawing.Size(100, 28)
        Me.BottonGuardar.TabIndex = 6
        Me.BottonGuardar.Text = "Guardar"
        Me.BottonGuardar.UseVisualStyleBackColor = False
        '
        'CajaNombre
        '
        Me.CajaNombre.Location = New System.Drawing.Point(100, 27)
        Me.CajaNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.CajaNombre.Name = "CajaNombre"
        Me.CajaNombre.Size = New System.Drawing.Size(208, 22)
        Me.CajaNombre.TabIndex = 1
        '
        'CajaDomicilio
        '
        Me.CajaDomicilio.Location = New System.Drawing.Point(100, 110)
        Me.CajaDomicilio.Margin = New System.Windows.Forms.Padding(4)
        Me.CajaDomicilio.Name = "CajaDomicilio"
        Me.CajaDomicilio.Size = New System.Drawing.Size(208, 22)
        Me.CajaDomicilio.TabIndex = 3
        '
        'CajaEmail
        '
        Me.CajaEmail.Location = New System.Drawing.Point(100, 201)
        Me.CajaEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.CajaEmail.Name = "CajaEmail"
        Me.CajaEmail.Size = New System.Drawing.Size(208, 22)
        Me.CajaEmail.TabIndex = 5
        '
        'CajaApellidos
        '
        Me.CajaApellidos.Location = New System.Drawing.Point(100, 66)
        Me.CajaApellidos.Margin = New System.Windows.Forms.Padding(4)
        Me.CajaApellidos.Name = "CajaApellidos"
        Me.CajaApellidos.Size = New System.Drawing.Size(208, 22)
        Me.CajaApellidos.TabIndex = 2
        '
        'CajaTelefono
        '
        Me.CajaTelefono.Location = New System.Drawing.Point(100, 154)
        Me.CajaTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.CajaTelefono.Name = "CajaTelefono"
        Me.CajaTelefono.Size = New System.Drawing.Size(208, 22)
        Me.CajaTelefono.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 158)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 70)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Apellidos"
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.Color.White
        Me.ButtonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelar.Location = New System.Drawing.Point(209, 274)
        Me.ButtonCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(100, 28)
        Me.ButtonCancelar.TabIndex = 7
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'TextoError
        '
        Me.TextoError.AutoSize = True
        Me.TextoError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoError.ForeColor = System.Drawing.Color.Red
        Me.TextoError.Location = New System.Drawing.Point(12, 240)
        Me.TextoError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TextoError.Name = "TextoError"
        Me.TextoError.Size = New System.Drawing.Size(109, 17)
        Me.TextoError.TabIndex = 57
        Me.TextoError.Text = "TEXTO ERROR"
        Me.TextoError.Visible = False
        '
        'ClientesAgregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(336, 338)
        Me.Controls.Add(Me.TextoError)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CajaTelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CajaApellidos)
        Me.Controls.Add(Me.CajaEmail)
        Me.Controls.Add(Me.CajaDomicilio)
        Me.Controls.Add(Me.CajaNombre)
        Me.Controls.Add(Me.BottonGuardar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ClientesAgregar"
        Me.Text = "clientesAgregar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BottonGuardar As Button
    Friend WithEvents CajaNombre As TextBox
    Friend WithEvents CajaDomicilio As TextBox
    Friend WithEvents CajaEmail As TextBox
    Friend WithEvents CajaApellidos As TextBox
    Friend WithEvents CajaTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents TextoError As Label
End Class
