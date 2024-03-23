Imports System.Data.OleDb
Imports System.String
Public Class remem
    Private Sub btncanc_Click(sender As Object, e As EventArgs) Handles btncanc.Click
        Me.Close()
        emp.Show()
    End Sub

    Private Sub btnfind_Click(sender As Object, e As EventArgs) Handles btnfind.Click

        con.Close()

        Try
            con.Open()
            dst1.Clear()
            dad1 = New OleDbDataAdapter("SELECT * FROM employee where Employee_ID = " & txtid.Text.Trim(), con)
            dad1.Fill(dst1, "employee")
            con.Close()
            txtname.Text = dst1.Tables("employee").Rows(0)("Employee_Name")
            gender.Text = dst1.Tables("employee").Rows(0)("Gender")
            birth.Text = dst1.Tables("employee").Rows(0)("Birthday")
            yearss.Text = dst1.Tables("employee").Rows(0)("Age")
            nume.Text = dst1.Tables("employee").Rows(0)("Contact_Number")
            txtdep.Text() = dst1.Tables("employee").Rows(0)("Department")
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

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Dim str As String

        Try
            str = "DELETE from employee where Employee_ID= "
            str += txtid.Text.Trim()
            con.Open()
            cmd1 = New OleDbCommand(str, con)
            cmd1.ExecuteNonQuery()

            dst1.Clear()
            dad1 = New OleDbDataAdapter("SELECT* FROM employee ORDER BY Employee_ID ", con)
            dad1.Fill(dst1, "employee")
            MsgBox("EMPLOYEE REMOVED SUCCESSFULY.")

            txtid.Text = ""
            txtname.Text = ""
            gender.Text = ""
            birth.Text = ""
            yearss.Text = ""
            nume.Text = ""
            txtdep.Text = ""
            txtrate.Text = ""

            If currentrow1 > 0 Then
                currentrow1 = currentrow1 - 1
                txtname.Text = dst1.Tables("employee").Rows(currentrow1)("Employee_Name")
                gender.Text = dst1.Tables("employee").Rows(currentrow1)("Gender")
                birth.Text = dst1.Tables("employee").Rows(currentrow1)("Birthday")
                yearss.Text = dst1.Tables("employee").Rows(currentrow1)("Age")
                nume.Text = dst1.Tables("employee").Rows(currentrow1)("Contact_Number")
                txtdep.Text = dst1.Tables("employee").Rows(currentrow1)("Department")
                txtrate.Text = dst1.Tables("employee").Rows(currentrow1)("Rate")

                con.Close()

            End If
        Catch ex As Exception
            MessageBox.Show("EMPLOYEE CANNOT BE REMOVED.")
            MsgBox(ex.Message & "_" & ex.Source)
            con.Close()
        End Try
    End Sub
End Class