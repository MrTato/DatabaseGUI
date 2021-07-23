Imports System.Data.SqlClient

Public Class Detalle_Factura
    Private Sub Detalle_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.Producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.Fill(Me.DataSet.Producto)
        'TODO: This line of code loads data into the 'DataSet.Factura' table. You can move, or remove it, as needed.
        Me.FacturaTableAdapter.Fill(Me.DataSet.Factura)
        'TODO: This line of code loads data into the 'DataSet.Detalle_Factura' table. You can move, or remove it, as needed.
        Me.Detalle_FacturaTableAdapter.Fill(Me.DataSet.Detalle_Factura)

    End Sub

    Dim CONN As New SqlConnection(My.Settings.Proyecto_FinalConnectionString)

    Private Sub DATOS()
        Me.ProductoTableAdapter.Fill(Me.DataSet.Producto)
        Me.FacturaTableAdapter.Fill(Me.DataSet.Factura)
        Me.Detalle_FacturaTableAdapter.Fill(Me.DataSet.Detalle_Factura)
    End Sub

    Private Sub LIMPIAR()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox2.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.Detalle_FacturaTableAdapter.GetDataByFacturaProducto(TextBox1.Text, TextBox2.Text).Rows.Count = 0 Then
            Me.Detalle_FacturaTableAdapter.InsertQuery(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        Else
            Me.Detalle_FacturaTableAdapter.UpdateQuery(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        End If
        DATOS()
        MsgBox("Datos guardados correctamente")
        LIMPIAR()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Detalle_FacturaTableAdapter.DeleteQuery(TextBox1.Text, TextBox2.Text)
        DATOS()
        MsgBox("Datos eliminados correctamente")
        LIMPIAR()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        MOSTRARDETALLEFACTURA()
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        MOSTRARDETALLEFACTURA()
    End Sub

    Private Sub MOSTRARDETALLEFACTURA()
        TextBox1.Text = CStr(DataGridView1.CurrentRow.Cells(0).Value)
        TextBox2.Text = CStr(DataGridView1.CurrentRow.Cells(1).Value)
        TextBox3.Text = CStr(DataGridView1.CurrentRow.Cells(2).Value)
        TextBox4.Text = CStr(DataGridView1.CurrentRow.Cells(3).Value)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        MOSTRARFACTURA()
    End Sub

    Private Sub DataGridView2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellEnter
        MOSTRARFACTURA()
    End Sub

    Private Sub MOSTRARFACTURA()
        TextBox1.Text = CStr(DataGridView2.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        MOSTRARPRODUCTO()
    End Sub

    Private Sub DataGridView3_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellEnter
        MOSTRARPRODUCTO()
    End Sub

    Private Sub MOSTRARPRODUCTO()
        TextBox2.Text = CStr(DataGridView3.CurrentRow.Cells(0).Value)
    End Sub
End Class