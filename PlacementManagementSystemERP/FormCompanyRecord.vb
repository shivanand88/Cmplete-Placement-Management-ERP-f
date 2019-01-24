Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Public Class FormCompanyRecord
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
            cmd = New OleDbCommand("SELECT Company.[CompanyID] as [Company ID], Company.[CompanyName] as [Company Name],Company.[HR1] as [HR1 Name],Company.[HRContact1] as [HR 1 Contact],Company.[HREmail1] as [HR1 Email],Company.[HR2] as [HR2 Name],Company.[HRContact2] as [HR 2 Contact],Company.[HREmail2] as [HR2 Email],Company.[Batch] as [Acad Year],Company.[Address] as [Company Address],Company.[SalPackage] as [Salary Offered],Company.SSLCP as [SSLC],Company.PUCP as [PUC/DIP],Company.BEP as [BEP],Company.Backlogs as [Backlogs] FROM Company ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Company")

            DataGridView1.DataSource = myDataSet.Tables("Company").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormCompanyRecord_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        FormCompanyEntry.Show()

    End Sub

    Private Sub FormCompanyRecord_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtCompanyName.Focus()
    End Sub

    Private Sub txtCompanyName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCompanyName.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT Company.[CompanyID] as [Company ID], Company.[CompanyName] as [Company Name],Company.[HR1] as [HR1 Name],Company.[HRContact1] as [HR 1 Contact],Company.[HREmail1] as [HR1 Email],Company.[HR2] as [HR2 Name],Company.[HRContact2] as [HR 2 Contact],Company.[HREmail2] as [HR2 Email],Company.[Batch] as [Acad Year],Company.[Address] as [Company Address],Company.[SalPackage] as [Salary Offered],Company.SSLCP as [SSLC],Company.PUCP as [PUC/DIP],Company.BEP as [BEP],Company.Backlogs as [Backlogs] FROM Company where Company.[CompanyName] like '" & txtCompanyName.Text & "%' ORDER BY Company.[CompanyName] ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Company")

            DataGridView1.DataSource = myDataSet.Tables("Company").DefaultView

            con.Close()
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

   

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            FormCompanyEntry.Show()
            FormCompanyEntry.txtCompanyID.Text = dr.Cells(0).Value.ToString()
            FormCompanyEntry.txtCompanyName.Text = dr.Cells(1).Value.ToString()
            FormCompanyEntry.txtHR1.Text = dr.Cells(2).Value.ToString()
            FormCompanyEntry.txtHRContact1.Text = dr.Cells(3).Value.ToString()
            FormCompanyEntry.txtHREmail1.Text = dr.Cells(4).Value.ToString()
            FormCompanyEntry.txtHR2.Text = dr.Cells(5).Value.ToString()
            FormCompanyEntry.txtHRContact2.Text = dr.Cells(6).Value.ToString()
            FormCompanyEntry.txtHREmail2.Text = dr.Cells(7).Value.ToString()
            FormCompanyEntry.cmbBatch.Text = dr.Cells(8).Value.ToString()
            FormCompanyEntry.txtAddress.Text = dr.Cells(9).Value.ToString()
            FormCompanyEntry.txtSalPackage.Text = dr.Cells(10).Value.ToString()
            FormCompanyEntry.txtSSLC.Text = dr.Cells(11).Value.ToString()
            FormCompanyEntry.txtPUCP_DIPP.Text = dr.Cells(12).Value.ToString()
            FormCompanyEntry.txtBE.Text = dr.Cells(13).Value.ToString()
            FormCompanyEntry.txtBacklog.Text = dr.Cells(14).Value.ToString()
            FormCompanyEntry.btnUpdate.Enabled = True
            FormCompanyEntry.btnDelete.Enabled = True
            FormCompanyEntry.btnSave.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
End Class