Imports System.Data
Imports System.Data.SqlClient

Public Class frmDocumentSetChoose
    Dim myConnCenter As New SqlConnection(System.Configuration.ConfigurationManager.AppSettings("csCenter"))
    Dim myConnMDR As New SqlConnection(System.Configuration.ConfigurationManager.AppSettings("csMDR"))

    Private Sub frmDocumentSetChoose_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Close()
    End Sub

    Private Sub frmDocumentSet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BindDocumentSet()
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

    Private Sub dgDocumentSet_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDocumentSet.CellContentClick
        If frmAuto.Visible = True Then
            If frmAutoPrintLog.Visible = True Then
                frmAutoPrintLog.lbGroup.Items.Clear()
                frmAutoPrintLog.lbLocation.Items.Clear()
            Else
                frmAuto.lbGroup.Items.Clear()
                frmAuto.lbLocation.Items.Clear()
            End If
        ElseIf frmDefault.Visible = True Then
            frmDefault.lbGroup.Items.Clear()
            frmDefault.lbLocation.Items.Clear()
        End If

            Dim id As Integer = dgDocumentSet.CurrentRow.Cells("ID").Value
            If dgDocumentSet.CurrentCellAddress.X = 0 Then 'เลือกเซ็ทกลุ่มเอกสาร
                Dim strSql As String = "SELECT id,ISNULL(group_code,'')As group_code,ISNULL(subgroup_code,'')As subgroup_code,ISNULL(location_code,'')As location_code FROM mdr_autoprint_groupset WHERE id=" & id
                Dim myDa As New SqlDataAdapter(strSql, myConnMDR)
                Dim ds As New DataSet()
                myDa.Fill(ds, "dsGroupSet")
                If ds.Tables("dsGroupSet").Rows.Count <> 0 Then
                    Dim listDetail As String = ""
                    Dim i As Integer = 0
                    For i = 0 To ds.Tables("dsGroupSet").Rows.Count - 1
                        With ds.Tables("dsGroupSet").Rows(i)
                            If .Item("group_code").ToString.Trim <> "" And .Item("subgroup_code").ToString.Trim <> "" Then
                                listDetail = .Item("group_code") & ":" & _
                                    SQLReturnMDR("SELECT suffixname FROM mdr_docgroup WHERE code='" & .Item("group_code") & "'") & _
                                    " , " & .Item("subgroup_code") & ":" & _
                                    SQLReturnMDR("SELECT suffixname FROM mdr_docsubgroup WHERE code='" & .Item("group_code") & "' AND subcode='" & .Item("subgroup_code") & "'")

                            If frmAuto.Visible = True Then
                                If frmAutoPrintLog.Visible = True Then
                                    frmAutoPrintLog.lbGroup.Items.Insert(0, listDetail)
                                    frmAutoPrintLog.btGroupRemove.Enabled = True
                                Else
                                    frmAuto.lbGroup.Items.Insert(0, listDetail)
                                    frmAuto.btGroupRemove.Enabled = True
                                End If
                            ElseIf frmDefault.Visible = True Then
                                frmDefault.lbGroup.Items.Insert(0, listDetail)
                                frmDefault.btGroupRemove.Enabled = True
                            End If

                                listDetail = ""
                            End If
                            If .Item("group_code").ToString.Trim <> "" And .Item("subgroup_code").ToString.Trim = "" Then
                                listDetail = .Item("group_code") & ":" & _
                                    SQLReturnMDR("SELECT suffixname FROM mdr_docgroup WHERE code='" & .Item("group_code") & "'") & _
                                    " , " & "ALL"

                            If frmAuto.Visible = True Then
                                If frmAutoPrintLog.Visible = True Then
                                    frmAutoPrintLog.lbGroup.Items.Insert(0, listDetail)
                                    frmAutoPrintLog.btGroupRemove.Enabled = True
                                Else
                                    frmAuto.lbGroup.Items.Insert(0, listDetail)
                                    frmAuto.btGroupRemove.Enabled = True
                                End If
                            ElseIf frmDefault.Visible = True Then
                                frmDefault.lbGroup.Items.Insert(0, listDetail)
                                frmDefault.btGroupRemove.Enabled = True
                            End If

                            listDetail = ""
                        End If
                        If .Item("location_code").ToString.Trim <> "" Then
                            If .Item("location_code").ToString.Trim = "ALL" Then
                                listDetail = "ALL"
                            Else
                                listDetail = .Item("location_code") & " : " & _
                                SQLReturnMDR("SELECT suffixname FROM mdr_location WHERE code='" & .Item("location_code") & "'")
                            End If

                            If frmAuto.Visible = True Then
                                If frmAutoPrintLog.Visible = True Then
                                    frmAutoPrintLog.lbLocation.Items.Insert(0, listDetail)
                                    frmAutoPrintLog.btLocationRemove.Enabled = True
                                Else
                                    frmAuto.lbLocation.Items.Insert(0, listDetail)
                                    frmAuto.btLocationRemove.Enabled = True
                                End If
                            ElseIf frmDefault.Visible = True Then
                                frmDefault.lbLocation.Items.Insert(0, listDetail)
                                frmDefault.btLocationRemove.Enabled = True
                            End If

                            listDetail = ""
                        End If
                    End With
                    Next
                End If
                Me.Close()
                'frmDefault.Show()
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
End Class