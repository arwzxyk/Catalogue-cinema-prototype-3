Public Class FormManager
    'used to switch between openforms
    Public Shared Sub ShowForm(Of T As {Form, New})()
        For Each form As Form In Application.OpenForms
            If TypeOf form Is T Then
                form.BringToFront()
                Return
            End If
        Next

        Dim formInstance As New T()
        formInstance.Show()
    End Sub

End Class