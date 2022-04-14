Imports System.Data.SqlClient
Module Module1
    Public con As New SqlConnection("data source= .\SQLEXPRESS;initial catalog=FSMS;integrated security=true;")
    Public cmd As New sqlCommand
    Public str As String
    Public dr As SqlDataReader
    Public ad As New SqlDataAdapter
    Public pcmd As New SqlCommand
End Module
