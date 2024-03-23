Public Class men
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("MM/dd/yyyy" + vbCrLf + "hh:mm:ss")
    End Sub

    Private Sub men_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        addss.Visible = False
        btncanc.Visible = False
        btnnview.Visible = False

    End Sub

    Private Sub bttnlog_Click(sender As Object, e As EventArgs) Handles bttnlog.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnsto_Click(sender As Object, e As EventArgs) Handles btnsto.Click
        btncanc.Visible = True
        addss.Visible = True
        btnnview.Visible = True
    End Sub

    Private Sub btncanc_Click(sender As Object, e As EventArgs) Handles btncanc.Click
        btncanc.Visible = False
        btnnview.Visible = False
        addss.Visible = False
    End Sub

    Private Sub btnnview_Click(sender As Object, e As EventArgs) Handles btnnview.Click
        stoview.Show()
        Me.Hide()
    End Sub

    Private Sub btnemplo_Click(sender As Object, e As EventArgs) Handles btnemplo.Click
        emp.Show()
        Me.Hide()
    End Sub

    Private Sub btnpay_Click(sender As Object, e As EventArgs) Handles btnpay.Click
        payroll.Show()
        Me.Hide()
    End Sub

    Private Sub btnsales_Click(sender As Object, e As EventArgs) Handles btnsales.Click
        sale.show()
        Me.Hide()
    End Sub

    Private Sub btnpos_Click(sender As Object, e As EventArgs) Handles btnpos.Click
        poss.Show()
        Me.Hide()
    End Sub

    Private Sub addss_Click(sender As Object, e As EventArgs) Handles addss.Click
        adds.show()
        Me.Hide()
    End Sub
End Class