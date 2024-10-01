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
    Function LoadFromJson(Of T)(RelativePath As String) As T 'load from json, of T is the type of object/ if class
        Try
            Dim executablePath As String = AppDomain.CurrentDomain.BaseDirectory
            Dim filePath As String = Path.Combine(executablePath, RelativePath) 'this is used so that the whole file path does not have to be written into the load args
            Dim jsonData As String = File.ReadAllText(filePath)
            Dim data As T = JsonConvert.DeserializeObject(Of T)(jsonData)
            MsgBox($"Data successfully loaded from {filePath}")
            Return data
        Catch ex As FileNotFoundException
            MsgBox($"The file {RelativePath} was not found.")
            Return Nothing
        Catch ex As Exception
            MsgBox($"An error occurred while loading from {RelativePath}: {ex.Message}")
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
    Public Sub QuickSort(Of T)(ByRef list As List(Of T), ByVal indexLow As Integer, ByVal indexHigh As Integer, ByVal keySelector As Func(Of T, Integer))
        ' this function will be used for data sorting for menu forms, the key selector is used to select what object attribute we would like to sort the data with

        Dim swap_space As T
        Dim Low As Integer = indexLow
        Dim High As Integer = indexHigh
        Dim pivot As Integer = keySelector(list(Int((indexLow + indexHigh) / 2)))

        While Low <= High
            While keySelector(list(Low)) < pivot And Low < indexHigh
                Low += 1
            End While

            While keySelector(list(High)) > pivot And High > indexLow
                High -= 1
            End While

            If Low <= High Then

                swap_space = list(Low)
                list(Low) = list(High)
                list(High) = swap_space
                Low += 1
                High -= 1
            End If
        End While

        ' list is split into two then quicksort is called again
        If indexLow < High Then QuickSort(list, indexLow, High, keySelector)
        If Low < indexHigh Then QuickSort(list, Low, indexHigh, keySelector)
    End Sub


    Sub QuickSortScreeningsByDateTime(ByRef screenings As Screening(), ByVal indexLow As Integer, ByVal indexHigh As Integer, ByVal keySelector As Func(Of T, Date))
        Dim i As Integer = indexLow
        Dim j As Integer = indexHigh
        Dim pivot As DateTime = screenings((indexLow + indexHigh) \ 2).datetime


        While i <= j

            While screenings(i).datetime < pivot
                i += 1
            End While


            While screenings(j).datetime > pivot
                j -= 1
            End While

            If i <= j Then
                Dim temp As DateTime = screenings(i).datetime
                screenings(i).datetime = screenings(j).datetime
                screenings(j).datetime = temp
                i += 1
                j -= 1
            End If
        End While

        If indexLow < j Then QuickSortDateTime(screenings, indexLow, j)
        If i < indexHigh Then QuickSortDateTime(screenings, i, indexHigh)
    End Sub
End Module
