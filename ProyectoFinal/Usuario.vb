Imports System.Data.SqlClient

Public Class Usuario
    Dim CONN As New SqlConnection(My.Settings.Proyecto_FinalConnectionString)

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.Usuario' table. You can move, or remove it, as needed.
        Me.UsuarioTableAdapter.Fill(Me.DataSet.Usuario)

    End Sub

    Private Sub DATOS()
        Me.UsuarioTableAdapter.Fill(Me.DataSet.Usuario)
    End Sub

    Private Sub LIMPIAR()
        TextBox1.Clear()
        MaskedTextBox1.Clear()
        CheckBox1.Checked = True
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim answer As DialogResult

        If Me.UsuarioTableAdapter.GetDataByID(TextBox1.Text).Rows.Count = 0 Then
            answer = MessageBox.Show("¿Crear nuevo usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = vbYes Then
                Me.UsuarioTableAdapter.InsertQuery(TextBox1.Text, MaskedTextBox1.Text, CheckBox1.Checked)
                MsgBox("Usuario creado")
                DATOS()
            Else
                MsgBox("No se creo usuario")
            End If
        Else
            answer = MessageBox.Show("Usuario ya existe. ¿Desea cambiar los datos del usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If answer = vbYes Then
                If Val(MaskedTextBox1.Text) = 0 Then
                    Me.UsuarioTableAdapter.UpdateQueryEstado(CheckBox1.Checked, TextBox1.Text)
                    MsgBox("Se cambiaron los datos del usuario")
                Else
                    CambioClave.MdiParent = MDI
                    CambioClave.idLogin = TextBox1.Text
                    CambioClave.MaskedTextBox2.Text = MaskedTextBox1.Text
                    CambioClave.Show()
                    CambioClave.goBack = True
                    Me.Close()
                End If
                DATOS()
                Else
                    MsgBox("No se cambiaron los datos del usuario")
            End If
        End If
        LIMPIAR()
    End Sub

    'Dim answer As DialogResult
    'answer = MessageBox.Show("Was nobugz here?", "Yes/no sample", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    'If answer = vbYes Then
    '  Debug.Print("He waz")
    'End If

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        MOSTRAR()
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        MOSTRAR()
    End Sub

    Private Sub MOSTRAR()
        TextBox1.Text = CStr(DataGridView1.CurrentRow.Cells(0).Value)
        CheckBox1.Checked = CStr(DataGridView1.CurrentRow.Cells(1).Value)

    End Sub
End Class