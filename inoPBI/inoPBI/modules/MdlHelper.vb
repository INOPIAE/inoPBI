Imports System.IO

Module MdlHelper
    Public Function FileInUse(ByVal sFile As String) As Boolean
        If System.IO.File.Exists(sFile) Then
            Try
                Dim F As Short = FreeFile()
                FileOpen(F, sFile, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.LockReadWrite)
                FileClose(F)
            Catch
                Return True
            End Try
        End If
        Return False
    End Function

    Public Sub SetFromEnable(frm As Form, ctrlCloseName As String)
        For Each c As Control In frm.Controls
            If c.Name <> ctrlCloseName Then
                c.Enabled = Not c.Enabled
            End If
        Next
    End Sub

    Public Function CheckFile(strFile As String, Optional blnEmpty As Boolean = False) As Boolean
        If File.Exists(strFile) = False Then
            MessageBox.Show(My.Resources.ResourcesLang.MsgNoFileGiven)
            Return False
        ElseIf blnEmpty = False And strFile = vbNullString Then
            MessageBox.Show(My.Resources.ResourcesLang.MsgNoFileGiven)
            Return False
        Else
            Return True
        End If
    End Function

    Public Function CheckFileFolder(strFile As String) As Boolean
        If Directory.Exists(Path.GetDirectoryName(strFile)) = False Then
            MessageBox.Show(My.Resources.ResourcesLang.MsgGivenFolderDoesNotExists)
            Return False
        Else
            Return True
        End If
    End Function

    Public Function GetSaveTime(strFile As String) As String
        If File.Exists(strFile) Then
            Return String.Format(My.Resources.ResourcesLang.MsgLastSaved, File.GetLastWriteTime(strFile))
        Else
            Return vbNullString
        End If
    End Function
End Module
