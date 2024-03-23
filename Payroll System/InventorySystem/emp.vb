Imports System.Data.OleDb
Imports System.String
Public Class emp
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
        men.Show()
    End Sub

    Private Sub btnremovee_Click(sender As Object, e As EventArgs) Handles btnremovee.Click
        remem.Show()
        Me.Hide()
        men.Hide()
    End Sub

    Private Sub btnadde_Click(sender As Object, e As EventArgs) Handles btnadde.Click
        addem.Show()
        men.Hide()
        Me.Hide()
    End Sub

    Private Sub emp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentrow1 = 0

        con.Close()

        con.Open()
        dad1 = New OleDbDataAdapter("SELECT * FROM employee ORDER BY Employee_ID", con)
        dad1.Fill(dst1, "employee")
        table2 = dst1.Tables

        Dim view As New DataView(table2(0))
        source2.DataSource = view
        dgvemp.DataSource = view
        con.Close()
    End Sub
End Class