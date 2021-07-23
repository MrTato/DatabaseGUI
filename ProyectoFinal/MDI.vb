Public Class MDI
    Public idLogin As String

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Cliente.MdiParent = Me
        Cliente.Show()
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        Producto.MdiParent = Me
        Producto.Show()
    End Sub

    Private Sub FacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaToolStripMenuItem.Click
        Factura.MdiParent = Me
        Factura.Show()
    End Sub

    Private Sub DetalleDeFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleDeFacturaToolStripMenuItem.Click
        Detalle_Factura.MdiParent = Me
        Detalle_Factura.Show()
    End Sub

    Private Sub RespaldarBaseDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RespaldarBaseDeDatosToolStripMenuItem.Click
        Respaldo.MdiParent = Me
        Respaldo.Show()
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        Usuario.MdiParent = Me
        Usuario.Show()
    End Sub

    Private Sub CambioDeClaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioDeClaveToolStripMenuItem.Click
        CambioClave.MdiParent = Me
        CambioClave.idLogin = Me.idLogin
        CambioClave.goBack = False
        CambioClave.Show()
    End Sub

    Private Sub MDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Enabled = False
        'Login.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AcercaDe.MdiParent = Me
        AcercaDe.Show()
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasToolStripMenuItem.Click
        Consulta.MdiParent = Me
        Consulta.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        ConsultaReporte.MdiParent = Me
        ConsultaReporte.Show()
    End Sub

    Private Sub TransaccionesDelDiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaccionesDelDiaToolStripMenuItem.Click
        Transacciones_Dia_Reporte.MdiParent = Me
        Transacciones_Dia_Reporte.Show()
    End Sub

    Private Sub TransaccionesDelMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaccionesDelMesToolStripMenuItem.Click
        Transacciones_Mes_Reporte.MdiParent = Me
        Transacciones_Mes_Reporte.Show()
    End Sub

    Private Sub TransaccionesAnualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaccionesAnualToolStripMenuItem.Click
        Transacciones_Anual_Reporte.MdiParent = Me
        Transacciones_Anual_Reporte.Show()
    End Sub

    Private Sub TransaccionesDeUnDiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaccionesDeUnDiaToolStripMenuItem.Click
        Transacciones_Especifico_Reporte.MdiParent = Me
        Transacciones_Especifico_Reporte.Show()
    End Sub
End Class