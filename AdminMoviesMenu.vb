Public Class AdminMoviesMenu
    Dim movies As List(Of movie) = LoadFromJson(Of List(Of movie))("Database\movies.json")
    Dim currentIndex As Integer = 0

    Private Sub DisplayCurrentMovie()
        Dim currentMovie As movie = movies(currentIndex)
        If currentMovie IsNot Nothing Then
            mvTitleTxt.Text = currentMovie.Title
            mvDateTxt.Text = "Year: " & (currentMovie.Year)
            mvGenresTxt.Text = "Genres: " & (currentMovie.Genre)
            mvCastTxt.Text = "Director: " & currentMovie.Director & "
Writer: " & currentMovie.Writer & "
Actors: " & currentMovie.Actors
            mvPlotTxt.Text = currentMovie.Plot
            posterPb.ImageLocation = currentMovie.Poster



        Else
            MessageBox.Show("No movie data available.")
        End If
    End Sub
    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        If currentIndex < movies.Count - 1 Then
            currentIndex = currentIndex + 1
        Else
            MsgBox("This is the last movie ")
        End If
        DisplayCurrentMovie()
    End Sub

    Private Sub PrevBtn_Click(sender As Object, e As EventArgs) Handles PrevBtn.Click
        If currentIndex > 0 Then
            currentIndex = currentIndex - 1
        Else
            MsgBox("This is the first movie ")
        End If
        DisplayCurrentMovie()
    End Sub

    Private Sub mvPlotTxt_TextChanged(sender As Object, e As EventArgs) Handles mvPlotTxt.TextChanged

    End Sub
End Class