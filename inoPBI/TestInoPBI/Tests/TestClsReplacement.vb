Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Runtime
Imports inoPBIDLL
Imports NUnit.Framework
Imports NUnit.Framework.Internal

Namespace TestInoPBI
    Public Class TestClsReplacement
        Private testPath As String = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)).Replace("\bin", "")
        'Private DBFile As String = testPath & "\TestData\DB\pfalzenCurrentDB.accdb"
        Private cRep As ClsReplacement
        Private cHelper As New ClsHelper
        Private testFolder As String
        Private DBFileTest As String

        <SetUp>
        Public Sub Setup()
            testFolder = cHelper.CreateTestFolder("currenttestdata")
            cHelper.DeleteTestFolder(testFolder)
            'DBFileTest = testFolder & "\pfalzenCurrentDB.accdb"
            'File.Copy(DBFile, DBFileTest)
            cRep = New ClsReplacement
        End Sub

        <TearDown>
        Public Sub TearDown()
            cHelper.DeleteTestFolder(testFolder)
        End Sub

        <Test>
        Public Sub TestGetReplacements()
            Dim strFile As String = "\TestData\testDataReplacement.txt"
            Dim cr As Collection(Of ClsReplacement.Replacement) = cRep.GetReplacements(testPath & strFile)

            Assert.AreEqual(4, cr.Count)
            Assert.AreEqual("HRworksOrdner", cr.Item(0).Title)
        End Sub

        <Test>
        Public Sub TestReplaceReferences()
            Dim strFile As String = testPath & "\TestData\test.bim"
            Dim strFileOut As String = testFolder & "\testout.bim"
            Dim strReplacement As String = testPath & "\TestData\testDataReplacement.txt"

            Dim cr As Collection(Of ClsReplacement.Replacement) = cRep.GetReplacements(strReplacement)

            Assert.True(cRep.ReplaceReferences(strFile, strReplacement, strFileOut))

            Dim strTest As String
            Using sr As New StreamReader(strFileOut)
                strTest = sr.ReadToEnd
            End Using

            For testCount As Integer = 0 To cr.Count - 1
                Assert.True(strTest.Contains(cr.Item(testCount).Title))
                Assert.False(strTest.Contains(cr.Item(testCount).StrFrom))
                Assert.True(strTest.Contains(cr.Item(testCount).StrTo))
            Next
        End Sub

        <Test>
        Public Sub TestReplaceReferencesError()
            Dim strFile As String = testPath & "\TestData\test1.bim"
            Dim strFileOut As String = testFolder & "\testout.bim"
            Dim strReplacement As String = testPath & "\TestData\testDataReplacement.txt"

            Assert.False(cRep.ReplaceReferences(strFile, strReplacement, strFileOut))

            strFile = testPath & "\TestData\test.bim"
            strReplacement = testPath & "\TestData\testDataReplacementE1.txt"

            Assert.False(cRep.ReplaceReferences(strFile, strReplacement, strFileOut))

            strFile = testPath & "\TestData\test.bim"
            strReplacement = testPath & "\TestData\testDataReplacementE2.txt"

            Assert.False(cRep.ReplaceReferences(strFile, strReplacement, strFileOut))

        End Sub

        <Test>
        Public Sub TestExtractMeasures()
            Dim strFile As String = testPath & "\TestData\test.bim"
            Dim strFileOut As String = testFolder & "\testmeasures.md"

            Assert.True(cRep.ExtractMeasures(strFile, strFileOut))


        End Sub
    End Class
End Namespace
