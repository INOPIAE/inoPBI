
Imports System.IO
Imports Markdown2Pdf
Imports Markdown2Pdf.Options
Public Class FrmPDF
    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub FrmPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFileDocu.Text = My.Settings.LastDocumentation
        TxtHeader.Text = My.Settings.LastHeader
        TxtFooter.Text = My.Settings.LastFooter
        '  TxtTargetFolder.Text = My.Settings.LastFolder
        TxtDocTitle.Text = My.Settings.LastDocTitle

        LblInfo.Text = ""
    End Sub

    Private Async Sub CmdDocumentation_Click(sender As Object, e As EventArgs) Handles CmdDocumentation.Click
        LblInfo.Text = "Documentation export to pdf"
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

        '   KeepHtml = True,
        '   IsLandscape = True,
        '};

        Dim mdconvert As New Markdown2PdfConverter(mdOptions)

        Dim strPDF = Await mdconvert.Convert(TxtFileDocu.Text)

        LblInfo.Text = "Documentation export finished"


        My.Settings.LastHeader = TxtHeader.Text
        My.Settings.LastFooter = TxtFooter.Text

        ' My.Settings.LastFolder = TxtTargetFolder.Text
        My.Settings.LastDocTitle = TxtDocTitle.Text
        My.Settings.Save()
    End Sub

    Private Sub CmdHeaderFile_Click(sender As Object, e As EventArgs) Handles CmdHeaderFile.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Filter = "*.html|*.html"
            If .ShowDialog Then
                TxtHeader.Text = .FileName
            End If
        End With
    End Sub

    Private Sub CmdFooterFile_Click(sender As Object, e As EventArgs) Handles CmdFooterFile.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Filter = "*.html|*.html"
            If .ShowDialog Then
                TxtFooter.Text = .FileName
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
End Class