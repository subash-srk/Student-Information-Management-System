Imports System.Data.OleDb
Module Module1

    Public cn As New OleDb.OleDbConnection
    Public cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Public ds As New DataSet
    Public ds1 As New DataSet
    Public ds2 As New DataSet
    Public str As String

    Public Sub conn()
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=C:\Users\Subash K\Documents\Project\student.accdb"
    End Sub




End Module
