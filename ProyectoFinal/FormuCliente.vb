Imports CapaNegocios
Public Class FormuCliente

    Dim cliente As New CapaNE
    Private Sub FormuCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PSolicitudes.Hide()
        DGVSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub BVerCatologo_Click(sender As Object, e As EventArgs) Handles BVerCatologo.Click
        Catalogo.Show()

    End Sub

    Private Sub BVerSolicitudes_Click(sender As Object, e As EventArgs) Handles BVerSolicitudes.Click
        PSolicitudes.Show()
        DGVSolicitudes.DataSource = cliente.SeleccionarSolicitudesxCliente(IIdCliente.Text)

    End Sub
End Class