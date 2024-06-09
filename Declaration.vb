

Imports System.Data.OleDb

Module Connection
    Public ds As New DataSet
    Public cmd As New OleDbCommand
    Public conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Danial\source\repos\revis\Database21.mdb")
    Public dr As OleDbDataReader
    Public dt As DataTable
End Module