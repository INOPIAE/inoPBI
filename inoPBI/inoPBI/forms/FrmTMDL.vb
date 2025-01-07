Imports System.IO
Imports inoPBIDLL
Imports inoPBIDLL.ClsHelper

Public Class FrmTMDL
    Private cH As New ClsHelper
    Private Sub CmdFileOriginal_Click(sender As Object, e As EventArgs) Handles CmdFileOriginal.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Filter = String.Format(My.Resources.ResourcesLang.PDFPowerBIProjectFile, "(*.pbip)|*.pbip")
            If .ShowDialog = DialogResult.OK Then
                If Path.GetExtension(.FileName) = ".pbip" Then
                    TxtPowerBIFile.Text = .FileName
                Else
                    MessageBox.Show(String.Format(My.Resources.ResourcesLang.MsgNoPowerBiFile, "(*.pbip)"))
                End If
            End If
        End With
        LblInfo.Text = ""
    End Sub

    Private Sub CmdFileReplacement_Click(sender As Object, e As EventArgs) Handles CmdFileReplacement.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Filter = "*.txt|*.txt"
            If .ShowDialog Then
                TxtReplace.Text = .FileName
            End If
        End With
        LblInfo.Text = ""
    End Sub

    Private Sub CmdEditReplacement_Click(sender As Object, e As EventArgs) Handles CmdEditReplacement.Click
        If File.Exists(TxtReplace.Text) Then
            With FrmReplacementFile
                .ReadFile(TxtReplace.Text)
                .ShowDialog()
                TxtReplace.Text = My.Settings.LastReplacement
            End With
        End If
        LblInfo.Text = ""
    End Sub

    Private Sub CmdFolderTarget_Click(sender As Object, e As EventArgs) Handles CmdFolderTarget.Click
        Dim fbd As New FolderBrowserDialog
        With fbd
            If .ShowDialog Then
                TxtTargetFolder.Text = .SelectedPath
            End If
        End With
        LblInfo.Text = ""
    End Sub

    Private Sub CmdFileDocu_Click(sender As Object, e As EventArgs) Handles CmdFileDocu.Click
        Dim sfd As New SaveFileDialog
        With sfd
            .Filter = "*.md|*.md"
            If .ShowDialog Then
                TxtFileDocu.Text = .FileName
            End If
        End With
        LblInfo.Text = ""
    End Sub

    Private Sub CmdReplace_Click(sender As Object, e As EventArgs) Handles CmdReplace.Click
        If CheckFile(TxtPowerBIFile.Text) = False Then
            TxtPowerBIFile.Select()
            Exit Sub
        End If

        If CheckFileFolder(TxtFileDocu.Text) = False Then
            TxtFileDocu.Select()
            Exit Sub
        End If

        If Directory.Exists(Path.GetDirectoryName(TxtReplace.Text)) = False Then
            MessageBox.Show(My.Resources.ResourcesLang.MsgGivenFolderDoesNotExists)
            TxtReplace.Select()
            Exit Sub
        End If

        If Directory.Exists(Path.GetDirectoryName(TxtTargetFolder.Text)) = False Then
            MessageBox.Show(My.Resources.ResourcesLang.MsgGivenFolderDoesNotExists)
            TxtTargetFolder.Select()
            Exit Sub
        End If

        If TxtCustomer.Text.Trim = vbNullString Then
            MessageBox.Show("No customer extension given")
            TxtCustomer.Select()
            Exit Sub
        End If



        SetFromEnable(Me, "CmdClose")
        LblInfo.Text = My.Resources.ResourcesLang.ReplacementReplacingStarted
        Application.DoEvents()

        Dim pt As New ProjectType
        Dim fileName As String
        Dim fileNameReplace As String
        Dim clsR As New ClsReplacement

        pt = cH.GetProjectType(TxtPowerBIFile.Text)

        Select Case pt.Type
            Case 1
                Dim strModel As String = Path.Combine(pt.Path, "model.bim")

                fileName = TxtTargetFolder.Text & "\" & Path.GetFileName("model") & ".org"
                fileNameReplace = TxtTargetFolder.Text & "\" & Path.GetFileName("model") & "." & TxtCustomer.Text

                If File.Exists(fileName) Then
                    File.Delete(fileName)
                End If

                File.Copy(strModel, fileName)


                If clsR.ReplaceReferences(fileName, TxtReplace.Text, fileNameReplace) = False Then
                    MessageBox.Show(My.Resources.ResourcesLang.MsgSomethingWentWrong)
                    LblInfo.Text = My.Resources.ResourcesLang.ReplacementCanceledWithError
                    Exit Sub
                End If

                LblInfo.Text = My.Resources.ResourcesLang.ReplacementCopyFiles
                Application.DoEvents()

                clsR.CopyPBIP(strModel, fileNameReplace)
            Case 2
                Dim fileNameSource = Path.Combine(pt.Path, "definition", "expressions.tmdl")
                fileName = TxtTargetFolder.Text & "\" & Path.GetFileName(fileNameSource) & ".org"
                fileNameReplace = TxtTargetFolder.Text & "\" & Path.GetFileName(fileNameSource) & "." & TxtCustomer.Text


                If File.Exists(fileName) Then
                    File.Delete(fileName)
                End If

                File.Copy(fileNameSource, fileName)
                clsR.ReplacementError = My.Resources.ResourcesLang.ReplacementReplacementError


                If ChkbReplacement.Checked = False Then
                    Try
                        If clsR.ReplaceReferenceTMDL(fileName, TxtReplace.Text, fileNameReplace) = False Then
                            MessageBox.Show(My.Resources.ResourcesLang.MsgSomethingWentWrong, My.Resources.ResourcesLang.MsgHint)
                            LblInfo.Text = My.Resources.ResourcesLang.ReplacementCanceledWithError
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, My.Resources.ResourcesLang.MsgHint)
                        LblInfo.Text = My.Resources.ResourcesLang.ReplacementCanceledWithError
                        Exit Sub
                    End Try
                End If

                LblInfo.Text = My.Resources.ResourcesLang.ReplacementCopyFiles
                Application.DoEvents()

                clsR.CopyPBIPTMDL(TxtPowerBIFile.Text, TxtTargetFolder.Text, fileNameReplace)
        End Select

        My.Settings.LastPowerBIFile = TxtPowerBIFile.Text
        My.Settings.LastReplacement = TxtReplace.Text
        My.Settings.LastFolder = TxtTargetFolder.Text
        My.Settings.LastCustomer = TxtCustomer.Text
        My.Settings.LastReplacementOption = ChkbReplacement.Checked
        My.Settings.Save()

        SetFromEnable(Me, "CmdClose")

        LblInfo.Text = My.Resources.ResourcesLang.ReplacementReplacingFinished
    End Sub

    Private Sub CmdDocumentation_Click(sender As Object, e As EventArgs) Handles CmdDocumentation.Click
        If CheckFile(TxtPowerBIFile.Text) = False Then
            TxtPowerBIFile.Select()
            Exit Sub
        End If
        If CheckFileFolder(TxtFileDocu.Text) = False Then
            TxtFileDocu.Select()
            Exit Sub
        End If

        SetFromEnable(Me, "CmdClose")
        LblInfo.Text = My.Resources.ResourcesLang.ReplacementDocumentationStarted
        Application.DoEvents()

        Dim pt As New ProjectType
        pt = cH.GetProjectType(TxtPowerBIFile.Text)

        Select Case pt.Type
            Case 1
                Dim clsJSON As New ClsJSONHandling
                If clsJSON.ExtractMeasures(Path.Combine(pt.Path, "model.bim"), TxtFileDocu.Text) = False Then
                    MessageBox.Show(My.Resources.ResourcesLang.MsgSomethingWentWrong)
                    LblInfo.Text = My.Resources.ResourcesLang.MsgSomethingWentWrong
                    GoTo More
                End If
            Case 2
                Dim clsTMDL As New ClsTMDLHandling(pt.Path)
                clsTMDL.columnHeader = My.Resources.ResourcesLang.ReplacementMDColumnHeader
                If clsTMDL.ExtractMeasures(TxtFileDocu.Text) = False Then
                    MessageBox.Show(My.Resources.ResourcesLang.MsgSomethingWentWrong)
                    LblInfo.Text = My.Resources.ResourcesLang.MsgSomethingWentWrong
                    GoTo More
                End If
        End Select

        My.Settings.LastPowerBIFile = TxtPowerBIFile.Text
        My.Settings.LastDocumentation = TxtFileDocu.Text
        My.Settings.Save()

        LblInfo.Text = My.Resources.ResourcesLang.ReplacementDocumentationFinished
More:
        SetFromEnable(Me, "CmdClose")
        LblInfoMD.Text = GetSaveTime(TxtFileDocu.Text)
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub CmdPDF_Click(sender As Object, e As EventArgs) Handles CmdPDF.Click
        FrmPDF.Show()
        LblInfo.Text = ""
    End Sub

    Private Sub FrmTMDL_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtPowerBIFile.Text = My.Settings.LastPowerBIFile
        TxtPowerBIFile.Select(TxtPowerBIFile.Text.Length, 0)
        TxtReplace.Text = My.Settings.LastReplacement
        TxtReplace.Select(TxtReplace.Text.Length, 0)
        TxtTargetFolder.Text = My.Settings.LastFolder
        TxtTargetFolder.Select(TxtTargetFolder.Text.Length, 0)
        TxtCustomer.Text = My.Settings.LastCustomer
        TxtFileDocu.Text = My.Settings.LastDocumentation
        TxtFileDocu.Select(TxtFileDocu.Text.Length, 0)
        ChkbReplacement.Checked = My.Settings.LastReplacementOption

        LblInfo.Text = ""
        LblInfoMD.Text = GetSaveTime(TxtFileDocu.Text)

        TranslateForm()

    End Sub

    Private Sub TranslateForm()
        Me.Text = My.Resources.ResourcesLang.TDMLTitle

        LblPowerBIFile.Text = My.Resources.ResourcesLang.PdfPowerBIFile
        LblRepacement.Text = My.Resources.ResourcesLang.ReplacementReplacementFile
        LblTargetFolder.Text = My.Resources.ResourcesLang.ReplacementTargetFolder
        LblCustomer.Text = My.Resources.ResourcesLang.ReplacementCustomerExtension
        LblFileDocu.Text = My.Resources.ResourcesLang.PdfDocumentationFile

        ChkbReplacement.Text = My.Resources.ResourcesLang.ReplacementNoReplacement

        CmdClose.Text = My.Resources.ResourcesLang.BtnClose
        CmdEditReplacement.Text = My.Resources.ResourcesLang.BtnEdit
        CmdDocumentation.Text = My.Resources.ResourcesLang.BtnCreateDokumentation
        CmdPDF.Text = My.Resources.ResourcesLang.BtnCreatePDF
        CmdReplace.Text = My.Resources.ResourcesLang.BtnReplace

        TT.SetToolTip(CmdFileOriginal, My.Resources.ResourcesLang.ReplacementChooseFolderOfSemanticModel)

    End Sub
End Class