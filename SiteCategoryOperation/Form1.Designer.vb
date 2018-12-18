<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiteCategoryOperation
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RefButton1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExeMenu03 = New System.Windows.Forms.RadioButton()
        Me.ExeMenu02 = New System.Windows.Forms.RadioButton()
        Me.ExeMenu01 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RefButton3 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.XMLPath = New System.Windows.Forms.TextBox()
        Me.RefButton2 = New System.Windows.Forms.Button()
        Me.ExecuteButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(41, 68)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(584, 22)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1. 基となるサイトカテゴリ設計書を選択してください。"
        '
        'RefButton1
        '
        Me.RefButton1.Location = New System.Drawing.Point(655, 65)
        Me.RefButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RefButton1.Name = "RefButton1"
        Me.RefButton1.Size = New System.Drawing.Size(133, 29)
        Me.RefButton1.TabIndex = 2
        Me.RefButton1.Text = "参照"
        Me.RefButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 128)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "2. 行う処理を下記より選択してください。"
        '
        'ExeMenu03
        '
        Me.ExeMenu03.Location = New System.Drawing.Point(41, 208)
        Me.ExeMenu03.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExeMenu03.Name = "ExeMenu03"
        Me.ExeMenu03.Size = New System.Drawing.Size(328, 20)
        Me.ExeMenu03.TabIndex = 6
        Me.ExeMenu03.TabStop = True
        Me.ExeMenu03.Text = "エクスポートXMLと比較を実施(テストの実施)"
        Me.ExeMenu03.UseVisualStyleBackColor = True
        '
        'ExeMenu02
        '
        Me.ExeMenu02.AutoSize = True
        Me.ExeMenu02.Location = New System.Drawing.Point(41, 181)
        Me.ExeMenu02.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExeMenu02.Name = "ExeMenu02"
        Me.ExeMenu02.Size = New System.Drawing.Size(148, 19)
        Me.ExeMenu02.TabIndex = 5
        Me.ExeMenu02.TabStop = True
        Me.ExeMenu02.Text = "テスト仕様書の作成"
        Me.ExeMenu02.UseVisualStyleBackColor = True
        '
        'ExeMenu01
        '
        Me.ExeMenu01.AutoSize = True
        Me.ExeMenu01.CheckAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ExeMenu01.Location = New System.Drawing.Point(41, 154)
        Me.ExeMenu01.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExeMenu01.Name = "ExeMenu01"
        Me.ExeMenu01.Size = New System.Drawing.Size(158, 19)
        Me.ExeMenu01.TabIndex = 4
        Me.ExeMenu01.TabStop = True
        Me.ExeMenu01.Text = "インポート用XML作成"
        Me.ExeMenu01.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 256)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(268, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "3. 生成ファイルの出力先を選択してください。"
        '
        'RefButton3
        '
        Me.RefButton3.Location = New System.Drawing.Point(655, 285)
        Me.RefButton3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RefButton3.Name = "RefButton3"
        Me.RefButton3.Size = New System.Drawing.Size(133, 29)
        Me.RefButton3.TabIndex = 9
        Me.RefButton3.Text = "参照"
        Me.RefButton3.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(41, 288)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(584, 22)
        Me.TextBox2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(377, 210)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "エクスポートXML"
        '
        'XMLPath
        '
        Me.XMLPath.Enabled = False
        Me.XMLPath.Location = New System.Drawing.Point(493, 206)
        Me.XMLPath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XMLPath.Name = "XMLPath"
        Me.XMLPath.Size = New System.Drawing.Size(132, 22)
        Me.XMLPath.TabIndex = 11
        '
        'RefButton2
        '
        Me.RefButton2.Enabled = False
        Me.RefButton2.Location = New System.Drawing.Point(655, 204)
        Me.RefButton2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RefButton2.Name = "RefButton2"
        Me.RefButton2.Size = New System.Drawing.Size(133, 29)
        Me.RefButton2.TabIndex = 12
        Me.RefButton2.Text = "参照"
        Me.RefButton2.UseVisualStyleBackColor = True
        '
        'ExecuteButton
        '
        Me.ExecuteButton.Location = New System.Drawing.Point(191, 345)
        Me.ExecuteButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExecuteButton.Name = "ExecuteButton"
        Me.ExecuteButton.Size = New System.Drawing.Size(179, 26)
        Me.ExecuteButton.TabIndex = 13
        Me.ExecuteButton.Text = "処理の実行"
        Me.ExecuteButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(448, 345)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(179, 26)
        Me.ClearButton.TabIndex = 14
        Me.ClearButton.Text = "キャンセル"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SiteCategoryOperation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 386)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExecuteButton)
        Me.Controls.Add(Me.RefButton2)
        Me.Controls.Add(Me.XMLPath)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RefButton3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ExeMenu03)
        Me.Controls.Add(Me.ExeMenu02)
        Me.Controls.Add(Me.ExeMenu01)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RefButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "SiteCategoryOperation"
        Me.Text = "サイトカテゴリ系操作メニュー"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents RefButton1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ExeMenu03 As RadioButton
    Friend WithEvents ExeMenu02 As RadioButton
    Friend WithEvents ExeMenu01 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents RefButton3 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents XMLPath As TextBox
    Friend WithEvents RefButton2 As Button
    Protected Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ExecuteButton As Button
    Friend WithEvents ClearButton As Button
End Class
