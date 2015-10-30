Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Deployment.Application

Public Class frmLogin
    Dim myConnCenter As New SqlConnection(System.Configuration.ConfigurationManager.AppSettings("csCenter"))
    Dim myConnMDR As New SqlConnection(System.Configuration.ConfigurationManager.AppSettings("csMDR"))
    Public lastApp As String = "DocScanPrinter"

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Dim lngFlags As Long
        Dim clsGlobal As New clsGlobal()
        Me.Name = clsGlobal.ApplicationName & " v." & clsGlobal.ApplicationVersion

        If InternetGetConnectedState(lngFlags, 0) Then 'เช็คว่าเครื่องนี้ต่อเข้าเน็ตเวิร์คหรือปล่าว
            If My.Computer.Network.Ping(System.Configuration.ConfigurationManager.AppSettings("ipMDR")) And _
                My.Computer.Network.Ping(System.Configuration.ConfigurationManager.AppSettings("ipCenter")) Then
                lblStatus.ForeColor = Color.LightSeaGreen
                lblStatus.Text = "Connected"

                Me.AcceptButton = btLogin
                Me.CancelButton = btClose
                btLogin.Enabled = True
                btClose.Enabled = True
            Else
                lblStatus.ForeColor = Color.Red
                lblStatus.Text = "Can't connect to server."
                btLogin.Enabled = False
                btClose.Enabled = True
            End If
        Else
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Disconnected"
            btLogin.Enabled = False
            btClose.Enabled = True
        End If
    End Sub

    Private Declare Function InternetGetConnectedState Lib "wininet.dll" ( _
        ByRef lpdwFlags As Int32, _
        ByVal dwReserved As Int32) As Boolean
    Private Enum Flags As Integer
        'Local system uses a LAN to connect to the Internet.
        INTERNET_CONNECTION_LAN = &H2
        'Local system uses a modem to connect to the Internet.
        INTERNET_CONNECTION_MODEM = &H1
        'Local system uses a proxy server to connect to the Internet.
        INTERNET_CONNECTION_PROXY = &H4
        'Local system has RAS installed.
        INTERNET_RAS_INSTALLED = &H10
    End Enum

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
    End Sub

    Private Sub btLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLogin.Click
        Login()
    End Sub

    Private Sub txtUsern_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsern.GotFocus
        txtUsern.ForeColor = Color.Black
        txtPwd.Enabled = True
        btLogin.Enabled = True
    End Sub
    Private Sub Login()
        If txtUsern.Text.Trim <> "" And txtPwd.Text.Trim <> "" Then
            Dim strSql As String = "SELECT COUNT(st_id) FROM STAFF WHERE st_usern='" & txtUsern.Text.Trim & "' AND st_pwd='" & txtPwd.Text.Trim & "'"
            If Val(SQLReturnCenter(strSql)) > 0 Then
                'อัพเดทสถานะผู้ล็อคอิน
                lblStaffStatus.Text = SQLReturnCenter("SELECT ISNULL(st_status,'')As st_status FROM STAFF WHERE st_usern='" & txtUsern.Text.Trim & "'")

                'WSCenter
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
                Try
                    If System.Configuration.ConfigurationManager.AppSettings("UsageLogEnable").ToLower() = "true" Then
                        Dim WSCenter As New WSCenter.ServiceSoapClient
                        Dim clsGlobal As New clsGlobal()
                        WSCenter.InsertLogApplicationBySite(clsGlobal.ApplicationName, clsGlobal.Department, clsGlobal.Site, txtUsern.Text.Trim(), ip, hostName)
                    End If
                Catch ex As Exception
                    MessageBox.Show("เกิดข้อผิดพลาดขณะบันทึก Log", "Login_Click(UsageLog)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                Me.Hide()
                If cbAutoPrint.Checked = True Then
                    frmAuto.Show()
                Else
                    frmDefault.Show()
                End If

            Else
                txtPwd.Clear()
                txtPwd.Focus()
                MsgBox("ไม่พบรหัสที่คุณกรอก")
            End If
        End If
    End Sub
    Private Sub txtUsern_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsern.LostFocus
        'Dim strSql As String = "SELECT COUNT(st_id) FROM STAFF WHERE st_usern='" & txtUsern.Text.Trim & "'"
        'If Val(SQLReturnCenter(strSql)) = 0 Then
        '    txtUsern.ForeColor = Color.Red
        '    txtPwd.Enabled = False
        '    btLogin.Enabled = False
        'Else
        '    txtUsern.ForeColor = Color.Black
        '    txtPwd.Enabled = True
        '    btLogin.Enabled = True
        'End If
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

    Function StaffProfileUpdate() As Boolean
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

        Try
            Dim strSql As String = "UPDATE STAFF SET " & _
                "st_lastlogin='" & Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & "'," & _
                "st_lastapp='" & lastApp & "'," & _
                "st_lastip='" & ip & "'," & _
                "st_lastcomname='" & hostName & "' " & _
                "WHERE st_usern='" & txtUsern.Text.Trim & "'"
            Dim myCmd As New SqlCommand(strSql, myConnCenter)
            myConnCenter.Open()
            myCmd.ExecuteNonQuery()
            myConnCenter.Close()
            myCmd.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub txtPwd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPwd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub
End Class
