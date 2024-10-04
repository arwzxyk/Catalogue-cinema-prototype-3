

Public Class Login
    'text changer

    Private Sub UsernameTxt_RemoveText(sender As Object, e As EventArgs) Handles UsernameTxt.GotFocus
        If UsernameTxt.Text = "Enter Username" Then
            UsernameTxt.Text = ""
        End If
    End Sub
    Private Sub UsernameTxt_AddText(sender As Object, e As EventArgs) Handles UsernameTxt.LostFocus
        If UsernameTxt.Text = "" Then
            UsernameTxt.Text = "Enter Username"
        End If
    End Sub
    Private Sub PasswordTxt_RemoveText(sender As Object, e As EventArgs) Handles PasswordTxt.GotFocus
        If PasswordTxt.Text = "Enter Password" Then
            PasswordTxt.Text = ""
        End If
    End Sub



    Private Sub PasswordTxt_AddText(sender As Object, e As EventArgs) Handles PasswordTxt.LostFocus
        If PasswordTxt.Text = "" Then
            PasswordTxt.Text = "Enter Password"
        End If
    End Sub

    Private Sub SigninBtn_Click(sender As Object, e As EventArgs) Handles SigninBtn.Click
        Dim users As List(Of User) = LoadFromJson(Of List(Of User))("Database\users.json")
        Dim userID As Integer = 0
        If users Is Nothing Then
            users = New List(Of User)()

        Else
            userID = BinarySearch(users, UsernameTxt.Text)
        End If


        If userID <> -1 Then
            If Sha256Hash(PasswordTxt.Text) = users(userID).Password Then
                SharedData.loggedIn = True
                SharedData.CurrentUser = users(userID)
                MsgBox("Login success")
                ShowForm(Of Form1)()
                If SharedData.CurrentUser.IsAdmin = True Then
                    Dim AdminForm As New Admin
                    AdminForm.Show()
                End If
                Me.Close()


            Else
                MsgBox("incorrect password")
            End If
        Else
            MsgBox("Username or Password incorrrect")
        End If
    End Sub

    Private Function BinarySearch(ByVal users As List(Of User), ByVal username As String) As Integer
        Dim low As Integer = 0
        Dim high As Integer = users.Count - 1

        While low <= high
            Dim mid As Integer = low + (high - low) \ 2
            Dim comparison As Integer = String.Compare(users(mid).username(), username)

            If comparison = 0 Then
                Return mid ' Username found
            ElseIf comparison < 0 Then
                low = mid + 1
            Else
                high = mid - 1
            End If
        End While

        Return -1 ' Username not found
    End Function

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Select()

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        ShowForm(Of Form1)()
        Me.Close()
    End Sub
End Class