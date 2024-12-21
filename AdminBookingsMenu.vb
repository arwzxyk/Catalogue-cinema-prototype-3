Public Class AdminBookingsMenu
    Dim bookings As List(Of Booking) = LoadFromJson(Of List(Of Booking))("Database\Bookings.json")
    Sub display_bookings()
        BookingDgv.DataSource = bookings

    End Sub

    Private Sub dltBookingBtn_Click(sender As Object, e As EventArgs) Handles dltBookingBtn.Click
        Dim index As Integer = CInt(controlBookingTxt.Text)
        If index >= 0 And index < bookings.Count Then
            bookings(index) = Nothing
            SaveToJson(bookings, "Database\Bookings.json")
            MsgBox("Booking removed")
        Else
            MsgBox("Booking does not exist")
        End If
    End Sub

    Private Sub fcsBookingBtn_Click(sender As Object, e As EventArgs) Handles fcsBookingBtn.Click
        Dim index As Integer = CInt(controlBookingTxt.Text)
        If index >= 0 And index < bookings.Count Then
            BookingDgv.DataSource = bookings(index)
        Else
            MsgBox("Booking does not exist")
        End If
    End Sub



    Private Sub resetFocusBtn_Click_1(sender As Object, e As EventArgs) Handles resetFocusBtn.Click
        display_bookings()
    End Sub

    Private Sub AdminBookingsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_bookings()
    End Sub

    Private Sub BookingsFltrTxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BookingsFltrTxt.SelectedIndexChanged
        Select Case BookingsFltrTxt.SelectedIndex
            Case 0

                QuickSort(Of Booking)(bookings, 0, bookings.Count - 1, Function(b) b.BookingID)
            Case 1
                QuickSort(Of Booking)(bookings, 0, bookings.Count - 1, Function(b) b.UserID)
            Case 2
                QuickSort(Of Booking)(bookings, 0, bookings.Count - 1, Function(b) b.screeningID)
            Case 3
                QuickSort(Of Booking)(bookings, 0, bookings.Count - 1, Function(b) b.movieID)
            Case 4
                QuickSort(Of Booking)(bookings, 0, bookings.Count - 1, Function(b) b.Price)
        End Select
        display_bookings() 're-displays the new sorted list
    End Sub


End Class