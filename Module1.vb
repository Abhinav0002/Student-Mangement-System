Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports System.Data.OleDb
Module Module1
    Public conn As New OdbcConnection

    Public cmd As New OdbcCommand()
    Public adp As New OdbcDataAdapter()
    Public ds As New DataSet()
    Public flags As Integer
    Public bb As String
    Public Sub main()
        If (conn.State = ConnectionState.Closed) Then
            'conn.ConnectionString = "DRIVER={MySql ODBC 3.5.1 Driver}; SERVER=localhost;DATABASE=student;USER=root;PASSWORD=;Option=3"
            conn.ConnectionString = "Dsn=abhinav;" + "Uid=root;" + "Pwd=;"
            conn.Open()
        End If
    End Sub


End Module
