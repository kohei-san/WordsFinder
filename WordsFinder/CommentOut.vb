Public Class CommentOut
    Protected Property ActiveCode As String ' コメントアウトされていない、有効なコードを格納
    Protected Property InCommentOut As Boolean = False ' コメントアウト状態を表す
    Protected Property InLiteral As Boolean = False ' 文字列であることを表す（trueの間は、コメントアウトの判定を停止）
    Protected Property StringToBeginCommentOutOneRow As String ' 1行コメントアウト開始の文字列
    Protected Property StringToBeginMultilineComment As String ' 複数行コメントアウト開始文字列
    Protected Property StringToEndMultilineComment As String ' 複数行コメントアウト終了文字列
    Protected Property CharToEncloseLiteral As Char ' 文字列開始、終了の文字'
    Protected Property CharToEscape As Char 'エスケープ文字を指定。この文字の次の文字がCharToEncloseLiteralの文字でも文字列を終了しない（InLiteralをfalseにしない）。

    Public Sub New()
        ' Do Nothing
    End Sub

    Protected Function ExtractActiveCode(str As String)
        Return str
    End Function

    Public Sub ResetActiveCode()
        ActiveCode = ""
    End Sub
End Class
