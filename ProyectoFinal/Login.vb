Public Class Login

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.Usuario' table. You can move, or remove it, as needed.
        Me.UsuarioTableAdapter.Fill(Me.DataSet.Usuario)
        MaximizeBox = False

    End Sub

    Private Sub ButtonAccept_Click(sender As Object, e As EventArgs) Handles ButtonAccept.Click
        If Me.UsuarioTableAdapter.Validate(TextBoxUsuario.Text, MaskedTextBoxPassword.Text) = 0 Then
            MsgBox("Usuario invalido. Intente nuevamente")
            TextBoxUsuario.Clear()
            MaskedTextBoxPassword.Clear()
            TextBoxUsuario.Focus()
            Exit Sub
        Else
            MDI.Enabled = True
            MDI.idLogin = TextBoxUsuario.Text
            Me.Close()
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        MDI.Close()
        Me.Close()
    End Sub
End Class
