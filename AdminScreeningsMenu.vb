Public Class AdminScreeningsMenu
    Dim screenings As List(Of Screening) = LoadFromJson(Of List(Of Screening))("Database\Screenings.json")

    Sub display_screenings()
        ScreeningDgv.DataSource = screenings
    End Sub

    Private Sub AdminScreeningsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fltrScreeningsClb.SetItemChecked(0, True) 'this automatically sorts the screenings by screeningID
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
        End If


        AddHandler fltrScreeningsClb.ItemCheck, AddressOf fltrScreeningsClb_ItemCheck
    End Sub
End Class