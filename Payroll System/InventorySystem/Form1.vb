Public Class Form1
    Private Sub btnex_Click(sender As Object, e As EventArgs) Handles btnex.Click
        Me.Close()
    End Sub

    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        If txtpass.Text = "1234" Then
            men.Show()
            Me.Hide()
            txtpass.Clear()
        Else
            MsgBox("The password you entered is incorrect!", MsgBoxStyle.Exclamation, "INCORRECT PASSWORD")
            txtpass.Clear()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btnlog
    End Sub
End Class
