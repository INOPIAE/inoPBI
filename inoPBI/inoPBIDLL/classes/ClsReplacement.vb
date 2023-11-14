Imports System.Collections.ObjectModel
Imports System.IO

Public Class ClsReplacement

    Public Structure Replacement
        Dim Title As String
        Dim StrFrom As String
        Dim StrTo As String
    End Structure

    Public Function ReplaceReferences(strFile As String, strReplacement As String, strFileOut As String) As Boolean
        Dim cr As Collection(Of ClsReplacement.Replacement) = GetReplacements(strReplacement)
        Dim blnReplace As Boolean = False
        Dim blnEnd As Boolean = False
        Dim strOutput As String = ""
        Dim crCount As Integer = 0

        Using sr As New StreamReader(strFile)
            While sr.Peek() >= 0
                Dim strLine As String = sr.ReadLine

                If strLine.Contains(cr.Item(crCount).Title) Then
                    blnReplace = True
                End If

                If blnReplace = True Then
                    If strLine.Contains(cr.Item(crCount).StrFrom) Then
                        strLine = strLine.Replace(cr.Item(crCount).StrFrom, cr.Item(crCount).StrTo)
                        crCount += 1
                        blnReplace = False
                        If crCount = cr.Count Then
                            crCount = cr.Count - 1
                            blnEnd = True
                        End If
                    End If
                End If
                strOutput &= strLine & vbCrLf
            End While
        End Using

        If crCount <= cr.Count - 1 And blnEnd = False Then
            Return False
        End If

        Using sw As New StreamWriter(strFileOut, False, System.Text.Encoding.Default)
            sw.Write(strOutput)
        End Using


        Return True
    End Function

    Public Function GetReplacements(strFile As String) As Collection(Of Replacement)
        Dim rc As New Collection(Of Replacement)

        Using sr As New StreamReader(strFile)
            While sr.Peek() >= 0
                Dim strData() As String = sr.ReadLine.Split(";")
                Dim r As Replacement
                r.Title = strData(0).Trim
                r.StrFrom = strData(1).Trim
                r.StrTo = strData(2).Trim
                rc.Add(r)
            End While
        End Using

        Return rc
    End Function
End Class
