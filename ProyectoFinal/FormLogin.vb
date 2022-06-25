Imports CapaNegocios
Imports System.Drawing.Imaging
Imports System.IO
Public Class FormLogin

    Dim persona As New CapaNE
    Private Sub BEntrar_Click(sender As Object, e As EventArgs) Handles BEntrar.Click
        If TBDocumento.Text = "1234" And TBContreaseña.Text = "1234" Then
            FormAdmin.Show()
        Else
            If persona.LoginEmpleado(TBDocumento.Text, TBContreaseña.Text).Rows.Count <> 0 Then
                FormEmpleado.Show()
            Else

                If persona.LoginCliente(TBDocumento.Text, TBContreaseña.Text).Rows.Count <> 0 Then
                    FormuCliente.IIdCliente.Text = persona.LoginCliente(TBDocumento.Text, TBContreaseña.Text).Rows(0)(0)
                    FormuCliente.Show()
                Else
                    MessageBox.Show("Usuario o contraseña incorrecta")
                End If
            End If
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelDato.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Environment.Exit(0)
    End Sub

    Private Sub BCrearUsuario_Click(sender As Object, e As EventArgs) Handles BCrearUsuario.Click
        PanelDato.Show()
    End Sub

    Private Sub BSubirFoto_Click(sender As Object, e As EventArgs) Handles BSubirFoto.Click
        Dim dialgo As New OpenFileDialog
        dialgo.Filter = "images|*.jpg;*.png;*.gif;*.bmp"

        If dialgo.ShowDialog = Windows.Forms.DialogResult.OK Then
            PBFoto.Image = Image.FromFile(dialgo.FileName)
        End If
    End Sub

    Private Sub BCrearNuevoUsuario_Click(sender As Object, e As EventArgs) Handles BCrearNuevoUsuario.Click
        Dim memorystream As New MemoryStream
        PBFoto.Image.Save(memorystream, PBFoto.Image.RawFormat)
        persona.AltaCliente(TBNombre.Text, TBApellido.Text, TBDocumentoN.Text, DTPNacimiento.Value, TBDireccion.Text, TBContraseña.Text, memorystream.ToArray)
        MessageBox.Show("Usuario Creado")
    End Sub
End Class