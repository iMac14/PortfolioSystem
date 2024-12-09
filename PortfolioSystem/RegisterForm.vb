Imports Microsoft.Data.SqlClient

Public Class RegisterForm
    Dim Command As SqlCommand
    Dim reader As SqlDataReader
    Dim con As SqlConnection ' Use consistent casing for variable names

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnReg.Click
        con = New SqlConnection("Data Source=DESKTOP-8U07U20;Initial Catalog=sampleDB;Integrated Security=True;TrustServerCertificate=True")
        Dim reader As SqlDataReader

        Try
            con.Open()
            Dim Query =
           "insert into sampleDB.dbo.UserTable (Username,Password,FirstName,LastName,Birthday,PhoneNumber,Email) Values('" & TbxUser2.Text & "','" & TbxPw2.Text & "','" & TbxFN.Text & "','" & TbxLN.Text & "','" & DateTimePicker1.Value.Date & "','" & TbxPN.Text & "', '" & TbxEmail.Text & "')"
            Command = New SqlCommand(Query, con)
            reader = Command.ExecuteReader
            MessageBox.Show("Register Done")
            Form1.Show()
            Me.Close()
            con.Close()
        Catch ex As Exception ' Corrected "Catch ex As Con" to "Catch ex As Exception"
            MessageBox.Show(ex.Message)
        Finally
            If con IsNot Nothing Then
                con.Dispose() ' Dispose releases resources, but Close() would be safer for connections
            End If
        End Try


    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TbxPw2.PasswordChar = "" ' Show password
        Else
            TbxPw2.PasswordChar = "*" ' Hide password with masking character
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim birthDate As DateTime = DateTimePicker1.Value
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - birthDate.Year

        ' Adjust if the birthday hasn't occurred yet this year
        If (birthDate > today.AddYears(-age)) Then
            age -= 1
        End If

        ' Display the age in the TextBox
        TbxAge.Text = age.ToString()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Form1.Show()

    End Sub
End Class