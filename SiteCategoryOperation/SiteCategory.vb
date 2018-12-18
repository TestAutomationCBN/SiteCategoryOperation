'サイトカテゴリクラス

Public Class SiteCategory

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
