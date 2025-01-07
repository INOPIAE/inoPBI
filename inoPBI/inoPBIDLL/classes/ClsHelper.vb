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
End Class
