Imports System.Data.SqlClient

Public Class book

    Private Sub BookBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.BookBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookShopDataSet)
    End Sub

    Private Sub book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookShopDataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.BookShopDataSet.Book)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=344_06\SQLEXPRESS;Initial Catalog=Bookshop;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("delete from Book where book_id = '" & Book_idTextBox.Text & "'", conn)
        conn.Open()
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("DELETE SUCCESS")
        End If
        conn.Close()
        Me.TableAdapterManager.UpdateAll(Me.BookShopDataSet)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=344_06\SQLEXPRESS;Initial Catalog=Bookshop;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("update book set book_name=@name, book_price=@price,book_amount=@amount WHERE book_id=@id", conn)
        cmd.Parameters.AddWithValue("name", Book_nameTextBox.Text)
        cmd.Parameters.AddWithValue("price", Book_priceTextBox.Text)
        cmd.Parameters.AddWithValue("amount", Book_amountTextBox.Text)
        cmd.Parameters.AddWithValue("id", Book_idTextBox.Text)
        conn.Open()
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("EDIT SUCCESS")
        End If
        conn.Close()
        Me.TableAdapterManager.UpdateAll(Me.BookShopDataSet)
    End Sub

End Class