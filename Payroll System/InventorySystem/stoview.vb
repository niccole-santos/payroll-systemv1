Imports System.Data.OleDb
Imports System.String
Public Class stoview
    Private Sub stoview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentrow = 0

        con.Close()

        con.Open()
        dad = New OleDbDataAdapter("SELECT * FROM Stocks ORDER BY Ingredient_Code", con)
        dad.Fill(dst, "Stocks")
        table1 = dst.Tables

        Dim view As New DataView(table1(0))
        source1.DataSource = view
        dtgstocks.DataSource = view
        con.Close()
    End Sub

    Private Sub exitt_Click(sender As Object, e As EventArgs) Handles exitt.Click
        Me.Close()
        men.Show()
    End Sub

    Private Sub btnfind_Click(sender As Object, e As EventArgs) Handles btnfind.Click

        con.Close()

        Try
            con.Open()
            dst.Clear()
            dad = New OleDbDataAdapter("SELECT * FROM Stocks where Ingredient_Code = " & code.Text.Trim(), con)
            dad.Fill(dst, "Stocks")
            con.Close()
            inname.Text = dst.Tables("Stocks").Rows(0)("Ingredient_Name")
            price.Text() = dst.Tables("Stocks").Rows(0)("Price")
            cstocks.Text() = dst.Tables("Stocks").Rows(0)("Stock")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        con.Close()

        con.Open()
        dst.Clear()
        dad = New OleDbDataAdapter("SELECT * FROM Stocks Order by Ingredient_Code", con)
        dad.Fill(dst, "Stocks")
        con.Close()
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        Dim str As String

        Try
            str = "DELETE from Stocks where Ingredient_Code= "
            str += code.Text.Trim()
            con.Open()
            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()

            dst.Clear()
            dad = New OleDbDataAdapter("SELECT* FROM Stocks ORDER BY Ingredient_Name ", con)
            dad.Fill(dst, "Stocks")
            MsgBox("INGREDIENT REMOVED.")

            inname.Text = ""
            cstocks.Text = ""
            price.Text = ""
            code.Text = ""

            If currentrow > 0 Then
                currentrow = currentrow - 1
                inname.Text = dst.Tables("Stocks").Rows(currentrow)("Ingredient_Name")
                cstocks.Text = dst.Tables("Stocks").Rows(currentrow)("Stock")
                price.Text = dst.Tables("Stocks").Rows(currentrow)("Price")

                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("INGREDIENT CANNOT BE REMOVED.")
            MsgBox(ex.Message & "_" & ex.Source)
            con.Close()
        End Try
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim dep As Integer
        Try
            dep = InputBox("Enter quantity.", "ADD STOCKS")
        Catch ex As Exception
            MsgBox("INVALID INPUT.")
            Exit Sub
        End Try

        Try
            Dim Str As String
            Dim x As Integer = Integer.Parse(cstocks.Text) + dep
            con.Open()
            Str = "update Stocks set Stock=" & x & " where Ingredient_Code = " & code.Text.Trim()
            cmd = New OleDbCommand(Str, con)
            cmd.ExecuteNonQuery()
            con.Close()

            con.Open()
            dst.Clear()
            dad = New OleDbDataAdapter("SELECT * FROM Stocks ORDER BY Ingredient_Code", con)
            dad.Fill(dst, "Stocks")
            MsgBox("UPDATE SUCESSFUL.")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            code.Text = dst.Tables("Stocks").Rows(currentrow)("Ingredient_Code")
            inname.Text = dst.Tables("Stocks").Rows(currentrow)("Ingredient_Name")
            cstocks.Text = dst.Tables("Stocks").Rows(currentrow)("Stock")
            price.Text = dst.Tables("Stocks").Rows(currentrow)("Price")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnded_Click(sender As Object, e As EventArgs) Handles btnded.Click
        Dim dep As Integer
        Try
            dep = InputBox("Enter quantity.", "REDUCE STOCKS")
        Catch ex As Exception
            MsgBox("INVALID INPUT.")
            Exit Sub
        End Try

        Try
            Dim Str As String
            Dim x As Integer = Integer.Parse(cstocks.Text) - dep
            con.Open()
            Str = "update Stocks set Stock=" & x & " where Ingredient_Code = " & code.Text.Trim()
            cmd = New OleDbCommand(Str, con)
            cmd.ExecuteNonQuery()
            con.Close()

            con.Open()
            dst.Clear()
            dad = New OleDbDataAdapter("SELECT * FROM Stocks ORDER BY Ingredient_Code", con)
            dad.Fill(dst, "Stocks")
            MsgBox("UPDATE SUCESSFUL.")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            code.Text = dst.Tables("Stocks").Rows(currentrow)("Ingredient_Code")
            inname.Text = dst.Tables("Stocks").Rows(currentrow)("Ingredient_Name")
            cstocks.Text = dst.Tables("Stocks").Rows(currentrow)("Stock")
            price.Text = dst.Tables("Stocks").Rows(currentrow)("Price")
        Catch ex As Exception
        End Try
    End Sub
End Class