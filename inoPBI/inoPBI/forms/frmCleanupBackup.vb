Imports System.IO

Public Class frmCleanupBackup
    Private Sub frmCleanuoBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListFiles()
        LblInfo.Text = ""
        TranslateForm()
    End Sub

    Private Sub CmdDelete_Click(sender As Object, e As EventArgs) Handles CmdDelete.Click
        If ClbBackup.CheckedItems.Count = 0 Then
            LblInfo.Text = My.Resources.ResourcesLang.CleanupNothingToDo
            Exit Sub
        End If
        If MessageBox.Show(String.Format(My.Resources.ResourcesLang.CleanupDleteFilesQuestion, ClbBackup.CheckedItems.Count), My.Resources.ResourcesLang.MsgHint, MessageBoxButtons.YesNo) = DialogResult.No Then
            LblInfo.Text = My.Resources.ResourcesLang.CleanupNothingToDo
            Exit Sub
        End If
        Dim intC As Int16
        For Each ci As String In ClbBackup.CheckedItems
            Dim FileDelete As String = Path.Combine(FrmMain.AppDataPath, "Backup", ci)
            If File.Exists(FileDelete) = True Then
                File.Delete(FileDelete)
                intC += 1
            End If
        Next
        LblInfo.Text = String.Format(My.Resources.ResourcesLang.CleanupFilesDeleted, intC)
        ClbBackup.Items.Clear()

        ListFiles()
    End Sub

    Private Sub ListFiles()
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Path.Combine(FrmMain.AppDataPath, "Backup"))
            If foundFile.Contains(My.Settings.CurrentProject) Then
                ClbBackup.Items.Add(Path.GetFileName(foundFile))
            End If
        Next
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Close()
    End Sub

    Private Sub TranslateForm()
        Me.Text = My.Resources.ResourcesLang.CleanupTitle

        CmdClose.Text = My.Resources.ResourcesLang.BtnClose
        CmdDelete.Text = My.Resources.ResourcesLang.BtnDeleteSelectedFiles

        LblFiles.Text = String.Format(My.Resources.ResourcesLang.CleanupBackupFiles, My.Settings.CurrentProject)

    End Sub
End Class