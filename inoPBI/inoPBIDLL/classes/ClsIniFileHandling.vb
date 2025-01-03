Imports System.IO
Imports System.Text

Public Class ClsIniFileHandling
    Public Structure IniData
        Public LastOriginal As String
        Public LastReplacement As String
        Public LastFolder As String
        Public LastCustomer As String
        Public LastDocumentation As String
        Public LastFooter As String
        Public LastHeader As String
        Public LastDocTitle As String
        Public LastPDFFile As String
        Public LastTMDLFile As String
        Public LastReplacementOption As Boolean

    End Structure
    Public Function WriteProjectIniFile(FilePath As String, Data As IniData) As Boolean

        Try
            Dim fs As FileStream = File.Create(FilePath)
            fs.Close()
            Dim sw As StreamWriter = File.AppendText(FilePath)

            sw.WriteLine("LastOriginal:" & Data.LastOriginal)
            sw.WriteLine("LastReplacement:" & Data.LastReplacement)
            sw.WriteLine("LastFolder:" & Data.LastFolder)
            sw.WriteLine("LastCustomer:" & Data.LastCustomer)
            sw.WriteLine("LastDocumentation:" & Data.LastDocumentation)
            sw.WriteLine("LastFooter:" & Data.LastFooter)
            sw.WriteLine("LastHeader:" & Data.LastHeader)
            sw.WriteLine("LastDocTitle:" & Data.LastDocTitle)
            sw.WriteLine("LastPDFFile:" & Data.LastPDFFile)
            sw.WriteLine("LastTMDLFile:" & Data.LastTMDLFile)
            sw.WriteLine("LastReplacementOption:" & Data.LastReplacementOption)
            sw.Close()
        Catch ex As Exception
            MsgBox(ex.Message,, "Error Project Ini File")
            Return False
        End Try
        Return True
    End Function

    Public Function GetProjectIniFromFile(Project As String) As IniData
        Dim data As New IniData

        Dim stream As New FileStream(Project, FileMode.Open)
        Dim line As String
        Dim flag As Boolean = True
        Dim reader As StreamReader
        reader = New StreamReader(stream, Encoding.UTF8)


        While (flag = True)
            line = reader.ReadLine()
            If (line = Nothing) Then
                flag = False
            Else
                Dim lSplit As String() = line.Split(":", 2)
                Select Case lSplit(0)
                    Case "LastOriginal"
                        data.LastOriginal = lSplit(1)
                    Case "LastReplacement"
                        data.LastReplacement = lSplit(1)
                    Case "LastFolder"
                        data.LastFolder = lSplit(1)
                    Case "LastCustomer"
                        data.LastCustomer = lSplit(1)
                    Case "LastDocumentation"
                        data.LastDocumentation = lSplit(1)
                    Case "LastFooter"
                        data.LastFooter = lSplit(1)
                    Case "LastHeader"
                        data.LastHeader = lSplit(1)
                    Case "LastDocTitle"
                        data.LastDocTitle = lSplit(1)
                    Case "LastPDFFile"
                        data.LastPDFFile = lSplit(1)
                    Case "LastTMDLFile"
                        data.LastTMDLFile = lSplit(1)
                    Case "LastReplacementOption"
                        data.LastReplacementOption = lSplit(1)
                End Select
            End If
        End While
        reader.Close()
        Return data
    End Function
End Class
