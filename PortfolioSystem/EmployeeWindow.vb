﻿Imports System
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.Data.SqlClient
Imports Windows.Win32.System
Public Class EmployeeWindow

    ' Corrected connection string (ensure to replace with actual database name)
    ' Corrected connection string (ensure to replace with actual database name)
    Private connectionString As String = "Data Source=DESKTOP-8U07U20;Initial Catalog=sampleDB;Integrated Security=True;Trust Server Certificate=True"

    Private Sub EmployeeWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeData()
    End Sub

    ' Load Employee data into DataGridView
    Private Sub LoadEmployeeData()
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT EmployeeID, UserID, FirstName, MiddleName, LastName FROM EmployeeTable"
            Dim adapter As New SqlDataAdapter(query, con)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub
    ' Check if UserID exists in UserTable
    Private Function IsUserIDValid(userID As String) As Boolean
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "SELECT COUNT(*) FROM UserTable WHERE UserID = @UserID"

            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@UserID", userID)
                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return result > 0 ' Return True if UserID exists, False otherwise
            End Using
        End Using
    End Function


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtEmployeeID.Text = row.Cells("EmployeeID").Value.ToString()
            txtUserID.Text = row.Cells("UserID").Value.ToString()
            txtFirstName.Text = row.Cells("FirstName").Value.ToString()
            txtMiddleName.Text = row.Cells("MiddleName").Value.ToString()
            txtLastName.Text = row.Cells("LastName").Value.ToString()
        End If
    End Sub


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ' Proceed with inserting the new employee
        Using con As New SqlConnection(connectionString)
            con.Open()
            ' UserID will be automatically generated by the database (no need to insert it)
            Dim query As String = "INSERT INTO EmployeeTable (UserID, FirstName, MiddleName, LastName) " &
                                  "VALUES ((SELECT TOP 1 UserID FROM UserTable ORDER BY UserID DESC), @FirstName, @MiddleName, @LastName)"

            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                command.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                command.Parameters.AddWithValue("@LastName", txtLastName.Text)

                command.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Employee added successfully!")
        LoadEmployeeData()
    End Sub


    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "DELETE FROM EmployeeTable WHERE EmployeeID = @EmployeeID"

            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text)
                command.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Employee deleted successfully!")
        LoadEmployeeData()
    End Sub


    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeID.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged

    End Sub
End Class

