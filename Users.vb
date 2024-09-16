Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json

Public Class User
    Private Property UserID As Integer
    Private Property username As String
    Private Property Password As String
    Private Property Fname As String
    Private Property Lname As String
    Private Property Email As String
    Private Property IsAdmin As Boolean

    Public Sub New(UserID, HashedPassword, GivenUsername, GivenFname, GivenLname, GivenEmail)
        UserID = UserID
        Password = HashedPassword 'password is hashed before it is stored in the database
        username = GivenUsername
        Fname = GivenFname
        Lname = GivenLname
        Email = GivenEmail
        IsAdmin = False
    End Sub
    'get functions
    Public Function GetPasswordHash()
        Return Password
    End Function
    Public Function GetUsername()
        Return username
    End Function
    Public Function GetFname()
        Return Fname
    End Function
    Public Function GetLName()
        Return Lname
    End Function
    Public Function GetEmail()
        Return Email
    End Function
    Public Sub SetAdmin()
        IsAdmin = True
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
