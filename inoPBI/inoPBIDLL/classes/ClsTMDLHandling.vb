Imports System.Diagnostics.Metrics
Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports System.Reflection.Metadata
Imports System.Text
Imports inoPBIDLL.ClsJSONHandling

Public Class ClsTMDLHandling

    Public Structure Element
        Public Name As String
        Public Value As String
        Public Displayfolder As String
        Public Description
        Public Type As ElementType
        Public TableName As String
    End Structure

    Public Enum ElementType
        NotDefined
        Measure
        PowerQuery
        Column
    End Enum

    Public ReadOnly FolderPathDataset As String
    Public ReadOnly ExpressionFile As String
    Public ReadOnly FolderPathTables As String


    Public Elements As New List(Of Element)

    Public Sub New(FolderPath As String)
        FolderPathDataset = FolderPath
        ExpressionFile = Path.Combine(FolderPath, "definition", "expressions.tmdl")
        FolderPathTables = Path.Combine(FolderPath, "definition", "tables")
    End Sub

    Public Sub ReadTables()
        Elements.Clear()
        For Each f As String In Directory.GetFiles(FolderPathTables)
            If f.Contains("\LocalDateTable") Then Continue For
            If f.Contains("\DateTableTemplate") Then Continue For
            ReadTable(f)
        Next
    End Sub

    Public Sub ReadTable(f As String)

        Dim reader As New StreamReader(f, Encoding.UTF8)
        Dim table As String = Path.GetFileNameWithoutExtension(f)
        Dim description As String = vbNullString
        Dim myElement As New Element
        Dim blnNew As Boolean = False
        Dim blnSource As Boolean = False
        Dim delimiter As String = vbNullString

        Do Until reader.Peek = -1
            Dim lineplain As String = reader.ReadLine
            Dim line As String = lineplain.Trim

            If line.Length > 0 Then
                If line.StartsWith("///") Then
                    description &= line.Substring(4)
                    Continue Do
                End If
                Dim start() As String = line.Split(" ")
                Select Case start(0)
                    Case "measure"
                        Dim m() As String = line.Substring(7).Split("=")
                        If blnNew = True Then
                            Elements.Add(myElement)
                        End If
                        myElement = New Element
                        myElement.TableName = table
                        myElement.Description = description
                        myElement.Name = m(0).Trim.Replace("'", vbNullString)
                        myElement.Value = m(1).Trim
                        myElement.Type = ElementType.Measure
                        description = vbNullString
                        blnNew = True
                        If m(1).Trim = "```" Then
                            blnSource = True
                            delimiter = vbCrLf
                        End If
                    Case "displayFolder:"
                        myElement.Displayfolder = line.Substring(14).Trim
                        If blnNew = True Then
                            Elements.Add(myElement)
                            blnNew = False
                            blnSource = False
                            delimiter = vbNullString
                        End If
                    Case "annotation", "lineageTag:"
                        If blnNew = True Then
                            Elements.Add(myElement)
                            blnNew = False
                            blnSource = False
                            delimiter = vbNullString
                        End If
                    Case "partition"
                        If blnNew = True Then
                            Elements.Add(myElement)
                        End If
                        myElement = New Element
                        myElement.TableName = table
                        myElement.Description = description
                        myElement.Name = table
                        myElement.Type = ElementType.PowerQuery
                        description = vbNullString
                        blnNew = True
                    Case "source"
                        blnSource = True
                    Case "column"
                        If line.Contains("=") Then
                            Dim m() As String = line.Substring(6).Split("=")
                            If blnNew = True Then
                                Elements.Add(myElement)
                            End If
                            myElement = New Element
                            myElement.TableName = table
                            myElement.Description = description
                            myElement.Name = m(0).Trim.Replace("'", vbNullString)
                            myElement.Value = m(1).Trim
                            myElement.Type = ElementType.Column
                            description = vbNullString
                            Elements.Add(myElement)
                            blnNew = False
                        End If
                    Case Else
                        If blnSource = True Then
                            myElement.Value &= delimiter & lineplain.Replace(vbTab, vbNullString)
                            delimiter = vbCrLf
                        End If
                End Select
            End If
        Loop
        If blnNew = True Then
            Elements.Add(myElement)
        End If
    End Sub

    Public Function ExtractMeasures(strFileOut As String) As Boolean
        Elements.Clear()
        ReadTables()

        Dim blnReplace As Boolean = False

        Dim measures As New Dictionary(Of String, String)
        Dim queries As New Dictionary(Of String, String)

        For Each i As Element In Elements

            Select Case i.Type
                Case ElementType.Measure
                    measures.Add("## " & i.Name & IIf(i.Displayfolder = "", "", " (" & i.Displayfolder & ")"), IIf(i.Description = "", "", "_" & i.Description & "_" & vbCrLf) & ReplaceMeasure(i.Value))
                Case ElementType.PowerQuery
                    queries.Add("## " & i.Name, ReplacePQ_MD(i.Value))
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

    Public Function ReplaceMeasure(strText As String) As String
        Dim strReturn As String = strText.Replace("[" & vbCrLf, "").Replace(vbCrLf & "]", "")
        strReturn = strReturn.Replace("  """"," & vbCrLf, "")
        strReturn = strReturn.Replace("\""", "\?")
        strReturn = strReturn.Replace("""", "")
        strReturn = strReturn.Replace("\?", """")
        strReturn = strReturn.Replace(", ", ",")
        strReturn = strReturn.Replace(",", ", ")
        strReturn = strReturn.Replace(", , ", ",")
        strReturn = strReturn.Replace("```", "")

        Dim strLine() As String = strReturn.Split(vbCrLf)
        Dim strReturn1 As String = ""
        Dim strCrlf As String = ""
        For intC As Int16 = 0 To strLine.Count - 1
            If strLine(intC).Trim <> vbNullString Then
                If strLine(intC).Count <= 92 Then
                    strReturn1 &= strCrlf & strLine(intC)
                Else
                    strReturn1 &= strCrlf & splitLine(strLine(intC))
                End If
                strCrlf = vbCrLf
            End If
        Next

        Return "```" & vbCrLf & strReturn1 & vbCrLf & "```"
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

    Public Function ReplacePQ_MD(strText As String) As String
        Dim strReturn As String = strText.Replace("[" & vbCrLf, "```" & vbCrLf).Replace(vbCrLf & "]", vbCrLf & "```")
        strReturn = strReturn.Replace("\""", "\?")
        strReturn = strReturn.Replace("""", "")
        strReturn = strReturn.Replace("\?", """")
        strReturn = strReturn.Replace("\\", "\")
        strReturn = strReturn.Replace(", ", ",")
        strReturn = strReturn.Replace(",", ", ")
        strReturn = strReturn.Replace(", , ", ",")
        strReturn = strReturn.Replace("```", "")

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
