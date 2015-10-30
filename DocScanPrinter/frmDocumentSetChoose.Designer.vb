<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocumentSetChoose
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocumentSetChoose))
        Me.lblPowerby = New System.Windows.Forms.Label()
        Me.lblHeaderDetail = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pbBackground = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDocumentSet = New System.Windows.Forms.Label()
        Me.dgDocumentSet = New System.Windows.Forms.DataGridView()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDocumentSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPowerby
        '
        Me.lblPowerby.AutoSize = True
        Me.lblPowerby.BackColor = System.Drawing.Color.YellowGreen
        Me.lblPowerby.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.lblPowerby.ForeColor = System.Drawing.Color.Ivory
        Me.lblPowerby.Location = New System.Drawing.Point(365, 444)
        Me.lblPowerby.Name = "lblPowerby"
        Me.lblPowerby.Padding = New System.Windows.Forms.Padding(3)
        Me.lblPowerby.Size = New System.Drawing.Size(108, 18)
        Me.lblPowerby.TabIndex = 34
        Me.lblPowerby.Text = "Powered by : Nithi.re"
        '
        'lblHeaderDetail
        '
        Me.lblHeaderDetail.AutoSize = True
        Me.lblHeaderDetail.Font = New System.Drawing.Font("PSL-Imperial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblHeaderDetail.ForeColor = System.Drawing.Color.Gray
        Me.lblHeaderDetail.Location = New System.Drawing.Point(308, 43)
        Me.lblHeaderDetail.Name = "lblHeaderDetail"
        Me.lblHeaderDetail.Size = New System.Drawing.Size(151, 19)
        Me.lblHeaderDetail.TabIndex = 32
        Me.lblHeaderDetail.Text = "DocumentSet Choose"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 27)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("PSL-Imperial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblHeader.Location = New System.Drawing.Point(250, 8)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(215, 37)
        Me.lblHeader.TabIndex = 31
        Me.lblHeader.Text = "DocScanPrinter"
        '
        'pbBackground
        '
        Me.pbBackground.Image = CType(resources.GetObject("pbBackground.Image"), System.Drawing.Image)
        Me.pbBackground.Location = New System.Drawing.Point(0, 262)
        Me.pbBackground.Name = "pbBackground"
        Me.pbBackground.Size = New System.Drawing.Size(473, 200)
        Me.pbBackground.TabIndex = 29
        Me.pbBackground.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblDocumentSet)
        Me.GroupBox2.Controls.Add(Me.dgDocumentSet)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 375)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DocumentSet List"
        '
        'lblDocumentSet
        '
        Me.lblDocumentSet.AutoSize = True
        Me.lblDocumentSet.BackColor = System.Drawing.Color.White
        Me.lblDocumentSet.Location = New System.Drawing.Point(163, 176)
        Me.lblDocumentSet.Name = "lblDocumentSet"
        Me.lblDocumentSet.Size = New System.Drawing.Size(126, 13)
        Me.lblDocumentSet.TabIndex = 29
        Me.lblDocumentSet.Text = "ไม่พบเซ็ทของกลุ่มเอกสาร"
        Me.lblDocumentSet.Visible = False
        '
        'dgDocumentSet
        '
        Me.dgDocumentSet.AllowUserToAddRows = False
        Me.dgDocumentSet.AllowUserToDeleteRows = False
        Me.dgDocumentSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgDocumentSet.BackgroundColor = System.Drawing.Color.White
        Me.dgDocumentSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDocumentSet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Edit})
        Me.dgDocumentSet.Location = New System.Drawing.Point(6, 16)
        Me.dgDocumentSet.MultiSelect = False
        Me.dgDocumentSet.Name = "dgDocumentSet"
        Me.dgDocumentSet.ReadOnly = True
        Me.dgDocumentSet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDocumentSet.Size = New System.Drawing.Size(436, 353)
        Me.dgDocumentSet.TabIndex = 22
        '
        'Edit
        '
        Me.Edit.HeaderText = ""
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Text = "Select"
        Me.Edit.UseColumnTextForButtonValue = True
        Me.Edit.Width = 5
        '
        'frmDocumentSetChoose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(473, 462)
        Me.Controls.Add(Me.lblPowerby)
        Me.Controls.Add(Me.lblHeaderDetail)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pbBackground)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDocumentSetChoose"
        Me.ShowInTaskbar = False
        Me.Text = "DocumentSet Choose"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgDocumentSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPowerby As System.Windows.Forms.Label
    Friend WithEvents lblHeaderDetail As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents pbBackground As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDocumentSet As System.Windows.Forms.Label
    Friend WithEvents dgDocumentSet As System.Windows.Forms.DataGridView
    Friend WithEvents Edit As System.Windows.Forms.DataGridViewButtonColumn
End Class
