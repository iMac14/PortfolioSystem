﻿Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnEmp.Click
        EmployeeWindow.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPayrol_Click(sender As Object, e As EventArgs) Handles BtnPayrol.Click
        Payrol.Show()
        Me.Hide()
    End Sub
End Class
