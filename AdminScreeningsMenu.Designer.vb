<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminScreeningsMenu
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
        Me.addScreeningBtn = New System.Windows.Forms.Button()
        Me.dltScreeningBtn = New System.Windows.Forms.Button()
        Me.dltScreeningTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ScreeningDgv = New System.Windows.Forms.DataGridView()
        Me.scrnDateTime = New System.Windows.Forms.DateTimePicker()
        Me.screenNoClb = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.crtScrnMovieTxt = New System.Windows.Forms.TextBox()
        Me.fltrScreeningsClb = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.ScreeningDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addScreeningBtn
        '
        Me.addScreeningBtn.Location = New System.Drawing.Point(562, 254)
        Me.addScreeningBtn.Name = "addScreeningBtn"
        Me.addScreeningBtn.Size = New System.Drawing.Size(236, 136)
        Me.addScreeningBtn.TabIndex = 15
        Me.addScreeningBtn.Text = "Add Screening"
        Me.addScreeningBtn.UseVisualStyleBackColor = True
        '
        'dltScreeningBtn
        '
        Me.dltScreeningBtn.Location = New System.Drawing.Point(562, 471)
        Me.dltScreeningBtn.Name = "dltScreeningBtn"
        Me.dltScreeningBtn.Size = New System.Drawing.Size(236, 103)
        Me.dltScreeningBtn.TabIndex = 14
        Me.dltScreeningBtn.Text = "Delete Booking"
        Me.dltScreeningBtn.UseVisualStyleBackColor = True
        '
        'dltScreeningTxt
        '
        Me.dltScreeningTxt.Location = New System.Drawing.Point(562, 432)
        Me.dltScreeningTxt.Name = "dltScreeningTxt"
        Me.dltScreeningTxt.Size = New System.Drawing.Size(137, 22)
        Me.dltScreeningTxt.TabIndex = 13
        Me.dltScreeningTxt.Text = "Input Screening ID..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(604, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Screenings Control"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Screenings Table"
        '
        'ScreeningDgv
        '
        Me.ScreeningDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScreeningDgv.Location = New System.Drawing.Point(3, 38)
        Me.ScreeningDgv.Name = "ScreeningDgv"
        Me.ScreeningDgv.RowHeadersWidth = 51
        Me.ScreeningDgv.RowTemplate.Height = 24
        Me.ScreeningDgv.Size = New System.Drawing.Size(553, 430)
        Me.ScreeningDgv.TabIndex = 10
        '
        'scrnDateTime
        '
        Me.scrnDateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.scrnDateTime.Location = New System.Drawing.Point(705, 148)
        Me.scrnDateTime.Name = "scrnDateTime"
        Me.scrnDateTime.Size = New System.Drawing.Size(93, 22)
        Me.scrnDateTime.TabIndex = 17
        '
        'screenNoClb
        '
        Me.screenNoClb.FormattingEnabled = True
        Me.screenNoClb.Items.AddRange(New Object() {"Screen 1" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "(12:10)", "Screen 2" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "(14:40)", "Screen 3" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "(16:40)"})
        Me.screenNoClb.Location = New System.Drawing.Point(562, 193)
        Me.screenNoClb.Name = "screenNoClb"
        Me.screenNoClb.Size = New System.Drawing.Size(236, 55)
        Me.screenNoClb.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(559, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Create Screening"
        '
        'crtScrnMovieTxt
        '
        Me.crtScrnMovieTxt.Location = New System.Drawing.Point(562, 148)
        Me.crtScrnMovieTxt.Name = "crtScrnMovieTxt"
        Me.crtScrnMovieTxt.Size = New System.Drawing.Size(137, 22)
        Me.crtScrnMovieTxt.TabIndex = 16
        Me.crtScrnMovieTxt.Text = "Movie name..."
        '
        'fltrScreeningsClb
        '
        Me.fltrScreeningsClb.FormattingEnabled = True
        Me.fltrScreeningsClb.Items.AddRange(New Object() {"Screening ID", "Movie Title", "Screen No", "Date"})
        Me.fltrScreeningsClb.Location = New System.Drawing.Point(33, 501)
        Me.fltrScreeningsClb.Name = "fltrScreeningsClb"
        Me.fltrScreeningsClb.Size = New System.Drawing.Size(139, 72)
        Me.fltrScreeningsClb.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 483)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Filter by:"
        '
        'AdminScreeningsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 586)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fltrScreeningsClb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.screenNoClb)
        Me.Controls.Add(Me.scrnDateTime)
        Me.Controls.Add(Me.crtScrnMovieTxt)
        Me.Controls.Add(Me.addScreeningBtn)
        Me.Controls.Add(Me.dltScreeningBtn)
        Me.Controls.Add(Me.dltScreeningTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ScreeningDgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminScreeningsMenu"
        Me.Text = "AdminScreeningsMenu"
        CType(Me.ScreeningDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addScreeningBtn As Button
    Friend WithEvents dltScreeningBtn As Button
    Friend WithEvents dltScreeningTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ScreeningDgv As DataGridView
    Friend WithEvents scrnDateTime As DateTimePicker
    Friend WithEvents screenNoClb As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents crtScrnMovieTxt As TextBox
    Friend WithEvents fltrScreeningsClb As CheckedListBox
    Friend WithEvents Label4 As Label
End Class
