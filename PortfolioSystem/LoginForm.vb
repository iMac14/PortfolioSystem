Imports System
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.Data.SqlClient


Public Class Form1

    ' Corrected connection string (ensure to replace with actual database name)

    Private Sub btn1log_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        ' Validate login
        Dim con As New SqlConnection("Data Source=DESKTOP-8U07U20;Initial Catalog=sampleDB;Integrated Security=True;Trust Server Certificate=True")
        If ValidateUser(TxtUser.Text, Txtpw.Text) Then
            MessageBox.Show("Login successful!")
            ' Open main form or dashboard after successful login
            Form2.Show()
            Me.Hide() ' Hide the login form
        Else
            MessageBox.Show("Invalid username or password.")
        End If

    End Sub

    Private Function ValidateUser(username As String, password As String) As Boolean
        Dim isValid As Boolean = False
        ' Using SQL connection and query to check if the username and password are correct
        Dim con As New SqlConnection("Data Source=DESKTOP-8U07U20;Initial Catalog=sampleDB;Integrated Security=True;Trust Server Certificate=True")
        ' SQL query to check if the username and password match any record in the database
        Dim query As String = "SELECT COUNT(*) FROM UserTable WHERE Username = @Username AND Password = @Password"

        Using command As New SqlCommand(query, con)
            ' Add parameters to avoid SQL injection
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@Password", password)

            Try
                con.Open()
                ' Execute the query and get the count of matching records
                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' If result is greater than 0, the login is successful
                If result > 0 Then
                    isValid = True
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using


        Return isValid
    End Function

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

    End Sub

End Class
