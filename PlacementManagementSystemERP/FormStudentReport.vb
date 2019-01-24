Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Excel = Microsoft.Office.Interop.Excel
Public Class FormStudentReport
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PMS_DB.accdb;Persist Security Info=False;"
    

    
    Private Sub btnReset1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset1.Click
        txtStudName.Text = ""
        txtUSN.Text = ""
        DataGridView1.DataSource = Nothing
    End Sub
    Private Sub btnReset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmbBatch.Text = ""
        cmbBranch1.Text = ""
        DataGridView2.DataSource = Nothing
    End Sub
    Private Sub btnReset3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmbBatch2.Text = ""
        DataGridView2.DataSource = Nothing
    End Sub
    Private Sub btnReset4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset4.Click
        cmbBranch.Text = ""
        DataGridView4.DataSource = Nothing
    End Sub
    Private Sub btnReset5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset5.Click
        cmbBatch3.Text = ""
        cmbGender.Text = ""
        DataGridView5.DataSource = Nothing
    End Sub
    Private Sub btnReset7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset7.Click
        cmbBatch4.Text = ""
        cmbCategory.Text = ""
        DataGridView7.DataSource = ""

    End Sub

    Private Sub btnReset8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset8.Click
        DataGridView8.DataSource = Nothing
    End Sub
    Sub GetStudentData()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT  Student.[StudName] as [Student Name], Student.[USN]  as [USN], Student.[DOB] as [DOB], Student.[Gender] as [Gender], Student.[Caste] as [Category], Student.[Batch] as [Batch], Student.[Department] as [Branch], Student.[AdmType] as [Adm Type], Student.[EntryType] as [PUC/DIP],Student.[Scheme] as [Scheme],  Student.[Mobile] as [Mobile No],Student.[FatherName] as [Father Name], Student.[AltMobile] as [Parents Contact], Student.[PermenentAddress] as [Address], Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP] as [PUC], Student.[DIPP] as [Dip], Student.[Sem1Marks] as [SEM 1], Student.[Sem2Marks] as [SEM 2], Student.[Sem3Marks] as [SEM 3], Student.[Sem4Marks] as [SEM 4], Student.[Sem5Marks] as [SEM 5], Student.[Sem6Marks] as [SEM 6], Student.[Sem7Marks] as [SEM 7], Student.[Sem8Marks] as [SEM 8], Student.[CGPA] as [CGPA],Student.[BEP] as [BE PERCENTAGE], Student.[Backlogs] as [Backlogs] FROM Student ORDER BY Student.[StudName] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")

            DataGridView1.DataSource = myDataSet.Tables("Student").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillCategory()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Caste) FROM Student", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbCategory.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbCategory.Items.Add(drow(0).ToString())
            Next
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
            cmbBatch2.Items.Clear()
            cmbBatch3.Items.Clear()
            cmbBatch4.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbBatch.Items.Add(drow(0).ToString())
                cmbBatch2.Items.Add(drow(0).ToString())
                cmbBatch3.Items.Add(drow(0).ToString())
                cmbBatch4.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillDepartment()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Department) FROM Department", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbBranch.Items.Clear()
            cmbBranch1.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbBranch.Items.Add(drow(0).ToString())
                cmbBranch1.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormStudentReport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        FormReport.Show()
    End Sub
    Private Sub FormStudentReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetStudentData()
        txtStudName.Focus()
        fillBatch()
        fillDepartment()
        fillCategory()

    End Sub
    Private Sub txtStudName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStudName.TextChanged
        Try
            txtUSN.Text = ""
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT  Student.[StudName] as [Student Name], Student.[USN]  as [USN], Student.[DOB] as [DOB], Student.[Gender] as [Gender], Student.[Caste] as [Category], Student.[Batch] as [Batch], Student.[Department] as [Branch], Student.[AdmType] as [Adm Type], Student.[EntryType] as [PUC/DIP],Student.[Scheme] as [Scheme],  Student.[Mobile] as [Mobile No],Student.[FatherName] as [Father Name], Student.[AltMobile] as [Parents Contact], Student.[PermenentAddress] as [Address], Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP] as [PUC], Student.[DIPP] as [Dip], Student.[Sem1Marks] as [SEM 1], Student.[Sem2Marks] as [SEM 2], Student.[Sem3Marks] as [SEM 3], Student.[Sem4Marks] as [SEM 4], Student.[Sem5Marks] as [SEM 5], Student.[Sem6Marks] as [SEM 6], Student.[Sem7Marks] as [SEM 7], Student.[Sem8Marks] as [SEM 8], Student.[CGPA] as [CGPA],Student.[BEP] as [BE PERCENTAGE], Student.[Backlogs] as [Backlogs] FROM Student where Student.[StudName] like '%" & txtStudName.Text & "%' ORDER BY Student.[StudName], Student.[Batch], Student.[Department] ", con)
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
            cmd = New OleDbCommand("SELECT  Student.[StudName] as [Student Name], Student.[USN]  as [USN], Student.[DOB] as [DOB], Student.[Gender] as [Gender], Student.[Caste] as [Category], Student.[Batch] as [Batch], Student.[Department] as [Branch], Student.[AdmType] as [Adm Type], Student.[EntryType] as [PUC/DIP], Student.[Scheme] as [Scheme],  Student.[Mobile] as [Mobile No],Student.[FatherName] as [Father Name], Student.[AltMobile] as [Parents Contact], Student.[PermenentAddress] as [Address], Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP] as [PUC], Student.[DIPP] as [Dip], Student.[Sem1Marks] as [SEM 1], Student.[Sem2Marks] as [SEM 2], Student.[Sem3Marks] as [SEM 3], Student.[Sem4Marks] as [SEM 4], Student.[Sem5Marks] as [SEM 5], Student.[Sem6Marks] as [SEM 6], Student.[Sem7Marks] as [SEM 7], Student.[Sem8Marks] as [SEM 8], Student.[CGPA] as [CGPA],Student.[BEP] as [BE PERCENTAGE], Student.[Backlogs] as [Backlogs] FROM Student where Student.[USN] like '%" & txtUSN.Text & "%' ORDER BY Student.[StudName], Student.[Batch], Student.[Department] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")

            DataGridView1.DataSource = myDataSet.Tables("Student").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnGetData2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData2.Click
        Try
            If Len(Trim(cmbBatch.Text)) = 0 Then
                MessageBox.Show("Please Select Batch", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbBatch.Focus()
                Exit Sub
            End If


            If Len(Trim(cmbBranch1.Text)) = 0 Then
                MessageBox.Show("Please Select Branch", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbBranch1.Focus()
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT  Student.[StudName] as [Student Name], Student.[USN]  as [USN], Student.[DOB] as [DOB], Student.[Gender] as [Gender], Student.[Caste] as [Category], Student.[Batch] as [Batch], Student.[Department] as [Branch], Student.[AdmType] as [Adm Type], Student.[EntryType] as [PUC/DIP], Student.[Scheme] as [Scheme],  Student.[Mobile] as [Mobile No],Student.[FatherName] as [Father Name], Student.[AltMobile] as [Parents Contact], Student.[PermenentAddress] as [Address], Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP] as [PUC], Student.[DIPP] as [Dip], Student.[Sem1Marks] as [SEM 1], Student.[Sem2Marks] as [SEM 2], Student.[Sem3Marks] as [SEM 3], Student.[Sem4Marks] as [SEM 4], Student.[Sem5Marks] as [SEM 5], Student.[Sem6Marks] as [SEM 6], Student.[Sem7Marks] as [SEM 7], Student.[Sem8Marks] as [SEM 8], Student.[CGPA] as [CGPA],Student.[BEP] as [BE PERCENTAGE], Student.[Backlogs] as [Backlogs] FROM Student where Student.Batch = '" & cmbBatch.Text & "' and  Student.Department = '" & cmbBranch1.Text & "' ORDER BY Student.[StudName], Student.[Batch], Student.[Department] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")

            DataGridView3.DataSource = myDataSet.Tables("Student").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnGetDataBatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDataBatch.Click
        Try
            If Len(Trim(cmbBatch2.Text)) = 0 Then
                MessageBox.Show("Please Select Batch", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbBatch2.Focus()
                Exit Sub
            End If




            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT  Student.[StudName] as [Student Name], Student.[USN]  as [USN], Student.[DOB] as [DOB], Student.[Gender] as [Gender], Student.[Caste] as [Category], Student.[Batch] as [Batch], Student.[Department] as [Branch], Student.[AdmType] as [Adm Type], Student.[EntryType] as [PUC/DIP], Student.[Scheme] as [Scheme],  Student.[Mobile] as [Mobile No],Student.[FatherName] as [Father Name], Student.[AltMobile] as [Parents Contact], Student.[PermenentAddress] as [Address], Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP] as [PUC], Student.[DIPP] as [Dip], Student.[Sem1Marks] as [SEM 1], Student.[Sem2Marks] as [SEM 2], Student.[Sem3Marks] as [SEM 3], Student.[Sem4Marks] as [SEM 4], Student.[Sem5Marks] as [SEM 5], Student.[Sem6Marks] as [SEM 6], Student.[Sem7Marks] as [SEM 7], Student.[Sem8Marks] as [SEM 8], Student.[CGPA] as [CGPA],Student.[BEP] as [BE PERCENTAGE], Student.[Backlogs] as [Backlogs] FROM Student where Student.Batch = '" & cmbBatch2.Text & "' ORDER BY Student.[StudName], Student.[Batch], Student.[Department] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")

            DataGridView2.DataSource = myDataSet.Tables("Student").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnGetDataBranch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDataBranch.Click
        Try
            If Len(Trim(cmbBranch.Text)) = 0 Then
                MessageBox.Show("Please Select Branch", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbBranch.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT  Student.[StudName] as [Student Name], Student.[USN]  as [USN], Student.[DOB] as [DOB], Student.[Gender] as [Gender], Student.[Caste] as [Category], Student.[Batch] as [Batch], Student.[Department] as [Branch], Student.[AdmType] as [Adm Type], Student.[EntryType] as [PUC/DIP], Student.[Scheme] as [Scheme],  Student.[Mobile] as [Mobile No],Student.[FatherName] as [Father Name], Student.[AltMobile] as [Parents Contact], Student.[PermenentAddress] as [Address], Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP] as [PUC], Student.[DIPP] as [Dip], Student.[Sem1Marks] as [SEM 1], Student.[Sem2Marks] as [SEM 2], Student.[Sem3Marks] as [SEM 3], Student.[Sem4Marks] as [SEM 4], Student.[Sem5Marks] as [SEM 5], Student.[Sem6Marks] as [SEM 6], Student.[Sem7Marks] as [SEM 7], Student.[Sem8Marks] as [SEM 8], Student.[CGPA] as [CGPA],Student.[BEP] as [BE PERCENTAGE], Student.[Backlogs] as [Backlogs] FROM Student where Student.Department = '" & cmbBranch.Text & "' ORDER BY Student.[StudName], Student.[Batch] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")

            DataGridView4.DataSource = myDataSet.Tables("Student").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGetDataGender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDataGender.Click
        Try
            If Len(Trim(cmbBatch3.Text)) = 0 Then
                MessageBox.Show("Please Select Batch", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbBatch3.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbGender.Text)) = 0 Then
                MessageBox.Show("Please Select Gender", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbGender.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT  Student.[StudName] as [Student Name], Student.[USN]  as [USN], Student.[DOB] as [DOB], Student.[Gender] as [Gender], Student.[Caste] as [Category], Student.[Batch] as [Batch], Student.[Department] as [Branch], Student.[AdmType] as [Adm Type], Student.[EntryType] as [PUC/DIP], Student.[Scheme] as [Scheme],  Student.[Mobile] as [Mobile No],Student.[FatherName] as [Father Name], Student.[AltMobile] as [Parents Contact], Student.[PermenentAddress] as [Address], Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP] as [PUC], Student.[DIPP] as [Dip], Student.[Sem1Marks] as [SEM 1], Student.[Sem2Marks] as [SEM 2], Student.[Sem3Marks] as [SEM 3], Student.[Sem4Marks] as [SEM 4], Student.[Sem5Marks] as [SEM 5], Student.[Sem6Marks] as [SEM 6], Student.[Sem7Marks] as [SEM 7], Student.[Sem8Marks] as [SEM 8], Student.[CGPA] as [CGPA],Student.[BEP] as [BE PERCENTAGE], Student.[Backlogs] as [Backlogs] FROM Student where Student.Batch = '" & cmbBatch3.Text & "' and Student.[Gender] = '" & cmbGender.Text & "' ORDER BY Student.[StudName], Student.[Batch] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")

            DataGridView5.DataSource = myDataSet.Tables("Student").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
   
    Private Sub btnGetDataCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDataCategory.Click
        Try
            If Len(Trim(cmbBatch4.Text)) = 0 Then
                MessageBox.Show("Please Select Batch", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbBatch4.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbCategory.Text)) = 0 Then
                MessageBox.Show("Please Select Category", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbCategory.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT  Student.[StudName] as [Student Name], Student.[USN]  as [USN], Student.[DOB] as [DOB], Student.[Gender] as [Gender], Student.[Caste] as [Category], Student.[Batch] as [Batch], Student.[Department] as [Branch], Student.[AdmType] as [Adm Type], Student.[EntryType] as [PUC/DIP], Student.[Scheme] as [Scheme],  Student.[Mobile] as [Mobile No],Student.[FatherName] as [Father Name], Student.[AltMobile] as [Parents Contact], Student.[PermenentAddress] as [Address], Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP] as [PUC], Student.[DIPP] as [Dip], Student.[Sem1Marks] as [SEM 1], Student.[Sem2Marks] as [SEM 2], Student.[Sem3Marks] as [SEM 3], Student.[Sem4Marks] as [SEM 4], Student.[Sem5Marks] as [SEM 5], Student.[Sem6Marks] as [SEM 6], Student.[Sem7Marks] as [SEM 7], Student.[Sem8Marks] as [SEM 8], Student.[CGPA] as [CGPA],Student.[BEP] as [BE PERCENTAGE], Student.[Backlogs] as [Backlogs] FROM Student where Student.Batch = '" & cmbBatch4.Text & "' and Student.[Caste] = '" & cmbCategory.Text & "' ORDER BY Student.[StudName], Student.[Batch] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")

            DataGridView7.DataSource = myDataSet.Tables("Student").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGetAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAll.Click
        Try
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT  Student.[StudName] as [Student Name], Student.[USN]  as [USN], Student.[DOB] as [DOB], Student.[Gender] as [Gender], Student.[Caste] as [Category], Student.[Batch] as [Batch], Student.[Department] as [Branch], Student.[AdmType] as [Adm Type], Student.[EntryType] as [PUC/DIP], Student.[Scheme] as [Scheme],  Student.[Mobile] as [Mobile No],Student.[FatherName] as [Father Name], Student.[AltMobile] as [Parents Contact], Student.[PermenentAddress] as [Address], Student.[Email] as [Email ID], Student.[SSLCP] as [SSLC], Student.[PUCP] as [PUC], Student.[DIPP] as [Dip], Student.[Sem1Marks] as [SEM 1], Student.[Sem2Marks] as [SEM 2], Student.[Sem3Marks] as [SEM 3], Student.[Sem4Marks] as [SEM 4], Student.[Sem5Marks] as [SEM 5], Student.[Sem6Marks] as [SEM 6], Student.[Sem7Marks] as [SEM 7], Student.[Sem8Marks] as [SEM 8], Student.[CGPA] as [CGPA],Student.[BEP] as [BE PERCENTAGE], Student.[Backlogs] as [Backlogs] FROM Student ORDER BY Student.[StudName], Student.[Batch] , Student.[Department] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")

            DataGridView8.DataSource = myDataSet.Tables("Student").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnExportExcel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel1.Click
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


    
    
    Private Sub btnExportExcel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel2.Click
        If DataGridView3.RowCount = Nothing Then
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

            rowsTotal = DataGridView3.RowCount - 1
            colsTotal = DataGridView3.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView3.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView3.Rows(I).Cells(j).Value
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

    Private Sub btnExpoerExcel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpoerExcel3.Click
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

   
    
    Private Sub btnExportExcel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel4.Click
        If DataGridView4.RowCount = Nothing Then
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

            rowsTotal = DataGridView4.RowCount - 1
            colsTotal = DataGridView4.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView4.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView4.Rows(I).Cells(j).Value
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

   
   
    Private Sub btnExportExcel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel5.Click
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

    
    Private Sub btnExportExcel7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel7.Click
        If DataGridView7.RowCount = Nothing Then
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

            rowsTotal = DataGridView7.RowCount - 1
            colsTotal = DataGridView7.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView7.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView7.Rows(I).Cells(j).Value
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

    
   
   
   
    Private Sub btnExportExcelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcelAll.Click
        If DataGridView8.RowCount = Nothing Then
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

            rowsTotal = DataGridView8.RowCount - 1
            colsTotal = DataGridView8.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView8.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView8.Rows(I).Cells(j).Value
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class