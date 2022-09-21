Imports System.Data.SqlClient
Public Class frm_login
    Private Sub bt_login_Click(sender As Object, e As EventArgs) Handles bt_login.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-7B686JL\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from Customer where cus_username = '" & tb_user.Text & "' and cus_pwd = '" & tb_pass.Text & "'", conn)
        Dim adap As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        adap.Fill(dt)
        If dt.Rows.Count = 1 Then
            MessageBox.Show("WELCOME")
            main.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username or Password Failed")
        End If
    End Sub
End Class
