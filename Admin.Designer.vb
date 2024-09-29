<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.UserPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DltUserBtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ByUserTxt = New System.Windows.Forms.TextBox()
        Me.ByIDTxt = New System.Windows.Forms.TextBox()
        Me.UserPanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserPanel
        '
        Me.UserPanel.Controls.Add(Me.ByIDTxt)
        Me.UserPanel.Controls.Add(Me.ByUserTxt)
        Me.UserPanel.Controls.Add(Me.Label1)
        Me.UserPanel.Controls.Add(Me.DataGridView1)
        Me.UserPanel.Controls.Add(Me.DltUserBtn)
        Me.UserPanel.Controls.Add(Me.Button1)
        Me.UserPanel.Location = New System.Drawing.Point(95, 1)
        Me.UserPanel.Name = "UserPanel"
        Me.UserPanel.Size = New System.Drawing.Size(704, 451)
        Me.UserPanel.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 129)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DltUserBtn
        '
        Me.DltUserBtn.Location = New System.Drawing.Point(560, 308)
        Me.DltUserBtn.Name = "DltUserBtn"
        Me.DltUserBtn.Size = New System.Drawing.Size(141, 129)
        Me.DltUserBtn.TabIndex = 1
        Me.DltUserBtn.Text = "Delete User"
        Me.DltUserBtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(698, 299)
        Me.DataGridView1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(442, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Remove User:"
        '
        'ByUserTxt
        '
        Me.ByUserTxt.Location = New System.Drawing.Point(446, 341)
        Me.ByUserTxt.Name = "ByUserTxt"
        Me.ByUserTxt.Size = New System.Drawing.Size(100, 22)
        Me.ByUserTxt.TabIndex = 4
        Me.ByUserTxt.Text = "By Username..."
        '
        'ByIDTxt
        '
        Me.ByIDTxt.Location = New System.Drawing.Point(446, 402)
        Me.ByIDTxt.Name = "ByIDTxt"
        Me.ByIDTxt.Size = New System.Drawing.Size(100, 22)
        Me.ByIDTxt.TabIndex = 5
        Me.ByIDTxt.Text = "By User ID..."
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UserPanel)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.UserPanel.ResumeLayout(False)
        Me.UserPanel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserPanel As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DltUserBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ByIDTxt As TextBox
    Friend WithEvents ByUserTxt As TextBox
End Class
