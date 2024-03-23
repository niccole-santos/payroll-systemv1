<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addem
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.dtpbirth = New System.Windows.Forms.DateTimePicker()
        Me.rbme = New System.Windows.Forms.RadioButton()
        Me.rbfem = New System.Windows.Forms.RadioButton()
        Me.txtcon = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbserv = New System.Windows.Forms.RadioButton()
        Me.rbcook = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnaddd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtage)
        Me.GroupBox1.Controls.Add(Me.dtpbirth)
        Me.GroupBox1.Controls.Add(Me.rbme)
        Me.GroupBox1.Controls.Add(Me.rbfem)
        Me.GroupBox1.Controls.Add(Me.txtcon)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 232)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EMPLOYEE INFORMATION"
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(291, 147)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(32, 26)
        Me.txtage.TabIndex = 17
        '
        'dtpbirth
        '
        Me.dtpbirth.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpbirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpbirth.Location = New System.Drawing.Point(83, 144)
        Me.dtpbirth.Name = "dtpbirth"
        Me.dtpbirth.Size = New System.Drawing.Size(143, 26)
        Me.dtpbirth.TabIndex = 15
        '
        'rbme
        '
        Me.rbme.AutoSize = True
        Me.rbme.Location = New System.Drawing.Point(272, 111)
        Me.rbme.Name = "rbme"
        Me.rbme.Size = New System.Drawing.Size(61, 24)
        Me.rbme.TabIndex = 16
        Me.rbme.TabStop = True
        Me.rbme.Text = "Male"
        Me.rbme.UseVisualStyleBackColor = True
        '
        'rbfem
        '
        Me.rbfem.AutoSize = True
        Me.rbfem.Location = New System.Drawing.Point(145, 111)
        Me.rbfem.Name = "rbfem"
        Me.rbfem.Size = New System.Drawing.Size(80, 24)
        Me.rbfem.TabIndex = 15
        Me.rbfem.TabStop = True
        Me.rbfem.Text = "Female"
        Me.rbfem.UseVisualStyleBackColor = True
        '
        'txtcon
        '
        Me.txtcon.Location = New System.Drawing.Point(145, 191)
        Me.txtcon.Name = "txtcon"
        Me.txtcon.Size = New System.Drawing.Size(203, 26)
        Me.txtcon.TabIndex = 10
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(146, 66)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(203, 26)
        Me.txtname.TabIndex = 9
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(146, 30)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(203, 26)
        Me.txtid.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AllowDrop = True
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(246, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Contact Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Birthday"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Employee Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbserv)
        Me.GroupBox2.Controls.Add(Me.rbcook)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtrate)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 134)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EMPLOYEE DEPLOYMENT"
        '
        'rbserv
        '
        Me.rbserv.AutoSize = True
        Me.rbserv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbserv.Location = New System.Drawing.Point(146, 58)
        Me.rbserv.Name = "rbserv"
        Me.rbserv.Size = New System.Drawing.Size(124, 20)
        Me.rbserv.TabIndex = 18
        Me.rbserv.TabStop = True
        Me.rbserv.Text = "Food Production"
        Me.rbserv.UseVisualStyleBackColor = True
        '
        'rbcook
        '
        Me.rbcook.AutoSize = True
        Me.rbcook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcook.Location = New System.Drawing.Point(146, 33)
        Me.rbcook.Name = "rbcook"
        Me.rbcook.Size = New System.Drawing.Size(176, 20)
        Me.rbcook.TabIndex = 17
        Me.rbcook.TabStop = True
        Me.rbcook.Text = "Food / Beverage Service"
        Me.rbcook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbcook.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(107, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Php"
        '
        'txtrate
        '
        Me.txtrate.Location = New System.Drawing.Point(146, 94)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(203, 26)
        Me.txtrate.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 20)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Rate"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 20)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Department"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.RosyBrown
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(262, 401)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(105, 42)
        Me.btncancel.TabIndex = 12
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.RosyBrown
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.White
        Me.btnclear.Location = New System.Drawing.Point(151, 401)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(105, 42)
        Me.btnclear.TabIndex = 13
        Me.btnclear.Text = "Clear All"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnaddd
        '
        Me.btnaddd.BackColor = System.Drawing.Color.RosyBrown
        Me.btnaddd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnaddd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddd.ForeColor = System.Drawing.Color.White
        Me.btnaddd.Location = New System.Drawing.Point(12, 401)
        Me.btnaddd.Name = "btnaddd"
        Me.btnaddd.Size = New System.Drawing.Size(133, 42)
        Me.btnaddd.TabIndex = 14
        Me.btnaddd.Text = "Add Employee"
        Me.btnaddd.UseVisualStyleBackColor = False
        '
        'addem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(381, 451)
        Me.Controls.Add(Me.btnaddd)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "addem"
        Me.Text = "ADD EMPLOYEE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents rbme As RadioButton
    Friend WithEvents rbfem As RadioButton
    Friend WithEvents txtcon As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbserv As RadioButton
    Friend WithEvents rbcook As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents txtrate As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnaddd As Button
    Friend WithEvents dtpbirth As DateTimePicker
    Friend WithEvents txtage As TextBox
End Class
