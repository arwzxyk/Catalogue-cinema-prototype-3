Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Public Class Form1
    Dim movies As List(Of movie) = LoadFromJson(Of List(Of movie))("movies.json")


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SharedData.loggedIn = True Then
            'Dim username As String = getuser
            UserLabel.Text = "Welcome "
            LgnBtn.Hide()
            RegBtn.Hide()
            'user log in/ register
        ElseIf SharedData.loggedIn = False Then
            UserLabel.Text = "It seems you are not logged in, Press Login if you have an account 
or press Register, to register with us today"
            TabPage4.Refresh()
        End If
        'Dim labelCount As Integer = TabPage1.Controls.OfType(Of Label)().Count()
        Label1.Text = movies(0).Title
        PictureBox1.ImageLocation = movies(0).Poster
    End Sub

    Private Sub LgnBtn_Click(sender As Object, e As EventArgs) Handles LgnBtn.Click
        Dim UserLogin As New Login
        UserLogin.Show()
        Me.Hide()
    End Sub

    Private Sub RegBtn_Click(sender As Object, e As EventArgs) Handles RegBtn.Click
        Dim UserRegister As New Registration
        UserRegister.Show()
        Me.Hide()
    End Sub



    Private Sub BookSeatBtn_Click(sender As Object, e As EventArgs) Handles BookSeatBtn.Click
        Dim newSeatBooking As New SeatBooking
        newSeatBooking.Show()
        Me.Hide()
    End Sub

    Private Sub ScreenTime1Lbl_Click(sender As Object, e As EventArgs) Handles ScreenTime1Lbl.Click
        ScreenTime1Lbl.ForeColor = Color.Red
        ScreenTime2Lbl.ForeColor = Color.Black
        ScreenTime3Lbl.ForeColor = Color.Black
    End Sub

    Private Sub ScreenTime2Lbl_Click(sender As Object, e As EventArgs) Handles ScreenTime2Lbl.Click
        ScreenTime1Lbl.ForeColor = Color.Black
        ScreenTime2Lbl.ForeColor = Color.Red
        ScreenTime3Lbl.ForeColor = Color.Black
    End Sub

    Private Sub ScreenTime3Lbl_Click(sender As Object, e As EventArgs) Handles ScreenTime3Lbl.Click
        ScreenTime1Lbl.ForeColor = Color.Black
        ScreenTime2Lbl.ForeColor = Color.Black
        ScreenTime3Lbl.ForeColor = Color.Red
    End Sub
End Class
