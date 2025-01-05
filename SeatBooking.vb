Imports System.Runtime.Remoting.Messaging
Imports Microsoft.VisualBasic.ApplicationServices

Public Class SeatBooking
    Dim availableIcon As New System.Drawing.Bitmap(My.Resources.available)
    Dim selectedIcon As New System.Drawing.Bitmap(My.Resources.selected)
    Dim unavailableIcon As New System.Drawing.Bitmap(My.Resources.unavailable)
    Dim sortedcontrols As IEnumerable(Of Control)
    Dim TotalSum As Double = 0 'price sum
    Dim seats As New List(Of Seat)()
    Dim seatings As List(Of Seating) = LoadFromJson(Of List(Of Seating))("Database\Seatings.json")
    Dim screenings As List(Of Screening) = LoadFromJson(Of List(Of Screening))("Database\Screenings.json")
    Dim UscreeningID As Integer
    'this allow us to use selection on an icon, as it is now an object
    Public Sub New(screeningId As Integer)

        InitializeComponent()

        For Each picturebox As PictureBox In SeatingPanel.Controls
            If picturebox.Image Is Nothing Then
                SeatingPanel.Controls.Remove(picturebox)
            End If
        Next
        'for some reason there are some hidden pictureboxes that mess up the sorted controls, im too lazy to redo the panel so i just delete them

        sortedcontrols = SeatingPanel.Controls.
                    OfType(Of PictureBox)().
                     OrderBy(Function(c) c.Left).
                     ThenBy(Function(c) c.Top)

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

            End If
        Next

    End Sub


    Private Sub PictureBox_Click(sender As Object, e As EventArgs)
        Dim pb As PictureBox = CType(sender, PictureBox)
        'select seats and adds prices

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
        Dim bookings As List(Of Booking) = LoadFromJson(Of List(Of Booking))("Database\Bookings.json")
        Dim bookingID As Integer = bookings.Count
        Dim movieID As Integer = screenings(UscreeningID).movieID
        Dim Currentseating As Seating = seatings(screenings(UscreeningID).seatingID) 'current seating arrangement
        Dim bookedSeats As New List(Of Seat)()
        Dim currentuserID As Integer = SharedData.CurrentUser.UserID

        For i = 0 To sortedControls.count - 1
            If TypeOf sortedcontrols(i) Is PictureBox Then
                Dim picturebox As PictureBox = CType(sortedcontrols(i), PictureBox)

                If Image.Equals(picturebox.Image, selectedIcon) Then
                    seats(i).isAvailable = False
                    'we change the booked seats to unavailable in order to be saved back into the seating list
                    bookedSeats.Add(seats(i))
                End If
            End If

        Next

        seatings(screenings(UscreeningID).seatingID) = Currentseating 'save to the seating list
        Dim booking As New Booking(bookingID, currentuserID, UscreeningID, movieID, bookedSeats, TotalSum)
        If bookings Is Nothing Then
            bookings = New List(Of Booking)
        End If
        AddToList(Of Booking)(bookings, booking)

        'save back to json
        SaveToJson(bookings, "Database\Bookings.json")
        SaveToJson(seatings, "Database\Seatings.json")
        MsgBox("Booking Created succesfully")
        Me.Close()
    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SeatingPanel_Paint(sender As Object, e As PaintEventArgs) Handles SeatingPanel.Paint

    End Sub

    Private Sub SumLabel_Click(sender As Object, e As EventArgs) Handles SumLabel.Click

    End Sub

    Private Sub SeatBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox95_Click(sender As Object, e As EventArgs) Handles PictureBox95.Click

    End Sub
End Class