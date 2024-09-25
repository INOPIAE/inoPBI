Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Net.WebRequestMethods
Imports System.Runtime
Imports inoPBIDLL
Imports inoPBIDLL.ClsReplacement
Imports NUnit.Framework
Imports NUnit.Framework.Internal
Imports NUnit.Framework.Legacy

Namespace TestInoPBI
    Public Class TestClsReplacementInfo
        Private testPath As String = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)).Replace("\bin", "")
        'Private DBFile As String = testPath & "\TestData\DB\pfalzenCurrentDB.accdb"
        Private cRepI As ClsReplacementInfo
        Private cHelper As New ClsHelper
        Private testFolder As String
        Private DBFileTest As String

        <SetUp>
        Public Sub Setup()
            testFolder = cHelper.CreateTestFolder("currenttestdata")
            cHelper.DeleteTestFolder(testFolder)
            'DBFileTest = testFolder & "\pfalzenCurrentDB.accdb"
            'File.Copy(DBFile, DBFileTest)

        End Sub

        <TearDown>
        Public Sub TearDown()
            cHelper.DeleteTestFolder(testFolder)
        End Sub

        <Test>
        Public Sub TestGetValue()
            Dim strFile As String = testPath & "\TestData\ConfigLine.txt"
            Dim strLine As String
            Using sr As New StreamReader(strFile)
                strLine = sr.ReadToEnd
            End Using

            Dim strValue As String = "\""height\"":"
            cRepI = New ClsReplacementInfo(strValue, strLine)

            Dim testValue = cRepI.GetValue

            Assert.That(testValue, [Is].EqualTo("400"))
            Assert.That(cRepI.StartPos, [Is].EqualTo(126))
            Assert.That(cRepI.EndPos, [Is].EqualTo(140))


            strLine = "            ""height"": 400.00,"
            strValue = """height"":"
            cRepI = New ClsReplacementInfo(strValue, strLine)

            testValue = cRepI.GetValue

            Assert.That(testValue, [Is].EqualTo("400.00"))
            Assert.That(cRepI.StartPos, [Is].EqualTo(12))
            Assert.That(cRepI.EndPos, [Is].EqualTo(28))


            strLine = "            ""height"": 400.00,             ""height"": 500.00,"
            strValue = """height"":"
            cRepI = New ClsReplacementInfo(strValue, strLine)

            testValue = cRepI.GetValue
            Assert.That(testValue, [Is].EqualTo("400.00"))
            Assert.That(cRepI.StartPos, [Is].EqualTo(12))
            Assert.That(cRepI.EndPos, [Is].EqualTo(28))

            testValue = cRepI.GetValue(cRepI.EndPos)
            Assert.That(testValue, [Is].EqualTo("500.00"))
            Assert.That(cRepI.StartPos, [Is].EqualTo(42))
            Assert.That(cRepI.EndPos, [Is].EqualTo(58))
        End Sub

    End Class
End Namespace
