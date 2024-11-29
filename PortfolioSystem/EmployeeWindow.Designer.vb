<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeWindow
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
        DataGridView1 = New DataGridView()
        BtnAdd = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtFirstName = New TextBox()
        txtMiddleName = New TextBox()
        txtLastName = New TextBox()
        txtEmployeeID = New TextBox()
        Label4 = New Label()
        BtnUpdate = New Button()
        BtnDelete = New Button()
        txtUserID = New TextBox()
        Label5 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(374, 25)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(542, 190)
        DataGridView1.TabIndex = 0
        ' 
        ' BtnAdd
        ' 
        BtnAdd.Location = New Point(374, 239)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(75, 23)
        BtnAdd.TabIndex = 1
        BtnAdd.Text = "Add"
        BtnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(143, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 2
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(144, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 3
        Label2.Text = "Middle Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(144, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 4
        Label3.Text = "Last Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(229, 99)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(100, 23)
        txtFirstName.TabIndex = 5
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(229, 139)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(100, 23)
        txtMiddleName.TabIndex = 6
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(229, 189)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(100, 23)
        txtLastName.TabIndex = 7
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Location = New Point(229, 70)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(100, 23)
        txtEmployeeID.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(144, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 15)
        Label4.TabIndex = 8
        Label4.Text = "Employee ID"
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(474, 239)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(75, 23)
        BtnUpdate.TabIndex = 10
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(569, 239)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(75, 23)
        BtnDelete.TabIndex = 11
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' txtUserID
        ' 
        txtUserID.Location = New Point(229, 25)
        txtUserID.Name = "txtUserID"
        txtUserID.Size = New Size(100, 23)
        txtUserID.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(156, 33)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 15)
        Label5.TabIndex = 13
        Label5.Text = "User ID"
        ' 
        ' EmployeeWindow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(940, 450)
        Controls.Add(Label5)
        Controls.Add(txtUserID)
        Controls.Add(BtnDelete)
        Controls.Add(BtnUpdate)
        Controls.Add(txtEmployeeID)
        Controls.Add(Label4)
        Controls.Add(txtLastName)
        Controls.Add(txtMiddleName)
        Controls.Add(txtFirstName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnAdd)
        Controls.Add(DataGridView1)
        Name = "EmployeeWindow"
        Text = "EmployeeWindow"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label5 As Label
End Class
