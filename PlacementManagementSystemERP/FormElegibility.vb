Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Excel = Microsoft.Office.Interop.Excel
Public Class FormElegibility
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PMS_DB.accdb;Persist Security Info=False;"
    Sub reset()
        txtBacklog.Text = ""
        txtBE.Text = ""
        txtPUCP_DIPP.Text = ""
        txtSSLC.Text = ""
        cmbBatch.Text = ""
        GetData()
    End Sub
    Sub GetData()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT distinct  Student.[USN]  as [USN], Student.[StudName] as [Student Name], Student.[DOB]  as [DOB], Student.[Gender]  as [Gender], Student.[FatherName]  as [FatherName],Student.[Batch] as [Batch], Student.[Department] as [Department], Student.[PermenentAddress] as [Address],Student.[Mobile] as [Mobile No],Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP_DIPP] as [PUC/DIP],Student.[BEP] as [BE], Student.[Backlogs] as [Backlogs] FROM Student ORDER BY Student.[Department],Student.[StudName],Student.[Batch] DESC", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")

            DataGridView2.DataSource = myDataSet.Tables("Student").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillBatch()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Batch) FROM Batch", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbBatch.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbBatch.Items.Add(drow(0).ToString())
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
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Department) FROM Department", CN)
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

    Private Sub FormElegibility_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        FormMain.Show()
    End Sub

    Private Sub FormElegibility_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fillBatch()
        fillBranch()
        GetData()
    End Sub

    Private Sub cmbBatch_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBatch.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT distinct  Student.[USN]  as [USN], Student.[StudName] as [Student Name], Student.[DOB]  as [DOB], Student.[Gender]  as [Gender], Student.[FatherName]  as [Father Name],Student.[Batch] as [Batch], Student.[Department] as [Department], Student.[PermenentAddress] as [Address],Student.[Mobile] as [Mobile No],Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP_DIPP] as [PUC/DIP],Student.[BEP] as [BE], Student.[Backlogs] as [Backlogs] FROM Student where Student.[Batch] = '" & cmbBatch.Text & "' ORDER BY Student.[Department],Student.[StudName] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")

            DataGridView2.DataSource = myDataSet.Tables("Student").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cmbBranch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBranch.SelectedIndexChanged
        Try
            If Len(Trim(cmbBatch.Text)) = 0 Then
                MessageBox.Show("Please Select Batch", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbBatch.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT distinct  Student.[USN]  as [USN], Student.[StudName] as [Student Name], Student.[DOB]  as [DOB], Student.[Gender]  as [Gender], Student.[FatherName]  as [FatherName],Student.[Batch] as [Batch], Student.[Department] as [Department], Student.[PermenentAddress] as [Address],Student.[Mobile] as [Mobile No],Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP_DIPP] as [PUC/DIP],Student.[BEP] as [BE], Student.[Backlogs] as [Backlogs] FROM Student where Student.[Batch] = '" & cmbBatch.Text & "' and Student.[Department] = '" & cmbBranch.Text & "'  ORDER BY Student.[StudName] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")

            DataGridView2.DataSource = myDataSet.Tables("Student").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        Try
            If Len(Trim(cmbBatch.Text)) = 0 Then
                MessageBox.Show("Please Select Batch", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbBatch.Focus()
                Exit Sub
            End If

            If Len(Trim(cmbBranch.Text)) = 0 Then
                MessageBox.Show("Please Select Branch", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbBranch.Focus()
                Exit Sub
            End If

            If Len(Trim(txtSSLC.Text)) = 0 Then
                MessageBox.Show("Please enter SSLC Percentage", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSSLC.Focus()
                Exit Sub
            End If


            If Len(Trim(txtPUCP_DIPP.Text)) = 0 Then
                MessageBox.Show("Please enter PUC/Diploma Percentage", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPUCP_DIPP.Focus()
                Exit Sub
            End If


            If Len(Trim(txtBE.Text)) = 0 Then
                MessageBox.Show("Please enter BE Percentage ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBE.Focus()
                Exit Sub
            End If


            If Len(Trim(txtBacklog.Text)) = 0 Then
                MessageBox.Show("Please enter Backlogs ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBacklog.Focus()
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT distinct  Student.[USN]  as [USN], Student.[StudName] as [Student Name], Student.[DOB]  as [DOB], Student.[Gender]  as [Gender], Student.[FatherName]  as [FatherName],Student.[Batch] as [Batch], Student.[Department] as [Department], Student.[PermenentAddress] as [Address],Student.[Mobile] as [Mobile No],Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP_DIPP] as [PUC/DIP],Student.[BEP] as [BE], Student.[Backlogs] as [Backlogs] FROM Student where Student.Batch = '" & cmbBatch.Text & "' and Student.Department = '" & cmbBranch.Text & "' and Student.SSLCP >= val('" & txtSSLC.Text & "') and Student.PUCP_DIPP >= val('" & txtPUCP_DIPP.Text & "') and Student.BEP >= val('" & txtBE.Text & "') and Student.Backlogs <= val('" & txtBacklog.Text & "') ORDER BY Student.[Department],Student.[StudName] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")

            DataGridView2.DataSource = myDataSet.Tables("Student").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
   

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        If DataGridView2.RowCount = Nothing Then
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

            rowsTotal = DataGridView2.RowCount - 1
            colsTotal = DataGridView2.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView2.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView2.Rows(I).Cells(j).Value
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

   
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        reset()
    End Sub

    

End Class