Imports System.Data.SqlClient

Public Class Detalle_Factura_Single
    Dim CONN As New SqlConnection(My.Settings.Proyecto_FinalConnectionString)

    Private Sub Detalle_Factura_Single_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.Factura' table. You can move, or remove it, as needed.
        Me.FacturaTableAdapter.Fill(Me.DataSet.Factura)
        'TODO: This line of code loads data into the 'DataSet.LastIDFactura' table. You can move, or remove it, as needed.
        Me.LastIDFacturaTableAdapter.Fill(Me.DataSet.LastIDFactura)
        TextBox4.Text = Me.LastIDFacturaTableAdapter.GetData().Rows(0)(0)
        'TODO: This line of code loads data into the 'DataSet.Producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.Fill(Me.DataSet.Producto)
        'TODO: This line of code loads data into the 'DataSet.Detalle_Factura' table. You can move, or remove it, as needed.
        Me.Detalle_FacturaTableAdapter.FillByFactura(Me.DataSet.Detalle_Factura, TextBox4.Text)
    End Sub

    Private Sub DATOS()
        Me.ProductoTableAdapter.Fill(Me.DataSet.Producto)
        Me.Detalle_FacturaTableAdapter.FillByFactura(Me.DataSet.Detalle_Factura, TextBox4.Text)
    End Sub

    Private Sub LIMPIAR()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.Detalle_FacturaTableAdapter.GetDataByFacturaProducto(TextBox4.Text, TextBox1.Text).Rows.Count = 0 Then
            Me.Detalle_FacturaTableAdapter.InsertQuery(TextBox4.Text, TextBox1.Text, TextBox2.Text)
        Else
            Me.Detalle_FacturaTableAdapter.UpdateQuery(TextBox4.Text, TextBox1.Text, TextBox2.Text)
        End If
        DATOS()
        LIMPIAR()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Detalle_FacturaTableAdapter.DeleteQuery(TextBox4.Text, TextBox1.Text)
        DATOS()
        LIMPIAR()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        MOSTRARDETALLEFACTURA()
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        MOSTRARDETALLEFACTURA()
    End Sub

    Private Sub MOSTRARDETALLEFACTURA()
        TextBox1.Text = CStr(DataGridView1.CurrentRow.Cells(1).Value)
        TextBox2.Text = CStr(DataGridView1.CurrentRow.Cells(2).Value)
        TextBox3.Text = CStr(DataGridView1.CurrentRow.Cells(3).Value)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        MOSTRARPRODUCTO()
    End Sub

    Private Sub DataGridView2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellEnter
        MOSTRARPRODUCTO()
    End Sub

    Private Sub MOSTRARPRODUCTO()
        TextBox1.Text = CStr(DataGridView2.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Factura.Show()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Detalle_FacturaTableAdapter.DeleteQueryFactura(TextBox4.Text)
        Me.LastIDFacturaTableAdapter.DeleteQuery()
        Me.FacturaTableAdapter.DeleteQuery(TextBox4.Text)
        Me.Close()
        Factura.MdiParent = MDI
        Factura.Show()
    End Sub
End Class