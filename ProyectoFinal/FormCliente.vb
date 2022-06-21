Imports CapaNegocios
Public Class FormCliente

    Dim cliente As New CapaNE
    Private Sub BVerCatologo_Click(sender As Object, e As EventArgs) Handles BVerCatologo.Click
        Catalogo.Show()
    End Sub

    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PSolicitudes.Hide()
    End Sub

    Private Sub BVerSolicitudes_Click(sender As Object, e As EventArgs) Handles BVerSolicitudes.Click
        PSolicitudes.Show()
        DGVSolicitudes.DataSource = cliente.SeleccionarSolicitudesxCliente(LIDCliente.Text)
    End Sub

    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Me.Hide()
    End Sub
End Class