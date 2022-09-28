Public Class main
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frm_login.Show()
        Me.Hide()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        customer.MdiParent = main.ActiveForm
        customer.Dock = DockStyle.Fill
        customer.Show()

    End Sub

    Private Sub BookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem.Click
        book.MdiParent = main.ActiveForm
        book.Dock = DockStyle.Fill
        book.Show()
    End Sub

    Private Sub SaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaleToolStripMenuItem.Click
        sale.MdiParent = main.ActiveForm
        sale.Dock = DockStyle.Fill
        sale.Show()
    End Sub

End Class
