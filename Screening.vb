Public Class Screening
    Public Property screeningID As Integer
    Public Property movieID As Integer
    Public Property Screen As Integer
    Public Property datetime As Date
    Public Property seatingID As Integer
    Public Sub New(nscreeningId As Integer, nmovieId As Integer, nScreen As Integer, ndatetime As DateTime, nseatingID As Integer)
        screeningID = nscreeningId
        movieID = nmovieId
        Screen = nScreen
        datetime = ndatetime
        seatingID = nseatingID
    End Sub
    Function getDate()
        Return datetime.Date
    End Function
    Function getTime()
        Return datetime.TimeOfDay
    End Function
End Class
