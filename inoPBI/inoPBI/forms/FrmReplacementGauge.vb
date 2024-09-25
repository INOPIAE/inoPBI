Imports inoPBIDLL
Imports System.IO

Public Class FrmReplacementGauge
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
        TxtReplacementFrom3.Text = My.Settings.LastRepFrom3
        TxtReplacementTo3.Text = My.Settings.LastRepTo3
        TxtReplacementFrom4.Text = My.Settings.LastRepFrom4
        TxtReplacementTo4.Text = My.Settings.LastRepTo4
        TxtReplacementFrom5.Text = My.Settings.LastRepFrom5
        TxtReplacementTo5.Text = My.Settings.LastRepTo5
        TxtReplacementFrom6.Text = My.Settings.LastRepFrom6
        TxtReplacementTo6.Text = My.Settings.LastRepTo6

        If My.Settings.LastRepFrom1 <> vbNullString Then
            dgvReplace.Rows.Add("h", "Height", My.Settings.LastRepFrom1, My.Settings.LastRepTo1)
        End If
        If My.Settings.LastRepFrom2 <> vbNullString Then
            dgvReplace.Rows.Add("w", "Width", My.Settings.LastRepFrom2, My.Settings.LastRepTo2)
        End If
        If My.Settings.LastRepFrom3 <> vbNullString Then
            dgvReplace.Rows.Add("x", "x", My.Settings.LastRepFrom3, My.Settings.LastRepTo3)
        End If
        If My.Settings.LastRepFrom4 <> vbNullString Then
            dgvReplace.Rows.Add("x", "x", My.Settings.LastRepFrom4, My.Settings.LastRepTo4)
        End If
        If My.Settings.LastRepFrom5 <> vbNullString Then
            dgvReplace.Rows.Add("y", "y", My.Settings.LastRepFrom5, My.Settings.LastRepTo5)
        End If
        If My.Settings.LastRepFrom6 <> vbNullString Then
            dgvReplace.Rows.Add("ý", "y", My.Settings.LastRepFrom6, My.Settings.LastRepTo6)
        End If

        LblInfo.Text = ""

        TranslateForm()
    End Sub

    Private Sub CmdReplace_Click(sender As Object, e As EventArgs) Handles CmdReplace.Click
        Dim clsR As New ClsReplacement
        Dim Replacements() As ClsReplacement.Replacement
        ReDim Replacements(0)
        ' Replacements(0).Title = TxtVisual.Text
        'Replacements(0).StrFrom = TxtReplacementFrom1.Text
        'Replacements(0).StrTo = TxtReplacementTo1.Text

        'If TxtReplacementFrom2.Text <> vbNullString Then
        '    ReDim Replacements(1)
        '    ' Replacements(1).Title = TxtVisual.Text
        '    Replacements(1).StrFrom = TxtReplacementFrom2.Text
        '    Replacements(1).StrTo = TxtReplacementTo2.Text
        'End If
        SaveSettings()

        Dim strReplace As String = TxtOrginal.Text.Replace(".json", String.Format("_{0}_{1}.json", Now.ToString("yyyyMMdd_HHmm"), My.Settings.CurrentProject))

        Dim strRPF As String = Path.Combine(FrmMain.AppDataPath, "Backup", Path.GetFileName(strReplace))
        My.Computer.FileSystem.CopyFile(TxtOrginal.Text, strRPF, overwrite:=True)

        My.Computer.FileSystem.CopyFile(TxtOrginal.Text, TxtReplace.Text, overwrite:=True)

        LblInfo.Text = My.Resources.ResourcesLang.ReplacementReplacingStarted
        LblInfo.ForeColor = Color.Blue
        Application.DoEvents()

        Dim clsRG As New ClsReplaceGauge
        Dim x As New ClsReplacementNum
        Dim y As New ClsReplacementNum

        clsRG.x.Clear()
        clsRG.y.Clear()

        For Each dr As DataGridViewRow In dgvReplace.Rows
            Select Case dr.Cells(0).Value
                Case "h"
                    clsRG.height.FromV = dr.Cells(2).Value
                    clsRG.height.ToV = dr.Cells(3).Value
                    clsRG.height.Range = IIf(dr.Cells(4).Value = vbNullString, 5, dr.Cells(4).Value)
                Case "w"
                    clsRG.width.FromV = dr.Cells(2).Value
                    clsRG.width.ToV = dr.Cells(3).Value
                    clsRG.width.Range = IIf(dr.Cells(4).Value = vbNullString, 5, dr.Cells(4).Value)
                Case "x"
                    x.FromV = dr.Cells(2).Value
                    x.ToV = dr.Cells(3).Value
                    x = IIf(dr.Cells(4).Value = vbNullString, 5, dr.Cells(4).Value)
                    clsRG.x.Add(x)
                Case "y"
                    y.FromV = dr.Cells(2).Value
                    y.ToV = dr.Cells(3).Value
                    y = IIf(dr.Cells(4).Value = vbNullString, 5, dr.Cells(4).Value)
                    clsRG.y.Add(y)
            End Select

        Next

        'clsRG.height.FromV = If(CkbSwitchData.Checked, TxtReplacementTo1.Text, TxtReplacementFrom1.Text)
        'clsRG.height.ToV = If(CkbSwitchData.Checked, TxtReplacementFrom1.Text, TxtReplacementTo1.Text)
        'clsRG.height.Range = 5
        'clsRG.width.FromV = If(CkbSwitchData.Checked, TxtReplacementTo2.Text, TxtReplacementFrom2.Text)
        'clsRG.width.ToV = If(CkbSwitchData.Checked, TxtReplacementFrom2.Text, TxtReplacementTo2.Text)
        'clsRG.width.Range = 5


        'x.FromV = If(CkbSwitchData.Checked, TxtReplacementTo3.Text, TxtReplacementFrom3.Text)
        'x.ToV = If(CkbSwitchData.Checked, TxtReplacementFrom3.Text, TxtReplacementTo3.Text)
        'x.Range = 5
        'clsRG.x.Add(x)

        'If TxtReplacementFrom3.Text <> vbNullString Then
        '    x = New ClsReplacementNum

        '    x.FromV = If(CkbSwitchData.Checked, TxtReplacementTo4.Text, TxtReplacementFrom4.Text)
        '    x.ToV = If(CkbSwitchData.Checked, TxtReplacementFrom4.Text, TxtReplacementTo4.Text)
        '    x.Range = 5
        '    clsRG.x.Add(x)
        'End If

        'y.FromV = If(CkbSwitchData.Checked, TxtReplacementTo5.Text, TxtReplacementFrom5.Text)
        'y.ToV = If(CkbSwitchData.Checked, TxtReplacementFrom5.Text, TxtReplacementTo5.Text)
        'y.Range = 5
        'clsRG.y.Add(y)

        'If TxtReplacementFrom6.Text <> vbNullString Then
        '    y = New ClsReplacementNum

        '    y.FromV = If(CkbSwitchData.Checked, TxtReplacementTo6.Text, TxtReplacementFrom6.Text)
        '    y.ToV = If(CkbSwitchData.Checked, TxtReplacementFrom6.Text, TxtReplacementTo6.Text)
        '    y.Range = 5
        '    clsRG.y.Add(y)
        'End If

        clsRG.ReplaceGauge(TxtOrginal.Text, TxtPage.Text)
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
        My.Settings.LastRepFrom3 = TxtReplacementFrom3.Text
        My.Settings.LastRepTo3 = TxtReplacementTo3.Text
        My.Settings.LastRepFrom4 = TxtReplacementFrom4.Text
        My.Settings.LastRepTo4 = TxtReplacementTo4.Text
        My.Settings.LastRepFrom5 = TxtReplacementFrom5.Text
        My.Settings.LastRepTo5 = TxtReplacementTo5.Text
        My.Settings.LastRepFrom6 = TxtReplacementFrom6.Text
        My.Settings.LastRepTo6 = TxtReplacementTo6.Text
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

    Private Sub CmdNew_Click(sender As Object, e As EventArgs) Handles CmdNew.Click
        FrmReplaceElement.Show()
    End Sub
End Class