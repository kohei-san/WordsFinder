Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports WordsFinder

Namespace TestProject2
    <TestClass>
    <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
    Public Class VBCode_CommentOutTest
        Dim co As CommentOut_VB
        <TestMethod>
        Sub Test()
            co = New CommentOut_VB("'", """", """")
            Call GetActiveCode_1_NomalCase()
            Call GetActiveCode_2_InLiteral()
            Call GetActiveCode_3_OutOfLiteral()
            Call GetActiveCode_4_NoCommentOut()
        End Sub
        Sub GetActiveCode_1_NomalCase()
            Dim result As String = co.ExtractActiveCode("aaaa'aaaa")
            Assert.AreEqual(result, "aaaa")
            co.ResetActiveCode()
        End Sub

        Sub GetActiveCode_2_InLiteral()
            Dim result As String = co.ExtractActiveCode("aa""aa'aa""aa")
            Assert.AreEqual(result, "aa""aa'aa""aa")
            co.ResetActiveCode()
        End Sub
        Sub GetActiveCode_3_OutOfLiteral()
            Dim result As String = co.ExtractActiveCode("aa""aa"" 'aa")
            Assert.AreEqual(result, "aa""aa"" ")
            co.ResetActiveCode()
        End Sub

        Sub GetActiveCode_4_NoCommentOut()
            Dim result As String = co.ExtractActiveCode("aa""aa"" aa")
            Assert.AreEqual(result, "aa""aa"" aa")
            co.ResetActiveCode()
        End Sub

        Private Function GetDebuggerDisplay() As String
            Return ToString()
        End Function
    End Class
End Namespace

