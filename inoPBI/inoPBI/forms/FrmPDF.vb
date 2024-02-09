
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
        CbShowPDF.Checked = My.Settings.ShowPDF

        LblInfo.Text = ""
    End Sub

    Private Async Sub CmdDocumentation_Click(sender As Object, e As EventArgs) Handles CmdDocumentation.Click

        If TxtFileDocu.Text = vbNullString Then
            MessageBox.Show("No file given.")
            TxtFileDocu.Select()
            Exit Sub
        End If
        Dim PdFOutput As String = TxtFileDocu.Text.Replace(".md", ".pdf")

        If FileInUse(PdFOutput) = True Then
            MessageBox.Show("PDF file in use.")
            Exit Sub
        End If

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

        ' mdOptions.KeepHtml = True
        '   IsLandscape = True,
        '};

        Dim mdconvert As New Markdown2PdfConverter(mdOptions)

        Dim strPDF = Await mdconvert.Convert(TxtFileDocu.Text)

        LblInfo.Text = "Documentation export finished"


        My.Settings.LastHeader = TxtHeader.Text
        My.Settings.LastFooter = TxtFooter.Text

        ' My.Settings.LastFolder = TxtTargetFolder.Text
        My.Settings.LastDocTitle = TxtDocTitle.Text
        My.Settings.ShowPDF = CbShowPDF.Checked
        My.Settings.Save()

        If CbShowPDF.Checked Then
            Dim p = New Process()
            p.StartInfo = New ProcessStartInfo(PdFOutput)
            p.StartInfo.UseShellExecute = True
            p.Start()
        End If
    End Sub

    Private Sub CmdHeaderFile_Click(sender As Object, e As EventArgs) Handles CmdHeaderFile.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Filter = "*.html|*.html"
            .Multiselect = False
            If .ShowDialog = DialogResult.OK Then
                TxtHeader.Text = .FileName
            End If
        End With
    End Sub

    Private Sub CmdFooterFile_Click(sender As Object, e As EventArgs) Handles CmdFooterFile.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Filter = "*.html|*.html"
            .Multiselect = False
            If .ShowDialog = DialogResult.OK Then
                TxtFooter.Text = .FileName
            End If
        End With
    End Sub

    Private Sub CmdFileDocu_Click(sender As Object, e As EventArgs) Handles CmdFileDocu.Click
        Dim sfd As New SaveFileDialog
        With sfd
            .Filter = "*.md|*.md"
            If .ShowDialog = DialogResult.OK Then
                TxtFileDocu.Text = .FileName
            End If
        End With
    End Sub

    Private Sub CmdFolderTarget_Click(sender As Object, e As EventArgs) Handles CmdFolderTarget.Click

    End Sub
End Class