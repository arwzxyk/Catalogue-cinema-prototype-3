Imports System.IO
Imports Newtonsoft.Json
Imports System.Security.Cryptography
Imports Microsoft.VisualBasic.ApplicationServices
Module Main_Functions
    Sub SaveToJson(data As Object, filePath As String) 'saves data objects into json, the file path changes for different tables
        Try
            Dim jsonData As String = JsonConvert.SerializeObject(data, Formatting.Indented)
            MsgBox(jsonData)
            File.WriteAllText(filePath, jsonData)
            MsgBox($"Data successfully saved to {filePath}")
        Catch ex As Exception
            MsgBox($"An error occurred while saving to {filePath}: {ex.Message}")
        End Try
    End Sub
    Function LoadFromJson(Of T)(filePath As String) As T 'load from json, of T is the type of object/ if class
        Try
            Dim jsonData As String = File.ReadAllText(filePath)
            Dim data As T = JsonConvert.DeserializeObject(Of T)(jsonData)
            MsgBox($"Data successfully loaded from {filePath}")
            Return data
        Catch ex As FileNotFoundException
            MsgBox($"The file {filePath} was not found.")
            Return Nothing
        Catch ex As Exception
            MsgBox($"An error occurred while loading from {filePath}: {ex.Message}")
            Return Nothing
        End Try
    End Function
    Public Function Sha256Hash(Password) 'password hashing
        Dim hash = New System.Security.Cryptography.SHA256Managed().ComputeHash(System.Text.Encoding.UTF8.GetBytes(Password))
        Return hash
    End Function

    Sub ShowForm(Of T As {Form, New})() 'this is used to show previously hidden forms, useful to go back
        For Each form As Form In Application.OpenForms
            If TypeOf form Is T Then
                form.BringToFront()
                Return
            End If
        Next

        Dim formInstance As New T()
        formInstance.Show()
    End Sub
End Module
