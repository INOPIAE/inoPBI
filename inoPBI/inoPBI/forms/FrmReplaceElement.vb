Public Class FrmReplaceElement

    Public intLine As Int16
    Private Types As New List(Of KeyValuePair(Of String, String))

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmReplaceElement_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim keyVal As KeyValuePair(Of String, String)
        keyVal = New KeyValuePair(Of String, String)("w", "width")
        Types.Add(keyVal)
        keyVal = New KeyValuePair(Of String, String)("h", "height")
        Types.Add(keyVal)
        keyVal = New KeyValuePair(Of String, String)("x", "x")
        Types.Add(keyVal)
        keyVal = New KeyValuePair(Of String, String)("y", "y")
        Types.Add(keyVal)
        CboType.DataSource = Types
        CboType.DisplayMember = "value"
        CboType.ValueMember = "key"
    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles CmdSave.Click
        FrmReplacementGauge.dgvReplace.Rows.Add(CboType.SelectedValue, CboType.Text, TxtFrom.Text, TxtTo.Text, TxtRange.Text)
    End Sub
End Class