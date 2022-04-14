Public Class Form1
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        GroupBox2.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd.Connection = con
        str = "select * from UserDetails where USERNAME='" & username.Text & "' and PASSWORD='" & password.Text & "'"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            MsgBox("LOGIN SUCCESSFULL")
            Me.Hide()
            MainMenu.Show()
            password.Text = ""
            username.Focus()
        Else
            MsgBox("INVALID USERNAME AND PASSWORD")
            username.Text = " "
            password.Text = " "
            username.Focus()
        End If
        dr.Close()
        con.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If cpassword.Text <> npassword.Text Then
            MsgBox("PASSWORD NOT MATCH")
        Else
            con.Open()
            cmd.Connection = con
            str = "update UserDetails set PASSWORD='" & cpassword.Text & "'where USERNAME='" & cusername.Text & "'"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = str
            cmd.ExecuteNonQuery()
            MsgBox("PASSWORD HAS BEEN CHANGED")
            con.Close()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        GroupBox2.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        con.Open()
        cmd.Connection = con
        str = "select * from UserDetails where USERNAME='" & fusername.Text & "'"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            fpassword.Text = dr("PASSWORD")
        End If
        dr.Close()
        con.Close()
    End Sub
End Class
