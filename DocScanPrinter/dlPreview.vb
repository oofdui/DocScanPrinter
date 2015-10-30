Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class dlPreview
    Dim myConnMDR As New SqlConnection(System.Configuration.ConfigurationManager.AppSettings("csMDR"))
    Public picPrint As Image

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmDefault.Visible = True Then
            BindPicture(frmDefault.hn, frmDefault.episode, frmDefault.no)
        ElseIf frmAutoPrintLog.Visible = True Then
            BindPicture(frmAutoPrintLog.hn, frmAutoPrintLog.episode, frmAutoPrintLog.no)
        End If
    End Sub

    Function BindPicture(ByVal hn As String, ByVal episode As String, ByVal no As Integer) As Boolean
        Dim myCmd As New SqlCommand("SELECT ISNULL(mdrpic,'')As mdrpic FROM mdr_cardfiles WHERE hn='" & hn & "' AND episode='" & episode & "' AND itemno=" & no, myConnMDR)
        myConnMDR.Open()
        Dim imagedata() As Byte = CType(myCmd.ExecuteScalar(), Byte())
        If (Not imagedata Is Nothing) Then
            Dim ms As New IO.MemoryStream(imagedata)
            picPrint = Image.FromStream(ms)
            myConnMDR.Close()

            Dim clsGlobal As New clsGlobal()
            Dim priorityName As String = ""
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
                imageDrawerText &= PrintTime(hn, episode, no)
            End If
            ImageDrawer(picPrint, imageDrawerText)

            picPreview.Image = picPrint
            Return True
        Else
            myConnMDR.Close()
            MessageBox.Show("ไม่พบข้อมูลไฟล์ที่สแกนในระบบ")
            Return Nothing
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
        strSQL.Append("mdr_pharmacyremarks A WITH(NOLOCK) ")
        strSQL.Append("INNER JOIN mdr_cardfiles B WITH(NOLOCK) ON A.hn=B.hn AND A.episode=B.episode AND A.itemno=B.itemno ")
        strSQL.Append("INNER JOIN mdr_syspharmacypriority E WITH(NOLOCK) ON A.ordertype=E.code AND E.isactive='1' ")

        strSQL.Append("WHERE ")
        strSQL.Append("B.scannow>=CONVERT(DATE,GETDATE()) ")
        strSQL.Append("AND E.prefixname='" & PriorityName & "' ")
        strSQL.Append(") TB ")
        strSQL.Append("WHERE hn='" & HN.Replace("-", "") & "' AND episode='" & Episode.Replace("-", "") & "' AND itemno=" & ItemNo & ";")
        result = SQLReturnMDR(strSQL.ToString())

        Return result
    End Function
    Private Function PrintTime(HN As String, Episode As String, ItemNo As String)
        Dim strSQL As New System.Text.StringBuilder()
        Dim result As String = ""
        strSQL.Append("SELECT ")
        strSQL.Append("dtprint ")
        strSQL.Append("FROM ")
        strSQL.Append("mdr_autoprint_log WITH(NOLOCK) ")
        strSQL.Append("WHERE ")
        strSQL.Append("hn='" & HN & "' ")
        strSQL.Append("AND episode='" & Episode & "' ")
        strSQL.Append("AND itemno=" & ItemNo & ";")

        result = SQLReturnMDR(strSQL.ToString())
        Return result
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
    Private Structure Selection
        Public Top As Integer
        Public Left As Integer
        Public Height As Integer
        Public Width As Integer
    End Structure
    Private wEdge As Boolean
    Private eEdge As Boolean
    Private nEdge As Boolean
    Private sEdge As Boolean
    Private Sizing As Boolean
    Private Const EdgeSize As Integer = 6
    Private StartCord As Drawing.Point
    Private OldCord As Drawing.Point
    Private newCord As Drawing.Point
    Private Rect As Selection
    Private MovePic As Boolean
    Private MoveMain As Boolean
    Private SizePic As Boolean

    Private Sub picPreview_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picPreview.MouseDown
        'MsgBox("คลิกแล้ว")
        ' Click on Sizable Image Region - NB. Child picturebox

        If e.Button = Windows.Forms.MouseButtons.Left Then
            OldCord = e.Location
            StartCord = e.Location
            If Sizing Then
                SizePic = True
            Else
                MovePic = True
            End If
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
            MoveMain = True
            StartCord = e.Location
        End If
    End Sub

    Private Sub picPreview_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picPreview.MouseMove
        picPreview.Select()  'probably deselect in leave

        ' Mouse move inside Image Region... - NB. Child Picturebox
        If e.Button = Windows.Forms.MouseButtons.None Then
            If e.Location.X < EdgeSize And e.Location.X > 0 Then
                wEdge = True
            Else
                wEdge = False
            End If
            If e.Location.X > picPreview.Size.Width - EdgeSize And e.Location.X < picPreview.Size.Width Then
                eEdge = True
            Else
                eEdge = False
            End If
            If e.Location.Y < EdgeSize And e.Location.Y > 0 Then
                nEdge = True
            Else
                nEdge = False
            End If
            If e.Location.Y > picPreview.Size.Height - EdgeSize And e.Location.Y < picPreview.Size.Height Then
                sEdge = True
            Else
                sEdge = False
            End If
            Sizing = True
        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
            If MovePic Then
                picPreview.Top = picPreview.Top + (e.Location.Y - StartCord.Y)
                picPreview.Left = picPreview.Left + (e.Location.X - StartCord.X)
            End If
            ' The code following works when used with a child Picturebox...
            ' NB. Alternate code will apply if working on a rect region selection.....
            If SizePic Then
                Rect.Top = picPreview.Top
                Rect.Height = picPreview.Height
                Rect.Left = picPreview.Left
                Rect.Width = picPreview.Width
                If eEdge Then
                    Rect.Width = e.Location.X
                End If
                If sEdge Then
                    Rect.Height = e.Location.Y
                End If
                If wEdge Then
                    Rect.Left = Rect.Left - (StartCord.X - e.Location.X)
                    Rect.Width = Rect.Width + (StartCord.X - e.Location.X)
                End If
                If nEdge Then
                    Rect.Top = Rect.Top - (StartCord.Y - e.Location.Y)
                    Rect.Height = Rect.Height + (StartCord.Y - e.Location.Y)
                End If
                If Rect.Height < 0 Then
                    Rect.Top = Rect.Top + Rect.Height
                    Rect.Height = Math.Abs(Rect.Height)
                    nEdge = Not nEdge
                    sEdge = Not sEdge
                    StartCord.Y = 0
                End If
                If Rect.Width < 0 Then
                    Rect.Left = Rect.Left + Rect.Width
                    Rect.Width = Math.Abs(Rect.Width)
                    eEdge = Not eEdge
                    wEdge = Not wEdge
                    StartCord.X = 0
                End If
                picPreview.Top = Rect.Top
                picPreview.Height = Rect.Height
                picPreview.Left = Rect.Left
                picPreview.Width = Rect.Width
            End If
        End If

        If (nEdge Or sEdge) And Not (wEdge Or eEdge) Then
            picPreview.Cursor = Cursors.Hand
        ElseIf (wEdge Or eEdge) And Not (nEdge Or sEdge) Then
            picPreview.Cursor = Cursors.Hand
        ElseIf (nEdge And eEdge) Or (sEdge And wEdge) Then
            picPreview.Cursor = Cursors.Hand
        ElseIf (nEdge And wEdge) Or (sEdge And eEdge) Then
            picPreview.Cursor = Cursors.Hand
        Else
            picPreview.Cursor = Cursors.Hand
            Sizing = False
        End If
    End Sub

    Private Sub picPreview_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picPreview.MouseWheel
        If e.Delta <> 0 Then
            If e.Delta <= 0 Then
                If picPreview.Width < 550 Then Exit Sub 'minimum 550?
            Else
                If picPreview.Width > 2000 Then Exit Sub 'maximum 2000?
            End If
            picPreview.Width += CInt(picPreview.Width * e.Delta / 1000)
            picPreview.Height += CInt(picPreview.Height * e.Delta / 1000)
        End If
    End Sub

    Private Sub btRotate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRotateRight.Click
        picPreview.Image.RotateFlip(RotateFlipType.Rotate270FlipXY)
        picPreview.Refresh()
    End Sub

    Private Sub btRotateLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRotateLeft.Click
        picPreview.Image.RotateFlip(RotateFlipType.Rotate90FlipXY)
        picPreview.Refresh()
    End Sub

    Private Sub btPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrint.Click
        Dim ret As Windows.Forms.DialogResult
        ret = PrintDialog1.ShowDialog()
        If ret = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
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
End Class
