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
            If chars(i) = CharToEncloseLiteral Then
                InLiteral = Not InLiteral
            End If

            If InLiteral = False Then
                If chars(i) = StringToBeginCommentOutOneRow Then
                    Exit For
                End If
            End If
            ActiveCode += chars(i)
        Next
        Return ActiveCode
    End Function
End Class
