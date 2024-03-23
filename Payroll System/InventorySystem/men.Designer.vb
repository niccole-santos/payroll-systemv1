<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class men
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(men))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bttnlog = New System.Windows.Forms.Button()
        Me.btnemplo = New System.Windows.Forms.Button()
        Me.btnpay = New System.Windows.Forms.Button()
        Me.btnsales = New System.Windows.Forms.Button()
        Me.btnpos = New System.Windows.Forms.Button()
        Me.btnsto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnnview = New System.Windows.Forms.Button()
        Me.btncanc = New System.Windows.Forms.Button()
        Me.addss = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Controls.Add(Me.bttnlog)
        Me.GroupBox1.Controls.Add(Me.btnemplo)
        Me.GroupBox1.Controls.Add(Me.btnpay)
        Me.GroupBox1.Controls.Add(Me.btnsales)
        Me.GroupBox1.Controls.Add(Me.btnpos)
        Me.GroupBox1.Controls.Add(Me.btnsto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'bttnlog
        '
        Me.bttnlog.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnlog.Font = New System.Drawing.Font("Raleway", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnlog.ForeColor = System.Drawing.Color.IndianRed
        Me.bttnlog.Location = New System.Drawing.Point(585, 38)
        Me.bttnlog.Name = "bttnlog"
        Me.bttnlog.Size = New System.Drawing.Size(75, 32)
        Me.bttnlog.TabIndex = 6
        Me.bttnlog.Text = "Logout"
        Me.bttnlog.UseVisualStyleBackColor = False
        '
        'btnemplo
        '
        Me.btnemplo.BackgroundImage = Global.InventorySystem.My.Resources.Resources.user
        Me.btnemplo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnemplo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnemplo.FlatAppearance.BorderSize = 0
        Me.btnemplo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnemplo.Location = New System.Drawing.Point(494, 19)
        Me.btnemplo.Name = "btnemplo"
        Me.btnemplo.Size = New System.Drawing.Size(75, 70)
        Me.btnemplo.TabIndex = 5
        Me.btnemplo.UseVisualStyleBackColor = True
        '
        'btnpay
        '
        Me.btnpay.BackColor = System.Drawing.Color.Transparent
        Me.btnpay.BackgroundImage = Global.InventorySystem.My.Resources.Resources.pay
        Me.btnpay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnpay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpay.FlatAppearance.BorderSize = 0
        Me.btnpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpay.Location = New System.Drawing.Point(413, 19)
        Me.btnpay.Name = "btnpay"
        Me.btnpay.Size = New System.Drawing.Size(75, 70)
        Me.btnpay.TabIndex = 4
        Me.btnpay.UseVisualStyleBackColor = False
        '
        'btnsales
        '
        Me.btnsales.BackgroundImage = Global.InventorySystem.My.Resources.Resources.sales
        Me.btnsales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsales.FlatAppearance.BorderSize = 0
        Me.btnsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsales.Location = New System.Drawing.Point(332, 19)
        Me.btnsales.Name = "btnsales"
        Me.btnsales.Size = New System.Drawing.Size(75, 70)
        Me.btnsales.TabIndex = 3
        Me.btnsales.UseVisualStyleBackColor = True
        '
        'btnpos
        '
        Me.btnpos.BackgroundImage = Global.InventorySystem.My.Resources.Resources._73_512
        Me.btnpos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnpos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpos.FlatAppearance.BorderSize = 0
        Me.btnpos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpos.Location = New System.Drawing.Point(251, 19)
        Me.btnpos.Name = "btnpos"
        Me.btnpos.Size = New System.Drawing.Size(75, 70)
        Me.btnpos.TabIndex = 2
        Me.btnpos.UseVisualStyleBackColor = True
        '
        'btnsto
        '
        Me.btnsto.BackColor = System.Drawing.Color.Transparent
        Me.btnsto.BackgroundImage = Global.InventorySystem.My.Resources.Resources.inventory
        Me.btnsto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsto.FlatAppearance.BorderSize = 0
        Me.btnsto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsto.Location = New System.Drawing.Point(170, 19)
        Me.btnsto.Name = "btnsto"
        Me.btnsto.Size = New System.Drawing.Size(75, 70)
        Me.btnsto.TabIndex = 1
        Me.btnsto.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 24)
        Me.Label1.TabIndex = 0
        '
        'Timer1
        '
        '
        'btnnview
        '
        Me.btnnview.BackColor = System.Drawing.Color.White
        Me.btnnview.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnview.ForeColor = System.Drawing.Color.Firebrick
        Me.btnnview.Location = New System.Drawing.Point(88, 156)
        Me.btnnview.Name = "btnnview"
        Me.btnnview.Size = New System.Drawing.Size(190, 37)
        Me.btnnview.TabIndex = 7
        Me.btnnview.Text = "View and Edit Stocks"
        Me.btnnview.UseVisualStyleBackColor = False
        '
        'btncanc
        '
        Me.btncanc.BackColor = System.Drawing.Color.White
        Me.btncanc.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncanc.ForeColor = System.Drawing.Color.Firebrick
        Me.btncanc.Location = New System.Drawing.Point(472, 156)
        Me.btncanc.Name = "btncanc"
        Me.btncanc.Size = New System.Drawing.Size(112, 37)
        Me.btncanc.TabIndex = 16
        Me.btncanc.Text = "Cancel"
        Me.btncanc.UseVisualStyleBackColor = False
        '
        'addss
        '
        Me.addss.BackColor = System.Drawing.Color.White
        Me.addss.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addss.ForeColor = System.Drawing.Color.Firebrick
        Me.addss.Location = New System.Drawing.Point(284, 156)
        Me.addss.Name = "addss"
        Me.addss.Size = New System.Drawing.Size(182, 37)
        Me.addss.TabIndex = 17
        Me.addss.Text = "Add New Ingredient"
        Me.addss.UseVisualStyleBackColor = False
        '
        'men
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(672, 418)
        Me.Controls.Add(Me.addss)
        Me.Controls.Add(Me.btncanc)
        Me.Controls.Add(Me.btnnview)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "men"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bttnlog As Button
    Friend WithEvents btnemplo As Button
    Friend WithEvents btnpay As Button
    Friend WithEvents btnsales As Button
    Friend WithEvents btnpos As Button
    Friend WithEvents btnsto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnnview As Button
    Friend WithEvents btncanc As Button
    Friend WithEvents addss As Button
End Class
