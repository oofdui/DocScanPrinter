<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDefault
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDefault))
        Me.pbBackground = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblHeaderDetail = New System.Windows.Forms.Label
        Me.lblHeader = New System.Windows.Forms.Label
        Me.lblPowerby = New System.Windows.Forms.Label
        Me.dgDocList = New System.Windows.Forms.DataGridView
        Me.clCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.clPrint = New System.Windows.Forms.DataGridViewButtonColumn
        Me.clPreview = New System.Windows.Forms.DataGridViewButtonColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btDocumentSet = New System.Windows.Forms.Button
        Me.btLocationRemove = New System.Windows.Forms.Button
        Me.btLocationAdd = New System.Windows.Forms.Button
        Me.lbGroup = New System.Windows.Forms.ListBox
        Me.btGroupRemove = New System.Windows.Forms.Button
        Me.btGroupAdd = New System.Windows.Forms.Button
        Me.ddlLocation = New System.Windows.Forms.ComboBox
        Me.lblLocation = New System.Windows.Forms.Label
        Me.ddlDoctor = New System.Windows.Forms.ComboBox
        Me.lblDoctor = New System.Windows.Forms.Label
        Me.lblTo = New System.Windows.Forms.Label
        Me.dtpTo = New System.Windows.Forms.DateTimePicker
        Me.lblFrom = New System.Windows.Forms.Label
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.lblSep = New System.Windows.Forms.Label
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.txtEpisode = New System.Windows.Forms.TextBox
        Me.lblEpisode = New System.Windows.Forms.Label
        Me.ddlDocSubGroup = New System.Windows.Forms.ComboBox
        Me.lblSubGroup = New System.Windows.Forms.Label
        Me.ddlDocGroup = New System.Windows.Forms.ComboBox
        Me.lblDocGroup = New System.Windows.Forms.Label
        Me.txtHN = New System.Windows.Forms.TextBox
        Me.lblHN = New System.Windows.Forms.Label
        Me.lbLocation = New System.Windows.Forms.ListBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btSearch = New System.Windows.Forms.Button
        Me.btClose = New System.Windows.Forms.Button
        Me.btCancel = New System.Windows.Forms.Button
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AutoPrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DocumentSetChooseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.SetupToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.picLoading = New System.Windows.Forms.PictureBox
        Me.pnLoading = New System.Windows.Forms.Panel
        Me.lblLoading = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.btPrintSelected = New System.Windows.Forms.Button
        Me.btClearSelected = New System.Windows.Forms.Button
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDocList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnLoading.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbBackground
        '
        Me.pbBackground.Image = CType(resources.GetObject("pbBackground.Image"), System.Drawing.Image)
        Me.pbBackground.Location = New System.Drawing.Point(-4, 562)
        Me.pbBackground.Name = "pbBackground"
        Me.pbBackground.Size = New System.Drawing.Size(688, 200)
        Me.pbBackground.TabIndex = 8
        Me.pbBackground.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 55)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'lblHeaderDetail
        '
        Me.lblHeaderDetail.AutoSize = True
        Me.lblHeaderDetail.Font = New System.Drawing.Font("PSL-Imperial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblHeaderDetail.ForeColor = System.Drawing.Color.Gray
        Me.lblHeaderDetail.Location = New System.Drawing.Point(564, 56)
        Me.lblHeaderDetail.Name = "lblHeaderDetail"
        Me.lblHeaderDetail.Size = New System.Drawing.Size(103, 19)
        Me.lblHeaderDetail.TabIndex = 12
        Me.lblHeaderDetail.Text = "Document List"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("PSL-Imperial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblHeader.Location = New System.Drawing.Point(458, 24)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(215, 37)
        Me.lblHeader.TabIndex = 11
        Me.lblHeader.Text = "DocScanPrinter"
        '
        'lblPowerby
        '
        Me.lblPowerby.AutoSize = True
        Me.lblPowerby.BackColor = System.Drawing.Color.YellowGreen
        Me.lblPowerby.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.lblPowerby.ForeColor = System.Drawing.Color.Ivory
        Me.lblPowerby.Location = New System.Drawing.Point(576, 744)
        Me.lblPowerby.Name = "lblPowerby"
        Me.lblPowerby.Padding = New System.Windows.Forms.Padding(3)
        Me.lblPowerby.Size = New System.Drawing.Size(108, 18)
        Me.lblPowerby.TabIndex = 15
        Me.lblPowerby.Text = "Powered by : Nithi.re"
        '
        'dgDocList
        '
        Me.dgDocList.AllowUserToAddRows = False
        Me.dgDocList.AllowUserToDeleteRows = False
        Me.dgDocList.AllowUserToResizeRows = False
        Me.dgDocList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgDocList.BackgroundColor = System.Drawing.Color.White
        Me.dgDocList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgDocList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clCheck, Me.clPrint, Me.clPreview})
        Me.dgDocList.Location = New System.Drawing.Point(13, 311)
        Me.dgDocList.MultiSelect = False
        Me.dgDocList.Name = "dgDocList"
        Me.dgDocList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDocList.Size = New System.Drawing.Size(660, 386)
        Me.dgDocList.StandardTab = True
        Me.dgDocList.TabIndex = 16
        '
        'clCheck
        '
        Me.clCheck.FalseValue = "0"
        Me.clCheck.Frozen = True
        Me.clCheck.HeaderText = "Select"
        Me.clCheck.IndeterminateValue = "0"
        Me.clCheck.Name = "clCheck"
        Me.clCheck.TrueValue = "1"
        Me.clCheck.Width = 43
        '
        'clPrint
        '
        Me.clPrint.Frozen = True
        Me.clPrint.HeaderText = ""
        Me.clPrint.MinimumWidth = 50
        Me.clPrint.Name = "clPrint"
        Me.clPrint.Text = "Print"
        Me.clPrint.ToolTipText = "Print"
        Me.clPrint.UseColumnTextForButtonValue = True
        Me.clPrint.Width = 50
        '
        'clPreview
        '
        Me.clPreview.Frozen = True
        Me.clPreview.HeaderText = ""
        Me.clPreview.MinimumWidth = 50
        Me.clPreview.Name = "clPreview"
        Me.clPreview.Text = "Preview"
        Me.clPreview.ToolTipText = "Preview"
        Me.clPreview.UseColumnTextForButtonValue = True
        Me.clPreview.Width = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btDocumentSet)
        Me.GroupBox1.Controls.Add(Me.btLocationRemove)
        Me.GroupBox1.Controls.Add(Me.btLocationAdd)
        Me.GroupBox1.Controls.Add(Me.lbGroup)
        Me.GroupBox1.Controls.Add(Me.btGroupRemove)
        Me.GroupBox1.Controls.Add(Me.btGroupAdd)
        Me.GroupBox1.Controls.Add(Me.ddlLocation)
        Me.GroupBox1.Controls.Add(Me.lblLocation)
        Me.GroupBox1.Controls.Add(Me.ddlDoctor)
        Me.GroupBox1.Controls.Add(Me.lblDoctor)
        Me.GroupBox1.Controls.Add(Me.lblTo)
        Me.GroupBox1.Controls.Add(Me.dtpTo)
        Me.GroupBox1.Controls.Add(Me.lblFrom)
        Me.GroupBox1.Controls.Add(Me.dtpFrom)
        Me.GroupBox1.Controls.Add(Me.lblSep)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.txtEpisode)
        Me.GroupBox1.Controls.Add(Me.lblEpisode)
        Me.GroupBox1.Controls.Add(Me.ddlDocSubGroup)
        Me.GroupBox1.Controls.Add(Me.lblSubGroup)
        Me.GroupBox1.Controls.Add(Me.ddlDocGroup)
        Me.GroupBox1.Controls.Add(Me.lblDocGroup)
        Me.GroupBox1.Controls.Add(Me.txtHN)
        Me.GroupBox1.Controls.Add(Me.lblHN)
        Me.GroupBox1.Controls.Add(Me.lbLocation)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 225)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'btDocumentSet
        '
        Me.btDocumentSet.Location = New System.Drawing.Point(539, 67)
        Me.btDocumentSet.Name = "btDocumentSet"
        Me.btDocumentSet.Size = New System.Drawing.Size(110, 23)
        Me.btDocumentSet.TabIndex = 33
        Me.btDocumentSet.Text = "DocumentSet"
        Me.btDocumentSet.UseVisualStyleBackColor = True
        '
        'btLocationRemove
        '
        Me.btLocationRemove.Enabled = False
        Me.btLocationRemove.Location = New System.Drawing.Point(16, 191)
        Me.btLocationRemove.Name = "btLocationRemove"
        Me.btLocationRemove.Size = New System.Drawing.Size(22, 20)
        Me.btLocationRemove.TabIndex = 31
        Me.btLocationRemove.Text = "-"
        Me.btLocationRemove.UseVisualStyleBackColor = True
        '
        'btLocationAdd
        '
        Me.btLocationAdd.Location = New System.Drawing.Point(16, 171)
        Me.btLocationAdd.Name = "btLocationAdd"
        Me.btLocationAdd.Size = New System.Drawing.Size(22, 20)
        Me.btLocationAdd.TabIndex = 30
        Me.btLocationAdd.Text = "+"
        Me.btLocationAdd.UseVisualStyleBackColor = True
        '
        'lbGroup
        '
        Me.lbGroup.FormattingEnabled = True
        Me.lbGroup.Location = New System.Drawing.Point(46, 96)
        Me.lbGroup.Name = "lbGroup"
        Me.lbGroup.Size = New System.Drawing.Size(487, 43)
        Me.lbGroup.TabIndex = 29
        '
        'btGroupRemove
        '
        Me.btGroupRemove.Enabled = False
        Me.btGroupRemove.Location = New System.Drawing.Point(16, 117)
        Me.btGroupRemove.Name = "btGroupRemove"
        Me.btGroupRemove.Size = New System.Drawing.Size(22, 20)
        Me.btGroupRemove.TabIndex = 28
        Me.btGroupRemove.Text = "-"
        Me.btGroupRemove.UseVisualStyleBackColor = True
        '
        'btGroupAdd
        '
        Me.btGroupAdd.Location = New System.Drawing.Point(16, 97)
        Me.btGroupAdd.Name = "btGroupAdd"
        Me.btGroupAdd.Size = New System.Drawing.Size(22, 20)
        Me.btGroupAdd.TabIndex = 27
        Me.btGroupAdd.Text = "+"
        Me.btGroupAdd.UseVisualStyleBackColor = True
        '
        'ddlLocation
        '
        Me.ddlLocation.FormattingEnabled = True
        Me.ddlLocation.Location = New System.Drawing.Point(46, 145)
        Me.ddlLocation.Name = "ddlLocation"
        Me.ddlLocation.Size = New System.Drawing.Size(487, 21)
        Me.ddlLocation.TabIndex = 9
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblLocation.Location = New System.Drawing.Point(1, 148)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(48, 13)
        Me.lblLocation.TabIndex = 25
        Me.lblLocation.Text = "Location"
        '
        'ddlDoctor
        '
        Me.ddlDoctor.FormattingEnabled = True
        Me.ddlDoctor.Location = New System.Drawing.Point(318, 42)
        Me.ddlDoctor.Name = "ddlDoctor"
        Me.ddlDoctor.Size = New System.Drawing.Size(331, 21)
        Me.ddlDoctor.TabIndex = 6
        '
        'lblDoctor
        '
        Me.lblDoctor.AutoSize = True
        Me.lblDoctor.Location = New System.Drawing.Point(276, 46)
        Me.lblDoctor.Name = "lblDoctor"
        Me.lblDoctor.Size = New System.Drawing.Size(39, 13)
        Me.lblDoctor.TabIndex = 23
        Me.lblDoctor.Text = "Doctor"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(473, 19)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 21
        Me.lblTo.Text = "To"
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(499, 17)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.ShowCheckBox = True
        Me.dtpTo.Size = New System.Drawing.Size(150, 20)
        Me.dtpTo.TabIndex = 3
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(285, 19)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 19
        Me.lblFrom.Text = "From"
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(318, 17)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.ShowCheckBox = True
        Me.dtpFrom.Size = New System.Drawing.Size(150, 20)
        Me.dtpFrom.TabIndex = 2
        '
        'lblSep
        '
        Me.lblSep.AutoSize = True
        Me.lblSep.Location = New System.Drawing.Point(149, 46)
        Me.lblSep.Name = "lblSep"
        Me.lblSep.Size = New System.Drawing.Size(10, 13)
        Me.lblSep.TabIndex = 10
        Me.lblSep.Text = "-"
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(159, 43)
        Me.txtLName.MaxLength = 0
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(102, 20)
        Me.txtLName.TabIndex = 5
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(46, 43)
        Me.txtFName.MaxLength = 0
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(102, 20)
        Me.txtFName.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(6, 46)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name"
        '
        'txtEpisode
        '
        Me.txtEpisode.Location = New System.Drawing.Point(181, 17)
        Me.txtEpisode.MaxLength = 11
        Me.txtEpisode.Name = "txtEpisode"
        Me.txtEpisode.Size = New System.Drawing.Size(80, 20)
        Me.txtEpisode.TabIndex = 1
        '
        'lblEpisode
        '
        Me.lblEpisode.AutoSize = True
        Me.lblEpisode.Location = New System.Drawing.Point(130, 20)
        Me.lblEpisode.Name = "lblEpisode"
        Me.lblEpisode.Size = New System.Drawing.Size(45, 13)
        Me.lblEpisode.TabIndex = 6
        Me.lblEpisode.Text = "Episode"
        '
        'ddlDocSubGroup
        '
        Me.ddlDocSubGroup.Enabled = False
        Me.ddlDocSubGroup.FormattingEnabled = True
        Me.ddlDocSubGroup.Location = New System.Drawing.Point(318, 69)
        Me.ddlDocSubGroup.Name = "ddlDocSubGroup"
        Me.ddlDocSubGroup.Size = New System.Drawing.Size(215, 21)
        Me.ddlDocSubGroup.TabIndex = 8
        '
        'lblSubGroup
        '
        Me.lblSubGroup.AutoSize = True
        Me.lblSubGroup.Location = New System.Drawing.Point(262, 72)
        Me.lblSubGroup.Name = "lblSubGroup"
        Me.lblSubGroup.Size = New System.Drawing.Size(55, 13)
        Me.lblSubGroup.TabIndex = 4
        Me.lblSubGroup.Text = "SubGroup"
        '
        'ddlDocGroup
        '
        Me.ddlDocGroup.FormattingEnabled = True
        Me.ddlDocGroup.Location = New System.Drawing.Point(46, 69)
        Me.ddlDocGroup.Name = "ddlDocGroup"
        Me.ddlDocGroup.Size = New System.Drawing.Size(215, 21)
        Me.ddlDocGroup.TabIndex = 7
        '
        'lblDocGroup
        '
        Me.lblDocGroup.AutoSize = True
        Me.lblDocGroup.Location = New System.Drawing.Point(6, 71)
        Me.lblDocGroup.Name = "lblDocGroup"
        Me.lblDocGroup.Size = New System.Drawing.Size(36, 13)
        Me.lblDocGroup.TabIndex = 2
        Me.lblDocGroup.Text = "Group"
        '
        'txtHN
        '
        Me.txtHN.Location = New System.Drawing.Point(46, 17)
        Me.txtHN.MaxLength = 10
        Me.txtHN.Name = "txtHN"
        Me.txtHN.Size = New System.Drawing.Size(80, 20)
        Me.txtHN.TabIndex = 0
        '
        'lblHN
        '
        Me.lblHN.AutoSize = True
        Me.lblHN.Location = New System.Drawing.Point(6, 20)
        Me.lblHN.Name = "lblHN"
        Me.lblHN.Size = New System.Drawing.Size(23, 13)
        Me.lblHN.TabIndex = 0
        Me.lblHN.Text = "HN"
        '
        'lbLocation
        '
        Me.lbLocation.FormattingEnabled = True
        Me.lbLocation.Location = New System.Drawing.Point(46, 170)
        Me.lbLocation.Name = "lbLocation"
        Me.lbLocation.Size = New System.Drawing.Size(487, 43)
        Me.lbLocation.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btSearch)
        Me.GroupBox2.Controls.Add(Me.btClose)
        Me.GroupBox2.Controls.Add(Me.btCancel)
        Me.GroupBox2.Location = New System.Drawing.Point(540, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(109, 117)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Command"
        '
        'btSearch
        '
        Me.btSearch.Location = New System.Drawing.Point(26, 26)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(61, 23)
        Me.btSearch.TabIndex = 10
        Me.btSearch.Text = "Search"
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btClose.Location = New System.Drawing.Point(26, 80)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(61, 23)
        Me.btClose.TabIndex = 12
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(26, 53)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(61, 23)
        Me.btCancel.TabIndex = 11
        Me.btCancel.Text = "Cancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem, Me.ToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoPrintToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.TestToolStripMenuItem.Text = "File"
        '
        'AutoPrintToolStripMenuItem
        '
        Me.AutoPrintToolStripMenuItem.Name = "AutoPrintToolStripMenuItem"
        Me.AutoPrintToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AutoPrintToolStripMenuItem.Text = "AutoPrint"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(122, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentSetChooseToolStripMenuItem, Me.ToolStripSeparator1, Me.SetupToolStripMenuItem1})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(91, 20)
        Me.ToolStripMenuItem1.Text = "DocumentSet"
        '
        'DocumentSetChooseToolStripMenuItem
        '
        Me.DocumentSetChooseToolStripMenuItem.Name = "DocumentSetChooseToolStripMenuItem"
        Me.DocumentSetChooseToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.DocumentSetChooseToolStripMenuItem.Text = "DocumentSet"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'SetupToolStripMenuItem1
        '
        Me.SetupToolStripMenuItem1.Name = "SetupToolStripMenuItem1"
        Me.SetupToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.SetupToolStripMenuItem1.Text = "Setup"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AboutToolStripMenuItem.Text = "About DocScanPrinter"
        '
        'picLoading
        '
        Me.picLoading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picLoading.BackColor = System.Drawing.Color.Transparent
        Me.picLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picLoading.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.picLoading.Image = CType(resources.GetObject("picLoading.Image"), System.Drawing.Image)
        Me.picLoading.Location = New System.Drawing.Point(21, 12)
        Me.picLoading.Name = "picLoading"
        Me.picLoading.Size = New System.Drawing.Size(32, 32)
        Me.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picLoading.TabIndex = 19
        Me.picLoading.TabStop = False
        Me.picLoading.WaitOnLoad = True
        '
        'pnLoading
        '
        Me.pnLoading.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnLoading.Controls.Add(Me.picLoading)
        Me.pnLoading.Controls.Add(Me.lblLoading)
        Me.pnLoading.Location = New System.Drawing.Point(278, 452)
        Me.pnLoading.Name = "pnLoading"
        Me.pnLoading.Size = New System.Drawing.Size(130, 59)
        Me.pnLoading.TabIndex = 20
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.Location = New System.Drawing.Point(58, 22)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(54, 13)
        Me.lblLoading.TabIndex = 20
        Me.lblLoading.Text = "Loading..."
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'btPrintSelected
        '
        Me.btPrintSelected.Location = New System.Drawing.Point(499, 704)
        Me.btPrintSelected.Name = "btPrintSelected"
        Me.btPrintSelected.Size = New System.Drawing.Size(87, 23)
        Me.btPrintSelected.TabIndex = 21
        Me.btPrintSelected.Text = "Print Selected"
        Me.btPrintSelected.UseVisualStyleBackColor = True
        '
        'btClearSelected
        '
        Me.btClearSelected.Location = New System.Drawing.Point(591, 704)
        Me.btClearSelected.Name = "btClearSelected"
        Me.btClearSelected.Size = New System.Drawing.Size(87, 23)
        Me.btClearSelected.TabIndex = 22
        Me.btClearSelected.Text = "Clear Selected"
        Me.btClearSelected.UseVisualStyleBackColor = True
        '
        'frmDefault
        '
        Me.AcceptButton = Me.btSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btClose
        Me.ClientSize = New System.Drawing.Size(684, 746)
        Me.Controls.Add(Me.btClearSelected)
        Me.Controls.Add(Me.btPrintSelected)
        Me.Controls.Add(Me.pnLoading)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgDocList)
        Me.Controls.Add(Me.lblPowerby)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHeaderDetail)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.pbBackground)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDefault"
        Me.Text = "DocScanPrinter"
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDocList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnLoading.ResumeLayout(False)
        Me.pnLoading.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbBackground As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeaderDetail As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblPowerby As System.Windows.Forms.Label
    Friend WithEvents dgDocList As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblHN As System.Windows.Forms.Label
    Friend WithEvents txtHN As System.Windows.Forms.TextBox
    Friend WithEvents lblDocGroup As System.Windows.Forms.Label
    Friend WithEvents ddlDocGroup As System.Windows.Forms.ComboBox
    Friend WithEvents ddlDocSubGroup As System.Windows.Forms.ComboBox
    Friend WithEvents lblSubGroup As System.Windows.Forms.Label
    Friend WithEvents txtEpisode As System.Windows.Forms.TextBox
    Friend WithEvents lblEpisode As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents lblSep As System.Windows.Forms.Label
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents btSearch As System.Windows.Forms.Button
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents lblDoctor As System.Windows.Forms.Label
    Friend WithEvents ddlLocation As System.Windows.Forms.ComboBox
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents ddlDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picLoading As System.Windows.Forms.PictureBox
    Friend WithEvents pnLoading As System.Windows.Forms.Panel
    Friend WithEvents lblLoading As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents AutoPrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btPrintSelected As System.Windows.Forms.Button
    Friend WithEvents btClearSelected As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetupToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbGroup As System.Windows.Forms.ListBox
    Friend WithEvents btGroupRemove As System.Windows.Forms.Button
    Friend WithEvents btGroupAdd As System.Windows.Forms.Button
    Friend WithEvents lbLocation As System.Windows.Forms.ListBox
    Friend WithEvents btLocationRemove As System.Windows.Forms.Button
    Friend WithEvents btLocationAdd As System.Windows.Forms.Button
    Friend WithEvents btDocumentSet As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents clCheck As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clPrint As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents clPreview As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DocumentSetChooseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
