Imports System.IO
Imports inoPBIDLL

Public Class FrmTMDL
    Private Sub CmdFileOriginal_Click(sender As Object, e As EventArgs) Handles CmdFileOriginal.Click
        Dim fbd As New FolderBrowserDialog
        With fbd
            If .ShowDialog Then
                TxtOrginal.Text = .SelectedPath
            End If
        End With
        If TxtOrginal.Text.Contains(".Dataset") = False And TxtOrginal.Text.Contains(".SemanticModel") = False Then
            MessageBox.Show(My.Resources.ResourcesLang.ReplacementNoDatasetFolderSelected)
        End If
        LblInfo.Text = ""
    End Sub

    Private Sub CmdFileReplacement_Click(sender As Object, e As EventArgs) Handles CmdFileReplacement.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Filter = "*.txt|*.txt"
            If .ShowDialog Then
                TxtReplace.Text = .FileName
            End If
        End With
        LblInfo.Text = ""
    End Sub

    Private Sub CmdEditReplacement_Click(sender As Object, e As EventArgs) Handles CmdEditReplacement.Click
        If File.Exists(TxtReplace.Text) Then
            With FrmReplacementFile
                .ReadFile(TxtReplace.Text)
                .ShowDialog()
                TxtReplace.Text = My.Settings.LastReplacement
            End With
        End If
        LblInfo.Text = ""
    End Sub

    Private Sub CmdFolderTarget_Click(sender As Object, e As EventArgs) Handles CmdFolderTarget.Click
        Dim fbd As New FolderBrowserDialog
        With fbd
            If .ShowDialog Then
                TxtTargetFolder.Text = .SelectedPath
            End If
        End With
        LblInfo.Text = ""
    End Sub

    Private Sub CmdFileDocu_Click(sender As Object, e As EventArgs) Handles CmdFileDocu.Click
        Dim sfd As New SaveFileDialog
        With sfd
            .Filter = "*.md|*.md"
            If .ShowDialog Then
                TxtFileDocu.Text = .FileName
            End If
        End With
        LblInfo.Text = ""
    End Sub

    Private Sub CmdReplace_Click(sender As Object, e As EventArgs) Handles CmdReplace.Click

        Dim fileNameSource = Path.Combine(TxtOrginal.Text, "definition", "expressions.tmdl")
        Dim fileName = TxtTargetFolder.Text & "\" & Path.GetFileName(fileNameSource) & ".org"
        Dim fileNameReplace = TxtTargetFolder.Text & "\" & Path.GetFileName(fileNameSource) & "." & TxtCustomer.Text

        SetFromEnable(Me, "CmdClose")

        LblInfo.Text = My.Resources.ResourcesLang.ReplacementReplacingStarted
        Application.DoEvents()

        If File.Exists(fileName) Then
            File.Delete(fileName)
        End If

        File.Copy(fileNameSource, fileName)
        Dim clsR As New ClsReplacement
        clsR.ReplacementError = My.Resources.ResourcesLang.ReplacementReplacementError

        My.Settings.LastTMDL = TxtOrginal.Text
        My.Settings.LastReplacement = TxtReplace.Text
        My.Settings.LastFolder = TxtTargetFolder.Text
        My.Settings.LastCustomer = TxtCustomer.Text
        My.Settings.LastReplacementOption = ChkbReplacement.Checked
        My.Settings.Save()

        If ChkbReplacement.Checked = False Then
            Try
                If clsR.ReplaceReferenceTMDL(fileName, TxtReplace.Text, fileNameReplace) = False Then
                    MessageBox.Show(My.Resources.ResourcesLang.MsgSomethingWentWrong, My.Resources.ResourcesLang.MsgHint)
                    LblInfo.Text = My.Resources.ResourcesLang.ReplacementCanceledWithError
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Resources.ResourcesLang.MsgHint)
                LblInfo.Text = My.Resources.ResourcesLang.ReplacementCanceledWithError
                Exit Sub
            End Try
        End If
        LblInfo.Text = My.Resources.ResourcesLang.ReplacementCopyFiles
        Application.DoEvents()

        clsR.CopyPBIPTMDL(TxtOrginal.Text, TxtTargetFolder.Text, fileNameReplace)

        SetFromEnable(Me, "CmdClose")

        LblInfo.Text = My.Resources.ResourcesLang.ReplacementReplacingFinished
    End Sub

    Private Sub CmdDocumentation_Click(sender As Object, e As EventArgs) Handles CmdDocumentation.Click
        SetFromEnable(Me, "CmdClose")
        LblInfo.Text = My.Resources.ResourcesLang.ReplacementDocumentationStarted
        Application.DoEvents()

        Dim clsTMDL As New ClsTMDLHandling(TxtOrginal.Text)
        clsTMDL.columnHeader = My.Resources.ResourcesLang.ReplacementMDColumnHeader
        If clsTMDL.ExtractMeasures(TxtFileDocu.Text) = False Then
            MessageBox.Show(My.Resources.ResourcesLang.MsgSomethingWentWrong)
            Exit Sub
        End If


        My.Settings.LastTMDL = TxtOrginal.Text
        My.Settings.LastDocumentation = TxtFileDocu.Text
        My.Settings.Save()

        LblInfo.Text = My.Resources.ResourcesLang.ReplacementDocumentationFinished
        SetFromEnable(Me, "CmdClose")
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub CmdPDF_Click(sender As Object, e As EventArgs) Handles CmdPDF.Click
        FrmPDF.Show()
        LblInfo.Text = ""
    End Sub

    Private Sub FrmTMDL_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtOrginal.Text = My.Settings.LastTMDL
        TxtOrginal.Select(TxtOrginal.Text.Length, 0)
        TxtReplace.Text = My.Settings.LastReplacement
        TxtReplace.Select(TxtReplace.Text.Length, 0)
        TxtTargetFolder.Text = My.Settings.LastFolder
        TxtTargetFolder.Select(TxtTargetFolder.Text.Length, 0)
        TxtCustomer.Text = My.Settings.LastCustomer
        TxtFileDocu.Text = My.Settings.LastDocumentation
        TxtFileDocu.Select(TxtFileDocu.Text.Length, 0)
        ChkbReplacement.Checked = My.Settings.LastReplacementOption

        LblInfo.Text = ""

        TranslateForm()
    End Sub

    Private Sub TranslateForm()
        Me.Text = My.Resources.ResourcesLang.TDMLTitle

        LblOriginal.Text = My.Resources.ResourcesLang.ReplacementOriginal
        LblRepacement.Text = My.Resources.ResourcesLang.ReplacementReplacementFile
        LblTargetFolder.Text = My.Resources.ResourcesLang.ReplacementTargetFolder
        LblCustomer.Text = My.Resources.ResourcesLang.ReplacementCustomerExtension
        LblFileDocu.Text = My.Resources.ResourcesLang.PdfDocumentationFile

        ChkbReplacement.Text = My.Resources.ResourcesLang.ReplacementNoReplacement

        CmdClose.Text = My.Resources.ResourcesLang.BtnClose
        CmdEditReplacement.Text = My.Resources.ResourcesLang.BtnEdit
        CmdDocumentation.Text = My.Resources.ResourcesLang.BtnCreateDokumentation
        CmdPDF.Text = My.Resources.ResourcesLang.BtnCreatePDF
        CmdReplace.Text = My.Resources.ResourcesLang.BtnReplace

        TT.SetToolTip(CmdFileOriginal, My.Resources.ResourcesLang.ReplacementChooseFolderOfSemanticModel)

    End Sub
End Class