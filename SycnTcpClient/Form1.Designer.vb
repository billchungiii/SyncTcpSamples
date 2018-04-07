<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 24)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "未連線"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(405, 282)
        Me.Button3.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(163, 46)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "離線"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(230, 282)
        Me.Button2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 46)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "發送"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 282)
        Me.Button1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 46)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "連接"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(230, 212)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(474, 36)
        Me.TextBox2.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 218)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 24)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "要發送的文字"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(234, 126)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(260, 36)
        Me.NumericUpDown1.TabIndex = 19
        Me.NumericUpDown1.Value = New Decimal(New Integer() {9999, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "遠端伺服器Port"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(234, 58)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(474, 36)
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.Text = "127.000.000.001"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "遠端伺服器IP"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 369)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Tcp Client"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
