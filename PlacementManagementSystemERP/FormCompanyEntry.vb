Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class FormCompanyEntry
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PMS_DB.accdb;Persist Security Info=False;"
    Sub Reset()
        txtCompanyID.Text = ""
        txtCompanyName.Text = ""
        txtHR1.Text = ""
        txtHRContact1.Text = ""
        txtHREmail1.Text = ""
        txtHR2.Text = ""
        txtHRContact2.Text = ""
        txtHREmail2.Text = ""
        txtAddress.Text = ""
        cmbBatch.Text = ""
        txtSalPackage.Text = ""
        txtSSLC.Text = ""
        txtPUCP_DIPP.Text = ""
        txtBE.Text = ""
        txtBacklog.Text = ""
        txtCompanyID.ReadOnly = True
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnSave.Enabled = True
        txtCompanyName.Focus()
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
    Private Sub FormCompanyEntry_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        FormMain.Show()
    End Sub

    Private Sub FormCompanyEntry_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Reset()
        fillBatch()
        txtCompanyName.Focus()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub txtHRContact1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHRContact1.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHRContact2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHRContact2.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtSalPackage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalPackage.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try

            If Len(Trim(txtCompanyName.Text)) = 0 Then
                MessageBox.Show("Please enter Company Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCompanyName.Focus()
                Exit Sub
            End If

            If Len(Trim(txtHR1.Text)) = 0 Then
                MessageBox.Show("Please enter HR 1 Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHR1.Focus()
                Exit Sub
            End If

            If Len(Trim(txtHRContact1.Text)) = 0 Then
                MessageBox.Show("Please enter Contact Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHRContact1.Focus()
                Exit Sub
            End If
            

            If Len(Trim(txtAddress.Text)) = 0 Then
                MessageBox.Show("Please enter Company Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAddress.Focus()
                Exit Sub
            End If

            If Len(Trim(cmbBatch.Text)) = 0 Then
                MessageBox.Show("Please enter Academic Year", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbBatch.Focus()
                Exit Sub
            End If
            If Len(Trim(txtSalPackage.Text)) = 0 Then
                MessageBox.Show("Please enter Salary Package ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSalPackage.Focus()
                Exit Sub
            End If
            If Len(Trim(txtHRContact2.Text)) = 0 Then
                MessageBox.Show("HR2 Contact  Is Not Entered! Do U want to Continue? ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHRContact2.Text = 0
                Exit Sub
            End If
            If Len(Trim(txtSSLC.Text)) = 0 Then
                MessageBox.Show("Please enter SSLC cutoff? ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSSLC.Text = 0
                Exit Sub
            End If

            If Len(Trim(txtPUCP_DIPP.Text)) = 0 Then
                MessageBox.Show("Please enter PUC/DIP cutoff? ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPUCP_DIPP.Text = 0
                Exit Sub
            End If

            If Len(Trim(txtBE.Text)) = 0 Then
                MessageBox.Show("Please enter BE cutoff? ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBE.Text = 0
                Exit Sub
            End If

            If Len(Trim(txtBacklog.Text)) = 0 Then
                MessageBox.Show("Please enter Backlogs ? ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBacklog.Text = 0
                Exit Sub
            End If






            txtCompanyID.Text = "C-" & GetUniqueKey(5)
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "insert into Company (CompanyID,CompanyName,HR1,HRContact1,HREmail1,HR2,HRContact2,HREmail2,Batch,Address,SalPackage,SSLCP,PUCP,BEP,Backlogs) values('" & txtCompanyID.Text & "','" & txtCompanyName.Text & "','" & txtHR1.Text & "','" & txtHRContact1.Text & "','" & txtHREmail1.Text & "', '" & txtHR2.Text & "', '" & txtHRContact2.Text & "', '" & txtHREmail2.Text & "', '" & cmbBatch.Text & "',  '" & txtAddress.Text & "','" & txtSalPackage.Text & "','" & txtSSLC.Text & "','" & txtPUCP_DIPP.Text & "','" & txtBE.Text & "','" & txtBacklog.Text & "')"

            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Record Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try

            If Len(Trim(txtCompanyName.Text)) = 0 Then
                MessageBox.Show("Please enter Company Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCompanyName.Focus()
                Exit Sub
            End If

            If Len(Trim(txtHR1.Text)) = 0 Then
                MessageBox.Show("Please enter HR 1 Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHR1.Focus()
                Exit Sub
            End If

            If Len(Trim(txtHRContact1.Text)) = 0 Then
                MessageBox.Show("Please enter Contact Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHRContact1.Focus()
                Exit Sub
            End If

            If Len(Trim(txtAddress.Text)) = 0 Then
                MessageBox.Show("Please enter Company Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAddress.Focus()
                Exit Sub
            End If

            If Len(Trim(cmbBatch.Text)) = 0 Then
                MessageBox.Show("Please enter Academic Year", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbBatch.Focus()
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            'Dim cb1 As String = "update Placement set StudName='" & txtStudName.Text & "',USN='" & txtUSN.Text & "',Batch='" & cmbBatch.Text & "',Department='" & cmbDepartment.Text & "' where SID='" & txtStudentID.Text & "' "
            Dim ct As String = "update Company set CompanyName='" & txtCompanyName.Text & "', HR1='" & txtHR1.Text & "', HRContact1='" & txtHRContact1.Text & "',HREmail1='" & txtHREmail1.Text & "', HR2='" & txtHR2.Text & "', HRContact2='" & txtHRContact2.Text & "',HREmail2='" & txtHREmail2.Text & "', Batch = '" & cmbBatch.Text & "'  , Address ='" & txtAddress.Text & "', SalPackage = '" & txtSalPackage.Text & "', SSLCP = '" & txtSSLC.Text & "', PUCP = '" & txtPUCP_DIPP.Text & "', BEP = '" & txtBE.Text & "', Backlogs = '" & txtBacklog.Text & "' where CompanyID = '" & txtCompanyID.Text & "'     "
            'Dim ct As String = "update Company set CompanyName='" & txtCompanyName.Text & "', HR1='" & txtHR1.Text & "',  HRContact1='" & txtHRContact1.Text & "',  HR2='" & txtHR2.Text & "',   HRContact2='" & txtHRContact2.Text & "',Batch='" & cmbBatch.Text & "',Address='" & txtAddress.Text & "' where CompanyID='" & txtCompanyID.Text & "'   "
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Record Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            Reset()
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
        Dim cb1 As String = "delete from Company where CompanyID= '" & txtCompanyID.Text & "'"
        cmd = New OleDbCommand(cb1)
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Reset()
    End Sub

    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click
        Me.Hide()
        FormCompanyRecord.GetData()
        FormCompanyRecord.Show()
    End Sub

   
    
    Private Sub txtHREmail1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtHREmail1.Validating
        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
        If txtHREmail1.Text.Length > 0 Then
            If Not rEMail.IsMatch(txtHREmail1.Text) Then
                MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtHREmail1.SelectAll()
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub txtHREmail2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtHREmail2.Validating
        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
        If txtHREmail1.Text.Length > 0 Then
            If Not rEMail.IsMatch(txtHREmail1.Text) Then
                MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtHREmail1.SelectAll()
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtSSLC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSSLC.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

   
    Private Sub txtPUCP_DIPP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPUCP_DIPP.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBE.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBacklog_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBacklog.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
End Class

