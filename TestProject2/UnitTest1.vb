Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports WordsFinder

Namespace TestProject2
    <TestClass>
    Public Class UnitTest1
        <TestMethod>
        Sub TestSub()
            Dim co As New CommentOut_VB("'", """", """")
            Dim result As String = co.ExtractActiveCode("aaaa'aaaa")
            Assert.AreEqual(result, "aaaa")

        End Sub
    End Class
End Namespace

