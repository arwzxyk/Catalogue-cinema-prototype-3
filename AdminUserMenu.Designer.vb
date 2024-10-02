<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUserMenu
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
        Me.UsersDgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.controlUserTxt = New System.Windows.Forms.TextBox()
        Me.dltUserBtn = New System.Windows.Forms.Button()
        Me.fcsUserBtn = New System.Windows.Forms.Button()
        Me.resetFocusBtn = New System.Windows.Forms.Button()
        CType(Me.UsersDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsersDgv
        '
        Me.UsersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersDgv.Location = New System.Drawing.Point(17, 55)
        Me.UsersDgv.Name = "UsersDgv"
        Me.UsersDgv.RowHeadersWidth = 51
        Me.UsersDgv.RowTemplate.Height = 24
        Me.UsersDgv.Size = New System.Drawing.Size(471, 414)
        Me.UsersDgv.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Users Table"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(520, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "User Control"
        '
        'controlUserTxt
        '
        Me.controlUserTxt.Location = New System.Drawing.Point(524, 126)
        Me.controlUserTxt.Name = "controlUserTxt"
        Me.controlUserTxt.Size = New System.Drawing.Size(236, 22)
        Me.controlUserTxt.TabIndex = 3
        Me.controlUserTxt.Text = "Username/ID..."
        '
        'dltUserBtn
        '
        Me.dltUserBtn.Location = New System.Drawing.Point(524, 167)
        Me.dltUserBtn.Name = "dltUserBtn"
        Me.dltUserBtn.Size = New System.Drawing.Size(236, 136)
        Me.dltUserBtn.TabIndex = 4
        Me.dltUserBtn.Text = "Delete User"
        Me.dltUserBtn.UseVisualStyleBackColor = True
        '
        'fcsUserBtn
        '
        Me.fcsUserBtn.Location = New System.Drawing.Point(524, 333)
        Me.fcsUserBtn.Name = "fcsUserBtn"
        Me.fcsUserBtn.Size = New System.Drawing.Size(164, 136)
        Me.fcsUserBtn.TabIndex = 5
        Me.fcsUserBtn.Text = "Focus User"
        Me.fcsUserBtn.UseVisualStyleBackColor = True
        '
        'resetFocusBtn
        '
        Me.resetFocusBtn.Location = New System.Drawing.Point(694, 333)
        Me.resetFocusBtn.Name = "resetFocusBtn"
        Me.resetFocusBtn.Size = New System.Drawing.Size(66, 136)
        Me.resetFocusBtn.TabIndex = 6
        Me.resetFocusBtn.Text = "Reset"
        Me.resetFocusBtn.UseVisualStyleBackColor = True
        '
        'AdminUserMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 518)
        Me.Controls.Add(Me.resetFocusBtn)
        Me.Controls.Add(Me.fcsUserBtn)
        Me.Controls.Add(Me.dltUserBtn)
        Me.Controls.Add(Me.controlUserTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UsersDgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminUserMenu"
        Me.Text = "AdminUserMenu"
        CType(Me.UsersDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsersDgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents controlUserTxt As TextBox
    Friend WithEvents dltUserBtn As Button
    Friend WithEvents fcsUserBtn As Button
    Friend WithEvents resetFocusBtn As Button
End Class
