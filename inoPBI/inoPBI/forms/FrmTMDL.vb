Imports System.IO
Imports inoPBIDLL

Public Class FrmTMDL
    Private Sub CmdFileOriginal_Click(sender As Object, e As EventArgs) Handles CmdFileOriginal.Click
        Dim fbd As New FolderBrowserDialog
        With fbd
            If .ShowDialog Then
                TxtOrginal.Text = .SelectedPath
            End If
        End With
        If TxtOrginal.Text.Contains(".Dataset") = False And TxtOrginal.Text.Contains(".SemanticModel") = False Then
            MessageBox.Show("No Dataset folder selcted")
        End If
    End Sub

    Private Sub CmdFileReplacement_Click(sender As Object, e As EventArgs) Handles CmdFileReplacement.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Filter = "*.txt|*.txt"
            If .ShowDialog Then
                TxtReplace.Text = .FileName
            End If
        End With
    End Sub

    Private Sub CmdEditReplacement_Click(sender As Object, e As EventArgs) Handles CmdEditReplacement.Click
        If File.Exists(TxtReplace.Text) Then
            With FrmReplacementFile
                .ReadFile(TxtReplace.Text)
                .ShowDialog()
                TxtReplace.Text = My.Settings.LastReplacement
            End With
        End If
    End Sub

    Private Sub CmdFolderTarget_Click(sender As Object, e As EventArgs) Handles CmdFolderTarget.Click
        Dim fbd As New FolderBrowserDialog
        With fbd
            If .ShowDialog Then
                TxtTargetFolder.Text = .SelectedPath
            End If
        End With
    End Sub

    Private Sub CmdFileDocu_Click(sender As Object, e As EventArgs) Handles CmdFileDocu.Click
        Dim sfd As New SaveFileDialog
        With sfd
            .Filter = "*.md|*.md"
            If .ShowDialog Then
                TxtFileDocu.Text = .FileName
            End If
        End With
    End Sub

    Private Sub CmdReplace_Click(sender As Object, e As EventArgs) Handles CmdReplace.Click

        Dim fileNameSource As String = Path.Combine(TxtOrginal.Text, "definition", "expressions.tmdl")
        Dim fileName As String = TxtTargetFolder.Text & "\" & Path.GetFileName(fileNameSource) & ".org"
        Dim fileNameReplace As String = TxtTargetFolder.Text & "\" & Path.GetFileName(fileNameSource) & "." & TxtCustomer.Text


        LblInfo.Text = "Replacing started"
        Application.DoEvents()

        If File.Exists(fileName) Then
            File.Delete(fileName)
        End If

        File.Copy(fileNameSource, fileName)
        Dim clsR As New ClsReplacement

        If clsR.ReplaceReferenceTMDL(fileName, TxtReplace.Text, fileNameReplace) = False Then
            MessageBox.Show("Something went wrong")
            LblInfo.Text = "Canceled with error"
            Exit Sub
        End If

        LblInfo.Text = "Copy files"
        Application.DoEvents()

        clsR.CopyPBIPTMDL(TxtOrginal.Text, TxtTargetFolder.Text, fileNameReplace)

        My.Settings.LastTMDL = TxtOrginal.Text
        My.Settings.LastReplacement = TxtReplace.Text
        My.Settings.LastFolder = TxtTargetFolder.Text
        My.Settings.LastCustomer = TxtCustomer.Text
        My.Settings.Save()

        LblInfo.Text = "Replacing finished"
    End Sub

    Private Sub CmdDocumentation_Click(sender As Object, e As EventArgs) Handles CmdDocumentation.Click
        LblInfo.Text = "Documentation started"
        Application.DoEvents()

        Dim clsTMDL As New ClsTMDLHandling(TxtOrginal.Text)
        If clsTMDL.ExtractMeasures(TxtFileDocu.Text) = False Then
            MessageBox.Show("Something went wrong")
            Exit Sub
        End If


        My.Settings.LastTMDL = TxtOrginal.Text
        My.Settings.LastDocumentation = TxtFileDocu.Text
        My.Settings.Save()

        LblInfo.Text = "Documentation finished"
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub CmdPDF_Click(sender As Object, e As EventArgs) Handles CmdPDF.Click
        FrmPDF.Show()
    End Sub

    Private Sub FrmTMDL_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtOrginal.Text = My.Settings.LastTMDL
        TxtReplace.Text = My.Settings.LastReplacement
        TxtTargetFolder.Text = My.Settings.LastFolder
        TxtCustomer.Text = My.Settings.LastCustomer
        TxtFileDocu.Text = My.Settings.LastDocumentation

        LblInfo.Text = ""
    End Sub
End Class