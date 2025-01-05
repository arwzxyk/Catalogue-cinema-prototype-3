Imports Microsoft.VisualBasic.ApplicationServices

Public Class Seat
    Public Property SeatID As Integer
    Public Property Reference As String
    Public Property isAvailable As Boolean
    Public Sub New(ID As Integer, ref As String, Availability As Boolean) 'this new function is only used for temporary lists in the booking form, allowing for multiple seats to be added to a seating array
        SeatID = ID
        Reference = ref
        isAvailable = Availability
    End Sub
End Class

Public Class Seating
    Public Property SeatingID As Integer
    Public Property SeatingList As List(Of Seat)

    Public Sub New(nseatingID As Integer)
        SeatingID = nseatingID
        SeatingList = New List(Of Seat)() 'create empty list to add empty seats
        CreateSeating()

    End Sub

    Private Sub CreateSeating()
        Dim rows As Char() = {"A", "B", "C", "D", "E"}
        Dim index As Integer = 0
        For y = 0 To 4 'no of rows -1 for rows character array indexing
            For x = 1 To 16 'no of columns
                Dim seatRef As String = (rows(y) & x.ToString)
                SeatingList.Add(New Seat(index, seatRef, True))
                index = index + 1
            Next
        Next
    End Sub
End Class
