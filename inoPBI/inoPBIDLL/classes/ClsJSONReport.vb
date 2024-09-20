
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO

Public Class ClsJSONReport

    Public Structure ReportMeasure
        Public Page As String
        Public Table As String
        Public Valuename As String
    End Structure

    Private strHidden As String = vbNullString
    Public strHiddenPublic As String = " (hidden)"

    Public ReportMeasures As New List(Of ReportMeasure)

    Public Sub ReadReport(strfile)


        Dim json As String = File.ReadAllText(strfile)

        ReportMeasures.Clear()

        Dim data As JObject = DirectCast(JsonConvert.DeserializeObject(json), JObject)
        Json2TreeSection(data, "", "")

    End Sub

    Public Function Json2TreeSection(obj As JObject, section As String, vc As String) As Boolean
        'loop through the obj. all token should be pair<key, value>
        For Each token In obj
            'check if the value is of type obj recall the method
            If token.Value.Type.ToString() = "Object" Then

                'create a new JObject using the the Token.value
                Dim o As JObject = DirectCast(token.Value, JObject)
                'Debug.Print("token " & token.Key.ToString)
                'recall the method
                Json2TreeSection(o, section, vc)

                'if type is of array
            ElseIf token.Value.Type.ToString() = "Array" Then
                Dim ix As Integer = -1
                'Debug.Print("array " & token.Key.ToString)

                'loop though the array
                For Each itm In token.Value
                    'check if value is an Array of objects
                    If itm.Type.ToString() = "Object" Then
                        'Debug.Print("object " & token.Key.ToString)
                        'call back the method
                        ix += 1
                        Dim o As JObject = DirectCast(itm, JObject)
                        If token.Key.ToString = "sections" Then
                            section = "sec"
                        End If
                        If token.Key.ToString = "visualContainers" Then
                            vc = "vc"
                        End If
                        Json2TreeSection(o, section, vc)

                        'regular array string, int, etc
                    ElseIf itm.Type.ToString() = "Array" Then
                        ix += 1
                        '    Debug.Print("Array 1 " & token.Key.ToString)
                    Else
                        '  Debug.Print("something")
                    End If
                Next
            Else
                'if token.Value is not nested
                'change the value into N/A if value == null or an empty string 
                If token.Value.ToString() = "" Then
                    'child.Nodes.Add("N/A")
                Else
                    'Debug.Print("Token 2  " & token.Key.ToString)

                    If section = "sec" And token.Key.ToString = "config" Then
                        ' Debug.Print("config  " & token.Value.ToString)
                        If token.Value.ToString.Contains("""visibility"":1") Then
                            strHidden = strHiddenPublic
                        Else
                            strHidden = vbNullString
                        End If
                    End If
                    If section = "sec" And token.Key.ToString = "displayName" Then
                        section = token.Value.ToString & strHidden
                        '  Debug.Print("Display  " & section)
                    End If

                    If vc = "vc" And token.Key.ToString = "config" Then
                        vc = token.Value.ToString
                        '     Debug.Print(section & " Config  " & vc)
                        ReadVC(vc, section)
                    End If
                End If
            End If
        Next
        Return True
    End Function

    Public Sub ReadVC(JSONString As String, Page As String)
        Dim data As JObject = DirectCast(JsonConvert.DeserializeObject(JSONString), JObject)
        Json2TreeVC(data, Page)
    End Sub

    Public Function Json2TreeVC(obj As JObject, page As String) As Boolean
        'loop through the obj. all token should be pair<key, value>
        For Each token In obj
            'change the display Content of the parent
            'check if the value is of type obj recall the method
            If token.Value.Type.ToString() = "Object" Then
                Dim o As JObject = DirectCast(token.Value, JObject)
                'Debug.Print("token " & token.Key.ToString)
                Json2TreeVC(o, page)

                'if type is of array
            ElseIf token.Value.Type.ToString() = "Array" Then
                Dim ix As Integer = -1

                '            Debug.Print("array " & token.Key.ToString)

                'loop though the array
                For Each itm In token.Value
                    'check if value is an Array of objects
                    If itm.Type.ToString() = "Object" Then
                        'Debug.Print("object " & token.Key.ToString)
                        Dim o As JObject = DirectCast(itm, JObject)
                        Json2TreeVC(o, page)
                    ElseIf itm.Type.ToString() = "Array" Then
                        ix += 1
                        '  Debug.Print("Array 1 " & token.Key.ToString)
                    Else
                        '  Debug.Print("something")
                    End If
                Next
            Else
                If token.Value.ToString() = "" Then
                    'child.Nodes.Add("N/A")
                Else

                    'Debug.Print("Token 2  " & token.Key.ToString)

                    If token.Key.ToString = "queryRef" Then

                        'Debug.Print("queryRef  " & token.Value.ToString)
                        Dim m() As String = token.Value.ToString.Split(".")
                        Dim rm As New ReportMeasure With {
                            .Page = page,
                            .Table = m(0),
                            .Valuename = m(1)
                        }
                        ReportMeasures.Add(rm)
                    End If
                End If
            End If
        Next
        Return True
    End Function
End Class
