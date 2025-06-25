Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports WordsFinder

Namespace TestProject2
    <TestClass>
    Public Class VBCode_CommentOutTest
        <TestMethod>
        Sub Test()
            Call GetActiveCode_1_NomalCase()
            Call GetActiveCode_2_InLiteral()
            Call GetActiveCode_3_OutOfLiteral()
            Call GetActiveCode_4_NoCommentOut()
        End Sub
        Sub GetActiveCode_1_NomalCase()
            Dim co As New CommentOut_VB("'", """", """")
            Dim result As String = co.ExtractActiveCode("aaaa'aaaa")
            Assert.AreEqual(result, "aaaa")
        End Sub

        Sub GetActiveCode_2_InLiteral()
            Dim co As New CommentOut_VB("'", """", """")
            Dim result As String = co.ExtractActiveCode("aa""aa'aa""aa")
            Assert.AreEqual(result, "aa""aa'aa""aa")
        End Sub
        Sub GetActiveCode_3_OutOfLiteral()
            Dim co As New CommentOut_VB("'", """", """")
            Dim result As String = co.ExtractActiveCode("aa""aa"" 'aa")
            Assert.AreEqual(result, "aa""aa"" ")
        End Sub

        Sub GetActiveCode_4_NoCommentOut()
            Dim co As New CommentOut_VB("'", """", """")
            Dim result As String = co.ExtractActiveCode("aa""aa"" aa")
            Assert.AreEqual(result, "aa""aa"" aa")
        End Sub
    End Class
End Namespace

