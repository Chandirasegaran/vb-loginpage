Imports System.Data.SqlClient
Public Class Signupform
    Dim connection As New SqlConnection("Data Source=LAPTOP-L25P685O;Initial Catalog=UserReg;Integrated Security=True")
    Private Sub pass_Click(sender As Object, e As EventArgs) Handles pass.Click

    End Sub

    Private Sub Exitlogin_Click(sender As Object, e As EventArgs) Handles Exitlogin.Click
        End
    End Sub

    Private Sub signinbtn_Click(sender As Object, e As EventArgs) Handles signinbtn.Click
        Me.Close()
        Login.Show()

    End Sub

    Private Sub signupbtn_Click(sender As Object, e As EventArgs) Handles signupbtn.Click
        Dim command As New SqlCommand("insert into userreg (name, email,password, phone,age,city) values ('" & nametxt.Text & "','" & emailtxt.Text & "','" & passwordtxt.Text & "'," & phonetxt.Text & " ," & agetxt.Text & " ,'" & citytxt.Text & "' )", connection)
        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("User Registered Successfully!")
            Me.Close()
            Login.Show()
        Else
            MessageBox.Show("Something Went Wrong, Try again Later.")
            End
        End If
        connection.Close()
    End Sub
End Class