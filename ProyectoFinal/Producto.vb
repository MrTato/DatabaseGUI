Imports System.Data.SqlClient

Public Class Producto
    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.Producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.Fill(Me.DataSet.Producto)
    End Sub

    Dim CONN As New SqlConnection(My.Settings.Proyecto_FinalConnectionString)

    Private Sub DATOS()
        Me.ProductoTableAdapter.Fill(Me.DataSet.Producto)
    End Sub

    Private Sub LIMPIAR()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox2.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) = 0 Then
            Me.ProductoTableAdapter.InsertQuery(TextBox2.Text, TextBox3.Text, TextBox4.Text)
        Else
            Me.ProductoTableAdapter.UpdateQuery(TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox1.Text)
        End If
        DATOS()
        MsgBox("Datos guardados correctamente")
        LIMPIAR()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ProductoTableAdapter.DeleteQuery(TextBox1.Text)
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
    End Sub
End Class