Imports System.Data.SqlClient

Public Class Respaldo
    Dim CONN As New SqlConnection(My.Settings.Proyecto_FinalConnectionString)

    Private Sub Respaldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ServerSQL As String = "LOCALHOST"
        Dim BD As String = "Proyecto_Final"

        Dim Address As String = "C:\Users\Public\" + TextBox1.Text + ".BAK"
        Dim sBackup As String = "BACKUP DATABASE " + BD + " TO DISK = N'" & Address & "' WITH NOFORMAT, NOINIT, NAME =N'" + BD + "-Full Database Backup',SKIP, STATS = 10"

        Dim csb As New SqlConnectionStringBuilder
        csb.DataSource = ServerSQL
        csb.InitialCatalog = BD
        csb.IntegratedSecurity = True

        CONN.Open()
        Dim cmdBackUp As New SqlCommand(sBackup, CONN)
        cmdBackUp.ExecuteNonQuery() '**** EJECUTAMOS EL RESPALDO
        CONN.Close()

        MsgBox("Respaldo realizado correctamente")
        Me.Close()
    End Sub
End Class