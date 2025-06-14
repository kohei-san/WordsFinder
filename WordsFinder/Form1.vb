Imports System.IO
Imports ClosedXML.Excel
Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        ' Excel出力
        ExportToExcel()
    End Sub

    Private Sub ExportToExcel()
        Dim savePath As String = Path.Combine(Application.StartupPath, "SearchResults.xlsx")
        Dim workbook As New XLWorkbook()
        Dim worksheet = workbook.Worksheets.Add("Results")

        workbook.SaveAs(savePath)
        MessageBox.Show($"検索結果を {savePath} に保存しました。")
    End Sub
End Class