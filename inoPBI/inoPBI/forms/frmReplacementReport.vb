Imports System.IO
Imports inoPBIDLL
Public Class frmReplacementReport
    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmReplacementReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim strFile As String
        If My.Settings.LastTMDL.Contains(".Dataset") Then
            strFile = My.Settings.LastTMDL.Replace(".Dataset", ".Report") & "\report.json"
        Else
            strFile = My.Settings.LastTMDL.Replace(".SemanticModel", ".Report") & "\report.json"
        End If
        Me.TxtOrginal.Text = strFile

        TxtReplace.Text = My.Settings.LastRepSaveTo

        TxtPage.Text = My.Settings.LastPage
        TxtVisual.Text = My.Settings.LastVisual
        TxtReplacementFrom1.Text = My.Settings.LastRepFrom1
        TxtReplacementTo1.Text = My.Settings.LastRepTo1
        TxtReplacementFrom2.Text = My.Settings.LastRepFrom2
        TxtReplacementTo2.Text = My.Settings.LastRepTo2

        LblInfo.Text = ""

        TranslateForm()
    End Sub

    Private Sub CmdReplace_Click(sender As Object, e As EventArgs) Handles CmdReplace.Click
        Dim clsR As New ClsReplacement
        Dim Replacements() As ClsReplacement.Replacement
        ReDim Replacements(0)
        ' Replacements(0).Title = TxtVisual.Text
        Replacements(0).StrFrom = TxtReplacementFrom1.Text
        Replacements(0).StrTo = TxtReplacementTo1.Text

        If TxtReplacementFrom2.Text <> vbNullString Then
            ReDim Replacements(1)
            ' Replacements(1).Title = TxtVisual.Text
            Replacements(1).StrFrom = TxtReplacementFrom2.Text
            Replacements(1).StrTo = TxtReplacementTo2.Text
        End If
        SaveSettings()

        Dim strReplace As String = TxtOrginal.Text.Replace(".json", String.Format("_{0}_{1}.json", Now.ToString("yyyyMMdd_HHmm"), My.Settings.CurrentProject))

        Dim strRPF As String = Path.Combine(FrmMain.AppDataPath, "Backup", Path.GetFileName(strReplace))
        My.Computer.FileSystem.CopyFile(TxtOrginal.Text, strRPF, overwrite:=True)

        My.Computer.FileSystem.CopyFile(TxtOrginal.Text, TxtReplace.Text, overwrite:=True)

        LblInfo.Text = My.Resources.ResourcesLang.ReplacementReplacingStarted
        LblInfo.ForeColor = Color.Blue
        Application.DoEvents()
        clsR.ReplaceReportFilter(TxtOrginal.Text, TxtPage.Text, TxtVisual.Text, Replacements)
        'clsR.ReplaceReportResize(TxtOrginal.Text, TxtPage.Text, TxtVisual.Text, Replacements)

        LblInfo.Text = My.Resources.ResourcesLang.ReplacementReplacingFinished
        LblInfo.ForeColor = Color.DarkGreen
    End Sub

    Private Sub SaveSettings()
        My.Settings.LastPage = TxtPage.Text
        My.Settings.LastVisual = TxtVisual.Text
        My.Settings.LastRepFrom1 = TxtReplacementFrom1.Text
        My.Settings.LastRepTo1 = TxtReplacementTo1.Text
        My.Settings.LastRepFrom2 = TxtReplacementFrom2.Text
        My.Settings.LastRepTo2 = TxtReplacementTo2.Text
        My.Settings.LastRepSaveTo = TxtReplace.Text
        My.Settings.Save()
    End Sub

    Private Sub CmdFileOriginal_Click(sender As Object, e As EventArgs) Handles CmdFileOriginal.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Filter = "*.json|*.json"
            If .ShowDialog Then
                TxtOrginal.Text = .FileName
            End If
        End With
    End Sub

    Private Sub CmdFileReplacement_Click(sender As Object, e As EventArgs) Handles CmdFileReplacement.Click
        Dim ofd As New SaveFileDialog
        With ofd
            .Filter = "*.json|*.json"
            If .ShowDialog Then
                TxtReplace.Text = .FileName
            End If
        End With
    End Sub

    Private Sub TranslateForm()
        Me.Text = My.Resources.ResourcesLang.ReplacementReportTitle

        LblOriginal.Text = My.Resources.ResourcesLang.ReplacementReportOriginal
        LblRepacementSave.Text = My.Resources.ResourcesLang.ReplacementReportBackup
        LblPage.Text = My.Resources.ResourcesLang.ReplacementReportPage
        LblVisual.Text = My.Resources.ResourcesLang.ReplacementReportVisual
        LblReplace1.Text = My.Resources.ResourcesLang.ReplacementReportReplace1
        LblReplace2.Text = My.Resources.ResourcesLang.ReplacementReportReplace2
        LblFrom.Text = My.Resources.ResourcesLang.RFFrom
        LblTo.Text = My.Resources.ResourcesLang.RFTo

        CmdClose.Text = My.Resources.ResourcesLang.BtnClose
        CmdReplace.Text = My.Resources.ResourcesLang.BtnReplace
    End Sub
End Class