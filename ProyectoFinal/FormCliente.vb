Imports CapaNegocios
Public Class FormCliente

    Dim cliente As New CapaNE
    Private Sub BVerCatologo_Click(sender As Object, e As EventArgs) Handles BVerCatologo.Click
        Catalogo.Show()
    End Sub

    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        PSolicitudes.Hide()
        LBienvenida.Text = "Bienvenido/a: " + cliente.BusquedaCliente(LIDCliente.Text).Rows(0)(1) + " " + cliente.BusquedaCliente(LIDCliente.Text).Rows(0)(2)
    End Sub

    Private Sub BVerSolicitudes_Click(sender As Object, e As EventArgs) Handles BVerSolicitudes.Click
        PSolicitudes.Show()
        DGVSolicitudes.DataSource = cliente.SeleccionarSolicitudesxCliente(LIDCliente.Text)
        LTotalSolicitudes.Text = "Solicitudes Totales " + cliente.SeleccionarSolicitudesxCliente(LIDCliente.Text).Rows.Count.ToString
    End Sub

    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Me.Hide()
    End Sub
End Class