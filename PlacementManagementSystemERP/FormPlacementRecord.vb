Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Public Class FormPlacementRecord
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PMS_DB.accdb;Persist Security Info=False;"
    Sub GetData()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT distinct  Placement.[StudName] as [Student Name],  Placement.[USN]  as [USN], Placement.[Batch] as [Batch],Placement.[Department] as [Department], Placement.[CompanyName] as [CompanyName], Placement.[Salary] as [Salary ], Placement.[DateOfPlacement] as [Placement Date],Placement.[PLID] as [Placement ID],Placement.[SID] as [Student ID],Placement.[PRID] as [Registration ID] FROM Placement ORDER BY Placement.[StudName] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Placement")

            DataGridView1.DataSource = myDataSet.Tables("Placement").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormPlacementRecord_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        FormPlacement.Show()

    End Sub

    Private Sub FormPlacementRecord_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetData()
        txtStudName.Focus()
    End Sub
    Private Sub txtUSN_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUSN.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            ' cmd = New OleDbCommand("SELECT distinct  Student.[SID] as [Student ID], Student.[StudName] as [Student Name], Student.[USN]  as [USN], Student.[DOB] as [DOB], Student.[Gender] as [Gender], Student.[Caste] as [Category], Student.[Batch] as [Batch], Student.[Department] as [Branch], Student.[AdmType] as [Adm Type], Student.[EntryType] as [PUC/DIP], Student.[Mobile] as [Mobile No], Student.[AltMobile] as [Alt Mobile], Student.[PermenentAddress] as [Address], Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP] as [PUC], Student.[DIPP] as [Dip], Student.[Sem1Marks] as [SEM 1], Student.[Sem2Marks] as [SEm 2], Student.[Sem3Marks] as [SEM 3], Student.[Sem4Marks] as [SEM 4], Student.[Sem5Marks] as [SEM 5], Student.[Sem6Marks] as [SEM 6], Student.[Sem7Marks] as [SEM 7], Student.[Sem8Marks] as [SEM 8], Student.[CGPA] as [CGPA],Student.[BEP] as [BE PERCENTAGE], Student.[Backlogs] as [Backlogs] FROM Student where Student.[USN] like '" & txtUSN.Text & "%' ORDER BY Student.[StudName] ", con)
            cmd = New OleDbCommand("SELECT distinct  Placement.[StudName] as [Student Name],  Placement.[USN]  as [USN], Placement.[Batch] as [Batch],Placement.[Department] as [Department], Placement.[CompanyName] as [CompanyName], Placement.[Salary] as [Salary ], Placement.[DateOfPlacement] as [Placement Date],Placement.[PLID] as [Placement ID],Placement.[SID] as [Student ID],Placement.[PRID] as [Registration ID] FROM Placement where Placement.[USN] like '" & txtUSN.Text & "%' ORDER BY Placement.[StudName] ", con)

            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Placement")

            DataGridView1.DataSource = myDataSet.Tables("Placement").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtStudName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStudName.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            ' cmd = New OleDbCommand("SELECT distinct  Student.[SID] as [Student ID], Student.[StudName] as [Student Name], Student.[USN]  as [USN], Student.[DOB] as [DOB], Student.[Gender] as [Gender], Student.[Caste] as [Category], Student.[Batch] as [Batch], Student.[Department] as [Branch], Student.[AdmType] as [Adm Type], Student.[EntryType] as [PUC/DIP], Student.[Mobile] as [Mobile No], Student.[AltMobile] as [Alt Mobile], Student.[PermenentAddress] as [Address], Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP] as [PUC], Student.[DIPP] as [Dip], Student.[Sem1Marks] as [SEM 1], Student.[Sem2Marks] as [SEm 2], Student.[Sem3Marks] as [SEM 3], Student.[Sem4Marks] as [SEM 4], Student.[Sem5Marks] as [SEM 5], Student.[Sem6Marks] as [SEM 6], Student.[Sem7Marks] as [SEM 7], Student.[Sem8Marks] as [SEM 8], Student.[CGPA] as [CGPA],Student.[BEP] as [BE PERCENTAGE], Student.[Backlogs] as [Backlogs] FROM Student where Student.[USN] like '" & txtUSN.Text & "%' ORDER BY Student.[StudName] ", con)
            cmd = New OleDbCommand("SELECT distinct  Placement.[StudName] as [Student Name],  Placement.[USN]  as [USN], Placement.[Batch] as [Batch],Placement.[Department] as [Department], Placement.[CompanyName] as [CompanyName], Placement.[Salary] as [Salary ], Placement.[DateOfPlacement] as [Placement Date],Placement.[PLID] as [Placement ID],Placement.[SID] as [Student ID],Placement.[PRID] as [Registration ID] FROM Placement where Placement.[USN] like '" & txtStudName.Text & "%' ORDER BY Placement.[StudName] ", con)

            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Placement")

            DataGridView1.DataSource = myDataSet.Tables("Placement").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            FormPlacement.Show()
           
         
            FormPlacement.txtStudName.Text = dr.Cells(0).Value.ToString()
            FormPlacement.txtUSN1.Text = dr.Cells(1).Value.ToString()
            FormPlacement.txtBatch.Text = dr.Cells(2).Value.ToString()
            FormPlacement.txtDepartment.Text = dr.Cells(3).Value.ToString()
            FormPlacement.txtCompanyName.Text = dr.Cells(4).Value.ToString()
            FormPlacement.txtSalary.Text = dr.Cells(5).Value.ToString()
            FormPlacement.dtpDate.Text = dr.Cells(6).Value.ToString()
            FormPlacement.txtPLID.Text = dr.Cells(7).Value.ToString()
            FormPlacement.cmbSID.Text = dr.Cells(8).Value.ToString()
            FormPlacement.txtPRID.Text = dr.Cells(9).Value.ToString()
            FormPlacement.btnUpdate.Enabled = True
            FormPlacement.btnDelete.Enabled = True
            FormPlacement.btnSave.Enabled = False
            FormPlacement.txtPRID.Enabled = False
            FormPlacement.cmbSID.Enabled = False
            FormPlacement.txtStudName.Enabled = False
            FormPlacement.txtUSN1.Enabled = False
            FormPlacement.txtBatch.Enabled = False
            FormPlacement.txtDepartment.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
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
End Class