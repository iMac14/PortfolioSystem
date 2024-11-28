Public Class Payrol
    Private Sub Payrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize form, clear fields
        txtEmployeeName.Clear()
        txtHoursWorked.Clear()
        txtHourlyRate.Clear()
        lblTotalSalary.Text = "Total Salary: ₱0.00"
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Get input values from user
        Dim employeeName As String = txtEmployeeName.Text
        Dim hoursWorked As Double
        Dim hourlyRate As Double

        ' Validate the input
        If Not Double.TryParse(txtHoursWorked.Text, hoursWorked) Then
            MessageBox.Show("Please enter a valid number for Hours Worked.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Double.TryParse(txtHourlyRate.Text, hourlyRate) Then
            MessageBox.Show("Please enter a valid number for Hourly Rate.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Calculate the total salary
        Dim totalSalary As Double = hoursWorked * hourlyRate

        ' Display the result
        lblTotalSalary.Text = "Total Salary: $" & totalSalary.ToString("F2")
        MessageBox.Show("Salary calculated for " & employeeName & " is ₱" & totalSalary.ToString("F2"), "Salary Calculation", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeName.TextChanged

    End Sub
End Class