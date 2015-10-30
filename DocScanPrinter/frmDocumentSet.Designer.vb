<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocumentSet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocumentSet))
        Me.pbBackground = New System.Windows.Forms.PictureBox
        Me.dgDocumentSet = New System.Windows.Forms.DataGridView
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblID = New System.Windows.Forms.Label
        Me.btClear = New System.Windows.Forms.Button
        Me.btUpdate = New System.Windows.Forms.Button
        Me.btClose = New System.Windows.Forms.Button
        Me.btLocationRemove = New System.Windows.Forms.Button
        Me.lbGroup = New System.Windows.Forms.ListBox
        Me.btLocationAdd = New System.Windows.Forms.Button
        Me.btGroupRemove = New System.Windows.Forms.Button
        Me.ddlLocation = New System.Windows.Forms.ComboBox
        Me.btGroupAdd = New System.Windows.Forms.Button
        Me.lblLocation = New System.Windows.Forms.Label
        Me.ddlDocSubGroup = New System.Windows.Forms.ComboBox
        Me.lbLocation = New System.Windows.Forms.ListBox
        Me.lblSubGroup = New System.Windows.Forms.Label
        Me.ddlDocGroup = New System.Windows.Forms.ComboBox
        Me.lblDocGroup = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblHeaderDetail = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblHeader = New System.Windows.Forms.Label
        Me.lblPowerby = New System.Windows.Forms.Label
        Me.lblDocumentSet = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtDetail = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDocumentSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbBackground
        '
        Me.pbBackground.Image = CType(resources.GetObject("pbBackground.Image"), System.Drawing.Image)
        Me.pbBackground.Location = New System.Drawing.Point(0, 263)
        Me.pbBackground.Name = "pbBackground"
        Me.pbBackground.Size = New System.Drawing.Size(473, 200)
        Me.pbBackground.TabIndex = 21
        Me.pbBackground.TabStop = False
        '
        'dgDocumentSet
        '
        Me.dgDocumentSet.AllowUserToAddRows = False
        Me.dgDocumentSet.AllowUserToDeleteRows = False
        Me.dgDocumentSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgDocumentSet.BackgroundColor = System.Drawing.Color.White
        Me.dgDocumentSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDocumentSet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Edit, Me.Delete})
        Me.dgDocumentSet.Location = New System.Drawing.Point(6, 16)
        Me.dgDocumentSet.MultiSelect = False
        Me.dgDocumentSet.Name = "dgDocumentSet"
        Me.dgDocumentSet.ReadOnly = True
        Me.dgDocumentSet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDocumentSet.Size = New System.Drawing.Size(436, 106)
        Me.dgDocumentSet.TabIndex = 22
        '
        'Edit
        '
        Me.Edit.HeaderText = ""
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Text = "Edit"
        Me.Edit.UseColumnTextForButtonValue = True
        Me.Edit.Width = 5
        '
        'Delete
        '
        Me.Delete.HeaderText = ""
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Text = "Delete"
        Me.Delete.UseColumnTextForButtonValue = True
        Me.Delete.Width = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.btClear)
        Me.GroupBox1.Controls.Add(Me.btUpdate)
        Me.GroupBox1.Controls.Add(Me.btClose)
        Me.GroupBox1.Controls.Add(Me.btLocationRemove)
        Me.GroupBox1.Controls.Add(Me.lbGroup)
        Me.GroupBox1.Controls.Add(Me.btLocationAdd)
        Me.GroupBox1.Controls.Add(Me.btGroupRemove)
        Me.GroupBox1.Controls.Add(Me.ddlLocation)
        Me.GroupBox1.Controls.Add(Me.btGroupAdd)
        Me.GroupBox1.Controls.Add(Me.lblLocation)
        Me.GroupBox1.Controls.Add(Me.ddlDocSubGroup)
        Me.GroupBox1.Controls.Add(Me.lbLocation)
        Me.GroupBox1.Controls.Add(Me.lblSubGroup)
        Me.GroupBox1.Controls.Add(Me.ddlDocGroup)
        Me.GroupBox1.Controls.Add(Me.lblDocGroup)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDetail)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 189)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 251)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add / Edit DocumentSet"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(189, 196)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 13)
        Me.lblID.TabIndex = 39
        Me.lblID.Visible = False
        '
        'btClear
        '
        Me.btClear.Location = New System.Drawing.Point(288, 222)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(75, 23)
        Me.btClear.TabIndex = 6
        Me.btClear.Text = "Clear"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'btUpdate
        '
        Me.btUpdate.Location = New System.Drawing.Point(208, 222)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btUpdate.TabIndex = 5
        Me.btUpdate.Text = "Insert"
        Me.btUpdate.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btClose.Location = New System.Drawing.Point(368, 222)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(75, 23)
        Me.btClose.TabIndex = 7
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btLocationRemove
        '
        Me.btLocationRemove.Enabled = False
        Me.btLocationRemove.Location = New System.Drawing.Point(14, 193)
        Me.btLocationRemove.Name = "btLocationRemove"
        Me.btLocationRemove.Size = New System.Drawing.Size(22, 20)
        Me.btLocationRemove.TabIndex = 36
        Me.btLocationRemove.Text = "-"
        Me.btLocationRemove.UseVisualStyleBackColor = True
        '
        'lbGroup
        '
        Me.lbGroup.FormattingEnabled = True
        Me.lbGroup.Location = New System.Drawing.Point(48, 97)
        Me.lbGroup.Name = "lbGroup"
        Me.lbGroup.Size = New System.Drawing.Size(394, 43)
        Me.lbGroup.TabIndex = 36
        '
        'btLocationAdd
        '
        Me.btLocationAdd.Location = New System.Drawing.Point(14, 173)
        Me.btLocationAdd.Name = "btLocationAdd"
        Me.btLocationAdd.Size = New System.Drawing.Size(22, 20)
        Me.btLocationAdd.TabIndex = 35
        Me.btLocationAdd.Text = "+"
        Me.btLocationAdd.UseVisualStyleBackColor = True
        '
        'btGroupRemove
        '
        Me.btGroupRemove.Enabled = False
        Me.btGroupRemove.Location = New System.Drawing.Point(14, 117)
        Me.btGroupRemove.Name = "btGroupRemove"
        Me.btGroupRemove.Size = New System.Drawing.Size(22, 20)
        Me.btGroupRemove.TabIndex = 35
        Me.btGroupRemove.Text = "-"
        Me.btGroupRemove.UseVisualStyleBackColor = True
        '
        'ddlLocation
        '
        Me.ddlLocation.FormattingEnabled = True
        Me.ddlLocation.Location = New System.Drawing.Point(48, 146)
        Me.ddlLocation.Name = "ddlLocation"
        Me.ddlLocation.Size = New System.Drawing.Size(394, 21)
        Me.ddlLocation.TabIndex = 4
        '
        'btGroupAdd
        '
        Me.btGroupAdd.Location = New System.Drawing.Point(14, 97)
        Me.btGroupAdd.Name = "btGroupAdd"
        Me.btGroupAdd.Size = New System.Drawing.Size(22, 20)
        Me.btGroupAdd.TabIndex = 34
        Me.btGroupAdd.Text = "+"
        Me.btGroupAdd.UseVisualStyleBackColor = True
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblLocation.Location = New System.Drawing.Point(3, 149)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(48, 13)
        Me.lblLocation.TabIndex = 34
        Me.lblLocation.Text = "Location"
        '
        'ddlDocSubGroup
        '
        Me.ddlDocSubGroup.Enabled = False
        Me.ddlDocSubGroup.FormattingEnabled = True
        Me.ddlDocSubGroup.Location = New System.Drawing.Point(288, 70)
        Me.ddlDocSubGroup.Name = "ddlDocSubGroup"
        Me.ddlDocSubGroup.Size = New System.Drawing.Size(154, 21)
        Me.ddlDocSubGroup.TabIndex = 3
        '
        'lbLocation
        '
        Me.lbLocation.FormattingEnabled = True
        Me.lbLocation.Location = New System.Drawing.Point(48, 173)
        Me.lbLocation.Name = "lbLocation"
        Me.lbLocation.Size = New System.Drawing.Size(394, 43)
        Me.lbLocation.TabIndex = 37
        '
        'lblSubGroup
        '
        Me.lblSubGroup.AutoSize = True
        Me.lblSubGroup.Location = New System.Drawing.Point(232, 73)
        Me.lblSubGroup.Name = "lblSubGroup"
        Me.lblSubGroup.Size = New System.Drawing.Size(55, 13)
        Me.lblSubGroup.TabIndex = 31
        Me.lblSubGroup.Text = "SubGroup"
        '
        'ddlDocGroup
        '
        Me.ddlDocGroup.FormattingEnabled = True
        Me.ddlDocGroup.Location = New System.Drawing.Point(48, 70)
        Me.ddlDocGroup.Name = "ddlDocGroup"
        Me.ddlDocGroup.Size = New System.Drawing.Size(154, 21)
        Me.ddlDocGroup.TabIndex = 2
        '
        'lblDocGroup
        '
        Me.lblDocGroup.AutoSize = True
        Me.lblDocGroup.Location = New System.Drawing.Point(8, 72)
        Me.lblDocGroup.Name = "lblDocGroup"
        Me.lblDocGroup.Size = New System.Drawing.Size(36, 13)
        Me.lblDocGroup.TabIndex = 30
        Me.lblDocGroup.Text = "Group"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(48, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(394, 20)
        Me.txtName.TabIndex = 0
        '
        'lblHeaderDetail
        '
        Me.lblHeaderDetail.AutoSize = True
        Me.lblHeaderDetail.Font = New System.Drawing.Font("PSL-Imperial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblHeaderDetail.ForeColor = System.Drawing.Color.Gray
        Me.lblHeaderDetail.Location = New System.Drawing.Point(310, 44)
        Me.lblHeaderDetail.Name = "lblHeaderDetail"
        Me.lblHeaderDetail.Size = New System.Drawing.Size(149, 19)
        Me.lblHeaderDetail.TabIndex = 25
        Me.lblHeaderDetail.Text = "DocumentSet Setting"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 27)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("PSL-Imperial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblHeader.Location = New System.Drawing.Point(250, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(215, 37)
        Me.lblHeader.TabIndex = 24
        Me.lblHeader.Text = "DocScanPrinter"
        '
        'lblPowerby
        '
        Me.lblPowerby.AutoSize = True
        Me.lblPowerby.BackColor = System.Drawing.Color.YellowGreen
        Me.lblPowerby.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.lblPowerby.ForeColor = System.Drawing.Color.Ivory
        Me.lblPowerby.Location = New System.Drawing.Point(365, 445)
        Me.lblPowerby.Name = "lblPowerby"
        Me.lblPowerby.Padding = New System.Windows.Forms.Padding(3)
        Me.lblPowerby.Size = New System.Drawing.Size(108, 18)
        Me.lblPowerby.TabIndex = 28
        Me.lblPowerby.Text = "Powered by : Nithi.re"
        '
        'lblDocumentSet
        '
        Me.lblDocumentSet.AutoSize = True
        Me.lblDocumentSet.Location = New System.Drawing.Point(162, 61)
        Me.lblDocumentSet.Name = "lblDocumentSet"
        Me.lblDocumentSet.Size = New System.Drawing.Size(126, 13)
        Me.lblDocumentSet.TabIndex = 29
        Me.lblDocumentSet.Text = "ไม่พบเซ็ทของกลุ่มเอกสาร"
        Me.lblDocumentSet.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblDocumentSet)
        Me.GroupBox2.Controls.Add(Me.dgDocumentSet)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 128)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DocumentSet List"
        '
        'txtDetail
        '
        Me.txtDetail.Location = New System.Drawing.Point(48, 44)
        Me.txtDetail.Name = "txtDetail"
        Me.txtDetail.Size = New System.Drawing.Size(394, 20)
        Me.txtDetail.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Detail"
        '
        'frmDocumentSet
        '
        Me.AcceptButton = Me.btUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btClose
        Me.ClientSize = New System.Drawing.Size(473, 462)
        Me.Controls.Add(Me.lblPowerby)
        Me.Controls.Add(Me.lblHeaderDetail)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbBackground)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDocumentSet"
        Me.Text = "DocumentSet - Setting"
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDocumentSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbBackground As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblHeaderDetail As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblPowerby As System.Windows.Forms.Label
    Friend WithEvents lblDocumentSet As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lbGroup As System.Windows.Forms.ListBox
    Friend WithEvents btGroupRemove As System.Windows.Forms.Button
    Friend WithEvents btGroupAdd As System.Windows.Forms.Button
    Friend WithEvents ddlDocSubGroup As System.Windows.Forms.ComboBox
    Friend WithEvents lblSubGroup As System.Windows.Forms.Label
    Friend WithEvents ddlDocGroup As System.Windows.Forms.ComboBox
    Friend WithEvents lblDocGroup As System.Windows.Forms.Label
    Friend WithEvents btLocationRemove As System.Windows.Forms.Button
    Friend WithEvents btLocationAdd As System.Windows.Forms.Button
    Friend WithEvents ddlLocation As System.Windows.Forms.ComboBox
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents lbLocation As System.Windows.Forms.ListBox
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents btUpdate As System.Windows.Forms.Button
    Friend WithEvents dgDocumentSet As System.Windows.Forms.DataGridView
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btClear As System.Windows.Forms.Button
    Friend WithEvents Edit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDetail As System.Windows.Forms.TextBox
End Class
