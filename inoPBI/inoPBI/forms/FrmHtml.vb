Imports System.IO

Public Class FrmHtml
    Private strFile As String

    Public Enum FileType
        NotDefined
        Header
        Footer
    End Enum

    Private myFileType As FileType

    Private Sub CmdOpen_Click(sender As Object, e As EventArgs) Handles CmdOpen.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Filter = "*.html|*.html"
            .Multiselect = False
            If .ShowDialog = DialogResult.OK Then
                strFile = .FileName
                ReadFile()
            End If
        End With
    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles CmdSave.Click
        WriteFile(strFile)
    End Sub

    Private Sub CmdSaveAs_Click(sender As Object, e As EventArgs) Handles CmdSaveAs.Click
        Dim sfd As New SaveFileDialog
        With sfd
            .Filter = "*.html|*.html"
            If .ShowDialog = DialogResult.OK Then
                strFile = .FileName
                WriteFile(strFile)
                Me.Text = String.Format(My.Resources.ResourcesLang.HtmlEditTitle, Path.GetFileName(strFile))
                Select Case myFileType
                    Case FileType.Header
                        My.Settings.LastHeader = strFile
                        My.Settings.Save()
                    Case FileType.Footer
                        My.Settings.LastFooter = strFile
                        My.Settings.Save()
                End Select
            End If
        End With
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub ReadFile()
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(strFile, System.Text.Encoding.UTF32)
        TxtText.Text = fileReader
        Me.Text = String.Format(My.Resources.ResourcesLang.HtmlEditTitle, Path.GetFileName(strFile))
    End Sub

    Private Sub WriteFile(filename)
        My.Computer.FileSystem.WriteAllText(filename, TxtText.Text, False)
    End Sub

    Public Sub OpenFile(filename As String, Optional filetype As FileType = 0)
        strFile = filename
        myFileType = filetype
        ReadFile()
    End Sub

    Private Sub FrmHtml_Load(sender As Object, e As EventArgs) Handles Me.Load
        TranslateForm()
    End Sub

    Private Sub TranslateForm()
        Me.Text = My.Resources.ResourcesLang.HtmlTitle
        CmdClose.Text = My.Resources.ResourcesLang.BtnClose
        CmdOpen.Text = My.Resources.ResourcesLang.BtnOpen
        CmdSave.Text = My.Resources.ResourcesLang.BtnSave
        CmdSaveAs.Text = My.Resources.ResourcesLang.BtnSaveAs
    End Sub
End Class