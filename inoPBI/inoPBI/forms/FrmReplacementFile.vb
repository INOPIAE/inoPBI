Imports System.IO
Imports System.Text
Imports inoPBI.FrmHtml

Public Class FrmReplacementFile
    Private strFile As String
    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Close()
    End Sub


    Public Sub ReadFile(filename As String)
        Dim TextLine As String = ""
        Dim SplitLine() As String
        strFile = filename


        DgvReplacement.SelectAll()
        DeleteRowsFromDgv()


        Using objReader As New System.IO.StreamReader(filename, Encoding.UTF8)
            Do While objReader.Peek() <> -1
                TextLine = objReader.ReadLine()
                SplitLine = Split(TextLine, ";")
                DgvReplacement.Rows.Add(SplitLine)
            Loop
        End Using
        Me.Text = String.Format("Edit {0}", strFile)
    End Sub

    Private Sub SaveFile()
        Dim rows = From row As DataGridViewRow In DgvReplacement.Rows.Cast(Of DataGridViewRow)()
                   Where Not row.IsNewRow
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        Using sw As New IO.StreamWriter(strFile, False, Encoding.UTF8)

            For Each r In rows
                sw.WriteLine(String.Join(";", r))
            Next
        End Using
    End Sub

    Private Sub CmdSaveAs_Click(sender As Object, e As EventArgs) Handles CmdSaveAs.Click
        Dim sfd As New SaveFileDialog
        With sfd
            .Filter = "*.txt|*.txt"
            If .ShowDialog = DialogResult.OK Then
                strFile = .FileName
                SaveFile()

                My.Settings.LastReplacement = strFile
                My.Settings.Save()

            End If
        End With
    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles CmdSave.Click
        SaveFile()
    End Sub

    Private Sub CmdDeleteEntry_Click(sender As Object, e As EventArgs) Handles CmdDeleteEntry.Click
        DeleteRowsFromDgv()
    End Sub

    Private Sub DeleteRowsFromDgv()
        For Each row As DataGridViewRow In DgvReplacement.SelectedRows
            If row.IsNewRow = False Then
                DgvReplacement.Rows.Remove(row)
            End If
        Next
    End Sub

    Private Sub CmdUp_Click(sender As Object, e As EventArgs) Handles CmdUp.Click
        If DgvReplacement.SelectedRows.Count = 1 Then
            Dim Row As DataGridViewRow = DgvReplacement.SelectedRows(0)

            If Row.Index > 0 Then
                Dim Index = Row.Index
                Dim OldRow = CType(Row.Clone(), DataGridViewRow)

                For i As Integer = 0 To OldRow.Cells.Count - 1
                    OldRow.Cells(i).Value = Row.Cells(i).Value
                Next

                DgvReplacement.Rows.RemoveAt(Index)
                DgvReplacement.Rows.Insert(Index - 1, OldRow)
            End If
        End If
    End Sub

    Private Sub CmdDown_Click(sender As Object, e As EventArgs) Handles CmdDown.Click
        If DgvReplacement.SelectedRows.Count = 1 Then
            Dim Row As DataGridViewRow = DgvReplacement.SelectedRows(0)

            If Row.Index < DgvReplacement.Rows.Count - 1 Then
                Dim Index = Row.Index
                Dim OldRow = CType(Row.Clone(), DataGridViewRow)

                For i As Integer = 0 To OldRow.Cells.Count - 1
                    OldRow.Cells(i).Value = Row.Cells(i).Value
                Next

                DgvReplacement.Rows.RemoveAt(Index)
                DgvReplacement.Rows.Insert(Index + 1, OldRow)
            End If
        End If
    End Sub

    Private Sub FrmReplacementFile_Load(sender As Object, e As EventArgs) Handles Me.Load
        TranslateForm()
    End Sub

    Private Sub TranslateForm()
        Me.Text = My.Resources.ResourcesLang.RFTitle
        CmdClose.Text = My.Resources.ResourcesLang.BtnClose
        CmdSave.Text = My.Resources.ResourcesLang.BtnSave
        CmdSaveAs.Text = My.Resources.ResourcesLang.BtnSaveAs
        CmdDeleteEntry.Text = My.Resources.ResourcesLang.BtnDeleteEntry
        CmdDown.Text = My.Resources.ResourcesLang.BtnDown
        CmdUp.Text = My.Resources.ResourcesLang.BtnUp

        With DgvReplacement
            .Columns(0).HeaderText = My.Resources.ResourcesLang.RFName
            .Columns(1).HeaderText = My.Resources.ResourcesLang.RFFrom
            .Columns(2).HeaderText = My.Resources.ResourcesLang.RFTo
        End With
    End Sub
End Class