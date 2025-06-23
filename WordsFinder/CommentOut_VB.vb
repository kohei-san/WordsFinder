Public Class CommentOut_VB
    Inherits CommentOut

    Public Sub New(commentStart As String, charForLiteral As Char, charEscape As Char)
        StringToBeginCommentOutOneRow = commentStart
        CharToEncloseLiteral = charForLiteral
        CharToEscape = charEscape
    End Sub

    Public Overloads Function ExtractActiveCode(str As String)
        Dim chars() As Char = str.ToCharArray
        Dim i As Integer
        For i = 0 To UBound(chars)
            Console.WriteLine(chars(i))
        Next
        Return "aaaa"
    End Function
End Class
