Public Class Form1
    ' Define correct username and password
    Private correctUsername As String = "admin"
    Private correctPassword As String = "admin"
    Private Sub btn1log_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        ' Simple validation: Check if username and password are correct
        If TxtUser.Text = "Admin" And Txtpw.Text = "Admin" Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' After login is successful, open a new form (NewForm)
            Dim newForm As New Form2()
            newForm.Show()
            Me.Hide() ' Hide the login form
        Else
            MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn2cancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles TxtUser.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles Txtpw.TextChanged
        Txtpw.PasswordChar = "*"c
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' Show password
            Txtpw.PasswordChar = ""
        Else
            ' Mask password with asterisks (*)
            Txtpw.PasswordChar = "*"c
        End If
    End Sub

End Class
