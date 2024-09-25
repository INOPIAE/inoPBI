Imports inoPBIDLL
Imports System.IO
Imports System.Runtime.InteropServices

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
                    clsRG.height.FromV = IIf(CkbSwitchData.Checked, dr.Cells(3).Value, dr.Cells(2).Value)
                    clsRG.height.ToV = IIf(CkbSwitchData.Checked, dr.Cells(2).Value, dr.Cells(3).Value)
                    clsRG.height.Range = IIf(dr.Cells(4).Value = vbNullString, 5, dr.Cells(4).Value)
                Case "w"
                    clsRG.width.FromV = IIf(CkbSwitchData.Checked, dr.Cells(3).Value, dr.Cells(2).Value)
                    clsRG.width.ToV = IIf(CkbSwitchData.Checked, dr.Cells(2).Value, dr.Cells(3).Value)
                    clsRG.width.Range = IIf(dr.Cells(4).Value = vbNullString, 5, dr.Cells(4).Value)
                Case "x"
                    x.FromV = IIf(CkbSwitchData.Checked, dr.Cells(3).Value, dr.Cells(2).Value)
                    x.ToV = IIf(CkbSwitchData.Checked, dr.Cells(2).Value, dr.Cells(3).Value)
                    x.Range = IIf(dr.Cells(4).Value = vbNullString, 5, dr.Cells(4).Value)
                    clsRG.x.Add(x)
                Case "y"
                    y.FromV = IIf(CkbSwitchData.Checked, dr.Cells(3).Value, dr.Cells(2).Value)
                    y.ToV = IIf(CkbSwitchData.Checked, dr.Cells(2).Value, dr.Cells(3).Value)
                    y.Range = IIf(dr.Cells(4).Value = vbNullString, 5, dr.Cells(4).Value)
                    clsRG.y.Add(y)
                Case "max"
                    clsRG.Max.FromStr = IIf(CkbSwitchData.Checked, dr.Cells(3).Value, dr.Cells(2).Value)
                    clsRG.Max.ToStr = IIf(CkbSwitchData.Checked, dr.Cells(2).Value, dr.Cells(3).Value)
                    clsRG.Max.CaptionFrom = IIf(CkbSwitchData.Checked, dr.Cells(5).Value.ToString.Trim, dr.Cells(4).Value.ToString.Trim)
                    clsRG.max.CaptionTo = IIf(CkbSwitchData.Checked, dr.Cells(4).Value.ToString.Trim, dr.Cells(5).Value.ToString.Trim)
                Case "min"
                    clsRG.min.FromStr = IIf(CkbSwitchData.Checked, dr.Cells(3).Value, dr.Cells(2).Value)
                    clsRG.min.ToStr = IIf(CkbSwitchData.Checked, dr.Cells(2).Value, dr.Cells(3).Value)
                    clsRG.min.CaptionFrom = IIf(CkbSwitchData.Checked, dr.Cells(5).Value.ToString.Trim, dr.Cells(4).Value.ToString.Trim)
                    clsRG.min.CaptionTo = IIf(CkbSwitchData.Checked, dr.Cells(4).Value.ToString.Trim, dr.Cells(5).Value.ToString.Trim)
                Case "target"
                    clsRG.target.FromStr = IIf(CkbSwitchData.Checked, dr.Cells(3).Value, dr.Cells(2).Value)
                    clsRG.target.ToStr = IIf(CkbSwitchData.Checked, dr.Cells(2).Value, dr.Cells(3).Value)
                    clsRG.target.CaptionFrom = IIf(CkbSwitchData.Checked, dr.Cells(5).Value.ToString.Trim, dr.Cells(4).Value.ToString.Trim)
                    clsRG.target.CaptionTo = IIf(CkbSwitchData.Checked, dr.Cells(4).Value.ToString.Trim, dr.Cells(5).Value.ToString.Trim)
            End Select
        Next


        clsRG.ReplaceGauge(TxtOrginal.Text, TxtPage.Text)
        LblInfo.Text = My.Resources.ResourcesLang.ReplacementReplacingFinished
        LblInfo.ForeColor = Color.DarkGreen
    End Sub

    Private Sub SaveSettings()
        My.Settings.LastPage = TxtPage.Text
        My.Settings.LastVisual = TxtVisual.Text
        My.Settings.LastRepSaveTo = TxtReplace.Text

        Dim x As Int16 = 0
        Dim y As Int16 = 0

        My.Settings.LastRepFrom1 = vbNullString
        My.Settings.LastRepTo1 = vbNullString
        My.Settings.LastRepFrom2 = vbNullString
        My.Settings.LastRepTo2 = vbNullString
        My.Settings.LastRepFrom3 = vbNullString
        My.Settings.LastRepTo3 = vbNullString
        My.Settings.LastRepFrom4 = vbNullString
        My.Settings.LastRepTo4 = vbNullString
        My.Settings.LastRepFrom5 = vbNullString
        My.Settings.LastRepTo5 = vbNullString
        My.Settings.LastRepFrom6 = vbNullString
        My.Settings.LastRepTo6 = vbNullString

        For Each dr As DataGridViewRow In dgvReplace.Rows
            Select Case dr.Cells(0).Value
                Case "h"
                    My.Settings.LastRepFrom1 = dr.Cells(2).Value
                    My.Settings.LastRepTo1 = dr.Cells(3).Value
                Case "w"
                    My.Settings.LastRepFrom2 = dr.Cells(2).Value
                    My.Settings.LastRepTo2 = dr.Cells(3).Value
                Case "x"
                    Select Case x
                        Case 0
                            My.Settings.LastRepFrom3 = dr.Cells(2).Value
                            My.Settings.LastRepTo3 = dr.Cells(3).Value
                        Case 1
                            My.Settings.LastRepFrom4 = dr.Cells(2).Value
                            My.Settings.LastRepTo4 = dr.Cells(3).Value
                    End Select
                    x += 1
                Case "y"
                    Select Case y
                        Case 0
                            My.Settings.LastRepFrom5 = dr.Cells(2).Value
                            My.Settings.LastRepTo5 = dr.Cells(3).Value
                        Case 1
                            My.Settings.LastRepFrom6 = dr.Cells(2).Value
                            My.Settings.LastRepTo6 = dr.Cells(3).Value
                    End Select
                    y += 1
            End Select

        Next
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

        With dgvReplace
            .Columns(0).Visible = 0
            .Columns(1).HeaderText = My.Resources.ResourcesLang.RFType
            .Columns(2).HeaderText = My.Resources.ResourcesLang.RFFrom
            .Columns(3).HeaderText = My.Resources.ResourcesLang.RFTo
            .Columns(4).HeaderText = My.Resources.ResourcesLang.RFAllowedDifference
            .Columns(5).HeaderText = My.Resources.ResourcesLang.RFNewCaption

            .Sort(.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        End With

        CmdClose.Text = My.Resources.ResourcesLang.BtnClose
        CmdReplace.Text = My.Resources.ResourcesLang.BtnReplace
        CmdNew.Text = My.Resources.ResourcesLang.BtnNew
        CmdEdit.Text = My.Resources.ResourcesLang.BtnEdit
        CmdDelete.Text = My.Resources.ResourcesLang.BtnDeleteEntry
    End Sub

    Private Sub CmdNew_Click(sender As Object, e As EventArgs) Handles CmdNew.Click
        FrmReplaceElement.Show()
    End Sub

    Private Sub CmdEdit_Click(sender As Object, e As EventArgs) Handles CmdEdit.Click
        If dgvReplace.SelectedRows.Count = 1 Then

            With FrmReplaceElement
                .Show()
                .intLine = dgvReplace.SelectedRows(0).Index
                .CboType.SelectedValue = dgvReplace.SelectedRows(0).Cells(0).Value
                .TxtFrom.Text = dgvReplace.SelectedRows(0).Cells(2).Value
                .TxtTo.Text = dgvReplace.SelectedRows(0).Cells(3).Value
                .TxtRange.Text = dgvReplace.SelectedRows(0).Cells(4).Value
                .TxtRangeTo.Text = dgvReplace.SelectedRows(0).Cells(5).Value
            End With
        End If
    End Sub

    Private Sub CmdDelete_Click(sender As Object, e As EventArgs) Handles CmdDelete.Click
        If dgvReplace.SelectedRows.Count = 1 Then
            If MessageBox.Show(My.Resources.ResourcesLang.MsgDeleteSelectedEntry, My.Resources.ResourcesLang.MsgHint, MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim i As Integer = dgvReplace.SelectedRows(0).Index
                dgvReplace.Rows.RemoveAt(i)
            End If
        End If
    End Sub

    Private Sub CkbSwitchData_CheckedChanged(sender As Object, e As EventArgs) Handles CkbSwitchData.CheckedChanged
        LblInfo.Text = ""
    End Sub
End Class