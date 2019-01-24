Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class FormPlacementRegistration
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PMS_DB.accdb;Persist Security Info=False;"
    Sub reset()
        txtPRID.Text = ""
        cmbSID.Text = ""
        txtStudent.Text = ""
        txtStudentName.Text = ""
        txtUSN.Text = ""
        cmbCompanyName.Text = ""
        txtBatch.Text = ""
        txtUSN1.Text = ""
        txtDepartment.Text = ""
        ' cmbBatch.Text = ""
        txtSSLCP.Text = ""
        txtBEP.Text = ""
        txtPUCP.Text = ""
        txtBacklogs.Text = ""
        dtpDate.Text = Today
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        DataGridView1.DataSource = Nothing
        DataGridView1.Visible = False
        cmbCompanyID.Visible = False
    End Sub
   

    Private Sub FormPlacementRegistration_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        FormMain.Show()
    End Sub

    Private Sub FormPlacementRegistration_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        reset()
        fillSID()
        fillBatch()
        fillCompanyID()
        
    End Sub
    Private Sub cmbBatch_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBatch.SelectedIndexChanged
        DataGridView2.DataSource = Nothing
        Try
           
                con = New OleDbConnection(cs)
                con.Open()

            cmd = New OleDbCommand("SELECT SID as [Student ID], StudName as [Student Name],USN as [USN],Batch as [Batch], Department as [Department], SSLCP as [SSLC], PUCP_DIPP as [PUC/DIP], BEP as [BE], Backlogs as [Backlogs]  from Student where Batch = '" & cmbBatch.Text & "'order by StudName", con)
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
    Sub fillSID()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(SID) FROM Student", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbSID.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbSID.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub fillCompanyID()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(CompanyID) FROM Company", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbCompanyID.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbCompanyID.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Shared Function GetUniqueKey(ByVal maxSize As Integer) As String
        Dim chars As Char() = New Char(61) {}
        chars = "123456789".ToCharArray()
        Dim data As Byte() = New Byte(0) {}
        Dim crypto As New RNGCryptoServiceProvider()
        crypto.GetNonZeroBytes(data)
        data = New Byte(maxSize - 1) {}
        crypto.GetNonZeroBytes(data)
        Dim result As New StringBuilder(maxSize)
        For Each b As Byte In data
            result.Append(chars(b Mod (chars.Length)))
        Next
        Return result.ToString()
    End Function
    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            cmbCompanyID.Text = dr.Cells(0).Value.ToString

            If (txtSSLCP.Text < dr.Cells(3).Value.ToString) Then
                MessageBox.Show("Student Not eligible ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                reset()
                ' End If
            ElseIf (txtPUCP.Text < dr.Cells(4).Value.ToString) Then
                MessageBox.Show("Student Not eligible ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                reset()
                ' End If
            ElseIf (txtBEP.Text < dr.Cells(5).Value.ToString) Then
                MessageBox.Show("Student Not eligible ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                reset()
                ' End If
            ElseIf (txtBacklogs.Text > dr.Cells(6).Value.ToString) Then
                MessageBox.Show("Student Not eligible ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                reset()
            Else

                con = New OleDbConnection(cs)
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandText = "SELECT CompanyName FROM Company WHERE CompanyID= '" & cmbCompanyID.Text & "'"
                rdr = cmd.ExecuteReader()
                If rdr.Read() Then
                    cmbCompanyName.Text = rdr.GetString(0)
                End If
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub DataGridView2_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseClick
        ' reset()
        Try
            Dim dr As DataGridViewRow = DataGridView2.SelectedRows(0)
            cmbSID.Text = dr.Cells(0).Value.ToString
            con = New OleDbConnection(cs)
            con.Open()
            cmd = con.CreateCommand()

            ' cmd.CommandText = "SELECT PRID,StudName,USN,Department,Batch,CompanyName FROM PlacementRegistration WHERE SID= '" & cmbSID.Text & "' AND batch = '" & cmbBatch.Text & "'"
            cmd.CommandText = "SELECT SID ,StudName, USN,Batch, Department, SSLCP , PUCP_DIPP , BEP , Backlogs FROM Student where SID = '" & cmbSID.Text & "'  "

            rdr = cmd.ExecuteReader()
            If rdr.Read() Then

                '  cmbSID.Text = dr.Cells(0).Value.ToString
                txtStudentName.Text = dr.Cells(1).Value.ToString
                txtUSN1.Text = dr.Cells(2).Value.ToString
                txtBatch.Text = dr.Cells(3).Value.ToString
                txtDepartment.Text = dr.Cells(4).Value.ToString
                txtSSLCP.Text = dr.Cells(5).Value.ToString
                txtPUCP.Text = dr.Cells(6).Value.ToString
                txtBEP.Text = dr.Cells(7).Value.ToString
                txtBacklogs.Text = dr.Cells(8).Value.ToString
            End If
            If (rdr IsNot Nothing) Then
                rdr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtStudent.Text = ""
        txtUSN.Text = ""
        txtStudent.Focus()
        txtPRID.Enabled = False
        cmbSID.Enabled = False
        txtStudentName.Enabled = False
        txtUSN1.Enabled = False
        txtDepartment.Enabled = False
        txtBatch.Enabled = False
    End Sub

    Private Sub txtBatch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBatch.TextChanged
        DataGridView1.Visible = True
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(CompanyName) FROM Company where Batch='" & txtBatch.Text & "'", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbCompanyName.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbCompanyName.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        DataGridView1.Visible = True
        Try
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("SELECT CompanyID as [Company ID],CompanyName as [Company Name],Batch as [Batch], SSLCP as [SSLC], PUCP as [PUC/DIP], BEP as [BE], Backlogs as [Backlogs] from Company where Batch= '" & txtBatch.Text & "' order by CompanyName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Company")
            DataGridView1.DataSource = myDataSet.Tables("Company").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub txtStudent_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStudent.TextChanged
        DataGridView2.DataSource = Nothing
        Try
            txtUSN.Text = ""
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT distinct  Student.[SID] as [Student ID], Student.[StudName] as [Student Name], Student.[USN]  as [USN],Student.[Batch] as [Batch], Student.[Department] as [Branch], SSLCP as [SSLC], PUCP_DIPP as [PUC/DIP], BEP as [BE], Backlogs as [Backlogs] FROM Student where Student.[Batch] = '" & cmbBatch.Text & "' and Student.[StudName] like '%" & txtStudent.Text & "%' ORDER BY Student.[StudName] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "Student")

            DataGridView2.DataSource = myDataSet.Tables("Student").DefaultView

            con.Close()
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtUSN_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUSN.TextChanged
        Try
            txtStudent.Text = ""
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT distinct  Student.[SID] as [Student ID], Student.[StudName] as [Student Name], Student.[USN]  as [USN],Student.[Batch] as [Batch], Student.[Department] as [Branch], SSLCP as [SSLC], PUCP_DIPP as [PUC/DIP], BEP as [BE], Backlogs as [Backlogs] FROM Student where Student.[Batch] = '" & cmbBatch.Text & "' and Student.[USN] like '%" & txtUSN.Text & "%' ORDER BY Student.[StudName] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            DataGridView2.DataSource = Nothing
            myDA.Fill(myDataSet, "Student")

            DataGridView2.DataSource = myDataSet.Tables("Student").DefaultView

            con.Close()
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    
    
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        reset()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Len(Trim(txtStudentName.Text)) = 0 Then
                MessageBox.Show("Please Enter Student Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStudentName.Focus()
                Exit Sub
            End If
            If Len(Trim(txtUSN1.Text)) = 0 Then
                MessageBox.Show("Please Enter USN", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUSN1.Focus()
                Exit Sub
            End If
            If Len(Trim(txtDepartment.Text)) = 0 Then
                MessageBox.Show("Please Enter Department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDepartment.Focus()
                Exit Sub
            End If
            If Len(Trim(txtBatch.Text)) = 0 Then
                MessageBox.Show("Please Enter Batch", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBatch.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbCompanyName.Text)) = 0 Then
                MessageBox.Show("Please Enter Company Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbCompanyName.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT StudName,USN,Batch,CompanyName FROM PlacementRegistration where StudName='" & txtStudentName.Text & "' and USN='" & txtUSN1.Text & "' and Batch='" & txtBatch.Text & "' and CompanyName='" & cmbCompanyName.Text & "'"
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                MessageBox.Show(" " & txtStudentName.Text & " Already Registerd for " & cmbCompanyName.Text & "", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If
            If (rdr IsNot Nothing) Then
                txtPRID.Text = "PR-" & GetUniqueKey(6)
                con = New OleDbConnection(cs)
                con.Open()
                Dim ct As String = "insert into PlacementRegistration (PRID,SID,StudName,USN,Batch,Department,CompanyName,RegDate) values('" & txtPRID.Text & "','" & cmbSID.Text & "','" & txtStudentName.Text & "','" & txtUSN1.Text & "','" & txtBatch.Text & "', '" & txtDepartment.Text & "', '" & cmbCompanyName.Text & "', #" & dtpDate.Text & "#)"
                cmd = New OleDbCommand(ct)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("" & txtStudentName.Text & " Registered For " & cmbCompanyName.Text & "  Successfully ", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    MessageBox.Show("Placed Successfully ", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnSave.Enabled = False
                reset()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    
    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click
        Me.Hide()
        FormRegistrationRecord.txtStudName.Text = ""
        FormRegistrationRecord.txtUSN.Text = ""
        FormRegistrationRecord.Show()
        FormRegistrationRecord.txtStudName.Focus()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Do you really want to delete the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                delete_records()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub delete_records()
        Dim RowsAffected As Integer = 0
        con = New OleDbConnection(cs)
        con.Open()
        Dim cb1 As String = "delete from PlacementRegistration where PRID= '" & txtPRID.Text & "'"
        cmd = New OleDbCommand(cb1)
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Reset()
    End Sub


    Private Sub cmbCompanyName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompanyName.SelectedIndexChanged
        Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
        cmbCompanyID.Text = dr.Cells(0).Value.ToString
        If (txtSSLCP.Text < dr.Cells(3).Value.ToString) Then
            MessageBox.Show("Student Not eligible ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            reset()
            ' End If
        ElseIf (txtPUCP.Text < dr.Cells(4).Value.ToString) Then
            MessageBox.Show("Student Not eligible ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            reset()
            ' End If
        ElseIf (txtBEP.Text < dr.Cells(5).Value.ToString) Then
            MessageBox.Show("Student Not eligible ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            reset()
            ' End If
        ElseIf (txtBacklogs.Text > dr.Cells(6).Value.ToString) Then
            MessageBox.Show("Student Not eligible ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            reset()

        End If
    End Sub
End Class