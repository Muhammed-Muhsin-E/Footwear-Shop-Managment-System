﻿Imports System.Data.SqlClient
Public Class ItemDetails
    Dim con As SqlConnection = New SqlConnection("Data Source= .\SQLEXPRESS;Database=FSMS;trusted_connection=true;")
    Dim ds As New DataSet("ItemDetails")
    Dim str As String
    Dim cmd As New SqlCommand
    Dim ad As New SqlDataAdapter
    Dim dr As SqlDataReader
    Dim pcmd As New SqlCommand

    Private Sub AttendenceLeave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        pcmd = New SqlCommand("select * from ItemDetails", con)
        Dim ad As New SqlDataAdapter(pcmd)
        ad.Fill(DataSet1, "ItemDetails")
        DataGridView1.DataSource = DataSet1
        DataGridView1.DataMember = "ItemDetails"
        DataGridView1.Refresh()
        con.Close()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        End
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd.Connection = con
        str = "insert into ItemDetails(ITEMNO,ITEMNAME,SIZE,QUANTITY,PRICE)values('" & ItemNo.Text & "','" & ItemName.Text & "','" & Size.Text & "','" & Quantity.Text & "','" & Price.Text & "')"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        cmd.ExecuteNonQuery()
        MsgBox("Data Saved", MsgBoxStyle.Information)
        cmd.Connection = con
        str = "select * from ItemDetails"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        ad.Fill(DataSet1, "ItemDetails")
        DataGridView1.DataSource = DataSet1.Tables("ItemDetails")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim Dataset1 As New DataSet("ItemDetails")
        con.Open()
        cmd.Connection = con
        str = "select * from ItemDetails"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        ad.Fill(Dataset1, "ItemDetails")
        DataGridView1.DataSource = Dataset1.Tables("ItemDetails")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con.Open()
        cmd.Connection = con
        str = "select * from ItemDetails where ITEMNO = '" & ItemNo.Text & "'"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        Dim Dataset1 As New DataSet("ItemDetails")
        ad.Fill(Dataset1, "ItemDetails")
        DataGridView1.DataSource = Dataset1.Tables("ItemDetails")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con.Open()
        cmd.Connection = con
        str = " update ItemDetails set ITEMNO='" & ItemNo.Text & "',ITEMNAME='" & ItemName.Text & "',SIZE='" & Size.Text & "',QUANTITY='" & Quantity.Text & "',PRICE='" & Price.Text & "'where ITEMNO='" & ItemNo.Text & "'"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        cmd.ExecuteNonQuery()
        MsgBox("Data Updated", MsgBoxStyle.Information)
        str = "select * from ItemDetails"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        Dim Dataset1 As New DataSet("ItemDetails")
        ad.Fill(Dataset1, "ItemDetails")
        DataGridView1.DataSource = Dataset1.Tables("ItemDetails")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Dataset1 As New DataSet("ItemDetails")
        con.Open()
        cmd.Connection = con
        str = " delete from ItemDetails where ITEMNO='" & ItemNo.Text & "'"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        cmd.ExecuteNonQuery()
        MsgBox("Data Deleted", MsgBoxStyle.Information)
        cmd.Connection = con
        str = "select * from ItemDetails"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        ad.Fill(Dataset1, "ItemDetails")
        DataGridView1.DataSource = Dataset1.Tables("ItemDetails")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim a As New ReportItemDetails
        a.ShowDialog()
    End Sub
End Class