Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Runtime
Imports inoPBIDLL
Imports inoPBIDLL.ClsReplacement
Imports NUnit.Framework
Imports NUnit.Framework.Internal
Imports NUnit.Framework.Legacy

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

            ClassicAssert.AreEqual(4, cr.Count)
            ClassicAssert.AreEqual("HRworksOrdner", cr.Item(0).Title)
        End Sub

        <Test>
        Public Sub TestReplaceReferences()
            Dim strFile As String = testPath & "\TestData\test.bim"
            Dim strFileOut As String = testFolder & "\testout.bim"
            Dim strReplacement As String = testPath & "\TestData\testDataReplacement.txt"

            Dim cr As Collection(Of ClsReplacement.Replacement) = cRep.GetReplacements(strReplacement)

            ClassicAssert.True(cRep.ReplaceReferences(strFile, strReplacement, strFileOut))

            Dim strTest As String
            Using sr As New StreamReader(strFileOut)
                strTest = sr.ReadToEnd
            End Using

            For testCount As Integer = 0 To cr.Count - 1
                ClassicAssert.True(strTest.Contains(cr.Item(testCount).Title))
                ClassicAssert.False(strTest.Contains(cr.Item(testCount).StrFrom))
                ClassicAssert.True(strTest.Contains(cr.Item(testCount).StrTo))
            Next
        End Sub

        <Test>
        Public Sub TestReplaceReferencesError()
            Dim strFile As String = testPath & "\TestData\test1.bim"
            Dim strFileOut As String = testFolder & "\testout.bim"
            Dim strReplacement As String = testPath & "\TestData\testDataReplacement.txt"

            ClassicAssert.False(cRep.ReplaceReferences(strFile, strReplacement, strFileOut))

            strFile = testPath & "\TestData\test.bim"
            strReplacement = testPath & "\TestData\testDataReplacementE1.txt"

            ClassicAssert.False(cRep.ReplaceReferences(strFile, strReplacement, strFileOut))

            strFile = testPath & "\TestData\test.bim"
            strReplacement = testPath & "\TestData\testDataReplacementE2.txt"

            ClassicAssert.False(cRep.ReplaceReferences(strFile, strReplacement, strFileOut))

        End Sub

        <Test>
        Public Sub TestExtractMeasures()
            Dim strFile As String = testPath & "\TestData\test.bim"
            Dim strFileOut As String = testFolder & "\testmeasures.md"

            ClassicAssert.True(cRep.ExtractMeasures(strFile, strFileOut))


        End Sub


        <Test>
        Public Sub TestReplaceReferenceTMDL()
            Dim strFile As String = testPath & "\TestData\expressions.tmdl"
            Dim strFileOut As String = testFolder & "\testoutExpressions.tmdl"
            Dim strReplacement As String = testPath & "\TestData\testDataReplacementTDML.txt"

            Dim cr As Collection(Of ClsReplacement.Replacement) = cRep.GetReplacements(strReplacement)


            Assert.That(cRep.ReplaceReferenceTMDL(strFile, strReplacement, strFileOut), NUnit.Framework.Is.EqualTo(True))

            Dim strTest As String
            Using sr As New StreamReader(strFileOut)
                strTest = sr.ReadToEnd
            End Using

            For Each c As ClsReplacement.Replacement In cr
                Dim strFrom As String = c.Title & " = " & c.StrFrom
                Dim strTo As String = c.Title & " = " & c.StrTo
                Assert.That(strTest, Does.Contain(strTo))
                Assert.That(strTest, Does.Not.Contain(strFrom))
            Next

        End Sub
    End Class
End Namespace
