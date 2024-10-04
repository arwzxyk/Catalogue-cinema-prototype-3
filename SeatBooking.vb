Imports System.Runtime.Remoting.Messaging
Imports Microsoft.VisualBasic.ApplicationServices

Public Class SeatBooking
    Dim availableIcon As New System.Drawing.Bitmap(My.Resources.available)
    Dim selectedIcon As New System.Drawing.Bitmap(My.Resources.selected)
    Dim unavailableIcon As New System.Drawing.Bitmap(My.Resources.unavailable)
    Dim sortedControls = SeatingPanel.Controls.Cast(Of Control)().OrderBy(Function(c) c.Left).ThenBy(Function(c) c.Top)
    Dim TotalSum As Double = 0 'price sum
    Dim seats As New List(Of Seat)()
    Dim seatings As List(Of Seating) = LoadFromJson(Of List(Of Seating))("Database\Seatings")
    Dim screenings As List(Of Screening) = LoadFromJson(Of List(Of Screening))("Database\Screenings")
    Dim UscreeningID As Integer
    'this allow us to use selection on an icon, as it is now an object
    Public Sub New(screeningId As Integer)

        InitializeComponent()
        UscreeningID = screeningId
        Dim seatingID As Integer = screenings(screeningId).seatingID
        seats = seatings(seatingID).SeatingList 'find seatinglist
        For i = 0 To seats.Count - 1
            If TypeOf sortedControls(i) Is PictureBox Then 'searches for every picture box in form
                Dim picturebox As PictureBox = CType(sortedControls(i), PictureBox)
                If seats(i).isAvailable = True Then
                    picturebox.Enabled = True

                    picturebox.Image = availableIcon
                    AddHandler picturebox.Click, AddressOf PictureBox_Click
                ElseIf seats(i).isAvailable = False Then
                    picturebox.Enabled = False
                    picturebox.Image = unavailableIcon
                End If
                picturebox.Tag = i ' I attach the seat id to the picturebox of the seat
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


    Private Sub CheckoutBtn_Click(sender As Object, e As EventArgs) Handles CheckoutBtn.Click
        Dim bookings As List(Of Booking) = LoadFromJson(Of List(Of Booking))("Database\Bookings")
        Dim bookingID As Integer = bookings.Count
        Dim movieID As Integer = screenings(UscreeningID).movieID
        Dim bookedSeats As New List(Of Seat)()
        For i = 0 To sortedControls.count - 1
            If TypeOf sortedControls(i) Is PictureBox Then
                Dim picturebox As PictureBox = CType(sortedControls(i), PictureBox)
                If Image.Equals(picturebox, selectedIcon) Then
                    seats(i).isAvailable = False
                    bookedSeats.Add(seats(i))
                End If
            End If
        Next
        For i As Integer = 0 To bookings.Count - 1
            If bookings(i) Is Nothing Then
                bookingID = i
            End If
        Next
        bookings.Add(New Booking(bookingID, SharedData.CurrentUser.UserID, UscreeningID, movieID, bookedSeats, TotalSum))
        SaveToJson(bookings, "Database\Bookings")
        MsgBox("Booking Created succesfully")
    End Sub

End Class