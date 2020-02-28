<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detallesAlbum
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantidadFotos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiseño = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDetalles = New System.Windows.Forms.TextBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Detalles"
        '
        'txtCantidadFotos
        '
        Me.txtCantidadFotos.Location = New System.Drawing.Point(119, 92)
        Me.txtCantidadFotos.Name = "txtCantidadFotos"
        Me.txtCantidadFotos.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadFotos.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad de fotos "
        '
        'txtDiseño
        '
        Me.txtDiseño.Location = New System.Drawing.Point(119, 118)
        Me.txtDiseño.Name = "txtDiseño"
        Me.txtDiseño.Size = New System.Drawing.Size(100, 20)
        Me.txtDiseño.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Diseño"
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(119, 144)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(100, 20)
        Me.txtCosto.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Costo                 $"
        '
        'txtDetalles
        '
        Me.txtDetalles.Location = New System.Drawing.Point(119, 28)
        Me.txtDetalles.Multiline = True
        Me.txtDetalles.Name = "txtDetalles"
        Me.txtDetalles.Size = New System.Drawing.Size(134, 57)
        Me.txtDetalles.TabIndex = 3
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.White
        Me.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnRegresar.Location = New System.Drawing.Point(119, 224)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 8
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Location = New System.Drawing.Point(33, 176)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(0, 13)
        Me.LabelError.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(35, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "TEXTO ERROR"
        Me.Label7.Visible = False
        '
        'detallesAlbum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(312, 288)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDiseño)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCantidadFotos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDetalles)
        Me.Controls.Add(Me.Label2)
        Me.Name = "detallesAlbum"
        Me.Text = "Detalles de Album"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCantidadFotos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDiseño As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDetalles As TextBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents LabelError As Label
    Friend WithEvents Label7 As Label
End Class
