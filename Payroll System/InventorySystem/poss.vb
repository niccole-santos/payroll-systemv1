Imports System.Data.OleDb
Imports System.String
Public Class poss
    Private Sub poss_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentrow2 = 0

        con.Close()

        con.Open()
        dad2 = New OleDbDataAdapter("SELECT * FROM pos ORDER BY Item_Code", con)
        dad2.Fill(dst2, "pos")
        table3 = dst2.Tables

        Dim view As New DataView(table3(0))
        source3.DataSource = view
        DataGridView1.DataSource = view
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        men.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tem.Clear()
        qt.Clear()
        pri.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Str As String

        Try
            Str = "INSERT INTO pos (Item_Name, ItemQty, DatePurchased, Amount) values("
            Str += """" & tem.Text.Trim() & """"
            Str += ","
            Str += """" & qt.Text.Trim() & """"
            Str += ","
            Str += """" & dtppos.Text() & """"
            Str += ","
            Str += pri.Text.Trim()
            Str += ")"

            con.Open()
            cmd1 = New OleDbCommand(Str, con)
            cmd1.ExecuteNonQuery()
            dst1.Clear()
            dad1 = New OleDbDataAdapter("SELECT * FROM pos ORDER BY Item_Code", con)
            dad1.Fill(dst1, "pos")
            MsgBox("RECORD ENTERED SUCCESSFULY.")

            tem.Text = ""
            qt.Text = ""
            dtppos.Text = ""
            pri.Text = ""

            con.Close()

        Catch ex As Exception
            MessageBox.Show("COULD NOT ENTER RECORD.")
            MsgBox(ex.Message & "-" & ex.Source)
            con.Close()
        End Try
    End Sub
End Class