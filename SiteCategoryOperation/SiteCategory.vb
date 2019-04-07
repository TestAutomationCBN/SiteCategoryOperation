'サイトカテゴリクラス

Public Class SiteCategory

    ' サイトURL
    Public catUrl As String

    ' ファイルサーバのURL
    Public fileServerUrl As String

    ' カテゴリ色
    Public bgColor As String

    ' カテゴリID
    Public catId As String

    ' カテゴリ整列値
    Public orderLnNo As String

    ' 上位カテゴリID
    Public upCatId As String

    ' カテゴリ名
    Public catNm As String

    ' ディレクトリ名
    Public dirNm As String

    ' カテゴリタイプ
    Public useCd As String

    ' 文字セット
    Public charSetCd As String

    ' RSS URL
    Public useRSS As String

    ' バージョンルール
    Public versionCnt As String

    ' アクションフィールドID01
    Public afieldId_01 As String

    ' アクションフィールドID02
    Public afieldId_02 As String

    ' アクションフィールドID03
    Public afieldId_03 As String

    'メタ情報のリスト
    Public metaList As ArrayList

    'コンテンツ自動読み込みのリスト
    Public conList As ArrayList



    ' サイトURLのGetter/Setter
    Public Function GetcatUrl() As String
        GetcatUrl = Me.catUrl
    End Function

    Public Sub SetcatUrl(arg As String)
        Me.catUrl = arg
    End Sub

    ' ファイルサーバのURLのGetter/Setter
    Public Function GetfileServerUrl() As String
        GetfileServerUrl = Me.fileServerUrl
    End Function

    Public Sub SetfileServerUrl(arg As String)
        Me.fileServerUrl = arg
    End Sub

    ' カテゴリ色のGetter/Setter
    Public Function GetbgColor() As String
        GetbgColor = Me.bgColor
    End Function

    Public Sub SetbgColor(arg As String)
        Me.bgColor = arg
    End Sub

    ' カテゴリIDのGetter/Setter
    Public Function GetcatId() As String
        GetcatId = Me.catId
    End Function

    Public Sub SetcatId(arg As String)
        Me.catId = arg
    End Sub

    ' カテゴリ整列値のGetter/Setter
    Public Function GetorderLnNo() As String
        GetorderLnNo = Me.orderLnNo
    End Function

    Public Sub SetorderLnNo(arg As String)
        Me.orderLnNo = arg
    End Sub

    ' 上位カテゴリIDのGetter/Setter
    Public Function GetupCatId() As String
        GetupCatId = Me.upCatId
    End Function

    Public Sub SetupCatId(arg As String)
        Me.upCatId = arg
    End Sub

    ' カテゴリ名のGetter/Setter
    Public Function GetcatNm() As String
        GetcatNm = Me.catNm
    End Function

    Public Sub SetcatNm(arg As String)
        Me.catNm = arg
    End Sub

    ' ディレクトリ名のGetter/Setter
    Public Function GetdirNm() As String
        GetdirNm = Me.dirNm
    End Function

    Public Sub SetdirNm(arg As String)
        Me.dirNm = arg
    End Sub

    ' カテゴリタイプのGetter/Setter
    Public Function GetuseCd() As String
        GetuseCd = Me.useCd
    End Function

    Public Sub SetuseCd(arg As String)
        Me.useCd = arg
    End Sub

    ' 文字セットのGetter/Setter
    Public Function GetcharSetCd() As String
        GetcharSetCd = Me.charSetCd
    End Function

    Public Sub SetcharSetCd(arg As String)
        Me.charSetCd = arg
    End Sub

    ' RSS URLのGetter/Setter
    Public Function GetuseRSS() As String
        GetuseRSS = Me.useRSS
    End Function

    Public Sub SetuseRSS(arg As String)
        Me.useRSS = arg
    End Sub

    ' バージョンルールのGetter/Setter
    Public Function GetversionCnt() As String
        GetversionCnt = Me.versionCnt
    End Function

    Public Sub SetversionCnt(arg As String)
        Me.versionCnt = arg
    End Sub

    ' アクションフィールドID01のGetter/Setter
    Public Function GetafieldId_01() As String
        GetafieldId_01 = Me.afieldId_01
    End Function

    Public Sub SetafieldId_01(arg As String)
        Me.afieldId_01 = arg
    End Sub

    ' アクションフィールドID02のGetter/Setter
    Public Function GetafieldId_02() As String
        GetafieldId_02 = Me.afieldId_02
    End Function

    Public Sub SetafieldId_02(arg As String)
        Me.afieldId_02 = arg
    End Sub

    ' アクションフィールドID03のGetter/Setter
    Public Function GetafieldId_03() As String
        GetafieldId_03 = Me.afieldId_03
    End Function

    Public Sub SetafieldId_03(arg As String)
        Me.afieldId_03 = arg
    End Sub



End Class

Public Class Meta

    'メタ情報関連


    'メタ情報名
    Public metaNm As String

    'メタ情報ID
    Public metaId As String

    'メタ情報のタイプ
    Public metaType As String

    'メタ情報値
    Public metaValue As String


    ' メタ情報名のGetter/Setter
    Public Function GetmetaNm() As String
        GetmetaNm = Me.metaNm
    End Function

    Public Sub SetmetaNm(arg As String)
        Me.metaNm = arg
    End Sub

    ' メタ情報IDのGetter/Setter
    Public Function GetmetaId() As String
        GetmetaId = Me.metaId
    End Function

    Public Sub SetmetaId(arg As String)
        Me.metaId = arg
    End Sub

    ' メタ情報のタイプのGetter/Setter
    Public Function GetmetaType() As String
        GetmetaType = Me.metaType
    End Function

    Public Sub SetmetaType(arg As String)
        Me.metaType = arg
    End Sub

    ' メタ情報値のGetter/Setter
    Public Function GetmetaValue() As String
        GetmetaValue = Me.metaValue
    End Function

    Public Sub SetmetaValue(arg As String)
        Me.metaValue = arg
    End Sub
End Class

Public Class ConRead

    'コンテンツ自動読み込み関連

    'コンテンツカテゴリID
    Public conId As String

    ' コンテンツカテゴリIDのGetter/Setter
    Public Function GetconId() As String
        GetconId = Me.conId
    End Function

    Public Sub SetconId(arg As String)
        Me.conId = arg
    End Sub

End Class