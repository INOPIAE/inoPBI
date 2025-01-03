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
End Module
