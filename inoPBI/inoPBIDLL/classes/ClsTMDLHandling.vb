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

    Public Elements As New List(Of Element)

    Public Sub ReadTables(strPath As String)
        Elements.Clear()
        For Each f As String In Directory.GetFiles(strPath)
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
                    Case "displayFolder:"
                        myElement.Displayfolder = line.Substring(14).Trim
                    Case "annotation"
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
End Class
