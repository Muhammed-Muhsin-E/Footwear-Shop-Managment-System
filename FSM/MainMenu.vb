Public Class MainMenu

    Private Sub UserDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserDetailsToolStripMenuItem.Click
        Me.Hide()
        Dim a As New UserDetails
        a.ShowDialog()
    End Sub

    Private Sub ItemDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemDetailsToolStripMenuItem.Click
        Me.Hide()
        Dim a As New ItemDetails
        a.ShowDialog()
    End Sub

    Private Sub EmployeeDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeMasterToolStripMenuItem.Click
        Me.Hide()
        Dim a As New EmployeeMaster
        a.ShowDialog()
    End Sub

    Private Sub BankMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankMasterToolStripMenuItem.Click
        Me.Hide()
        Dim a As New BankMaster
        a.ShowDialog()
    End Sub

    Private Sub VendorMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendorMasterToolStripMenuItem.Click
        Me.Hide()
        Dim a As New VendorMaster
        a.ShowDialog()
    End Sub

    Private Sub InvToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvToolStripMenuItem.Click
        Me.Hide()
        Dim a As New Invoice
        a.ShowDialog()
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseToolStripMenuItem.Click
        Me.Hide()
        Dim a As New Purchase
        a.ShowDialog()
    End Sub

    Private Sub DamageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        Me.Hide()
        Dim a As New Stock
        a.ShowDialog()
    End Sub

    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DamageToolStripMenuItem.Click
        Me.Hide()
        Dim a As New Damage
        a.ShowDialog()
    End Sub

    Private Sub SalesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem1.Click

    End Sub

    Private Sub SheoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SheoToolStripMenuItem.Click
        Me.Hide()
        Dim a As New Sheo
        a.ShowDialog()
    End Sub

    Private Sub SlipperToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlipperToolStripMenuItem.Click
        Me.Hide()
        Dim a As New Slipper
        a.ShowDialog()
    End Sub

    Private Sub SocksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SocksToolStripMenuItem.Click
        Me.Hide()
        Dim a As New Socks
        a.ShowDialog()
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnToolStripMenuItem.Click
        Me.Hide()
        Dim a As New ItemReturn
        a.ShowDialog()
    End Sub

    Private Sub EmployeeSalaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeSalaryToolStripMenuItem.Click
        Me.Hide()
        Dim a As New EmployeeSalary
        a.ShowDialog()
    End Sub

    Private Sub AttendenceLeaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendenceLeaveToolStripMenuItem.Click
        Me.Hide()
        Dim a As New AttendenceLeave
        a.ShowDialog()
    End Sub

    Private Sub SendingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendingToolStripMenuItem.Click
        Me.Hide()
        Dim a As New Sending
        a.ShowDialog()
    End Sub

    Private Sub RecievingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecievingToolStripMenuItem.Click
        Me.Hide()
        Dim a As New Recieving
        a.ShowDialog()
    End Sub

    Private Sub ABOUTUSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABOUTUSToolStripMenuItem.Click
        Me.Hide()
        Dim a As New AboutUs
        a.ShowDialog()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        End
    End Sub

    Private Sub UserDetailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserDetailsToolStripMenuItem1.Click
        Me.Hide()
        Dim a As New ReportUserDetails
        a.ShowDialog()
    End Sub

    Private Sub ItemDetailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemDetailsToolStripMenuItem1.Click
        Me.Hide()
        Dim a As New ReportItemDetails
        a.ShowDialog()
    End Sub

    Private Sub EmployeeMasterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeMasterToolStripMenuItem1.Click
        Me.Hide()
        Dim a As New ReportEmployeeMaster
        a.ShowDialog()
    End Sub

    Private Sub BankMasterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankMasterToolStripMenuItem1.Click
        Me.Hide()
        Dim a As New ReportBankMaster
        a.ShowDialog()
    End Sub

    Private Sub VendorMasterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendorMasterToolStripMenuItem1.Click
        Me.Hide()
        Dim a As New ReportVendorMaster
        a.ShowDialog()
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceToolStripMenuItem.Click
        Me.Hide()
        Dim a As New ReportInvoice
        a.ShowDialog()
    End Sub

    Private Sub PurchaseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseToolStripMenuItem1.Click
        Me.Hide()
        Dim a As New ReportPurchase
        a.ShowDialog()
    End Sub

    Private Sub StockToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem1.Click
        Me.Hide()
        Dim a As New ReportStock
        a.ShowDialog()
    End Sub

    Private Sub DamageToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DamageToolStripMenuItem1.Click
        Me.Hide()
        Dim a As New ReportDamage
        a.ShowDialog()
    End Sub

   
    Private Sub ReturnToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnToolStripMenuItem1.Click
        Me.Hide()
        Dim a As New ReportItemReturn
        a.ShowDialog()
    End Sub

    Private Sub EmployeeSalaryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeSalaryToolStripMenuItem1.Click
        Me.Hide()
        Dim a As New ReportEmployeeSalary
        a.ShowDialog()
    End Sub

    Private Sub AttendeceLeaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendeceLeaveToolStripMenuItem.Click
        Me.Hide()
        Dim a As New ReportAttendenceLeave
        a.ShowDialog()
    End Sub

    Private Sub SendingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendingToolStripMenuItem1.Click
        Me.Hide()
        Dim a As New ReportSending
        a.ShowDialog()
    End Sub

    Private Sub RecievingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecievingToolStripMenuItem1.Click
        Me.Hide()
        Dim a As New ReportRecieving
        a.ShowDialog()
    End Sub

    Private Sub ShoeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShoeToolStripMenuItem.Click
        Me.Hide()
        Dim a As New ReportShoe
        a.ShowDialog()
    End Sub

    Private Sub SlipperToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlipperToolStripMenuItem1.Click
        Me.Hide()
        Dim a As New ReportSlipper
        a.ShowDialog()
    End Sub

    Private Sub SocksToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SocksToolStripMenuItem1.Click
        Me.Hide()
        Dim a As New ReportSocks
        a.ShowDialog()
    End Sub
End Class