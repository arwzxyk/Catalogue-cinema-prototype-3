Public Class Admin
    Private Sub Usermenu_Click(sender As Object, e As EventArgs) Handles usermenuBtn.Click
        switchmenu(AdminUserMenu)
    End Sub
    Private Sub Moviesmenu_Click(sender As Object, e As EventArgs) Handles moviesmenuBtn.Click
        switchmenu(AdminMoviesMenu)
    End Sub
    Private Sub Screeningsmenu_Click(sender As Object, e As EventArgs) Handles screeningsmenuBtn.Click
        switchmenu(AdminScreeningsMenu)
    End Sub
    Private Sub Bookingsmenu_Click(sender As Object, e As EventArgs) Handles bookingsmenuBtn.Click
        switchmenu(AdminBookingsMenu)
    End Sub
    Sub switchmenu(ByVal menu As Form)
        AdminPanel.Controls.Clear()
        menu.TopLevel = False
        menu.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        menu.Dock = DockStyle.Fill
        AdminPanel.Controls.Add(menu)
        menu.Show()
    End Sub
End Class