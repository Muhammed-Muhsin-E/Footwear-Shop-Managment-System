Imports System.Data.SqlClient
Public Class AttendenceLeave
    Dim con As SqlConnection = New SqlConnection("Data Source= .\SQLEXPRESS;Database=FSMS;trusted_connection=true;")
    Dim ds As New DataSet("AttendenceLeave")
    Dim str As String
    Dim cmd As New SqlCommand
    Dim ad As New SqlDataAdapter
    Dim dr As SqlDataReader
    Dim pcmd As New SqlCommand

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        End
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim Dataset1 As New DataSet("AttendenceLeave")
        con.Open()
        cmd.Connection = con
        str = "select * from AttendenceLeave"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        ad.Fill(Dataset1, "AttendenceLeave")
        DataGridView1.DataSource = Dataset1.Tables("AttendenceLeave")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd.Connection = con
        str = "insert into AttendenceLeave(EMPLOYEEID,EMPLOYEENAME,WORKDAYS,LEAVEDAYS)values('" & employeeid.Text & "','" & employeename.Text & "','" & workdays.Text & "','" & leavedays.Text & "')"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        cmd.ExecuteNonQuery()
        MsgBox("Data Saved", MsgBoxStyle.Information)
        cmd.Connection = con
        str = "select * from AttendenceLeave"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        ad.Fill(DataSet1, "AttendenceLeave")
        DataGridView1.DataSource = DataSet1.Tables("AttendenceLeave")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con.Open()
        cmd.Connection = con
        str = "select * from AttendenceLeave where EMPLOYEEID = '" & employeeid.Text & "'"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        Dim Dataset1 As New DataSet("AttendenceLeave")
        ad.Fill(Dataset1, "AttendenceLeave")
        DataGridView1.DataSource = Dataset1.Tables("AttendenceLeave")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con.Open()
        cmd.Connection = con
        str = " update AttendenceLeave set EMPLOYEEID='" & employeeid.Text & "',EMPLOYEENAME='" & employeename.Text & "',WORKDAYS='" & workdays.Text & "',LEAVEDAYS='" & leavedays.Text & "'where EMPLOYEEID='" & employeeid.Text & "'"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        cmd.ExecuteNonQuery()
        MsgBox("Data Updated", MsgBoxStyle.Information)
        str = "select * from AttendenceLeave"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        Dim Dataset1 As New DataSet("AttendenceLeave")
        ad.Fill(Dataset1, "AttendenceLeave")
        DataGridView1.DataSource = Dataset1.Tables("AttendenceLeave")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Dataset1 As New DataSet("AttendenceLeave")
        con.Open()
        cmd.Connection = con
        str = " delete from AttendenceLeave where EMPLOYEEID='" & employeeid.Text & "'"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        cmd.ExecuteNonQuery()
        MsgBox("Data Deleted", MsgBoxStyle.Information)
        cmd.Connection = con
        str = "select * from AttendenceLeave"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        ad.Fill(Dataset1, "AttendenceLeave")
        DataGridView1.DataSource = Dataset1.Tables("AttendenceLeave")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub AttendenceLeave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        pcmd = New SqlCommand("select * from AttendenceLeave", con)
        Dim ad As New SqlDataAdapter(pcmd)
        ad.Fill(DataSet1, "AttendenceLeave")
        DataGridView1.DataSource = DataSet1
        DataGridView1.DataMember = "AttendenceLeave"
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim a As New ReportAttendenceLeave
        a.ShowDialog()
    End Sub
End Class