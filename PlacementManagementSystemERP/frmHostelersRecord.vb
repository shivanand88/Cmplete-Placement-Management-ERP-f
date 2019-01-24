Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmHostelersRecord
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\HMS_DB.accdb;Persist Security Info=False;"

    Private Sub cmbProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHostelerName.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],Purpose as [Department],USN,DOB,Gender,Relegion as[Relegion],Caste as [Caste],Subcaste as[Sub caste],Category as [Category],HostelName as [Hostel Name],RoomNo as [Room No],DateOfJoining as [Date Of Joining],Acadyear as [Acadyear],FatherName as [Father's Name],MobNo1 as [Mobile No],Phone1 as [Phone No],MotherName as [Mother's Name],MobNo2 as [Mobile No 2],City,Address,Email,ContactNo as [Contact No],InstOfcDetails as [Ins/Ofc Details],Phone2 as [Phone No 2],Agreement,GuardianName as  [Guardian Name],GuardianAddress as [Guardian Address],MobNo3 as [Guardian Mobile No],Phone3 as [Guardian Phone No],CompletionDate as [Completion Date] from Hostelers where HostelerName='" & cmbHostelerName.Text & "' order by HostelerName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Hostelers")
            DataGridView1.DataSource = myDataSet.Tables("Hostelers").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillHostelerName()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(HostelerName) FROM Hostelers", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbHostelerName.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cmbHostelerName.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillCity()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(City) FROM Hostelers", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbCity.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbCity.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillCat()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Category) FROM Hostelers", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            ComboBox1.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                ComboBox1.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillBranch()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Hostelname) FROM Hostelers", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbBranch.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbBranch.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmHostelersRecord_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmMain.Show()
    End Sub
    Private Sub frmHostelersRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillHostelerName()
        fillRoomNo()
        fillCity()
        fillCat()
        fillBranch()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],USN,Purpose as [Department],DOB,Gender,Relegion as[Relegion],Caste as [Caste],Subcaste as[Sub caste],Category as [Category],HostelName as [Hostel Name],RoomNo as [Room No],DateOfJoining as [Date Of Joining],Acadyear as [Acadyear],FatherName as [Father's Name],MobNo1 as [Mobile No],Phone1 as [Phone No],MotherName as [Mother's Name],MobNo2 as [Mobile No 2],City,Address,Email,ContactNo as [Contact No],InstOfcDetails as [Ins/Ofc Details],Phone2 as [Phone No 2],Agreement,GuardianName as  [Guardian Name],GuardianAddress as [Guardian Address],MobNo3 as [Guardian Mobile No],Phone3 as [Guardian Phone No],CompletionDate as [Completion Date] from Hostelers where DateOfJoining between #" & DateFrom.Text & " # and #" & DateTo.Text & "# order by HostelerName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Hostelers")
            DataGridView2.DataSource = myDataSet.Tables("Hostelers").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cmbHostelerName.Text = ""
        txtHostelerName.Text = ""
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DateFrom.Text = Today
        DateTo.Text = Today
        DataGridView2.DataSource = Nothing
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        cmbRoomNo.Text = ""
        DataGridView3.DataSource = Nothing
    End Sub
    Sub fillRoomNo()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(RoomNo) FROM Hostelers", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbRoomNo.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbRoomNo.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbRoomNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRoomNo.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],USN,Purpose as [Department],DOB,Gender,Relegion as[Relegion],Caste as [Caste],Subcaste as[Sub caste],Category as [Category],HostelName as [Hostel Name],RoomNo as [Room No],DateOfJoining as [Date Of Joining],Acadyear as [Acadyear],FatherName as [Father's Name],MobNo1 as [Mobile No],Phone1 as [Phone No],MotherName as [Mother's Name],MobNo2 as [Mobile No 2],City,Address,Email,ContactNo as [Contact No],InstOfcDetails as [Ins/Ofc Details],Phone2 as [Phone No 2],Agreement,GuardianName as  [Guardian Name],GuardianAddress as [Guardian Address],MobNo3 as [Guardian Mobile No],Phone3 as [Guardian Phone No],CompletionDate as [Completion Date] from Hostelers where RoomNo='" & cmbRoomNo.Text & "' order by HostelerName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Hostelers")
            DataGridView3.DataSource = myDataSet.Tables("Hostelers").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbBranch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBranch.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],USN,Purpose as [Department],DOB,Gender,Relegion as[Relegion],Caste as [Caste],Subcaste as[Sub caste],Category as [Category],HostelName as [Hostel Name],RoomNo as [Room No],DateOfJoining as [Date Of Joining],Acadyear as [Acadyear],FatherName as [Father's Name],MobNo1 as [Mobile No],Phone1 as [Phone No],MotherName as [Mother's Name],MobNo2 as [Mobile No 2],City,Address,Email,ContactNo as [Contact No],InstOfcDetails as [Ins/Ofc Details],Phone2 as [Phone No 2],Agreement,GuardianName as  [Guardian Name],GuardianAddress as [Guardian Address],MobNo3 as [Guardian Mobile No],Phone3 as [Guardian Phone No],CompletionDate as [Completion Date] from Hostelers where HostelName='" & cmbBranch.Text & "' order by HostelerName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Hostelers")
            DataGridView4.DataSource = myDataSet.Tables("Hostelers").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmbBranch.Text = ""
        DataGridView4.DataSource = Nothing
    End Sub

    Private Sub TabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        cmbBranch.Text = ""
        DataGridView4.DataSource = Nothing
        cmbRoomNo.Text = ""
        DataGridView3.DataSource = Nothing
        DateFrom.Text = Today
        DateTo.Text = Today
        DataGridView2.DataSource = Nothing
        cmbHostelerName.Text = ""
        txtHostelerName.Text = ""
        DataGridView1.DataSource = Nothing
        DataGridView5.DataSource = Nothing
        DataGridView7.DataSource = Nothing
        DataGridView6.DataSource = Nothing
        DateTimePicker1.Text = Today
        ComboBox1.Text = ""
        DataGridView8.DataSource = Nothing
    End Sub


    Private Sub DataGridView1_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub DataGridView2_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView2.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView2.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView2.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub DataGridView3_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView3.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView3.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView3.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub DataGridView4_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView4.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView4.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView4.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Cursor = Cursors.Default
        Timer1.Enabled = False
    End Sub




    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],USN,Purpose as [Department],DOB,Gender,Relegion as[Relegion],Caste as [Caste],Subcaste as[Sub caste],Category as [Category],HostelName as [Hostel Name],RoomNo as [Room No],DateOfJoining as [Date Of Joining],Acadyear as [Acadyear],FatherName as [Father's Name],MobNo1 as [Mobile No],Phone1 as [Phone No],MotherName as [Mother's Name],MobNo2 as [Mobile No 2],City,Address,Email,ContactNo as [Contact No],InstOfcDetails as [Ins/Ofc Details],Phone2 as [Phone No 2],Agreement,GuardianName as  [Guardian Name],GuardianAddress as [Guardian Address],MobNo3 as [Guardian Mobile No],Phone3 as [Guardian Phone No],CompletionDate as [Completion Date] from Hostelers order by HostelerName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Hostelers")
            DataGridView5.DataSource = myDataSet.Tables("Hostelers").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        DataGridView5.DataSource = Nothing
    End Sub

    Private Sub DataGridView5_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView5.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView5.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView5.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub txtHostelerName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHostelerName.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],USN,Purpose as [Department],DOB,Gender,Relegion as[Relegion],Caste as [Caste],Subcaste as[Sub caste],Category as [Category],HostelName as [Hostel Name],RoomNo as [Room No],DateOfJoining as [Date Of Joining],Acadyear as [Acadyear],FatherName as [Father's Name],MobNo1 as [Mobile No],Phone1 as [Phone No],MotherName as [Mother's Name],MobNo2 as [Mobile No 2],City,Address,Email,ContactNo as [Contact No],InstOfcDetails as [Ins/Ofc Details],Phone2 as [Phone No 2],Agreement,GuardianName as  [Guardian Name],GuardianAddress as [Guardian Address],MobNo3 as [Guardian Mobile No],Phone3 as [Guardian Phone No],CompletionDate as [Completion Date] from Hostelers where HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Hostelers")
            DataGridView1.DataSource = myDataSet.Tables("Hostelers").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        DataGridView6.DataSource = Nothing
        DateTimePicker1.Text = Today
    End Sub

    Private Sub cmbCity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCity.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],USN,Purpose as [Department],DOB,Gender,Relegion as[Relegion],Caste as [Caste],Subcaste as[Sub caste],Category as [Category],HostelName as [Hostel Name],RoomNo as [Room No],DateOfJoining as [Date Of Joining],Acadyear as [Acadyear],FatherName as [Father's Name],MobNo1 as [Mobile No],Phone1 as [Phone No],MotherName as [Mother's Name],MobNo2 as [Mobile No 2],City,Address,Email,ContactNo as [Contact No],InstOfcDetails as [Ins/Ofc Details],Phone2 as [Phone No 2],Agreement,GuardianName as  [Guardian Name],GuardianAddress as [Guardian Address],MobNo3 as [Guardian Mobile No],Phone3 as [Guardian Phone No],CompletionDate as [Completion Date] from Hostelers where City='" & cmbCity.Text & "' order by HostelerName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Hostelers")
            DataGridView7.DataSource = myDataSet.Tables("Hostelers").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        DataGridView7.DataSource = Nothing
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],USN,Purpose as [Department],DOB,Gender,Relegion as[Relegion],Caste as [Caste],Subcaste as[Sub caste],Category as [Category],HostelName as [Hostel Name],RoomNo as [Room No],DateOfJoining as [Date Of Joining],Acadyear as [Acadyear],FatherName as [Father's Name],MobNo1 as [Mobile No],Phone1 as [Phone No],MotherName as [Mother's Name],MobNo2 as [Mobile No 2],City,Address,Email,ContactNo as [Contact No],InstOfcDetails as [Ins/Ofc Details],Phone2 as [Phone No 2],Agreement,GuardianName as  [Guardian Name],GuardianAddress as [Guardian Address],MobNo3 as [Guardian Mobile No],Phone3 as [Guardian Phone No],CompletionDate as [Completion Date] from Hostelers where DOB=#" & DateTimePicker1.Text & "# order by HostelerName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Hostelers")
            DataGridView6.DataSource = myDataSet.Tables("Hostelers").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView6_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView6.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView6.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView6.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub DataGridView7_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView7.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView7.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView7.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub


    Private Sub DataGridView8_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView8.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView8.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView8.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],USN,Purpose as [Department],DOB,Gender,Relegion as[Relegion],Caste as [Caste],Subcaste as[Sub caste],Category as [Category],HostelName as [Hostel Name],RoomNo as [Room No],DateOfJoining as [Date Of Joining],Acadyear as [Acadyear],FatherName as [Father's Name],MobNo1 as [Mobile No],Phone1 as [Phone No],MotherName as [Mother's Name],MobNo2 as [Mobile No 2],City,Address,Email,ContactNo as [Contact No],InstOfcDetails as [Ins/Ofc Details],Phone2 as [Phone No 2],Agreement,GuardianName as  [Guardian Name],GuardianAddress as [Guardian Address],MobNo3 as [Guardian Mobile No],Phone3 as [Guardian Phone No],CompletionDate as [Completion Date] from Hostelers where Category ='" & ComboBox1.Text & "' order by HostelerName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Hostelers")
            DataGridView8.DataSource = myDataSet.Tables("Hostelers").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ComboBox1.Text = ""
        DataGridView8.DataSource = Nothing
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If DataGridView1.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True
            rowsTotal = DataGridView1.RowCount - 1
            colsTotal = DataGridView1.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12
                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If DataGridView5.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True
            rowsTotal = DataGridView5.RowCount - 1
            colsTotal = DataGridView5.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView5.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView5.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub
End Class