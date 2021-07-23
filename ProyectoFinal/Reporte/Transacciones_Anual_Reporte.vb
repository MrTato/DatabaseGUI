Public Class Transacciones_Anual_Reporte
    Private Sub Transacciones_Anual_Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.FillByAnual(Me.DataSet.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class