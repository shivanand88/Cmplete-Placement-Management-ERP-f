Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Excel = Microsoft.Office.Interop.Excel
Public Class FormPlacementReport
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PMS_DB.accdb;Persist Security Info=False;"
   
    Sub fillBatch()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Batch) FROM Batch", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbBatch1.Items.Clear()
            cmbBatch2.Items.Clear()

            cmbBatch5.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbBatch1.Items.Add(drow(0).ToString())
                cmbBatch2.Items.Add(drow(0).ToString())
                cmbBatch5.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub FillCompanyname()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(CompanyName) FROM Company", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbCompanyName1.Items.Clear()
            ' cmbCompanyName1.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cmbCompanyName1.Items.Add(drow(0).ToString())
                'cmbCompanyName1.Items.Add(drow(0).ToString())

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub FillDepartment()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Department) FROM Department", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbBranch.Items.Clear()
            ' cmbCompanyName1.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cmbBranch.Items.Add(drow(0).ToString())
                'cmbCompanyName1.Items.Add(drow(0).ToString())

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub GetPlacementData()
        Try

            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT Placement.[StudName] as [Student Name],Placement.[USN] as [USN],Placement.[Batch] as [Batch],Placement.[Department] as [Branch],Placement.[CompanyName] as [Company Name],Placement.[Salary] as [Salary Offered],Placement.[DateOfPlacement] as [Placement Date] FROM Placement  Order By StudName,Batch,Department", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Placement")

            DataGridView1.DataSource = myDataSet.Tables("Placement").DefaultView
            DataGridView2.DataSource = myDataSet.Tables("Placement").DefaultView
            DataGridView3.DataSource = myDataSet.Tables("Placement").DefaultView
            DataGridView8.DataSource = myDataSet.Tables("Placement").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormPlacementReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetPlacementData()
        fillBatch()
        FillCompanyname()
        FillDepartment()
    End Sub

    Private Sub cmbBatch1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBatch1.SelectedIndexChanged
        Try

            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT Placement.[StudName] as [Student Name],Placement.[USN] as [USN],Placement.[Batch] as [Batch],Placement.[Department] as [Branch],Placement.[CompanyName] as [Company Name],Placement.[Salary] as [Salary Offered],Placement.[DateOfPlacement] as [Placement Date] FROM Placement   where Placement.Batch= '" & cmbBatch1.Text & "'  Order By Batch,Department,CompanyName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Placement")

            DataGridView1.DataSource = myDataSet.Tables("Placement").DefaultView
            

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

    Private Sub cmbBatch2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBatch2.SelectedIndexChanged
        Try
            cmbCompanyName1.Text = ""
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT Placement.[StudName] as [Student Name],Placement.[USN] as [USN],Placement.[Batch] as [Batch],Placement.[Department] as [Branch],Placement.[CompanyName] as [Company Name],Placement.[Salary] as [Salary Offered],Placement.[DateOfPlacement] as [Placement Date] FROM Placement   where Placement.Batch= '" & cmbBatch2.Text & "'  Order By Department,CompanyName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Placement")

            DataGridView2.DataSource = myDataSet.Tables("Placement").DefaultView


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(CompanyName) FROM Company Where Batch = '" & cmbBatch2.Text & "'", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            'cmbCompanyName.Items.Clear()
            cmbCompanyName1.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                'cmbCompanyName.Items.Add(drow(0).ToString())
                cmbCompanyName1.Items.Add(drow(0).ToString())

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbCompanyName1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompanyName1.SelectedIndexChanged
        Try

            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT Placement.[StudName] as [Student Name],Placement.[USN] as [USN],Placement.[Batch] as [Batch],Placement.[Department] as [Branch],Placement.[CompanyName] as [Company Name],Placement.[Salary] as [Salary Offered],Placement.[DateOfPlacement] as [Placement Date] FROM Placement   where Placement.Batch= '" & cmbBatch2.Text & "' and Placement.CompanyName = '" & cmbCompanyName1.Text & "' Order By Department", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Placement")

            DataGridView2.DataSource = myDataSet.Tables("Placement").DefaultView


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cmbBranch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBranch.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT Placement.[StudName] as [Student Name],Placement.[USN] as [USN],Placement.[Batch] as [Batch],Placement.[Department] as [Branch],Placement.[CompanyName] as [Company Name],Placement.[Salary] as [Salary Offered],Placement.[DateOfPlacement] as [Placement Date] FROM Placement   where Placement.[Batch] = '" & cmbBatch5.Text & "' and  Placement.[Department]= '" & cmbBranch.Text & "'  Order By StudName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Placement")

            DataGridView3.DataSource = myDataSet.Tables("Placement").DefaultView


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReset1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset1.Click
        cmbBatch1.Text = ""
        cmbBatch1.Focus()
        GetPlacementData()
    End Sub

    Private Sub btnReset3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset3.Click
        cmbCompanyName1.Text = ""
        cmbBatch2.Text = ""
        cmbBatch2.Focus()
        DataGridView2.DataSource = Nothing
        GetPlacementData()
    End Sub
    Private Sub btnReset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset2.Click
        cmbBranch.Text = ""
        cmbBatch5.Text = ""
        cmbBatch5.Focus()
        DataGridView3.DataSource = Nothing
        GetPlacementData()
    End Sub
    Private Sub btnReset8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset8.Click
        DataGridView8.DataSource = Nothing
        GetPlacementData()
    End Sub

    
    Private Sub cmbBatch5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBatch5.SelectedIndexChanged
        Try

            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT Placement.[StudName] as [Student Name],Placement.[USN] as [USN],Placement.[Batch] as [Batch],Placement.[Department] as [Branch],Placement.[CompanyName] as [Company Name],Placement.[Salary] as [Salary Offered],Placement.[DateOfPlacement] as [Placement Date] FROM Placement   where Placement.Batch= '" & cmbBatch5.Text & "'  Order By Department,CompanyName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Placement")

            DataGridView3.DataSource = myDataSet.Tables("Placement").DefaultView


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


            If Len(Trim(cmbCompanyName1.Text)) = 0 Then
                MessageBox.Show("Please Select Company", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbCompanyName1.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT Placement.[StudName] as [Student Name],Placement.[USN] as [USN],Placement.[Batch] as [Batch],Placement.[Department] as [Branch],Placement.[CompanyName] as [Company Name],Placement.[Salary] as [Salary Offered],Placement.[DateOfPlacement] as [Placement Date] FROM Placement   where Placement.Batch= '" & cmbBatch2.Text & "' and Placement.CompanyName = '" & cmbCompanyName1.Text & "' Order By Department,CompanyName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Placement")

            DataGridView2.DataSource = myDataSet.Tables("Placement").DefaultView


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGetDataBranch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDataBranch.Click
        Try
            If Len(Trim(cmbBatch5.Text)) = 0 Then
                MessageBox.Show("Please Select Batch", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbBatch5.Focus()
                Exit Sub
            End If


            If Len(Trim(cmbBranch.Text)) = 0 Then
                MessageBox.Show("Please Select Department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbBranch.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            'cmd = New OleDbCommand("Select ReceiptNumber as [Receipt No],Hostelers.HostelerID as [Hosteler ID],HostelerName as [Hosteler Name],HostelName as [Hostel Name],RoomNo as [Room No],AcadYear as [Academic Year],CautionMoney as [Caution Money],RentalCharges as [Rental+Foods Charges],FormFee as [Form Fee],TotalCharges as [Total Charges], PaymentDate as [Payment Date] from RegCharges,Hostelers where Hostelers.HostelerID=RegCharges.HostelerID and HostelerName like '" & txtHostelerName.Text & "%' order by HostelerName", con)
            cmd = New OleDbCommand("SELECT Placement.[StudName] as [Student Name],Placement.[USN] as [USN],Placement.[Batch] as [Batch],Placement.[Department] as [Branch],Placement.[CompanyName] as [Company Name],Placement.[Salary] as [Salary Offered],Placement.[DateOfPlacement] as [Placement Date] FROM Placement   where Placement.Batch= '" & cmbBatch2.Text & "' and Placement.Department = '" & cmbBranch.Text & "' Order By Department,CompanyName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Placement")

            DataGridView3.DataSource = myDataSet.Tables("Placement").DefaultView


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
            cmd = New OleDbCommand("SELECT Placement.[StudName] as [Student Name],Placement.[USN] as [USN],Placement.[Batch] as [Batch],Placement.[Department] as [Branch],Placement.[CompanyName] as [Company Name],Placement.[Salary] as [Salary Offered],Placement.[DateOfPlacement] as [Placement Date] FROM Placement  Order By Batch, Department", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Placement")

            DataGridView8.DataSource = myDataSet.Tables("Placement").DefaultView


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
End Class