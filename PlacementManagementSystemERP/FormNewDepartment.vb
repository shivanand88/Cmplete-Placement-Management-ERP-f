Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class FormNewDepartment
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PMS_DB.accdb;Persist Security Info=False;"
    Sub ResetDept()
        txtDID.Text = ""
        
        txtDepartment.Text = ""
        txtDummyDept.Text = ""
        txtDID.Visible = False
        Label2.Visible = False
        txtDummyDept.Visible = False
        btnSaveDep.Enabled = True
        btnDeleteDep.Enabled = False
        btnUpdateDep.Enabled = False
        txtDepartment.Focus()
    End Sub
    Sub GetDepartment()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT Department.[DID] as [Dept ID], Department.[Department] as [Dept Name] FROM Department ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Department")

            DataGridView2.DataSource = myDataSet.Tables("Department").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormNewDepartment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        FormMain.Show()
    End Sub

    Private Sub FormNewDepartment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtDepartment.Focus()
        GetDepartment()
        ResetDept()
    End Sub

    Private Sub btnResetDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetDep.Click
        ResetDept()

    End Sub

    Private Sub btnSaveDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDep.Click
        Try
            If Len(Trim(txtDepartment.Text)) = 0 Then
                MessageBox.Show("Please Enter Department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDepartment.Focus()
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT distinct Department FROM Department where Department='" & txtDepartment.Text & "' "
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                MessageBox.Show(" " & txtDepartment.Text & "! Department Already Exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ResetDept()
                txtDepartment.Focus()
                Exit Sub

            End If

            If (rdr IsNot Nothing) Then

                con = New OleDbConnection(cs)
                con.Open()
                Dim cb As String = "insert into Department(Department) VALUES ('" & txtDepartment.Text & "')"
                cmd = New OleDbCommand(cb)
                cmd.Connection = con
                cmd.ExecuteReader()
                con.Close()
                MessageBox.Show(" " & txtDepartment.Text & "   ,Saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Refresh()
                ResetDept()
                txtDepartment.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUpdateDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateDep.Click
        Try
            If Len(Trim(txtDepartment.Text)) = 0 Then
                MessageBox.Show("Please Enter Department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDepartment.Focus()
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update Department  set Department='" & txtDepartment.Text & "' where  DID=val('" & txtDID.Text & "') "
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()


            con = New OleDbConnection(cs)
            con.Open()
            Dim cb1 As String = "update Student  set Department='" & txtDepartment.Text & "' where  Department='" & txtDummyDept.Text & "' "
            cmd = New OleDbCommand(cb1)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()


            con = New OleDbConnection(cs)
            con.Open()
            Dim cb4 As String = "update PlacementRegistration  set Department='" & txtDepartment.Text & "' where  Department='" & txtDummyDept.Text & "' "
            cmd = New OleDbCommand(cb4)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()

            con = New OleDbConnection(cs)
            con.Open()
            Dim cb2 As String = "update Placement set Department='" & txtDepartment.Text & "' where  Department='" & txtDummyDept.Text & "' "
            cmd = New OleDbCommand(cb2)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            btnUpdateDep.Enabled = False
            Me.Refresh()
            ResetDept()
            txtDepartment.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDeleteDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteDep.Click
        Try
            If MessageBox.Show("Do you really want to delete the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                delete_Dept_records()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub delete_Dept_records()

        con = New OleDbConnection(cs)
        con.Open()
        Dim cb1 As String = "delete from Department where Department= '" & txtDummyDept.Text & "' "
        cmd = New OleDbCommand(cb1)
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ResetDept()
        txtDepartment.Focus()

    End Sub
    Private Sub DataGridView2_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseClick
        Label2.Visible = True
        txtDummyDept.Visible = True
        txtDummyDept.Enabled = False
        txtDepartment.Focus()
        Try
            Dim dr As DataGridViewRow = DataGridView2.SelectedRows(0)
            txtDID.Text = dr.Cells(0).Value.ToString()
            txtDummyDept.Text = dr.Cells(1).Value.ToString()
            btnSaveDep.Enabled = False
            btnUpdateDep.Enabled = True
            btnDeleteDep.Enabled = True
        Catch ex As Exception

        End Try
    End Sub


End Class