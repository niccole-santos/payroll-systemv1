Imports System.Data.OleDb
Imports System.String
Public Class addem
    Dim gender As String
    Dim depa As String
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtcon.Clear()
        txtid.Clear()
        txtname.Clear()
        txtrate.Clear()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
        emp.Show()
    End Sub

    Private Sub rbfem_CheckedChanged(sender As Object, e As EventArgs) Handles rbfem.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub rbme_CheckedChanged(sender As Object, e As EventArgs) Handles rbme.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub rbcook_CheckedChanged(sender As Object, e As EventArgs) Handles rbcook.CheckedChanged
        depa = "Food / Bevarage Service"
    End Sub

    Private Sub rbserv_CheckedChanged(sender As Object, e As EventArgs) Handles rbserv.CheckedChanged
        depa = "Food Production"
    End Sub

    Private Sub btnaddd_Click(sender As Object, e As EventArgs) Handles btnaddd.Click
        Dim Str As String

        Try
            Str = "INSERT INTO employee (Employee_ID, Employee_Name, Gender, Birthday, Age, Contact_Number, Department, Rate) values("
            Str += """" & txtid.Text.Trim() & """"
            Str += ","
            Str += """" & txtname.Text.Trim() & """"
            Str += ","
            Str += """" & gender & """"
            Str += ","
            Str += """" & dtpbirth.Text() & """"
            Str += ","
            Str += """" & txtage.Text() & """"
            Str += ","
            Str += """" & txtcon.Text.Trim() & """"
            Str += ","
            Str += """" & depa & """"
            Str += ","
            Str += txtrate.Text.Trim()
            Str += ")"

            con.Open()
            cmd1 = New OleDbCommand(Str, con)
            cmd1.ExecuteNonQuery()
            dst1.Clear()
            dad1 = New OleDbDataAdapter("SELECT * FROM employee ORDER BY Employee_ID", con)
            dad1.Fill(dst1, "employee")
            MsgBox("RECORD ENTERED SUCCESSFULY.")

            txtid.Text = ""
            txtname.Text = ""
            gender = ""
            dtpbirth.Text = ""
            txtage.Text = ""
            txtcon.Text = ""
            depa = ""
            txtrate.Text = ""

            con.Close()

        Catch ex As Exception
            MessageBox.Show("COULD NOT ENTER RECORD.")
            MsgBox(ex.Message & "-" & ex.Source)
            con.Close()
        End Try
    End Sub

    Private Sub txtage_TextChanged(sender As Object, e As EventArgs) Handles txtage.TextChanged

    End Sub

    Private Sub dtpbirth_ValueChanged(sender As Object, e As EventArgs) Handles dtpbirth.ValueChanged
        txtage.Text = Str(Today() - dtpbirth.Value())
    End Sub
End Class