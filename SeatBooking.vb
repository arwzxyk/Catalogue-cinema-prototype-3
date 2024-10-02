Public Class SeatBooking
    Dim availableIcon As New System.Drawing.Bitmap(My.Resources.available)
    Dim selectedIcon As New System.Drawing.Bitmap(My.Resources.selected)
    Dim sortedControls = SeatingPanel.Controls.Cast(Of Control)().OrderBy(Function(c) c.Left).ThenBy(Function(c) c.Top)
    Dim TotalSum As Double = 0
    'this allow us to use selection on an icon, as it is now an object
    Private Sub SeatBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SumLabel.Text = "Your total is £" & Math.Round(TotalSum, 2)
        For Each control In SeatingPanel.Controls
            If TypeOf control Is PictureBox Then 'searches for every picture box in form
                Dim picturebox As PictureBox = CType(control, PictureBox)
                picturebox.Enabled = True
                picturebox.Image = availableIcon
                AddHandler picturebox.Click, AddressOf PictureBox_Click
            End If
        Next
    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs)

        Dim pb As PictureBox = CType(sender, PictureBox)
        If Image.Equals(pb.Image, availableIcon) Then
            pb.Image = selectedIcon
            TotalSum = TotalSum + 10.2
            SumLabel.Text = "Your total is £" & Format((TotalSum), "0.00")
        ElseIf Image.Equals(pb.Image, selectedIcon) Then
            pb.Image = availableIcon
            TotalSum = TotalSum - 10.2
            SumLabel.Text = "Your total is £" & Format((TotalSum), "0.00")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        PictureBox1.Image = selectedIcon
    End Sub
End Class