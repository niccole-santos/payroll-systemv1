<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payroll
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
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.btncanci = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.dtgp = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnfin = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cca = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ibig = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.health = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.sss = New System.Windows.Forms.TextBox()
        Me.salary = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.late = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.absentt = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.works = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.White
        Me.btnreset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnreset.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.Color.Firebrick
        Me.btnreset.Location = New System.Drawing.Point(507, 369)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(97, 41)
        Me.btnreset.TabIndex = 11
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'btncalc
        '
        Me.btncalc.BackColor = System.Drawing.Color.White
        Me.btncalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncalc.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalc.ForeColor = System.Drawing.Color.Firebrick
        Me.btncalc.Location = New System.Drawing.Point(507, 322)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(97, 41)
        Me.btncalc.TabIndex = 10
        Me.btncalc.Text = "Calculate"
        Me.btncalc.UseVisualStyleBackColor = False
        '
        'btncanci
        '
        Me.btncanci.BackColor = System.Drawing.Color.White
        Me.btncanci.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncanci.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncanci.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncanci.ForeColor = System.Drawing.Color.Firebrick
        Me.btncanci.Location = New System.Drawing.Point(507, 416)
        Me.btncanci.Name = "btncanci"
        Me.btncanci.Size = New System.Drawing.Size(97, 41)
        Me.btncanci.TabIndex = 9
        Me.btncanci.Text = "Cancel"
        Me.btncanci.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtrate)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtname)
        Me.GroupBox2.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 230)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 91)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EMPLOYEE DETAILS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rate"
        '
        'txtrate
        '
        Me.txtrate.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Location = New System.Drawing.Point(126, 51)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.ReadOnly = True
        Me.txtrate.Size = New System.Drawing.Size(100, 25)
        Me.txtrate.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Employee Name"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(126, 20)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(100, 25)
        Me.txtname.TabIndex = 1
        '
        'dtgp
        '
        Me.dtgp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgp.Location = New System.Drawing.Point(12, 12)
        Me.dtgp.Name = "dtgp"
        Me.dtgp.Size = New System.Drawing.Size(589, 126)
        Me.dtgp.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnfin)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Font = New System.Drawing.Font("Raleway", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 80)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ENTER EMPLOYEE ID"
        '
        'btnfin
        '
        Me.btnfin.BackColor = System.Drawing.Color.Maroon
        Me.btnfin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfin.Location = New System.Drawing.Point(137, 27)
        Me.btnfin.Name = "btnfin"
        Me.btnfin.Size = New System.Drawing.Size(79, 30)
        Me.btnfin.TabIndex = 1
        Me.btnfin.Text = "Find"
        Me.btnfin.UseVisualStyleBackColor = False
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(10, 31)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 25)
        Me.txtid.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cca)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.ibig)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.health)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.sss)
        Me.GroupBox3.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(264, 153)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(340, 163)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DEDUCTIONS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CCA"
        '
        'cca
        '
        Me.cca.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cca.Location = New System.Drawing.Point(135, 128)
        Me.cca.Name = "cca"
        Me.cca.Size = New System.Drawing.Size(100, 25)
        Me.cca.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 14)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Pag-IBIG"
        '
        'ibig
        '
        Me.ibig.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ibig.Location = New System.Drawing.Point(135, 54)
        Me.ibig.Name = "ibig"
        Me.ibig.Size = New System.Drawing.Size(100, 25)
        Me.ibig.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 14)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "PhilHealth"
        '
        'health
        '
        Me.health.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.health.Location = New System.Drawing.Point(135, 85)
        Me.health.Name = "health"
        Me.health.Size = New System.Drawing.Size(100, 25)
        Me.health.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 14)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "SSS"
        '
        'sss
        '
        Me.sss.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sss.Location = New System.Drawing.Point(135, 23)
        Me.sss.Name = "sss"
        Me.sss.Size = New System.Drawing.Size(100, 25)
        Me.sss.TabIndex = 1
        '
        'salary
        '
        Me.salary.AutoSize = True
        Me.salary.Location = New System.Drawing.Point(384, 63)
        Me.salary.Name = "salary"
        Me.salary.Size = New System.Drawing.Size(0, 15)
        Me.salary.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(267, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total Salary"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "No. of minutes late"
        '
        'late
        '
        Me.late.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.late.Location = New System.Drawing.Point(156, 57)
        Me.late.Name = "late"
        Me.late.Size = New System.Drawing.Size(70, 25)
        Me.late.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "No. of absence"
        '
        'absentt
        '
        Me.absentt.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.absentt.Location = New System.Drawing.Point(156, 26)
        Me.absentt.Name = "absentt"
        Me.absentt.Size = New System.Drawing.Size(70, 25)
        Me.absentt.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.salary)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.absentt)
        Me.GroupBox4.Controls.Add(Me.works)
        Me.GroupBox4.Controls.Add(Me.late)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Font = New System.Drawing.Font("Raleway", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(12, 327)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(487, 126)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TOTAL SALARY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "No. of days worked"
        '
        'works
        '
        Me.works.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.works.Location = New System.Drawing.Point(156, 88)
        Me.works.Name = "works"
        Me.works.Size = New System.Drawing.Size(70, 25)
        Me.works.TabIndex = 5
        '
        'payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(616, 465)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.btncanci)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dtgp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "payroll"
        Me.Text = "PAYROLL"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtgp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnreset As Button
    Friend WithEvents btncalc As Button
    Friend WithEvents btncanci As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtrate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents dtgp As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnfin As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents salary As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ibig As TextBox
    Friend WithEvents late As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents health As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents sss As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cca As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents absentt As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents works As TextBox
End Class
