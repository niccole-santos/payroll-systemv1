Imports System.Data.OleDb
Imports System.String
Public Class adds
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        men.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Str As String

        Try
            Str = "INSERT INTO Stocks (Ingredient_Name, Stock, Price) values("
            Str += """" & names.Text.Trim() & """"
            Str += ","
            Str += """" & cstocks.Text.Trim() & """"
            Str += ","
            Str += price.Text.Trim()
            Str += ")"

            con.Open()
            cmd = New OleDbCommand(Str, con)
            cmd.ExecuteNonQuery()
            dst.Clear()
            dad = New OleDbDataAdapter("SELECT * FROM Stocks ORDER BY Ingredient_Code", con)
            dad.Fill(dst, "Stocks")
            MsgBox("RECORD ENTERED SUCCESSFULY.")

            names.Text = ""
            cstocks.Text = ""
            price.Text = ""

            con.Close()

        Catch ex As Exception
            MessageBox.Show("COULD NOT ENTER RECORD.")
            MsgBox(ex.Message & "-" & ex.Source)
            con.Close()
        End Try
    End Sub
End Class