<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserPage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UserProfileBtn = New System.Windows.Forms.Label()
        Me.LogoutBtn = New System.Windows.Forms.Label()
        Me.AddRentFormBtn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.firstname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.update = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.firstnameTxt = New System.Windows.Forms.Label()
        Me.usernameTxt = New System.Windows.Forms.Label()
        Me.phonenumberTxt = New System.Windows.Forms.Label()
        Me.emailTxt = New System.Windows.Forms.Label()
        Me.lastnameTxt = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.UserProfileBtn)
        Me.Panel1.Controls.Add(Me.LogoutBtn)
        Me.Panel1.Controls.Add(Me.AddRentFormBtn)
        Me.Panel1.Location = New System.Drawing.Point(-2, -9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 467)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(62, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'UserProfileBtn
        '
        Me.UserProfileBtn.AutoSize = True
        Me.UserProfileBtn.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserProfileBtn.ForeColor = System.Drawing.Color.White
        Me.UserProfileBtn.Location = New System.Drawing.Point(43, 152)
        Me.UserProfileBtn.Name = "UserProfileBtn"
        Me.UserProfileBtn.Size = New System.Drawing.Size(63, 20)
        Me.UserProfileBtn.TabIndex = 14
        Me.UserProfileBtn.Text = "| Profile"
        '
        'LogoutBtn
        '
        Me.LogoutBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LogoutBtn.AutoSize = True
        Me.LogoutBtn.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBtn.ForeColor = System.Drawing.Color.White
        Me.LogoutBtn.Location = New System.Drawing.Point(58, 402)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(57, 20)
        Me.LogoutBtn.TabIndex = 13
        Me.LogoutBtn.Text = "Logout"
        '
        'AddRentFormBtn
        '
        Me.AddRentFormBtn.AutoSize = True
        Me.AddRentFormBtn.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddRentFormBtn.ForeColor = System.Drawing.Color.White
        Me.AddRentFormBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddRentFormBtn.Location = New System.Drawing.Point(58, 182)
        Me.AddRentFormBtn.Name = "AddRentFormBtn"
        Me.AddRentFormBtn.Size = New System.Drawing.Size(40, 20)
        Me.AddRentFormBtn.TabIndex = 12
        Me.AddRentFormBtn.Text = "Rent"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(239, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 30)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Welcome"
        '
        'firstname
        '
        Me.firstname.AutoSize = True
        Me.firstname.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.ForeColor = System.Drawing.Color.White
        Me.firstname.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.firstname.Location = New System.Drawing.Point(344, 31)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(56, 30)
        Me.firstname.TabIndex = 17
        Me.firstname.Text = "User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(315, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Name: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(291, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Username:"
        '
        'update
        '
        Me.update.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.update.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.update.FlatAppearance.BorderSize = 0
        Me.update.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.ForeColor = System.Drawing.Color.White
        Me.update.Location = New System.Drawing.Point(680, 386)
        Me.update.Margin = New System.Windows.Forms.Padding(0)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(79, 34)
        Me.update.TabIndex = 20
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(323, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(255, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Phone Number:"
        '
        'firstnameTxt
        '
        Me.firstnameTxt.AutoSize = True
        Me.firstnameTxt.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstnameTxt.ForeColor = System.Drawing.Color.White
        Me.firstnameTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.firstnameTxt.Location = New System.Drawing.Point(379, 117)
        Me.firstnameTxt.Name = "firstnameTxt"
        Me.firstnameTxt.Size = New System.Drawing.Size(88, 21)
        Me.firstnameTxt.TabIndex = 23
        Me.firstnameTxt.Text = "User Name"
        '
        'usernameTxt
        '
        Me.usernameTxt.AutoSize = True
        Me.usernameTxt.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTxt.ForeColor = System.Drawing.Color.White
        Me.usernameTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.usernameTxt.Location = New System.Drawing.Point(379, 143)
        Me.usernameTxt.Name = "usernameTxt"
        Me.usernameTxt.Size = New System.Drawing.Size(81, 21)
        Me.usernameTxt.TabIndex = 24
        Me.usernameTxt.Text = "Username"
        '
        'phonenumberTxt
        '
        Me.phonenumberTxt.AutoSize = True
        Me.phonenumberTxt.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phonenumberTxt.ForeColor = System.Drawing.Color.White
        Me.phonenumberTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.phonenumberTxt.Location = New System.Drawing.Point(379, 173)
        Me.phonenumberTxt.Name = "phonenumberTxt"
        Me.phonenumberTxt.Size = New System.Drawing.Size(152, 21)
        Me.phonenumberTxt.TabIndex = 25
        Me.phonenumberTxt.Text = "User Phone Number"
        '
        'emailTxt
        '
        Me.emailTxt.AutoSize = True
        Me.emailTxt.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTxt.ForeColor = System.Drawing.Color.White
        Me.emailTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.emailTxt.Location = New System.Drawing.Point(379, 203)
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.Size = New System.Drawing.Size(84, 21)
        Me.emailTxt.TabIndex = 26
        Me.emailTxt.Text = "User Email"
        '
        'lastnameTxt
        '
        Me.lastnameTxt.AutoSize = True
        Me.lastnameTxt.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastnameTxt.ForeColor = System.Drawing.Color.White
        Me.lastnameTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lastnameTxt.Location = New System.Drawing.Point(473, 118)
        Me.lastnameTxt.Name = "lastnameTxt"
        Me.lastnameTxt.Size = New System.Drawing.Size(0, 21)
        Me.lastnameTxt.TabIndex = 28
        '
        'UserPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lastnameTxt)
        Me.Controls.Add(Me.emailTxt)
        Me.Controls.Add(Me.phonenumberTxt)
        Me.Controls.Add(Me.usernameTxt)
        Me.Controls.Add(Me.firstnameTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.firstname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserProfileBtn As Label
    Friend WithEvents LogoutBtn As Label
    Friend WithEvents AddRentFormBtn As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents firstname As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents update As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents firstnameTxt As Label
    Friend WithEvents usernameTxt As Label
    Friend WithEvents phonenumberTxt As Label
    Friend WithEvents emailTxt As Label
    Friend WithEvents lastnameTxt As Label
End Class
