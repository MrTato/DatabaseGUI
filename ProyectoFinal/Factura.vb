Imports System.Data.SqlClient

Public Class Factura
    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.Factura' table. You can move, or remove it, as needed.
        Me.FacturaTableAdapter.Fill(Me.DataSet.Factura)

        Me.ClienteTableAdapter.FillBy1(Me.DataSet.Cliente)

    End Sub

    Dim CONN As New SqlConnection(My.Settings.Proyecto_FinalConnectionString)

    Private Sub DATOS()
        Me.FacturaTableAdapter.Fill(Me.DataSet.Factura)
        Me.ClienteTableAdapter.FillBy1(Me.DataSet.Cliente)
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
            If Val(TextBox2.Text) = 0 Then
                Me.FacturaTableAdapter.InsertQueryDefaultDate(TextBox3.Text)
            Else
                Me.FacturaTableAdapter.InsertQuery(DateTime.Parse(TextBox2.Text), TextBox3.Text)
            End If
            Me.Close()
            Detalle_Factura_Single.Show()
        Else
            Me.FacturaTableAdapter.UpdateQuery(DateTime.Parse(TextBox2.Text), TextBox3.Text, TextBox1.Text)
            MsgBox("Datos guardados correctamente")
        End If
        DATOS()
        LIMPIAR()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.FacturaTableAdapter.DeleteQuery(TextBox1.Text)
        DATOS()
        MsgBox("Datos eliminados correctamente")
        LIMPIAR()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        MOSTRARFACTURA()
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        MOSTRARFACTURA()
    End Sub

    Private Sub MOSTRARFACTURA()
        TextBox1.Text = CStr(DataGridView1.CurrentRow.Cells(0).Value)
        TextBox2.Text = CStr(DataGridView1.CurrentRow.Cells(1).Value)
        TextBox3.Text = CStr(DataGridView1.CurrentRow.Cells(2).Value)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        MOSTRARCLIENTE()
    End Sub

    Private Sub DataGridView2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellEnter
        MOSTRARCLIENTE()
    End Sub

    Private Sub MOSTRARCLIENTE()
        TextBox3.Text = CStr(DataGridView2.CurrentRow.Cells(0).Value)
    End Sub
End Class