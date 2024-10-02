<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminBookingsMenu
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
        Me.BookingDgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fcsBookingBtn = New System.Windows.Forms.Button()
        Me.dltBookingBtn = New System.Windows.Forms.Button()
        Me.controlBookingTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BookingsFltrTxt = New System.Windows.Forms.ComboBox()
        Me.resetFocusBtn = New System.Windows.Forms.Button()
        CType(Me.BookingDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookingDgv
        '
        Me.BookingDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookingDgv.Location = New System.Drawing.Point(12, 49)
        Me.BookingDgv.Name = "BookingDgv"
        Me.BookingDgv.RowHeadersWidth = 51
        Me.BookingDgv.RowTemplate.Height = 24
        Me.BookingDgv.Size = New System.Drawing.Size(553, 403)
        Me.BookingDgv.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bookings Table"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 477)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Filter by"
        '
        'fcsBookingBtn
        '
        Me.fcsBookingBtn.Location = New System.Drawing.Point(571, 315)
        Me.fcsBookingBtn.Name = "fcsBookingBtn"
        Me.fcsBookingBtn.Size = New System.Drawing.Size(166, 136)
        Me.fcsBookingBtn.TabIndex = 9
        Me.fcsBookingBtn.Text = "Focus Booking"
        Me.fcsBookingBtn.UseVisualStyleBackColor = True
        '
        'dltBookingBtn
        '
        Me.dltBookingBtn.Location = New System.Drawing.Point(571, 149)
        Me.dltBookingBtn.Name = "dltBookingBtn"
        Me.dltBookingBtn.Size = New System.Drawing.Size(236, 136)
        Me.dltBookingBtn.TabIndex = 8
        Me.dltBookingBtn.Text = "Delete Booking"
        Me.dltBookingBtn.UseVisualStyleBackColor = True
        '
        'controlBookingTxt
        '
        Me.controlBookingTxt.Location = New System.Drawing.Point(571, 108)
        Me.controlBookingTxt.Name = "controlBookingTxt"
        Me.controlBookingTxt.Size = New System.Drawing.Size(236, 22)
        Me.controlBookingTxt.TabIndex = 7
        Me.controlBookingTxt.Text = "Input Booking ID..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(567, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Bookings Control"
        '
        'BookingsFltrTxt
        '
        Me.BookingsFltrTxt.FormattingEnabled = True
        Me.BookingsFltrTxt.Items.AddRange(New Object() {"Booking ID", "User ID", "Screening ID", "Movie ID", "Price"})
        Me.BookingsFltrTxt.Location = New System.Drawing.Point(89, 474)
        Me.BookingsFltrTxt.Name = "BookingsFltrTxt"
        Me.BookingsFltrTxt.Size = New System.Drawing.Size(121, 24)
        Me.BookingsFltrTxt.TabIndex = 5
        '
        'resetFocusBtn
        '
        Me.resetFocusBtn.Location = New System.Drawing.Point(741, 315)
        Me.resetFocusBtn.Name = "resetFocusBtn"
        Me.resetFocusBtn.Size = New System.Drawing.Size(66, 136)
        Me.resetFocusBtn.TabIndex = 10
        Me.resetFocusBtn.Text = "Reset"
        Me.resetFocusBtn.UseVisualStyleBackColor = True
        '
        'AdminBookingsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 520)
        Me.Controls.Add(Me.resetFocusBtn)
        Me.Controls.Add(Me.fcsBookingBtn)
        Me.Controls.Add(Me.dltBookingBtn)
        Me.Controls.Add(Me.controlBookingTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BookingsFltrTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BookingDgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminBookingsMenu"
        Me.Text = "AdminBookingsMenu"
        CType(Me.BookingDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BookingDgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents fcsBookingBtn As Button
    Friend WithEvents dltBookingBtn As Button
    Friend WithEvents controlBookingTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BookingsFltrTxt As ComboBox
    Friend WithEvents resetFocusBtn As Button
End Class
