<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class encode_section
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
        Dim SectionLabel As System.Windows.Forms.Label
        Dim GradeLevelLabel As System.Windows.Forms.Label
        Dim TrackLabel As System.Windows.Forms.Label
        Dim StrandLabel As System.Windows.Forms.Label
        Dim ScheduleIDLabel As System.Windows.Forms.Label
        Dim SectionAdviserLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(encode_section))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SectionInfoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.SectionInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._LNHS_SHS_SLS_DATABASEDataSet = New LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSet()
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
        Me.SectionInfoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SectionTextBox = New System.Windows.Forms.TextBox()
        Me.GradeLevelTextBox = New System.Windows.Forms.TextBox()
        Me.TrackTextBox = New System.Windows.Forms.TextBox()
        Me.StrandTextBox = New System.Windows.Forms.TextBox()
        Me.ScheduleIDTextBox = New System.Windows.Forms.TextBox()
        Me.sav_btn = New System.Windows.Forms.Button()
        Me.new_btn = New System.Windows.Forms.Button()
        Me.del_btn = New System.Windows.Forms.Button()
        Me.edit_btn = New System.Windows.Forms.Button()
        Me.next_btn = New System.Windows.Forms.Button()
        Me.prev_btn = New System.Windows.Forms.Button()
        Me.schedid_cbox = New System.Windows.Forms.ComboBox()
        Me.strand_cbox = New System.Windows.Forms.ComboBox()
        Me.track_cbox = New System.Windows.Forms.ComboBox()
        Me.glevel_cbox = New System.Windows.Forms.ComboBox()
        Me.SectionAdviserTextBox = New System.Windows.Forms.TextBox()
        Me.SectionInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionInfoTableAdapter = New LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSetTableAdapters.SectionInfoTableAdapter()
        Me.TableAdapterManager = New LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.ScheduleInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScheduleInfoTableAdapter = New LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSetTableAdapters.ScheduleInfoTableAdapter()
        Me.ScheduleInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.srch_chkbox = New System.Windows.Forms.CheckBox()
        Me.sch_txtbox = New System.Windows.Forms.TextBox()
        SectionLabel = New System.Windows.Forms.Label()
        GradeLevelLabel = New System.Windows.Forms.Label()
        TrackLabel = New System.Windows.Forms.Label()
        StrandLabel = New System.Windows.Forms.Label()
        ScheduleIDLabel = New System.Windows.Forms.Label()
        SectionAdviserLabel = New System.Windows.Forms.Label()
        CType(Me.SectionInfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SectionInfoBindingNavigator.SuspendLayout()
        CType(Me.SectionInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._LNHS_SHS_SLS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduleInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduleInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SectionLabel
        '
        SectionLabel.AutoSize = True
        SectionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SectionLabel.Location = New System.Drawing.Point(100, 134)
        SectionLabel.Name = "SectionLabel"
        SectionLabel.Size = New System.Drawing.Size(100, 29)
        SectionLabel.TabIndex = 2
        SectionLabel.Text = "Section:"
        '
        'GradeLevelLabel
        '
        GradeLevelLabel.AutoSize = True
        GradeLevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GradeLevelLabel.Location = New System.Drawing.Point(50, 216)
        GradeLevelLabel.Name = "GradeLevelLabel"
        GradeLevelLabel.Size = New System.Drawing.Size(150, 29)
        GradeLevelLabel.TabIndex = 4
        GradeLevelLabel.Text = "Grade Level:"
        '
        'TrackLabel
        '
        TrackLabel.AutoSize = True
        TrackLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TrackLabel.Location = New System.Drawing.Point(120, 259)
        TrackLabel.Name = "TrackLabel"
        TrackLabel.Size = New System.Drawing.Size(80, 29)
        TrackLabel.TabIndex = 6
        TrackLabel.Text = "Track:"
        '
        'StrandLabel
        '
        StrandLabel.AutoSize = True
        StrandLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StrandLabel.Location = New System.Drawing.Point(111, 300)
        StrandLabel.Name = "StrandLabel"
        StrandLabel.Size = New System.Drawing.Size(89, 29)
        StrandLabel.TabIndex = 8
        StrandLabel.Text = "Strand:"
        '
        'ScheduleIDLabel
        '
        ScheduleIDLabel.AutoSize = True
        ScheduleIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ScheduleIDLabel.Location = New System.Drawing.Point(50, 341)
        ScheduleIDLabel.Name = "ScheduleIDLabel"
        ScheduleIDLabel.Size = New System.Drawing.Size(150, 29)
        ScheduleIDLabel.TabIndex = 10
        ScheduleIDLabel.Text = "Schedule ID:"
        '
        'SectionAdviserLabel
        '
        SectionAdviserLabel.AutoSize = True
        SectionAdviserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SectionAdviserLabel.Location = New System.Drawing.Point(14, 175)
        SectionAdviserLabel.Name = "SectionAdviserLabel"
        SectionAdviserLabel.Size = New System.Drawing.Size(186, 29)
        SectionAdviserLabel.TabIndex = 148
        SectionAdviserLabel.Text = "Section Adviser:"
        '
        'SectionInfoBindingNavigator
        '
        Me.SectionInfoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SectionInfoBindingNavigator.BindingSource = Me.SectionInfoBindingSource
        Me.SectionInfoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SectionInfoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SectionInfoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SectionInfoBindingNavigatorSaveItem})
        Me.SectionInfoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SectionInfoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SectionInfoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SectionInfoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SectionInfoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SectionInfoBindingNavigator.Name = "SectionInfoBindingNavigator"
        Me.SectionInfoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SectionInfoBindingNavigator.Size = New System.Drawing.Size(1358, 25)
        Me.SectionInfoBindingNavigator.TabIndex = 0
        Me.SectionInfoBindingNavigator.Text = "BindingNavigator1"
        Me.SectionInfoBindingNavigator.Visible = False
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
        'SectionInfoBindingSource
        '
        Me.SectionInfoBindingSource.DataMember = "SectionInfo"
        Me.SectionInfoBindingSource.DataSource = Me._LNHS_SHS_SLS_DATABASEDataSet
        '
        '_LNHS_SHS_SLS_DATABASEDataSet
        '
        Me._LNHS_SHS_SLS_DATABASEDataSet.DataSetName = "_LNHS_SHS_SLS_DATABASEDataSet"
        Me._LNHS_SHS_SLS_DATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'SectionInfoBindingNavigatorSaveItem
        '
        Me.SectionInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SectionInfoBindingNavigatorSaveItem.Image = CType(resources.GetObject("SectionInfoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SectionInfoBindingNavigatorSaveItem.Name = "SectionInfoBindingNavigatorSaveItem"
        Me.SectionInfoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SectionInfoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SectionTextBox
        '
        Me.SectionTextBox.AutoCompleteCustomSource.AddRange(New String() {"Adams", "Adobo", "Android", "Asset", "Avocado", "B. Nebres", "Bolin", "Brave", "Chico", "Comenius", "Cooperative", "Corporation", "Cupcake", "Dale", "Donut", "E. Quisimbing", "Emerson", "Equity", "Feldman", "Ghandi", "Helpful", "Honest", "Hopper", "Income", "Innis", "Joaquin", "L. Bellardo", "Lemon", "Linux", "Loyal", "Macintosh", "Makabansa", "Makadiyos", "Makakalikasan", "Makasining", "Makatao", "Makawika", "Mango", "Marshmallow", "Operation", "Oracle", "Orange", "P. Campos", "Paracetamol", "Partnership", "Q. Zara", "Ram", "Reverent", "Router", "Sisig", "Telecom", "Trustworthy", "Turbo C", "Variable"})
        Me.SectionTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SectionTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SectionInfoBindingSource, "Section", True))
        Me.SectionTextBox.Enabled = False
        Me.SectionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionTextBox.Location = New System.Drawing.Point(206, 131)
        Me.SectionTextBox.Name = "SectionTextBox"
        Me.SectionTextBox.Size = New System.Drawing.Size(350, 35)
        Me.SectionTextBox.TabIndex = 3
        '
        'GradeLevelTextBox
        '
        Me.GradeLevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SectionInfoBindingSource, "GradeLevel", True))
        Me.GradeLevelTextBox.Enabled = False
        Me.GradeLevelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeLevelTextBox.Location = New System.Drawing.Point(206, 215)
        Me.GradeLevelTextBox.Name = "GradeLevelTextBox"
        Me.GradeLevelTextBox.Size = New System.Drawing.Size(350, 35)
        Me.GradeLevelTextBox.TabIndex = 5
        '
        'TrackTextBox
        '
        Me.TrackTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SectionInfoBindingSource, "Track", True))
        Me.TrackTextBox.Enabled = False
        Me.TrackTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrackTextBox.Location = New System.Drawing.Point(206, 256)
        Me.TrackTextBox.Name = "TrackTextBox"
        Me.TrackTextBox.Size = New System.Drawing.Size(350, 35)
        Me.TrackTextBox.TabIndex = 7
        '
        'StrandTextBox
        '
        Me.StrandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SectionInfoBindingSource, "Strand", True))
        Me.StrandTextBox.Enabled = False
        Me.StrandTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StrandTextBox.Location = New System.Drawing.Point(206, 297)
        Me.StrandTextBox.Name = "StrandTextBox"
        Me.StrandTextBox.Size = New System.Drawing.Size(350, 35)
        Me.StrandTextBox.TabIndex = 9
        '
        'ScheduleIDTextBox
        '
        Me.ScheduleIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SectionInfoBindingSource, "ScheduleID", True))
        Me.ScheduleIDTextBox.Enabled = False
        Me.ScheduleIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduleIDTextBox.Location = New System.Drawing.Point(206, 338)
        Me.ScheduleIDTextBox.Name = "ScheduleIDTextBox"
        Me.ScheduleIDTextBox.Size = New System.Drawing.Size(350, 35)
        Me.ScheduleIDTextBox.TabIndex = 11
        '
        'sav_btn
        '
        Me.sav_btn.Enabled = False
        Me.sav_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sav_btn.Location = New System.Drawing.Point(247, 559)
        Me.sav_btn.Name = "sav_btn"
        Me.sav_btn.Size = New System.Drawing.Size(113, 37)
        Me.sav_btn.TabIndex = 141
        Me.sav_btn.TabStop = False
        Me.sav_btn.Text = "Save"
        Me.sav_btn.UseVisualStyleBackColor = True
        '
        'new_btn
        '
        Me.new_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_btn.Location = New System.Drawing.Point(247, 500)
        Me.new_btn.Name = "new_btn"
        Me.new_btn.Size = New System.Drawing.Size(113, 37)
        Me.new_btn.TabIndex = 142
        Me.new_btn.TabStop = False
        Me.new_btn.Text = "New"
        Me.new_btn.UseVisualStyleBackColor = True
        '
        'del_btn
        '
        Me.del_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del_btn.Location = New System.Drawing.Point(379, 559)
        Me.del_btn.Name = "del_btn"
        Me.del_btn.Size = New System.Drawing.Size(113, 37)
        Me.del_btn.TabIndex = 143
        Me.del_btn.TabStop = False
        Me.del_btn.Text = "Delete"
        Me.del_btn.UseVisualStyleBackColor = True
        '
        'edit_btn
        '
        Me.edit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_btn.Location = New System.Drawing.Point(379, 499)
        Me.edit_btn.Name = "edit_btn"
        Me.edit_btn.Size = New System.Drawing.Size(113, 37)
        Me.edit_btn.TabIndex = 144
        Me.edit_btn.TabStop = False
        Me.edit_btn.Text = "Edit"
        Me.edit_btn.UseVisualStyleBackColor = True
        '
        'next_btn
        '
        Me.next_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.next_btn.Location = New System.Drawing.Point(379, 437)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(113, 37)
        Me.next_btn.TabIndex = 145
        Me.next_btn.TabStop = False
        Me.next_btn.Text = "Next"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'prev_btn
        '
        Me.prev_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prev_btn.Location = New System.Drawing.Point(247, 437)
        Me.prev_btn.Name = "prev_btn"
        Me.prev_btn.Size = New System.Drawing.Size(113, 37)
        Me.prev_btn.TabIndex = 146
        Me.prev_btn.TabStop = False
        Me.prev_btn.Text = "Previous"
        Me.prev_btn.UseVisualStyleBackColor = True
        '
        'schedid_cbox
        '
        Me.schedid_cbox.DropDownHeight = 188
        Me.schedid_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.schedid_cbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.schedid_cbox.FormattingEnabled = True
        Me.schedid_cbox.IntegralHeight = False
        Me.schedid_cbox.Location = New System.Drawing.Point(206, 338)
        Me.schedid_cbox.Name = "schedid_cbox"
        Me.schedid_cbox.Size = New System.Drawing.Size(350, 37)
        Me.schedid_cbox.TabIndex = 147
        Me.schedid_cbox.Visible = False
        '
        'strand_cbox
        '
        Me.strand_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.strand_cbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strand_cbox.FormattingEnabled = True
        Me.strand_cbox.Location = New System.Drawing.Point(206, 297)
        Me.strand_cbox.Name = "strand_cbox"
        Me.strand_cbox.Size = New System.Drawing.Size(350, 37)
        Me.strand_cbox.TabIndex = 148
        Me.strand_cbox.Visible = False
        '
        'track_cbox
        '
        Me.track_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.track_cbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.track_cbox.FormattingEnabled = True
        Me.track_cbox.Items.AddRange(New Object() {"Academic", "Technical Vocational Livelihood"})
        Me.track_cbox.Location = New System.Drawing.Point(206, 256)
        Me.track_cbox.Name = "track_cbox"
        Me.track_cbox.Size = New System.Drawing.Size(350, 37)
        Me.track_cbox.TabIndex = 148
        Me.track_cbox.Visible = False
        '
        'glevel_cbox
        '
        Me.glevel_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.glevel_cbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glevel_cbox.FormattingEnabled = True
        Me.glevel_cbox.Items.AddRange(New Object() {"11", "12"})
        Me.glevel_cbox.Location = New System.Drawing.Point(206, 213)
        Me.glevel_cbox.Name = "glevel_cbox"
        Me.glevel_cbox.Size = New System.Drawing.Size(350, 37)
        Me.glevel_cbox.TabIndex = 148
        Me.glevel_cbox.Visible = False
        '
        'SectionAdviserTextBox
        '
        Me.SectionAdviserTextBox.AutoCompleteCustomSource.AddRange(New String() {"AIRRA MAE A. DACUT", "ALETH YVONNE B. BUSA", "ALMER H. BUGAL", "ANNABELLE C. PILANDE", "CESAR M. BRILLO", "CHARIGOLD G. PABILLON", "CHARMAINE JOYCE P. LAGAS", "CRIS GWYNGIE O. PONTERRADA", "DARREL M. SUSAYA", "DAVY T. VACALCCR", "ED LESTER V. CAGATAN", "EDUARDO FAJARDO", "EDUARDO P. SIVELLITA", "EDUARDO R. GALAPON III", "ELVIRA A. FLORES", "EMELIE D. MACAYAN", "EMMANUEL S. COLETE", "EMMARNIE S. ESTOQUE", "FELISA P. MAKINANO", "FERDINAND A. NEGROS", "FERDINAND BOCO", "FERDINAND REGINE H. BOCO", "GERALDINE REINA S. PIANDONG", "GWEN SANO", "JOCELYN T. BALAGUSA", "JOEL LABADO", "JULIANA C. ARPON", "JULIETA C. MONTEFOLKA", "LEAH AMOR V. FELICILDA", "LESLIE DARWIN D.", "LYNIE P. LENGUA", "MA. CELESTINA CAIMOY", "MA. JESSA LI A. CARILLA", "MANETH B. VIVERO", "MANSUETO S. PACA-ANAS JR.", "MARBETH CANEZO", "MARIA LIEZEL L. MOLON, MAT", "MARIAN N. RAMOS", "MARISA A. CUENTO", "MARISSA R. SADIA", "MARY JANE G. GALAN", "NORLANIE A. RICAFRANCA", "OMAIRAH S. MALAWI", "PEARLY ANN C. JERVOSO", "RAMIL B. CAPAMBI", "RAMIL CAPAMBI", "RENATO S. TANCONTIAN", "RENZY KIEL A. AGUILON", "ROLANDO B. VIDAN", "ROMEL C. DAGAMI", "ROSEVILLA G. BABIDA", "RYAN JOSEPH M. SALANO", "RYAN PAUL NIONES", "SHERMIN C. CUEVAS", "VALENTE O. TAYANES"})
        Me.SectionAdviserTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SectionAdviserTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SectionAdviserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SectionInfoBindingSource, "SectionAdviser", True))
        Me.SectionAdviserTextBox.Enabled = False
        Me.SectionAdviserTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionAdviserTextBox.Location = New System.Drawing.Point(206, 172)
        Me.SectionAdviserTextBox.Name = "SectionAdviserTextBox"
        Me.SectionAdviserTextBox.Size = New System.Drawing.Size(350, 35)
        Me.SectionAdviserTextBox.TabIndex = 149
        '
        'SectionInfoDataGridView
        '
        Me.SectionInfoDataGridView.AllowUserToOrderColumns = True
        Me.SectionInfoDataGridView.AllowUserToResizeColumns = False
        Me.SectionInfoDataGridView.AllowUserToResizeRows = False
        Me.SectionInfoDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SectionInfoDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.SectionInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SectionInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.SectionInfoDataGridView.DataSource = Me.SectionInfoBindingSource
        Me.SectionInfoDataGridView.Location = New System.Drawing.Point(562, 12)
        Me.SectionInfoDataGridView.Name = "SectionInfoDataGridView"
        Me.SectionInfoDataGridView.ReadOnly = True
        Me.SectionInfoDataGridView.RowHeadersVisible = False
        Me.SectionInfoDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SectionInfoDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.SectionInfoDataGridView.Size = New System.Drawing.Size(796, 674)
        Me.SectionInfoDataGridView.TabIndex = 149
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Section"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Section"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SectionAdviser"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Section Adviser"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 167
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GradeLevel"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Grade Level"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 154
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Track"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Track"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 99
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Strand"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Strand"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 108
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ScheduleID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Schedule ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 135
        '
        'SectionInfoTableAdapter
        '
        Me.SectionInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ScheduleInfoTableAdapter = Nothing
        Me.TableAdapterManager.SectionInfoTableAdapter = Me.SectionInfoTableAdapter
        Me.TableAdapterManager.StudentInfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ScheduleInfoBindingSource
        '
        Me.ScheduleInfoBindingSource.DataMember = "ScheduleInfo"
        Me.ScheduleInfoBindingSource.DataSource = Me._LNHS_SHS_SLS_DATABASEDataSet
        '
        'ScheduleInfoTableAdapter
        '
        Me.ScheduleInfoTableAdapter.ClearBeforeFill = True
        '
        'ScheduleInfoDataGridView
        '
        Me.ScheduleInfoDataGridView.AutoGenerateColumns = False
        Me.ScheduleInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScheduleInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37})
        Me.ScheduleInfoDataGridView.DataSource = Me.ScheduleInfoBindingSource
        Me.ScheduleInfoDataGridView.Location = New System.Drawing.Point(745, -18)
        Me.ScheduleInfoDataGridView.Name = "ScheduleInfoDataGridView"
        Me.ScheduleInfoDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.ScheduleInfoDataGridView.TabIndex = 149
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SubjectOne"
        Me.DataGridViewTextBoxColumn7.HeaderText = "SubjectOne"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TeacherOne"
        Me.DataGridViewTextBoxColumn8.HeaderText = "TeacherOne"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "LocationOne"
        Me.DataGridViewTextBoxColumn9.HeaderText = "LocationOne"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SubjectTwo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "SubjectTwo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TeacherTwo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "TeacherTwo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "LocationTwo"
        Me.DataGridViewTextBoxColumn12.HeaderText = "LocationTwo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "SubjectThree"
        Me.DataGridViewTextBoxColumn13.HeaderText = "SubjectThree"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TeacherThree"
        Me.DataGridViewTextBoxColumn14.HeaderText = "TeacherThree"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "LocationThree"
        Me.DataGridViewTextBoxColumn15.HeaderText = "LocationThree"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "SubjectFour"
        Me.DataGridViewTextBoxColumn16.HeaderText = "SubjectFour"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "TeacherFour"
        Me.DataGridViewTextBoxColumn17.HeaderText = "TeacherFour"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "LocationFour"
        Me.DataGridViewTextBoxColumn18.HeaderText = "LocationFour"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "SubjectFive"
        Me.DataGridViewTextBoxColumn19.HeaderText = "SubjectFive"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "TeacherFive"
        Me.DataGridViewTextBoxColumn20.HeaderText = "TeacherFive"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "LocationFIve"
        Me.DataGridViewTextBoxColumn21.HeaderText = "LocationFIve"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "SubjectSix"
        Me.DataGridViewTextBoxColumn22.HeaderText = "SubjectSix"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "TeacherSix"
        Me.DataGridViewTextBoxColumn23.HeaderText = "TeacherSix"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "LocationSix"
        Me.DataGridViewTextBoxColumn24.HeaderText = "LocationSix"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "SubectSeven"
        Me.DataGridViewTextBoxColumn25.HeaderText = "SubectSeven"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "TeacherSeven"
        Me.DataGridViewTextBoxColumn26.HeaderText = "TeacherSeven"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "LocationSeven"
        Me.DataGridViewTextBoxColumn27.HeaderText = "LocationSeven"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "SubjectEight"
        Me.DataGridViewTextBoxColumn28.HeaderText = "SubjectEight"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "TeacherEight"
        Me.DataGridViewTextBoxColumn29.HeaderText = "TeacherEight"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "LocationEight"
        Me.DataGridViewTextBoxColumn30.HeaderText = "LocationEight"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "SubjectNine"
        Me.DataGridViewTextBoxColumn31.HeaderText = "SubjectNine"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "TeacherNine"
        Me.DataGridViewTextBoxColumn32.HeaderText = "TeacherNine"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "LocationNine"
        Me.DataGridViewTextBoxColumn33.HeaderText = "LocationNine"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "SubjectTen"
        Me.DataGridViewTextBoxColumn34.HeaderText = "SubjectTen"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "TeacherTen"
        Me.DataGridViewTextBoxColumn35.HeaderText = "TeacherTen"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "LocationTen"
        Me.DataGridViewTextBoxColumn36.HeaderText = "LocationTen"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "ScheduleID"
        Me.DataGridViewTextBoxColumn37.HeaderText = "ScheduleID"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'srch_chkbox
        '
        Me.srch_chkbox.AutoSize = True
        Me.srch_chkbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srch_chkbox.Location = New System.Drawing.Point(325, 391)
        Me.srch_chkbox.Name = "srch_chkbox"
        Me.srch_chkbox.Size = New System.Drawing.Size(94, 29)
        Me.srch_chkbox.TabIndex = 245
        Me.srch_chkbox.Text = "Search"
        Me.srch_chkbox.UseVisualStyleBackColor = True
        '
        'sch_txtbox
        '
        Me.sch_txtbox.AutoCompleteCustomSource.AddRange(New String() {"Adams", "Adobo", "Android", "Asset", "Avocado", "B. Nebres", "Bolin", "Brave", "Chico", "Comenius", "Cooperative", "Corporation", "Cupcake", "Dale", "Donut", "E. Quisimbing", "Emerson", "Equity", "Feldman", "Ghandi", "Helpful", "Honest", "Hopper", "Income", "Innis", "Joaquin", "L. Bellardo", "Lemon", "Linux", "Loyal", "Macintosh", "Makabansa", "Makadiyos", "Makakalikasan", "Makasining", "Makatao", "Makawika", "Mango", "Marshmallow", "Operation", "Oracle", "Orange", "P. Campos", "Paracetamol", "Partnership", "Q. Zara", "Ram", "Reverent", "Router", "Sisig", "Telecom", "Trustworthy", "Turbo C", "Variable"})
        Me.sch_txtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.sch_txtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.sch_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sch_txtbox.Location = New System.Drawing.Point(206, 131)
        Me.sch_txtbox.Name = "sch_txtbox"
        Me.sch_txtbox.Size = New System.Drawing.Size(350, 35)
        Me.sch_txtbox.TabIndex = 3
        Me.sch_txtbox.Visible = False
        '
        'encode_section
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.srch_chkbox)
        Me.Controls.Add(Me.ScheduleInfoDataGridView)
        Me.Controls.Add(Me.SectionInfoDataGridView)
        Me.Controls.Add(SectionAdviserLabel)
        Me.Controls.Add(Me.SectionAdviserTextBox)
        Me.Controls.Add(Me.glevel_cbox)
        Me.Controls.Add(Me.track_cbox)
        Me.Controls.Add(Me.strand_cbox)
        Me.Controls.Add(Me.schedid_cbox)
        Me.Controls.Add(Me.sav_btn)
        Me.Controls.Add(Me.new_btn)
        Me.Controls.Add(Me.del_btn)
        Me.Controls.Add(Me.edit_btn)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.prev_btn)
        Me.Controls.Add(SectionLabel)
        Me.Controls.Add(Me.sch_txtbox)
        Me.Controls.Add(Me.SectionTextBox)
        Me.Controls.Add(GradeLevelLabel)
        Me.Controls.Add(Me.GradeLevelTextBox)
        Me.Controls.Add(TrackLabel)
        Me.Controls.Add(Me.TrackTextBox)
        Me.Controls.Add(StrandLabel)
        Me.Controls.Add(Me.StrandTextBox)
        Me.Controls.Add(ScheduleIDLabel)
        Me.Controls.Add(Me.ScheduleIDTextBox)
        Me.Controls.Add(Me.SectionInfoBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "encode_section"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encode Section"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SectionInfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SectionInfoBindingNavigator.ResumeLayout(False)
        Me.SectionInfoBindingNavigator.PerformLayout()
        CType(Me.SectionInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._LNHS_SHS_SLS_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduleInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduleInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _LNHS_SHS_SLS_DATABASEDataSet As LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSet
    Friend WithEvents SectionInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SectionInfoTableAdapter As LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSetTableAdapters.SectionInfoTableAdapter
    Friend WithEvents TableAdapterManager As LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SectionInfoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SectionInfoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SectionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GradeLevelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrackTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StrandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ScheduleIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents sav_btn As System.Windows.Forms.Button
    Friend WithEvents new_btn As System.Windows.Forms.Button
    Friend WithEvents del_btn As System.Windows.Forms.Button
    Friend WithEvents edit_btn As System.Windows.Forms.Button
    Friend WithEvents next_btn As System.Windows.Forms.Button
    Friend WithEvents prev_btn As System.Windows.Forms.Button
    Friend WithEvents schedid_cbox As System.Windows.Forms.ComboBox
    Friend WithEvents strand_cbox As System.Windows.Forms.ComboBox
    Friend WithEvents track_cbox As System.Windows.Forms.ComboBox
    Friend WithEvents glevel_cbox As System.Windows.Forms.ComboBox
    Friend WithEvents SectionAdviserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SectionInfoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ScheduleInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ScheduleInfoTableAdapter As LNHS_SHS_SLS._LNHS_SHS_SLS_DATABASEDataSetTableAdapters.ScheduleInfoTableAdapter
    Friend WithEvents ScheduleInfoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents srch_chkbox As System.Windows.Forms.CheckBox
    Friend WithEvents sch_txtbox As System.Windows.Forms.TextBox
End Class
