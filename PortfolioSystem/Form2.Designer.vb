<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        BtnPayrol = New Button()
        BtnEmp = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' BtnPayrol
        ' 
        BtnPayrol.Location = New Point(103, 59)
        BtnPayrol.Name = "BtnPayrol"
        BtnPayrol.Size = New Size(75, 23)
        BtnPayrol.TabIndex = 0
        BtnPayrol.Text = "Payrol"
        BtnPayrol.UseVisualStyleBackColor = True
        ' 
        ' BtnEmp
        ' 
        BtnEmp.Location = New Point(184, 59)
        BtnEmp.Name = "BtnEmp"
        BtnEmp.Size = New Size(103, 23)
        BtnEmp.TabIndex = 1
        BtnEmp.Text = "Employee List"
        BtnEmp.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(103, 88)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 2
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(184, 88)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 3
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 15)
        Label1.TabIndex = 4
        Label1.Text = "Select System."
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(434, 178)
        Controls.Add(Label1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(BtnEmp)
        Controls.Add(BtnPayrol)
        Name = "Form2"
        Text = "System List"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnPayrol As Button
    Friend WithEvents BtnEmp As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
End Class
