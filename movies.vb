﻿Public Class movie
    Public Property Title As String
    Public Property Year As String
    Public Property Rated As String
    Public Property Released As String
    Public Property Runtime As String
    Public Property Genre As String
    Public Property Director As String
    Public Property Writer As String
    Public Property Actors As String
    Public Property Plot As String
    Public Property Language As String
    Public Property Country As String
    Public Property Awards As String
    Public Property Poster As String
    Public Property Ratings As List(Of Rating) 'ratings can have different sources, which
    'the values are dependent to, requiring a new class
    Public Property Metascore As String
    Public Property ImdbRating As String
    Public Property ImdbVotes As String
    Public Property ImdbID As String
    Public Property Type As String
    Public Property DVD As String
    Public Property BoxOffice As String
    Public Property Production As String
    Public Property Website As String
    Public Property Response As String
End Class

Public Class Rating
    Public Property Source As String
    Public Property Value As String

End Class
