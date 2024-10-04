
Imports System.Text

Public Class Registration

    Dim users As List(Of User) = LoadFromJson(Of List(Of User))("Database\users.json")




    Private Sub UsernameTxt_RemoveText(sender As Object, e As EventArgs) Handles UsernameTxt.GotFocus
        If UsernameTxt.Text = "Create Username" Then
            UsernameTxt.Text = ""
        End If
    End Sub
    Private Sub UsernameTxt_AddText(sender As Object, e As EventArgs) Handles UsernameTxt.LostFocus
        If UsernameTxt.Text = "" Then
            UsernameTxt.Text = "Create Username"
        End If
    End Sub
    Private Sub PasswordTxt_RemoveText(sender As Object, e As EventArgs) Handles PasswordTxt.GotFocus
        If PasswordTxt.Text = "Create Password" Then
            PasswordTxt.Text = ""
        End If
    End Sub
    Private Sub PasswordTxt_AddText(sender As Object, e As EventArgs) Handles PasswordTxt.LostFocus
        If PasswordTxt.Text = "" Then
            PasswordTxt.Text = "Create Password"
        End If
    End Sub
    Private Sub FNameRemoveText(sender As Object, e As EventArgs) Handles FNameTxt.GotFocus
        If FNameTxt.Text = "Enter Firstname" Then
            FNameTxt.Text = ""
        End If
    End Sub
    Private Sub FnameTxt_AddText(sender As Object, e As EventArgs) Handles FNameTxt.LostFocus
        If FNameTxt.Text = "" Then
            FNameTxt.Text = "Enter Firstname"
        End If
    End Sub
    Private Sub LNameTxt_RemoveText(sender As Object, e As EventArgs) Handles LNameTxt.GotFocus
        If LNameTxt.Text = "Enter Lastname" Then
            LNameTxt.Text = ""
        End If
    End Sub
    Private Sub LnameTxt_AddText(sender As Object, e As EventArgs) Handles LNameTxt.LostFocus
        If LNameTxt.Text = "" Then
            LNameTxt.Text = "Enter Lastname"
        End If
    End Sub
    Private Sub EmailTxt_RemoveText(sender As Object, e As EventArgs) Handles EmailTxt.GotFocus
        If EmailTxt.Text = "Enter Email" Then
            EmailTxt.Text = ""
        End If
    End Sub
    Private Sub EmailTxt_AddText(sender As Object, e As EventArgs) Handles EmailTxt.LostFocus
        If EmailTxt.Text = "" Then
            EmailTxt.Text = "Enter Email"
        End If
    End Sub

    'Instantiation
    Private Sub RegAccBtn_Click(sender As Object, e As EventArgs) Handles RegAccBtn.Click
        Dim validinput As Integer = -1
        If users Is Nothing Then
            users = New List(Of User)()
        End If
        Dim indexID As Integer = users.Count 'automatically at the end of the list + 1
        For i As Integer = 0 To users.Count - 1
            If users(i) Is Nothing Then
                indexID = i
                Exit For
            End If
        Next

        Dim givenUsername As String = UsernameTxt.Text
        Dim givenFname As String = FNameTxt.Text
        Dim givenLname As String = LNameTxt.Text
        Dim givenEmail As String = EmailTxt.Text
        Dim hashedPass As String = Encoding.UTF8.GetString((Sha256Hash(PasswordTxt.Text)))
        validinput += validateUsername(givenUsername)
        If validinput <> -1 Then
            SharedData.CurrentUser = New User(indexID, givenUsername, hashedPass, givenFname, givenLname, givenEmail)
            users.Add(SharedData.CurrentUser)

            SaveToJson(users, "Users.json")

            SharedData.loggedIn = True
            MsgBox("Account Registered Succesfully")
            ShowForm(Of Form1)()
            Me.Close()
        Else
            MsgBox("Invalid Input")
        End If
    End Sub

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Select()

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        ShowForm(Of Form1)()
        Me.Close()
    End Sub
    Public Function validateUsername(username As String)
        Dim validusername As Integer = 1
        If lengthCheck(validusername, 5) = True Then
            For i = 0 To users.Count - 1
                If users(i).username = username Then
                    validusername = 0
                End If
            Next
            MsgBox("Username is already taken")
        ElseIf lengthCheck(username, 5) = False Then
            MsgBox("Username is not over 5 characters")
        End If
        Return validusername
    End Function
End Class