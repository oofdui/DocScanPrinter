<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutoPrintHis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutoPrintHis))
        Me.dgHistory = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btClose = New System.Windows.Forms.Button
        Me.btSearch = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpPTo = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpPFrom = New System.Windows.Forms.DateTimePicker
        Me.lblTo = New System.Windows.Forms.Label
        Me.dtpSTo = New System.Windows.Forms.DateTimePicker
        Me.lblFrom = New System.Windows.Forms.Label
        Me.dtpSFrom = New System.Windows.Forms.DateTimePicker
        Me.txtEpisode = New System.Windows.Forms.TextBox
        Me.lblEpisode = New System.Windows.Forms.Label
        Me.txtHN = New System.Windows.Forms.TextBox
        Me.lblHN = New System.Windows.Forms.Label
        Me.lblMessage = New System.Windows.Forms.Label
        Me.pnLoading = New System.Windows.Forms.Panel
        Me.picLoading = New System.Windows.Forms.PictureBox
        Me.lblLoading = New System.Windows.Forms.Label
        CType(Me.dgHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.pnLoading.SuspendLayout()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgHistory
        '
        Me.dgHistory.AllowUserToAddRows = False
        Me.dgHistory.AllowUserToDeleteRows = False
        Me.dgHistory.AllowUserToOrderColumns = True
        Me.dgHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgHistory.Location = New System.Drawing.Point(12, 94)
        Me.dgHistory.MultiSelect = False
        Me.dgHistory.Name = "dgHistory"
        Me.dgHistory.ReadOnly = True
        Me.dgHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgHistory.Size = New System.Drawing.Size(681, 448)
        Me.dgHistory.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btClose)
        Me.GroupBox1.Controls.Add(Me.btSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpPTo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpPFrom)
        Me.GroupBox1.Controls.Add(Me.lblTo)
        Me.GroupBox1.Controls.Add(Me.dtpSTo)
        Me.GroupBox1.Controls.Add(Me.lblFrom)
        Me.GroupBox1.Controls.Add(Me.dtpSFrom)
        Me.GroupBox1.Controls.Add(Me.txtEpisode)
        Me.GroupBox1.Controls.Add(Me.lblEpisode)
        Me.GroupBox1.Controls.Add(Me.txtHN)
        Me.GroupBox1.Controls.Add(Me.lblHN)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(681, 76)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'btClose
        '
        Me.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btClose.Location = New System.Drawing.Point(200, 45)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(61, 23)
        Me.btClose.TabIndex = 7
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSearch
        '
        Me.btSearch.Location = New System.Drawing.Point(133, 45)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(61, 23)
        Me.btSearch.TabIndex = 6
        Me.btSearch.Text = "Search"
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(495, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "To"
        '
        'dtpPTo
        '
        Me.dtpPTo.Location = New System.Drawing.Point(521, 45)
        Me.dtpPTo.Name = "dtpPTo"
        Me.dtpPTo.ShowCheckBox = True
        Me.dtpPTo.Size = New System.Drawing.Size(150, 20)
        Me.dtpPTo.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(280, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Print From"
        '
        'dtpPFrom
        '
        Me.dtpPFrom.Location = New System.Drawing.Point(340, 45)
        Me.dtpPFrom.Name = "dtpPFrom"
        Me.dtpPFrom.ShowCheckBox = True
        Me.dtpPFrom.Size = New System.Drawing.Size(150, 20)
        Me.dtpPFrom.TabIndex = 4
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(495, 19)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 21
        Me.lblTo.Text = "To"
        '
        'dtpSTo
        '
        Me.dtpSTo.Location = New System.Drawing.Point(521, 17)
        Me.dtpSTo.Name = "dtpSTo"
        Me.dtpSTo.ShowCheckBox = True
        Me.dtpSTo.Size = New System.Drawing.Size(150, 20)
        Me.dtpSTo.TabIndex = 3
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(280, 19)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(58, 13)
        Me.lblFrom.TabIndex = 19
        Me.lblFrom.Text = "Scan From"
        '
        'dtpSFrom
        '
        Me.dtpSFrom.Location = New System.Drawing.Point(340, 17)
        Me.dtpSFrom.Name = "dtpSFrom"
        Me.dtpSFrom.ShowCheckBox = True
        Me.dtpSFrom.Size = New System.Drawing.Size(150, 20)
        Me.dtpSFrom.TabIndex = 2
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
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(306, 289)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(50, 13)
        Me.lblMessage.TabIndex = 19
        Me.lblMessage.Text = "Message"
        '
        'pnLoading
        '
        Me.pnLoading.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnLoading.Controls.Add(Me.picLoading)
        Me.pnLoading.Controls.Add(Me.lblLoading)
        Me.pnLoading.Location = New System.Drawing.Point(282, 264)
        Me.pnLoading.Name = "pnLoading"
        Me.pnLoading.Size = New System.Drawing.Size(130, 59)
        Me.pnLoading.TabIndex = 21
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
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.Location = New System.Drawing.Point(58, 22)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(54, 13)
        Me.lblLoading.TabIndex = 20
        Me.lblLoading.Text = "Loading..."
        '
        'frmAutoPrintHis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 554)
        Me.Controls.Add(Me.pnLoading)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgHistory)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAutoPrintHis"
        Me.Text = "AutoPrint History"
        CType(Me.dgHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnLoading.ResumeLayout(False)
        Me.pnLoading.PerformLayout()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgHistory As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpPTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpPFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents dtpSTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents dtpSFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEpisode As System.Windows.Forms.TextBox
    Friend WithEvents lblEpisode As System.Windows.Forms.Label
    Friend WithEvents txtHN As System.Windows.Forms.TextBox
    Friend WithEvents lblHN As System.Windows.Forms.Label
    Friend WithEvents btSearch As System.Windows.Forms.Button
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents pnLoading As System.Windows.Forms.Panel
    Friend WithEvents picLoading As System.Windows.Forms.PictureBox
    Friend WithEvents lblLoading As System.Windows.Forms.Label
End Class
