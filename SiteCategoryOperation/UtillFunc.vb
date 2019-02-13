Imports ClosedXML.Excel

Public Class UtillFunc

    ' Ecxelワークブックから、サイトカテゴリクラスのリストを生成する関数
    Public Function ExceltoSiteCategoryList(wb As XLWorkbook) As ArrayList

        '戻り値用リスト
        Dim catList As New ArrayList

        '開始行
        Dim cnt As Integer
        cnt = 13

        '処理終了フラグ
        Dim exeflg As Boolean
        exeflg = True

        ' 空白判定用変数
        Dim b As Integer
        b = 5

        Using wb
            Dim ws = wb.Worksheet("サイトカテゴリ設計")

            ' 行情報をCategoryクラスに変換
            While ws.Cell(cnt, 12).Value <> "" Or ws.Cell(cnt, 13).Value <> "" Or ws.Cell(cnt, 14).Value <> "" Or ws.Cell(cnt, 15).Value <> "" Or ws.Cell(cnt, 16).Value <> "" Or ws.Cell(cnt, 17).Value <> "" Or ws.Cell(cnt, 18).Value <> "" Or ws.Cell(cnt, 19).Value <> "" Or ws.Cell(cnt, 20).Value <> ""

                Dim cat As New SiteCategory
                Dim list As New ArrayList

                '親カテゴリID, カテゴリ名以外の基本情報を格納
                cat.SetcatId(ws.Cell(cnt, 2).Value)
                cat.SetcatUrl(ws.Cell(cnt, 3).Value)
                cat.SetfileServerUrl(ws.Cell(cnt, 4).Value)
                cat.SetorderLnNo(ws.Cell(cnt, 5).Value)
                cat.SetbgColor(ws.Cell(cnt, 6).Value)
                cat.SetcharSetCd(ws.Cell(cnt, 7).Value)
                cat.SetuseCd(ws.Cell(cnt, 8).Value)
                cat.SetuseRSS(ws.Cell(cnt, 9).Value)
                cat.SetversionCnt(ws.Cell(cnt, 10).Value)
                cat.SetdirNm(ws.Cell(cnt, 11).Value)

                'アクションフィールドを取得
                cat.SetafieldId_01(ws.Cell(cnt, 21).Value)
                cat.SetafieldId_02(ws.Cell(cnt, 22).Value)
                cat.SetafieldId_03(ws.Cell(cnt, 23).Value)

                '親カテゴリID, カテゴリ名の取得
                Dim search As Integer
                search = cnt
                Dim i As Integer
                i = 12

                While i <= 20
                    If i = 12 Then
                        cat.SetcatNm(ws.Cell(cnt, i).Value)
                        cat.SetupCatId("scat")
                    ElseIf ws.Cell(cnt, i).Value <> "" Then
                        cat.SetcatNm(ws.Cell(cnt, i).Value)
                        While ws.Cell(search - 1, i - 1).Value = ""
                            search -= 1
                        End While
                        '親カテゴリID格納
                        cat.SetupCatId(ws.Cell(search - 1, 2).Value)
                    End If
                    i += 1
                End While

                cnt += 1

                'サイトカテゴリリストに作成したカテゴリ情報を格納
                catList.Add(cat)

            End While

        End Using

        ExceltoSiteCategoryList = catList

    End Function

    ' サイトカテゴリリストから、XMLファイルを生成する関数
    Public Sub SiteCategoryListtoXML(catList As ArrayList, export_filepath As String)

        Dim fileName As String = "\site_category"

        '保存しようとしたファイル名と既に同じファイル名が存在するならば、ファイル名末尾に(k)をつける
        If Dir(export_filepath & fileName & ".xml") <> "" Then
            Dim k As Integer
            k = 1

            While Dir(export_filepath & fileName & ".xml") <> ""
                fileName = "\site_category" & " (" & k & ")"
                k += 1
            End While
        End If

        Dim sw As New System.IO.StreamWriter(export_filepath & fileName & ".xml", False, System.Text.Encoding.GetEncoding("utf-8"))

        sw.Write("<?xml version=""1.0"" encoding=""UTF-8""?>" & vbCrLf)
        sw.Write("<root>" & vbCrLf)

        For Each cat As SiteCategory In catList
            sw.Write("    <category bgColor=""" & cat.GetbgColor & """ catId=""" & cat.GetcatId & """ charSetCd=""" & cat.GetcharSetCd & """ orderLnNo=""" & cat.GetorderLnNo & """ upperCatId=""" & cat.GetupCatId & """ useCd=""" & cat.GetuseCd & """ useRSS=""" & cat.GetuseRSS & """ versionCnt=""0"">" & vbCrLf)
            sw.Write("        <catNm><![CDATA[" & cat.GetcatNm & "]]></catNm>" & vbCrLf)
            sw.Write("        <phyDirNm><![CDATA[" & cat.GetdirNm & "]]></phyDirNm>" & vbCrLf)
            sw.Write("        <catExp/>" & vbCrLf)
            sw.Write("        <catUrl><![CDATA[" & cat.GetcatUrl & "]]></catUrl>" & vbCrLf)
            sw.Write("        <fileServerUrl><![CDATA[" & cat.GetfileServerUrl & "]]></fileServerUrl>" & vbCrLf)
            If cat.GetafieldId_01 <> "" Or cat.GetafieldId_02 <> "" Or cat.GetafieldId_03 <> "" Then
                sw.Write("        <afields>" & vbCrLf)
                If cat.GetafieldId_01 <> "" Then
                    sw.Write("            <afield afieldId=""" & cat.GetafieldId_01 & """ orderLnNo=""1""/>" & vbCrLf)
                End If
                If cat.GetafieldId_02 <> "" Then
                    sw.Write("            <afield afieldId=""" & cat.GetafieldId_02 & """ orderLnNo=""2""/>" & vbCrLf)
                End If
                If cat.GetafieldId_03 <> "" Then
                    sw.Write("            <afield afieldId=""" & cat.GetafieldId_03 & """ orderLnNo=""3""/>" & vbCrLf)
                End If
                sw.Write("        </afields>" & vbCrLf)
            Else
                sw.Write("        <afields/>" & vbCrLf)
            End If
            sw.Write("        <metafields/>" & vbCrLf)
            sw.Write("        <forwardcats/>" & vbCrLf)
            sw.Write("        <deliverycats/>" & vbCrLf)
            sw.Write("    </category>" & vbCrLf)
        Next

        sw.Write("</root>" & vbCrLf)

        '閉じる
        sw.Close()
    End Sub

    ' サイトカテゴリリストから、テスト仕様書を生成する関数
    Public Sub SiteCategoryListtoTest(project As String, catList As ArrayList, export_filepath As String)

        '雛形ファイルを開く
        Dim base As New ClosedXML.Excel.XLWorkbook(My.Application.Info.DirectoryPath & "\TestBase\site_base.xlsx")

        'シートを取得
        Dim sheet As ClosedXML.Excel.IXLWorksheet = base.Worksheet("サイトカテゴリ")

        'ヘッダーを入力
        sheet.Cell("A2").Value = project
        sheet.Cell("B2").Value = ""
        sheet.Cell("C2").Value = DateTime.Today
        sheet.Cell("B4").Value = "-"
        sheet.Cell("C4").Value = "-"
        sheet.Cell("A6").Value = "-"
        sheet.Cell("B6").Value = "-"
        sheet.Cell("C6").Value = "-"

        'なぜかセルの書式設定が2行目以降反映されないので解決策
        '1行目のセルを2行目以降にコピー
        Dim count As Integer : count = 0
        Dim copy As IXLRange = sheet.Range("A10:J10") 'コピー範囲
        Dim paste As IXLRange '貼り付け範囲
        For Each cat As SiteCategory In catList
            count = count + 1

            paste = sheet.Range("A" & (count + 9) & ":J" & (count + 9)) '貼り付け範囲取得
            copy.CopyTo(paste) 'コピー
        Next

        'テスト項目を入力
        count = 0 'インデックス初期化
        For Each cat As SiteCategory In catList
            count = count + 1

            sheet.Cell("A" & (count + 9)).Value = "SC_" & count 'テストID
            sheet.Cell("B" & (count + 9)).Value = cat.catNm 'カテゴリ名
            sheet.Cell("C" & (count + 9)).Value = cat.catId 'カテゴリID
            sheet.Cell("D" & (count + 9)).Value = "サイトカテゴリ設計書通り設定されている" '期待結果
            sheet.Cell("E" & (count + 9)).Value = "" '確認日
            sheet.Cell("F" & (count + 9)).Value = "" '確認者
            sheet.Cell("G" & (count + 9)).Value = "" '修正確認日
            sheet.Cell("H" & (count + 9)).Value = "" '修正確認者
            sheet.Cell("I" & (count + 9)).Value = "" '判定
            sheet.Cell("J" & (count + 9)).Value = "" '備考
        Next

        Dim fileName As String = "\サイトカテゴリテスト仕様書"

        '保存しようとしたファイル名と既に同じファイル名が存在するならば、ファイル名末尾に(k)をつける
        If Dir(export_filepath & fileName & ".xlsx") <> "" Then
            Dim k As Integer
            k = 1

            While Dir(export_filepath & fileName & ".xlsx") <> ""
                fileName = "\サイトカテゴリテスト仕様書" & " (" & k & ")"
                k += 1
            End While
        End If

        '保存
        base.SaveAs(export_filepath & fileName & ".xlsx")

    End Sub

End Class
