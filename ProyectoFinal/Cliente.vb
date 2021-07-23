Imports System.Data.SqlClient

Public Class Cliente
    Dim CONN As New SqlConnection(My.Settings.Proyecto_FinalConnectionString)

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClienteTableAdapter.Fill(Me.DataSet.Cliente)

    End Sub

    Private Sub DATOS()
        Me.ClienteTableAdapter.Fill(Me.DataSet.Cliente)
    End Sub

    Private Sub LIMPIAR()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        CheckBox1.Checked = True
        TextBox2.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) = 0 Then
            Me.ClienteTableAdapter.InsertQuery(TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox7.Text, TextBox6.Text, TextBox8.Text, CheckBox1.Checked)
        Else
            Me.ClienteTableAdapter.UpdateQuery(TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox7.Text, TextBox6.Text, TextBox8.Text, CheckBox1.Checked, TextBox1.Text)
        End If
        DATOS()
        MsgBox("Datos guardados correctamente")
        LIMPIAR()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ClienteTableAdapter.DeleteQuery(TextBox1.Text)
        DATOS()
        MsgBox("Datos eliminados correctamente")
        LIMPIAR()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        MOSTRAR()
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        MOSTRAR()
    End Sub

    Private Sub MOSTRAR()
        TextBox1.Text = CStr(DataGridView1.CurrentRow.Cells(0).Value)
        TextBox2.Text = CStr(DataGridView1.CurrentRow.Cells(1).Value)
        TextBox3.Text = CStr(DataGridView1.CurrentRow.Cells(2).Value)
        TextBox4.Text = CStr(DataGridView1.CurrentRow.Cells(3).Value)
        TextBox5.Text = CStr(DataGridView1.CurrentRow.Cells(4).Value)
        TextBox7.Text = CStr(DataGridView1.CurrentRow.Cells(5).Value)
        TextBox6.Text = CStr(DataGridView1.CurrentRow.Cells(6).Value)
        TextBox8.Text = CStr(DataGridView1.CurrentRow.Cells(7).Value)
        CheckBox1.Checked = CStr(DataGridView1.CurrentRow.Cells(8).Value)

    End Sub
End Class