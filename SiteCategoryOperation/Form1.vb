Imports ClosedXML.Excel

Public Class SiteCategoryOperation

    '設計書のパス格納用変数
    Private ddpath = ""
    'エクスポートしたXMLファイルのパス格納用変数
    Private exported_xmlpath = ""
    '出力ファイルのパス格納用変数
    Private export_filepath = ""

    Public utilfunc As New UtillFunc


    Private Sub ExeMenu03_CheckedChanged(sender As Object, e As EventArgs) Handles ExeMenu03.CheckedChanged
        If ExeMenu03.Checked Then
            Label4.Enabled = True
            XMLPath.Enabled = True
            RefButton2.Enabled = True
        Else
            Label4.Enabled = False
            XMLPath.Enabled = False
            RefButton2.Enabled = False
        End If
    End Sub


    ' 【1つ目の参照ボタン押下時の処理】
    Private Sub RefButton1_Click(sender As Object, e As EventArgs) Handles RefButton1.Click
        Dim fcd As New OpenFileDialog()
        fcd.InitialDirectory = "C:\"
        fcd.Title = "使用するサイトカテゴリ設計書を選択してください"

        If fcd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する
            TextBox1.Text = fcd.FileName
        End If

        ddpath = TextBox1.Text

    End Sub

    ' 【2つ目の参照ボタン押下時の処理】
    Private Sub RefButton2_Click(sender As Object, e As EventArgs) Handles RefButton2.Click
        Dim fcd As New OpenFileDialog()
        fcd.InitialDirectory = "C:\"
        fcd.Title = "使用するサイトカテゴリ設計書を選択してください"

        If fcd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する
            XMLPath.Text = fcd.FileName
        End If

        exported_xmlpath = XMLPath.Text

    End Sub

    ' 【3つ目の参照ボタン押下時の処理】
    Private Sub RefButton3_Click(sender As Object, e As EventArgs) Handles RefButton3.Click
        Dim fbd As New FolderBrowserDialog()
        fbd.SelectedPath = "C:\"
        fbd.Description = "保存するフォルダを選択してください"

        If fbd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する
            TextBox2.Text = fbd.SelectedPath
        End If

        export_filepath = TextBox2.Text

    End Sub

    ' 【キャンセルボタン押下時の処理】
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Me.Close()
    End Sub


    ' 【処理実行ボタン押下時の処理】
    Private Sub ExecuteButton_Click(sender As Object, e As EventArgs) Handles ExecuteButton.Click

        '【インポートXMLの作成処理】
        If ExeMenu01.Checked Then

            '処理関数呼び出し
            Call CreateImportXML(ddpath, export_filepath)

            MsgBox("インポートXMLを作成しました。")
        End If


        '【テスト仕様書作成処理】
        If ExeMenu02.Checked Then

            '処理関数呼び出し
            Call CreateTestSpecification(ddpath, export_filepath)

            MsgBox("テスト仕様書を作成しました。")
        End If

        '【テスト実施処理】
        If ExeMenu03.Checked Then

            '処理関数呼び出し
            Call TestExecute(ddpath, exported_xmlpath, export_filepath)

            MsgBox("テストを実施し、テスト仕様書を作成しました。")
        End If

    End Sub

    'インポートXMLの作成関数
    Private Sub CreateImportXML(ddpath As String, export_filepath As String)

        ' 対象ワークブックの取得
        Dim wb As XLWorkbook = New XLWorkbook(ddpath)
        ' サイトカテゴリリストの作成
        Dim catList As New ArrayList
        catList = utilfunc.ExceltoSiteCategoryList(wb)
        ' XMLファイル生成
        utilfunc.SiteCategoryListtoXML(catList, export_filepath)

    End Sub


    'テスト仕様書作成関数
    Private Sub CreateTestSpecification(ddpath As String, export_filepath As String)

        ' 対象ワークブックの取得
        Dim wb As XLWorkbook = New XLWorkbook(ddpath)
        Dim ws = wb.Worksheet("サイトカテゴリ設計")

        ' プロジェクト名取得
        Dim projectName As String
        projectName = ws.Cell("D2").Value

        ' サイトカテゴリリストの作成
        Dim catList As New ArrayList
        catList = utilfunc.ExceltoSiteCategoryList(wb)

        'テスト仕様書生成
        utilfunc.SiteCategoryListtoTest(projectName, catList, export_filepath)

    End Sub


    'テスト実施関数
    Private Sub TestExecute(ddpath As String, exported_xmlpath As String, export_filepath As String)

    End Sub

    Private Sub SiteCategoryOperation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

