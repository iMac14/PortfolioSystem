<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        TxtUser = New TextBox()
        Txtpw = New TextBox()
        BtnLogin = New Button()
        BtnCancel = New Button()
        CheckBox1 = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(234, 193)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 15)
        Label1.TabIndex = 0
        Label1.Text = "Mark Andrew M. Gregorio"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(121, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 1
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(121, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 2
        Label3.Text = "Password:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 104)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' TxtUser
        ' 
        TxtUser.BackColor = SystemColors.InactiveCaption
        TxtUser.Location = New Point(187, 33)
        TxtUser.Name = "TxtUser"
        TxtUser.Size = New Size(157, 23)
        TxtUser.TabIndex = 4
        ' 
        ' Txtpw
        ' 
        Txtpw.BackColor = SystemColors.InactiveCaption
        Txtpw.Location = New Point(187, 87)
        Txtpw.Name = "Txtpw"
        Txtpw.Size = New Size(157, 23)
        Txtpw.TabIndex = 5
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = SystemColors.ActiveCaption
        BtnLogin.Location = New Point(188, 143)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(75, 23)
        BtnLogin.TabIndex = 6
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' BtnCancel
        ' 
        BtnCancel.BackColor = SystemColors.ActiveCaption
        BtnCancel.Location = New Point(269, 143)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(75, 23)
        BtnCancel.TabIndex = 7
        BtnCancel.Text = "Cancel"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(188, 118)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 8
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(390, 217)
        Controls.Add(CheckBox1)
        Controls.Add(BtnCancel)
        Controls.Add(BtnLogin)
        Controls.Add(Txtpw)
        Controls.Add(TxtUser)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents Txtpw As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents CheckBox1 As CheckBox

End Class
