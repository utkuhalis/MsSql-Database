<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Login = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UserPW = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UserID = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MainForm = New System.Windows.Forms.Panel()
        Me.ProductInfo = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ProductAdd = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Login.SuspendLayout()
        Me.MainForm.SuspendLayout()
        Me.ProductInfo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.Controls.Add(Me.Button2)
        Me.Login.Controls.Add(Me.UserPW)
        Me.Login.Controls.Add(Me.Label3)
        Me.Login.Controls.Add(Me.Label2)
        Me.Login.Controls.Add(Me.Label1)
        Me.Login.Controls.Add(Me.Button1)
        Me.Login.Controls.Add(Me.UserID)
        Me.Login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Login.Location = New System.Drawing.Point(0, 0)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(384, 361)
        Me.Login.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(70, 229)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 39)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Temizle"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'UserPW
        '
        Me.UserPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserPW.Location = New System.Drawing.Point(70, 186)
        Me.UserPW.Name = "UserPW"
        Me.UserPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.UserPW.Size = New System.Drawing.Size(247, 20)
        Me.UserPW.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(360, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Kullanıcı Şifresi"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kullanıcı Adı"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 47)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Giriş Yap"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(200, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Giriş Yap"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'UserID
        '
        Me.UserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserID.Location = New System.Drawing.Point(70, 133)
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(247, 20)
        Me.UserID.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'MainForm
        '
        Me.MainForm.Controls.Add(Me.ProductInfo)
        Me.MainForm.Controls.Add(Me.Label6)
        Me.MainForm.Controls.Add(Me.ProductAdd)
        Me.MainForm.Controls.Add(Me.Label5)
        Me.MainForm.Controls.Add(Me.ComboBox1)
        Me.MainForm.Controls.Add(Me.DataGridView1)
        Me.MainForm.Controls.Add(Me.Button6)
        Me.MainForm.Controls.Add(Me.Button3)
        Me.MainForm.Controls.Add(Me.Button4)
        Me.MainForm.Controls.Add(Me.TextBox2)
        Me.MainForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainForm.Enabled = False
        Me.MainForm.Location = New System.Drawing.Point(0, 0)
        Me.MainForm.Name = "MainForm"
        Me.MainForm.Size = New System.Drawing.Size(384, 361)
        Me.MainForm.TabIndex = 1
        Me.MainForm.Visible = False
        '
        'ProductInfo
        '
        Me.ProductInfo.Controls.Add(Me.TextBox8)
        Me.ProductInfo.Controls.Add(Me.Label7)
        Me.ProductInfo.Controls.Add(Me.Label4)
        Me.ProductInfo.Controls.Add(Me.Button7)
        Me.ProductInfo.Controls.Add(Me.TextBox4)
        Me.ProductInfo.Controls.Add(Me.Label12)
        Me.ProductInfo.Controls.Add(Me.TextBox3)
        Me.ProductInfo.Controls.Add(Me.Label11)
        Me.ProductInfo.Controls.Add(Me.Label9)
        Me.ProductInfo.Controls.Add(Me.Button5)
        Me.ProductInfo.Controls.Add(Me.Label8)
        Me.ProductInfo.Controls.Add(Me.TextBox1)
        Me.ProductInfo.Enabled = False
        Me.ProductInfo.Location = New System.Drawing.Point(390, 5)
        Me.ProductInfo.Name = "ProductInfo"
        Me.ProductInfo.Size = New System.Drawing.Size(363, 174)
        Me.ProductInfo.TabIndex = 18
        Me.ProductInfo.TabStop = False
        Me.ProductInfo.Text = "Ürün Bilgileri"
        Me.ProductInfo.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(6, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 15)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "ÜrünKodu:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(39, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Title:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(85, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(194, 20)
        Me.TextBox1.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(30, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Değer:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(18, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Kategori:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(94, 54)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox1.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 186)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(363, 133)
        Me.DataGridView1.TabIndex = 14
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(288, 325)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(84, 24)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Çık"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(156, 143)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 24)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Sil"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(255, 148)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 24)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Ekle"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(255, 61)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 39)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Ara"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(94, 88)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(155, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(34, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 15)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Fiyatı:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(85, 84)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(109, 20)
        Me.TextBox3.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(34, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 15)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Adeti:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(85, 112)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(109, 20)
        Me.TextBox4.TabIndex = 25
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(246, 143)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(111, 25)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "Güncelle"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'ProductAdd
        '
        Me.ProductAdd.Controls.Add(Me.TextBox9)
        Me.ProductAdd.Controls.Add(Me.Button8)
        Me.ProductAdd.Controls.Add(Me.TextBox5)
        Me.ProductAdd.Controls.Add(Me.Label13)
        Me.ProductAdd.Controls.Add(Me.TextBox6)
        Me.ProductAdd.Controls.Add(Me.Label14)
        Me.ProductAdd.Controls.Add(Me.Label16)
        Me.ProductAdd.Controls.Add(Me.Label17)
        Me.ProductAdd.Controls.Add(Me.TextBox7)
        Me.ProductAdd.Enabled = False
        Me.ProductAdd.Location = New System.Drawing.Point(390, 5)
        Me.ProductAdd.Name = "ProductAdd"
        Me.ProductAdd.Size = New System.Drawing.Size(363, 174)
        Me.ProductAdd.TabIndex = 19
        Me.ProductAdd.TabStop = False
        Me.ProductAdd.Text = "Ürün Ekle"
        Me.ProductAdd.Visible = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(246, 143)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(111, 25)
        Me.Button8.TabIndex = 19
        Me.Button8.Text = "Ekle"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(85, 112)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(109, 20)
        Me.TextBox5.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(34, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 15)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Adeti:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(85, 84)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(109, 20)
        Me.TextBox6.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(34, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 15)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Fiyatı:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label16.Location = New System.Drawing.Point(6, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 15)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "ÜrünKodu:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label17.Location = New System.Drawing.Point(39, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 15)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Title:"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(85, 29)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(194, 20)
        Me.TextBox7.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(34, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 15)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 15)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "ID:"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(85, 58)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(109, 20)
        Me.TextBox8.TabIndex = 28
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(85, 56)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(109, 20)
        Me.TextBox9.TabIndex = 29
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.MainForm)
        Me.Controls.Add(Me.Login)
        Me.Name = "Form1"
        Me.Text = "Login"
        Me.Login.ResumeLayout(False)
        Me.Login.PerformLayout()
        Me.MainForm.ResumeLayout(False)
        Me.MainForm.PerformLayout()
        Me.ProductInfo.ResumeLayout(False)
        Me.ProductInfo.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductAdd.ResumeLayout(False)
        Me.ProductAdd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Login As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents UserPW As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents UserID As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MainForm As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ProductInfo As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ProductAdd As GroupBox
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
End Class
