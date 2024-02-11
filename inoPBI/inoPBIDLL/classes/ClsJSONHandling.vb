Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ClsJSONHandling

    Public strTest As String
    Public Structure Element
        Public Name As String
        Public Value As String
        Public Displayfolder As String
        Public Type As ElementType
    End Structure

    Public Elements As New List(Of Element)

    Public Enum ElementType
        NotDefined
        Measure
        PowerQuery
    End Enum

    Public Sub JsonLoop(obj As JObject, intLevel As Int16, Optional strName As String = "", Optional blnMeasure As Boolean = False, Optional strFolder As String = "")
        Dim strKey As String
        Dim strKeySub As String
        Dim blnTestMeasure As Boolean = blnMeasure
        Dim strDisplayfolder As String = strFolder

        For Each token In obj
            'change the display Content of the parent
            strKey = token.Key.ToString()

            If token.Key.ToString() = "name" Then
                strName = token.Value.ToString
                strDisplayfolder = ""
            End If

            If token.Key.ToString() = "displayFolder" Then
                strDisplayfolder = token.Value.ToString
            End If

            If token.Key.ToString() = "measures" Then
                blnTestMeasure = True
            End If

            strTest &= String.Format(intLevel, "00") & " " & strKey & " - " & Left(token.Value.ToString(), 40) & vbCrLf
            'check if the value is of type obj recall the method
            If token.Value.Type.ToString() = "Object" Then
                Dim o As JObject = DirectCast(token.Value, JObject)
                'recall the method
                JsonLoop(o, intLevel + 1, strName, blnTestMeasure, strDisplayfolder)

                'if type is of array
            ElseIf token.Value.Type.ToString() = "Array" Then
                Dim ix As Integer = -1
                'loop though the array
                For Each itm In token.Value
                    'check if value is an Array of objects
                    If itm.Type.ToString() = "Object" Then

                        ix += 1
                        Dim o As JObject = DirectCast(itm, JObject)
                        JsonLoop(o, intLevel + 1, strName, blnTestMeasure, strDisplayfolder)
                        ' objTN.Text = token.Key.ToString() + "[" + ix.ToString + "]"

                    ElseIf itm.Type.ToString() = "Array" Then
                        ix += 1
                        ' Dim dataArray As New TreeNode()
                        For Each _Data In itm
                            strKeySub = token.Key.ToString() + "[" + ix.ToString + "]"
                            strTest &= strKeySub & vbCrLf
                        Next

                    Else
                        strTest &= token.Key.ToString() & " -- " & token.Value.ToString & vbCrLf
                        If token.Key.ToString() = "expression" Then
                            strTest &= "bla" & vbCrLf
                            strTest &= strName & " --- " & token.Value.ToString & vbCrLf
                            If token.Value.ToString.Contains("""let""") Then
                                Dim ElementItem As New Element
                                ElementItem.Name = strName
                                ElementItem.Value = token.Value.ToString
                                ElementItem.Type = ElementType.PowerQuery

                                If ItmInElements(ElementItem) = False Then
                                    Elements.Add(ElementItem)
                                End If
                            End If
                            If blnMeasure = True Then
                                Dim ElementItem As New Element
                                ElementItem.Name = strName
                                ElementItem.Value = token.Value.ToString
                                ElementItem.Displayfolder = strDisplayfolder
                                ElementItem.Type = ElementType.Measure

                                If ItmInElements(ElementItem) = False Then
                                    Elements.Add(ElementItem)
                                End If
                            End If
                        End If


                    End If
                Next
            Else
                'if token.Value is not nested
                strTest &= "blubb" & vbCrLf
                strTest &= token.Key.ToString() & " -- " & token.Value.ToString & vbCrLf
                If token.Key.ToString() = "expression" Then
                    If blnMeasure = True Then
                        Dim ElementItem As New Element
                        ElementItem.Name = strName
                        ElementItem.Value = token.Value.ToString
                        ElementItem.Displayfolder = strDisplayfolder
                        ElementItem.Type = ElementType.Measure

                        If ItmInElements(ElementItem) = False Then
                            Elements.Add(ElementItem)
                        End If
                    End If
                End If
            End If

        Next
        blnTestMeasure = False

    End Sub


    Private Function ItmInElements(itm As Element) As Boolean
        For Each i As Element In Elements
            If i.Equals(itm) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function ExtractMeasures(strFile As String, strFileOut As String) As Boolean
        Dim json As String = File.ReadAllText(strFile)

        Dim data As JObject = DirectCast(JsonConvert.DeserializeObject(json), JObject)

        Elements.Clear()
        JsonLoop(data, 0)

        Dim blnReplace As Boolean = False




        Dim measures As New Dictionary(Of String, String)
        Dim queries As New Dictionary(Of String, String)

        For Each i As Element In Elements
            Select Case i.Name
                Case "_Measures"
                    'Skip
                Case Else
                    Select Case i.Type
                        Case ElementType.Measure
                            measures.Add("## " & i.Name & IIf(i.Displayfolder = "", "", " (" & i.Displayfolder & ")"), ReplaceMeasure(i.Value))
                        Case ElementType.PowerQuery

                            queries.Add("## " & i.Name, ReplacePQ_MD(i.Value))
                    End Select
            End Select
        Next

        Dim strOutput As String = "Stand: " & Format(Now, "dd.MM.yyyy") & vbCrLf & vbCrLf
        strOutput &= "Inhaltsverzeichnis" & vbCrLf & vbCrLf
        strOutput &= "<!--TOC-->" & vbCrLf & vbCrLf
        strOutput &= "# Measures" & vbCrLf & vbCrLf

        Dim sorted = From pair In measures Order By pair.Key
        Dim sortedDictionary = sorted.ToDictionary(Function(p) p.Key, Function(p) p.Value)

        Dim lngRows As Long = 4
        Dim lngLines As Long
        For Each pair In sortedDictionary
            lngLines = pair.Value.Length - pair.Value.Replace(Environment.NewLine, String.Empty).Length
            lngRows += 4 + lngLines
            If lngRows > 50 Then
                strOutput &= "<div style = ""page-break-after: always""></div>" & vbCrLf & vbCrLf
                lngRows = 4 + lngLines
            End If
            strOutput &= pair.Key & ":  " & vbCrLf & pair.Value & vbCrLf & vbCrLf
        Next

        sorted = From pair In queries Order By pair.Key
        sortedDictionary = sorted.ToDictionary(Function(p) p.Key, Function(p) p.Value)

        strOutput &= vbCrLf & vbCrLf & "# Tabellen über PowerQuery" & vbCrLf & vbCrLf
        lngRows = 4
        Dim blnPage2 As Boolean = False
        For Each pair In sortedDictionary
            lngLines = pair.Value.Length - pair.Value.Replace(Environment.NewLine, String.Empty).Length
            lngRows += 4 + lngLines
            If lngRows > 60 And blnPage2 = True Then
                strOutput &= "<div style = ""page-break-after: always""></div>" & vbCrLf & vbCrLf
                lngRows = 4 + lngLines
            End If
            strOutput &= pair.Key & ":  " & vbCrLf & "   " & pair.Value & vbCrLf & vbCrLf
            blnPage2 = True
        Next

        Using sw As New StreamWriter(strFileOut, False, System.Text.Encoding.UTF8)
            sw.Write(strOutput)
        End Using

        Return True

    End Function

    Public Function ReplacePQ_MD(strText As String) As String
        Dim strReturn As String = strText.Replace("[" & vbCrLf, "```" & vbCrLf).Replace(vbCrLf & "]", vbCrLf & "```")
        strReturn = strReturn.Replace("\""", "\?")
        strReturn = strReturn.Replace("""", "")
        strReturn = strReturn.Replace("\?", """")
        strReturn = strReturn.Replace(", ", ",")
        strReturn = strReturn.Replace(",", ", ")
        strReturn = strReturn.Replace(", , ", ",")

        Dim strLine() As String = strReturn.Split(vbCrLf)
        Dim strReturn1 As String = ""
        Dim strCrlf As String = ""
        For intC As Int16 = 0 To strLine.Count - 1
            If strLine(intC).Count <= 92 Then
                strReturn1 &= strCrlf & strLine(intC)
            Else
                strReturn1 &= strCrlf & splitLine(strLine(intC))
            End If
            strCrlf = vbCrLf
        Next

        Return strReturn1
    End Function

    Public Function splitLine(strLine As String) As String
        Dim CountWhiteSpaces As Int16
        Dim PosWhitespace As Int16
        Dim strReturn As String = ""
        Dim strCrLf As String = ""

        Dim match = System.Text.RegularExpressions.Regex.Match(strLine, "\S")
        If match.Success Then
            CountWhiteSpaces = match.Index '6
        End If

        Do While strLine.Count > 92
            PosWhitespace = strLine.LastIndexOf(" ", 92)
            strReturn &= strCrLf & strLine.Substring(0, PosWhitespace)
            strLine = StrDup(CountWhiteSpaces + 3, " ") & strLine.Substring(PosWhitespace).Trim
            strCrLf = vbCrLf
        Loop

        strReturn &= strCrLf & strLine

        Return strReturn
    End Function

    Public Function ReplaceMeasure(strText As String) As String
        Dim strReturn As String = strText.Replace("[" & vbCrLf, "").Replace(vbCrLf & "]", "")
        strReturn = strReturn.Replace("  """"," & vbCrLf, "")
        strReturn = strReturn.Replace("\""", "\?")
        strReturn = strReturn.Replace("""", "")
        strReturn = strReturn.Replace("\?", """")
        strReturn = strReturn.Replace(", ", ",")
        strReturn = strReturn.Replace(",", ", ")
        strReturn = strReturn.Replace(", , ", ",")

        Dim strLine() As String = strReturn.Split(vbCrLf)
        Dim strReturn1 As String = ""
        Dim strCrlf As String = ""
        For intC As Int16 = 0 To strLine.Count - 1
            If strLine(intC).Count <= 92 Then
                strReturn1 &= strCrlf & strLine(intC)
            Else
                strReturn1 &= strCrlf & splitLine(strLine(intC))
            End If
            strCrlf = vbCrLf
        Next

        Return "```" & vbCrLf & strReturn1 & vbCrLf & "```"
    End Function
End Class
