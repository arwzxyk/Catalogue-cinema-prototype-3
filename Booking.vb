Public Class Booking
    Public Property BookingID As Integer
    Public Property UserID As Integer
    Public Property screeningID As Integer
    Public Property movieID As Integer
    Public Property Seats As List(Of Seat)
    Public Property Price As Double
    Public Sub New(GivenBookingID, GivenUserID, GivenScreeningID, GivenMovieID, GivenSeats, GivenPrice)
        BookingID = GivenBookingID
        UserID = GivenUserID
        screeningID = GivenScreeningID
        movieID = GivenMovieID
        Seats = GivenSeats
        Price = GivenPrice

    End Sub

End Class
