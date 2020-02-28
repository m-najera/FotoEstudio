<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiciosPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServiciosPrincipal))
        Me.ButtonNuevo = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.ButtonServicioAbonos = New System.Windows.Forms.Button()
        Me.ButtonHistoricoAbonos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonNuevo
        '
        Me.ButtonNuevo.BackColor = System.Drawing.Color.White
        Me.ButtonNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNuevo.Location = New System.Drawing.Point(32, 39)
        Me.ButtonNuevo.Name = "ButtonNuevo"
        Me.ButtonNuevo.Size = New System.Drawing.Size(100, 76)
        Me.ButtonNuevo.TabIndex = 1
        Me.ButtonNuevo.Text = "Registrar Nueva Venta"
        Me.ButtonNuevo.UseVisualStyleBackColor = False
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.Color.White
        Me.ButtonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscar.Location = New System.Drawing.Point(293, 39)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(100, 76)
        Me.ButtonBuscar.TabIndex = 3
        Me.ButtonBuscar.Text = "Buscar Tickets"
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'ButtonServicioAbonos
        '
        Me.ButtonServicioAbonos.BackColor = System.Drawing.Color.White
        Me.ButtonServicioAbonos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonServicioAbonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonServicioAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonServicioAbonos.Location = New System.Drawing.Point(162, 162)
        Me.ButtonServicioAbonos.Name = "ButtonServicioAbonos"
        Me.ButtonServicioAbonos.Size = New System.Drawing.Size(100, 76)
        Me.ButtonServicioAbonos.TabIndex = 4
        Me.ButtonServicioAbonos.Text = "Registrar Abonos"
        Me.ButtonServicioAbonos.UseVisualStyleBackColor = False
        '
        'ButtonHistoricoAbonos
        '
        Me.ButtonHistoricoAbonos.BackColor = System.Drawing.Color.White
        Me.ButtonHistoricoAbonos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonHistoricoAbonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHistoricoAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHistoricoAbonos.Location = New System.Drawing.Point(162, 39)
        Me.ButtonHistoricoAbonos.Name = "ButtonHistoricoAbonos"
        Me.ButtonHistoricoAbonos.Size = New System.Drawing.Size(100, 76)
        Me.ButtonHistoricoAbonos.TabIndex = 5
        Me.ButtonHistoricoAbonos.Text = "Historial de Abonos"
        Me.ButtonHistoricoAbonos.UseVisualStyleBackColor = False
        '
        'ServiciosPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(469, 399)
        Me.Controls.Add(Me.ButtonHistoricoAbonos)
        Me.Controls.Add(Me.ButtonServicioAbonos)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.ButtonNuevo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ServiciosPrincipal"
        Me.Text = "Servicios"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonNuevo As Button
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents ButtonServicioAbonos As System.Windows.Forms.Button
    Friend WithEvents ButtonHistoricoAbonos As System.Windows.Forms.Button
End Class
