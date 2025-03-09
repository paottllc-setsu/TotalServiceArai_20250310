<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 見積請求作成修正
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(見積請求作成修正))
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        Column7 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Button3 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Button4 = New Button()
        ProgressBar1 = New ProgressBar()
        Label4 = New Label()
        Button7 = New Button()
        TextBox3 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Label8 = New Label()
        TextBox4 = New TextBox()
        CheckBox1 = New CheckBox()
        DateTimePicker1 = New DateTimePicker()
        Panel3 = New Panel()
        CheckBox2 = New CheckBox()
        Button8 = New Button()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(809, 619)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 7
        Button1.Text = "PDF出力"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(919, 619)
        Button2.Name = "Button2"
        Button2.Size = New Size(82, 23)
        Button2.TabIndex = 8
        Button2.Text = "クリア"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.AcceptsReturn = True
        TextBox1.Font = New Font("Yu Gothic UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(409, 44)
        TextBox1.MaxLength = 100
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(288, 100)
        TextBox1.TabIndex = 2
        TextBox1.Text = "XXXXXXXX　XXXXXX　XXXXXX" & vbCrLf & "　"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column7, Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.Location = New Point(30, 204)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(971, 400)
        DataGridView1.TabIndex = 5
        ' 
        ' Column7
        ' 
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.LightSteelBlue
        DataGridViewCellStyle8.Font = New Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle8.Padding = New Padding(15, 0, 0, 0)
        Column7.DefaultCellStyle = DataGridViewCellStyle8
        Column7.HeaderText = " ﾓｰﾄﾞ"
        Column7.MaxInputLength = 99
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.SortMode = DataGridViewColumnSortMode.NotSortable
        Column7.Width = 40
        ' 
        ' Column1
        ' 
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.White
        DataGridViewCellStyle9.Font = New Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Column1.DefaultCellStyle = DataGridViewCellStyle9
        Column1.HeaderText = "工事名"
        Column1.MaxInputLength = 56
        Column1.Name = "Column1"
        Column1.Resizable = DataGridViewTriState.False
        Column1.SortMode = DataGridViewColumnSortMode.NotSortable
        Column1.Width = 362
        ' 
        ' Column2
        ' 
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Font = New Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle10.Format = "N1"
        Column2.DefaultCellStyle = DataGridViewCellStyle10
        Column2.HeaderText = "数量"
        Column2.Name = "Column2"
        Column2.SortMode = DataGridViewColumnSortMode.NotSortable
        Column2.Width = 45
        ' 
        ' Column3
        ' 
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Font = New Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Column3.DefaultCellStyle = DataGridViewCellStyle11
        Column3.FillWeight = 90F
        Column3.HeaderText = "単位"
        Column3.Name = "Column3"
        Column3.Resizable = DataGridViewTriState.True
        Column3.SortMode = DataGridViewColumnSortMode.NotSortable
        Column3.Width = 70
        ' 
        ' Column4
        ' 
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Font = New Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle12.Format = "N0"
        Column4.DefaultCellStyle = DataGridViewCellStyle12
        Column4.HeaderText = "単価"
        Column4.Name = "Column4"
        Column4.SortMode = DataGridViewColumnSortMode.NotSortable
        Column4.Width = 50
        ' 
        ' Column5
        ' 
        DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Font = New Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Column5.DefaultCellStyle = DataGridViewCellStyle13
        Column5.HeaderText = "金額"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Resizable = DataGridViewTriState.False
        Column5.SortMode = DataGridViewColumnSortMode.NotSortable
        Column5.Width = 80
        ' 
        ' Column6
        ' 
        DataGridViewCellStyle14.Font = New Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Column6.DefaultCellStyle = DataGridViewCellStyle14
        Column6.HeaderText = "備考"
        Column6.MaxInputLength = 100
        Column6.Name = "Column6"
        Column6.SortMode = DataGridViewColumnSortMode.NotSortable
        Column6.Width = 270
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(30, 618)
        Button3.Name = "Button3"
        Button3.Size = New Size(66, 24)
        Button3.TabIndex = 6
        Button3.Text = "行追加"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(371, 626)
        Button5.Name = "Button5"
        Button5.Size = New Size(121, 22)
        Button5.TabIndex = 99
        Button5.Text = "Jsonテスト"
        Button5.UseVisualStyleBackColor = True
        Button5.Visible = False
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(252, 618)
        Button6.Name = "Button6"
        Button6.Size = New Size(66, 24)
        Button6.TabIndex = 14
        Button6.Text = "行削除"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 9F, FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(425, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 15)
        Label1.TabIndex = 0
        Label1.Text = "顧客名の選択"
        ' 
        ' TextBox2
        ' 
        TextBox2.AcceptsReturn = True
        TextBox2.Location = New Point(728, 44)
        TextBox2.MaxLength = 100
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(270, 100)
        TextBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(726, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 17
        Label2.Text = "備考欄"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(34, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 37)
        Label3.TabIndex = 18
        Label3.Text = "見積書作成"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(47, 114)
        Button4.Name = "Button4"
        Button4.Size = New Size(120, 41)
        Button4.TabIndex = 4
        Button4.Text = "見積履歴から作成"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(844, 22)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(134, 15)
        ProgressBar1.TabIndex = 20
        ProgressBar1.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 175)
        Label4.Name = "Label4"
        Label4.Size = New Size(278, 15)
        Label4.TabIndex = 21
        Label4.Text = "※モード　0：空行　1：明細行　2：数値入力不可行"
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button7.Location = New Point(215, 57)
        Button7.Name = "Button7"
        Button7.Size = New Size(110, 35)
        Button7.TabIndex = 100
        Button7.Text = "削除実行"
        Button7.UseVisualStyleBackColor = False
        Button7.Visible = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(96, 7)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(70, 23)
        TextBox3.TabIndex = 101
        TextBox3.Text = "0"
        TextBox3.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 15)
        Label5.TabIndex = 102
        Label5.Text = "現在の合計："
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(168, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 15)
        Label6.TabIndex = 103
        Label6.Text = "（課税前）"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(728, 155)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(270, 38)
        Panel1.TabIndex = 104
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(220, 274)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(628, 302)
        Panel2.TabIndex = 105
        Panel2.UseWaitCursor = True
        Panel2.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(244, 121)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(151, 65)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        PictureBox1.UseWaitCursor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(258, 198)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 15)
        Label7.TabIndex = 0
        Label7.Text = "しばらくお待ちください。"
        Label7.UseWaitCursor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(48, 84)
        Label8.Name = "Label8"
        Label8.Size = New Size(50, 15)
        Label8.TabIndex = 106
        Label8.Text = "請求No."
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(98, 82)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(40, 23)
        TextBox4.TabIndex = 107
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(215, 110)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(126, 19)
        CheckBox1.TabIndex = 109
        CheckBox1.Text = "作成日付を指定する"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Enabled = False
        DateTimePicker1.Location = New Point(215, 130)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(110, 23)
        DateTimePicker1.TabIndex = 111
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Location = New Point(28, 70)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(160, 96)
        Panel3.TabIndex = 112
        Panel3.Visible = False
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(215, 32)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(126, 19)
        CheckBox2.TabIndex = 113
        CheckBox2.Text = "見積・請求書の削除"
        CheckBox2.UseVisualStyleBackColor = True
        CheckBox2.Visible = False
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(452, 150)
        Button8.Name = "Button8"
        Button8.Size = New Size(193, 22)
        Button8.TabIndex = 115
        Button8.Text = "顧客名に「様」を追加する"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(665, 621)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(140, 19)
        CheckBox3.TabIndex = 116
        CheckBox3.Text = "印刷せずに保存だけする"
        CheckBox3.UseVisualStyleBackColor = True
        CheckBox3.Visible = False
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(102, 620)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(136, 19)
        CheckBox4.TabIndex = 117
        CheckBox4.Text = "選択行の前に追加する"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' 見積請求作成修正
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Button5
        ClientSize = New Size(1038, 661)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(Button8)
        Controls.Add(CheckBox2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Button7)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox4)
        Controls.Add(Label8)
        Controls.Add(Panel2)
        Controls.Add(Label4)
        Controls.Add(ProgressBar1)
        Controls.Add(Button4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button3)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Location = New Point(500, 300)
        Name = "見積請求作成修正"
        StartPosition = FormStartPosition.CenterScreen
        Text = "見積・請求"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Button8 As Button
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
