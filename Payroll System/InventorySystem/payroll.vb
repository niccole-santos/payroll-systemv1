Imports System.Data.OleDb
Imports System.String
Public Class payroll
    Private Sub payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sss.Text = "0"
        health.Text = "0"
        ibig.Text = "0"
        cca.Text = "0"

        currentrow1 = 0

        con.Close()

        con.Open()
        dad1 = New OleDbDataAdapter("SELECT * FROM employee ORDER BY Employee_ID", con)
        dad1.Fill(dst1, "employee")
        table2 = dst1.Tables
        Dim view As New DataView(table2(0))
        source2.DataSource = view
        dtgp.DataSource = view

        con.Close()

    End Sub

    Private Sub btncanci_Click(sender As Object, e As EventArgs) Handles btncanci.Click
        men.Show()
        Me.Close()
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtid.Clear()
        txtname.Clear()
        txtrate.Clear()
        sss.Clear()
        health.Clear()
        ibig.Clear()
        late.Clear()
        works.Clear()
        absentt.Clear()
        cca.Clear()

        sss.Text = "0"
        health.Text = "0"
        ibig.Text = "0"
        cca.Text = "0"

    End Sub

    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        Dim das As Integer = Integer.Parse(works.Text)
        Dim ssss As Integer = Integer.Parse(sss.Text)
        Dim healths As Integer = Integer.Parse(health.Text)
        Dim ibigs As Integer = Integer.Parse(ibig.Text)
        Dim lat As Integer = Integer.Parse(late.Text)
        Dim abss As Integer = Integer.Parse(absentt.Text)
        Dim rat As Integer = Integer.Parse(txtrate.Text)

        Dim ded As Integer
        Dim latt As Integer
        Dim absss As Integer
        Dim tots As Integer

        latt = 10 * lat
        absss = 300 * abss
        ded = healths + ibigs + ssss + latt + absss

        tots = rat * das

        salary.Text = tots - ded

    End Sub

    Private Sub btnfin_Click(sender As Object, e As EventArgs) Handles btnfin.Click
        Try
            con.Open()
            dst1.Clear()
            dad1 = New OleDbDataAdapter("SELECT * FROM employee where Employee_ID = " & txtid.Text.Trim(), con)
            dad1.Fill(dst1, "employee")
            con.Close()
            txtname.Text = dst1.Tables("employee").Rows(0)("Employee_Name")
            txtrate.Text() = dst1.Tables("employee").Rows(0)("Rate")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        con.Close()

        con.Open()
        dst1.Clear()
        dad1 = New OleDbDataAdapter("SELECT * FROM employee Order by Employee_ID", con)
        dad1.Fill(dst1, "employee")
        con.Close()
    End Sub
End Class