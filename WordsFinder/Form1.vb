Imports System.IO
Imports ClosedXML.Excel
Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim co As New CommentOut_VB("'", """", """")

        'If Not Directory.Exists(txtRootDirectory.Text) Then
        '    MessageBox.Show("指定されたディレクトリが存在しません。")
        '    Exit Sub
        'End If

        'Search(txtSearchWord.Text, txtRootDirectory.Text)

        ' Excel出力
        'ExportToExcel()
    End Sub
    Private Sub Search(searchWord As String, rootDir As String)

        ' まずは１つのディレクトリを読み取る検証
        Dim files = Directory.GetFiles(rootDir, "*.*") ' SearchOption.AllDirectoriesとすると、配下のファイルがすべて取得できるが、除外フォルダを指定したいため１ディレクトリずつ取得していくこととする。

        For Each file As String In files
            SearchWordInFile(file, searchWord)
        Next
    End Sub

    Private Sub SearchWordInFile(fileName As String, word As String)
        Try
            Dim lines = File.ReadAllLines(fileName)

            For i As Integer = 0 To lines.Length - 1
                Dim line = lines(i).Trim()

                ' 指定した単語を検索
                If line.Contains(word) Then
                    Debug.Print("hit in " & fileName)
                    Debug.Print("in line " & CStr(i + 1))
                    'add the word to List
                End If
            Next
        Catch ex As Exception
            'add error message to List
            Debug.Print($"Error reading file {fileName}: {ex.Message}")
        End Try
    End Sub


    Private Sub ExportToExcel()
        Dim fileName As String = MakeExcelFileName()
        Dim savePath As String = Path.Combine(
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads"),
            fileName
        )

        Dim workbook As New XLWorkbook()
        Dim worksheet = workbook.Worksheets.Add("Results")

        workbook.SaveAs(savePath)
        MessageBox.Show($"検索結果を {savePath} に保存しました。")
    End Sub

    Private Function MakeExcelFileName() As String
        Dim searchWord As String = "SearchResults" '検索ワードを後から引数としてとるように変更予定
        Dim timestamp As String = DateTime.Now.ToString("yyyyMMddHHmmss")
        Dim fileName As String = $"{searchWord}_{timestamp}.xlsx"
        Return fileName
    End Function

    Private Sub BtnChooseDirectory_Click(sender As Object, e As EventArgs) Handles BtnChooseDirectory.Click
        Using folderDialog As New FolderBrowserDialog()
            folderDialog.Description = "検索するディレクトリを選択してください"
            folderDialog.ShowNewFolderButton = False ' 新しいフォルダの作成を許可しない

            If folderDialog.ShowDialog() = DialogResult.OK Then
                txtRootDirectory.Text = folderDialog.SelectedPath
            End If
        End Using
    End Sub
End Class