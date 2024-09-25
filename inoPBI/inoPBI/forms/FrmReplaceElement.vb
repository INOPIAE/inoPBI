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
        If intLine = 0 Then
            Dim row As DataGridViewRow = FrmReplacementGauge.dgvReplace.Rows.Cast(Of DataGridViewRow)().Where(Function(r) r.Cells(0).Value.ToString().Equals(CboType.SelectedValue)).First()
            If row.Index > 0 And (CboType.SelectedValue = "w" Or CboType.SelectedValue = "h") And FrmReplacementGauge.dgvReplace.Rows.Count > 0 Then
                MessageBox.Show(My.Resources.ResourcesLang.MsgEntryExists & vbCrLf & My.Resources.ResourcesLang.MsgActionIsCanceled)
                Exit Sub
            End If

            FrmReplacementGauge.dgvReplace.Rows.Add(CboType.SelectedValue, CboType.Text, TxtFrom.Text, TxtTo.Text, TxtRange.Text)
            FrmReplacementGauge.dgvReplace.Sort(FrmReplacementGauge.dgvReplace.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        Else
            With FrmReplacementGauge.dgvReplace.Rows(intLine)
                .Cells(0).Value = CboType.SelectedValue
                .Cells(1).Value = CboType.Text
                .Cells(2).Value = TxtFrom.Text
                .Cells(3).Value = TxtTo.Text
                .Cells(4).Value = TxtRange.Text
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

        Me.Text = My.Resources.ResourcesLang.REDefineElement
    End Sub
End Class