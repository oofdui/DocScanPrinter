<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtUsern = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.lblUsern = New System.Windows.Forms.Label()
        Me.lblPwd = New System.Windows.Forms.Label()
        Me.btLogin = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.pbBackground = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblHeaderDetail = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPowerby = New System.Windows.Forms.Label()
        Me.cbAutoPrint = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblStaffStatus = New System.Windows.Forms.Label()
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsern
        '
        Me.txtUsern.Location = New System.Drawing.Point(148, 97)
        Me.txtUsern.Name = "txtUsern"
        Me.txtUsern.Size = New System.Drawing.Size(100, 23)
        Me.txtUsern.TabIndex = 0
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(148, 126)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(100, 23)
        Me.txtPwd.TabIndex = 1
        '
        'lblUsern
        '
        Me.lblUsern.AutoSize = True
        Me.lblUsern.Location = New System.Drawing.Point(76, 100)
        Me.lblUsern.Name = "lblUsern"
        Me.lblUsern.Size = New System.Drawing.Size(66, 16)
        Me.lblUsern.TabIndex = 2
        Me.lblUsern.Text = "Username"
        '
        'lblPwd
        '
        Me.lblPwd.AutoSize = True
        Me.lblPwd.Location = New System.Drawing.Point(76, 129)
        Me.lblPwd.Name = "lblPwd"
        Me.lblPwd.Size = New System.Drawing.Size(63, 16)
        Me.lblPwd.TabIndex = 3
        Me.lblPwd.Text = "Password"
        '
        'btLogin
        '
        Me.btLogin.Location = New System.Drawing.Point(87, 193)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(75, 23)
        Me.btLogin.TabIndex = 3
        Me.btLogin.Text = "Login"
        Me.btLogin.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Location = New System.Drawing.Point(173, 193)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(75, 23)
        Me.btClose.TabIndex = 4
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'pbBackground
        '
        Me.pbBackground.Image = CType(resources.GetObject("pbBackground.Image"), System.Drawing.Image)
        Me.pbBackground.Location = New System.Drawing.Point(-1, 112)
        Me.pbBackground.Name = "pbBackground"
        Me.pbBackground.Size = New System.Drawing.Size(335, 200)
        Me.pbBackground.TabIndex = 7
        Me.pbBackground.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblHeader.Location = New System.Drawing.Point(119, 5)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(219, 31)
        Me.lblHeader.TabIndex = 8
        Me.lblHeader.Text = "DocScanPrinter"
        '
        'lblHeaderDetail
        '
        Me.lblHeaderDetail.AutoSize = True
        Me.lblHeaderDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblHeaderDetail.ForeColor = System.Drawing.Color.Gray
        Me.lblHeaderDetail.Location = New System.Drawing.Point(277, 42)
        Me.lblHeaderDetail.Name = "lblHeaderDetail"
        Me.lblHeaderDetail.Size = New System.Drawing.Size(48, 17)
        Me.lblHeaderDetail.TabIndex = 9
        Me.lblHeaderDetail.Text = "Login"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 27)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'lblPowerby
        '
        Me.lblPowerby.AutoSize = True
        Me.lblPowerby.BackColor = System.Drawing.Color.YellowGreen
        Me.lblPowerby.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.lblPowerby.ForeColor = System.Drawing.Color.Ivory
        Me.lblPowerby.Location = New System.Drawing.Point(227, 295)
        Me.lblPowerby.Name = "lblPowerby"
        Me.lblPowerby.Padding = New System.Windows.Forms.Padding(3)
        Me.lblPowerby.Size = New System.Drawing.Size(108, 18)
        Me.lblPowerby.TabIndex = 12
        Me.lblPowerby.Text = "Powered by : Nithi.re"
        '
        'cbAutoPrint
        '
        Me.cbAutoPrint.AutoSize = True
        Me.cbAutoPrint.Checked = True
        Me.cbAutoPrint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAutoPrint.Location = New System.Drawing.Point(147, 156)
        Me.cbAutoPrint.Name = "cbAutoPrint"
        Me.cbAutoPrint.Size = New System.Drawing.Size(79, 20)
        Me.cbAutoPrint.TabIndex = 2
        Me.cbAutoPrint.Text = "AutoPrint"
        Me.cbAutoPrint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(10, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Link Status : "
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblStatus.Location = New System.Drawing.Point(84, 64)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(44, 16)
        Me.lblStatus.TabIndex = 14
        Me.lblStatus.Text = "Status"
        '
        'lblStaffStatus
        '
        Me.lblStaffStatus.AutoSize = True
        Me.lblStaffStatus.Location = New System.Drawing.Point(265, 64)
        Me.lblStaffStatus.Name = "lblStaffStatus"
        Me.lblStaffStatus.Size = New System.Drawing.Size(57, 16)
        Me.lblStaffStatus.TabIndex = 15
        Me.lblStaffStatus.Text = "lblStatus"
        Me.lblStaffStatus.Visible = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(334, 312)
        Me.Controls.Add(Me.lblStaffStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbAutoPrint)
        Me.Controls.Add(Me.lblPowerby)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHeaderDetail)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btLogin)
        Me.Controls.Add(Me.lblPwd)
        Me.Controls.Add(Me.lblUsern)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtUsern)
        Me.Controls.Add(Me.pbBackground)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DocScanPrinter"
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents lblUsern As System.Windows.Forms.Label
    Friend WithEvents lblPwd As System.Windows.Forms.Label
    Friend WithEvents btLogin As System.Windows.Forms.Button
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents pbBackground As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblHeaderDetail As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPowerby As System.Windows.Forms.Label
    Friend WithEvents cbAutoPrint As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblStaffStatus As System.Windows.Forms.Label
    Friend WithEvents txtUsern As System.Windows.Forms.TextBox

End Class
