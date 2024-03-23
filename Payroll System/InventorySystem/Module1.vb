Imports System.Data.OleDb
Module Module1
    Public con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\bin\Debug\ippos.accdb")

    Public dad As OleDbDataAdapter
    Public drd As OleDbDataReader
    Public cmd As OleDbCommand
    Public dst As New DataSet
    Public currentrow As Integer
    Public table1 As DataTableCollection
    Public source1 As New BindingSource

    Public dad1 As OleDbDataAdapter
    Public drd1 As OleDbDataReader
    Public cmd1 As OleDbCommand
    Public dst1 As New DataSet
    Public currentrow1 As Integer
    Public table2 As DataTableCollection
    Public source2 As New BindingSource

    Public dad2 As OleDbDataAdapter
    Public drd2 As OleDbDataReader
    Public cmd2 As OleDbCommand
    Public dst2 As New DataSet
    Public currentrow2 As Integer
    Public table3 As DataTableCollection
    Public source3 As New BindingSource
End Module
