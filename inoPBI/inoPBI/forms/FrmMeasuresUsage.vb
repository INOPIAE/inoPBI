Imports inoPBIDLL

Public Class FrmMeasuresUsage
    Private cTMDL As ClsTMDLHandling
    Private cJR As New ClsJSONReport
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

        cJR.ReadReport(strFile)
        Dim rMeasures As List(Of ClsJSONReport.ReportMeasure) = cJR.ReportMeasures
        For Each rm As ClsJSONReport.ReportMeasure In rMeasures
            DgvReport.Rows.Add(New String() {rm.Page, rm.Table, rm.Valuename})
        Next
    End Sub
    Private Sub FrmMeasuresUsage_Load(sender As Object, e As EventArgs) Handles Me.Load
        LblInfo.Text = My.Settings.LastTMDL
        TranslateForm()
    End Sub

    Private Sub TranslateForm()
        Me.Text = My.Resources.ResourcesLang.MUTitle

        CmdClose.Text = My.Resources.ResourcesLang.BtnClose
        CmdRefresh.Text = My.Resources.ResourcesLang.BtnRefresh

        With DgvMeasures
            .Columns(0).HeaderText = My.Resources.ResourcesLang.MUMeasure
            .Columns(1).HeaderText = My.Resources.ResourcesLang.MUUsage
        End With

        With DgvReport
            .Columns(0).HeaderText = My.Resources.ResourcesLang.MUPage
            .Columns(1).HeaderText = My.Resources.ResourcesLang.MUTable
            .Columns(2).HeaderText = My.Resources.ResourcesLang.MUName
        End With
    End Sub
End Class