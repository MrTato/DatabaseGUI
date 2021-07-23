Public Class Test
    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.DataSet.Cliente)

    End Sub
End Class