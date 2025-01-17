﻿Imports Newtonsoft.Json

Public Class AdminScreeningsMenu
    Dim screenings As List(Of Screening) = LoadFromJson(Of List(Of Screening))("Database\Screenings.json")
    Dim movies As List(Of movie) = LoadFromJson(Of List(Of movie))("Database\movies.json")
    Dim screen As Integer
    Dim screeningDatetime As DateTime
    Sub display_screenings()
        Me.Refresh()
        ScreeningDgv.DataSource = screenings
    End Sub

    Private Sub AdminScreeningsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If screenings Is Nothing Then
            screenings = New List(Of Screening)()
        End If
        ' fltrScreeningsClb.SetItemChecked(0, True) 'this automatically sorts the screenings by screeningID
        For Each movie In movies
            crtScrnMovieTxt.Items.Add(movie.Title)
        Next
    End Sub

    Private Sub fltrScreeningsClb_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles fltrScreeningsClb.ItemCheck
        'this sub is used in the case a sort order is applied to the data grid
        ' we temporarily remove the event handler to prevent any unwanted recursion
        RemoveHandler fltrScreeningsClb.ItemCheck, AddressOf fltrScreeningsClb_ItemCheck

        If e.NewValue = CheckState.Checked Then

            For i As Integer = 0 To fltrScreeningsClb.Items.Count - 1
                If i <> e.Index Then
                    fltrScreeningsClb.SetItemChecked(i, False)
                End If
            Next
            Select Case e.Index
                Case 0
                    QuickSort(Of Screening)(screenings, 0, screenings.Count - 1, Function(s) s.screeningID)
                Case 1
                    QuickSort(Of Screening)(screenings, 0, screenings.Count - 1, Function(s) s.movieID)
                    MsgBox(JsonConvert.SerializeObject(screenings, Formatting.Indented))
                Case 2
                    QuickSort(Of Screening)(screenings, 0, screenings.Count - 1, Function(s) s.Screen)
                    MsgBox(JsonConvert.SerializeObject(screenings, Formatting.Indented))
                Case 3
                    QuickSort(Of Screening)(screenings, 0, screenings.Count - 1, Function(s) s.datetime)
            End Select

            display_screenings()
        End If


        AddHandler fltrScreeningsClb.ItemCheck, AddressOf fltrScreeningsClb_ItemCheck
    End Sub


    Private Sub addScreeningBtn_Click(sender As Object, e As EventArgs) Handles addScreeningBtn.Click


        Dim movieId As Integer = -1

        For i = 0 To movies.Count - 1
            If movies(i).Title = crtScrnMovieTxt.Text Then
                movieId = i
            End If
        Next
        If movieId = -1 Then
            MsgBox("Movie not Found")
        End If
        Dim seatings As List(Of Seating) = LoadFromJson(Of List(Of Seating))("Database\Seatings.json")
        If seatings Is Nothing Then
            seatings = New List(Of Seating)()
        End If
        If screenings Is Nothing Then
            screenings = New List(Of Screening)()
        End If


        screeningDatetime = scrnDateTime.Value
        For i = 0 To screenNoClb.Items.Count - 1
            If screenNoClb.GetItemCheckState(i) = CheckState.Checked Then
                MsgBox(i & " Is checked")
                Select Case i
                    Case 0

                        screen = 1
                        screeningDatetime = New DateTime(screeningDatetime.Year, screeningDatetime.Month, screeningDatetime.Day, 12, 10, 0)
                    Case 1
                        screen = 2
                        screeningDatetime = New DateTime(screeningDatetime.Year, screeningDatetime.Month, screeningDatetime.Day, 14, 40, 0)
                    'screening datetime is already intialised, we are essentially taking the date and adding the time we want on the end 
                    Case 2
                        screen = 3
                        screeningDatetime = New DateTime(screeningDatetime.Year, screeningDatetime.Month, screeningDatetime.Day, 16, 30, 0)
                End Select
                Dim seatingID As Integer = seatings.Count
                Dim screeningID As Integer = screenings.Count

                Dim seatingNew As New Seating(seatingID)

                AddToList(Of Seating)(seatings, seatingNew)
                AddToList(Of Screening)(screenings, (New Screening(screeningID, movieId, screen, screeningDatetime, seatingNew.SeatingID)))
            End If
        Next

        fltrScreeningsClb.SetItemChecked(0, True)
        QuickSort(Of Seating)(seatings, 0, seatings.Count - 1, Function(s) s.SeatingID) 'this is done to initiate a quicksort before save to json
        SaveToJson(screenings, "Database\Screenings.json")
        SaveToJson(seatings, "Database\Seatings.json")
        MsgBox("Screening added")

    End Sub

    Private Sub dltScreeningBtn_Click(sender As Object, e As EventArgs) Handles dltScreeningBtn.Click
        Dim index As Integer = CInt(dltScreeningTxt.Text)
        If index >= 0 And index < screenings.Count Then
            screenings(index) = Nothing
            fltrScreeningsClb.SetItemChecked(0, True)
            SaveToJson(screenings, "Database\Screenings.json")
            MsgBox("Screening removed")
        Else
            MsgBox("Screening does not exist")
        End If

    End Sub
End Class