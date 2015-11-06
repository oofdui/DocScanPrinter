Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Management

Public Class frmAuto
    Dim myConnCenter As New SqlConnection(System.Configuration.ConfigurationManager.AppSettings("csCenter"))
    Dim myConnMDR As New SqlConnection(System.Configuration.ConfigurationManager.AppSettings("csMDR"))
    Public lastApp As String = "DocScanPrinter"
    Public picPrint As Image
    Public strSearch As String
    Public tempQueueNumber As String = ""
    Public tempQueueNumberQuery As String = ""

    Public ret As Windows.Forms.DialogResult

    Private Sub frmAuto_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmLogin.Close()
    End Sub

    Private Sub frmAuto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim clsGlobal As New clsGlobal()
        lblHeaderDetail.Text &= " v." & clsGlobal.ApplicationVersion

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        CheckForIllegalCrossThreadCalls = False

        lblUsern.Text = frmLogin.txtUsern.Text.Trim
        btStart.Enabled = True
        btStop.Enabled = False
        pnLoading.Visible = False
        Timer1.Stop()
        BindDocSearch()
        If frmLogin.lblStaffStatus.Text = "admin" Then
            SetupToolStripMenuItem.Enabled = True
        Else
            SetupToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        frmLogin.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim siza As System.Drawing.Size
        Dim Rctb As System.Drawing.Rectangle
        Dim factorW As Single
        Dim factorH As Single
        Dim factor As Single
        Dim printDialog1 As New PrintDialog
        factorW = printDialog1.PrinterSettings.DefaultPageSettings.PrintableArea.Width / picPrint.Size.Width
        factorH = printDialog1.PrinterSettings.DefaultPageSettings.PrintableArea.Height / picPrint.Size.Height
        'Default Size = A4
        'factorW = 4960 / picPrint.Size.Width
        'factorH = 7016 / picPrint.Size.Height
        If factorH < factorW Then
            factor = factorH
        Else
            factor = factorW
        End If
        siza.Height = picPrint.Size.Height * factor
        siza.Width = picPrint.Size.Width * factor

        e.Graphics.DrawImage(picPrint, 0, 0, siza.Width, siza.Height)

        Rctb.X = 0 * factor
        Rctb.Y = 0 * factor
        Rctb.Width = picPrint.Width * factor
        Rctb.Height = picPrint.Height * factor
        e.Graphics.DrawImage(picPrint, Rctb)
    End Sub

    Sub BindDocSearch()
        Dim strSql As String = ""
        Dim i As Integer = 0

        'Bind DocGroup
        strSql = "SELECT Code,(Code+': '+suffixname) As suffixname FROM mdr_docgroup WHERE isactive='1' ORDER BY Code"
        Dim myDa As New SqlDataAdapter(strSql, myConnMDR)
        Dim ds As New DataSet
        myDa.Fill(ds, "dsDocGroup")
        Dim dr As DataRow = ds.Tables("dsDocGroup").NewRow()
        dr(0) = "0" : dr(1) = "-- All --"
        ds.Tables("dsDocGroup").Rows.InsertAt(dr, 0)
        If ds.Tables("dsDocGroup").Rows.Count <> 0 Then
            ddlDocGroup.DataSource = ds.Tables("dsDocGroup")
            ddlDocGroup.DisplayMember = "suffixname"
            ddlDocGroup.ValueMember = "Code"
        End If

        'Bind Location
        strSql = "SELECT code,prefixname FROM mdr_location ORDER BY prefixname"
        myDa = New SqlDataAdapter(strSql, myConnMDR)
        myDa.Fill(ds, "dsLocation")
        Dim drLocation As DataRow = ds.Tables("dsLocation").NewRow()
        drLocation(0) = "0" : drLocation(1) = "-- All --"
        ds.Tables("dsLocation").Rows.InsertAt(drLocation, 0)
        If ds.Tables("dsLocation").Rows.Count <> 0 Then
            ddlLocation.DataSource = ds.Tables("dsLocation")
            ddlLocation.ValueMember = "code"
            ddlLocation.DisplayMember = "prefixname"
        End If
    End Sub

    Private Sub ddlDocGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlDocGroup.SelectedIndexChanged
        If ddlDocGroup.SelectedIndex <> 0 Then
            ddlDocSubGroup.Enabled = True

            'Bind DocSubGroup
            Dim strSql As String = "SELECT subcode,(subcode+': '+suffixname) As suffixname FROM mdr_docsubgroup WHERE isactive='1' AND code='" & ddlDocGroup.SelectedValue & "' ORDER BY subcode"
            Dim myDa As New SqlDataAdapter(strSql, myConnMDR)
            Dim ds As New DataSet()
            myDa.Fill(ds, "dsDocSubGroup")
            Dim dr As DataRow = ds.Tables("dsDocSubGroup").NewRow
            dr(0) = "0" : dr(1) = "-- All --"
            ds.Tables("dsDocSubGroup").Rows.InsertAt(dr, 0)

            ddlDocSubGroup.DataSource = ds.Tables("dsDocSubGroup")
            ddlDocSubGroup.DisplayMember = "suffixname"
            ddlDocSubGroup.ValueMember = "subcode"

            ddlDocSubGroup.Focus()
        Else
            ddlDocSubGroup.Enabled = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        frmLogin.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    Function SQLReturnCenter(ByVal strSql As String) As String
        Dim myCmd As New SqlCommand(strSql, myConnCenter)
        Try
            myConnCenter.Open()
            Dim returnValue As String = myCmd.ExecuteScalar
            myConnCenter.Close()
            myCmd.Dispose()
            Return returnValue
        Catch ex As Exception
            Try
                myConnCenter.Close()
                myCmd.Dispose()
            Catch ex2 As Exception

            End Try
            Return "0"
        End Try
    End Function

    Function SQLExecuteCenter(ByVal strSql As String) As Boolean
        Dim myCmd As New SqlCommand(strSql, myConnCenter)
        Try
            myConnCenter.Open()
            myCmd.ExecuteNonQuery()
            myConnCenter.Close()
            myCmd.Dispose()
            Return True
        Catch ex As Exception
            Try
                myConnCenter.Close()
                myCmd.Dispose()
            Catch ex2 As Exception

            End Try
            Return False
        End Try
    End Function

    Function SQLReturnMDR(ByVal strSql As String) As String
        Dim myCmd As New SqlCommand(strSql, myConnMDR)
        Try
            myConnMDR.Open()
            Dim returnValue As String = myCmd.ExecuteScalar
            myConnMDR.Close()
            myCmd.Dispose()
            Return returnValue
        Catch ex As Exception
            Try
                myConnMDR.Close()
                myCmd.Dispose()
            Catch ex2 As Exception

            End Try
            Return "0"
        End Try
    End Function

    Function SQLExecuteMDR(ByVal strSql As String) As Boolean
        Dim myCmd As New SqlCommand(strSql, myConnMDR)
        Try
            myConnMDR.Open()
            myCmd.ExecuteNonQuery()
            myConnMDR.Close()
            myCmd.Dispose()
            Return True
        Catch ex As Exception
            Try
                myConnMDR.Close()
                myCmd.Dispose()
            Catch ex2 As Exception

            End Try
            Return False
        End Try
    End Function

    Private Sub AutoPrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoPrintToolStripMenuItem.Click
        'Timer1.Stop()
        Me.Hide()
        'strSearch = ""
        frmDefault.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not BackgroundWorker1.IsBusy Then
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub btStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStart.Click
        ret = PrintDialog1.ShowDialog()

        Dim i As Integer = 0
        lblTimerTick.Text = "0" : lblTimerTick.Refresh()
        'ส่วนค้นหา
        strSearch = ""
        Dim checkSearch As Boolean = False
        If dtpFrom.Checked = True And dtpTo.Checked = True Then 'เลือกช่วงวัน
            'Between
            checkSearch = True
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "(CF.scannow BETWEEN '" & dtpFrom.Value.ToString("yyyy-dd-MM") & " " & dtpFromT.Value.Hour & ":" & dtpFromT.Value.Minute & "' AND '" & dtpTo.Value.ToString("yyyy-dd-MM") & " " & dtpToT.Value.Hour & ":" & dtpToT.Value.Minute & "') "
        ElseIf dtpFrom.Checked = True And dtpTo.Checked = False Then 'เลือกวันเริ่มต้น
            'DT >= ...
            checkSearch = True
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "CF.scannow >= '" & dtpFrom.Value.ToString("yyyy-dd-MM") & " " & dtpFromT.Value.Hour & ":" & dtpFromT.Value.Minute & "' "
        ElseIf dtpFrom.Checked = False And dtpTo.Checked = True Then 'เลือกวันสิ้นสุด
            'DT <= ...
            checkSearch = True
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "CF.scannow <='" & dtpTo.Value.ToString("yyyy-dd-MM") & " " & dtpToT.Value.Hour & ":" & dtpToT.Value.Minute & "' "
        End If
        If lbGroup.Items.Count > 0 Then
            Dim docGroupSplit As Array
            Dim docGroup As String = ""
            Dim docSubGroup As String = ""
            Dim chkGroupAll As Boolean = False
            Dim strGroupSearch As String = ""

            For i = 0 To lbGroup.Items.Count - 1
                'แยก Group และ SubGroup ออกจากกันด้วยสัญลักษณ์  , และ แยกรหัสกลุ่ม ออกจากชื่อกลุ่มด้วยสัญลักษณ์ :
                docGroupSplit = Split(lbGroup.Items(i), " , ")
                docGroup = docGroupSplit(0)
                docSubGroup = docGroupSplit(1)
                If docGroup <> "ALL" And docSubGroup <> "ALL" Then
                    docGroupSplit = Nothing
                    docGroupSplit = Split(docGroup, ":")
                    docGroup = docGroupSplit(0).ToString.Trim

                    docGroupSplit = Nothing
                    docGroupSplit = Split(docSubGroup, ":")
                    docSubGroup = docGroupSplit(0).ToString.Trim

                    strGroupSearch &= "(CF.docgrp='" & docGroup & "' AND CF.docsubgrp='" & docSubGroup & "')"
                ElseIf docGroup <> "ALL" And docSubGroup = "ALL" Then
                    docGroupSplit = Nothing
                    docGroupSplit = Split(docGroup, ":")
                    docGroup = docGroupSplit(0).ToString.Trim

                    strGroupSearch &= "(CF.docgrp='" & docGroup & "')"
                Else
                    chkGroupAll = True
                End If

                If i < lbGroup.Items.Count - 1 Then
                    strGroupSearch &= " OR "
                End If
            Next

            If chkGroupAll <> True Then
                checkSearch = True
                If InStr(strSearch, "WHERE") <> 0 Then
                    strSearch &= "AND (" & strGroupSearch & ") "
                Else
                    strSearch &= "WHERE (" & strGroupSearch & ") "
                End If
            End If
        End If
        If lbLocation.Items.Count > 0 Then
            Dim location As String = ""
            Dim locationSplit As Array
            Dim chkLocationAll As Boolean = False
            Dim strLocationSearch As String = ""
            For i = 0 To lbLocation.Items.Count - 1
                'แยกรหัสแผนก กับ ชื่อแผนกออกจากกัน
                locationSplit = Nothing
                locationSplit = Split(lbLocation.Items(i), " : ")
                location = locationSplit(0).ToString.Trim

                If location <> "ALL" Then
                    strLocationSearch &= "CF.locationcode='" & location & "'"
                Else
                    chkLocationAll = True
                End If

                If i < lbLocation.Items.Count - 1 Then
                    strLocationSearch &= " OR "
                End If
            Next

            If chkLocationAll = False Then
                checkSearch = True
                If InStr(strSearch, "WHERE") <> 0 Then
                    strSearch &= "AND (" & strLocationSearch & ") "
                Else
                    strSearch &= "WHERE (" & strLocationSearch & ") "
                End If
            End If
        End If
        If checkSearch = False Then 'กรณีไม่ได้กรอกข้อมูลสำหรับค้นหา ให้ลบค่าใน strSearch ทิ้ง
            MsgBox("คุณจำเป็นต้องเลือกตัวเลือกในการค้นหา", MsgBoxStyle.ApplicationModal)
            strSearch = ""
            Exit Sub
        End If
        If ret = Windows.Forms.DialogResult.OK Then
            If PrinterChecker().ToString.Trim <> "Unknown" Then
                BackgroundWorker1.RunWorkerAsync()
                Timer1.Start()
            Else
                MsgBox("ปริ้นเตอร์ที่คุณเลือกไม่สามารถใช้งานได้ในขณะนี้" & ":" & PrinterChecker())
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStop.Click
        Timer1.Stop()
        strSearch = ""

        If BackgroundWorker1.IsBusy Then
            If BackgroundWorker1.WorkerSupportsCancellation Then
                BackgroundWorker1.CancelAsync()
            End If
        End If
        pnLoading.Visible = False

        btStart.Enabled = True : btStart.Text = "Start"
        btStop.Enabled = False
        dtpFrom.Enabled = True
        dtpTo.Enabled = True
        dtpFromT.Enabled = True
        dtpToT.Enabled = True
        ddlDocGroup.Enabled = True
        If ddlDocGroup.SelectedIndex > 0 Then
            ddlDocSubGroup.Enabled = True
        Else
            ddlDocSubGroup.Enabled = False
        End If

        ddlLocation.Enabled = True

        lbGroup.Enabled = True
        lbLocation.Enabled = True
        btGroupAdd.Enabled = True : IIf(lbGroup.Items.Count > 0, btGroupRemove.Enabled = True, btGroupRemove.Enabled = False)
        btLocationAdd.Enabled = True : IIf(lbLocation.Items.Count > 0, btLocationRemove.Enabled = True, btLocationRemove.Enabled = False)
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'Disable Control
        btStart.Enabled = False
        btStop.Enabled = True
        dtpFrom.Enabled = False
        dtpTo.Enabled = False
        ddlDocGroup.Enabled = False
        ddlDocSubGroup.Enabled = False
        ddlLocation.Enabled = False
        dtpFromT.Enabled = False
        dtpToT.Enabled = False
        lbGroup.Enabled = False
        lbLocation.Enabled = False
        btGroupAdd.Enabled = False : btGroupRemove.Enabled = False
        btLocationAdd.Enabled = False : btLocationRemove.Enabled = False

        pnLoading.Visible = True
        Dim strSql As String = ""
        Dim pharmacyQueueQueryWhere As String = ""
        Dim clsGlobal As New clsGlobal()
        If clsGlobal.PharmacyQueueMode = "Enable" Then
            pharmacyQueueQueryWhere = " AND (SELECT COUNT(itemno) FROM mdr_pharmacyremarks WITH(NOLOCK) WHERE hn=CF.hn AND episode=CF.episode AND itemno=CF.itemno)>0 "
        End If
        'ส่วนตรวจสอบว่าเป็นการวนลูปปริ้นโดยการคลิกเริ่ม หรือ ผ่านตัว Timer
        If lblTimerTick.Text = "0" Then 'ถ้าเป็นการคลิกเริ่ม จะวนลูปทั้งหมด เริ่มจากเวลาน้อยสุด
            strSql = "SELECT CF.hn AS HN, CF.episode AS Episode, CF.itemno AS No," & _
            "CF.scannow AS ScanNow " & _
            "FROM dbo.mdr_cardfiles AS CF WITH(NOLOCK) LEFT OUTER JOIN " & _
            "dbo.mdr_location AS LO WITH(NOLOCK) ON CF.locationcode = LO.code INNER JOIN " & _
            "dbo.mdr_docgroup AS DG WITH(NOLOCK) ON CF.docgrp = DG.code INNER JOIN " & _
            "dbo.mdr_docsubgroup AS DS WITH(NOLOCK) ON CF.docgrp = DS.code AND CF.docsubgrp = DS.subcode " & _
            strSearch & _
            pharmacyQueueQueryWhere & _
            "ORDER BY CF.scannow"
        Else 'ถ้าผ่าน Timer จะดึงแค่ Top 20 พอ เริ่มจากเวลาปัจจุบัน
            strSql = "SELECT TOP 20 CF.hn AS HN, CF.episode AS Episode, CF.itemno AS No," & _
            "CF.scannow AS ScanNow " & _
            "FROM dbo.mdr_cardfiles AS CF WITH(NOLOCK) LEFT OUTER JOIN " & _
            "dbo.mdr_location AS LO WITH(NOLOCK) ON CF.locationcode = LO.code INNER JOIN " & _
            "dbo.mdr_docgroup AS DG WITH(NOLOCK) ON CF.docgrp = DG.code INNER JOIN " & _
            "dbo.mdr_docsubgroup AS DS WITH(NOLOCK) ON CF.docgrp = DS.code AND CF.docsubgrp = DS.subcode " & _
            strSearch & _
            pharmacyQueueQueryWhere & _
            "ORDER BY CF.scannow DESC"
        End If

        TextBox1.Text = strSql
        'Exit Sub

        lblTimerTick.Text = Val(lblTimerTick.Text) + 1 : lblTimerTick.Refresh()

        'TextBox1.Text = strSql : Exit Sub
        Dim myDa As New SqlDataAdapter(strSql, myConnMDR)
        Dim ds As New DataSet()
        myDa.Fill(ds, "dsAutoPrint")
        If ds.Tables("dsAutoPrint").Rows.Count <> 0 Then
            Dim i As Integer = 0
            'หา IP เครื่อง
            Dim hostName, ip As String
            hostName = "" : ip = ""
            Try
                hostName = System.Net.Dns.GetHostName()
                Dim IPHost As IPHostEntry = Dns.GetHostByName(hostName)
                Dim ipFind As IPAddress() = IPHost.AddressList
                ip = ipFind(0).ToString
            Catch ex As Exception

            End Try

            Dim ScanNowTest As String

            For i = 0 To ds.Tables("dsAutoPrint").Rows.Count - 1
                If BackgroundWorker1.CancellationPending = False Then
                    If PrinterChecker().ToString.Trim <> "Unknown" Then
                        With ds.Tables("dsAutoPrint").Rows(i)
                            ScanNowTest = .Item("ScanNow")
                            BindPicture(.Item("HN"), .Item("Episode"), .Item("No"), ScanNowTest, hostName, ip)
                        End With
                    Else
                        MsgBox("ปริ้นเตอร์ที่คุณเลือกไม่สามารถใช้งานได้ในขณะนี้")
                        Timer1.Stop()
                        strSearch = ""

                        If BackgroundWorker1.IsBusy Then
                            If BackgroundWorker1.WorkerSupportsCancellation Then
                                BackgroundWorker1.CancelAsync()
                            End If
                        End If
                        pnLoading.Visible = False

                        btStart.Enabled = True : btStart.Text = "Start"
                        btStop.Enabled = False
                        dtpFrom.Enabled = True
                        dtpTo.Enabled = True
                        dtpFromT.Enabled = True
                        dtpToT.Enabled = True
                        ddlDocGroup.Enabled = True
                        If ddlDocGroup.SelectedIndex > 0 Then
                            ddlDocSubGroup.Enabled = True
                        Else
                            ddlDocSubGroup.Enabled = False
                        End If

                        ddlLocation.Enabled = True

                        lbGroup.Enabled = True
                        lbLocation.Enabled = True
                        btGroupAdd.Enabled = True : IIf(lbGroup.Items.Count > 0, btGroupRemove.Enabled = True, btGroupRemove.Enabled = False)
                        btLocationAdd.Enabled = True : IIf(lbLocation.Items.Count > 0, btLocationRemove.Enabled = True, btLocationRemove.Enabled = False)
                        Exit Sub
                    End If
                Else
                    Exit For
                End If
            Next
        End If
    End Sub

    Function BindPicture(ByVal hn As String, ByVal episode As String, ByVal no As Integer, ByVal scannow As DateTime, ByVal hostname As String, ByVal ip As String) As Boolean
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Dim strSql As String = ""
        Dim scannowTemp As DateTime = scannow
        Dim clsGlobal As New clsGlobal()

        If scannowTemp.Second >= 30 Then
            scannowTemp = scannowTemp.AddMinutes(1)
        End If
        strSql = "SELECT COUNT(mdr_autoprint_log.hn) " & _
            "FROM mdr_autoprint_log " & _
            "WHERE mdr_autoprint_log.hn='" & hn & "' AND " & _
            "mdr_autoprint_log.episode='" & episode & "' AND " & _
            "mdr_autoprint_log.itemno=" & no & " AND " & _
            "CONVERT(VARCHAR(19), mdr_autoprint_log.scannow, 120)='" & scannowTemp.ToString("yyyy-MM-dd HH:mm") & ":00'"
        'Work for me : scannow.ToString("yyyy-dd-MM HH:mm:ss")
        'TextBox1.Text = strSql ' : Exit Function
        If Val(SQLReturnMDR(strSql)) = 0 Then
            'ตรวจสอบรูปว่ามีหรือไม่
            strSql = "SELECT ISNULL(mdrpic,'')As mdrpic FROM mdr_cardfiles WITH(NOLOCK) WHERE hn='" & hn & "' AND episode='" & episode & "' AND itemno=" & no & _
                " AND CONVERT(VARCHAR(19), scannow, 120)='" & scannow.ToString("yyyy-MM-dd HH:mm:ss") & "'"
            'TextBox1.Text = strSql : Exit Function
            Dim myCmd As New SqlCommand(strSql, myConnMDR)
            myConnMDR.Open()
            'Dim mdrPic As String = myCmd.ExecuteScalar.ToString()
            If myCmd.ExecuteScalar.ToString() <> "" Then
                Dim imagedata() As Byte = CType(myCmd.ExecuteScalar(), Byte())

                If (Not imagedata Is Nothing) Then
                    'TextBox1.Text = "แปลงภาพได้"
                    Try
                        Dim ms As New IO.MemoryStream(imagedata)
                        Dim img As Image = Image.FromStream(ms)
                        Dim priorityName As String = ""

                        myConnMDR.Close()
                        'ใส่ข้อความลงบนภาพ
                        Dim imageDrawerText As String = ""
                        If clsGlobal.PharmacyQueuePriorityBuilder = "Enable" Then
                            priorityName = PrioritySelect(hn, episode, no)
                            If imageDrawerText.Length > 0 Then
                                imageDrawerText &= " , "
                            End If
                            imageDrawerText &= priorityName
                        End If
                        If clsGlobal.PharmacyQueuePriorityCounterBuilder = "Enable" Then
                            imageDrawerText &= " (" & CountByPriority(priorityName, hn, episode, no) & ")"
                        End If
                        If clsGlobal.PrintTimeBuilder = "Enable" Then
                            If imageDrawerText.Length > 0 Then
                                imageDrawerText &= " "
                            End If
                            imageDrawerText &= DateTime.Now.ToString("dd/MM/yyyy HH:mm")
                        End If
                        ImageDrawer(img, imageDrawerText)

                        picPrint = Nothing
                        picPrint = img
                        
                        'ปริ้นเอกสาร
                        'Dim printControl = New Printing.StandardPrintController
                        'PrintDocument1.PrintController = printControl
                        'PrintDocument1.Print()
                        PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
                        PrintDocument1.Print()

                        'แสดงชื่อไฟล์ที่กำลังปริ้น
                        lbPrinting.Items.Insert(0, "HN:" & hn & " (" & no & ")  ScanTime:" & scannow & " " & SQLReturnMDR("SELECT '('+docgrp+':'+docsubgrp+':'+locationcode+')' FROM mdr_cardfiles WITH(NOLOCK) WHERE hn='" & hn & "' AND episode='" & episode & "' AND itemno=" & no))
                        lbPrinting.SelectedIndex = 0
                        lbPrinting.Refresh()

                        System.Threading.Thread.Sleep(1000) 'หน่วงเวลา 1 วินาที
                        lbPrinting.ClearSelected()
                        System.Threading.Thread.Sleep(2000) 'หน่วงเวลา 2 วินาที
                        If lbPrinting.Items.Count > 10 Then
                            lbPrinting.Items.RemoveAt(10)
                        End If
                        'อัพเดทการปริ้น
                        Dim tmpSQL As String = "INSERT INTO mdr_autoprint_log(hn,episode,itemno,scannow,usern,hostname,ipaddress,dtprint) VALUES('" & hn & "','" & episode & "'," & no & ",'" & scannow.ToString("yyyy-dd-MM HH:mm:ss") & "','" & lblUsern.Text.Trim & "','" & hostname & "','" & ip & "','" & Now.ToString("yyyy-dd-MM HH:mm:ss") & "')"
                        'Work for me : Now.ToString("yyyy-dd-MM HH:mm:ss")
                        SQLExecuteMDR(tmpSQL)
                        Return True
                    Catch ex As Exception
                        'อัพเดทการปริ้น
                        'SQLExecuteMDR("INSERT INTO mdr_autoprint_log(hn,episode,itemno,usern,hostname,ipaddress,dtprint) VALUES('" & hn & "','" & episode & "'," & no & ",'" & frmLogin.txtUsern.Text.Trim & "','" & hostname & "','" & ip & "','" & Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "')")
                        'เช็คกรณี QueueNumber บนหัวใบยาซ้ำกันกับเลขที่ได้ก่อนหน้า ให้เมล์มาหา
                        Dim mailTo As String = System.Configuration.ConfigurationManager.AppSettings("mailTo")
                        If (mailTo = "") Then
                            mailTo = "nithi.re@glsict.com"
                        End If
                        Try
                            Dim wsDefault As New wsDefault.ServiceSoapClient
                            wsDefault.MailSend(
                                mailTo,
                                "DocScanPrinter : BindPicture & Update PrintLog",
                                ex.Message,
                                "AutoSystem@glsict.com",
                                System.Configuration.ConfigurationManager.AppSettings("Site") & " : " & "DocScanPrinter",
                                "", "", "", False)
                        Catch ex2 As Exception

                        End Try
                        Return False
                    End Try
                Else
                    TextBox1.Text = "แปลงภาพไม่ได้"
                    myConnMDR.Close()
                    Return False
                End If
            End If
        Else
            Return False
        End If
    End Function

    Private Function ImageDrawer(Img As Image, Text As String)
        Dim clsGlobal As New clsGlobal()
        Dim DrawGraphic As Graphics = Drawing.Graphics.FromImage(Img)
        Dim DrawFont As New Font(clsGlobal.DrawFontName, clsGlobal.DrawFontSize, FontStyle.Regular)
        Dim DrawBrush As New SolidBrush(Color.Black)
        Dim DrawPoint As New PointF(20.0F, 30.0F)
        Dim imageRectangle As New Rectangle(0, 0, Img.Width, Img.Height)
        Dim strFormat As New StringFormat()

        Select Case clsGlobal.DrawPosition
            Case "TopRight"
                strFormat.Alignment = StringAlignment.Far
                strFormat.LineAlignment = StringAlignment.Near
            Case "TopLeft"
                strFormat.Alignment = StringAlignment.Near
                strFormat.LineAlignment = StringAlignment.Near
            Case "BottomRight"
                strFormat.Alignment = StringAlignment.Far
                strFormat.LineAlignment = StringAlignment.Far
            Case "BottomLeft"
                strFormat.Alignment = StringAlignment.Near
                strFormat.LineAlignment = StringAlignment.Far
            Case "TopCenter"
                strFormat.Alignment = StringAlignment.Center
                strFormat.LineAlignment = StringAlignment.Near
            Case "BottomCenter"
                strFormat.Alignment = StringAlignment.Center
                strFormat.LineAlignment = StringAlignment.Far
            Case Else

        End Select

        Try
            DrawGraphic.DrawString(Text, New Font(clsGlobal.DrawFontName, clsGlobal.DrawFontSize * (100 / DrawGraphic.DpiX)), New SolidBrush(Color.Black), imageRectangle, strFormat)
            DrawGraphic.Save()
            DrawGraphic.DrawImage(Img, 0, 0)
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดขณะเขียนอักษรลงบนภาพ " & ex.Message, "ImageDrawer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        DrawPoint = Nothing
        DrawBrush = Nothing
        DrawFont = Nothing
        DrawGraphic = Nothing
        Return Img
    End Function
    Private Function PrioritySelect(HN As String, Episode As String, ItemNo As String)
        Dim strSQL As New System.Text.StringBuilder()
        Dim result As String = ""
        strSQL.Append("SELECT ")
        strSQL.Append("E.prefixname Priority ")
        strSQL.Append("FROM ")
        strSQL.Append("mdr_pharmacyremarks A WITH(NOLOCK) ")
        strSQL.Append("INNER JOIN mdr_syspharmacypriority E WITH(NOLOCK) ON A.ordertype=E.code AND E.isactive='1' ")
        strSQL.Append("WHERE ")
        strSQL.Append("hn='" & HN & "' ")
        strSQL.Append("AND episode='" & Episode & "' ")
        strSQL.Append("AND itemno=" & ItemNo & ";")

        result = SQLReturnMDR(strSQL.ToString())
        Return result
    End Function
    Private Function CountByPriority(PriorityName As String, HN As String, Episode As String, ItemNo As String)
        Dim result As String = ""
        Dim strSQL As New System.Text.StringBuilder()

        strSQL.Append("SELECT RowNumber FROM ")
        strSQL.Append("(")
        strSQL.Append("SELECT ")
        strSQL.Append("ROW_NUMBER() OVER (ORDER BY B.scannow ASC) RowNumber,A.hn,A.episode,A.itemno,B.scannow,E.prefixname PriorityName ")

        strSQL.Append("FROM ")
        strSQL.Append("mdr_pharmacyremarks A ")
        strSQL.Append("INNER JOIN mdr_cardfiles B ON A.hn=B.hn AND A.episode=B.episode AND A.itemno=B.itemno ")
        strSQL.Append("INNER JOIN mdr_syspharmacypriority E ON A.ordertype=E.code AND E.isactive='1' ")

        strSQL.Append("WHERE ")
        strSQL.Append("B.scannow>=CONVERT(DATE,GETDATE()) ")
        strSQL.Append("AND E.prefixname='" & PriorityName & "' ")
        strSQL.Append(") TB ")
        strSQL.Append("WHERE hn='" & HN.Replace("-", "") & "' AND episode='" & Episode.Replace("-", "") & "' AND itemno=" & ItemNo & ";")
        result = SQLReturnMDR(strSQL.ToString())
        Try
            If (result = tempQueueNumber) Then
                'เช็คกรณี QueueNumber บนหัวใบยาซ้ำกันกับเลขที่ได้ก่อนหน้า ให้เมล์มาหา
                Dim mailTo As String = System.Configuration.ConfigurationManager.AppSettings("mailTo")
                If (mailTo = "") Then
                    mailTo = "nithi.re@glsict.com"
                End If
                Dim wsDefault As New wsDefault.ServiceSoapClient
                wsDefault.MailSend(
                    mailTo,
                    "DocScanPrinter : Duplicate Queue Number",
                    "Previous Query : " & tempQueueNumberQuery & "<br/>Previous Number : " & tempQueueNumber & "<hr/>" &
                    "Current Query : " & strSQL.ToString() & "<br/>Current Number : " & result,
                    "AutoSystem@glsict.com",
                    System.Configuration.ConfigurationManager.AppSettings("Site") & " : " & "DocScanPrinter",
                    "", "", "", False)
            End If
        Catch ex As Exception

        End Try
        tempQueueNumber = result
        tempQueueNumberQuery = strSQL.ToString()

        Return result
    End Function
    Private Sub btGroupAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGroupAdd.Click
        Dim i As Integer = 0
        Dim chkDuplicate As Boolean = False
        For i = 0 To lbGroup.Items.Count - 1
            If lbGroup.Items(i).ToString = IIf(ddlDocGroup.SelectedValue = "0", "ALL", ddlDocGroup.Text) & " , " & IIf(ddlDocSubGroup.Enabled = True, IIf(ddlDocSubGroup.SelectedValue = "0", "ALL", ddlDocSubGroup.Text), "ALL") Then
                chkDuplicate = True
            End If
        Next
        If chkDuplicate = False Then
            lbGroup.Items.Insert(0, IIf(ddlDocGroup.SelectedValue = "0", "ALL", ddlDocGroup.Text) & " , " & IIf(ddlDocSubGroup.Enabled = True, IIf(ddlDocSubGroup.SelectedValue = "0", "ALL", ddlDocSubGroup.Text), "ALL"))
        End If
        btGroupRemove.Enabled = True
    End Sub

    Private Sub btGroupRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGroupRemove.Click
        If lbGroup.Items.Count > 0 Then
            btGroupRemove.Enabled = True
            If lbGroup.SelectedItems.Count > 0 Then
                lbGroup.Items.RemoveAt(lbGroup.SelectedIndex)
                lbGroup.Refresh()
                If lbGroup.Items.Count = 0 Then
                    btGroupRemove.Enabled = False
                End If
            End If
        Else
            btGroupRemove.Enabled = False
        End If
    End Sub

    Private Sub btLocationAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLocationAdd.Click
        Dim i As Integer = 0
        Dim chkDuplicate As Boolean = False
        For i = 0 To lbLocation.Items.Count - 1
            If lbLocation.Items(i).ToString = IIf(ddlLocation.SelectedValue = "0", "ALL", ddlLocation.SelectedValue & " : " & ddlLocation.Text) Then
                chkDuplicate = True
            End If
        Next
        If chkDuplicate = False Then
            lbLocation.Items.Insert(0, IIf(ddlLocation.SelectedValue = "0", "ALL", ddlLocation.SelectedValue & " : " & ddlLocation.Text))
        End If
        btLocationRemove.Enabled = True
    End Sub

    Private Sub btLocationRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLocationRemove.Click
        If lbLocation.Items.Count > 0 Then
            btLocationRemove.Enabled = True
            If lbLocation.SelectedItems.Count > 0 Then
                lbLocation.Items.RemoveAt(lbLocation.SelectedIndex)
                lbLocation.Refresh()
                If lbLocation.Items.Count = 0 Then
                    btLocationRemove.Enabled = False
                End If
            End If
        Else
            btLocationRemove.Enabled = False
        End If
    End Sub

    Private Sub SetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetupToolStripMenuItem.Click
        'Me.Hide()
        frmDocumentSet.ShowDialog()
    End Sub

    Private Sub DocumentSetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentSetToolStripMenuItem.Click
        frmDocumentSetChoose.ShowDialog()
        frmDocumentSetChoose.dgDocumentSet.ClearSelection()
    End Sub

    Private Sub lbGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbGroup.SelectedIndexChanged
        btGroupRemove.Enabled = True
    End Sub

    Private Sub lbGroup_ValueMemberChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbGroup.ValueMemberChanged
        If lbGroup.Items.Count = 0 Then
            btGroupRemove.Enabled = False
        End If
    End Sub

    Private Sub lbLocation_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbLocation.SelectedIndexChanged
        btLocationRemove.Enabled = True
    End Sub

    Private Sub lbLocation_ValueMemberChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbLocation.ValueMemberChanged
        If lbLocation.Items.Count = 0 Then
            btLocationRemove.Enabled = False
        End If
    End Sub

    Private Sub AutoPrintHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoPrintHistoryToolStripMenuItem.Click
        'frmAutoPrintHis.ShowDialog()
        frmAutoPrintLog.ShowDialog()
    End Sub

    Sub PrinterCheck()
        Dim scope As New ManagementScope("\root\cimv2")
        scope.Connect()
        ' Select Printers from WMI Object Collections 
        Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_Printer")
        Dim printerName As String = ""
        For Each printer As ManagementObject In searcher.[Get]()
            printerName = printer("Name").ToString().ToLower()

            If printerName.Equals(PrintDialog1.PrinterSettings.PrinterName.ToString.ToLower) Then
                Console.WriteLine("Printer = " + printer("Name"))
                If printer("WorkOffline").ToString().ToLower().Equals("true") Then
                    ' printer is offline by user 
                    MsgBox("Your Plug-N-Play printer is not connected.")
                Else
                    ' printer is not offline 
                    MsgBox("Your Plug-N-Play printer is connected.")
                    MsgBox("Printer = " + printer("Name"))
                End If
            End If
        Next
    End Sub

    Private Enum PrinterStatus
        PrinterIdle = 3
        PrinterPrinting = 4
        PrinterWarmingUp = 5
        PrinterOffline = 7
        PrinterPause = 8
        PrinterError = 9
        ' For more states see WMI docs.
    End Enum

    Private Function PrinterStatusToString(ByVal ps As PrinterStatus) As String
        Dim s As String
        Select Case ps
            Case PrinterStatus.PrinterIdle
                s = "Waiting"
            Case PrinterStatus.PrinterPrinting
                s = "Printing"
            Case PrinterStatus.PrinterWarmingUp
                s = "Warming up"
                'Case PrinterStatus.PrinterOffline
                's = "Offline"
                'Case PrinterStatus.PrinterPause
                's = "Paused"
                'Case PrinterStatus.PrinterError
                's = "Error"
            Case Else ' Vielleicht gibt es noch weitere Fälle...
                s = "Unknown"
        End Select
        PrinterStatusToString = s
    End Function

    Function PrinterChecker() As String
        Dim strPrintServer As String = ""
        Dim printerStatus As String = ""
        Dim printerName As String = ""
        strPrintServer = "localhost"
        Dim WMIObject As String, PrinterSet As Object, Printer As Object
        WMIObject = "winmgmts://" & strPrintServer
        PrinterSet = GetObject(WMIObject).InstancesOf("win32_Printer")
        For Each Printer In PrinterSet
            If Printer.Name = PrintDialog1.PrinterSettings.PrinterName Then
                printerName = Printer.Name
                printerStatus = PrinterStatusToString(Printer.PrinterStatus)
            End If
        Next Printer

        'MsgBox(printerName & ":" & printerStatus)
        Return printerStatus
    End Function

    Function SQLReturn(ByVal strSql As String) As String
        Dim myCmd As New SqlCommand(strSql, myConnMDR)
        Try
            myConnMDR.Open()
            Dim returnValue As String = myCmd.ExecuteScalar
            myConnMDR.Close()
            myCmd.Dispose()
            Return returnValue
        Catch ex As Exception
            Try
                myConnMDR.Close()
                myCmd.Dispose()
            Catch ex2 As Exception

            End Try
            Return ""
        End Try
    End Function
End Class