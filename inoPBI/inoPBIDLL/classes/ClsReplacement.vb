Imports System.Collections.ObjectModel
Imports System.IO
Imports System.IO.Compression
Imports System.Reflection.Metadata

Public Class ClsReplacement

    Public Structure Replacement
        Dim Title As String
        Dim StrFrom As String
        Dim StrTo As String
    End Structure

    Public ReplacementError As String = "{0} replacement(s) could not be resolved"

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
        Dim intError As Int16 = 0
        Using sr As New StreamReader(strFile)
            While sr.Peek() >= 0
                Dim strData() As String = sr.ReadLine.Split(";")
                If strData.Length = 3 Then
                    Dim r As Replacement
                    r.Title = strData(0).Trim
                    r.StrFrom = strData(1).Trim
                    r.StrTo = strData(2).Trim
                    rc.Add(r)
                Else
                    intError += 1
                End If
            End While
        End Using
        If intError > 0 Then
            Throw New Exception(String.Format(ReplacementError, intError))
        End If
        Return rc
    End Function

    Public Function ExtractMeasures(strFile As String, strFileOut As String) As Boolean
        Dim blnReplace As Boolean = False
        Dim strOutput As String = "# Measures" & vbCrLf & vbCrLf
        strOutput &= "Stand: " & Format(Now, "dd.MM.yyyy") & vbCrLf & vbCrLf
        Dim measures As New Dictionary(Of String, String)
        Dim m As String = ""
        Dim f As String = ""
        Dim fo As String = ""
        Dim intLine As Int16 = 0

        Using sr As New StreamReader(strFile)
            While sr.Peek() >= 0
                intLine += 1
                Dim strLine As String = sr.ReadLine

                If strLine.Contains("""measures"": [") Then
                    blnReplace = True
                End If
                If strLine.Contains("""partitions"": [") Then
                    blnReplace = False
                End If

                If blnReplace = True Then
                    If strLine.Contains("name") Then
                        fo = ""
                        m = GetContent(strLine, "name")
                        strLine = sr.ReadLine
                        If strLine.Contains("displayFolder") Then
                            fo = " (" & GetContent(strLine, "displayFolder").Trim & ")"
                            strLine = sr.ReadLine
                        End If
                        If strLine.Contains("annotations") Then
                            Do Until strLine.Contains("]")
                                strLine = sr.ReadLine
                            Loop
                            strLine = sr.ReadLine
                        End If
                        f = GetContent(strLine, "expression")
                        If f = " [" Then
                            strLine = sr.ReadLine
                            f = GetContent(strLine, "expression")
                        End If
                        f = f.Replace("'", """")
                        f = f.Replace(",", ", ")
                        measures.Add(m & fo, f)
                    End If
                End If
            End While
        End Using

        Dim sorted = From pair In measures
                     Order By pair.Key
        Dim sortedDictionary = sorted.ToDictionary(Function(p) p.Key, Function(p) p.Value)

        For Each pair In sortedDictionary
            strOutput &= pair.Key & ":  " & vbCrLf & "   " & pair.Value & vbCrLf & vbCrLf
        Next
        Using sw As New StreamWriter(strFileOut, False, System.Text.Encoding.Default)
            sw.Write(strOutput)
        End Using

        Return True
    End Function

    Private Shared Function GetContent(strLine As String, strTopic As String) As String
        Return strLine.Trim.Replace(""",", "").Replace("\", "'").Replace("""", "").Replace(":", "").Replace(strTopic, "")
    End Function

    Public Function CopyPBIP(strFile As String, strFileOut As String) As Boolean
        Dim strSourceFolder As String = Directory.GetParent(Directory.GetParent(strFile).FullName).FullName
        Dim strSourceParent As String = Directory.GetParent(Directory.GetParent(strFile).FullName).Name

        Dim strDestinationFolder As String = Path.Combine(Directory.GetParent(strFileOut).FullName, strSourceParent)
        Dim strCopyFolder As String = Directory.GetParent(strFile).Name

        Directory.Delete(strDestinationFolder, True)

        CopyDirectory(strSourceFolder, strDestinationFolder, True)

        IO.File.Copy(strFileOut, Path.Combine(strDestinationFolder, strCopyFolder, "model.bim"), True)

        CreateZipFile(strDestinationFolder)

        Return True
    End Function

    Private Shared Sub CreateZipFile(strDestinationFolder As String)
        Dim strZip As String = String.Format("{0}.{1}", strDestinationFolder, "zip")

        If File.Exists(strZip) = True Then
            File.Delete(strZip)
        End If

        ZipFile.CreateFromDirectory(strDestinationFolder, strZip, CompressionLevel.Fastest, True)
    End Sub

    Private Shared Sub CopyDirectory(ByVal sourceDir As String, ByVal destinationDir As String, ByVal recursive As Boolean)
        Dim dir = New DirectoryInfo(sourceDir)
        If Not dir.Exists Then Throw New DirectoryNotFoundException($"Source directory not found: {dir.FullName}")

        If sourceDir.Contains(".git") Then Exit Sub

        Dim dirs As DirectoryInfo() = dir.GetDirectories()
        Directory.CreateDirectory(destinationDir)

        For Each file As FileInfo In dir.GetFiles()
            If file.Name = ".gitignore" Then Continue For
            Dim targetFilePath As String = Path.Combine(destinationDir, file.Name)
            IO.File.Copy(file.FullName, targetFilePath, True)
        Next

        If recursive Then

            For Each subDir As DirectoryInfo In dirs
                Dim newDestinationDir As String = Path.Combine(destinationDir, subDir.Name)
                CopyDirectory(subDir.FullName, newDestinationDir, True)
            Next
        End If
    End Sub

    Public Function ReplaceReferenceTMDL(strFile As String, strReplacement As String, strFileOut As String) As Boolean
        Dim cr As Collection(Of ClsReplacement.Replacement) = GetReplacements(strReplacement)
        Dim strText As String = vbNullString

        Using sr As New StreamReader(strFile)
            strText = sr.ReadToEnd
        End Using

        For Each c As Replacement In cr
            Dim strFrom As String = c.Title & " = " & c.StrFrom
            Dim strTo As String = c.Title & " = " & c.StrTo
            strText = strText.Replace(strFrom, strTo)
        Next

        Using sw As New StreamWriter(strFileOut, False, System.Text.Encoding.Default)
            sw.Write(strText)
        End Using

        Return True
    End Function

    Public Function CopyPBIPTMDL(strDatasetFolder As String, strFolderTarget As String, strFileOut As String) As Boolean
        Dim strSourceFolder As String = Directory.GetParent(strDatasetFolder).FullName
        Dim strSourceParent As String = Directory.GetParent(strDatasetFolder).Name

        Dim strDestinationFolder As String = Path.Combine(strFolderTarget, strSourceParent)
        Dim strCopyFolder As String = strDatasetFolder.Substring(InStrRev(strDatasetFolder, "\"))

        If Directory.Exists(strDestinationFolder) Then
            Directory.Delete(strDestinationFolder, True)
        End If

        CopyDirectory(strSourceFolder, strDestinationFolder, True)

        IO.File.Copy(strFileOut, Path.Combine(strDestinationFolder, strCopyFolder, "definition", "expressions.tmdl"), True)

        CreateZipFile(strDestinationFolder)

        Return True
    End Function

    Public Function ReplaceReportFilter(strFile As String, strPage As String, strVisual As String, Replacements() As Replacement) As Boolean
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
                    Else
                        blnReplaceVisual = False
                    End If
                End If

                If strLine.Contains("""filters"":") And blnReplaceVisual = True Then
                    Debug.Print(intI & " " & page & " " & strLine)
                    For Each r As Replacement In Replacements
                        strLine = strLine.Replace(String.Format("\""Entity\"":\""{0}\""", r.StrFrom), String.Format("\""Entity\"":\""{0}\""", r.StrTo))
                    Next
                    'Dim strRF1 As String = String.Format("\""Bereich\""{1}{1}],\""Values\"":[[{0}\""Literal\"":{0}\""Value\"":\""'{2}'\""", "{", "}", "Sach")
                    'Dim strRF2 As String = String.Format("\""Bereich\""{1}{1}],\""Values\"":[[{0}\""Literal\"":{0}\""Value\"":\""'{2}'\""", "{", "}", "TV")
                    'Dim strRF3 As String = String.Format("\""Bereich\""{1}{1}],\""Values\"":[[{0}\""Literal\"":{0}\""Value\"":\""'{2}'\""", "{", "}", "Haftpflicht")
                    'Dim strRF4 As String = String.Format("\""Bereich\""{1}{1}],\""Values\"":[[{0}\""Literal\"":{0}\""Value\"":\""'{2}'\""", "{", "}", "Heilwesen Haftpflicht")
                    'Dim strRF5 As String = String.Format("\""Bereich\""{1}{1}],\""Values\"":[[{0}\""Literal\"":{0}\""Value\"":\""'{2}'\""", "{", "}", "Kfz")
                    'Dim strRF6 As String = String.Format("\""Bereich\""{1}{1}],\""Values\"":[[{0}\""Literal\"":{0}\""Value\"":\""'{2}'\""", "{", "}", "Financial Lines")
                    'Dim strRF7 As String = String.Format("\""Bereich\""{1}{1}],\""Values\"":[[{0}\""Literal\"":{0}\""Value\"":\""'{2}'\""", "{", "}", "Transport/Verkehrshaftung")
                    'Dim strRT As String = String.Format("\""Bereich\""{1}{1}],\""Values\"":[[{0}\""Literal\"":{0}\""Value\"":\""'{2}'\""", "{", "}", "Industrie/Spezial")
                    'strLine = strLine.Replace(strRF1, strRT)
                    'strLine = strLine.Replace(strRF2, strRT)
                    'strLine = strLine.Replace(strRF3, strRT)
                    'strLine = strLine.Replace(strRF4, strRT)
                    'strLine = strLine.Replace(strRF5, strRT)
                    'strLine = strLine.Replace(strRF6, strRT)
                    'strLine = strLine.Replace(strRF7, strRT)
                End If

                strOutput &= strOutputLinebreak & strLine
                strOutputLinebreak = vbCrLf
            End While
        End Using
        File.WriteAllText(strFile, strOutput)
        Return True
    End Function
End Class
