Imports System.Data.SqlClient

Public Class Consulta
    Dim CONN As New SqlConnection(My.Settings.Proyecto_FinalConnectionString)

    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        MaskedTextBox1.Enabled = False
        If Val(TextBox1.Text) > 0 Then
            If ComboBox1.Text = "Mayor que" Then
                DataGridView1.DataSource = Me.DataTable1TableAdapter.GetDataByMayorQue(TextBox1.Text)
            ElseIf ComboBox1.Text = "Menor que" Then
                DataGridView1.DataSource = Me.DataTable1TableAdapter.GetDataByMenorQue(TextBox1.Text)
            ElseIf ComboBox1.Text = "Igual a" Then
                DataGridView1.DataSource = Me.DataTable1TableAdapter.GetDataByIgualA(TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        MaskedTextBox1.Enabled = False
        If Val(TextBox1.Text) > 0 Then
            If ComboBox1.Text = "Mayor que" Then
                DataGridView1.DataSource = Me.DataTable1TableAdapter.GetDataByMayorQue(TextBox1.Text)
            ElseIf ComboBox1.Text = "Menor que" Then
                DataGridView1.DataSource = Me.DataTable1TableAdapter.GetDataByMenorQue(TextBox1.Text)
            ElseIf ComboBox1.Text = "Igual a" Then
                DataGridView1.DataSource = Me.DataTable1TableAdapter.GetDataByIgualA(TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        MaskedTextBox1.Enabled = False
        DataGridView1.DataSource = Me.DataTable1TableAdapter.GetData()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        MaskedTextBox1.Enabled = False
        DataGridView1.DataSource = Me.DataTable1TableAdapter.GetDataByDia()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        MaskedTextBox1.Enabled = False
        DataGridView1.DataSource = Me.DataTable1TableAdapter.GetDataByMes()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        MaskedTextBox1.Enabled = False
        DataGridView1.DataSource = Me.DataTable1TableAdapter.GetDataByAnual()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        MaskedTextBox1.Enabled = True
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected
        DataGridView1.DataSource = Me.DataTable1TableAdapter.GetDataByFecha(MaskedTextBox1.Text)
    End Sub
End Class