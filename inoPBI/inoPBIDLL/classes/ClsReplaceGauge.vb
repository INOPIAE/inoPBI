Imports System.Collections.ObjectModel
Imports System.IO

Public Class ClsReplaceGauge
    Public width As New ClsReplacementNum
    Public height As New ClsReplacementNum
    Public x As New Collection(Of ClsReplacementNum)
    Public y As New Collection(Of ClsReplacementNum)

    Private strVisual As String = "gauge"



    Public Function ReplaceGauge(strFile As String, strPage As String) As Boolean
        Dim blnReplacePage As Boolean = False
        Dim blnReplaceVisual As Boolean = False
        Dim strOutput As String = vbNullString
        Dim strOutputLinebreak As String = vbNullString
        Dim intI As Int32
        Dim page As String = vbNullString

        Using sr As New StreamReader(strFile)
            While sr.Peek() >= 0
                Dim strLine As String = sr.ReadLine
                intI += 1
                If strLine.Contains("""displayName"":") Then
                    If strLine.Contains(strPage) Then
                        blnReplacePage = True
                    Else
                        blnReplacePage = False
                    End If
                    page = strLine
                End If
                If strLine.Contains("""config"":") And blnReplacePage = True Then
                    Dim search As String = String.Format("\""singleVisual\"":{0}\""visualType\"":\""{1}\""", "{", strVisual)
                    If strLine.Contains(search) Then
                        blnReplaceVisual = True
                        If height.FromV <> height.ToV Then
                            Dim StrReplace As String = "\""height\"":"
                            strLine = ReplaceNumValue(strLine, StrReplace, height)
                        End If
                        If width.FromV <> width.ToV Then
                            Dim StrReplace As String = "\""width\"":"
                            strLine = ReplaceNumValue(strLine, StrReplace, width)
                        End If
                        For Each xt As ClsReplacementNum In x
                            If xt.FromV <> xt.ToV Then
                                Dim StrReplace As String = "\""x\"":"
                                strLine = ReplaceNumValue(strLine, StrReplace, xt)
                            End If
                        Next
                        For Each yt As ClsReplacementNum In y
                            If yt.FromV <> yt.ToV Then
                                Dim StrReplace As String = "\""y\"":"
                                strLine = ReplaceNumValue(strLine, StrReplace, yt)
                            End If
                        Next
                    Else
                        blnReplaceVisual = False
                    End If
                End If

                If strLine.Contains("""height"":") And blnReplaceVisual = True Then
                    Debug.Print(intI & " " & page & " " & strLine)
                    If height.FromV <> height.ToV Then
                        Dim StrReplace As String = """height"": "
                        strLine = ReplaceNumValue(strLine, StrReplace, height)
                    End If
                End If
                If strLine.Contains("""width"":") And blnReplaceVisual = True Then

                    Debug.Print(intI & " " & page & " " & strLine)
                    If width.FromV <> width.ToV And strLine.Substring(0, 8) = "        " Then
                        Dim StrReplace As String = """width"": "
                        strLine = ReplaceNumValue(strLine, StrReplace, width)
                    End If
                End If
                If strLine.Contains("""x"":") And blnReplaceVisual = True Then
                    Debug.Print(intI & " " & page & " " & strLine)
                    For Each xt As ClsReplacementNum In x
                        If xt.FromV <> xt.ToV Then
                            Dim StrReplace As String = """x"": "
                            strLine = ReplaceNumValue(strLine, StrReplace, xt)
                        End If
                    Next
                End If
                If strLine.Contains("""y"":") And blnReplaceVisual = True Then
                    Debug.Print(intI & " " & page & " " & strLine)
                    For Each yt As ClsReplacementNum In y
                        If yt.FromV <> yt.ToV Then
                            Dim StrReplace As String = """y"": "
                            strLine = ReplaceNumValue(strLine, StrReplace, yt)
                        End If
                    Next
                End If

                strOutput &= strOutputLinebreak & strLine
                strOutputLinebreak = vbCrLf
            End While
        End Using
        File.WriteAllText(strFile, strOutput)
        Return True
    End Function

    Public Function ReplaceNumValue(strLine As String, StrReplace As String, Rep As ClsReplacementNum) As String
        Dim cRepInfo As New ClsReplacementInfo(StrReplace, strLine)
        Dim Value As String = cRepInfo.GetValue
        If ValueInRange(Rep.FromV, CDec(Val(Value)), Rep.Range) Then
            strLine = strLine.Replace(String.Format("{0}{1},", StrReplace, Value), String.Format("{0}{1},", StrReplace, Rep.ToV.ToString.Replace(",", ".")))
        End If

        Return strLine
    End Function

    Public Function ValueInRange(Value As Decimal, TestValue As Decimal, Range As Decimal) As Boolean
        If Value - Range <= TestValue And Value + Range >= TestValue Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
