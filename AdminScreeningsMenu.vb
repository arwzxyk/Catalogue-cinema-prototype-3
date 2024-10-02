Public Class AdminScreeningsMenu
    Dim screenings As List(Of Screening) = LoadFromJson(Of List(Of Screening))("Database\Screenings.json")
    Dim movies As List(Of movie) = LoadFromJson(Of List(Of movie))("Database\movies.json")
    Dim screen As Integer
    Dim screeningDatetime As DateTime = scrnDateTime.Value
    Sub display_screenings()
        ScreeningDgv.DataSource = screenings
    End Sub

    Private Sub AdminScreeningsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fltrScreeningsClb.SetItemChecked(0, True) 'this automatically sorts the screenings by screeningID
        For Each movie In movies
            crtScrnMovieTxt.Items.Add(movie)
        Next
    End Sub

    Private Sub fltrScreeningsClb_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles fltrScreeningsClb.ItemCheck
        ' here we temporarily remove the event handler to prevent any unwanted recursion
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
                Case 2
                    QuickSort(Of Screening)(screenings, 0, screenings.Count - 1, Function(s) s.Screen)
                Case 3
                    QuickSort(Of Screening)(screenings, 0, screenings.Count - 1, Function(s) s.datetime)
            End Select
            display_screenings()
        End If


        AddHandler fltrScreeningsClb.ItemCheck, AddressOf fltrScreeningsClb_ItemCheck
    End Sub
    Private Sub screenNoClb_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles screenNoClb.ItemCheck
        ' here we temporarily remove the event handler to prevent any unwanted recursion
        RemoveHandler screenNoClb.ItemCheck, AddressOf fltrScreeningsClb_ItemCheck
        If e.NewValue = CheckState.Checked Then
                For i As Integer = 0 To screenNoClb.Items.Count - 1
                    If i <> e.Index Then
                        screenNoClb.SetItemChecked(i, False)
                    End If
                Next
            'unchecks every other box as we should only be able to sort by one 
            Select Case e.Index
                    Case 0

                    screen = 1
                    screeningDatetime = New DateTime(screeningDatetime.Year, screeningDatetime.Month, screeningDatetime.Day, 12, 10, 0)
                Case 1
                    screen = 2
                    screeningDatetime = New DateTime(screeningDatetime.Year, screeningDatetime.Month, screeningDatetime.Day, 14, 40, 0)
                    'screening datetime is already intialised, we are essentially taking the date and adding the time we want on the end
                Case 2
                    screen = 1
                    screeningDatetime = New DateTime(screeningDatetime.Year, screeningDatetime.Month, screeningDatetime.Day, 14, 30, 0)
            End Select
        End If
    End Sub

    Private Sub scrnDateTime_ValueChanged(sender As Object, e As EventArgs) Handles scrnDateTime.ValueChanged
        screeningDatetime = scrnDateTime.Value
    End Sub

    Private Sub addScreeningBtn_Click(sender As Object, e As EventArgs) Handles addScreeningBtn.Click
        If screenings Is Nothing Then
            screenings = New List(Of Screening)()
        End If
        Dim movieId As Integer = -1

        For i = 0 To movies.Count - 1
            If String.Compare(movies(i).Title, crtScrnMovieTxt.Text, True) = 0 Then
                movieId = i
            End If
        Next
        If movieId = -1 Then
            MsgBox("Movie not Found")
        End If
        screenings.Add(New Screening(screenings.Count - 1, movieId, screen, screeningDatetime))
        fltrScreeningsClb.SetItemChecked(0, True) 'this is done to initiate a quicksort before save to json
        SaveToJson(screenings, "Database\Screenings")
        MsgBox("Screening added")

    End Sub

    Private Sub dltScreeningBtn_Click(sender As Object, e As EventArgs) Handles dltScreeningBtn.Click
        Dim index As Integer = CInt(dltScreeningTxt.Text)
        If index >= 0 And index <= screenings.Count Then
            screenings.Remove(screenings(index))
            fltrScreeningsClb.SetItemChecked(0, True)
            SaveToJson(screenings, "Database\Screenings")
            MsgBox("Screening removed")
        Else
            MsgBox("Screening does not exist")
        End If

    End Sub
End Class