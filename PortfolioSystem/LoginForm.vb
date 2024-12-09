Imports System
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.Data.SqlClient


Public Class Form1
    Dim Command As SqlCommand
    Dim reader As SqlDataReader
    Dim con As SqlConnection ' Use consistent casing for variable names
    Private Sub btn1log_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        con = New SqlConnection("Data Source=DESKTOP-8U07U20;Initial Catalog=sampleDB;Integrated Security=True;TrustServerCertificate=True")
        Dim reader As SqlDataReader

        Try
            con.Open()
            Dim Query = "SELECT * FROM UserTable Where Username='" & TxtUser.Text & "' and Password='" & Txtpw.Text & "'"
            Command = New SqlCommand(Query, con)
            reader = Command.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Login Succesful")
                Form2.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username and password are Duplicate")
            Else
                MessageBox.Show("Username and password are incorrect")

            End If
            con.Close()

        Catch ex As Exception ' Corrected "Catch ex As Con" to "Catch ex As Exception"
            MessageBox.Show(ex.Message)
        Finally
            If con IsNot Nothing Then
                con.Dispose() ' Dispose releases resources, but Close() would be safer for connections
            End If
        End Try

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn2cancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles TxtUser.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles Txtpw.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Txtpw.PasswordChar = "" ' Show password
        Else
            Txtpw.PasswordChar = "*" ' Hide password with masking character
        End If
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        RegisterForm.Show()
        Me.Hide()



    End Sub

End Class
