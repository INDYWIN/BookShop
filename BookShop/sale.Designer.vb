<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tb_add = New System.Windows.Forms.Button()
        Me.tb_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewSale = New System.Windows.Forms.DataGridView()
        Me.Book_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Book_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Book_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Book_Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Book_Sum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_amount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_total = New System.Windows.Forms.TextBox()
        Me.tb_cash = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.la_change = New System.Windows.Forms.Label()
        Me.bt_buy = New System.Windows.Forms.Button()
        CType(Me.DataGridViewSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_add
        '
        Me.tb_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_add.Location = New System.Drawing.Point(170, 11)
        Me.tb_add.Name = "tb_add"
        Me.tb_add.Size = New System.Drawing.Size(47, 23)
        Me.tb_add.TabIndex = 0
        Me.tb_add.Text = "ADD"
        Me.tb_add.UseVisualStyleBackColor = True
        '
        'tb_id
        '
        Me.tb_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.Location = New System.Drawing.Point(89, 12)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Size = New System.Drawing.Size(75, 21)
        Me.tb_id.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "รหัสหนังสือ"
        '
        'DataGridViewSale
        '
        Me.DataGridViewSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Book_id, Me.Book_name, Me.Book_price, Me.Book_Amount, Me.Book_Sum})
        Me.DataGridViewSale.Location = New System.Drawing.Point(220, 12)
        Me.DataGridViewSale.Name = "DataGridViewSale"
        Me.DataGridViewSale.Size = New System.Drawing.Size(552, 258)
        Me.DataGridViewSale.TabIndex = 3
        '
        'Book_id
        '
        Me.Book_id.HeaderText = "รหัสหนังสือ"
        Me.Book_id.Name = "Book_id"
        '
        'Book_name
        '
        Me.Book_name.HeaderText = "ชื่อหนังสือ"
        Me.Book_name.Name = "Book_name"
        Me.Book_name.Width = 160
        '
        'Book_price
        '
        Me.Book_price.HeaderText = "ราคาหนังสือ"
        Me.Book_price.Name = "Book_price"
        '
        'Book_Amount
        '
        Me.Book_Amount.HeaderText = "จำนวนหนังสือ"
        Me.Book_Amount.Name = "Book_Amount"
        '
        'Book_Sum
        '
        Me.Book_Sum.HeaderText = "รวม"
        Me.Book_Sum.Name = "Book_Sum"
        Me.Book_Sum.Width = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "จำนวน"
        '
        'tb_amount
        '
        Me.tb_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_amount.Location = New System.Drawing.Point(89, 50)
        Me.tb_amount.Name = "tb_amount"
        Me.tb_amount.Size = New System.Drawing.Size(75, 21)
        Me.tb_amount.TabIndex = 5
        Me.tb_amount.Text = "1"
        Me.tb_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(657, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "รวม"
        '
        'tb_total
        '
        Me.tb_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_total.Location = New System.Drawing.Point(697, 276)
        Me.tb_total.Name = "tb_total"
        Me.tb_total.Size = New System.Drawing.Size(75, 21)
        Me.tb_total.TabIndex = 7
        '
        'tb_cash
        '
        Me.tb_cash.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cash.Location = New System.Drawing.Point(569, 276)
        Me.tb_cash.Name = "tb_cash"
        Me.tb_cash.Size = New System.Drawing.Size(75, 21)
        Me.tb_cash.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(498, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "รับเงินมา"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(219, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ถอน"
        '
        'la_change
        '
        Me.la_change.AutoSize = True
        Me.la_change.Location = New System.Drawing.Point(261, 281)
        Me.la_change.Name = "la_change"
        Me.la_change.Size = New System.Drawing.Size(34, 13)
        Me.la_change.TabIndex = 11
        Me.la_change.Text = "........."
        '
        'bt_buy
        '
        Me.bt_buy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_buy.Location = New System.Drawing.Point(725, 303)
        Me.bt_buy.Name = "bt_buy"
        Me.bt_buy.Size = New System.Drawing.Size(47, 23)
        Me.bt_buy.TabIndex = 12
        Me.bt_buy.Text = "BUY"
        Me.bt_buy.UseVisualStyleBackColor = True
        '
        'sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.bt_buy)
        Me.Controls.Add(Me.la_change)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_cash)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_amount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridViewSale)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_id)
        Me.Controls.Add(Me.tb_add)
        Me.Name = "sale"
        Me.Text = "sale"
        CType(Me.DataGridViewSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_add As Button
    Friend WithEvents tb_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewSale As DataGridView
    Friend WithEvents Book_id As DataGridViewTextBoxColumn
    Friend WithEvents Book_name As DataGridViewTextBoxColumn
    Friend WithEvents Book_price As DataGridViewTextBoxColumn
    Friend WithEvents Book_Amount As DataGridViewTextBoxColumn
    Friend WithEvents Book_Sum As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_amount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_total As TextBox
    Friend WithEvents tb_cash As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents la_change As Label
    Friend WithEvents bt_buy As Button
End Class
