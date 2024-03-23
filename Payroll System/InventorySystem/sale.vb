Imports System.Data.OleDb
Imports System.String
Public Class sale

    Private Sub sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PosTableAdapter.Fill(Me.IpposDataSet.pos)
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Me.Validate()
        Me.PosBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.IpposDataSet)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        men.Show()
        Me.Close()
    End Sub
End Class