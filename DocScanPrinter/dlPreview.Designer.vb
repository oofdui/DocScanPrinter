<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlPreview))
        Me.lblMessage = New System.Windows.Forms.Label
        Me.picPreview = New System.Windows.Forms.PictureBox
        Me.lblManual = New System.Windows.Forms.Label
        Me.btRotateRight = New System.Windows.Forms.Button
        Me.btRotateLeft = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.OK_Button = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.btPrint = New System.Windows.Forms.Button
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(21, 21)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblMessage.TabIndex = 2
        '
        'picPreview
        '
        Me.picPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picPreview.Location = New System.Drawing.Point(3, 3)
        Me.picPreview.Name = "picPreview"
        Me.picPreview.Size = New System.Drawing.Size(661, 782)
        Me.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPreview.TabIndex = 1
        Me.picPreview.TabStop = False
        '
        'lblManual
        '
        Me.lblManual.AutoSize = True
        Me.lblManual.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblManual.Location = New System.Drawing.Point(9, 808)
        Me.lblManual.Name = "lblManual"
        Me.lblManual.Size = New System.Drawing.Size(247, 13)
        Me.lblManual.TabIndex = 3
        Me.lblManual.Text = "TIP : Wheel you mouse for 'zoom in' and 'zoom out'"
        '
        'btRotateRight
        '
        Me.btRotateRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btRotateRight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btRotateRight.ForeColor = System.Drawing.Color.Transparent
        Me.btRotateRight.Image = CType(resources.GetObject("btRotateRight.Image"), System.Drawing.Image)
        Me.btRotateRight.Location = New System.Drawing.Point(52, 825)
        Me.btRotateRight.Name = "btRotateRight"
        Me.btRotateRight.Size = New System.Drawing.Size(35, 35)
        Me.btRotateRight.TabIndex = 2
        Me.btRotateRight.UseVisualStyleBackColor = False
        '
        'btRotateLeft
        '
        Me.btRotateLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btRotateLeft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btRotateLeft.ForeColor = System.Drawing.Color.White
        Me.btRotateLeft.Image = CType(resources.GetObject("btRotateLeft.Image"), System.Drawing.Image)
        Me.btRotateLeft.Location = New System.Drawing.Point(11, 825)
        Me.btRotateLeft.Name = "btRotateLeft"
        Me.btRotateLeft.Size = New System.Drawing.Size(35, 35)
        Me.btRotateLeft.TabIndex = 1
        Me.btRotateLeft.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.picPreview)
        Me.Panel1.Location = New System.Drawing.Point(12, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(667, 788)
        Me.Panel1.TabIndex = 6
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 20)
        Me.Cancel_Button.TabIndex = 5
        Me.Cancel_Button.Text = "Cancel"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 20)
        Me.OK_Button.TabIndex = 4
        Me.OK_Button.Text = "OK"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(489, 1113)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 47)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btPrint
        '
        Me.btPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPrint.ForeColor = System.Drawing.Color.Transparent
        Me.btPrint.Image = CType(resources.GetObject("btPrint.Image"), System.Drawing.Image)
        Me.btPrint.Location = New System.Drawing.Point(93, 825)
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(35, 35)
        Me.btPrint.TabIndex = 3
        Me.btPrint.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'dlPreview
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(694, 760)
        Me.Controls.Add(Me.btPrint)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btRotateLeft)
        Me.Controls.Add(Me.btRotateRight)
        Me.Controls.Add(Me.lblManual)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlPreview"
        Me.ShowInTaskbar = False
        Me.Text = "DocScanPrinter Preview"
        Me.TopMost = True
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Private WithEvents picPreview As System.Windows.Forms.PictureBox
    Friend WithEvents lblManual As System.Windows.Forms.Label
    Friend WithEvents btRotateRight As System.Windows.Forms.Button
    Friend WithEvents btRotateLeft As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btPrint As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument

End Class
