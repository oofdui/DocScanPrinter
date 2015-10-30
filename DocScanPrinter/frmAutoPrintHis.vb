Imports System.Data
Imports System.Data.SqlClient

Public Class frmAutoPrintHis
    Public strSearch As String
    Dim myConnCenter As New SqlConnection(System.Configuration.ConfigurationManager.AppSettings("csCenter"))
    Dim myConnMDR As New SqlConnection(System.Configuration.ConfigurationManager.AppSettings("csMDR"))

    Private Sub frmAutoPrintHis_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        dtpPFrom.Checked = True : dtpPTo.Checked = True
        'dtpPFrom.Value = Now.Date : dtpPTo.Value = Now.Date
        dtpSFrom.Checked = False : dtpSTo.Checked = False
        'CheckForIllegalCrossThreadCalls = False
        pnLoading.Visible = False

        strSearch = "WHERE dtprint BETWEEN '" & dtpPFrom.Value.Date & "  00:00:00' AND '" & dtpPTo.Value.Date & "  23:59:59' "
        BindSearch()
    End Sub

    Private Sub btSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSearch.Click
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        strSearch = ""

        If txtHN.Text.Trim <> "" Then
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "hn like '%" & txtHN.Text.Trim & "%' "
        End If
        If txtEpisode.Text.Trim <> "" Then
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "episode like '%" & txtEpisode.Text.Trim & "%' "
        End If
        If dtpSFrom.Checked = True And dtpSTo.Checked = True Then 'เลือกช่วงวัน
            'Between
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "(scannow BETWEEN '" & dtpSFrom.Value.Date & "  00:00:00' AND '" & dtpSTo.Value.Date & "  23:59:59') "
        ElseIf dtpSFrom.Checked = True And dtpSTo.Checked = False Then 'เลือกวันเริ่มต้น
            'DT >= ...
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "scannow >= '" & dtpSFrom.Value.Date & " 00:00:00' "
        ElseIf dtpSFrom.Checked = False And dtpSTo.Checked = True Then 'เลือกวันสิ้นสุด
            'DT <= ...
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "scannow <='" & dtpSTo.Value.Date & " 23:59:59' "
        End If
        If dtpPFrom.Checked = True And dtpPTo.Checked = True Then 'เลือกช่วงวัน
            'Between
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "(dtprint BETWEEN '" & dtpPFrom.Value.Date & "  00:00:00' AND '" & dtpPTo.Value.Date & "  23:59:59') "
        ElseIf dtpPFrom.Checked = True And dtpPTo.Checked = False Then 'เลือกวันเริ่มต้น
            'DT >= ...
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "dtprint >= '" & dtpPFrom.Value.Date & " 00:00:00' "
        ElseIf dtpPFrom.Checked = False And dtpPTo.Checked = True Then 'เลือกวันสิ้นสุด
            'DT <= ...
            If InStr(strSearch, "WHERE") <> 0 Then
                strSearch &= "AND "
            Else
                strSearch &= "WHERE "
            End If
            strSearch &= "dtprint <='" & dtpPTo.Value.Date & " 23:59:59' "
        End If
        'txtHN.Text = strSearch
        BindSearch()
    End Sub

    Private Sub BindSearch()
        'pnLoading.Visible = True
        Dim strSql As String = "SELECT * FROM mdr_autoprint_log " & strSearch
        strSql &= "ORDER BY dtprint DESC"


        Dim myDa As New SqlDataAdapter(strSql, myConnMDR)
        Dim ds As New DataSet
        myDa.Fill(ds, "dsHistory")
        If ds.Tables("dsHistory").Rows.Count <> 0 Then
            dgHistory.DataSource = ds.Tables("dsHistory")
            dgHistory.Refresh()
            lblMessage.Text = ""
            dgHistory.Visible = True
        Else
            lblMessage.Text = "ไม่พบข้อมูลที่ต้องการ"
            dgHistory.Visible = False
        End If
    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
    End Sub
End Class