Imports System.Data.SqlClient
Public Class ItemReturn
    Dim con As SqlConnection = New SqlConnection("Data Source= .\SQLEXPRESS;Database=FSMS;trusted_connection=true;")
    Dim ds As New DataSet("ItemReturn")
    Dim str As String
    Dim cmd As New SqlCommand
    Dim ad As New SqlDataAdapter
    Dim dr As SqlDataReader
    Dim pcmd As New SqlCommand

    Private Sub AttendenceLeave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        pcmd = New SqlCommand("select * from ItemReturn", con)
        Dim ad As New SqlDataAdapter(pcmd)
        ad.Fill(DataSet1, "ItemReturn")
        DataGridView1.DataSource = DataSet1
        DataGridView1.DataMember = "ItemReturn"
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
        Dim Dataset1 As New DataSet("ItemReturn")
        con.Open()
        cmd.Connection = con
        str = "select * from ItemReturn"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        ad.Fill(Dataset1, "ItemReturn")
        DataGridView1.DataSource = Dataset1.Tables("ItemReturn")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd.Connection = con
        str = "insert into ItemReturn(INVOICENO,DATE,ITEMNO,ITEMNAME,SIZE,QUANTITY,PRICE,TOTAL)values('" & invoiceno.Text & "','" & day.Text & "','" & itemno.Text & "','" & itemname.Text & "','" & size.Text & "','" & quantity.Text & "','" & price.Text & "','" & total.Text & "')"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        cmd.ExecuteNonQuery()
        MsgBox("Data Saved", MsgBoxStyle.Information)
        cmd.Connection = con
        str = "select * from ItemReturn"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        ad.Fill(DataSet1, "ItemReturn")
        DataGridView1.DataSource = DataSet1.Tables("ItemReturn")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con.Open()
        cmd.Connection = con
        str = "select * from ItemReturn where INVOICENO = '" & invoiceno.Text & "'"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        Dim Dataset1 As New DataSet("ItemReturn")
        ad.Fill(Dataset1, "ItemReturn")
        DataGridView1.DataSource = Dataset1.Tables("ItemReturn")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con.Open()
        cmd.Connection = con
        str = " update ItemReturn set INVOICENO='" & invoiceno.Text & "',DATE='" & day.Text & "',ITEMNO='" & itemno.Text & "',ITEMNAME='" & itemname.Text & "',SIZE='" & size.Text & "',QUANTITY='" & quantity.Text & "',PRICE='" & price.Text & "',TOTAL='" & total.Text & "'where INVOICENO='" & invoiceno.Text & "'"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        cmd.ExecuteNonQuery()
        MsgBox("Data Updated", MsgBoxStyle.Information)
        str = "select * from ItemReturn"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        Dim Dataset1 As New DataSet("ItemReturn")
        ad.Fill(Dataset1, "ItemReturn")
        DataGridView1.DataSource = Dataset1.Tables("ItemReturn")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Dataset1 As New DataSet("ItemReturn")
        con.Open()
        cmd.Connection = con
        str = " delete from ItemReturn where INVOICENO='" & invoiceno.Text & "'"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        cmd.ExecuteNonQuery()
        MsgBox("Data Deleted", MsgBoxStyle.Information)
        cmd.Connection = con
        str = "select * from ItemReturn"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        ad.SelectCommand = cmd
        ad.Fill(Dataset1, "ItemReturn")
        DataGridView1.DataSource = Dataset1.Tables("ItemReturn")
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim dt As New Date
        dt = DateTimePicker1.Value
        day.Text = Format(dt, "dd-mm-yyyy")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim a As New ReportItemReturn
        a.ShowDialog()
    End Sub
End Class