Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Runtime
Imports inoPBIDLL
Imports NUnit.Framework
Imports NUnit.Framework.Internal

Namespace TestInoPBI
    Public Class TestClsJSONHandling
        Private testPath As String = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)).Replace("\bin", "")
        'Private DBFile As String = testPath & "\TestData\DB\pfalzenCurrentDB.accdb"
        Private cJSON As ClsJSONHandling
        Private cHelper As New ClsHelper
        Private testFolder As String
        Private DBFileTest As String

        <SetUp>
        Public Sub Setup()
            testFolder = cHelper.CreateTestFolder("currenttestdata")
            cHelper.DeleteTestFolder(testFolder)
            'DBFileTest = testFolder & "\pfalzenCurrentDB.accdb"
            'File.Copy(DBFile, DBFileTest)
            cJSON = New ClsJSONHandling
        End Sub

        <TearDown>
        Public Sub TearDown()
            cHelper.DeleteTestFolder(testFolder)
        End Sub

        <Test>
        Public Sub TestSplitLine()
            Dim strLine As String = "      Quelle = Excel.Workbook(Web.Contents(SharepointOrdner & ""Definitionen.xlsx""), null, true),"
            Dim strResult As String = "      Quelle = Excel.Workbook(Web.Contents(SharepointOrdner & ""Definitionen.xlsx""), null," & vbCrLf & "         true),"
            Dim result As String = cJSON.splitLine(strLine)

            Assert.That(result, NUnit.Framework.Is.EqualTo(strResult))

            strLine = "      Quelle = Excel.Workbook(Web.Contents(SharepointOrdner & ""Definitionen.xlsx"")"
            strResult = "      Quelle = Excel.Workbook(Web.Contents(SharepointOrdner & ""Definitionen.xlsx"")"
            result = cJSON.splitLine(strLine)

            Assert.That(result, NUnit.Framework.Is.EqualTo(strResult))

            strLine = "      Quelle = Excel.Workbook(Web.Contents(SharepointOrdner & ""Definitionen.xlsx""), null, true), Quelle = Excel.Workbook(Web.Contents(SharepointOrdner & ""Definitionen.xlsx""), null, true),"
            strResult = "      Quelle = Excel.Workbook(Web.Contents(SharepointOrdner & ""Definitionen.xlsx""), null," & vbCrLf & "         true), Quelle = Excel.Workbook(Web.Contents(SharepointOrdner &" & vbCrLf & "         ""Definitionen.xlsx""), null, true),"

            Console.WriteLine(result)
            Assert.That(result, NUnit.Framework.Is.EqualTo(strResult))

        End Sub
    End Class
End Namespace

