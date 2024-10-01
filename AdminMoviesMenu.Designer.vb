<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminMoviesMenu
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
        Me.mvTitleTxt = New System.Windows.Forms.TextBox()
        Me.mvPlotTxt = New System.Windows.Forms.TextBox()
        Me.mvCastTxt = New System.Windows.Forms.TextBox()
        Me.posterPb = New System.Windows.Forms.PictureBox()
        Me.PrevBtn = New System.Windows.Forms.Button()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.mvDateTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mvGenresTxt = New System.Windows.Forms.TextBox()
        CType(Me.posterPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mvTitleTxt
        '
        Me.mvTitleTxt.Enabled = False
        Me.mvTitleTxt.Location = New System.Drawing.Point(49, 54)
        Me.mvTitleTxt.Name = "mvTitleTxt"
        Me.mvTitleTxt.Size = New System.Drawing.Size(246, 22)
        Me.mvTitleTxt.TabIndex = 0
        '
        'mvPlotTxt
        '
        Me.mvPlotTxt.Enabled = False
        Me.mvPlotTxt.Location = New System.Drawing.Point(49, 133)
        Me.mvPlotTxt.Multiline = True
        Me.mvPlotTxt.Name = "mvPlotTxt"
        Me.mvPlotTxt.Size = New System.Drawing.Size(377, 226)
        Me.mvPlotTxt.TabIndex = 2
        '
        'mvCastTxt
        '
        Me.mvCastTxt.Enabled = False
        Me.mvCastTxt.Location = New System.Drawing.Point(439, 54)
        Me.mvCastTxt.Multiline = True
        Me.mvCastTxt.Name = "mvCastTxt"
        Me.mvCastTxt.Size = New System.Drawing.Size(349, 53)
        Me.mvCastTxt.TabIndex = 3
        '
        'posterPb
        '
        Me.posterPb.Location = New System.Drawing.Point(439, 133)
        Me.posterPb.Name = "posterPb"
        Me.posterPb.Size = New System.Drawing.Size(349, 294)
        Me.posterPb.TabIndex = 4
        Me.posterPb.TabStop = False
        '
        'PrevBtn
        '
        Me.PrevBtn.Location = New System.Drawing.Point(49, 380)
        Me.PrevBtn.Name = "PrevBtn"
        Me.PrevBtn.Size = New System.Drawing.Size(168, 47)
        Me.PrevBtn.TabIndex = 5
        Me.PrevBtn.Text = "Previous"
        Me.PrevBtn.UseVisualStyleBackColor = True
        '
        'NextBtn
        '
        Me.NextBtn.Location = New System.Drawing.Point(258, 380)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(168, 47)
        Me.NextBtn.TabIndex = 6
        Me.NextBtn.Text = "Next"
        Me.NextBtn.UseVisualStyleBackColor = True
        '
        'mvDateTxt
        '
        Me.mvDateTxt.Enabled = False
        Me.mvDateTxt.Location = New System.Drawing.Point(49, 85)
        Me.mvDateTxt.Name = "mvDateTxt"
        Me.mvDateTxt.Size = New System.Drawing.Size(100, 22)
        Me.mvDateTxt.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 26)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "View Movies"
        '
        'mvGenresTxt
        '
        Me.mvGenresTxt.Enabled = False
        Me.mvGenresTxt.Location = New System.Drawing.Point(164, 85)
        Me.mvGenresTxt.Name = "mvGenresTxt"
        Me.mvGenresTxt.Size = New System.Drawing.Size(262, 22)
        Me.mvGenresTxt.TabIndex = 13
        '
        'AdminMoviesMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mvGenresTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mvDateTxt)
        Me.Controls.Add(Me.NextBtn)
        Me.Controls.Add(Me.PrevBtn)
        Me.Controls.Add(Me.posterPb)
        Me.Controls.Add(Me.mvCastTxt)
        Me.Controls.Add(Me.mvPlotTxt)
        Me.Controls.Add(Me.mvTitleTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminMoviesMenu"
        Me.Text = "AdminMoviesMenu"
        CType(Me.posterPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mvTitleTxt As TextBox
    Friend WithEvents mvPlotTxt As TextBox
    Friend WithEvents mvCastTxt As TextBox
    Friend WithEvents posterPb As PictureBox
    Friend WithEvents PrevBtn As Button
    Friend WithEvents NextBtn As Button
    Friend WithEvents mvDateTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mvGenresTxt As TextBox
End Class
