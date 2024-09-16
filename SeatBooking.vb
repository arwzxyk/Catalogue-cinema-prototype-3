Public Class SeatBooking
    Dim availableIcon As New System.Drawing.Bitmap(My.Resources.available)
    Dim selectedIcon As New System.Drawing.Bitmap(My.Resources.selected)
    'this allow us to use selection on an icon, as it is now an object
    Private Sub SeatBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then 'searches for every picture box in form
                CType(c, PictureBox).Image = My.Resources.available
                AddHandler c.Click, AddressOf PictureBox_Click
            End If
        Next
    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs)

        Dim pb As PictureBox = CType(sender, PictureBox)

        If Image.Equals(pb.Image, availableIcon) Then
            pb.Image = selectedIcon
        ElseIf Image.Equals(pb.Image, selectedIcon) Then
            pb.Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Image = selectedIcon
    End Sub
End Class