Public Class CommentOut_VB
    Inherits CommentOut

    Public Sub New(commentStart As String, charForLiteral As Char, charEscape As Char)
        StringToBeginCommentOutOneRow = commentStart
        CharToEncloseLiteral = charForLiteral
        CharToEscape = charEscape
    End Sub
End Class
