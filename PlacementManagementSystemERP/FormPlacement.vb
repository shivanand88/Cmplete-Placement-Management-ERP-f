Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class FormPlacement
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PMS_DB.accdb;Persist Security Info=False;"
    Sub reset()
        cmbSID.Enabled = False
        txtPLID.Enabled = False
        cmbCompanyID.Visible = False
        txtPLID.Text = ""
        txtPRID.Text = ""
        cmbSID.Text = ""
        txtStudName.Text = ""
        txtStudent.Text = ""
        txtUSN.Text = ""
        txtUSN.Text = ""
        txtCompanyName.Text = ""
        txtBatch.Text = ""
        txtUSN1.Text = ""
        txtDepartment.Text = ""
        txtSalary.Text = ""
        dtpDate.Text = Today
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        DataGridView1.DataSource = Nothing
        DataGridView1.Visible = False
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

    Sub FillCompanyName()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(CompanyName) FROM PlacementRegistration Where Batch = '" & cmbBatch.Text & "'", CN)
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
    Private Sub cmbBatch_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBatch.SelectedIndexChanged
        cmbCompanyName.Text = ""

        FillCompanyName()
        DataGridView2.DataSource = Nothing
        cmbCompanyName.Focus()
    End Sub
    Private Sub FormPlacement_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        FormMain.Show()
    End Sub

    Private Sub FormPlacement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        reset()
        fillSID()
        fillCompanyID()
        fillBatch()
        DataGridView2.DataSource = Nothing
    End Sub


    Private Sub btnLoadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadData.Click
        reset()
        Try

            If Len(Trim(cmbBatch.Text)) = 0 Then
                MessageBox.Show("Please Select Batch", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbBatch.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbCompanyName.Text)) = 0 Then
                MessageBox.Show("Please Select Company", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbCompanyName.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("SELECT SID as [Student ID], StudName as [Student Name],USN as [USN],Batch as [Batch]  from PlacementRegistration Where Batch= '" & cmbBatch.Text & "' and CompanyName = '" & cmbCompanyName.Text & "' order by StudName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Student")
            DataGridView2.DataSource = myDataSet.Tables("Student").DefaultView
            con.Close()
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

            '  cmbCompanyID.Text = dr.Cells(0).Value.ToString
            '  con = New OleDbConnection(cs)
            '  con.Open()
            '   cmd = con.CreateCommand()
            '  cmd.CommandText = "SELECT CompanyName FROM Company WHERE CompanyID= '" & cmbCompanyID.Text & "'"
            '  rdr = cmd.ExecuteReader()
            '   If rdr.Read() Then
            ''txtCompanyName.Text = rdr.GetString(0)
            '   End If
            '  If (rdr IsNot Nothing) Then
            'rdr.Close()
            '  End If
            '    If con.State = ConnectionState.Open Then
            'con.Close()
            '   End If
            txtCompanyName.Text = dr.Cells(1).Value.ToString()
            txtSalary.Text = dr.Cells(3).Value.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtSalary.Focus()
    End Sub
    Private Sub DataGridView2_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseClick
        '  reset()
        Try
            Dim dr As DataGridViewRow = DataGridView2.SelectedRows(0)
            cmbSID.Text = dr.Cells(0).Value.ToString
            con = New OleDbConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT PRID,StudName,USN,Department,Batch,CompanyName FROM PlacementRegistration WHERE SID= '" & cmbSID.Text & "' AND batch = '" & cmbBatch.Text & "'"
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                txtPRID.Text = rdr.GetString(0)
                txtStudName.Text = rdr.GetString(1)
                txtUSN1.Text = rdr.GetString(2)
                txtDepartment.Text = rdr.GetString(3)
                txtBatch.Text = rdr.GetString(4)
                txtCompanyName.Text = cmbCompanyName.Text
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
        txtSalary.Focus()
        txtPLID.Enabled = False
        cmbSID.Enabled = False
        txtStudName.Enabled = False
        txtUSN1.Enabled = False
        txtDepartment.Enabled = False
        txtBatch.Enabled = False
        txtCompanyName.Enabled = False
    End Sub

    Private Sub txtBatch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBatch.TextChanged
        DataGridView1.Visible = True
        Try
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("SELECT CompanyID as [Company ID],CompanyName as [Company Name],Batch as [Batch],SalPackage as [Salary Offered] from Company where Batch= '" & txtBatch.Text & "' order by CompanyName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Company")
            DataGridView1.DataSource = myDataSet.Tables("Company").DefaultView
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
            If Len(Trim(txtStudName.Text)) = 0 Then
                MessageBox.Show("Please Enter Student Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStudName.Focus()
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
            If Len(Trim(txtCompanyName.Text)) = 0 Then
                MessageBox.Show("Please Enter Company Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCompanyName.Focus()
                Exit Sub
            End If
            If Len(Trim(txtSalary.Text)) = 0 Then
                MessageBox.Show("Please Enter Salary Offered", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSalary.Focus()
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT StudName,USN,Batch,CompanyName FROM Placement where StudName='" & txtStudName.Text & "' and USN='" & txtUSN1.Text & "' and Batch='" & txtBatch.Text & "' and CompanyName='" & txtCompanyName.Text & "'"
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                MessageBox.Show(" " & txtStudName.Text & " Already Placed for " & txtCompanyName.Text & "", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If
            If (rdr IsNot Nothing) Then
                txtPLID.Text = "PL-" & GetUniqueKey(6)
                con = New OleDbConnection(cs)
                con.Open()
                Dim ct As String = "insert into Placement (PLID,PRID,SID,StudName,USN,Batch,Department,CompanyName,Salary,DateOfPlacement) values('" & txtPLID.Text & "','" & txtPRID.Text & "','" & cmbSID.Text & "','" & txtStudName.Text & "','" & txtUSN1.Text & "','" & txtBatch.Text & "', '" & txtDepartment.Text & "', '" & txtCompanyName.Text & "', '" & txtSalary.Text & "', #" & dtpDate.Text & "#)"
                cmd = New OleDbCommand(ct)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show(" Congradulations  " & txtStudName.Text & "  You Have Been Placed Successfully ", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnSave.Enabled = False
                reset()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSalary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalary.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try

            If Len(Trim(txtStudName.Text)) = 0 Then
                MessageBox.Show("Please Enter Student Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStudName.Focus()
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
            If Len(Trim(txtCompanyName.Text)) = 0 Then
                MessageBox.Show("Please Enter Company Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCompanyName.Focus()
                Exit Sub
            End If
            If Len(Trim(txtSalary.Text)) = 0 Then
                MessageBox.Show("Please Enter Salary Offered", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSalary.Focus()
                Exit Sub
            End If


            con = New OleDbConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT StudName,USN,Batch,CompanyName FROM Placement where StudName='" & txtStudName.Text & "' and USN='" & txtUSN1.Text & "' and Batch='" & txtBatch.Text & "' and CompanyName='" & txtCompanyName.Text & "'"
            'cmd.CommandText = "SELECT StudName,USN,Batch,CompanyName,Salary FROM Placement where StudName='" & txtStudName.Text & "' and USN='" & txtUSN1.Text & "' and Batch='" & txtBatch.Text & "' and CompanyName='" & txtCompanyName.Text & "' and Salary='" & txtSalary.Text & "'"
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                MessageBox.Show("Cant Update ! " & txtStudName.Text & " Already Placed for " & txtCompanyName.Text & "", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If

            If (rdr IsNot Nothing) Then
                con = New OleDbConnection(cs)
                con.Open()

                Dim ct As String = "update Placement set CompanyName='" & txtCompanyName.Text & "', Salary = '" & txtSalary.Text & "', DateOfPlacement= #" & dtpDate.Text & "# where PLID = '" & txtPLID.Text & "' "

                cmd = New OleDbCommand(ct)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Record Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnSave.Enabled = False
                reset()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        Dim cb1 As String = "delete from Placement where PLID= '" & txtPLID.Text & "'"
        cmd = New OleDbCommand(cb1)
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Reset()
    End Sub

    Private Sub txtStudent_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStudent.TextChanged
        txtUSN.Text = ""

        Try
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("SELECT SID as [Student ID], StudName as [Student Name],USN as [USN],Batch as [Batch]  from PlacementRegistration Where Batch= '" & cmbBatch.Text & "' and CompanyName = '" & cmbCompanyName.Text & "' and StudName like '%" & txtStudent.Text & "%' order by StudName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "PlacementRegistration")
            DataGridView2.DataSource = myDataSet.Tables("PlacementRegistration").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub txtUSN_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUSN.TextChanged

        txtStudent.Text = ""

        Try
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("SELECT SID as [Student ID], StudName as [Student Name],USN as [USN],Batch as [Batch]  from PlacementRegistration Where Batch= '" & cmbBatch.Text & "' and CompanyName = '" & cmbCompanyName.Text & "' and USN like '%" & txtUSN.Text & "%' order by StudName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "PlacementRegistration")
            DataGridView2.DataSource = myDataSet.Tables("PlacementRegistration").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click
        Me.Hide()
        FormPlacementRecord.txtStudName.Text = ""
        FormPlacementRecord.txtUSN.Text = ""
        FormPlacementRecord.Show()
        FormPlacementRecord.txtStudName.Focus()
    End Sub

End Class