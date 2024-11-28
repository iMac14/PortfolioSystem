<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payrol
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
        btnCalculate = New Button()
        lblTotalSalary = New Label()
        txtEmployeeName = New TextBox()
        txtHoursWorked = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtHourlyRate = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(195, 166)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 23)
        btnCalculate.TabIndex = 0
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' lblTotalSalary
        ' 
        lblTotalSalary.AutoSize = True
        lblTotalSalary.Location = New Point(153, 130)
        lblTotalSalary.Name = "lblTotalSalary"
        lblTotalSalary.Size = New Size(84, 15)
        lblTotalSalary.TabIndex = 1
        lblTotalSalary.Text = "TOTAL SALARY"
        ' 
        ' txtEmployeeName
        ' 
        txtEmployeeName.Location = New Point(137, 31)
        txtEmployeeName.Name = "txtEmployeeName"
        txtEmployeeName.Size = New Size(100, 23)
        txtEmployeeName.TabIndex = 2
        ' 
        ' txtHoursWorked
        ' 
        txtHoursWorked.Location = New Point(137, 60)
        txtHoursWorked.Name = "txtHoursWorked"
        txtHoursWorked.Size = New Size(100, 23)
        txtHoursWorked.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 15)
        Label2.TabIndex = 4
        Label2.Text = "Employee Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(34, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 15)
        Label3.TabIndex = 5
        Label3.Text = "Hours Worked:"
        ' 
        ' txtHourlyRate
        ' 
        txtHourlyRate.Location = New Point(137, 89)
        txtHourlyRate.Name = "txtHourlyRate"
        txtHourlyRate.Size = New Size(100, 23)
        txtHourlyRate.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(34, 97)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 7
        Label4.Text = "Hourly Rate:"
        ' 
        ' Payrol
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(295, 201)
        Controls.Add(Label4)
        Controls.Add(txtHourlyRate)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtHoursWorked)
        Controls.Add(txtEmployeeName)
        Controls.Add(lblTotalSalary)
        Controls.Add(btnCalculate)
        Name = "Payrol"
        Text = "Payrol"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblTotalSalary As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents txtHoursWorked As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHourlyRate As TextBox
    Friend WithEvents Label4 As Label
End Class
