Public Class ReccomendationsStart

    Private Sub ReccomendationsStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ("Welcome " & SharedData.CurrentUser.username & "
please set your preferences for each genre.")

    End Sub

    Private Sub SubmitPreferences_Click(sender As Object, e As EventArgs) Handles SubmitPrefBtn.Click
        Dim ActionPref As Double = ActionTrkBar.Value
        Dim DramaPref As Double = DramaTrkBar.Value
        Dim ComedyPref As Double = ComedyTrkBar.Value
        Dim RomancePref As Double = RomanceTrkBar.Value
        Dim HorrorPref As Double = HorrorTrkBar.Value
        Dim ThrillerPref As Double = ThrillerTrkBar.Value
        Form1.Show()
        Me.Close()
    End Sub
End Class