Imports System.IO
Imports System.Text
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


        LblInfo.Text = My.Resources.ResourcesLang.ReplacementReplacingStarted
        Application.DoEvents()

        If File.Exists(fileName) Then
            File.Delete(fileName)
        End If

        File.Copy(TxtOrginal.Text, fileName)
        Dim clsR As New ClsReplacement

        If clsR.ReplaceReferences(fileName, TxtReplace.Text, fileNameReplace) = False Then
            MessageBox.Show(My.Resources.ResourcesLang.MsgSomethingWentWrong)
            LblInfo.Text = My.Resources.ResourcesLang.ReplacementCanceledWithError
            Exit Sub
        End If

        LblInfo.Text = My.Resources.ResourcesLang.ReplacementCopyFiles
        Application.DoEvents()

        clsR.CopyPBIP(TxtOrginal.Text, fileNameReplace)

        My.Settings.LastOriginal = TxtOrginal.Text
        My.Settings.LastReplacement = TxtReplace.Text
        My.Settings.LastFolder = TxtTargetFolder.Text
        My.Settings.LastCustomer = TxtCustomer.Text
        My.Settings.Save()

        LblInfo.Text = My.Resources.ResourcesLang.ReplacementReplacingFinished
    End Sub

    Private Sub FrmReplacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtOrginal.Text = My.Settings.LastOriginal
        TxtReplace.Text = My.Settings.LastReplacement
        TxtTargetFolder.Text = My.Settings.LastFolder
        TxtCustomer.Text = My.Settings.LastCustomer
        TxtFileDocu.Text = My.Settings.LastDocumentation

        LblInfo.Text = ""

        TranslateForm()
    End Sub

    Private Sub CmdFileDocu_Click(sender As Object, e As EventArgs) Handles CmdFileDocu.Click
        Dim sfd As New SaveFileDialog
        With sfd
            .Filter = "*.md|*.md"
            If .ShowDialog Then
                TxtFileDocu.Text = .FileName
            End If
        End With
    End Sub

    Private Sub CmdDocumentation_Click(sender As Object, e As EventArgs) Handles CmdDocumentation.Click
        LblInfo.Text = My.Resources.ResourcesLang.ReplacementDocumentationStarted
        Application.DoEvents()


        Dim clsJSON As New ClsJSONHandling
        If clsJSON.ExtractMeasures(TxtOrginal.Text, TxtFileDocu.Text) = False Then
            MessageBox.Show(My.Resources.ResourcesLang.MsgSomethingWentWrong)
            Exit Sub
        End If



        My.Settings.LastDocumentation = TxtFileDocu.Text
        My.Settings.Save()

        LblInfo.Text = My.Resources.ResourcesLang.ReplacementDocumentationFinished
    End Sub

    Private Sub CmdEditReplacement_Click(sender As Object, e As EventArgs) Handles CmdEditReplacement.Click
        If File.Exists(TxtReplace.Text) Then
            With FrmReplacementFile
                .ReadFile(TxtReplace.Text)
                .ShowDialog()
                TxtReplace.Text = My.Settings.LastReplacement
            End With
        End If
    End Sub

    Private Sub TranslateForm()
        Me.Text = My.Resources.ResourcesLang.ReplacementTitle

        LblOriginal.Text = My.Resources.ResourcesLang.ReplacementOriginal
        LblRepacement.Text = My.Resources.ResourcesLang.ReplacementReplacementFile
        LblTargetFolder.Text = My.Resources.ResourcesLang.ReplacementTargetFolder
        LblCustomer.Text = My.Resources.ResourcesLang.ReplacementCustomerExtension
        LblFileDocu.Text = My.Resources.ResourcesLang.PdfDocumentationFile

        CmdClose.Text = My.Resources.ResourcesLang.BtnClose
        CmdEditReplacement.Text = My.Resources.ResourcesLang.BtnEdit
        CmdDocumentation.Text = My.Resources.ResourcesLang.BtnCreateDokumentation

        CmdReplace.Text = My.Resources.ResourcesLang.BtnReplace

    End Sub
End Class