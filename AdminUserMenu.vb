Imports System.Reflection

Public Class AdminUserMenu
    Dim users As List(Of User) = LoadFromJson(Of List(Of User))("Database\Users")
    Sub display_users()
        UsersDgv.DataSource = users
        UsersDgv.Columns("password").Visible = False
    End Sub

    Private Sub dltUserBtn_Click(sender As Object, e As EventArgs) Handles dltUserBtn.Click
        Dim index As Integer = CInt(controlUserTxt.Text)
        If index >= 0 And index <= users.Count Then
            users.Remove(users(index))
            SaveToJson(users, "Database\Users")
            MsgBox("User removed")
        Else
            MsgBox("User does not exist")
        End If
    End Sub

    Private Sub fcsUserBtn_Click(sender As Object, e As EventArgs) Handles fcsUserBtn.Click
        Dim index As Integer = CInt(controlUserTxt.Text)
        If Index >= 0 And Index <= users.Count Then
            UsersDgv.DataSource = users(index)
            UsersDgv.Columns("password").Visible = False
        Else
            MsgBox("User does not exist")
        End If
    End Sub

    Private Sub resetFocusBtn_Click(sender As Object, e As EventArgs) Handles resetFocusBtn.Click
        display_users()
    End Sub

    Private Sub AdminUserMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_users()
    End Sub
End Class