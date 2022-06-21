Imports CapaNegocios
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
                    FormCliente.LIDCliente.Text = persona.LoginCliente(TBDocumento.Text, TBContreaseña.Text).Rows(0)(0)
                    FormCliente.Show()
                End If
            End If
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Environment.Exit(0)

    End Sub


    'COMENTARIO



    ' // hi ///

End Class