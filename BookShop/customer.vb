Imports System.Data.SqlClient

Public Class customer
    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookShopDataSet)

    End Sub

    Private Sub customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookShopDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.BookShopDataSet.Customer)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=344_06\SQLEXPRESS;Initial Catalog=Bookshop;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("delete from Customer where cus_id = '" & Cus_idTextBox.Text & "'", conn)
        conn.Open()
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("DELETE SUCCESS")
        End If
        conn.Close()
        Me.CustomerTableAdapter.Fill(Me.BookShopDataSet.Customer)
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=344_06\SQLEXPRESS;Initial Catalog=Bookshop;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("update customer set cus_name=@name, cus_lastname=@lastname, cus_username=@username, cus_pwd=@pwd WHERE cus_id=@id", conn)
        cmd.Parameters.AddWithValue("name", Cus_nameTextBox.Text)
        cmd.Parameters.AddWithValue("lastname", Cus_lastnameTextBox.Text)
        cmd.Parameters.AddWithValue("username", Cus_usernameTextBox.Text)
        cmd.Parameters.AddWithValue("pwd", Cus_pwdTextBox.Text)
        cmd.Parameters.AddWithValue("id", Cus_idTextBox.Text)
        conn.Open()
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("EDIT SUCCESS")
        End If
        conn.Close()
        Me.CustomerTableAdapter.Fill(Me.BookShopDataSet.Customer)
    End Sub
End Class