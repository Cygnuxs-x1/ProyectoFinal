Imports CapaNegocios

Public Class FormVenta
    Dim FormVenta As CapaNE

    Private Sub btnSolicitarCompra_Click(sender As Object, e As EventArgs) Handles btnSolicitarCompra.Click

        MessageBox.Show("¿Esta seguro que desea continuar?")

        '   If (messa) Then

        FormVenta.AltaSolicitud(txtIdCliente.Text, txtIdVehiculo.Text, txtEstado.Text)


    End Sub

    Private Sub FormVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FormAdmin.Show()
        Me.Hide()

    End Sub
End Class