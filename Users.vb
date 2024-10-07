Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json

Public Class User
    Public Property UserID As Integer
    Public Property username As String
    Public Property Password As String
    Public Property Fname As String
    Public Property Lname As String
    Public Property Email As String
    Public Property IsAdmin As Boolean




    Public Sub New(GivenUserID, GivenUsername, HashedPassword, GivenFname, GivenLname, GivenEmail)
        UserID = GivenUserID
        Password = HashedPassword 'password is hashed before it is stored in the database
        username = GivenUsername
        Fname = GivenFname
        Lname = GivenLname
        Email = GivenEmail
        IsAdmin = False
    End Sub



    Public Function ToJson() As String 'when i serialise a user, to keep the attributes private but to be able to write to json, we create public json properties for each private property
        Dim jsonObject As New JObject(
            New JProperty("UserID", UserID),
            New JProperty("Username", username),
            New JProperty("Password", Password),
            New JProperty("Fname", Fname),
            New JProperty("Lname", Lname),
            New JProperty("Email", Email),
            New JProperty("IsAdmin", IsAdmin)
        )
        Return jsonObject.ToString(Formatting.Indented)
    End Function

End Class
