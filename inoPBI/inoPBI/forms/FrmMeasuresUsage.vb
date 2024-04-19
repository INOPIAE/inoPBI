Imports System.IO
Imports System.Windows.Forms.ImageList
Imports inoPBIDLL
Imports Markdig.Renderers
Imports Newtonsoft.Json.Linq
Imports PuppeteerSharp.Input

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

    End Sub
End Class