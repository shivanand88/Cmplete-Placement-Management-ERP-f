Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Public Class FormStudentRecord
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
            cmd = New OleDbCommand("SELECT distinct  Student.[SID] as [Student ID], Student.[StudName] as [Student Name], Student.[USN]  as [USN], Student.[DOB] as [DOB], Student.[Gender] as [Gender], Student.[Caste] as [Category], Student.[Batch] as [Batch], Student.[Department] as [Branch], Student.[AdmType] as [Adm Type], Student.[EntryType] as [PUC/DIP],Student.[Scheme] as [Scheme],  Student.[Mobile] as [Mobile No],Student.[FatherName] as [Father Name], Student.[AltMobile] as [Parents Contact], Student.[PermenentAddress] as [Address], Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP] as [PUC], Student.[DIPP] as [Dip], Student.[Sem1Marks] as [SEM 1], Student.[Sem2Marks] as [SEm 2], Student.[Sem3Marks] as [SEM 3], Student.[Sem4Marks] as [SEM 4], Student.[Sem5Marks] as [SEM 5], Student.[Sem6Marks] as [SEM 6], Student.[Sem7Marks] as [SEM 7], Student.[Sem8Marks] as [SEM 8], Student.[CGPA] as [CGPA],Student.[BEP] as [BE PERCENTAGE], Student.[Backlogs] as [Backlogs] FROM Student ORDER BY Student.[StudName] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")
           
            DataGridView1.DataSource = myDataSet.Tables("Student").DefaultView
           
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormStudentRecord_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtStudName.Text = ""
        txtUSN.Text = ""
        txtStudName.Focus()
        GetData()
    End Sub

    Private Sub txtStudName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStudName.TextChanged
        Try
            txtUSN.Text = ""
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT distinct  Student.[SID] as [Student ID], Student.[StudName] as [Student Name], Student.[USN]  as [USN], Student.[DOB] as [DOB], Student.[Gender] as [Gender], Student.[Caste] as [Category], Student.[Batch] as [Batch], Student.[Department] as [Branch], Student.[AdmType] as [Adm Type], Student.[EntryType] as [PUC/DIP],Student.[Scheme] as [Scheme],  Student.[Mobile] as [Mobile No],Student.[FatherName] as [Father Name], Student.[AltMobile] as [Parents Contact], Student.[PermenentAddress] as [Address], Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP] as [PUC], Student.[DIPP] as [Dip], Student.[Sem1Marks] as [SEM 1], Student.[Sem2Marks] as [SEm 2], Student.[Sem3Marks] as [SEM 3], Student.[Sem4Marks] as [SEM 4], Student.[Sem5Marks] as [SEM 5], Student.[Sem6Marks] as [SEM 6], Student.[Sem7Marks] as [SEM 7], Student.[Sem8Marks] as [SEM 8], Student.[CGPA] as [CGPA],Student.[BEP] as [BE PERCENTAGE], Student.[Backlogs] as [Backlogs] FROM Student where Student.[StudName] like '%" & txtStudName.Text & "%' ORDER BY Student.[StudName] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")

            DataGridView1.DataSource = myDataSet.Tables("Student").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtUSN_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUSN.TextChanged
        Try
            txtStudName.Text = ""
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT distinct  Student.[SID] as [Student ID], Student.[StudName] as [Student Name], Student.[USN]  as [USN], Student.[DOB] as [DOB], Student.[Gender] as [Gender], Student.[Caste] as [Category], Student.[Batch] as [Batch], Student.[Department] as [Branch], Student.[AdmType] as [Adm Type], Student.[EntryType] as [PUC/DIP], Student.[Scheme] as [Scheme],  Student.[Mobile] as [Mobile No],Student.[FatherName] as [Father Name], Student.[AltMobile] as [Parents Contact], Student.[PermenentAddress] as [Address], Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP] as [PUC], Student.[DIPP] as [Dip], Student.[Sem1Marks] as [SEM 1], Student.[Sem2Marks] as [SEm 2], Student.[Sem3Marks] as [SEM 3], Student.[Sem4Marks] as [SEM 4], Student.[Sem5Marks] as [SEM 5], Student.[Sem6Marks] as [SEM 6], Student.[Sem7Marks] as [SEM 7], Student.[Sem8Marks] as [SEM 8], Student.[CGPA] as [CGPA],Student.[BEP] as [BE PERCENTAGE], Student.[Backlogs] as [Backlogs] FROM Student where Student.[USN] like '%" & txtUSN.Text & "%' ORDER BY Student.[StudName] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")

            DataGridView1.DataSource = myDataSet.Tables("Student").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            FormStudentEntry.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            'frmRegCharges.txtPrevDue.Text = "0"
            FormStudentEntry.txtStudentID.Text = dr.Cells(0).Value.ToString()


            FormStudentEntry.txtStudName.Text = dr.Cells(1).Value.ToString()
            FormStudentEntry.txtUSN.Text = dr.Cells(2).Value.ToString()
            FormStudentEntry.dtpDOB.Text = dr.Cells(3).Value.ToString()
            FormStudentEntry.cmbGender.Text = dr.Cells(4).Value.ToString()
            FormStudentEntry.cmbCaste.Text = dr.Cells(5).Value.ToString()
            FormStudentEntry.cmbBatch.Text = dr.Cells(6).Value.ToString()
            FormStudentEntry.cmbDepartment.Text = dr.Cells(7).Value.ToString()
            FormStudentEntry.cmbAdmType.Text = dr.Cells(8).Value.ToString()
            FormStudentEntry.cmbEntryType.Text = dr.Cells(9).Value.ToString()
            FormStudentEntry.cmbScheme.Text = dr.Cells(10).Value.ToString()
            FormStudentEntry.txtMobile.Text = dr.Cells(11).Value.ToString()
            FormStudentEntry.txtFatherName.Text = dr.Cells(12).Value.ToString()
            FormStudentEntry.txtAltMobile.Text = dr.Cells(13).Value.ToString()
            FormStudentEntry.txtAddress.Text = dr.Cells(14).Value.ToString()
            FormStudentEntry.txtEmail.Text = dr.Cells(15).Value.ToString()
            FormStudentEntry.txtSSLCP.Text = dr.Cells(16).Value.ToString()
            FormStudentEntry.txtPUCP.Text = dr.Cells(17).Value.ToString()
            FormStudentEntry.txtDiplomaP.Text = dr.Cells(18).Value.ToString()

            If (FormStudentEntry.cmbScheme.Text) = "CBCS" Then


                FormStudentEntry.txtSem1.Text = dr.Cells(19).Value.ToString()
                FormStudentEntry.txtSem2.Text = dr.Cells(20).Value.ToString()
                FormStudentEntry.txtSem3.Text = dr.Cells(21).Value.ToString()
                FormStudentEntry.txtSem4.Text = dr.Cells(22).Value.ToString()
                If (dr.Cells(23).Value) > 0 Then
                    FormStudentEntry.chkSEM5.Checked = True
                End If
                FormStudentEntry.txtSem5.Text = dr.Cells(23).Value.ToString()
                If (dr.Cells(24).Value) > 0 Then
                    FormStudentEntry.chkSEM6.Checked = True
                End If
                FormStudentEntry.txtSem6.Text = dr.Cells(24).Value.ToString()
                If (dr.Cells(25).Value) > 0 Then
                    FormStudentEntry.chkSEM7.Checked = True
                End If
                FormStudentEntry.txtSem7.Text = dr.Cells(25).Value.ToString()
                If (dr.Cells(26).Value) > 0 Then
                    FormStudentEntry.chkSEM8.Checked = True
                End If
                FormStudentEntry.txtSem8.Text = dr.Cells(26).Value.ToString()
                FormStudentEntry.txtAggregateCGPA.Text = dr.Cells(27).Value.ToString()
                FormStudentEntry.txtBEP.Text = dr.Cells(28).Value.ToString()
                FormStudentEntry.txtBacklog.Text = dr.Cells(29).Value.ToString()

            End If
            If (FormStudentEntry.cmbScheme.Text) = "NONCBCS" Then


                FormStudentEntry.txtSem11.Text = dr.Cells(19).Value.ToString()
                FormStudentEntry.txtSem22.Text = dr.Cells(20).Value.ToString()
                FormStudentEntry.txtSem33.Text = dr.Cells(21).Value.ToString()
                FormStudentEntry.txtSem44.Text = dr.Cells(22).Value.ToString()
                If (dr.Cells(23).Value) > 0 Then
                    FormStudentEntry.chkSEM55.Checked = True
                End If
                FormStudentEntry.txtSem55.Text = dr.Cells(23).Value.ToString()

                If (dr.Cells(24).Value) > 0 Then
                    FormStudentEntry.chkSEM66.Checked = True
                End If
                FormStudentEntry.txtSem66.Text = dr.Cells(24).Value.ToString()

                If (dr.Cells(25).Value) > 0 Then
                    FormStudentEntry.chkSEM77.Checked = True
                End If
                FormStudentEntry.txtSem77.Text = dr.Cells(25).Value.ToString()

                If (dr.Cells(26).Value) > 0 Then
                    FormStudentEntry.chkSEM88.Checked = True
                End If
                FormStudentEntry.txtSem88.Text = dr.Cells(26).Value.ToString()

                FormStudentEntry.txtAggregateCGPANC.Text = dr.Cells(27).Value.ToString()
                FormStudentEntry.txtBEPNC.Text = dr.Cells(28).Value.ToString()
                FormStudentEntry.txtBacklogNC.Text = dr.Cells(29).Value.ToString()

            End If
            FormStudentEntry.txtAggregateCGPA.Enabled = False
            FormStudentEntry.txtBEP.Enabled = False
            FormStudentEntry.txtAggregateCGPANC.Enabled = False
            FormStudentEntry.txtBEPNC.Enabled = False
            FormStudentEntry.btnUpdate.Enabled = True
            FormStudentEntry.btnDelete.Enabled = True
            FormStudentEntry.btnSave.Enabled = False

            FormStudentEntry.GetEntryType()
            If (dr.Cells(17).Value) > 0 Then
                FormStudentEntry.txtPUCP_DIPP.Text = dr.Cells(17).Value.ToString()
            End If
            If (dr.Cells(18).Value) > 0 Then
                FormStudentEntry.txtPUCP_DIPP.Text = dr.Cells(18).Value.ToString()
            End If
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