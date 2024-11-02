﻿Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Public Class Form1
    Dim movies As List(Of movie) = LoadFromJson(Of List(Of movie))("Database\movies.json")
    Dim selectMovieID As Integer = -1 'set to indicate no movie is selected

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub
    Public Sub LoadForm()
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
                'adding click event, using a tag to store the index to pass onto booking form
                AddHandler MovieLabel.Click, AddressOf Movie_Click
                Dim MovieImage As New PictureBox
                MovieImage.ImageLocation = movies(panelIndex - 1).Poster
                MovieImage.SizeMode = PictureBoxSizeMode.StretchImage
                MovieImage.Size = New Size(250, 100)
                MovieImage.Tag = panelIndex
                AddHandler MovieImage.Click, AddressOf Movie_Click
                'adding label and image to the panel
                panel.Controls.Add(MovieLabel)
                panel.controls.add(MovieImage)

                panelIndex = panelIndex + 1
            End If
        Next

        'Bookings page
        For Each movie In movies
            slctMovieCB.Items.Add(movie.Title)

            'For screenings search page
            mvscreenTxt.Items.Add(movie.Title)
        Next
        slctMovieCB.Text = "Select a movie"
        slctScreeningCB.Enabled = False
        slctScreeningCB.Text = "Please select a movie first"


    End Sub

    Private Sub Movie_selected()
        Dim screenings As List(Of Screening) = LoadFromJson(Of List(Of Screening))("Database\Screenings.json")
        While selectMovieID <> -1
            slctMovieCB.Text = movies(selectMovieID).Title
            slctScreeningCB.Enabled = True
            slctScreeningCB.Text = "Select a screening"
            For i = 0 To screenings.Count - 1
                If screenings(i).movieID = selectMovieID Then
                    slctScreeningCB.Items.Add(screenings(i).datetime)
                End If
            Next

        End While
    End Sub
    Private Sub Movie_Click(sender As Object, e As EventArgs)
        selectMovieID = CInt(sender.Tag) - 1
        TabControl1.SelectedIndex = 2
        MsgBox(movies(selectMovieID).Title & " Selected")
        Movie_selected()

    End Sub
    Private Sub scrnsearchBtn_Click(sender As Object, e As EventArgs) Handles scrnsearchBtn.Click
        Dim screenings As List(Of Screening) = LoadFromJson(Of List(Of Screening))("Database\Screenings")
        Dim selectmovieScreenings As New List(Of Screening)
        For i = 0 To movies.Count - 1
            If movies(i).Title = mvscreenTxt.Text Then
                selectMovieID = i
            End If
        Next
        For i = 0 To screenings.Count - 1
            If screenings(i).movieID = selectMovieID Then
                selectmovieScreenings.Add(screenings(i))

            End If
        Next
        If selectmovieScreenings Is Nothing Then
            MsgBox("No screenings found")
        Else
            QuickSort(Of Screening)(selectmovieScreenings, 0, selectmovieScreenings.Count - 1, Function(s) s.datetime)
            'sort by date time so the buttons are in this order
            For i = 0 To selectmovieScreenings.Count - 1
                Dim screeningBtn As New Button
                screeningBtn.Font = New Font("Times New Roman", 12)
                screeningBtn.Text = "Date: " & selectmovieScreenings(i).datetime & "
Screen No: " & selectmovieScreenings(i).Screen
                screeningBtn.Tag = selectmovieScreenings(i).screeningID
                screeningBtn.Size = New Size(80, 30)
                screeningBtn.TextAlign = ContentAlignment.MiddleCenter

                AddHandler screeningBtn.Click, AddressOf scrnBtn_click
                ScreeningsFLPanel.Controls.Add(screeningBtn)
            Next
        End If

    End Sub

    Private Sub scrnBtn_click(sender As Object, e As EventArgs)
        Dim screenings As List(Of Screening) = LoadFromJson(Of List(Of Screening))("Database\Screenings")
        Dim selectscreening As Screening = screenings(CInt(sender.tag))
        'passes all attributes of selected screening
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
        Dim newseatBooking As New SeatBooking(CInt(slctScreeningCB.Text))
        bookSeatsPanel.Controls.Clear()
        newseatBooking.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        newseatBooking.Dock = DockStyle.Fill
        bookSeatsPanel.Controls.Add(newseatBooking)
        newseatBooking.Show()
    End Sub



End Class
