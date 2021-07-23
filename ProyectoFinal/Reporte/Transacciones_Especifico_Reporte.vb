Public Class Transacciones_Especifico_Reporte
    Private Sub Transacciones_Especifico_Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DataSet.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(MaskedTextBox1.Text) = 0 Then
            Me.DataTable1TableAdapter.Fill(Me.DataSet.DataTable1)
        Else
            Me.DataTable1TableAdapter.FillByFecha(Me.DataSet.DataTable1, MaskedTextBox1.Text)
        End If
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class