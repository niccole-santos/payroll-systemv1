<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class emp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvemp = New System.Windows.Forms.DataGridView()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnadde = New System.Windows.Forms.Button()
        Me.btnremovee = New System.Windows.Forms.Button()
        CType(Me.dgvemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvemp
        '
        Me.dgvemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvemp.Location = New System.Drawing.Point(12, 12)
        Me.dgvemp.Name = "dgvemp"
        Me.dgvemp.Size = New System.Drawing.Size(798, 187)
        Me.dgvemp.TabIndex = 0
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.White
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnexit.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.Firebrick
        Me.btnexit.Location = New System.Drawing.Point(719, 214)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(91, 35)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnadde
        '
        Me.btnadde.BackColor = System.Drawing.Color.White
        Me.btnadde.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnadde.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnadde.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadde.ForeColor = System.Drawing.Color.Firebrick
        Me.btnadde.Location = New System.Drawing.Point(12, 214)
        Me.btnadde.Name = "btnadde"
        Me.btnadde.Size = New System.Drawing.Size(146, 35)
        Me.btnadde.TabIndex = 4
        Me.btnadde.Text = "Add Employee"
        Me.btnadde.UseVisualStyleBackColor = False
        '
        'btnremovee
        '
        Me.btnremovee.BackColor = System.Drawing.Color.White
        Me.btnremovee.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnremovee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnremovee.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremovee.ForeColor = System.Drawing.Color.Firebrick
        Me.btnremovee.Location = New System.Drawing.Point(164, 214)
        Me.btnremovee.Name = "btnremovee"
        Me.btnremovee.Size = New System.Drawing.Size(172, 35)
        Me.btnremovee.TabIndex = 5
        Me.btnremovee.Text = "Remove Employee"
        Me.btnremovee.UseVisualStyleBackColor = False
        '
        'emp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(822, 261)
        Me.Controls.Add(Me.btnremovee)
        Me.Controls.Add(Me.btnadde)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.dgvemp)
        Me.Name = "emp"
        Me.Text = "EMPLOYEE INFORMATION"
        CType(Me.dgvemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvemp As DataGridView
    Friend WithEvents btnexit As Button
    Friend WithEvents btnadde As Button
    Friend WithEvents btnremovee As Button
End Class
