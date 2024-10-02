<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
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
        Me.AdminPanel = New System.Windows.Forms.Panel()
        Me.usermenuBtn = New System.Windows.Forms.Button()
        Me.moviesmenuBtn = New System.Windows.Forms.Button()
        Me.screeningsmenuBtn = New System.Windows.Forms.Button()
        Me.bookingsmenuBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AdminPanel
        '
        Me.AdminPanel.Location = New System.Drawing.Point(163, 1)
        Me.AdminPanel.Name = "AdminPanel"
        Me.AdminPanel.Size = New System.Drawing.Size(816, 579)
        Me.AdminPanel.TabIndex = 0
        '
        'usermenuBtn
        '
        Me.usermenuBtn.Location = New System.Drawing.Point(12, 1)
        Me.usermenuBtn.Name = "usermenuBtn"
        Me.usermenuBtn.Size = New System.Drawing.Size(145, 139)
        Me.usermenuBtn.TabIndex = 0
        Me.usermenuBtn.Text = "User Menu"
        Me.usermenuBtn.UseVisualStyleBackColor = True
        '
        'moviesmenuBtn
        '
        Me.moviesmenuBtn.Location = New System.Drawing.Point(12, 147)
        Me.moviesmenuBtn.Name = "moviesmenuBtn"
        Me.moviesmenuBtn.Size = New System.Drawing.Size(145, 139)
        Me.moviesmenuBtn.TabIndex = 1
        Me.moviesmenuBtn.Text = "Movies Menu"
        Me.moviesmenuBtn.UseVisualStyleBackColor = True
        '
        'screeningsmenuBtn
        '
        Me.screeningsmenuBtn.Location = New System.Drawing.Point(12, 293)
        Me.screeningsmenuBtn.Name = "screeningsmenuBtn"
        Me.screeningsmenuBtn.Size = New System.Drawing.Size(145, 139)
        Me.screeningsmenuBtn.TabIndex = 2
        Me.screeningsmenuBtn.Text = "Screenings Menu"
        Me.screeningsmenuBtn.UseVisualStyleBackColor = True
        '
        'bookingsmenuBtn
        '
        Me.bookingsmenuBtn.Location = New System.Drawing.Point(12, 439)
        Me.bookingsmenuBtn.Name = "bookingsmenuBtn"
        Me.bookingsmenuBtn.Size = New System.Drawing.Size(145, 139)
        Me.bookingsmenuBtn.TabIndex = 3
        Me.bookingsmenuBtn.Text = "Bookings Menu"
        Me.bookingsmenuBtn.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 579)
        Me.Controls.Add(Me.bookingsmenuBtn)
        Me.Controls.Add(Me.screeningsmenuBtn)
        Me.Controls.Add(Me.moviesmenuBtn)
        Me.Controls.Add(Me.AdminPanel)
        Me.Controls.Add(Me.usermenuBtn)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AdminPanel As Panel
    Friend WithEvents usermenuBtn As Button
    Friend WithEvents moviesmenuBtn As Button
    Friend WithEvents screeningsmenuBtn As Button
    Friend WithEvents bookingsmenuBtn As Button
End Class
