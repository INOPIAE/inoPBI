Imports System.IO
Imports inoPBIDLL

Public Class FrmReplacement
    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub CmdFileOriginal_Click(sender As Object, e As EventArgs) Handles CmdFileOriginal.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Filter = "*.bim|*.bim"
            If .ShowDialog Then
                TxtOrginal.Text = .FileName
            End If
        End With
    End Sub

    Private Sub CmdFileReplacement_Click(sender As Object, e As EventArgs) Handles CmdFileReplacement.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Filter = "*.txt|*.txt"
            If .ShowDialog Then
                TxtReplace.Text = .FileName
            End If
        End With
    End Sub

    Private Sub CmdFolderTarget_Click(sender As Object, e As EventArgs) Handles CmdFolderTarget.Click
        Dim fbd As New FolderBrowserDialog
        With fbd
            If .ShowDialog Then
                TxtTargetFolder.Text = .SelectedPath
            End If
        End With
    End Sub

    Private Sub CmdReplace_Click(sender As Object, e As EventArgs) Handles CmdReplace.Click
        Dim fileName As String = TxtTargetFolder.Text & "\" & Path.GetFileName(TxtOrginal.Text) & ".org"
        Dim fileNameReplace As String = TxtTargetFolder.Text & "\" & Path.GetFileName(TxtOrginal.Text) & "." & TxtCustomer.Text

        LblInfo.Text = "Replacing started"
        Application.DoEvents()

        If File.Exists(fileName) Then
            File.Delete(fileName)
        End If

        File.Copy(TxtOrginal.Text, fileName)
        Dim clsR As New ClsReplacement
        If clsR.ReplaceReferences(fileName, TxtReplace.Text, fileNameReplace) = False Then
            MessageBox.Show("Something went wrong")
            Exit Sub
        End If


        My.Settings.LastOriginal = TxtOrginal.Text
        My.Settings.LastReplacement = TxtReplace.Text
        My.Settings.LastFolder = TxtTargetFolder.Text
        My.Settings.LastCustomer = TxtCustomer.Text
        My.Settings.Save()

        LblInfo.Text = "Replacing finished"
    End Sub

    Private Sub FrmReplacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtOrginal.Text = My.Settings.LastOriginal
        TxtReplace.Text = My.Settings.LastReplacement
        TxtTargetFolder.Text = My.Settings.LastFolder
        TxtCustomer.Text = My.Settings.LastCustomer

        LblInfo.Text = ""
    End Sub

    Private Sub CmdInfo_Click(sender As Object, e As EventArgs) Handles CmdInfo.Click
        FrmInfo.ShowDialog()
    End Sub
End Class