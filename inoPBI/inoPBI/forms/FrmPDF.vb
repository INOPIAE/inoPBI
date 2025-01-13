
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Security.Policy
Imports inoPBIDLL
Imports inoPBIDLL.ClsHelper
Imports Markdown2Pdf
Imports Markdown2Pdf.Options
Imports Newtonsoft.Json.Converters
Imports PuppeteerSharp
Imports UglyToad.PdfPig.Fonts.Encodings
Imports UglyToad.PdfPig.Graphics.Operations.InlineImages
Public Class FrmPDF

    Private cH As New ClsHelper
    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub FrmPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFileDocu.Text = My.Settings.LastDocumentation
        TxtFileDocu.Select(TxtFileDocu.Text.Length, 0)
        TxtHeader.Text = My.Settings.LastHeader
        TxtHeader.Select(TxtHeader.Text.Length, 0)
        TxtFooter.Text = My.Settings.LastFooter
        TxtFooter.Select(TxtFooter.Text.Length, 0)
        TxtTargetFile.Text = My.Settings.LastPDFFile
        TxtTargetFile.Select(TxtTargetFile.Text.Length, 0)
        TxtDocTitle.Text = My.Settings.LastDocTitle
        TxtDocTitle.Select(TxtDocTitle.Text.Length, 0)
        CbShowPDF.Checked = My.Settings.ShowPDF
        TxtPowerBIFile.Text = My.Settings.LastPowerBIFile

        LblInfo.Text = ""
        LblInfoMD.Text = cH.GetSaveTime(TxtFileDocu.Text)
        TranslateForm()
    End Sub

    Private Async Sub CmdPDF_Click(sender As Object, e As EventArgs) Handles CmdPDF.Click

        Dim chkFile As String = cH.CheckFile(TxtFileDocu.Text)
        If chkFile IsNot vbNullString Then
            MessageBox.Show(chkFile)
            TxtFileDocu.Select()
            Exit Sub
        End If

        SetFromEnable(Me, "CmdClose")
        Dim PdFOutput = vbNullString

        chkFile = cH.CheckFile(TxtHeader.Text, True)
        If chkFile IsNot vbNullString Then
            MessageBox.Show(chkFile)
            TxtHeader.Select()
            Exit Sub
        End If

        chkFile = cH.CheckFile(TxtFooter.Text, True)
        If chkFile IsNot vbNullString Then
            MessageBox.Show(chkFile)
            TxtFooter.Select()
            Exit Sub
        End If

        If TxtTargetFile.Text.Trim = vbNullString Then
            PdFOutput = TxtFileDocu.Text.Replace(".md", ".pdf")
            TxtFileDocu.Text = PdFOutput
        Else
            PdFOutput = TxtTargetFile.Text.Trim
        End If

        If FileInUse(PdFOutput) = True Then
            MessageBox.Show(My.Resources.ResourcesLang.MsgPdfFileInUse)
            Exit Sub
        End If

        LblInfo.Text = My.Resources.ResourcesLang.PdfDocumentationExportToPdf
        Application.DoEvents()

        Dim mdMarginOptions As New MarginOptions With {
             .Top = "80px",
             .Bottom = "50px",
             .Left = "50px",
             .Right = "50px"
           }

        Dim mdOptions As New Markdown2PdfOptions With {
            .DocumentTitle = TxtDocTitle.Text,
            .MarginOptions = mdMarginOptions
           }

        If TxtHeader.Text.Trim <> vbNullString Then
            mdOptions.HeaderHtml = File.ReadAllText(TxtHeader.Text)
        End If

        If TxtFooter.Text.Trim <> vbNullString Then
            mdOptions.FooterHtml = File.ReadAllText(TxtFooter.Text)
        End If

        mdOptions.CustomHeadContent = "<style>h1 { page-break-before: always; }</style>"

        mdOptions.TableOfContents = New TableOfContentsOptions With {
            .ListStyle = ListStyle.Decimal,
            .PageNumberOptions = New PageNumberOptions With {
                .TabLeader = Leader.Dots
            }
        }

        Dim mdconvert As New Markdown2PdfConverter(mdOptions)

        Await mdconvert.Convert(TxtFileDocu.Text, PdFOutput)

        LblInfo.Text = My.Resources.ResourcesLang.PdfDocumentationExportFinished

        If TxtTargetFile.Text.Trim = vbNullString Then
            TxtTargetFile.Text = PdFOutput
        End If

        My.Settings.LastHeader = TxtHeader.Text
        My.Settings.LastFooter = TxtFooter.Text
        My.Settings.LastPDFFile = TxtTargetFile.Text
        My.Settings.LastDocTitle = TxtDocTitle.Text
        My.Settings.ShowPDF = CbShowPDF.Checked
        My.Settings.LastPowerBIFile = TxtPowerBIFile.Text
        My.Settings.Save()

        If CbShowPDF.Checked Then
            Dim p = New Process With {
                .StartInfo = New ProcessStartInfo(PdFOutput)
            }
            p.StartInfo.UseShellExecute = True
            p.Start()
        End If
        SetFromEnable(Me, "CmdClose")
    End Sub

    Private Sub CmdHeaderFile_Click(sender As Object, e As EventArgs) Handles CmdHeaderFile.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Filter = "HTML (*.html)|*.html"
            .Multiselect = False
            .Title = My.Resources.ResourcesLang.PdfSelectHeaderFile
            If .ShowDialog = DialogResult.OK Then
                TxtHeader.Text = .FileName
            End If
        End With
        LblInfo.Text = ""
    End Sub

    Private Sub CmdFooterFile_Click(sender As Object, e As EventArgs) Handles CmdFooterFile.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Filter = "HTML (*.html)|*.html"
            .Multiselect = False
            .Title = My.Resources.ResourcesLang.PdfSelectFooterFile
            If .ShowDialog = DialogResult.OK Then
                TxtFooter.Text = .FileName
            End If
        End With
        LblInfo.Text = ""
    End Sub

    Private Sub CmdFileDocu_Click(sender As Object, e As EventArgs) Handles CmdFileDocu.Click
        Dim sfd As New SaveFileDialog
        With sfd
            .Filter = "Markdown (*.md)|*.md"
            If .ShowDialog = DialogResult.OK Then
                TxtFileDocu.Text = .FileName
            End If
        End With
        LblInfo.Text = ""
        LblInfoMD.Text = cH.GetSaveTime(TxtFileDocu.Text)
    End Sub

    Private Sub CmdEditHeader_Click(sender As Object, e As EventArgs) Handles CmdEditHeader.Click
        If File.Exists(TxtHeader.Text) Then
            With FrmHtml
                .OpenFile(TxtHeader.Text, FrmHtml.FileType.Header)
                .ShowDialog()
                TxtHeader.Text = My.Settings.LastHeader
            End With
        End If
        LblInfo.Text = ""
    End Sub

    Private Sub CmdEditFooter_Click(sender As Object, e As EventArgs) Handles CmdEditFooter.Click
        If File.Exists(TxtFooter.Text) Then
            With FrmHtml
                .OpenFile(TxtFooter.Text, FrmHtml.FileType.Footer)
                .ShowDialog()
                TxtFooter.Text = My.Settings.LastFooter
            End With
        End If
        LblInfo.Text = ""
    End Sub

    Private Sub CmdTargetFile_Click(sender As Object, e As EventArgs) Handles CmdTargetFile.Click
        Dim sfd As New SaveFileDialog
        With sfd
            .Filter = "PDF (*.pdf)|*.pdf"
            If .ShowDialog = DialogResult.OK Then
                TxtTargetFile.Text = .FileName
            End If
        End With
        LblInfo.Text = ""
    End Sub

    Private Sub TranslateForm()
        Me.Text = My.Resources.ResourcesLang.PdfTitle
        LblDocTitle.Text = My.Resources.ResourcesLang.PdfDocumentTitle
        LblFileDocu.Text = My.Resources.ResourcesLang.PdfDocumentationFile
        LblHeader.Text = My.Resources.ResourcesLang.PdfHeaderFile
        LblFooter.Text = My.Resources.ResourcesLang.PdfFooterFile
        LblTargetFile.Text = My.Resources.ResourcesLang.PdfTargetFile
        LblPowerBIFile.Text = My.Resources.ResourcesLang.PdfPowerBIFile

        CbShowPDF.Text = My.Resources.ResourcesLang.PdfShowPDF

        CmdClose.Text = My.Resources.ResourcesLang.BtnClose
        CmdEditFooter.Text = My.Resources.ResourcesLang.BtnEdit
        CmdEditHeader.Text = My.Resources.ResourcesLang.BtnEdit
        CmdPDF.Text = My.Resources.ResourcesLang.BtnCreatePDF
        CmdDocumentation.Text = My.Resources.ResourcesLang.BtnCreateDokumentation
    End Sub

    Private Sub CmdPowerBIFile_Click(sender As Object, e As EventArgs) Handles CmdPowerBIFile.Click
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

    Private Sub CmdDocumentation_Click(sender As Object, e As EventArgs) Handles CmdDocumentation.Click
        Dim chkFile As String = cH.CheckFile(TxtPowerBIFile.Text)
        If chkFile IsNot vbNullString Then
            MessageBox.Show(chkFile)
            TxtPowerBIFile.Select()
            Exit Sub
        End If

        Dim chkFolder As String = cH.CheckFileFolder(TxtFileDocu.Text)
        If chkFolder IsNot vbNullString Then
            MessageBox.Show(chkFolder)
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
        LblInfoMD.Text = cH.GetSaveTime(TxtFileDocu.Text)
    End Sub

End Class