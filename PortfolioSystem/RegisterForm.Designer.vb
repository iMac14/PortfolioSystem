<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BtnBack = New Button()
        BtnReg = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TbxUser2 = New TextBox()
        TbxPw2 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TbxFN = New TextBox()
        TbxLN = New TextBox()
        TbxPN = New TextBox()
        TbxEmail = New TextBox()
        CheckBox1 = New CheckBox()
        DateTimePicker1 = New DateTimePicker()
        Label8 = New Label()
        TbxAge = New TextBox()
        SuspendLayout()
        ' 
        ' BtnBack
        ' 
        BtnBack.Location = New Point(238, 289)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(75, 23)
        BtnBack.TabIndex = 0
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' BtnReg
        ' 
        BtnReg.Location = New Point(107, 289)
        BtnReg.Name = "BtnReg"
        BtnReg.Size = New Size(75, 23)
        BtnReg.TabIndex = 1
        BtnReg.Text = "Register"
        BtnReg.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 2
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 3
        Label2.Text = "Password:"
        ' 
        ' TbxUser2
        ' 
        TbxUser2.Location = New Point(107, 26)
        TbxUser2.Name = "TbxUser2"
        TbxUser2.Size = New Size(206, 23)
        TbxUser2.TabIndex = 4
        ' 
        ' TbxPw2
        ' 
        TbxPw2.Location = New Point(107, 55)
        TbxPw2.Name = "TbxPw2"
        TbxPw2.PasswordChar = "*"c
        TbxPw2.Size = New Size(206, 23)
        TbxPw2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 15)
        Label3.TabIndex = 6
        Label3.Text = "First Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 133)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 15)
        Label4.TabIndex = 7
        Label4.Text = "Last Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 166)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 15)
        Label5.TabIndex = 8
        Label5.Text = "Birthday:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 220)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 15)
        Label6.TabIndex = 9
        Label6.Text = "Phone Number:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 256)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 10
        Label7.Text = "Email:"
        ' 
        ' TbxFN
        ' 
        TbxFN.Location = New Point(107, 105)
        TbxFN.Name = "TbxFN"
        TbxFN.Size = New Size(206, 23)
        TbxFN.TabIndex = 11
        ' 
        ' TbxLN
        ' 
        TbxLN.Location = New Point(107, 134)
        TbxLN.Name = "TbxLN"
        TbxLN.Size = New Size(206, 23)
        TbxLN.TabIndex = 12
        ' 
        ' TbxPN
        ' 
        TbxPN.Location = New Point(107, 220)
        TbxPN.Name = "TbxPN"
        TbxPN.Size = New Size(206, 23)
        TbxPN.TabIndex = 14
        ' 
        ' TbxEmail
        ' 
        TbxEmail.Location = New Point(107, 248)
        TbxEmail.Name = "TbxEmail"
        TbxEmail.Size = New Size(208, 23)
        TbxEmail.TabIndex = 15
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(107, 84)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 17
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(107, 166)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 193)
        Label8.Name = "Label8"
        Label8.Size = New Size(31, 15)
        Label8.TabIndex = 19
        Label8.Text = "Age:"
        ' 
        ' TbxAge
        ' 
        TbxAge.Location = New Point(107, 193)
        TbxAge.Name = "TbxAge"
        TbxAge.Size = New Size(57, 23)
        TbxAge.TabIndex = 20
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(356, 321)
        Controls.Add(TbxAge)
        Controls.Add(Label8)
        Controls.Add(DateTimePicker1)
        Controls.Add(CheckBox1)
        Controls.Add(TbxEmail)
        Controls.Add(TbxPN)
        Controls.Add(TbxLN)
        Controls.Add(TbxFN)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TbxPw2)
        Controls.Add(TbxUser2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnReg)
        Controls.Add(BtnBack)
        Name = "RegisterForm"
        Text = "RegisterForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnReg As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbxUser2 As TextBox
    Friend WithEvents TbxPw2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TbxFN As TextBox
    Friend WithEvents TbxLN As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TbxPN As TextBox
    Friend WithEvents TbxEmail As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TbxAge As TextBox
End Class
