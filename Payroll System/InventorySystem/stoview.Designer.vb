<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stoview
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
        Me.dtgstocks = New System.Windows.Forms.DataGridView()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.exitt = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnded = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.price = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cstocks = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnfind = New System.Windows.Forms.Button()
        Me.code = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dtgstocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgstocks
        '
        Me.dtgstocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgstocks.Location = New System.Drawing.Point(13, 12)
        Me.dtgstocks.Name = "dtgstocks"
        Me.dtgstocks.Size = New System.Drawing.Size(436, 150)
        Me.dtgstocks.TabIndex = 0
        '
        'btnremove
        '
        Me.btnremove.BackColor = System.Drawing.Color.MistyRose
        Me.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnremove.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.ForeColor = System.Drawing.Color.Firebrick
        Me.btnremove.Location = New System.Drawing.Point(349, 107)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(72, 37)
        Me.btnremove.TabIndex = 11
        Me.btnremove.Text = "Remove"
        Me.btnremove.UseVisualStyleBackColor = False
        '
        'exitt
        '
        Me.exitt.BackColor = System.Drawing.Color.White
        Me.exitt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitt.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitt.ForeColor = System.Drawing.Color.Firebrick
        Me.exitt.Location = New System.Drawing.Point(337, 341)
        Me.exitt.Name = "exitt"
        Me.exitt.Size = New System.Drawing.Size(112, 37)
        Me.exitt.TabIndex = 12
        Me.exitt.Text = "Exit"
        Me.exitt.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnded)
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.price)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cstocks)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.inname)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnfind)
        Me.GroupBox1.Controls.Add(Me.code)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnremove)
        Me.GroupBox1.Font = New System.Drawing.Font("Raleway", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 156)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGREDIENT INFORMATION"
        '
        'btnded
        '
        Me.btnded.BackColor = System.Drawing.Color.MistyRose
        Me.btnded.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnded.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnded.ForeColor = System.Drawing.Color.Firebrick
        Me.btnded.Location = New System.Drawing.Point(349, 63)
        Me.btnded.Name = "btnded"
        Me.btnded.Size = New System.Drawing.Size(72, 37)
        Me.btnded.TabIndex = 30
        Me.btnded.Text = "Deduct"
        Me.btnded.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.MistyRose
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnadd.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.Firebrick
        Me.btnadd.Location = New System.Drawing.Point(349, 21)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(72, 37)
        Me.btnadd.TabIndex = 29
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'price
        '
        Me.price.Location = New System.Drawing.Point(127, 95)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(141, 23)
        Me.price.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Price"
        '
        'cstocks
        '
        Me.cstocks.Location = New System.Drawing.Point(127, 124)
        Me.cstocks.Name = "cstocks"
        Me.cstocks.Size = New System.Drawing.Size(141, 23)
        Me.cstocks.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Current Stocks"
        '
        'inname
        '
        Me.inname.Location = New System.Drawing.Point(127, 66)
        Me.inname.Name = "inname"
        Me.inname.Size = New System.Drawing.Size(141, 23)
        Me.inname.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 15)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Ingredient Name"
        '
        'btnfind
        '
        Me.btnfind.BackColor = System.Drawing.Color.White
        Me.btnfind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfind.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfind.ForeColor = System.Drawing.Color.Firebrick
        Me.btnfind.Location = New System.Drawing.Point(202, 17)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(66, 31)
        Me.btnfind.TabIndex = 14
        Me.btnfind.Text = "Find"
        Me.btnfind.UseVisualStyleBackColor = False
        '
        'code
        '
        Me.code.Location = New System.Drawing.Point(127, 21)
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(69, 23)
        Me.code.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ingredient Code"
        '
        'stoview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(459, 381)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.exitt)
        Me.Controls.Add(Me.dtgstocks)
        Me.Name = "stoview"
        Me.Text = "STOCKS"
        CType(Me.dtgstocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgstocks As DataGridView
    Friend WithEvents btnremove As Button
    Friend WithEvents exitt As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents price As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cstocks As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents inname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnfind As Button
    Friend WithEvents code As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents btnded As Button
End Class
