Imports System.Data.SqlClient
Public Class sale
    Private Sub tb_add_Click(sender As Object, e As EventArgs) Handles tb_add.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-7B686JL\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from Book where book_id = '" & tb_id.Text & "'", conn)
        Dim adap As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        adap.Fill(dt)
        Dim rowID As Integer = DataGridViewSale.Rows.Add()
        Dim row As DataGridViewRow = DataGridViewSale.Rows(rowID)
        row.Cells("Book_id").Value = dt.Rows(0).Item("book_id")
        row.Cells("Book_name").Value = dt.Rows(0).Item("book_name")
        row.Cells("Book_price").Value = dt.Rows(0).Item("book_price")
        row.Cells("Book_Amount").Value = tb_amount.Text
        row.Cells("Book_sum").Value = row.Cells("Book_price").Value * row.Cells("Book_Amount").Value
        Dim total As Integer = 0
        For Each dataRow As DataGridViewRow In DataGridViewSale.Rows
            total += dataRow.Cells("Book_sum").Value
        Next
        tb_total.Text = total
    End Sub

    Private Sub tb_cash_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_cash.KeyUp
        la_change.Text = tb_cash.Text - tb_total.Text
    End Sub

    Private Sub bt_buy_Click(sender As Object, e As EventArgs) Handles bt_buy.Click
        For Each dataRow As DataGridViewRow In DataGridViewSale.Rows
            Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-7B686JL\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("select * from Book where book_id = '" & dataRow.Cells("Book_id").Value & "'", conn)
            Dim adap As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            adap.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim conn2 As SqlConnection = New SqlConnection("Data Source=DESKTOP-7B686JL\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True")
                Dim cmd2 As SqlCommand = New SqlCommand("update Book set book_amount = '" & dt.Rows(0).Item("Book_Amount") - dataRow.Cells("Book_Amount").Value & "' WHERE book_id  = '" & dataRow.Cells("Book_id") & "'", conn2)
                conn2.Open()
                If cmd2.ExecuteNonQuery() Then
                    MessageBox.Show("Sale SUCCESS")
                End If
                conn2.Close()
            End If
        Next
    End Sub
End Class