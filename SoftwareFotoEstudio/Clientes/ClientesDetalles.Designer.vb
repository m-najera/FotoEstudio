<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clientesDetalles
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
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightCyan
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(383, 63)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(297, 245)
        Me.DataGridView1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 106)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Apellidos"
        '
        'CajaTelefono
        '
        Me.CajaTelefono.BackColor = System.Drawing.Color.White
        Me.CajaTelefono.Location = New System.Drawing.Point(128, 190)
        Me.CajaTelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CajaTelefono.Name = "CajaTelefono"
        Me.CajaTelefono.ReadOnly = True
        Me.CajaTelefono.Size = New System.Drawing.Size(208, 22)
        Me.CajaTelefono.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 193)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Telefono"
        '
        'CajaApellidos
        '
        Me.CajaApellidos.BackColor = System.Drawing.Color.White
        Me.CajaApellidos.Location = New System.Drawing.Point(128, 102)
        Me.CajaApellidos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CajaApellidos.Name = "CajaApellidos"
        Me.CajaApellidos.ReadOnly = True
        Me.CajaApellidos.Size = New System.Drawing.Size(208, 22)
        Me.CajaApellidos.TabIndex = 2
        '
        'CajaEmail
        '
        Me.CajaEmail.BackColor = System.Drawing.Color.White
        Me.CajaEmail.Location = New System.Drawing.Point(128, 236)
        Me.CajaEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CajaEmail.Name = "CajaEmail"
        Me.CajaEmail.ReadOnly = True
        Me.CajaEmail.Size = New System.Drawing.Size(208, 22)
        Me.CajaEmail.TabIndex = 5
        '
        'CajaDomicilio
        '
        Me.CajaDomicilio.BackColor = System.Drawing.Color.White
        Me.CajaDomicilio.Location = New System.Drawing.Point(128, 145)
        Me.CajaDomicilio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CajaDomicilio.Name = "CajaDomicilio"
        Me.CajaDomicilio.ReadOnly = True
        Me.CajaDomicilio.Size = New System.Drawing.Size(208, 22)
        Me.CajaDomicilio.TabIndex = 3
        '
        'CajaNombre
        '
        Me.CajaNombre.BackColor = System.Drawing.Color.White
        Me.CajaNombre.Location = New System.Drawing.Point(128, 63)
        Me.CajaNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CajaNombre.Name = "CajaNombre"
        Me.CajaNombre.ReadOnly = True
        Me.CajaNombre.Size = New System.Drawing.Size(208, 22)
        Me.CajaNombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 240)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 149)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Domicilio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(379, 32)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Compras y Presupuestos"
        '
        'clientesDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(712, 321)
        Me.Controls.Add(Me.Label6)
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
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "clientesDetalles"
        Me.Text = "clientesDetalles"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents Label6 As Label
End Class
