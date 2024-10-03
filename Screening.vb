Public Class Screening
    Public Property screeningID As Integer
    Public Property movieID As Integer
    Public Property Screen As Integer
    Public Property datetime As Date
    Public Property seats As List(Of Seat)
    Public Sub New(screeningId, movieId, Screen, datetime)
        screeningId = screeningId
        movieId = movieId
        Screen = Screen
        datetime = datetime
    End Sub
    Function getDate()
        Return datetime.Date
    End Function
    Function getTime()
        Return datetime.TimeOfDay
    End Function
End Class
