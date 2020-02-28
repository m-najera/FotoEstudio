<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClienteServicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonSeleccionar = New System.Windows.Forms.Button()
        Me.BotonBuscar = New System.Windows.Forms.Button()
        Me.CajaBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridClientes = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonSeleccionar
        '
        Me.ButtonSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonSeleccionar.Location = New System.Drawing.Point(200, 336)
        Me.ButtonSeleccionar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonSeleccionar.Name = "ButtonSeleccionar"
        Me.ButtonSeleccionar.Size = New System.Drawing.Size(229, 43)
        Me.ButtonSeleccionar.TabIndex = 24
        Me.ButtonSeleccionar.Text = "Seleccionar cliente"
        Me.ButtonSeleccionar.UseVisualStyleBackColor = True
        '
        'BotonBuscar
        '
        Me.BotonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BotonBuscar.Location = New System.Drawing.Point(512, 14)
        Me.BotonBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BotonBuscar.Name = "BotonBuscar"
        Me.BotonBuscar.Size = New System.Drawing.Size(100, 28)
        Me.BotonBuscar.TabIndex = 22
        Me.BotonBuscar.Text = "Buscar"
        Me.BotonBuscar.UseVisualStyleBackColor = True
        '
        'CajaBuscar
        '
        Me.CajaBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CajaBuscar.Location = New System.Drawing.Point(76, 17)
        Me.CajaBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CajaBuscar.Name = "CajaBuscar"
        Me.CajaBuscar.Size = New System.Drawing.Size(411, 24)
        Me.CajaBuscar.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(15, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Buscar"
        '
        'DataGridClientes
        '
        Me.DataGridClientes.AllowUserToAddRows = False
        Me.DataGridClientes.BackgroundColor = System.Drawing.Color.LightCyan
        Me.DataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridClientes.Location = New System.Drawing.Point(15, 49)
        Me.DataGridClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridClientes.Name = "DataGridClientes"
        Me.DataGridClientes.ReadOnly = True
        Me.DataGridClientes.Size = New System.Drawing.Size(597, 267)
        Me.DataGridClientes.TabIndex = 18
        '
        'ClienteServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(628, 406)
        Me.Controls.Add(Me.ButtonSeleccionar)
        Me.Controls.Add(Me.BotonBuscar)
        Me.Controls.Add(Me.CajaBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridClientes)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClienteServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClienteServicio"
        CType(Me.DataGridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonSeleccionar As Button
    Friend WithEvents BotonBuscar As Button
    Friend WithEvents CajaBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridClientes As DataGridView
End Class
