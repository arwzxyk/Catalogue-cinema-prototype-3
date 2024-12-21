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
    Public Function lengthCheck(Checkstring As String, toLength As Integer)
        Dim valid As Boolean = False
        If Checkstring.Length >= toLength Then
            valid = True
        End If
        Return valid
    End Function
    Public Sub AddToList(Of T)(ByRef list As List(Of T), ByRef obj As Object)
        'byref to edit og list
        Dim index As Integer = list.Count
        Dim count As Integer = 0
        'set index to list count so if no empty index found it defaults to the end
        'find empty indexes first
        While count < list.Count AndAlso index = list.Count
            If list(count) Is Nothing Then
                index = count
            Else
                count += 1
            End If
        End While

        'in future add try statements for exceptions

        Dim objType As Type = obj.GetType
        Dim objIDprop = objType.GetProperties().FirstOrDefault
        'retrieves the first property of the class, this is always the ID
        objIDprop.SetValue(obj, index)

        'add to list
        If index = list.Count Then
            list.Add(obj)
        Else
            list(index) = obj
        End If
    End Sub

    Public Sub QuickSort(Of T)(ByRef list As List(Of T), ByVal indexLow As Integer, ByVal indexHigh As Integer, ByVal keySelector As Func(Of T, IComparable))
        ' this function will be used for data sorting for menu forms, the key selector is used to select what object attribute we would like to sort the data with

        Dim swapspace As T
        Dim i As Integer = indexLow
        Dim j As Integer = indexHigh
        Dim pivot As IComparable = keySelector(list((indexLow + indexHigh) \ 2))
        'IComparable is used in the case that the function needs to handle data types for a key other than integers e.g datetime

        While i <= j

            While keySelector(list(i)).CompareTo(pivot) < 0
                i += 1
            End While
            While keySelector(list(j)).CompareTo(pivot) > 0
                j -= 1
            End While

            If i <= j Then
                swapspace = list(i)
                list(i) = list(j)
                list(j) = swapspace
                i += 1
                j -= 1
            End If
        End While

        ' Recursive phase
        If indexLow < j Then QuickSort(list, indexLow, j, keySelector)
        If i < indexHigh Then QuickSort(list, i, indexHigh, keySelector)
    End Sub
End Module


