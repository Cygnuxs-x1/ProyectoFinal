Imports CapaNegocios
Imports System.IO
Imports System.Drawing.Imaging

Public Class FormVenta
    Dim FormVenta As New CapaNE

    Private Sub btnSolicitarCompra_Click(sender As Object, e As EventArgs) Handles btnSolicitarCompra.Click
        Dim dialogo As DialogResult
        Dim pago As Integer
        dialogo = MessageBox.Show("¿Desea comfirmar la venta?", "Confirmar", MessageBoxButtons.YesNo)
        If dialogo = DialogResult.Yes Then
            If CBFormadePago.Text = "Efectivo" Then
                pago = 1
            Else
                pago = 0
            End If
            FormVenta.AltaVenta(LIdVehiculo.Text, LidEmpleado.Text, LIdCliente.Text, DTPFechaVenta.Value, FormVenta.BusquedaVehiculo(LIdVehiculo.Text).Rows(0)(5).ToString, CBCuotas.Text, pago)
        End If
            MessageBox.Show("La venta a sido realizada")
    End Sub

    Private Sub FormVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LIdCliente.Text = FormEmpleado.DGVSolicitudes.CurrentRow.Cells(1).Value
        LIdVehiculo.Text = FormEmpleado.DGVSolicitudes.CurrentRow.Cells(4).Value
        LidEmpleado.Text = FormEmpleado.LIdeEmpleado.Text

        LMarcaModelo.Text = FormVenta.BusquedaVehiculo(LIdVehiculo.Text).Rows(0)(1).ToString + " " + FormVenta.BusquedaVehiculo(LIdVehiculo.Text).Rows(0)(2).ToString
        LAño.Text = "Año: " + FormVenta.BusquedaVehiculo(LIdVehiculo.Text).Rows(0)(3).ToString
        LMotor.Text = "Motor: " + FormVenta.BusquedaVehiculo(LIdVehiculo.Text).Rows(0)(4).ToString
        LPrecio.Text = "Precio: " + FormVenta.BusquedaVehiculo(LIdVehiculo.Text).Rows(0)(5).ToString
        LAsientos.Text = "N° Asientos: " + FormVenta.BusquedaVehiculo(LIdVehiculo.Text).Rows(0)(6).ToString
        LVelocidad.Text = "N° Velocidades: " + FormVenta.BusquedaVehiculo(LIdVehiculo.Text).Rows(0)(7).ToString
        LPeso.Text = "Peso: " + FormVenta.BusquedaVehiculo(LIdVehiculo.Text).Rows(0)(8).ToString + " Kg"
        Dim var As Byte() = FormVenta.BusquedaVehiculo(LIdVehiculo.Text).Rows(0)(9)
        Dim ms As New MemoryStream(var)
        PbFotoVehiculo.Image = Image.FromStream(ms)
        LStock.Text = "Vehiculo Disponible"

        txtNombre.Text = FormVenta.BusquedaCliente(LIdCliente.Text).Rows(0)(1)
        txtApellido.Text = FormVenta.BusquedaCliente(LIdCliente.Text).Rows(0)(2)
        txtDni.Text = FormVenta.BusquedaCliente(LIdCliente.Text).Rows(0)(3)
        dtpFecha.Value = FormVenta.BusquedaCliente(LIdCliente.Text).Rows(0)(4)
        txtDireccion.Text = FormVenta.BusquedaCliente(LIdCliente.Text).Rows(0)(5)
        txtIdCliente.Text = LIdCliente.Text
        txtIdVehiculo.Text = LIdVehiculo.Text

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
    End Sub
End Class