<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeSalary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeSalary))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.employeeid = New System.Windows.Forms.TextBox
        Me.employeename = New System.Windows.Forms.TextBox
        Me.salary = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button8 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.da = New System.Windows.Forms.TextBox
        Me.pf = New System.Windows.Forms.TextBox
        Me.hra = New System.Windows.Forms.TextBox
        Me.ta = New System.Windows.Forms.TextBox
        Me.it = New System.Windows.Forms.TextBox
        Me.pt = New System.Windows.Forms.TextBox
        Me.netsalary = New System.Windows.Forms.TextBox
        Me.DataSet1 = New System.Data.DataSet
        Me.designation = New System.Windows.Forms.ComboBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(583, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(583, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(583, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Designation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(583, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Salary"
        '
        'employeeid
        '
        Me.employeeid.Location = New System.Drawing.Point(759, 114)
        Me.employeeid.Name = "employeeid"
        Me.employeeid.Size = New System.Drawing.Size(100, 20)
        Me.employeeid.TabIndex = 5
        '
        'employeename
        '
        Me.employeename.Location = New System.Drawing.Point(759, 155)
        Me.employeename.Name = "employeename"
        Me.employeename.Size = New System.Drawing.Size(100, 20)
        Me.employeename.TabIndex = 6
        '
        'salary
        '
        Me.salary.Location = New System.Drawing.Point(759, 237)
        Me.salary.Name = "salary"
        Me.salary.Size = New System.Drawing.Size(100, 20)
        Me.salary.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(405, 590)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(512, 590)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "SEARCH"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(619, 590)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "MODIFY"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(726, 590)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(940, 590)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 23)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "MAIN MENU"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(833, 590)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "PRINT"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(1061, 590)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "EXIT"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(572, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(397, 42)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "EMPLOYEE SALARY"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(199, 673)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1143, 150)
        Me.DataGridView1.TabIndex = 18
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(877, 115)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 23)
        Me.Button8.TabIndex = 19
        Me.Button8.Text = "RETRIEVE"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(583, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 25)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "DA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(583, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 25)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "PF"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(583, 355)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 25)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "HRA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(583, 396)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 25)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "TA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(583, 437)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 25)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "IT"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(583, 478)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 25)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "PT"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(583, 519)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 25)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Net Salary"
        '
        'da
        '
        Me.da.Location = New System.Drawing.Point(759, 278)
        Me.da.Name = "da"
        Me.da.Size = New System.Drawing.Size(100, 20)
        Me.da.TabIndex = 27
        '
        'pf
        '
        Me.pf.Location = New System.Drawing.Point(759, 319)
        Me.pf.Name = "pf"
        Me.pf.Size = New System.Drawing.Size(100, 20)
        Me.pf.TabIndex = 28
        '
        'hra
        '
        Me.hra.Location = New System.Drawing.Point(759, 360)
        Me.hra.Name = "hra"
        Me.hra.Size = New System.Drawing.Size(100, 20)
        Me.hra.TabIndex = 29
        '
        'ta
        '
        Me.ta.Location = New System.Drawing.Point(759, 401)
        Me.ta.Name = "ta"
        Me.ta.Size = New System.Drawing.Size(100, 20)
        Me.ta.TabIndex = 30
        '
        'it
        '
        Me.it.Location = New System.Drawing.Point(759, 442)
        Me.it.Name = "it"
        Me.it.Size = New System.Drawing.Size(100, 20)
        Me.it.TabIndex = 31
        '
        'pt
        '
        Me.pt.Location = New System.Drawing.Point(759, 483)
        Me.pt.Name = "pt"
        Me.pt.Size = New System.Drawing.Size(100, 20)
        Me.pt.TabIndex = 32
        '
        'netsalary
        '
        Me.netsalary.Location = New System.Drawing.Point(759, 524)
        Me.netsalary.Name = "netsalary"
        Me.netsalary.Size = New System.Drawing.Size(100, 20)
        Me.netsalary.TabIndex = 33
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'designation
        '
        Me.designation.FormattingEnabled = True
        Me.designation.Items.AddRange(New Object() {"HR", "SUPERVISER", "SALESMAN", "MANAGER", "CASHIER", "SECURITY", "HOUSEKEEPER"})
        Me.designation.Location = New System.Drawing.Point(759, 195)
        Me.designation.Name = "designation"
        Me.designation.Size = New System.Drawing.Size(100, 21)
        Me.designation.TabIndex = 34
        '
        'EmployeeSalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1540, 845)
        Me.Controls.Add(Me.designation)
        Me.Controls.Add(Me.netsalary)
        Me.Controls.Add(Me.pt)
        Me.Controls.Add(Me.it)
        Me.Controls.Add(Me.ta)
        Me.Controls.Add(Me.hra)
        Me.Controls.Add(Me.pf)
        Me.Controls.Add(Me.da)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.salary)
        Me.Controls.Add(Me.employeename)
        Me.Controls.Add(Me.employeeid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EmployeeSalary"
        Me.Text = "EmployeeSalary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents employeeid As System.Windows.Forms.TextBox
    Friend WithEvents employeename As System.Windows.Forms.TextBox
    Friend WithEvents salary As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents da As System.Windows.Forms.TextBox
    Friend WithEvents pf As System.Windows.Forms.TextBox
    Friend WithEvents hra As System.Windows.Forms.TextBox
    Friend WithEvents ta As System.Windows.Forms.TextBox
    Friend WithEvents it As System.Windows.Forms.TextBox
    Friend WithEvents pt As System.Windows.Forms.TextBox
    Friend WithEvents netsalary As System.Windows.Forms.TextBox
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents designation As System.Windows.Forms.ComboBox
End Class
