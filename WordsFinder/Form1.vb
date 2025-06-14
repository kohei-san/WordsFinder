Imports System.IO
Imports ClosedXML.Excel
Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        ' Excel出力
        ExportToExcel()
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