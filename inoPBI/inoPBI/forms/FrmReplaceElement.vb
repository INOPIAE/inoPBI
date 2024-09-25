Public Class FrmReplaceElement

    Public intLine As Int16
    Private Types As New List(Of KeyValuePair(Of String, String))

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmReplaceElement_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim keyVal As KeyValuePair(Of String, String)
        keyVal = New KeyValuePair(Of String, String)("w", My.Resources.ResourcesLang.REWidth)
        Types.Add(keyVal)
        keyVal = New KeyValuePair(Of String, String)("h", My.Resources.ResourcesLang.REHeight)
        Types.Add(keyVal)
        keyVal = New KeyValuePair(Of String, String)("x", My.Resources.ResourcesLang.REXHorizontal)
        Types.Add(keyVal)
        keyVal = New KeyValuePair(Of String, String)("y", My.Resources.ResourcesLang.REYVertical)
        Types.Add(keyVal)
        keyVal = New KeyValuePair(Of String, String)("max", My.Resources.ResourcesLang.REMaximum)
        Types.Add(keyVal)
        keyVal = New KeyValuePair(Of String, String)("min", My.Resources.ResourcesLang.REMinimum)
        Types.Add(keyVal)
        keyVal = New KeyValuePair(Of String, String)("target", My.Resources.ResourcesLang.RETargetValue)
        Types.Add(keyVal)

        CboType.DataSource = Types
        CboType.DisplayMember = "value"
        CboType.ValueMember = "key"
        TranslateForm()
    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles CmdSave.Click
        If TxtFrom.Text.Trim = vbNullString Then
            MessageBox.Show(My.Resources.ResourcesLang.MsgFromIsMissing & vbCrLf & My.Resources.ResourcesLang.MsgActionIsCanceled)
            TxtFrom.Select()
            Exit Sub
        End If
        If TxtTo.Text.Trim = vbNullString Then
            MessageBox.Show(My.Resources.ResourcesLang.MsgToIsMissing & vbCrLf & My.Resources.ResourcesLang.MsgActionIsCanceled)
            TxtTo.Select()
            Exit Sub
        End If

        Select Case CboType.SelectedValue
            Case "max", "min", "target"
                If TxtRange.Text.Trim = vbNullString Then
                    MessageBox.Show(My.Resources.ResourcesLang.MsgAllowedDifferenceIsMissing & vbCrLf & My.Resources.ResourcesLang.MsgActionIsCanceled)
                    TxtRange.Select()
                    Exit Sub
                End If
            Case Else

        End Select

        If intLine = 0 Then
            Try
                Dim row As DataGridViewRow = FrmReplacementGauge.dgvReplace.Rows.Cast(Of DataGridViewRow)().Where(Function(r) r.Cells(0).Value.ToString().Equals(CboType.SelectedValue)).First()
                If row.Index > 0 And (CboType.SelectedValue <> "x" And CboType.SelectedValue <> "y") And FrmReplacementGauge.dgvReplace.Rows.Count > 0 Then
                    MessageBox.Show(My.Resources.ResourcesLang.MsgEntryExists & vbCrLf & My.Resources.ResourcesLang.MsgActionIsCanceled)
                    Exit Sub
                End If
            Catch ex As InvalidOperationException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
            FrmReplacementGauge.dgvReplace.Rows.Add(CboType.SelectedValue, CboType.Text, TxtFrom.Text, TxtTo.Text, TxtRange.Text, TxtRangeTo.Text)
            FrmReplacementGauge.dgvReplace.Sort(FrmReplacementGauge.dgvReplace.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        Else
            With FrmReplacementGauge.dgvReplace.Rows(intLine)
                .Cells(0).Value = CboType.SelectedValue
                .Cells(1).Value = CboType.Text
                .Cells(2).Value = TxtFrom.Text
                .Cells(3).Value = TxtTo.Text
                .Cells(4).Value = TxtRange.Text
                .Cells(5).Value = TxtRangeTo.Text
            End With
        End If
        Close()
    End Sub

    Private Sub TranslateForm()
        CmdCancel.Text = My.Resources.ResourcesLang.BtnCancel
        CmdSave.Text = My.Resources.ResourcesLang.BtnSave

        LblType.Text = My.Resources.ResourcesLang.RFType
        LblFrom.Text = My.Resources.ResourcesLang.RFFrom
        LblTo.Text = My.Resources.ResourcesLang.RFTo
        LblRange.Text = My.Resources.ResourcesLang.RFAllowedDifference
        LblRangeTo.Text = My.Resources.ResourcesLang.RFNewCaption

        Me.Text = My.Resources.ResourcesLang.REDefineElement
    End Sub
End Class