Imports System.Data.SqlClient
Public Class Login
    Dim connection As New SqlConnection("Data Source=LAPTOP-L25P685O;Initial Catalog=UserReg;Integrated Security=True")
    Private Sub Exitlogin_Click(sender As Object, e As EventArgs) Handles Exitlogin.Click
        End
    End Sub

    Private Sub signupbtn_Click(sender As Object, e As EventArgs) Handles signupbtn.Click
        Me.Hide()

        Signupform.Show()

    End Sub

    Private Sub signinbtn_Click(sender As Object, e As EventArgs) Handles signinbtn.Click
        Dim cmd As SqlCommand = New SqlCommand("select email, password from userreg where email='" + emailtxt.Text + "' and password='" + passwordtxt.Text + "'", connection)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Login Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Invalid Login Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
