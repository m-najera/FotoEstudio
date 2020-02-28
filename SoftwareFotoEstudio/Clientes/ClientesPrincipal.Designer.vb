<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesPrincipal
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
        Me.DataGridClientes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CajaBuscar = New System.Windows.Forms.TextBox()
        Me.BotonNuevoCliente = New System.Windows.Forms.Button()
        Me.BotonEliminar = New System.Windows.Forms.Button()
        Me.BotonBuscar = New System.Windows.Forms.Button()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonDetalles = New System.Windows.Forms.Button()
        CType(Me.DataGridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridClientes
        '
        Me.DataGridClientes.AllowUserToAddRows = False
        Me.DataGridClientes.BackgroundColor = System.Drawing.Color.LightCyan
        Me.DataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridClientes.Location = New System.Drawing.Point(16, 98)
        Me.DataGridClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridClientes.Name = "DataGridClientes"
        Me.DataGridClientes.ReadOnly = True
        Me.DataGridClientes.Size = New System.Drawing.Size(597, 267)
        Me.DataGridClientes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar"
        '
        'CajaBuscar
        '
        Me.CajaBuscar.Location = New System.Drawing.Point(77, 66)
        Me.CajaBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CajaBuscar.Name = "CajaBuscar"
        Me.CajaBuscar.Size = New System.Drawing.Size(411, 22)
        Me.CajaBuscar.TabIndex = 2
        '
        'BotonNuevoCliente
        '
        Me.BotonNuevoCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BotonNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonNuevoCliente.Location = New System.Drawing.Point(16, 18)
        Me.BotonNuevoCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BotonNuevoCliente.Name = "BotonNuevoCliente"
        Me.BotonNuevoCliente.Size = New System.Drawing.Size(153, 41)
        Me.BotonNuevoCliente.TabIndex = 3
        Me.BotonNuevoCliente.Text = "Nuevo Cliente"
        Me.BotonNuevoCliente.UseVisualStyleBackColor = True
        '
        'BotonEliminar
        '
        Me.BotonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BotonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonEliminar.Location = New System.Drawing.Point(468, 386)
        Me.BotonEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BotonEliminar.Name = "BotonEliminar"
        Me.BotonEliminar.Size = New System.Drawing.Size(116, 43)
        Me.BotonEliminar.TabIndex = 5
        Me.BotonEliminar.Text = "Eliminar"
        Me.BotonEliminar.UseVisualStyleBackColor = True
        '
        'BotonBuscar
        '
        Me.BotonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonBuscar.Location = New System.Drawing.Point(513, 63)
        Me.BotonBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BotonBuscar.Name = "BotonBuscar"
        Me.BotonBuscar.Size = New System.Drawing.Size(100, 28)
        Me.BotonBuscar.TabIndex = 7
        Me.BotonBuscar.Text = "Buscar"
        Me.BotonBuscar.UseVisualStyleBackColor = True
        '
        'ButtonModificar
        '
        Me.ButtonModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificar.Location = New System.Drawing.Point(259, 386)
        Me.ButtonModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(116, 43)
        Me.ButtonModificar.TabIndex = 17
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = True
        '
        'ButtonDetalles
        '
        Me.ButtonDetalles.Enabled = False
        Me.ButtonDetalles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDetalles.Location = New System.Drawing.Point(53, 386)
        Me.ButtonDetalles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonDetalles.Name = "ButtonDetalles"
        Me.ButtonDetalles.Size = New System.Drawing.Size(116, 43)
        Me.ButtonDetalles.TabIndex = 16
        Me.ButtonDetalles.Text = "Detalles"
        Me.ButtonDetalles.UseVisualStyleBackColor = True
        Me.ButtonDetalles.Visible = False
        '
        'ClientesPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(645, 444)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.ButtonDetalles)
        Me.Controls.Add(Me.BotonBuscar)
        Me.Controls.Add(Me.BotonEliminar)
        Me.Controls.Add(Me.BotonNuevoCliente)
        Me.Controls.Add(Me.CajaBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ClientesPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClientesPrincipal"
        Me.TopMost = True
        CType(Me.DataGridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridClientes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CajaBuscar As TextBox
    Friend WithEvents BotonNuevoCliente As Button
    Friend WithEvents BotonEliminar As Button
    Friend WithEvents BotonBuscar As Button
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonDetalles As Button
End Class
