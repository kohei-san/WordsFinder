Public Class CommentOut
    Private Property ActiveCode As String ' コメントアウトされていない、有効なコードを格納
    Private Property InCommentOut As Boolean = False ' コメントアウト状態を表す
    Private Property InLiteral As Boolean = False ' 文字列であることを表す（trueの間は、コメントアウトの判定を停止）
    Private Property StringToBeginCommentOutOneRow As String ' 1行コメントアウト開始の文字列
    Private Property StringToBeginMultilineComment As String ' 複数行コメントアウト開始文字列
    Private Property StringToEndMultilineComment As String ' 複数行コメントアウト終了文字列
    Private Property CharToEncloseLiteral As Char ' 文字列開始、終了の文字'
    Private Property CharToEscape As Char 'エスケープ文字を指定。この文字の次の文字がCharToEncloseLiteralの文字でも文字列を終了しない（InLiteralをfalseにしない）。

    Sub New(commentStart As String, charForLiteral As Char, charEscape As Char, Optional mulitStart As String = "", Optional multiEnd As String = "")
        StringToBeginCommentOutOneRow = commentStart
        StringToBeginMultilineComment = mulitStart
        StringToEndMultilineComment = multiEnd
        CharToEncloseLiteral = charForLiteral
        CharToEscape = charEscape
    End Sub

    Private Function ExtractActiveCode(str As String)
        Return str
    End Function
End Class
