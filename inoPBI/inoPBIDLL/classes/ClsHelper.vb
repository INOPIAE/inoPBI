Imports System.IO

Public Class ClsHelper
    Public Structure ProjectType
        Public Path As String
        Public Type As Int16
    End Structure

    Public Function GetProjectType(projectFile As String) As ProjectType
        Dim pt As New ProjectType
        For Each Dir As String In Directory.GetDirectories(Path.GetDirectoryName(projectFile))
            If Dir.Contains("DataSet", StringComparison.CurrentCultureIgnoreCase) And pt.Path = vbNullString Then
                pt.Path = Dir
                If File.Exists(Path.Combine(Dir, "model.bim")) Then
                    pt.Type = 1
                Else
                    pt.Type = 2
                End If
            End If
            If Dir.Contains("SemanticModel", StringComparison.CurrentCultureIgnoreCase) Then
                pt.Path = Dir
                pt.Type = 2
            End If
        Next
        Return pt
    End Function

    Public Function CheckFile(strFile As String) As String
        Return CheckFile(strFile, False)
    End Function
    Public Function CheckFile(strFile As String, blnEmpty As Boolean) As String
        If blnEmpty = True And strFile = vbNullString Then
            Return vbNullString
        ElseIf blnEmpty = False And strFile = vbNullString Then
            Return My.Resources.ResourcesLangDLL.MsgNoFileGiven
        ElseIf File.Exists(strFile) = False Then
            Return My.Resources.ResourcesLangDLL.MsgNoFileGiven
        Else
            Return vbNullString
        End If
    End Function

    Public Function CheckFileFolder(strFile As String) As String
        If Directory.Exists(Path.GetDirectoryName(strFile)) = False Then
            Return My.Resources.ResourcesLangDLL.MsgGivenFolderDoesNotExists
        Else
            Return vbNullString
        End If
    End Function

    Public Function GetSaveTime(strFile As String) As String
        If File.Exists(strFile) Then
            Return String.Format(My.Resources.ResourcesLangDLL.MsgLastSaved, File.GetLastWriteTime(strFile))
        Else
            Return vbNullString
        End If
    End Function
End Class
