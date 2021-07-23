Public Class CambioClave
    Public idLogin As String
    Public goBack As Boolean

    Private Sub CambioClave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.Usuario' table. You can move, or remove it, as needed.
        Me.UsuarioTableAdapter.Fill(Me.DataSet.Usuario)
        TextBox1.Text = idLogin
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.UsuarioTableAdapter.Validate(idLogin, MaskedTextBox1.Text) = 0 Then
            MsgBox("La clave anterior es incorrecta")
            MaskedTextBox1.Clear()
            MaskedTextBox1.Focus()
        ElseIf MaskedTextBox2.Text = MaskedTextBox3.Text Then
            Me.UsuarioTableAdapter.UpdateQueryClave(MaskedTextBox2.Text, idLogin)
            MsgBox("Clave cambiada")
            If goBack Then
                Usuario.Show()
            End If
            Me.Close()
        Else
            MsgBox("Las claves no coinciden")
            MaskedTextBox3.Clear()
            MaskedTextBox2.Clear()
        End If
    End Sub
End Class