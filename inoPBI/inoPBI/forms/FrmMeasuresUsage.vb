Imports inoPBIDLL

Public Class FrmMeasuresUsage
    Private cTMDL As ClsTMDLHandling
    Private cJR As New ClsJSONReport
    Private dtReport As DataTable
    Private dvReport As DataView

    Private filterHidden As String = vbNullString
    Private filterMeasure As String = vbNullString

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub CmdRefresh_Click(sender As Object, e As EventArgs) Handles CmdRefresh.Click
        cTMDL = New ClsTMDLHandling(My.Settings.LastTMDL)
        cTMDL.CheckMeasures()

        DgvMeasures.Rows.Clear()

        For Each iKey As String In cTMDL.measuresCheck.Keys
            DgvMeasures.Rows.Add(New String() {iKey.ToString, cTMDL.measuresCheck(iKey)})
        Next

        Dim strFile As String
        If My.Settings.LastTMDL.Contains(".Dataset") Then
            strFile = My.Settings.LastTMDL.Replace(".Dataset", ".Report") & "\report.json"
        Else
            strFile = My.Settings.LastTMDL.Replace(".SemanticModel", ".Report") & "\report.json"
        End If

        DgvReport.Rows.Clear()

        cJR.strHiddenPublic = My.Resources.ResourcesLang.MUHidden
        cJR.ReadReport(strFile)
        Dim rMeasures As List(Of ClsJSONReport.ReportMeasure) = cJR.ReportMeasures

        dtReport = New DataTable
        dtReport.Columns.Add("Page", GetType(String))
        dtReport.Columns.Add("Table", GetType(String))
        dtReport.Columns.Add("Name", GetType(String))
        For Each rm As ClsJSONReport.ReportMeasure In rMeasures
            dtReport.Rows.Add(New String() {rm.Page, rm.Table, rm.Valuename})
        Next

        dvReport = New DataView(dtReport)
        BcReport.DataSource = dvReport
        DgvReport.DataSource = BcReport

        With DgvReport
            .Columns(0).HeaderText = My.Resources.ResourcesLang.MUPage
            .Columns(1).HeaderText = My.Resources.ResourcesLang.MUTable
            .Columns(2).HeaderText = My.Resources.ResourcesLang.MUName
        End With
    End Sub
    Private Sub FrmMeasuresUsage_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtInfo.Text = My.Settings.LastTMDL
        CmdRefresh.PerformClick()
        TranslateForm()
    End Sub

    Private Sub TranslateForm()
        Me.Text = My.Resources.ResourcesLang.MUTitle

        CmdClose.Text = My.Resources.ResourcesLang.BtnClose
        CmdRefresh.Text = My.Resources.ResourcesLang.BtnRefresh
        CmdClearFilterReport.Text = My.Resources.ResourcesLang.BtnClearFilter

        LblFilterMeasure.Text = My.Resources.ResourcesLang.MUFilterMeasure

        CkbHidden.Text = My.Resources.ResourcesLang.MUHiddenOnly

        With DgvMeasures
            .Columns(0).HeaderText = My.Resources.ResourcesLang.MUMeasure
            .Columns(1).HeaderText = My.Resources.ResourcesLang.MUUsage
        End With
    End Sub

    Private Sub FrmMeasuresUsage_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width < 800 Then
            Me.Width = 800
        End If
        Dim rightDistance As Int16 = 25
        CmdClose.Left = Me.Width - rightDistance - CmdClose.Width
        CmdRefresh.Left = Me.Width - rightDistance - CmdRefresh.Width
        TxtInfo.Width = Me.Width - 120 - rightDistance
    End Sub


    Private Sub CkbHidden_CheckedChanged_1(sender As Object, e As EventArgs) Handles CkbHidden.CheckedChanged

        If CkbHidden.Checked Then
            filterHidden = String.Format("Page Like '%{0}%'", My.Resources.ResourcesLang.MUHidden.Trim)
        Else
            filterHidden = ""
        End If
        ApplyFilter()
    End Sub

    Private Sub CmdClearFilterReport_Click(sender As Object, e As EventArgs) Handles CmdClearFilterReport.Click
        CkbHidden.Checked = False
        TxtFilterMeasure.Text = vbNullString
    End Sub

    Private Sub ApplyFilter()
        Dim Filter As String = vbNullString
        If filterHidden <> vbNullString Then
            Filter = filterHidden
        End If
        If filterMeasure <> vbNullString Then
            Filter &= If(Filter <> vbNullString, " AND ", "") & filterMeasure
        End If
        dvReport.RowFilter = Filter
    End Sub

    Private Sub TxtFilterMeasure_TextChanged(sender As Object, e As EventArgs) Handles TxtFilterMeasure.TextChanged
        filterMeasure = String.Format("Name Like '%{0}%'", Me.TxtFilterMeasure.Text)
        ApplyFilter()
    End Sub
End Class