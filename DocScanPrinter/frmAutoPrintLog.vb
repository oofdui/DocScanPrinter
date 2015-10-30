Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class frmAutoPrintLog
    Dim myConnCenter As New SqlConnection(System.Configuration.ConfigurationManager.AppSettings("csCenter"))
    Dim myConnMDR As New SqlConnection(System.Configuration.ConfigurationManager.AppSettings("csMDR"))
    Public lastApp As String = "DocScanPrinter"
    Public hn, episode, no As String
    Public picPrint As Image
    Public strSearch As String
    Public retSelect As Windows.Forms.DialogResult

    Private Sub frmAutoPrintLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        'pnLoading.Visible = False
        btSearch.Enabled = True : btCancel.Enabled = False
        dgDocList.Visible = False
        'CheckForIllegalCrossThreadCalls = False
        BindDocSearch()
        dtpFrom.Checked = False : dtpTo.Checked = False
        dtpPFrom.Checked = True : dtpPTo.Checked = True
        dtpTPrint_f.Value = Now.Date & " " & Now.Hour - 1 & ":" & Now.Minute
        dtpTPrint_t.Value = Now.Date & " 23:59:59"
        If frmLogin.lblStaffStatus.Text = "admin" Then
            SetupToolStripMenuItem1.Enabled = True
        Else
            SetupToolStripMenuItem1.Enabled = False
        End If

        lbGroup.Items.Clear()
        lbLocation.Items.Clear()
        '# Default Search
        strSearch = ""
        If dtpPFrom.Checked = True And dtpPTo.Checked = True Then 'เลือกช่วงวัน
            'Between
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "(AP.dtprint BETWEEN '" & dtpPFrom.Value.Date.ToString("yyyy-dd-MM") & " " & dtpTPrint_f.Value.Hour & ":" & dtpTPrint_f.Value.Minute & "' AND '" & dtpPTo.Value.Date.ToString("yyyy-dd-MM") & " " & dtpTPrint_t.Value.Hour & ":" & dtpTPrint_t.Value.Minute & "') "
        ElseIf dtpPFrom.Checked = True And dtpPTo.Checked = False Then 'เลือกวันเริ่มต้น
            'DT >= ...
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "AP.dtprint >= '" & dtpPFrom.Value.Date.ToString("yyyy-dd-MM") & " " & dtpTPrint_f.Value.Hour & ":" & dtpTPrint_f.Value.Minute & "' "
        ElseIf dtpPFrom.Checked = False And dtpPTo.Checked = True Then 'เลือกวันสิ้นสุด
            'DT <= ...
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "AP.dtprint <='" & dtpPTo.Value.Date.ToString("yyyy-dd-MM") & " " & dtpTPrint_t.Value.Hour & ":" & dtpTPrint_t.Value.Minute & "' "
        End If
        dgDocList.Visible = True
        BindData()
    End Sub

    Private Sub frmAutoPrintLog_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Close()
    End Sub

    Sub BindDocSearch()
        Dim strSql As String = ""
        Dim i As Integer = 0
        dtpFrom.Checked = True : dtpTo.Checked = True
        dgDocList.ClearSelection()
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

        'Bind Doctor
        strSql = "SELECT code,ISNULL(prefixname,'ไม่ระบุ')As prefixname FROM mdr_careprovidor ORDER BY prefixname"
        myDa = New SqlDataAdapter(strSql, myConnMDR)
        myDa.Fill(ds, "dsDoctor")
        Dim drDoctor As DataRow = ds.Tables("dsDoctor").NewRow
        drDoctor(0) = "0" : drDoctor(1) = "-- All --"
        ds.Tables("dsDoctor").Rows.InsertAt(drDoctor, 0)
        If ds.Tables("dsDoctor").Rows.Count <> 0 Then
            ddlDoctor.DataSource = ds.Tables("dsDoctor")
            ddlDoctor.ValueMember = "code"
            ddlDoctor.DisplayMember = "prefixname"
        End If
    End Sub

    Private Sub btSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSearch.Click
        If Not ds.Tables("dsDocList") Is Nothing Then
            ds.Tables("dsDocList").Clear()
        End If

        strSearch = ""
        Dim checkSearch As Boolean = False

        If txtHN.Text.Trim <> "" Then
            checkSearch = True
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "CF.hn like '%" & txtHN.Text.Trim & "%' "
        End If
        If txtEpisode.Text.Trim <> "" Then
            checkSearch = True
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "CF.episode like '%" & txtEpisode.Text.Trim & "%' "
        End If
        If dtpPFrom.Checked = True And dtpPTo.Checked = True Then 'เลือกช่วงวัน
            'Between
            checkSearch = True
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "(AP.dtprint BETWEEN '" & dtpPFrom.Value.Date.ToString("yyyy-dd-MM") & " " & dtpTPrint_f.Value.Hour & ":" & dtpTPrint_f.Value.Minute & "' AND '" & dtpPTo.Value.Date.ToString("yyyy-dd-MM") & " " & dtpTPrint_t.Value.Hour & ":" & dtpTPrint_t.Value.Minute & "') "
        ElseIf dtpPFrom.Checked = True And dtpPTo.Checked = False Then 'เลือกวันเริ่มต้น
            'DT >= ...
            checkSearch = True
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "AP.dtprint >= '" & dtpPFrom.Value.Date.ToString("yyyy-dd-MM") & " " & dtpTPrint_f.Value.Hour & ":" & dtpTPrint_f.Value.Minute & "' "
        ElseIf dtpPFrom.Checked = False And dtpPTo.Checked = True Then 'เลือกวันสิ้นสุด
            'DT <= ...
            checkSearch = True
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "AP.dtprint <='" & dtpPTo.Value.Date.ToString("yyyy-dd-MM") & " " & dtpTPrint_t.Value.Hour & ":" & dtpTPrint_t.Value.Minute & "' "
        End If
        If dtpFrom.Checked = True And dtpTo.Checked = True Then 'เลือกช่วงวัน
            'Between
            checkSearch = True
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "(CF.scannow BETWEEN '" & dtpFrom.Value.Date.ToString("yyyy-dd-MM") & " " & dtpTScan_f.Value.Hour & ":" & dtpTScan_f.Value.Minute & "' AND '" & dtpTo.Value.Date.ToString("yyyy-dd-MM") & " " & dtpTScan_t.Value.Hour & ":" & dtpTScan_t.Value.Minute & "') "
        ElseIf dtpFrom.Checked = True And dtpTo.Checked = False Then 'เลือกวันเริ่มต้น
            'DT >= ...
            checkSearch = True
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "CF.scannow >= '" & dtpFrom.Value.Date.ToString("yyyy-dd-MM") & " " & dtpTScan_f.Value.Hour & ":" & dtpTScan_f.Value.Minute & "' "
        ElseIf dtpFrom.Checked = False And dtpTo.Checked = True Then 'เลือกวันสิ้นสุด
            'DT <= ...
            checkSearch = True
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "CF.scannow <='" & dtpTo.Value.Date.ToString("yyyy-dd-MM") & " " & dtpTScan_t.Value.Hour & ":" & dtpTScan_t.Value.Minute & "' "
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
        If txtFName.Text.Trim <> "" Then
            checkSearch = True
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "fname like '%" & txtFName.Text.Trim & "%' "
        End If
        If txtLName.Text.Trim <> "" Then
            checkSearch = True
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "lname like '%" & txtLName.Text.Trim & "%' "
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
        If ddlDoctor.SelectedIndex > 0 Then
            checkSearch = True
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "CF.doctorcode='" & ddlDoctor.SelectedValue & "' "
        End If
        If checkSearch = False Then 'กรณีไม่ได้กรอกข้อมูลสำหรับค้นหา ให้ลบค่าใน strSearch ทิ้ง
            MsgBox("คุณจำเป็นต้องเลือกตัวเลือกในการค้นหา ไม่เช่นนั้นอาจใช้เวลานานในการแสดงผล", MsgBoxStyle.ApplicationModal)
            strSearch = ""
            Exit Sub
        End If
        dgDocList.Visible = True
        BindData()
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

    Private Sub dgDocList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDocList.CellContentClick
        If dgDocList.CurrentCellAddress.X < 3 And dgDocList.CurrentCellAddress.X > 0 Then 'ถ้าเป็นการคลิกที่ 2 Columns แรก (กดปุ่ม Print , Preview)
            Select Case dgDocList.CurrentCellAddress.X
                Case "0" 'Choose
                    'MsgBox(dgDocList.CurrentRow.Cells("Choose").Value)
                Case "1" 'Print
                    If BindPicture(dgDocList.CurrentRow.Cells("hn").Value, dgDocList.CurrentRow.Cells("episode").Value, dgDocList.CurrentRow.Cells("no").Value) = True Then
                        Dim ret As Windows.Forms.DialogResult
                        ret = PrintDialog1.ShowDialog()
                        If ret = Windows.Forms.DialogResult.OK Then
                            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
                            PrintDocument1.Print()
                        End If
                    End If
                Case "2" 'Preview
                    hn = dgDocList.CurrentRow.Cells("hn").Value
                    episode = dgDocList.CurrentRow.Cells("episode").Value
                    no = dgDocList.CurrentRow.Cells("no").Value
                    dlPreview.Show()
            End Select
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim siza As System.Drawing.Size
        Dim Rctb As System.Drawing.Rectangle
        Dim factorW As Single
        Dim factorH As Single
        Dim factor As Single
        factorW = PrintDialog1.PrinterSettings.DefaultPageSettings.PrintableArea.Width / picPrint.Size.Width
        factorH = PrintDialog1.PrinterSettings.DefaultPageSettings.PrintableArea.Height / picPrint.Size.Height
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

    Function BindPicture(ByVal hn As String, ByVal episode As String, ByVal no As Integer) As Boolean
        Dim myCmd As New SqlCommand("SELECT ISNULL(mdrpic,'')As mdrpic FROM mdr_cardfiles WHERE hn='" & hn & "' AND episode='" & episode & "' AND itemno=" & no, myConnMDR)
        myConnMDR.Open()
        Dim imagedata() As Byte = CType(myCmd.ExecuteScalar(), Byte())
        If (Not imagedata Is Nothing) Then
            Dim ms As New IO.MemoryStream(imagedata)
            Dim img As Image = Image.FromStream(ms)
            myConnMDR.Close()
            picPrint = img
            Return True
        Else
            myConnMDR.Close()
            MessageBox.Show("ไม่พบข้อมูลไฟล์ที่สแกนในระบบ")
            Return False
        End If
    End Function

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
    End Sub

    Private Sub ddlLocation_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlLocation.SelectedIndexChanged
        Dim strSql As String = "SELECT code,ISNull(prefixname,'ไม่ระบุ')As prefixname FROM mdr_careprovidor "
        If ddlLocation.SelectedIndex <> 0 Then
            strSql &= "WHERE drlocation='" & ddlLocation.SelectedValue & "' "
        End If
        strSql &= "ORDER BY prefixname"
        Dim myDa As New SqlDataAdapter(strSql, myConnMDR)
        Dim ds As New DataSet
        myDa.Fill(ds, "dsDoctorSearch")
        Dim drDoctor As DataRow = ds.Tables("dsDoctorSearch").NewRow
        drDoctor(0) = "0" : drDoctor(1) = "-- All --"
        ds.Tables("dsDoctorSearch").Rows.InsertAt(drDoctor, 0)
        If ds.Tables("dsDoctorSearch").Rows.Count <> 0 Then
            ddlDoctor.DataSource = ds.Tables("dsDoctorSearch")
            ddlDoctor.ValueMember = "code"
            ddlDoctor.DisplayMember = "prefixname"
        End If
        ddlDoctor.Focus()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        frmLogin.Close()
        'Form1.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    Public ds As New DataSet()

    Sub BindData()
        'Bind DocList
        Dim strSql As String = "SELECT CF.hn As HN," & _
             "CF.episode As Episode," & _
             "CF.itemno AS No," & _
             "(PT.pname+' '+PT.fname+'  '+PT.lname)As PatientName," & _
             "CP.prefixname As Doctor," & _
             "LO.prefixname As Location," & _
             "DG.prefixname As DocGroup," & _
             "DS.prefixname As DocSubGroup," & _
             "CF.scannow As ScanNow,AP.dtprint AS PrintTime " & _
             "FROM mdr_autoprint_log AS AP WITH(NOLOCK) " & _
             "LEFT JOIN mdr_cardfiles As CF WITH(NOLOCK) ON AP.hn=CF.hn AND AP.episode=CF.episode AND AP.itemno=CF.itemno " & _
             "LEFT JOIN mdr_patient AS PT WITH(NOLOCK) ON CF.hn=PT.hn " & _
             "LEFT JOIN mdr_careprovidor AS CP WITH(NOLOCK) ON CF.doctorcode=CP.code " & _
             "LEFT JOIN mdr_location As LO WITH(NOLOCK) ON CF.locationcode=LO.code " & _
             "INNER JOIN mdr_docgroup As DG WITH(NOLOCK) ON CF.docgrp=DG.code " & _
             "INNER JOIN mdr_docsubgroup As DS WITH(NOLOCK) ON CF.docgrp=DS.code AND CF.docsubgrp=DS.subcode "
        strSql &= strSearch
        strSql &= "ORDER BY dtprint DESC"
        'txtHN.Text = strSql : Exit Sub
        Dim myDa As New SqlDataAdapter(strSql, myConnMDR)
        Dim ds As New DataSet()
        myDa.Fill(ds, "dsDocList")
        dgDocList.DataSource = ds.Tables("dsDocList")
        dgDocList.Refresh()
    End Sub

    Private Sub AutoPrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoPrintToolStripMenuItem.Click
        Me.Hide()
        frmAuto.Show()
    End Sub

    Private Sub btPrintSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrintSelected.Click
        Dim chkSelect As Boolean = False
        retSelect = PrintDialog1.ShowDialog()
        If retSelect = Windows.Forms.DialogResult.OK Then
            Dim i As Integer = 0
            For i = 0 To dgDocList.Rows.Count - 1
                'PrintSelected()
                If dgDocList.Rows(i).Cells(0).Value = "1" Then
                    chkSelect = True
                    PrintSelected(dgDocList.Rows(i).Cells("hn").Value, dgDocList.Rows(i).Cells("episode").Value, dgDocList.Rows(i).Cells("no").Value)
                End If
            Next
            If chkSelect = False Then
                MsgBox("คุณยังไม่ได้เลือกข้อมูลที่ต้องการปริ้น")
            Else
                MsgBox("ปริ้นข้อมูลที่เลือกแล้ว")
            End If
        End If
    End Sub

    Function PrintSelected(ByVal hn As String, ByVal episode As String, ByVal no As Integer) As Boolean
        Dim strSql As String = ""

        'ตรวจสอบรูปว่ามีหรือไม่
        Dim myCmd As New SqlCommand("SELECT ISNULL(mdrpic,'')As mdrpic FROM mdr_cardfiles WHERE hn='" & hn & "' AND episode='" & episode & "' AND itemno=" & no, myConnMDR)
        myConnMDR.Open()
        If myCmd.ExecuteScalar.ToString <> "" Then
            Dim imagedata() As Byte = CType(myCmd.ExecuteScalar(), Byte())
            If (Not imagedata Is Nothing) Then
                Try
                    Dim ms As New IO.MemoryStream(imagedata)
                    Dim img As Image = Image.FromStream(ms)
                    myConnMDR.Close()
                    picPrint = Nothing
                    picPrint = img

                    'ปริ้นเอกสาร
                    PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
                    PrintDocument1.Print()
                    System.Threading.Thread.Sleep(1000) 'หน่วงเวลา 1 วินาที
                    Return True
                Catch ex As Exception
                    'อัพเดทการปริ้น
                    'SQLExecuteMDR("INSERT INTO mdr_autoprint_log(hn,episode,itemno,usern,hostname,ipaddress,dtprint) VALUES('" & hn & "','" & episode & "'," & no & ",'" & frmLogin.txtUsern.Text.Trim & "','" & hostname & "','" & ip & "','" & Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "')")
                    Return False
                End Try
            Else
                myConnMDR.Close()
                Return False
            End If
        End If
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

    Private Sub btClearSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClearSelected.Click
        Dim i As Integer = 0
        For i = 0 To dgDocList.Rows.Count - 1
            'PrintSelected()
            If dgDocList.Rows(i).Cells(0).Value = "1" Then
                dgDocList.Rows(i).Cells(0).Value = "0"
            End If
        Next
    End Sub

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

    Private Sub SetupToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetupToolStripMenuItem1.Click
        'Me.Hide()
        frmDocumentSet.ShowDialog()
    End Sub

    Private Sub btDocumentSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDocumentSet.Click
        'Me.Hide()
        frmDocumentSetChoose.ShowDialog()
        frmDocumentSetChoose.dgDocumentSet.ClearSelection()
    End Sub

    Private Sub DocumentSetChooseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentSetChooseToolStripMenuItem.Click
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

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub
End Class