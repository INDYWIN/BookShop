<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class book
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
        Me.components = New System.ComponentModel.Container()
        Dim Book_idLabel As System.Windows.Forms.Label
        Dim Book_nameLabel As System.Windows.Forms.Label
        Dim Book_priceLabel As System.Windows.Forms.Label
        Dim Book_amountLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(book))
        Me.BookShopDataSet = New BookShop.BookShopDataSet()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookTableAdapter = New BookShop.BookShopDataSetTableAdapters.BookTableAdapter()
        Me.TableAdapterManager = New BookShop.BookShopDataSetTableAdapters.TableAdapterManager()
        Me.BookBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BookDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Book_idTextBox = New System.Windows.Forms.TextBox()
        Me.Book_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Book_priceTextBox = New System.Windows.Forms.TextBox()
        Me.Book_amountTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BookBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Book_idLabel = New System.Windows.Forms.Label()
        Book_nameLabel = New System.Windows.Forms.Label()
        Book_priceLabel = New System.Windows.Forms.Label()
        Book_amountLabel = New System.Windows.Forms.Label()
        CType(Me.BookShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BookBindingNavigator.SuspendLayout()
        CType(Me.BookDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Book_idLabel
        '
        Book_idLabel.AutoSize = True
        Book_idLabel.Location = New System.Drawing.Point(69, 89)
        Book_idLabel.Name = "Book_idLabel"
        Book_idLabel.Size = New System.Drawing.Size(45, 13)
        Book_idLabel.TabIndex = 2
        Book_idLabel.Text = "book id:"
        '
        'Book_nameLabel
        '
        Book_nameLabel.AutoSize = True
        Book_nameLabel.Location = New System.Drawing.Point(69, 115)
        Book_nameLabel.Name = "Book_nameLabel"
        Book_nameLabel.Size = New System.Drawing.Size(63, 13)
        Book_nameLabel.TabIndex = 4
        Book_nameLabel.Text = "book name:"
        '
        'Book_priceLabel
        '
        Book_priceLabel.AutoSize = True
        Book_priceLabel.Location = New System.Drawing.Point(69, 141)
        Book_priceLabel.Name = "Book_priceLabel"
        Book_priceLabel.Size = New System.Drawing.Size(60, 13)
        Book_priceLabel.TabIndex = 6
        Book_priceLabel.Text = "book price:"
        '
        'Book_amountLabel
        '
        Book_amountLabel.AutoSize = True
        Book_amountLabel.Location = New System.Drawing.Point(69, 167)
        Book_amountLabel.Name = "Book_amountLabel"
        Book_amountLabel.Size = New System.Drawing.Size(72, 13)
        Book_amountLabel.TabIndex = 8
        Book_amountLabel.Text = "book amount:"
        '
        'BookShopDataSet
        '
        Me.BookShopDataSet.DataSetName = "BookShopDataSet"
        Me.BookShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookBindingSource
        '
        Me.BookBindingSource.DataMember = "Book"
        Me.BookBindingSource.DataSource = Me.BookShopDataSet
        '
        'BookTableAdapter
        '
        Me.BookTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Me.BookTableAdapter
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BookShop.BookShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BookBindingNavigator
        '
        Me.BookBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BookBindingNavigator.BindingSource = Me.BookBindingSource
        Me.BookBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BookBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BookBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BookBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.BookBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BookBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BookBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BookBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BookBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BookBindingNavigator.Name = "BookBindingNavigator"
        Me.BookBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BookBindingNavigator.Size = New System.Drawing.Size(784, 25)
        Me.BookBindingNavigator.TabIndex = 0
        Me.BookBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BookDataGridView
        '
        Me.BookDataGridView.AutoGenerateColumns = False
        Me.BookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.BookDataGridView.DataSource = Me.BookBindingSource
        Me.BookDataGridView.Location = New System.Drawing.Point(303, 62)
        Me.BookDataGridView.Name = "BookDataGridView"
        Me.BookDataGridView.Size = New System.Drawing.Size(442, 220)
        Me.BookDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "book_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "book_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "book_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "book_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "book_price"
        Me.DataGridViewTextBoxColumn3.HeaderText = "book_price"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "book_amount"
        Me.DataGridViewTextBoxColumn4.HeaderText = "book_amount"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Book_idTextBox
        '
        Me.Book_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "book_id", True))
        Me.Book_idTextBox.Location = New System.Drawing.Point(147, 86)
        Me.Book_idTextBox.Name = "Book_idTextBox"
        Me.Book_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Book_idTextBox.TabIndex = 3
        '
        'Book_nameTextBox
        '
        Me.Book_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "book_name", True))
        Me.Book_nameTextBox.Location = New System.Drawing.Point(147, 112)
        Me.Book_nameTextBox.Name = "Book_nameTextBox"
        Me.Book_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Book_nameTextBox.TabIndex = 5
        '
        'Book_priceTextBox
        '
        Me.Book_priceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "book_price", True))
        Me.Book_priceTextBox.Location = New System.Drawing.Point(147, 138)
        Me.Book_priceTextBox.Name = "Book_priceTextBox"
        Me.Book_priceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Book_priceTextBox.TabIndex = 7
        '
        'Book_amountTextBox
        '
        Me.Book_amountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "book_amount", True))
        Me.Book_amountTextBox.Location = New System.Drawing.Point(147, 164)
        Me.Book_amountTextBox.Name = "Book_amountTextBox"
        Me.Book_amountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Book_amountTextBox.TabIndex = 9
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BookBindingNavigatorSaveItem
        '
        Me.BookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BookBindingNavigatorSaveItem.Image = CType(resources.GetObject("BookBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BookBindingNavigatorSaveItem.Name = "BookBindingNavigatorSaveItem"
        Me.BookBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BookBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Book_idLabel)
        Me.Controls.Add(Me.Book_idTextBox)
        Me.Controls.Add(Book_nameLabel)
        Me.Controls.Add(Me.Book_nameTextBox)
        Me.Controls.Add(Book_priceLabel)
        Me.Controls.Add(Me.Book_priceTextBox)
        Me.Controls.Add(Book_amountLabel)
        Me.Controls.Add(Me.Book_amountTextBox)
        Me.Controls.Add(Me.BookDataGridView)
        Me.Controls.Add(Me.BookBindingNavigator)
        Me.Name = "book"
        Me.Text = "book"
        CType(Me.BookShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BookBindingNavigator.ResumeLayout(False)
        Me.BookBindingNavigator.PerformLayout()
        CType(Me.BookDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BookShopDataSet As BookShopDataSet
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents BookTableAdapter As BookShopDataSetTableAdapters.BookTableAdapter
    Friend WithEvents TableAdapterManager As BookShopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BookBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BookBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BookDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Book_idTextBox As TextBox
    Friend WithEvents Book_nameTextBox As TextBox
    Friend WithEvents Book_priceTextBox As TextBox
    Friend WithEvents Book_amountTextBox As TextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
