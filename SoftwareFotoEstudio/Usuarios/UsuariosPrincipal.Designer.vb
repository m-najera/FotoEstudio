<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariosPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BotonBuscar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.BotonNuevoUsuario = New System.Windows.Forms.Button()
        Me.CajaBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridUsuarios = New System.Windows.Forms.DataGridView()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        CType(Me.DataGridUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BotonBuscar
        '
        Me.BotonBuscar.BackColor = System.Drawing.Color.White
        Me.BotonBuscar.Cursor = System.Windows.Forms.Cursors.Default
        Me.BotonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BotonBuscar.Location = New System.Drawing.Point(513, 59)
        Me.BotonBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BotonBuscar.Name = "BotonBuscar"
        Me.BotonBuscar.Size = New System.Drawing.Size(100, 28)
        Me.BotonBuscar.TabIndex = 14
        Me.BotonBuscar.Text = "Buscar"
        Me.BotonBuscar.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.White
        Me.ButtonEliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonEliminar.Location = New System.Drawing.Point(461, 386)
        Me.ButtonEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(116, 43)
        Me.ButtonEliminar.TabIndex = 12
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'BotonNuevoUsuario
        '
        Me.BotonNuevoUsuario.BackColor = System.Drawing.Color.White
        Me.BotonNuevoUsuario.Cursor = System.Windows.Forms.Cursors.Default
        Me.BotonNuevoUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BotonNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonNuevoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BotonNuevoUsuario.Location = New System.Drawing.Point(16, 15)
        Me.BotonNuevoUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BotonNuevoUsuario.Name = "BotonNuevoUsuario"
        Me.BotonNuevoUsuario.Size = New System.Drawing.Size(153, 32)
        Me.BotonNuevoUsuario.TabIndex = 11
        Me.BotonNuevoUsuario.Text = "Agregar Usuario"
        Me.BotonNuevoUsuario.UseVisualStyleBackColor = False
        '
        'CajaBuscar
        '
        Me.CajaBuscar.Location = New System.Drawing.Point(77, 63)
        Me.CajaBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CajaBuscar.Name = "CajaBuscar"
        Me.CajaBuscar.Size = New System.Drawing.Size(411, 22)
        Me.CajaBuscar.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Buscar"
        '
        'DataGridUsuarios
        '
        Me.DataGridUsuarios.AllowUserToAddRows = False
        Me.DataGridUsuarios.AllowUserToDeleteRows = False
        Me.DataGridUsuarios.AllowUserToResizeColumns = False
        Me.DataGridUsuarios.AllowUserToResizeRows = False
        Me.DataGridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridUsuarios.BackgroundColor = System.Drawing.Color.LightCyan
        Me.DataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridUsuarios.Location = New System.Drawing.Point(16, 95)
        Me.DataGridUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridUsuarios.MultiSelect = False
        Me.DataGridUsuarios.Name = "DataGridUsuarios"
        Me.DataGridUsuarios.ReadOnly = True
        Me.DataGridUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridUsuarios.Size = New System.Drawing.Size(597, 267)
        Me.DataGridUsuarios.TabIndex = 8
        '
        'ButtonModificar
        '
        Me.ButtonModificar.BackColor = System.Drawing.Color.White
        Me.ButtonModificar.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonModificar.Location = New System.Drawing.Point(77, 386)
        Me.ButtonModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(116, 43)
        Me.ButtonModificar.TabIndex = 15
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = False
        '
        'UsuariosPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(645, 444)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.BotonBuscar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.BotonNuevoUsuario)
        Me.Controls.Add(Me.CajaBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridUsuarios)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UsuariosPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Foto Estudio - Control de Usuarios"
        CType(Me.DataGridUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BotonBuscar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents BotonNuevoUsuario As Button
    Friend WithEvents CajaBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridUsuarios As DataGridView
    Friend WithEvents ButtonModificar As Button
End Class
