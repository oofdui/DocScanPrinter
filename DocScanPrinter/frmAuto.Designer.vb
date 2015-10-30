<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAuto))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHeaderDetail = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoPrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentSetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoPrintHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPowerby = New System.Windows.Forms.Label()
        Me.pbBackground = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbLocation = New System.Windows.Forms.ListBox()
        Me.lbGroup = New System.Windows.Forms.ListBox()
        Me.btStop = New System.Windows.Forms.Button()
        Me.btLocationRemove = New System.Windows.Forms.Button()
        Me.btLocationAdd = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btStart = New System.Windows.Forms.Button()
        Me.btGroupRemove = New System.Windows.Forms.Button()
        Me.btGroupAdd = New System.Windows.Forms.Button()
        Me.ddlLocation = New System.Windows.Forms.ComboBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.dtpToT = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromT = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.ddlDocSubGroup = New System.Windows.Forms.ComboBox()
        Me.lblSubGroup = New System.Windows.Forms.Label()
        Me.ddlDocGroup = New System.Windows.Forms.ComboBox()
        Me.lblDocGroup = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.pnLoading = New System.Windows.Forms.Panel()
        Me.lblTimerTick = New System.Windows.Forms.Label()
        Me.picLoading = New System.Windows.Forms.PictureBox()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.lbPrinting = New System.Windows.Forms.ListBox()
        Me.lblPrintingList = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblUsern = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.pnLoading.SuspendLayout()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 27)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'lblHeaderDetail
        '
        Me.lblHeaderDetail.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblHeaderDetail.AutoSize = True
        Me.lblHeaderDetail.Font = New System.Drawing.Font("PSL-Imperial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblHeaderDetail.ForeColor = System.Drawing.Color.Gray
        Me.lblHeaderDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblHeaderDetail.Location = New System.Drawing.Point(253, 56)
        Me.lblHeaderDetail.Name = "lblHeaderDetail"
        Me.lblHeaderDetail.Size = New System.Drawing.Size(77, 19)
        Me.lblHeaderDetail.TabIndex = 12
        Me.lblHeaderDetail.Text = "Auto Print"
        Me.lblHeaderDetail.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("PSL-Imperial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblHeader.Location = New System.Drawing.Point(249, 25)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(215, 37)
        Me.lblHeader.TabIndex = 11
        Me.lblHeader.Text = "DocScanPrinter"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem, Me.ToolStripMenuItem1, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(472, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoPrintToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.TestToolStripMenuItem.Text = "File"
        '
        'AutoPrintToolStripMenuItem
        '
        Me.AutoPrintToolStripMenuItem.Name = "AutoPrintToolStripMenuItem"
        Me.AutoPrintToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.AutoPrintToolStripMenuItem.Text = "ManualPrint"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(136, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentSetToolStripMenuItem, Me.ToolStripSeparator2, Me.SetupToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(91, 20)
        Me.ToolStripMenuItem1.Text = "DocumentSet"
        '
        'DocumentSetToolStripMenuItem
        '
        Me.DocumentSetToolStripMenuItem.Name = "DocumentSetToolStripMenuItem"
        Me.DocumentSetToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.DocumentSetToolStripMenuItem.Text = "DocumentSet"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(143, 6)
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SetupToolStripMenuItem.Text = "Setup"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoPrintHistoryToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'AutoPrintHistoryToolStripMenuItem
        '
        Me.AutoPrintHistoryToolStripMenuItem.Name = "AutoPrintHistoryToolStripMenuItem"
        Me.AutoPrintHistoryToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AutoPrintHistoryToolStripMenuItem.Text = "AutoPrint History"
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
        'lblPowerby
        '
        Me.lblPowerby.AutoSize = True
        Me.lblPowerby.BackColor = System.Drawing.Color.YellowGreen
        Me.lblPowerby.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.lblPowerby.ForeColor = System.Drawing.Color.Ivory
        Me.lblPowerby.Location = New System.Drawing.Point(364, 393)
        Me.lblPowerby.Name = "lblPowerby"
        Me.lblPowerby.Padding = New System.Windows.Forms.Padding(3)
        Me.lblPowerby.Size = New System.Drawing.Size(108, 18)
        Me.lblPowerby.TabIndex = 22
        Me.lblPowerby.Text = "Powered by : Nithi.re"
        '
        'pbBackground
        '
        Me.pbBackground.Image = CType(resources.GetObject("pbBackground.Image"), System.Drawing.Image)
        Me.pbBackground.Location = New System.Drawing.Point(-1, 211)
        Me.pbBackground.Name = "pbBackground"
        Me.pbBackground.Size = New System.Drawing.Size(473, 200)
        Me.pbBackground.TabIndex = 20
        Me.pbBackground.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbLocation)
        Me.GroupBox1.Controls.Add(Me.lbGroup)
        Me.GroupBox1.Controls.Add(Me.btStop)
        Me.GroupBox1.Controls.Add(Me.btLocationRemove)
        Me.GroupBox1.Controls.Add(Me.btLocationAdd)
        Me.GroupBox1.Controls.Add(Me.btClose)
        Me.GroupBox1.Controls.Add(Me.btStart)
        Me.GroupBox1.Controls.Add(Me.btGroupRemove)
        Me.GroupBox1.Controls.Add(Me.btGroupAdd)
        Me.GroupBox1.Controls.Add(Me.ddlLocation)
        Me.GroupBox1.Controls.Add(Me.lblLocation)
        Me.GroupBox1.Controls.Add(Me.lblTo)
        Me.GroupBox1.Controls.Add(Me.dtpTo)
        Me.GroupBox1.Controls.Add(Me.lblFrom)
        Me.GroupBox1.Controls.Add(Me.dtpToT)
        Me.GroupBox1.Controls.Add(Me.dtpFromT)
        Me.GroupBox1.Controls.Add(Me.dtpFrom)
        Me.GroupBox1.Controls.Add(Me.ddlDocSubGroup)
        Me.GroupBox1.Controls.Add(Me.lblSubGroup)
        Me.GroupBox1.Controls.Add(Me.ddlDocGroup)
        Me.GroupBox1.Controls.Add(Me.lblDocGroup)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 200)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Scan"
        '
        'lbLocation
        '
        Me.lbLocation.FormattingEnabled = True
        Me.lbLocation.Location = New System.Drawing.Point(47, 146)
        Me.lbLocation.Name = "lbLocation"
        Me.lbLocation.Size = New System.Drawing.Size(332, 43)
        Me.lbLocation.TabIndex = 26
        '
        'lbGroup
        '
        Me.lbGroup.FormattingEnabled = True
        Me.lbGroup.Location = New System.Drawing.Point(47, 72)
        Me.lbGroup.Name = "lbGroup"
        Me.lbGroup.Size = New System.Drawing.Size(399, 43)
        Me.lbGroup.TabIndex = 6
        '
        'btStop
        '
        Me.btStop.Location = New System.Drawing.Point(385, 143)
        Me.btStop.Name = "btStop"
        Me.btStop.Size = New System.Drawing.Size(61, 23)
        Me.btStop.TabIndex = 6
        Me.btStop.Text = "Stop"
        Me.btStop.UseVisualStyleBackColor = True
        '
        'btLocationRemove
        '
        Me.btLocationRemove.Enabled = False
        Me.btLocationRemove.Location = New System.Drawing.Point(17, 167)
        Me.btLocationRemove.Name = "btLocationRemove"
        Me.btLocationRemove.Size = New System.Drawing.Size(22, 20)
        Me.btLocationRemove.TabIndex = 5
        Me.btLocationRemove.Text = "-"
        Me.btLocationRemove.UseVisualStyleBackColor = True
        '
        'btLocationAdd
        '
        Me.btLocationAdd.Location = New System.Drawing.Point(17, 147)
        Me.btLocationAdd.Name = "btLocationAdd"
        Me.btLocationAdd.Size = New System.Drawing.Size(22, 20)
        Me.btLocationAdd.TabIndex = 4
        Me.btLocationAdd.Text = "+"
        Me.btLocationAdd.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btClose.Location = New System.Drawing.Point(385, 167)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(61, 23)
        Me.btClose.TabIndex = 7
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btStart
        '
        Me.btStart.Location = New System.Drawing.Point(385, 119)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(61, 23)
        Me.btStart.TabIndex = 5
        Me.btStart.Text = "Start"
        Me.btStart.UseVisualStyleBackColor = True
        '
        'btGroupRemove
        '
        Me.btGroupRemove.Enabled = False
        Me.btGroupRemove.Location = New System.Drawing.Point(17, 93)
        Me.btGroupRemove.Name = "btGroupRemove"
        Me.btGroupRemove.Size = New System.Drawing.Size(22, 20)
        Me.btGroupRemove.TabIndex = 5
        Me.btGroupRemove.Text = "-"
        Me.btGroupRemove.UseVisualStyleBackColor = True
        '
        'btGroupAdd
        '
        Me.btGroupAdd.Location = New System.Drawing.Point(17, 73)
        Me.btGroupAdd.Name = "btGroupAdd"
        Me.btGroupAdd.Size = New System.Drawing.Size(22, 20)
        Me.btGroupAdd.TabIndex = 4
        Me.btGroupAdd.Text = "+"
        Me.btGroupAdd.UseVisualStyleBackColor = True
        '
        'ddlLocation
        '
        Me.ddlLocation.FormattingEnabled = True
        Me.ddlLocation.Location = New System.Drawing.Point(47, 121)
        Me.ddlLocation.Name = "ddlLocation"
        Me.ddlLocation.Size = New System.Drawing.Size(332, 21)
        Me.ddlLocation.TabIndex = 4
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(1, 130)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(48, 13)
        Me.lblLocation.TabIndex = 25
        Me.lblLocation.Text = "Location"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(249, 21)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 21
        Me.lblTo.Text = "To"
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(276, 21)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.ShowCheckBox = True
        Me.dtpTo.Size = New System.Drawing.Size(108, 20)
        Me.dtpTo.TabIndex = 1
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(9, 23)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 19
        Me.lblFrom.Text = "From"
        '
        'dtpToT
        '
        Me.dtpToT.CustomFormat = "HH:mm:ss"
        Me.dtpToT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToT.Location = New System.Drawing.Point(390, 21)
        Me.dtpToT.Name = "dtpToT"
        Me.dtpToT.ShowUpDown = True
        Me.dtpToT.Size = New System.Drawing.Size(55, 20)
        Me.dtpToT.TabIndex = 9
        Me.dtpToT.Value = New Date(2011, 11, 17, 23, 59, 59, 0)
        '
        'dtpFromT
        '
        Me.dtpFromT.CustomFormat = "HH:mm:ss"
        Me.dtpFromT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromT.Location = New System.Drawing.Point(161, 21)
        Me.dtpFromT.Name = "dtpFromT"
        Me.dtpFromT.ShowUpDown = True
        Me.dtpFromT.Size = New System.Drawing.Size(55, 20)
        Me.dtpFromT.TabIndex = 8
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = ""
        Me.dtpFrom.Location = New System.Drawing.Point(47, 21)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.ShowCheckBox = True
        Me.dtpFrom.Size = New System.Drawing.Size(108, 20)
        Me.dtpFrom.TabIndex = 0
        '
        'ddlDocSubGroup
        '
        Me.ddlDocSubGroup.Enabled = False
        Me.ddlDocSubGroup.FormattingEnabled = True
        Me.ddlDocSubGroup.Location = New System.Drawing.Point(276, 47)
        Me.ddlDocSubGroup.Name = "ddlDocSubGroup"
        Me.ddlDocSubGroup.Size = New System.Drawing.Size(170, 21)
        Me.ddlDocSubGroup.TabIndex = 3
        '
        'lblSubGroup
        '
        Me.lblSubGroup.AutoSize = True
        Me.lblSubGroup.Location = New System.Drawing.Point(221, 50)
        Me.lblSubGroup.Name = "lblSubGroup"
        Me.lblSubGroup.Size = New System.Drawing.Size(55, 13)
        Me.lblSubGroup.TabIndex = 4
        Me.lblSubGroup.Text = "SubGroup"
        '
        'ddlDocGroup
        '
        Me.ddlDocGroup.FormattingEnabled = True
        Me.ddlDocGroup.Location = New System.Drawing.Point(47, 47)
        Me.ddlDocGroup.Name = "ddlDocGroup"
        Me.ddlDocGroup.Size = New System.Drawing.Size(168, 21)
        Me.ddlDocGroup.TabIndex = 2
        '
        'lblDocGroup
        '
        Me.lblDocGroup.AutoSize = True
        Me.lblDocGroup.Location = New System.Drawing.Point(9, 50)
        Me.lblDocGroup.Name = "lblDocGroup"
        Me.lblDocGroup.Size = New System.Drawing.Size(36, 13)
        Me.lblDocGroup.TabIndex = 2
        Me.lblDocGroup.Text = "Group"
        '
        'PrintDocument1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'pnLoading
        '
        Me.pnLoading.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnLoading.Controls.Add(Me.lblTimerTick)
        Me.pnLoading.Controls.Add(Me.picLoading)
        Me.pnLoading.Controls.Add(Me.lblLoading)
        Me.pnLoading.Location = New System.Drawing.Point(356, 288)
        Me.pnLoading.Name = "pnLoading"
        Me.pnLoading.Size = New System.Drawing.Size(108, 56)
        Me.pnLoading.TabIndex = 24
        '
        'lblTimerTick
        '
        Me.lblTimerTick.AutoSize = True
        Me.lblTimerTick.ForeColor = System.Drawing.Color.OliveDrab
        Me.lblTimerTick.Location = New System.Drawing.Point(46, 37)
        Me.lblTimerTick.Name = "lblTimerTick"
        Me.lblTimerTick.Size = New System.Drawing.Size(13, 13)
        Me.lblTimerTick.TabIndex = 21
        Me.lblTimerTick.Text = "0"
        Me.lblTimerTick.Visible = False
        '
        'picLoading
        '
        Me.picLoading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picLoading.BackColor = System.Drawing.Color.Transparent
        Me.picLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picLoading.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.picLoading.Image = CType(resources.GetObject("picLoading.Image"), System.Drawing.Image)
        Me.picLoading.Location = New System.Drawing.Point(10, 11)
        Me.picLoading.Name = "picLoading"
        Me.picLoading.Size = New System.Drawing.Size(32, 32)
        Me.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picLoading.TabIndex = 19
        Me.picLoading.TabStop = False
        Me.picLoading.WaitOnLoad = True
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.Location = New System.Drawing.Point(46, 21)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(51, 13)
        Me.lblLoading.TabIndex = 20
        Me.lblLoading.Text = "Printing..."
        '
        'lbPrinting
        '
        Me.lbPrinting.FormattingEnabled = True
        Me.lbPrinting.HorizontalScrollbar = True
        Me.lbPrinting.Location = New System.Drawing.Point(7, 288)
        Me.lbPrinting.Name = "lbPrinting"
        Me.lbPrinting.Size = New System.Drawing.Size(343, 56)
        Me.lbPrinting.TabIndex = 25
        '
        'lblPrintingList
        '
        Me.lblPrintingList.AutoSize = True
        Me.lblPrintingList.BackColor = System.Drawing.Color.Transparent
        Me.lblPrintingList.Location = New System.Drawing.Point(6, 272)
        Me.lblPrintingList.Name = "lblPrintingList"
        Me.lblPrintingList.Size = New System.Drawing.Size(95, 13)
        Me.lblPrintingList.TabIndex = 26
        Me.lblPrintingList.Text = "Last print 10 files..."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 356)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(456, 20)
        Me.TextBox1.TabIndex = 27
        '
        'lblUsern
        '
        Me.lblUsern.AutoSize = True
        Me.lblUsern.Location = New System.Drawing.Point(325, 393)
        Me.lblUsern.Name = "lblUsern"
        Me.lblUsern.Size = New System.Drawing.Size(33, 13)
        Me.lblUsern.TabIndex = 28
        Me.lblUsern.Text = "usern"
        Me.lblUsern.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(472, 410)
        Me.Controls.Add(Me.lblUsern)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblHeaderDetail)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPrintingList)
        Me.Controls.Add(Me.lbPrinting)
        Me.Controls.Add(Me.pnLoading)
        Me.Controls.Add(Me.lblPowerby)
        Me.Controls.Add(Me.pbBackground)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAuto"
        Me.Text = "DocScanPrinter"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnLoading.ResumeLayout(False)
        Me.pnLoading.PerformLayout()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeaderDetail As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPowerby As System.Windows.Forms.Label
    Friend WithEvents pbBackground As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btStop As System.Windows.Forms.Button
    Friend WithEvents ddlLocation As System.Windows.Forms.ComboBox
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents btStart As System.Windows.Forms.Button
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents ddlDocSubGroup As System.Windows.Forms.ComboBox
    Friend WithEvents lblSubGroup As System.Windows.Forms.Label
    Friend WithEvents ddlDocGroup As System.Windows.Forms.ComboBox
    Friend WithEvents lblDocGroup As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AutoPrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnLoading As System.Windows.Forms.Panel
    Friend WithEvents picLoading As System.Windows.Forms.PictureBox
    Friend WithEvents lblLoading As System.Windows.Forms.Label
    Friend WithEvents lbPrinting As System.Windows.Forms.ListBox
    Friend WithEvents lblPrintingList As System.Windows.Forms.Label
    Friend WithEvents lblTimerTick As System.Windows.Forms.Label
    Friend WithEvents dtpFromT As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpToT As System.Windows.Forms.DateTimePicker
    Friend WithEvents btGroupAdd As System.Windows.Forms.Button
    Friend WithEvents btGroupRemove As System.Windows.Forms.Button
    Friend WithEvents lbGroup As System.Windows.Forms.ListBox
    Friend WithEvents lbLocation As System.Windows.Forms.ListBox
    Friend WithEvents btLocationRemove As System.Windows.Forms.Button
    Friend WithEvents btLocationAdd As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentSetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblUsern As System.Windows.Forms.Label
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoPrintHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
