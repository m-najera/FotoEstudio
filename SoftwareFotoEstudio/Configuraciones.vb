Imports MySql.Data.MySqlClient
Public Class Configuraciones



    Private Sub ButtonCambiarImg_Click(sender As Object, e As EventArgs) Handles ButtonCambiarImg.Click
        Dim a As New OpenFileDialog

        a.Filter = "Imagenes|*.jpg;*.png;*.jpeg"
        a.Multiselect = False
        Dim resultado As DialogResult = a.ShowDialog()
        If resultado = DialogResult.OK Then
            PictureBox1.Image = New Bitmap("default.png")
            If FileIO.FileSystem.FileExists("logo.png") Then
                FileIO.FileSystem.DeleteFile("logo.png")
            End If
            Dim directorio As String = a.FileName
            Try
                Dim imagen As New Bitmap(directorio)


                PictureBox1.Image() = imagen
                Threading.Thread.Sleep(200)
                imagen.Save("logo.png")

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub Configuraciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim iniciar As New IniciarSesion
        iniciar.Show()
    End Sub

    Private Sub ButtonCambiarDir_Click(sender As Object, e As EventArgs) Handles ButtonCambiarDir.Click
        ButtonCambiarDir.Visible = False
        ButtonCambiarDir.Enabled = False
        ButtonGuardarDir.Visible = True
        ButtonGuardarDir.Enabled = True
        ButtonCancelarDir.Visible = True
        ButtonCancelarDir.Enabled = True
        TextBoxDireccion.Enabled = True
        TextBoxDireccion.ReadOnly = False
    End Sub

    Private Sub Configuraciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxDireccion.Text = My.Settings.dir
    End Sub

    Private Sub ButtonGuardarDir_Click(sender As Object, e As EventArgs) Handles ButtonGuardarDir.Click
        ButtonCambiarDir.Visible = True
        ButtonCambiarDir.Enabled = True
        ButtonGuardarDir.Visible = False
        ButtonGuardarDir.Enabled = False
        ButtonCancelarDir.Visible = False
        ButtonCancelarDir.Enabled = False
        TextBoxDireccion.Enabled = False
        TextBoxDireccion.ReadOnly = True

        My.Settings.dir = TextBoxDireccion.Text
        My.Settings.Save()
        TextBoxDireccion.Text = My.Settings.dir

    End Sub

    Private Sub ButtonCancelarDir_Click(sender As Object, e As EventArgs) Handles ButtonCancelarDir.Click
        ButtonCambiarDir.Visible = True
        ButtonCambiarDir.Enabled = True
        ButtonGuardarDir.Visible = False
        ButtonGuardarDir.Enabled = False
        ButtonCancelarDir.Visible = False
        ButtonCancelarDir.Enabled = False
        TextBoxDireccion.Enabled = False
        TextBoxDireccion.ReadOnly = True

        TextBoxDireccion.Text = My.Settings.dir
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonGuardarR_Click(sender As Object, e As EventArgs) Handles ButtonGuardarR.Click
        Dim save As New SaveFileDialog()
        save.Filter = "MySQL DataBase|*.sql"
        save.DefaultExt = ".sql"
        Dim resultado As String = save.ShowDialog()
        If resultado = 1 Then
            Dim db As New BDConexiones
            Dim res As Boolean = db.CrearRespaldo(save.FileName)
            If res Then
                MsgBox("Base de datos guardada con Exito")
            Else
                MsgBox("No se pudo guardar la base de datos", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub ButtonCargarR_Click(sender As Object, e As EventArgs) Handles ButtonCargarR.Click
        Dim load As New OpenFileDialog()
        Dim resultado As String = load.ShowDialog()
        load.Filter = "MySQL DataBase|*.sql|Todos los archivos|*.*"
        If resultado = 1 Then
            Dim db As New BDConexiones
            Dim res As Boolean = db.CargarRespaldo(load.FileName)
            If res Then
                MsgBox("Base de datos restaurada con Exito")
            Else
                MsgBox("No se pudo cargar la base de datos", MsgBoxStyle.Critical)
            End If
        End If

    End Sub
End Class