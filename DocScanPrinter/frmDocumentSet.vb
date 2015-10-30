Imports System.Data
Imports System.Data.SqlClient

Public Class frmDocumentSet
    Dim myConnCenter As New SqlConnection(System.Configuration.ConfigurationManager.AppSettings("csCenter"))
    Dim myConnMDR As New SqlConnection(System.Configuration.ConfigurationManager.AppSettings("csMDR"))

    Private Sub frmDocumentSet_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Close()
        'frmDefault.Show()
    End Sub

    Private Sub frmDocumentSet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If frmLogin.lblStaffStatus.Text = "admin" Then
            BindDocSearch()
            BindDocumentSet()
        End If
    End Sub

    Sub BindDocumentSet()
        Dim strSql As String = "SELECT DISTINCT id AS ID,name AS Name,detail AS Detail " & _
            "FROM mdr_autoprint_groupset AS GS " & _
            "ORDER BY id DESC"
        Dim myDa As New SqlDataAdapter(strSql, myConnMDR)
        Dim ds As New DataSet()
        myDa.Fill(ds, "dsDocumentSet")
        If ds.Tables("dsDocumentSet").Rows.Count > 0 Then
            dgDocumentSet.Visible = True
            dgDocumentSet.DataSource = ds.Tables("dsDocumentSet")
            lblDocumentSet.Visible = False
            dgDocumentSet.ClearSelection()
        Else
            dgDocumentSet.Visible = False
            lblDocumentSet.Visible = True
        End If
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

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
        'frmDefault.Show()
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

    Private Sub btUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUpdate.Click
        Dim name As String = ""
        Dim id As Integer = 1
        Dim runid As Integer = 1
        Dim strSql As String = ""

        If lblID.Text <> "" Then
            SQLExecuteMDR("DELETE FROM mdr_autoprint_groupset WHERE id=" & lblID.Text.Trim)
        End If

        If txtName.Text.Trim.Replace("'", "''") <> "" And (lbGroup.Items.Count > 0 Or lbLocation.Items.Count > 0) Then
            'กำหนดตัวแปรหลัก
            name = txtName.Text.Trim.Replace("'", "''")
            If Val(SQLReturnMDR("SELECT COUNT(id) FROM mdr_autoprint_groupset")) > 0 Then
                If lblID.Text.Trim <> "" Then
                    id = lblID.Text.Trim
                    lblID.Text = ""
                Else
                    id = Val(SQLReturnMDR("SELECT MAX(id) FROM mdr_autoprint_groupset")) + 1
                End If
                runid = Val(SQLReturnMDR("SELECT MAX(runid) FROM mdr_autoprint_groupset WHERE id=" & id)) + 1
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

                        strSql = "INSERT INTO mdr_autoprint_groupset(id,runid,name,detail,group_code,subgroup_code) " & _
                            "VALUES(" & _
                            id & "," & _
                            runid & ",'" & _
                            txtName.Text.Trim.Replace("'", "''") & "','" & _
                            txtDetail.Text.Trim.Replace("'", "''") & "','" & _
                            docGroup & "','" & _
                            docSubGroup & "')"
                        runid = runid + 1
                        SQLExecuteMDR(strSql)
                    ElseIf docGroup <> "ALL" And docSubGroup = "ALL" Then
                        docGroupSplit = Nothing
                        docGroupSplit = Split(docGroup, ":")
                        docGroup = docGroupSplit(0).ToString.Trim

                        strSql = "INSERT INTO mdr_autoprint_groupset(id,runid,name,detail,group_code) " & _
                            "VALUES(" & _
                            id & "," & _
                            runid & ",'" & _
                            txtName.Text.Trim.Replace("'", "''") & "','" & _
                            txtDetail.Text.Trim.Replace("'", "''") & "','" & _
                            docGroup & "')"
                        runid = runid + 1
                        SQLExecuteMDR(strSql)
                    End If
                Next
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

                    strSql = "INSERT INTO mdr_autoprint_groupset(id,runid,name,detail,location_code) " & _
                            "VALUES(" & _
                            id & "," & _
                            runid & ",'" & _
                            txtName.Text.Trim.Replace("'", "''") & "','" & _
                            txtDetail.Text.Trim.Replace("'", "''") & "','" & _
                            location & "')"
                    runid = runid + 1
                    SQLExecuteMDR(strSql)
                Next
            End If

            dgDocumentSet.ClearSelection()
            lbGroup.Items.Clear()
            lbLocation.Items.Clear()
            txtName.Text = ""
            lblID.Text = ""
            If ddlDocGroup.Items.Count > 0 Then
                ddlDocGroup.SelectedIndex = 0
            End If
            If ddlDocSubGroup.Items.Count > 0 Then
                ddlDocSubGroup.SelectedIndex = 0
            End If

            BindDocumentSet()
        Else
            MsgBox("กรุณาตั้งชื่อเซ็ท และ เลือกประเภทเอกสาร หรือ เลือกแผนกที่สแกน ก่อนทำการเซฟข้อมูล")
        End If
    End Sub

    Private Sub dgDocumentSet_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDocumentSet.CellContentClick
        lbGroup.Items.Clear()
        lbLocation.Items.Clear()

        Dim id As Integer = dgDocumentSet.CurrentRow.Cells("ID").Value
        lblID.Text = id
        If dgDocumentSet.CurrentCellAddress.X = 1 Then 'ลบข้อมูลเซ็ท
            'MsgBox("คุณคลิกที่ ID : " & id)
            SQLExecuteMDR("DELETE FROM mdr_autoprint_groupset WHERE id=" & id)
            BindDocumentSet()
        ElseIf dgDocumentSet.CurrentCellAddress.X = 0 Then 'เรียกดู / แก้ไขข้อมูล
            btUpdate.Text = "Update"
            Dim strSql As String = "SELECT id,runid,name,ISNULL(detail,'') As detail,ISNULL(group_code,'')As group_code,ISNULL(subgroup_code,'')As subgroup_code,ISNULL(location_code,'')As location_code FROM mdr_autoprint_groupset WHERE id=" & id
            Dim myDa As New SqlDataAdapter(strSql, myConnMDR)
            Dim ds As New DataSet()
            myDa.Fill(ds, "dsGroupSet")
            If ds.Tables("dsGroupSet").Rows.Count <> 0 Then
                Dim listDetail As String = ""
                Dim i As Integer = 0
                txtName.Text = ds.Tables("dsGroupSet").Rows(0).Item("name")
                txtDetail.Text = ds.Tables("dsGroupSet").Rows(0).Item("detail")
                For i = 0 To ds.Tables("dsGroupSet").Rows.Count - 1
                    With ds.Tables("dsGroupSet").Rows(i)
                        If .Item("group_code").ToString.Trim <> "" And .Item("subgroup_code").ToString.Trim <> "" Then
                            listDetail = .Item("group_code") & ":" & _
                                SQLReturnMDR("SELECT suffixname FROM mdr_docgroup WHERE code='" & .Item("group_code") & "'") & _
                                " , " & .Item("subgroup_code") & ":" & _
                                SQLReturnMDR("SELECT suffixname FROM mdr_docsubgroup WHERE code='" & .Item("group_code") & "' AND subcode='" & .Item("subgroup_code") & "'")
                            lbGroup.Items.Insert(0, listDetail)
                            listDetail = ""
                            btGroupRemove.Enabled = True
                        End If
                        If .Item("group_code").ToString.Trim <> "" And .Item("subgroup_code").ToString.Trim = "" Then
                            listDetail = .Item("group_code") & ":" & _
                                SQLReturnMDR("SELECT suffixname FROM mdr_docgroup WHERE code='" & .Item("group_code") & "'") & _
                                " , " & "ALL"
                            lbGroup.Items.Insert(0, listDetail)
                            listDetail = ""
                            btGroupRemove.Enabled = True
                        End If
                        If .Item("location_code").ToString.Trim <> "" Then
                            If .Item("location_code").ToString.Trim = "ALL" Then
                                listDetail = "ALL"
                            Else
                                listDetail = .Item("location_code") & " : " & _
                                SQLReturnMDR("SELECT suffixname FROM mdr_location WHERE code='" & .Item("location_code") & "'")
                            End If
                            lbLocation.Items.Insert(0, listDetail)
                            listDetail = ""
                            btLocationRemove.Enabled = True
                        End If
                    End With
                Next
            End If
        End If
    End Sub

    Private Sub btClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClear.Click
        btUpdate.Text = "Insert"
        dgDocumentSet.ClearSelection()
        lbGroup.Items.Clear()
        lbLocation.Items.Clear()
        txtName.Text = ""
        txtDetail.Text = ""
        lblID.Text = ""
        If ddlDocGroup.Items.Count > 0 Then
            ddlDocGroup.SelectedIndex = 0
        End If
        If ddlDocSubGroup.Items.Count > 0 Then
            ddlDocSubGroup.SelectedIndex = 0
        End If
    End Sub
End Class