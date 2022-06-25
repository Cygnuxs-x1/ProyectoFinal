Imports CapaNegocios
Imports System.IO
Public Class FormEmpleado

    Dim persona As New CapaNE

    Dim dni As Integer
    Private Sub FormEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LIdeEmpleado.Text = persona.LoginEmpleado(FormLogin.TBDocumento.Text, FormLogin.TBContreaseña.Text).Rows(0)(0)
        Dim var As Byte() = persona.LoginEmpleado(FormLogin.TBDocumento.Text, FormLogin.TBContreaseña.Text).Rows(0)(7)
        LVentasRealizadas.Text = "Total de Ventas Realizadas: " + persona.SeleccionarVentasxEmpleado(LIdeEmpleado.Text).Rows.Count.ToString
        Dim ms As New MemoryStream(var)
        PBFoto.Image = Image.FromStream(ms)
        DGVSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
<<<<<<< HEAD
        DGVVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVVentas.DataSource = persona.SeleccionarVentasxEmpleado(LIdeEmpleado.Text)
        PSolicitudes.Hide()
=======
        PSolicitudes.Hide()
        PPerfil.Show()
>>>>>>> b484225b2d52cdd1b6e47498807e5b0ad6e0db63
    End Sub

    Private Sub btnIrCatalogo_Click(sender As Object, e As EventArgs) Handles btnIrCatalogo.Click

    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        FormLogin.Show()
<<<<<<< HEAD
        Me.Close()
    End Sub

    Private Sub BSolicitudes_Click() Handles BSolicitudes.Click
        PSolicitudes.Show()
        PSolicitudes.BringToFront()
=======
        Me.Hide()
    End Sub

    Private Sub BSolicitudes_Click() Handles BSolicitudes.Click
        PaSolicitudes.Show()
        PPerfil.Hide()
>>>>>>> b484225b2d52cdd1b6e47498807e5b0ad6e0db63
        LSolicitudes.Text = "Total de Solicitudes: " + persona.SeleccionarSolicitud.Rows.Count.ToString
        DGVSolicitudes.DataSource = persona.SeleccionarSolicitud
    End Sub

    Private Sub BAprobarVenta_Click(sender As Object, e As EventArgs) Handles BAprobarVenta.Click
        persona.ModificarEstadoSolicitud(DGVSolicitudes.CurrentRow.Cells(0).Value, CBEstadoSolicitud.Text)
        If CBEstadoSolicitud.Text = "Aprobada" Then
            FormVenta.Show()
        End If
        DGVSolicitudes.DataSource = persona.SeleccionarSolicitud
    End Sub

    Private Sub btnMiPerfil_Click(sender As Object, e As EventArgs) Handles btnMiPerfil.Click
<<<<<<< HEAD
        PSolicitudes.Hide()
        DGVVentas.DataSource = persona.SeleccionarVentasxEmpleado(LIdeEmpleado.Text)
=======
        PPerfil.Show()
        PaSolicitudes.Hide()
        LDocumento.Text = "Dni: " + FormLogin.TBDocumento.Text
        LNombreApellido.Text = "Bienvenido: " + persona.LoginEmpleado(FormLogin.TBDocumento.Text, FormLogin.TBContreaseña.Text).Rows(0)(1) + " " + persona.LoginEmpleado(FormLogin.TBDocumento.Text, FormLogin.TBContreaseña.Text).Rows(0)(2)
    End Sub

    Private Sub PanelMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelMenu.Paint

>>>>>>> b484225b2d52cdd1b6e47498807e5b0ad6e0db63
    End Sub
End Class