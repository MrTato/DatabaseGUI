Public Class ConsultaReporte
    Private Sub ConsultaReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DataSet.DataTable1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) > 0 Then
            If ComboBox1.Text = "Mayor que" Then
                Me.DataTable1TableAdapter.FillByMayorQue(Me.DataSet.DataTable1, TextBox1.Text)
            ElseIf ComboBox1.Text = "Menor que" Then
                Me.DataTable1TableAdapter.FillByMenorQue(Me.DataSet.DataTable1, TextBox1.Text)
            ElseIf ComboBox1.Text = "Igual a" Then
                Me.DataTable1TableAdapter.FillByIgualA(Me.DataSet.DataTable1, TextBox1.Text)
            Else
                Me.DataTable1TableAdapter.Fill(Me.DataSet.DataTable1)
            End If
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub
End Class