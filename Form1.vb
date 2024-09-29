Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Public Class Form1
    Dim movies As List(Of movie) = LoadFromJson(Of List(Of movie))("C:\Users\wenes\GitHub\Catalogue-cinema-prototype-3\movies.json")
    Dim selectMovieID As Integer = -1 'set to indicate no movie is selected

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SharedData.loggedIn = True Then
            'Login/reg page

            UserLabel.Text = "Welcome "
            LgnBtn.Hide()
            RegBtn.Hide()
        ElseIf SharedData.loggedIn = False Then
            UserLabel.Text = "It seems you are not logged in, Press Login if you have an account 
or press Register, to register with us today"
            TabPage4.Refresh()
        End If
        'Movies page
        Dim panelIndex As Integer = 1
        For Each panel In Panel1.Controls
            If TypeOf panel Is Panel And (panel.controls.count = 0) Then
                Dim MovieLabel As New Label
                MovieLabel.AutoSize = True
                MovieLabel.Font = New Font("Times New Roman", 12)
                MovieLabel.Text = movies(panelIndex - 1).Title
                MovieLabel.Location = New Point(58, 111)
                MovieLabel.Tag = panelIndex
                'adding click event, using a tag to store the tab index to pass onto screening form
                AddHandler MovieLabel.Click, AddressOf Movielabel_Click
                Dim MovieImage As New PictureBox
                MovieImage.ImageLocation = movies(panelIndex - 1).Poster
                MovieImage.SizeMode = PictureBoxSizeMode.StretchImage
                MovieImage.Size = New Size(250, 100)
                MovieImage.Tag = TabIndex
                AddHandler MovieImage.Click, AddressOf Movieimage_Click
                'adding label and image to the panel
                panel.Controls.Add(MovieLabel)
                panel.controls.add(MovieImage)

                panelIndex = panelIndex + 1
            End If
        Next

        'Bookings page
        If selectMovieID = -1 Then

        End If

    End Sub
    Private Sub Movielabel_Click(sender As Object, e As EventArgs)
        selectMovieID = CInt(sender.Tag) - 1


    End Sub
    Private Sub Movieimage_Click(sender As Object, e As EventArgs)

        selectMovieID = CInt(sender.tag) - 1

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
