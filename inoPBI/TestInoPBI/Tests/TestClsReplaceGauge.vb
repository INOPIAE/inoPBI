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
    Public Class TestClsReplaceGauge
        Private testPath As String = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)).Replace("\bin", "")
        'Private DBFile As String = testPath & "\TestData\DB\pfalzenCurrentDB.accdb"
        Private cRepG As ClsReplaceGauge
        Private cHelper As New ClsHelper
        Private testFolder As String
        Private DBFileTest As String

        <SetUp>
        Public Sub Setup()
            testFolder = cHelper.CreateTestFolder("currenttestdata")
            cHelper.DeleteTestFolder(testFolder)
            'DBFileTest = testFolder & "\pfalzenCurrentDB.accdb"
            'File.Copy(DBFile, DBFileTest)
            cRepG = New ClsReplaceGauge
        End Sub

        <TearDown>
        Public Sub TearDown()
            cHelper.DeleteTestFolder(testFolder)
        End Sub

        <Test>
        Public Sub TestValueInRange()
            Dim Value As Decimal = 250
            Dim TestValue As Decimal = 253
            Dim Range As Decimal = 5

            Dim TestResult As Boolean = cRepG.ValueInRange(Value, TestValue, Range)

            Assert.That(TestValue, True)

            Range = 4
            TestResult = cRepG.ValueInRange(Value, TestValue, Range)
            Assert.That(TestValue, True)

            Range = 3
            TestResult = cRepG.ValueInRange(Value, TestValue, Range)
            Assert.That(TestValue, True)

            Range = 2
            TestResult = cRepG.ValueInRange(Value, TestValue, Range)
            Assert.That(TestValue, False)
        End Sub

        <Test>
        Public Sub TestReplaceNumValue()
            Dim strLine As String = "            ""height"": 400.00,"
            Dim strValue As String = """height"": "
            Dim Rep As New ClsReplacementNum

            Rep.FromV = 400
            Rep.ToV = 420
            Rep.Range = 3

            Dim strTest As String = cRepG.ReplaceNumValue(strLine, strValue, Rep)
            Assert.That(strTest, Does.Not.Contain("""height"": 400.00,"))
            Assert.That(strTest, Does.Contain("""height"": 420,"))

            Rep.FromV = 403
            Rep.ToV = 420.25
            Rep.Range = 3

            strTest = cRepG.ReplaceNumValue(strLine, strValue, Rep)
            Assert.That(strTest, Does.Not.Contain("""height"": 400.00,"))
            Assert.That(strTest, Does.Contain("""height"": 420.25,"))

            Rep.FromV = 405
            Rep.ToV = 420.25
            Rep.Range = 3

            strTest = cRepG.ReplaceNumValue(strLine, strValue, Rep)
            Assert.That(strTest, Does.Contain("""height"": 400.00,"))
            Assert.That(strTest, Does.Not.Contain("""height"": 420.25,"))
        End Sub

        <Test>
        Public Sub TestReplaceStringValue()
            Dim strLine As String = "\""Tooltips\"":[{\""queryRef\"":\""_Measures.Ziele\""}],\""MaxValue\"":[{\""queryRef\"":\""_Measures.Max\""}]}"
            Dim strValue As String = "\""MaxValue\"":[{\""queryRef\"":\""XXX\""}]}"
            Dim Rep As New ClSReplacementStr

            Rep.FromStr = "_Measures.Max"
            Rep.ToStr = "_Measures.Max2"
            Rep.CaptionFrom = "Max"
            Rep.CaptionTo = "Max2"

            Dim strTest As String = cRepG.ReplaceStringValue(strLine, strValue, Rep)
            Assert.That(strTest, Does.Not.Contain("_Measures.Max\"))
            Assert.That(strTest, Does.Contain("_Measures.Max2\"))

            strLine = "{\""Measure\"":{\""Expression\"":{\""SourceRef\"":{\""Source\"":\""_\""}},\""Property\"":\""Max\""},\""Name\"":\""_Measures.Max\"",\""NativeReferenceName\"":\""Max\""}],"
            strValue = "\""YYY\""},\""Name\"":\""XXX\"",\""NativeReferenceName\"":\""YYY\""}"

            strTest = cRepG.ReplaceStringValue2(strLine, strValue, Rep)
            Assert.That(strTest, Does.Not.Contain("_Measures.Max\"))
            Assert.That(strTest, Does.Contain("_Measures.Max2\"))
            Assert.That(strTest, Does.Not.Contain("""Max\"))
            Assert.That(strTest, Does.Contain("""Max2\"))

            Rep.CaptionTo = "Max"
            strTest = cRepG.ReplaceStringValue2(strLine, strValue, Rep)
            Assert.That(strTest, Does.Not.Contain("_Measures.Max\"))
            Assert.That(strTest, Does.Contain("_Measures.Max2\"))
            Assert.That(strTest, Does.Not.Contain("""Max2\"))
            Assert.That(strTest, Does.Contain("""Max\"))
        End Sub
    End Class
End Namespace
