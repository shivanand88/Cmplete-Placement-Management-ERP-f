Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class FormAddBatchDept
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PMS_DB.accdb;Persist Security Info=False;"
    Sub ResetBatch()
        txtBID.Text = ""
        txtBID.Visible = False
        txtDummyBatch.Visible = False
        txtBatch.Text = ""
        txtDummyBatch.Text = ""
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtBatch.Focus()
    End Sub
    
    Sub GetBatch()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT Batch.[BatchID] as [Batch ID],Batch.[Batch] as [Batch] FROM Batch ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Batch")
            DataGridView1.DataSource = myDataSet.Tables("Batch").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    

    Private Sub FormAddBatchDept_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        FormMain.Show()

    End Sub
   

    Private Sub FormAddBatchDept_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetBatch()
        txtBatch.Focus()
        ResetBatch()

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ResetBatch()
    End Sub

   

   

    

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Len(Trim(txtBatch.Text)) = 0 Then
                MessageBox.Show("Please Enter Batch", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBatch.Focus()
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT Batch FROM Batch where Batch='" & txtBatch.Text & "' "
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                MessageBox.Show(" " & txtBatch.Text & "! Batch Already Exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ResetBatch()
                txtBatch.Focus()
                Exit Sub

            End If

            If (rdr IsNot Nothing) Then

                con = New OleDbConnection(cs)
                con.Open()
                Dim cb As String = "insert into Batch(Batch) VALUES ('" & txtBatch.Text & "')"
                cmd = New OleDbCommand(cb)
                cmd.Connection = con
                cmd.ExecuteReader()
                con.Close()
                MessageBox.Show(" " & txtBatch.Text & "   ,Saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Refresh()
                txtBatch.Focus()
                ResetBatch()
            End If
        Catch ex As Exception

        End Try
    End Sub


   

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If Len(Trim(txtBatch.Text)) = 0 Then
                MessageBox.Show("Please Enter Batch", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBatch.Focus()
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update Batch  set Batch='" & txtBatch.Text & "' where  BatchID= val('" & txtBID.Text & "') "
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()


            con = New OleDbConnection(cs)
            con.Open()
            Dim cb1 As String = "update PlacementRegistration  set Batch='" & txtBatch.Text & "' where  Batch='" & txtDummyBatch.Text & "' "
            cmd = New OleDbCommand(cb1)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb2 As String = "update Student  set Batch='" & txtBatch.Text & "' where  Batch='" & txtDummyBatch.Text & "' "
            cmd = New OleDbCommand(cb2)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()

            con = New OleDbConnection(cs)
            con.Open()
            Dim cb3 As String = "update Placement set Batch='" & txtBatch.Text & "' where  Batch='" & txtDummyBatch.Text & "' "
            cmd = New OleDbCommand(cb3)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            btnUpdate.Enabled = False
            Me.Refresh()
            ResetBatch()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Do you really want to delete the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                delete_Batch_records()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub delete_Batch_records()

        con = New OleDbConnection(cs)
        con.Open()
        Dim cb1 As String = "delete from Batch where Batch='" & txtDummyBatch.Text & "'"
        cmd = New OleDbCommand(cb1)
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ResetBatch()
        txtBatch.Focus()

    End Sub
    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        txtDummyBatch.Visible = True
        txtBatch.Focus()
        Try

            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            txtBID.Text = dr.Cells(0).Value.ToString
            txtDummyBatch.Text = dr.Cells(1).Value.ToString
            btnSave.Enabled = False
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

   
End Class