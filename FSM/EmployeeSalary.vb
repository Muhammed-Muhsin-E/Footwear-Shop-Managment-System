Imports System.Data.SqlClient
Public Class EmployeeSalary
    Dim con As SqlConnection = New SqlConnection("Data Source= .\SQLEXPRESS;Database=FSMS;trusted_connection=true;")
    Dim ds As New DataSet("EmployeeSalary")
    Dim str As String
    Dim cmd As New SqlCommand
    Dim ad As New SqlDataAdapter
    Dim dr As SqlDataReader
    Dim pcmd As New SqlCommand

    Private Sub AttendenceLeave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        pcmd = New SqlCommand("select * from EmployeeSalary", con)
        Dim ad As New SqlDataAdapter(pcmd)
        ad.Fill(DataSet1, "EmployeeSalary")
        DataGridView1.DataSource = DataSet1
        DataGridView1.DataMember = "EmployeeSalary"
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim Dataset1 As New DataSet("EmployeeSalary")
        con.Open()
        cmd.Connection = con
        str = "select * from EmployeeSalary"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        ad.Fill(Dataset1, "EmployeeSalary")
        DataGridView1.DataSource = Dataset1.Tables("EmployeeSalary")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd.Connection = con
        str = "insert into EmployeeSalary(EMPLOYEEID,EMPLOYEENAME,DESIGNATION,SALARY,DA,PF,HRA,TA,IT,PT,NETSALARY)values('" & employeeid.Text & "','" & employeename.Text & "','" & designation.Text & "','" & salary.Text & "','" & da.Text & "','" & pf.Text & "','" & hra.Text & "','" & ta.Text & "','" & it.Text & "','" & pt.Text & "','" & netsalary.Text & "')"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        cmd.ExecuteNonQuery()
        MsgBox("Data Saved", MsgBoxStyle.Information)
        cmd.Connection = con
        str = "select * from EmployeeSalary"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        ad.Fill(DataSet1, "EmployeeSalary")
        DataGridView1.DataSource = DataSet1.Tables("EmployeeSalary")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con.Open()
        cmd.Connection = con
        str = "select * from EmployeeSalary where EMPLOYEEID = '" & employeeid.Text & "'"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        Dim Dataset1 As New DataSet("EmployeeSalary")
        ad.Fill(Dataset1, "EmployeeSalary")
        DataGridView1.DataSource = Dataset1.Tables("EmployeeSalary")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con.Open()
        cmd.Connection = con
        str = " update EmployeeSalary set EMPLOYEEID='" & employeeid.Text & "',EMPLOYEENAME='" & employeename.Text & "',DESIGNATION='" & designation.Text & "',SALARY='" & salary.Text & "',DA='" & da.Text & "',PF='" & pf.Text & "',HRA='" & hra.Text & "',TA='" & ta.Text & "',IT='" & it.Text & "',PT='" & pt.Text & "',NETSALARY='" & netsalary.Text & "'where EMPLOYEEID='" & employeeid.Text & "'"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        cmd.ExecuteNonQuery()
        MsgBox("Data Updated", MsgBoxStyle.Information)
        str = "select * from EmployeeSalary"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        Dim Dataset1 As New DataSet("EmployeeSalary")
        ad.Fill(Dataset1, "EmployeeSalary")
        DataGridView1.DataSource = Dataset1.Tables("EmployeeSalary")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Dataset1 As New DataSet("EmployeeSalary")
        con.Open()
        cmd.Connection = con
        str = " delete from EmployeeSalary where EMPLOYEEID='" & employeeid.Text & "'"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        cmd.ExecuteNonQuery()
        MsgBox("Data Deleted", MsgBoxStyle.Information)
        cmd.Connection = con
        str = "select * from EmployeeSalary"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        ad.Fill(Dataset1, "EmployeeSalary")
        DataGridView1.DataSource = Dataset1.Tables("EmployeeSalary")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        con.Open()
        cmd.Connection = con
        str = "select * from EmployeeMaster where EMPLOYEEID='" & employeeid.Text & "' "
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr Is Nothing Then
            employeename.Text = dr("EMPLOYEENAME")
            designation.Text = dr("DESIGNATION")
            salary.Text = dr("SALARY")
        End If
        dr.Close()
        con.Close()
    End Sub

    Private Sub salary_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salary.TextChanged
        da.Text = Val(salary.Text) * 50 / 100
        pf.Text = Val(salary.Text) * 12 / 100
        hra.Text = Val(salary.Text) * 12 / 100
        ta.Text = Val(salary.Text) * 5 / 100
        it.Text = Val(salary.Text) * 2 / 100
        pt.Text = Val(salary.Text) * 3 / 100
        netsalary.Text = (Val(da.Text) + Val(pf.Text) + Val(hra.Text) + Val(ta.Text)) - (Val(it.Text) + Val(pt.Text))
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim a As New ReportEmployeeSalary
        a.ShowDialog()
    End Sub

End Class