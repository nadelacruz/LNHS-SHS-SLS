<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class encode_students
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
        Dim LRNLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim MiddleNameLabel As System.Windows.Forms.Label
        Dim SectionLabel As System.Windows.Forms.Label
        Dim ContactNumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(encode_students))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me._LNHS_SHS_SLS_DATABASEDataSet = New LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSet()
        Me.StudentInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentInfoTableAdapter = New LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSetTableAdapters.StudentInfoTableAdapter()
        Me.TableAdapterManager = New LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.StudentInfoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StudentInfoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StudentInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LRNTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.SectionTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.PhotoIDTextBox = New System.Windows.Forms.TextBox()
        Me.sav_btn = New System.Windows.Forms.Button()
        Me.new_btn = New System.Windows.Forms.Button()
        Me.del_btn = New System.Windows.Forms.Button()
        Me.edit_btn = New System.Windows.Forms.Button()
        Me.next_btn = New System.Windows.Forms.Button()
        Me.prev_btn = New System.Windows.Forms.Button()
        Me.sec_cbox = New System.Windows.Forms.ComboBox()
        Me.selpht_btn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pht_picbox = New System.Windows.Forms.PictureBox()
        Me.SectionInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SectionInfoTableAdapter = New LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSetTableAdapters.SectionInfoTableAdapter()
        Me.SectionInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.srch_chkbox = New System.Windows.Forms.CheckBox()
        Me.lnamesch_txtbox = New System.Windows.Forms.TextBox()
        Me.fnamesch_txtbox = New System.Windows.Forms.TextBox()
        LRNLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        MiddleNameLabel = New System.Windows.Forms.Label()
        SectionLabel = New System.Windows.Forms.Label()
        ContactNumberLabel = New System.Windows.Forms.Label()
        CType(Me._LNHS_SHS_SLS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentInfoBindingNavigator.SuspendLayout()
        CType(Me.StudentInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pht_picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LRNLabel
        '
        LRNLabel.AutoSize = True
        LRNLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LRNLabel.Location = New System.Drawing.Point(141, 225)
        LRNLabel.Name = "LRNLabel"
        LRNLabel.Size = New System.Drawing.Size(67, 29)
        LRNLabel.TabIndex = 2
        LRNLabel.Text = "LRN:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.Location = New System.Drawing.Point(74, 266)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(134, 29)
        LastNameLabel.TabIndex = 4
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(71, 307)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(137, 29)
        FirstNameLabel.TabIndex = 6
        FirstNameLabel.Text = "First Name:"
        '
        'MiddleNameLabel
        '
        MiddleNameLabel.AutoSize = True
        MiddleNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MiddleNameLabel.Location = New System.Drawing.Point(44, 348)
        MiddleNameLabel.Name = "MiddleNameLabel"
        MiddleNameLabel.Size = New System.Drawing.Size(164, 29)
        MiddleNameLabel.TabIndex = 8
        MiddleNameLabel.Text = "Middle Name:"
        '
        'SectionLabel
        '
        SectionLabel.AutoSize = True
        SectionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SectionLabel.Location = New System.Drawing.Point(108, 389)
        SectionLabel.Name = "SectionLabel"
        SectionLabel.Size = New System.Drawing.Size(100, 29)
        SectionLabel.TabIndex = 10
        SectionLabel.Text = "Section:"
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.AutoSize = True
        ContactNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactNumberLabel.Location = New System.Drawing.Point(15, 430)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(193, 29)
        ContactNumberLabel.TabIndex = 12
        ContactNumberLabel.Text = "Contact Number:"
        '
        '_LNHS_SHS_SLS_DATABASEDataSet
        '
        Me._LNHS_SHS_SLS_DATABASEDataSet.DataSetName = "_LNHS_SHS_SLS_DATABASEDataSet"
        Me._LNHS_SHS_SLS_DATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentInfoBindingSource
        '
        Me.StudentInfoBindingSource.DataMember = "StudentInfo"
        Me.StudentInfoBindingSource.DataSource = Me._LNHS_SHS_SLS_DATABASEDataSet
        '
        'StudentInfoTableAdapter
        '
        Me.StudentInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ScheduleInfoTableAdapter = Nothing
        Me.TableAdapterManager.SectionInfoTableAdapter = Nothing
        Me.TableAdapterManager.StudentInfoTableAdapter = Me.StudentInfoTableAdapter
        Me.TableAdapterManager.UpdateOrder = LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StudentInfoBindingNavigator
        '
        Me.StudentInfoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentInfoBindingNavigator.BindingSource = Me.StudentInfoBindingSource
        Me.StudentInfoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentInfoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentInfoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentInfoBindingNavigatorSaveItem})
        Me.StudentInfoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentInfoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentInfoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentInfoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentInfoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentInfoBindingNavigator.Name = "StudentInfoBindingNavigator"
        Me.StudentInfoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentInfoBindingNavigator.Size = New System.Drawing.Size(1350, 25)
        Me.StudentInfoBindingNavigator.TabIndex = 0
        Me.StudentInfoBindingNavigator.Text = "BindingNavigator1"
        Me.StudentInfoBindingNavigator.Visible = False
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'StudentInfoBindingNavigatorSaveItem
        '
        Me.StudentInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentInfoBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentInfoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentInfoBindingNavigatorSaveItem.Name = "StudentInfoBindingNavigatorSaveItem"
        Me.StudentInfoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StudentInfoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StudentInfoDataGridView
        '
        Me.StudentInfoDataGridView.AllowUserToDeleteRows = False
        Me.StudentInfoDataGridView.AllowUserToOrderColumns = True
        Me.StudentInfoDataGridView.AllowUserToResizeColumns = False
        Me.StudentInfoDataGridView.AllowUserToResizeRows = False
        Me.StudentInfoDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentInfoDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.StudentInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.StudentInfoDataGridView.DataSource = Me.StudentInfoBindingSource
        Me.StudentInfoDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.StudentInfoDataGridView.Location = New System.Drawing.Point(477, 12)
        Me.StudentInfoDataGridView.Name = "StudentInfoDataGridView"
        Me.StudentInfoDataGridView.RowHeadersVisible = False
        Me.StudentInfoDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.StudentInfoDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.StudentInfoDataGridView.Size = New System.Drawing.Size(881, 665)
        Me.StudentInfoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "LRN"
        Me.DataGridViewTextBoxColumn1.HeaderText = "LRN"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 67
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 140
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 123
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MiddleName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Middle Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 148
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Section"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Section"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 119
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ContactNumber"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Contact Number"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 193
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PhotoID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Photo ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'LRNTextBox
        '
        Me.LRNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "LRN", True))
        Me.LRNTextBox.Enabled = False
        Me.LRNTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRNTextBox.Location = New System.Drawing.Point(214, 222)
        Me.LRNTextBox.MaxLength = 12
        Me.LRNTextBox.Name = "LRNTextBox"
        Me.LRNTextBox.Size = New System.Drawing.Size(257, 35)
        Me.LRNTextBox.TabIndex = 3
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "LastName", True))
        Me.LastNameTextBox.Enabled = False
        Me.LastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(214, 263)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(257, 35)
        Me.LastNameTextBox.TabIndex = 5
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Enabled = False
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(214, 304)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(257, 35)
        Me.FirstNameTextBox.TabIndex = 7
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "MiddleName", True))
        Me.MiddleNameTextBox.Enabled = False
        Me.MiddleNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(214, 345)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(257, 35)
        Me.MiddleNameTextBox.TabIndex = 9
        '
        'SectionTextBox
        '
        Me.SectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "Section", True))
        Me.SectionTextBox.Enabled = False
        Me.SectionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionTextBox.Location = New System.Drawing.Point(214, 386)
        Me.SectionTextBox.Name = "SectionTextBox"
        Me.SectionTextBox.Size = New System.Drawing.Size(257, 35)
        Me.SectionTextBox.TabIndex = 11
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "ContactNumber", True))
        Me.ContactNumberTextBox.Enabled = False
        Me.ContactNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(214, 427)
        Me.ContactNumberTextBox.MaxLength = 11
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(257, 35)
        Me.ContactNumberTextBox.TabIndex = 13
        '
        'PhotoIDTextBox
        '
        Me.PhotoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "PhotoID", True))
        Me.PhotoIDTextBox.Enabled = False
        Me.PhotoIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhotoIDTextBox.Location = New System.Drawing.Point(214, 468)
        Me.PhotoIDTextBox.Name = "PhotoIDTextBox"
        Me.PhotoIDTextBox.Size = New System.Drawing.Size(257, 35)
        Me.PhotoIDTextBox.TabIndex = 15
        '
        'sav_btn
        '
        Me.sav_btn.Enabled = False
        Me.sav_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sav_btn.Location = New System.Drawing.Point(214, 640)
        Me.sav_btn.Name = "sav_btn"
        Me.sav_btn.Size = New System.Drawing.Size(113, 37)
        Me.sav_btn.TabIndex = 147
        Me.sav_btn.Text = "Save"
        Me.sav_btn.UseVisualStyleBackColor = True
        '
        'new_btn
        '
        Me.new_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_btn.Location = New System.Drawing.Point(214, 580)
        Me.new_btn.Name = "new_btn"
        Me.new_btn.Size = New System.Drawing.Size(113, 37)
        Me.new_btn.TabIndex = 148
        Me.new_btn.Text = "New"
        Me.new_btn.UseVisualStyleBackColor = True
        '
        'del_btn
        '
        Me.del_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del_btn.Location = New System.Drawing.Point(346, 640)
        Me.del_btn.Name = "del_btn"
        Me.del_btn.Size = New System.Drawing.Size(113, 37)
        Me.del_btn.TabIndex = 149
        Me.del_btn.Text = "Delete"
        Me.del_btn.UseVisualStyleBackColor = True
        '
        'edit_btn
        '
        Me.edit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_btn.Location = New System.Drawing.Point(346, 580)
        Me.edit_btn.Name = "edit_btn"
        Me.edit_btn.Size = New System.Drawing.Size(113, 37)
        Me.edit_btn.TabIndex = 150
        Me.edit_btn.Text = "Edit"
        Me.edit_btn.UseVisualStyleBackColor = True
        '
        'next_btn
        '
        Me.next_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.next_btn.Location = New System.Drawing.Point(346, 522)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(113, 37)
        Me.next_btn.TabIndex = 151
        Me.next_btn.Text = "Next"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'prev_btn
        '
        Me.prev_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prev_btn.Location = New System.Drawing.Point(214, 522)
        Me.prev_btn.Name = "prev_btn"
        Me.prev_btn.Size = New System.Drawing.Size(113, 37)
        Me.prev_btn.TabIndex = 152
        Me.prev_btn.Text = "Previous"
        Me.prev_btn.UseVisualStyleBackColor = True
        '
        'sec_cbox
        '
        Me.sec_cbox.DropDownHeight = 188
        Me.sec_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sec_cbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sec_cbox.FormattingEnabled = True
        Me.sec_cbox.IntegralHeight = False
        Me.sec_cbox.Location = New System.Drawing.Point(214, 386)
        Me.sec_cbox.Name = "sec_cbox"
        Me.sec_cbox.Size = New System.Drawing.Size(257, 37)
        Me.sec_cbox.TabIndex = 153
        Me.sec_cbox.Visible = False
        '
        'selpht_btn
        '
        Me.selpht_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.selpht_btn.Enabled = False
        Me.selpht_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selpht_btn.Location = New System.Drawing.Point(49, 467)
        Me.selpht_btn.Name = "selpht_btn"
        Me.selpht_btn.Size = New System.Drawing.Size(159, 37)
        Me.selpht_btn.TabIndex = 152
        Me.selpht_btn.Text = "Select Photo"
        Me.selpht_btn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pht_picbox
        '
        Me.pht_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pht_picbox.Location = New System.Drawing.Point(232, 22)
        Me.pht_picbox.Name = "pht_picbox"
        Me.pht_picbox.Size = New System.Drawing.Size(216, 174)
        Me.pht_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pht_picbox.TabIndex = 154
        Me.pht_picbox.TabStop = False
        '
        'SectionInfoBindingSource
        '
        Me.SectionInfoBindingSource.DataMember = "SectionInfo"
        Me.SectionInfoBindingSource.DataSource = Me._LNHS_SHS_SLS_DATABASEDataSet
        '
        'SectionInfoTableAdapter
        '
        Me.SectionInfoTableAdapter.ClearBeforeFill = True
        '
        'SectionInfoDataGridView
        '
        Me.SectionInfoDataGridView.AutoGenerateColumns = False
        Me.SectionInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SectionInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.SectionInfoDataGridView.DataSource = Me.SectionInfoBindingSource
        Me.SectionInfoDataGridView.Location = New System.Drawing.Point(636, -18)
        Me.SectionInfoDataGridView.Name = "SectionInfoDataGridView"
        Me.SectionInfoDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.SectionInfoDataGridView.TabIndex = 154
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Section"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Section"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SectionAdviser"
        Me.DataGridViewTextBoxColumn9.HeaderText = "SectionAdviser"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "GradeLevel"
        Me.DataGridViewTextBoxColumn10.HeaderText = "GradeLevel"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Track"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Track"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Strand"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Strand"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ScheduleID"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ScheduleID"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'srch_chkbox
        '
        Me.srch_chkbox.AutoSize = True
        Me.srch_chkbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srch_chkbox.Location = New System.Drawing.Point(79, 527)
        Me.srch_chkbox.Name = "srch_chkbox"
        Me.srch_chkbox.Size = New System.Drawing.Size(94, 29)
        Me.srch_chkbox.TabIndex = 245
        Me.srch_chkbox.Text = "Search"
        Me.srch_chkbox.UseVisualStyleBackColor = True
        '
        'lnamesch_txtbox
        '
        Me.lnamesch_txtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.lnamesch_txtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.lnamesch_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnamesch_txtbox.Location = New System.Drawing.Point(214, 263)
        Me.lnamesch_txtbox.Name = "lnamesch_txtbox"
        Me.lnamesch_txtbox.Size = New System.Drawing.Size(257, 35)
        Me.lnamesch_txtbox.TabIndex = 5
        Me.lnamesch_txtbox.Visible = False
        '
        'fnamesch_txtbox
        '
        Me.fnamesch_txtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.fnamesch_txtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.fnamesch_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnamesch_txtbox.Location = New System.Drawing.Point(214, 304)
        Me.fnamesch_txtbox.Name = "fnamesch_txtbox"
        Me.fnamesch_txtbox.Size = New System.Drawing.Size(257, 35)
        Me.fnamesch_txtbox.TabIndex = 7
        Me.fnamesch_txtbox.Visible = False
        '
        'encode_students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.srch_chkbox)
        Me.Controls.Add(Me.SectionInfoDataGridView)
        Me.Controls.Add(Me.pht_picbox)
        Me.Controls.Add(Me.sec_cbox)
        Me.Controls.Add(Me.sav_btn)
        Me.Controls.Add(Me.new_btn)
        Me.Controls.Add(Me.del_btn)
        Me.Controls.Add(Me.edit_btn)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.selpht_btn)
        Me.Controls.Add(Me.prev_btn)
        Me.Controls.Add(LRNLabel)
        Me.Controls.Add(Me.LRNTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.lnamesch_txtbox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.fnamesch_txtbox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(MiddleNameLabel)
        Me.Controls.Add(Me.MiddleNameTextBox)
        Me.Controls.Add(SectionLabel)
        Me.Controls.Add(Me.SectionTextBox)
        Me.Controls.Add(ContactNumberLabel)
        Me.Controls.Add(Me.ContactNumberTextBox)
        Me.Controls.Add(Me.PhotoIDTextBox)
        Me.Controls.Add(Me.StudentInfoDataGridView)
        Me.Controls.Add(Me.StudentInfoBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "encode_students"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encode Students"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me._LNHS_SHS_SLS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentInfoBindingNavigator.ResumeLayout(False)
        Me.StudentInfoBindingNavigator.PerformLayout()
        CType(Me.StudentInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pht_picbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _LNHS_SHS_SLS_DATABASEDataSet As LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSet
    Friend WithEvents StudentInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentInfoTableAdapter As LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSetTableAdapters.StudentInfoTableAdapter
    Friend WithEvents TableAdapterManager As LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentInfoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StudentInfoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StudentInfoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LRNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiddleNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SectionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhotoIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents sav_btn As System.Windows.Forms.Button
    Friend WithEvents new_btn As System.Windows.Forms.Button
    Friend WithEvents del_btn As System.Windows.Forms.Button
    Friend WithEvents edit_btn As System.Windows.Forms.Button
    Friend WithEvents next_btn As System.Windows.Forms.Button
    Friend WithEvents prev_btn As System.Windows.Forms.Button
    Friend WithEvents sec_cbox As System.Windows.Forms.ComboBox
    Friend WithEvents selpht_btn As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pht_picbox As System.Windows.Forms.PictureBox
    Friend WithEvents SectionInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SectionInfoTableAdapter As LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSetTableAdapters.SectionInfoTableAdapter
    Friend WithEvents SectionInfoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents srch_chkbox As System.Windows.Forms.CheckBox
    Friend WithEvents lnamesch_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents fnamesch_txtbox As System.Windows.Forms.TextBox
End Class
