Public Class FormCliente
    Private Sub BVerCatologo_Click(sender As Object, e As EventArgs) Handles BVerCatologo.Click
        Catalogo.Show()
    End Sub

    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PSolicitudes.Hide()
    End Sub
End Class