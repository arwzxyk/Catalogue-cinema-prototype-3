<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration))
        Me.RegAccBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UsernameTxt = New System.Windows.Forms.TextBox()
        Me.LNameTxt = New System.Windows.Forms.TextBox()
        Me.EmailTxt = New System.Windows.Forms.TextBox()
        Me.FNameTxt = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegAccBtn
        '
        Me.RegAccBtn.Location = New System.Drawing.Point(405, 322)
        Me.RegAccBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RegAccBtn.Name = "RegAccBtn"
        Me.RegAccBtn.Size = New System.Drawing.Size(256, 66)
        Me.RegAccBtn.TabIndex = 10
        Me.RegAccBtn.Text = "Create Account"
        Me.RegAccBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 40)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Welcome to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the Catalogue Cinema..."
        '
        'PasswordTxt
        '
        Me.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTxt.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTxt.Location = New System.Drawing.Point(77, 322)
        Me.PasswordTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Size = New System.Drawing.Size(182, 28)
        Me.PasswordTxt.TabIndex = 0
        Me.PasswordTxt.Text = "Create Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(40, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'UsernameTxt
        '
        Me.UsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsernameTxt.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTxt.Location = New System.Drawing.Point(77, 214)
        Me.UsernameTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UsernameTxt.Name = "UsernameTxt"
        Me.UsernameTxt.Size = New System.Drawing.Size(182, 28)
        Me.UsernameTxt.TabIndex = 0
        Me.UsernameTxt.Text = "Create Username"
        '
        'LNameTxt
        '
        Me.LNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LNameTxt.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNameTxt.Location = New System.Drawing.Point(405, 154)
        Me.LNameTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LNameTxt.Multiline = True
        Me.LNameTxt.Name = "LNameTxt"
        Me.LNameTxt.Size = New System.Drawing.Size(255, 24)
        Me.LNameTxt.TabIndex = 11
        Me.LNameTxt.Text = "Enter Lastname"
        '
        'EmailTxt
        '
        Me.EmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmailTxt.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTxt.Location = New System.Drawing.Point(405, 228)
        Me.EmailTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.Size = New System.Drawing.Size(255, 28)
        Me.EmailTxt.TabIndex = 12
        Me.EmailTxt.Text = "Enter Email"
        '
        'FNameTxt
        '
        Me.FNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FNameTxt.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNameTxt.Location = New System.Drawing.Point(405, 86)
        Me.FNameTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FNameTxt.Multiline = True
        Me.FNameTxt.Name = "FNameTxt"
        Me.FNameTxt.Size = New System.Drawing.Size(255, 24)
        Me.FNameTxt.TabIndex = 13
        Me.FNameTxt.Text = "Enter Firstname"
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 417)
        Me.Controls.Add(Me.FNameTxt)
        Me.Controls.Add(Me.EmailTxt)
        Me.Controls.Add(Me.LNameTxt)
        Me.Controls.Add(Me.UsernameTxt)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.RegAccBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Registration"
        Me.Text = "Registration"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RegAccBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UsernameTxt As TextBox
    Friend WithEvents LNameTxt As TextBox
    Friend WithEvents EmailTxt As TextBox
    Friend WithEvents FNameTxt As TextBox
End Class
