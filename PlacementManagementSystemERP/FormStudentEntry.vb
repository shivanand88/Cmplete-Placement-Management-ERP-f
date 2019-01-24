Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class FormStudentEntry
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PMS_DB.accdb;Persist Security Info=False;"
    

    Private Sub FormStudentEntry_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        FormMain.Show()
    End Sub

    Private Sub FormStudentEntry_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.WindowState = FormWindowState.Maximized
        Reset()
        fillBatch()
        fillDepartment()

        txtBEP.Text = 0
        txtBEPNC.Text = 0
        txtAggregateCGPANC.Text = 0
        txtAggregateCGPA.Text = 0
    End Sub

    Sub Reset_Save()
        fillBatch()
        fillDepartment()
        txtUSN.Text = ""
        txtStudentID.Text = ""
        txtStudName.Text = ""
        dtpDOB.Text = Today
        cmbGender.Text = ""
        cmbCaste.Text = ""
        cmbBatch.Text = ""
        cmbDepartment.Text = ""
        cmbAdmType.Text = ""
        cmbEntryType.Text = ""
        cmbScheme.Text = ""
        txtMobile.Text = ""
        txtFatherName.Text = ""
        txtAltMobile.Text = ""
        txtAddress.Text = ""
        txtEmail.Text = ""
        txtSSLCP.Text = ""
        txtDiplomaP.Text = ""
        txtPUCP.Text = ""
        txtPUCP_DIPP.Text = ""

        chkSEM1.Checked = True
        chkSEM2.Checked = True
        chkSEM3.Checked = True
        chkSEM4.Checked = True
        chkSEM5.Checked = False
        chkSEM6.Checked = False
        chkSEM7.Checked = False
        chkSEM8.Checked = False

        chkSEM11.Checked = True
        chkSEM22.Checked = True
        chkSEM33.Checked = True
        chkSEM44.Checked = True

        chkSEM55.Checked = False
        chkSEM66.Checked = False
        chkSEM77.Checked = False
        chkSEM88.Checked = False

        
        txtBEP.Text = 0
        txtBEPNC.Text = 0
        txtAggregateCGPANC.Text = 0
        txtAggregateCGPA.Text = 0
        
    End Sub

    Sub Reset()
        txtUSN.Text = ""
        txtStudentID.Text = ""
        txtStudName.Text = ""
        dtpDOB.Text = Today
        cmbGender.Text = ""
        cmbCaste.Text = ""
        cmbBatch.Text = ""
        cmbDepartment.Text = ""
        cmbAdmType.Text = ""
        cmbEntryType.Text = ""
        cmbScheme.Text = ""
        txtMobile.Text = ""
        txtFatherName.Text = ""
        txtAltMobile.Text = ""
        txtAddress.Text = ""
        txtEmail.Text = ""
        txtSSLCP.Text = ""
        txtDiplomaP.Text = ""
        txtPUCP.Text = ""
        txtPUCP_DIPP.Text = ""
        txtSem1.Text = ""
        txtSem2.Text = ""
        txtSem3.Text = ""
        txtSem4.Text = ""
        ' txtSem5.Text = 0
        ' txtSem6.Text = 0
        ' txtSem7.Text = 0
        ' txtSem8.Text = 0
        txtBacklog.Text = ""
        txtAggregateCGPA.Text = 0
        txtBEP.Text = 0


        'making check box checked true
        chkSEM1.Checked = True
        chkSEM2.Checked = True

        ' making visible
        txtSem1.Visible = True
        ' txtSem1Total.Visible = True
        txtSem2.Visible = True
        ' txtSem2Total.Visible = True
        txtDiplomaP.Visible = True
        txtPUCP.Visible = True

        'Making all check box checked

        chkSEM1.Checked = True
        chkSEM1.CheckState = CheckState.Checked

        chkSEM2.Checked = True
        chkSEM2.CheckState = CheckState.Checked

        chkSEM3.Checked = True
        chkSEM3.CheckState = CheckState.Checked

        chkSEM4.Checked = True
        chkSEM4.CheckState = CheckState.Checked

        chkSEM5.Checked = False
        chkSEM5.CheckState = CheckState.Unchecked

        chkSEM6.Checked = False
        chkSEM6.CheckState = CheckState.Unchecked

        chkSEM7.Checked = False
        chkSEM7.CheckState = CheckState.Unchecked

        chkSEM8.Checked = False
        chkSEM8.CheckState = CheckState.Unchecked

       

        ' making enabled
        txtSem1.Enabled = True
        ' txtSem1Total.Enabled = True
        txtSem2.Enabled = True
        ' txtSem2Total.Enabled = True
        txtDiplomaP.Enabled = True
        txtPUCP.Enabled = True
        chkSEM1.Enabled = True
        chkSEM2.Enabled = True
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        '''''''''''''''''''''''''''''''''''''''''''''' Noncbcs educational filds reset
        txtSem11.Text = ""
        txtSem22.Text = ""
        txtSem33.Text = ""
        txtSem44.Text = ""
        ' txtSem55.Text = 0
        ' txtSem66.Text = 0
        ' txtSem77.Text = 0
        ' txtSem88.Text = 0
        txtBacklogNC.Text = ""

        txtBEPNC.Text = 0
        txtAggregateCGPANC.Text = 0


        'making check box checked true
        chkSEM11.Checked = True
        chkSEM22.Checked = True

        ' making visible
        txtSem11.Visible = True
        txtSem11Total.Visible = True
        txtSem22.Visible = True
        txtSem22Total.Visible = True
        txtDiplomaP.Visible = True
        txtPUCP.Visible = True

        'Making all check box checked

        chkSEM11.Checked = True
        chkSEM11.CheckState = CheckState.Checked

        chkSEM22.Checked = True
        chkSEM22.CheckState = CheckState.Checked

        chkSEM33.Checked = True
        chkSEM33.CheckState = CheckState.Checked

        chkSEM44.Checked = True
        chkSEM44.CheckState = CheckState.Checked

        chkSEM55.Checked = False
        chkSEM55.CheckState = CheckState.Unchecked

        chkSEM66.Checked = False
        chkSEM66.CheckState = CheckState.Unchecked

        chkSEM77.Checked = False
        chkSEM77.CheckState = CheckState.Unchecked

        chkSEM88.Checked = False
        chkSEM88.CheckState = CheckState.Unchecked

        


        ' making enabled
        txtSem11.Enabled = True
        ' txtSem11Total.Enabled = True
        txtSem22.Enabled = True
        ' txtSem22Total.Enabled = True
        txtDiplomaP.Enabled = True
        txtPUCP.Enabled = True
        chkSEM11.Enabled = True
        chkSEM22.Enabled = True




        ' focusing student usn textbox

        txtUSN.Focus()

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
    Sub fillDepartment()
        Try
            Dim CN As New OleDbConnection(cs)
            CN.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct RTRIM(Department) FROM Department", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbDepartment.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbDepartment.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub GetEntryType()
        Dim EntryType As String
        EntryType = cmbEntryType.SelectedItem.ToString()
        If EntryType = "PUC" Then
            ''''''''''''''''' cbcs check box   check status'''''''''''''''''''''
            chkSEM1.Checked = True
            chkSEM1.CheckState = CheckState.Checked
            chkSEM2.Checked = True
            chkSEM2.CheckState = CheckState.Checked
            chkSEM1.Enabled = True
            chkSEM2.Enabled = True

            '''''''''''''''''Non cbcs check box   check status'''''''''''''''''''
            chkSEM11.Checked = True
            chkSEM11.CheckState = CheckState.Checked
            chkSEM22.Checked = True
            chkSEM22.CheckState = CheckState.Checked
            chkSEM11.Enabled = True
            chkSEM22.Enabled = True
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            txtPUCP.Enabled = True
            txtDiplomaP.Enabled = False
            txtDiplomaP.Text = 0

            ''''''''''''''''' cbcs sem1 sem2 textbox status making enabled '''''''''''''''''''
            txtSem1.Enabled = True
            txtSem1Total.Enabled = True
            txtSem2.Enabled = True
            txtSem2Total.Enabled = True

            ''''''''''''''''' Non cbcs sem1 sem2 textbox status making enabled '''''''''''''''''''
            txtSem11.Enabled = True
            txtSem11Total.Enabled = True
            txtSem22.Enabled = True
            txtSem22Total.Enabled = True
        End If



        If EntryType = "DIPLOMA" Then


            txtPUCP.Text = 0
            txtPUCP.Enabled = False


            ''''''''''''''''' cbcs check box   check status'''''''''''''''''''''
            chkSEM1.Checked = False
            chkSEM1.CheckState = CheckState.Unchecked
            chkSEM2.Checked = False
            chkSEM2.CheckState = CheckState.Unchecked
            chkSEM1.Enabled = False
            chkSEM2.Enabled = False
            txtSem1.Text = 0
            txtSem2.Text = 0
            txtSem1.Enabled = False
            txtSem1Total.Enabled = False
            txtSem2.Enabled = False
            txtSem2Total.Enabled = False
            ''''''''''''''''' Noncbcs check box   check status'''''''''''''''''''''
            chkSEM11.Checked = False
            chkSEM11.CheckState = CheckState.Unchecked
            chkSEM22.Checked = False
            chkSEM22.CheckState = CheckState.Unchecked
            chkSEM11.Enabled = False
            chkSEM22.Enabled = False
            txtSem11.Text = 0
            txtSem22.Text = 0
            txtSem11.Enabled = False
            txtSem11Total.Enabled = False
            txtSem22.Enabled = False
            txtSem22Total.Enabled = False

        End If

    End Sub
    Private Sub cmbEntryType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEntryType.SelectedIndexChanged
        Dim EntryType As String
        EntryType = cmbEntryType.SelectedItem.ToString()
        If EntryType = "PUC" Then

            txtPUCP.Enabled = True
            txtPUCP.Text = ""
            txtDiplomaP.Enabled = False
            txtDiplomaP.Text = 0

            '''''''''''CBCS Fields
            chkSEM1.Checked = True
            chkSEM1.CheckState = CheckState.Checked
            chkSEM2.Checked = True
            chkSEM2.CheckState = CheckState.Checked
            chkSEM1.Enabled = True
            chkSEM2.Enabled = True
            txtSem1.Text = ""
            txtSem2.Text = ""
            txtSem1.Enabled = True
            ' txtSem1Total.Enabled = True
            txtSem2.Enabled = True
            ' txtSem2Total.Enabled = True

            ''''''''''''Non CBC Fields

            chkSEM11.Checked = True
            chkSEM11.CheckState = CheckState.Checked
            chkSEM22.Checked = True
            chkSEM22.CheckState = CheckState.Checked
            chkSEM11.Enabled = True
            chkSEM22.Enabled = True
            txtSem11.Text = ""
            txtSem22.Text = ""
            txtSem11.Enabled = True
            ' txtSem11Total.Enabled = True
            txtSem22.Enabled = True
            'txtSem22Total.Enabled = True
        End If


        If EntryType = "DIPLOMA" Then
            Label14.Show()
            txtDiplomaP.Show()
            txtPUCP.Text = 0
            txtDiplomaP.Text = ""
            txtPUCP.Enabled = False
            txtDiplomaP.Enabled = True
            chkSEM1.Checked = False

            '''''' CBCS Fields 
            chkSEM1.CheckState = CheckState.Unchecked
            chkSEM2.Checked = False
            chkSEM2.CheckState = CheckState.Unchecked
            chkSEM1.Enabled = False
            chkSEM2.Enabled = False
            txtSem1.Text = 0
            txtSem2.Text = 0
            txtSem1.Enabled = False
            txtSem1Total.Enabled = False
            txtSem2.Enabled = False
            txtSem2Total.Enabled = False

            '''''' NONCBCS Fields 

            chkSEM11.CheckState = CheckState.Unchecked
            chkSEM22.Checked = False
            chkSEM22.CheckState = CheckState.Unchecked
            chkSEM11.Enabled = False
            chkSEM22.Enabled = False
            txtSem11.Text = 0
            txtSem22.Text = 0
            txtSem11.Enabled = False
            txtSem11Total.Enabled = False
            txtSem22.Enabled = False
            txtSem22Total.Enabled = False
        End If
    End Sub

    Private Sub txtMobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobile.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAltMobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAltMobile.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSSLCP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSSLCP.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPUCP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPUCP.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDiplomaP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiplomaP.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    ' cbcs sem marks should me numerics only

    Private Sub txtSem1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSem1.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSem2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSem2.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtSem3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSem3.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtSem4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSem4.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSem5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSem5.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSem6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSem6.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtSem7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSem7.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtSem8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSem8.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub


    ' Non cbcs sem marks should me numerics only

    Private Sub txtSem11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSem11.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSem22_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSem22.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtSem33_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSem33.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtSem44_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSem44.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSem55_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSem55.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSem66_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSem66.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtSem77_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSem77.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtSem88_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSem88.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    
    Private Sub txtBacklog_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBacklog.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtBacklogNC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBacklogNC.KeyPress
        If (e.KeyChar < Chr(46) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    ' calculating CGPA 

    Sub getCGPA()
        txtAggregateCGPA.Text = ((Val(txtSem1.Text) * Val(txtSem1Total.Text)) + (Val(txtSem2.Text) * Val(txtSem2Total.Text)) + (Val(txtSem3.Text) * Val(txtSem3Total.Text)) + (Val(txtSem4.Text) * Val(txtSem4Total.Text)) + (Val(txtSem5.Text) * Val(txtSem5Total.Text)) + (Val(txtSem6.Text) * Val(txtSem6Total.Text)) + (Val(txtSem7.Text) * Val(txtSem7Total.Text)) + (Val(txtSem8.Text) * Val(txtSem8Total.Text))) / (Val(txtSem1Total.Text) + Val(txtSem2Total.Text) + Val(txtSem3Total.Text) + Val(txtSem4Total.Text) + Val(txtSem5Total.Text) + Val(txtSem6Total.Text) + Val(txtSem7Total.Text) + Val(txtSem8Total.Text))

        Dim Average As Double = 0
        Average = Val(txtAggregateCGPA.Text)
        txtAggregateCGPA.Text = Math.Round(Average, 2)
    End Sub

   
    Private Sub txtSem1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSem1.TextChanged
        getCGPA()
       
    End Sub

    Private Sub txtSem2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSem2.TextChanged
        getCGPA()
        
    End Sub


    Private Sub txtSem3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSem3.TextChanged
        getCGPA()
        
    End Sub

    Private Sub txtSem4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSem4.TextChanged
        getCGPA()
        
    End Sub

    Private Sub txtSem5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSem5.TextChanged
        getCGPA()
        
    End Sub

    Private Sub txtSem6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSem6.TextChanged
        getCGPA()
        
    End Sub

    Private Sub txtSem7_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSem7.TextChanged
        getCGPA()
        
    End Sub

    Private Sub txtSem8_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSem8.TextChanged
        getCGPA()
       
    End Sub



    ' total percentage calculation on each  sem textbox value changed for non cbcs scheme


    Sub getBEP()

        txtBEPNC.Text = ((Val(txtSem11.Text) + Val(txtSem22.Text) + Val(txtSem33.Text) + Val(txtSem44.Text) + Val(txtSem55.Text) + Val(txtSem66.Text) + Val(txtSem77.Text) + Val(txtSem88.Text)) / (Val(txtSem11Total.Text) + Val(txtSem22Total.Text) + Val(txtSem33Total.Text) + Val(txtSem44Total.Text) + Val(txtSem55Total.Text) + Val(txtSem66Total.Text) + Val(txtSem77Total.Text) + Val(txtSem88Total.Text))) * 100
        'txtBEPNC.Text = ((Val(txtSem1.Text) * Val(txtSem1Total.Text)) + (Val(txtSem2.Text) * Val(txtSem2Total.Text)) + (Val(txtSem3.Text) * Val(txtSem3Total.Text)) + (Val(txtSem4.Text) * Val(txtSem4Total.Text)) + (Val(txtSem5.Text) * Val(txtSem5Total.Text)) + (Val(txtSem6.Text) * Val(txtSem6Total.Text)) + (Val(txtSem7.Text) * Val(txtSem7Total.Text)) + (Val(txtSem8.Text) * Val(txtSem8Total.Text))) / (Val(txtSem1Total.Text) + Val(txtSem2Total.Text) + Val(txtSem3Total.Text) + Val(txtSem4Total.Text) + Val(txtSem5Total.Text) + Val(txtSem6Total.Text) + Val(txtSem7Total.Text) + Val(txtSem8Total.Text))

        Dim Average As Double = 0
        Average = Val(txtBEPNC.Text)
        txtBEPNC.Text = Math.Round(Average, 2)
    End Sub


    Private Sub txtSem11_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSem11.TextChanged
        getBEP()

    End Sub

    Private Sub txtSem22_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSem22.TextChanged
        getBEP()

    End Sub


    Private Sub txtSem33_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSem33.TextChanged
        getBEP()

    End Sub

    Private Sub txtSem44_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSem44.TextChanged
        getBEP()

    End Sub

    Private Sub txtSem55_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSem55.TextChanged
        getBEP()

    End Sub

    Private Sub txtSem66_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSem66.TextChanged
        getBEP()

    End Sub

    Private Sub txtSem77_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSem77.TextChanged
        getBEP()

    End Sub

    Private Sub txtSem88_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSem88.TextChanged
        getBEP()

    End Sub


    ' validation for cbcs sem cgpa to check its should not more than the total grade

    Private Sub txtSem1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSem1.Validating
        If Val(txtSem1.Text) > 10 Then
            MessageBox.Show("SEM 1 SGPA is More than 10", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSem1.Text = ""
            txtSem1.Focus()
        End If
    End Sub
    Private Sub txtSem2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSem2.Validating
        If Val(txtSem2.Text) > 10 Then
            MessageBox.Show("SEM 2 SGPA is More than 10", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSem2.Text = ""
            txtSem2.Focus()
        End If
    End Sub
    Private Sub txtSem3_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSem3.Validating
        If Val(txtSem3.Text) > 10 Then
            MessageBox.Show("SEM 3 SGPA is More than 10", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSem3.Text = ""
            txtSem3.Focus()
        End If
    End Sub

    Private Sub txtSem4_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSem4.Validating
        If Val(txtSem4.Text) > 10 Then
            MessageBox.Show("SEM 4 SGPA is More than 10", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSem4.Text = ""
            txtSem4.Focus()
        End If
    End Sub
    Private Sub txtSem5_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSem5.Validating
        If Val(txtSem5.Text) > 10 Then
            MessageBox.Show("SEM 5 SGPA is More than 10", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSem5.Text = ""
            txtSem5.Focus()
        End If
    End Sub
    Private Sub txtSem6_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSem6.Validating
        If Val(txtSem6.Text) > 10 Then
            MessageBox.Show("SEM 6 SGPA is More than 10", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSem6.Text = ""
            txtSem6.Focus()
        End If
    End Sub
    Private Sub txtSem7_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSem7.Validating
        If Val(txtSem7.Text) > 10 Then
            MessageBox.Show("SEM 7 SGPA is More than 10", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSem7.Text = ""
            txtSem7.Focus()
        End If
    End Sub
    Private Sub txtSem8_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSem8.Validating
        If Val(txtSem8.Text) > 10 Then
            MessageBox.Show("SEM 8 SGPA is More than 10", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSem8.Text = ""
            txtSem8.Focus()
        End If
    End Sub


    ' validation for Non cbcs sem Marks to check its should not more than the total Grade Marks


    Private Sub txtSem11_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSem11.Validating
        If Val(txtSem11.Text) > Val(txtSem11Total.Text) Then
            MessageBox.Show("SEM 1 marks is More than Total marks", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSem11.Text = ""
            txtSem11.Focus()
        End If
    End Sub
    Private Sub txtSem22_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSem22.Validating
        If Val(txtSem22.Text) > Val(txtSem22Total.Text) Then
            MessageBox.Show("SEM 2 marks is More than Total marks", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSem22.Text = ""
            txtSem22.Focus()
        End If
    End Sub
    Private Sub txtSem33_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSem33.Validating
        If Val(txtSem33.Text) > Val(txtSem33Total.Text) Then
            MessageBox.Show("SEM 3 marks is More than Total marks", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSem33.Text = ""
            txtSem33.Focus()
        End If
    End Sub

    Private Sub txtSem44_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSem44.Validating
        If Val(txtSem44.Text) > Val(txtSem44Total.Text) Then
            MessageBox.Show("SEM 4 marks is More than Total marks", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSem44.Text = ""
            txtSem44.Focus()
        End If
    End Sub
    Private Sub txtSem55_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSem55.Validating
        If Val(txtSem55.Text) > Val(txtSem55Total.Text) Then
            MessageBox.Show("SEM 5 marks is More than Total marks", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSem55.Text = ""
            txtSem55.Focus()
        End If
    End Sub
    Private Sub txtSem66_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSem66.Validating
        If Val(txtSem66.Text) > Val(txtSem66Total.Text) Then
            MessageBox.Show("SEM 6 marks is More than Total marks", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSem66.Text = ""
            txtSem66.Focus()
        End If
    End Sub
    Private Sub txtSem77_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSem77.Validating
        If Val(txtSem77.Text) > Val(txtSem77Total.Text) Then
            MessageBox.Show("SEM 7 marks is More than Total marks", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSem77.Text = ""
            txtSem77.Focus()
        End If
    End Sub
    Private Sub txtSem88_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSem88.Validating
        If Val(txtSem88.Text) > Val(txtSem88Total.Text) Then
            MessageBox.Show("SEM 8 marks is More than Total marks", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSem88.Text = ""
            txtSem88.Focus()
        End If
    End Sub

    Private Sub txtPUCP_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPUCP.Validating
        If Val(txtPUCP.Text) > 100 Then
            MessageBox.Show("PUC Percentage canot be more than 100", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPUCP.Text = ""
            txtPUCP.Focus()
        End If
    End Sub

    Private Sub txtSSLCP_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSSLCP.Validating
        If Val(txtSSLCP.Text) > 100 Then
            MessageBox.Show("SSLC Percentage canot be more than 100", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSSLCP.Text = ""
            txtSSLCP.Focus()
        End If
    End Sub

    Private Sub txtDiplomaP_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDiplomaP.Validating
        If Val(txtDiplomaP.Text) > 100 Then
            MessageBox.Show("Diploma Percentage canot be more than 100", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDiplomaP.Text = ""
            txtDiplomaP.Focus()
        End If
    End Sub

    Private Sub txtEmail_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
        If txtEmail.Text.Length > 0 Then
            If Not rEMail.IsMatch(txtEmail.Text) Then
                MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtEmail.SelectAll()
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub txtUSN_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUSN.Validating
        con = New OleDbConnection(cs)
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandText = "SELECT USN FROM Student where USN='" & txtUSN.Text & "' "
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            MessageBox.Show("USN " & txtUSN.Text & " Already Exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUSN.Text = ""
            txtUSN.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub txtMobile_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMobile.Validating
        con = New OleDbConnection(cs)
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandText = "SELECT Mobile FROM Student where Mobile= val('" & txtMobile.Text & "') "
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            MessageBox.Show("Mobile Number " & txtMobile.Text & " Already Exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMobile.Text = ""
            txtMobile.Focus()
            Exit Sub

        End If
    End Sub
   

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Reset()
        Reset_Save()
        txtUSN.Focus()
    End Sub



    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' Dim PUCP_DIPP As Double
        If (Val(txtPUCP.Text) > 0) Then
            '  PUCP_DIPP = Val(txtPUCP.Text)
            txtPUCP_DIPP.Text = txtPUCP.Text
        End If
        If (Val(txtDiplomaP.Text) > 0) Then
            '  PUCP_DIPP = Val(txtDiplomaP.Text)
            txtPUCP_DIPP.Text = txtDiplomaP.Text
        End If

        Try
            If Len(Trim(txtStudName.Text)) = 0 Then
                MessageBox.Show("Please enter Student Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStudName.Focus()
                Exit Sub
            End If
            If Len(Trim(txtUSN.Text)) = 0 Then
                MessageBox.Show("Please enter Student USN", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUSN.Focus()
                Exit Sub
            End If

            If Len(Trim(cmbGender.Text)) = 0 Then
                MessageBox.Show("Please Select Gender Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbGender.Focus()
                Exit Sub
            End If


            If Len(Trim(cmbAdmType.Text)) = 0 Then
                MessageBox.Show("Please Select Admission Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbAdmType.Focus()
                Exit Sub
            End If

            If Len(Trim(cmbBatch.Text)) = 0 Then
                MessageBox.Show("Please Select Batch", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbBatch.Focus()
                Exit Sub
            End If

            If Len(Trim(cmbCaste.Text)) = 0 Then
                MessageBox.Show("Please Select Caste", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbCaste.Focus()
                Exit Sub
            End If



            If Len(Trim(cmbDepartment.Text)) = 0 Then
                MessageBox.Show("Please Select Department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbDepartment.Focus()
                Exit Sub
            End If

            If Len(Trim(cmbEntryType.Text)) = 0 Then
                MessageBox.Show("Please Select Entry Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbEntryType.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbScheme.Text)) = 0 Then
                MessageBox.Show("Please Select Scheme", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbScheme.Focus()
                Exit Sub
            End If


            If cmbEntryType.Text = "DIPLOMA" Then
                If Len(Trim(txtDiplomaP.Text)) = 0 Then
                    MessageBox.Show("Please enter Diploma Percentage", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtDiplomaP.Focus()
                    Exit Sub
                End If
            End If

            If cmbEntryType.Text = "PUC" Then
                If Len(Trim(txtPUCP.Text)) = 0 Then
                    MessageBox.Show("Please enter PUC Percentage", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtPUCP.Focus()
                    Exit Sub
                End If
            End If

            If Len(Trim(txtMobile.Text)) = 0 Then
                MessageBox.Show("Please Enter Mobile Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMobile.Focus()
                Exit Sub
            End If

            If Len(Trim(txtAddress.Text)) = 0 Then
                MessageBox.Show("Please enter Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAddress.Focus()
                Exit Sub
            End If


            If Len(Trim(txtSSLCP.Text)) = 0 Then
                MessageBox.Show("Please enter SSLC Percentage", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSSLCP.Focus()
                Exit Sub
            End If

            




            'fill unique StudentID 
            txtStudentID.Text = "S-" & GetUniqueKey(6)

           



            Dim Scheme1 As String
            Scheme1 = cmbScheme.SelectedItem.ToString()
            If Scheme1 = "CBCS" Then

                If Len(Trim(txtBacklog.Text)) = 0 Then
                    MessageBox.Show("Please enter Subject Backlogs", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtBacklog.Focus()
                    Exit Sub
                End If

                con = New OleDbConnection(cs)
                con.Open()
                Dim ct1 As String = "insert into Student ( SID, StudName, USN, DOB, Gender, Caste, Batch, Department, AdmType, EntryType, Scheme, Mobile, FatherName, AltMobile, PermenentAddress, Email, SSLCP, PUCP, DIPP, PUCP_DIPP, Sem1Marks, Sem2Marks, Sem3Marks, Sem4Marks, Sem5Marks, Sem6Marks, Sem7Marks, Sem8Marks, CGPA, BEP, Backlogs ) values ('" & txtStudentID.Text & "','" & txtStudName.Text & "','" & txtUSN.Text & "', #" & dtpDOB.Text & "#, '" & cmbGender.Text & "', '" & cmbCaste.Text & "', '" & cmbBatch.Text & "',  '" & cmbDepartment.Text & "',  '" & cmbAdmType.Text & "', '" & cmbEntryType.Text & "','" & cmbScheme.Text & "','" & txtMobile.Text & "','" & txtFatherName.Text & "','" & txtAltMobile.Text & "','" & txtAddress.Text & "','" & txtEmail.Text & "','" & txtSSLCP.Text & "','" & txtPUCP.Text & "','" & txtDiplomaP.Text & "','" & txtPUCP_DIPP.Text & "','" & txtSem1.Text & "','" & txtSem2.Text & "','" & txtSem3.Text & "','" & txtSem4.Text & "','" & txtSem5.Text & "','" & txtSem6.Text & "','" & txtSem7.Text & "','" & txtSem8.Text & "','" & txtAggregateCGPA.Text & "', '" & txtBEP.Text & "', '" & txtBacklog.Text & "' )"
               
                cmd = New OleDbCommand(ct1)
                cmd.Connection = con
                cmd.ExecuteNonQuery()

                MessageBox.Show("Record Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                Reset()
                Reset_Save()
                Me.Refresh()
                ' btnSave.Enabled = False
            End If
            If Scheme1 = "NONCBCS" Then

                If Len(Trim(txtBacklogNC.Text)) = 0 Then
                    MessageBox.Show("Please enter Subject Backlogs", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtBacklogNC.Focus()
                    Exit Sub
                End If
                con = New OleDbConnection(cs)
                con.Open()
                Dim ct As String = "insert into Student ( SID, StudName, USN, DOB, Gender, Caste, Batch, Department, AdmType, EntryType, Scheme, Mobile, FatherName, AltMobile, PermenentAddress, Email, SSLCP, PUCP, DIPP, PUCP_DIPP, Sem1Marks, Sem2Marks, Sem3Marks, Sem4Marks, Sem5Marks, Sem6Marks, Sem7Marks, Sem8Marks, CGPA, BEP, Backlogs ) values ('" & txtStudentID.Text & "','" & txtStudName.Text & "','" & txtUSN.Text & "', #" & dtpDOB.Text & "#, '" & cmbGender.Text & "', '" & cmbCaste.Text & "', '" & cmbBatch.Text & "',  '" & cmbDepartment.Text & "',  '" & cmbAdmType.Text & "', '" & cmbEntryType.Text & "','" & cmbScheme.Text & "','" & txtMobile.Text & "','" & txtFatherName.Text & "','" & txtAltMobile.Text & "','" & txtAddress.Text & "','" & txtEmail.Text & "','" & txtSSLCP.Text & "','" & txtPUCP.Text & "','" & txtDiplomaP.Text & "','" & txtPUCP_DIPP.Text & "','" & txtSem11.Text & "','" & txtSem22.Text & "','" & txtSem33.Text & "','" & txtSem44.Text & "','" & txtSem55.Text & "','" & txtSem66.Text & "','" & txtSem77.Text & "','" & txtSem88.Text & "','" & txtAggregateCGPANC.Text & "', '" & txtBEPNC.Text & "', '" & txtBacklogNC.Text & "' )"

                cmd = New OleDbCommand(ct)
                cmd.Connection = con
                cmd.ExecuteNonQuery()

                MessageBox.Show("Record Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                Reset()
                Reset_Save()
                Me.Refresh()
                ' btnSave.Enabled = False
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
   
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If Len(Trim(txtStudName.Text)) = 0 Then
                MessageBox.Show("Please enter Student Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStudName.Focus()
                Exit Sub
            End If
            If Len(Trim(txtUSN.Text)) = 0 Then
                MessageBox.Show("Please enter Student USN", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUSN.Focus()
                Exit Sub
            End If

            If Len(Trim(cmbGender.Text)) = 0 Then
                MessageBox.Show("Please Select Gender Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbGender.Focus()
                Exit Sub
            End If


            If Len(Trim(cmbAdmType.Text)) = 0 Then
                MessageBox.Show("Please Select Admission Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbAdmType.Focus()
                Exit Sub
            End If

            If Len(Trim(cmbBatch.Text)) = 0 Then
                MessageBox.Show("Please Select Batch", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbBatch.Focus()
                Exit Sub
            End If

            If Len(Trim(cmbCaste.Text)) = 0 Then
                MessageBox.Show("Please Select Caste", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbCaste.Focus()
                Exit Sub
            End If



            If Len(Trim(cmbDepartment.Text)) = 0 Then
                MessageBox.Show("Please Select Department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbDepartment.Focus()
                Exit Sub
            End If

            If Len(Trim(cmbEntryType.Text)) = 0 Then
                MessageBox.Show("Please Select Entry Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbEntryType.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbScheme.Text)) = 0 Then
                MessageBox.Show("Please Select Scheme", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbScheme.Focus()
                Exit Sub
            End If


            If cmbEntryType.Text = "DIPLOMA" Then
                If Len(Trim(txtDiplomaP.Text)) = 0 Then
                    MessageBox.Show("Please enter Diploma Percentage", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtDiplomaP.Focus()
                    Exit Sub
                End If
            End If

            If cmbEntryType.Text = "PUC" Then
                If Len(Trim(txtPUCP.Text)) = 0 Then
                    MessageBox.Show("Please enter PUC Percentage", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtPUCP.Focus()
                    Exit Sub
                End If
            End If

            If Len(Trim(txtMobile.Text)) = 0 Then
                MessageBox.Show("Please enter Mobile Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMobile.Focus()
                Exit Sub
            End If
            If Len(Trim(txtAltMobile.Text)) = 0 Then

                txtAltMobile.Text = 0
                '  Exit Sub
            End If

            If Len(Trim(txtAddress.Text)) = 0 Then
                MessageBox.Show("Please enter Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAddress.Focus()
                Exit Sub
            End If


            If Len(Trim(txtSSLCP.Text)) = 0 Then
                MessageBox.Show("Please enter SSLC Percentage", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSSLCP.Focus()
                Exit Sub
            End If

           

            Dim Scheme1 As String
            Scheme1 = cmbScheme.SelectedItem.ToString()
            If Scheme1 = "CBCS" Then

                If Len(Trim(txtBacklog.Text)) = 0 Then
                    MessageBox.Show("Please enter Subject Backlogs", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtBacklog.Focus()
                    Exit Sub
                End If

                con = New OleDbConnection(cs)
                con.Open()
                Dim cb As String = "update student set StudName= '" & txtStudName.Text & "', USN='" & txtUSN.Text & "', DOB=#" & dtpDOB.Text & "#, Gender='" & cmbGender.Text & "',Caste='" & cmbCaste.Text & "',Batch='" & cmbBatch.Text & "',Department='" & cmbDepartment.Text & "',AdmType='" & cmbAdmType.Text & "',   EntryType='" & cmbEntryType.Text & "',Scheme='" & cmbScheme.Text & "' ,  Mobile='" & txtMobile.Text & "', FatherName='" & txtFatherName.Text & "' , AltMobile='" & txtAltMobile.Text & "',   PermenentAddress='" & txtAddress.Text & "',   Email='" & txtEmail.Text & "',   SSLCP='" & txtSSLCP.Text & "',   PUCP='" & txtPUCP.Text & "',   DIPP='" & txtDiplomaP.Text & "', PUCP_DIPP = '" & txtPUCP_DIPP.Text & "', Sem1Marks='" & txtSem1.Text & "',   Sem2Marks='" & txtSem2.Text & "',   Sem3Marks='" & txtSem3.Text & "',   Sem4Marks='" & txtSem4.Text & "',   Sem5Marks='" & txtSem5.Text & "',   Sem6Marks='" & txtSem6.Text & "',   Sem7Marks='" & txtSem7.Text & "',   Sem8Marks=='" & txtSem8.Text & "',   CGPA='" & txtAggregateCGPA.Text & "',   BEP='" & txtBEP.Text & "',   Backlogs='" & txtBacklog.Text & "'where SID='" & txtStudentID.Text & "'       "
                cmd = New OleDbCommand(cb)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                con.Open()
                Dim cb1 As String = "update Placement set StudName='" & txtStudName.Text & "',USN='" & txtUSN.Text & "',Batch='" & cmbBatch.Text & "',Department='" & cmbDepartment.Text & "' where SID='" & txtStudentID.Text & "' "
                cmd = New OleDbCommand(cb1)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                Reset()
                Reset_Save()
                Me.Refresh()
                btnUpdate.Enabled = False
            End If

            If Scheme1 = "NONCBCS" Then

                If Len(Trim(txtBacklogNC.Text)) = 0 Then
                    MessageBox.Show("Please enter Subject Backlogs", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtBacklogNC.Focus()
                    Exit Sub
                End If


                con = New OleDbConnection(cs)
                con.Open()
                Dim cb As String = "update student set StudName= '" & txtStudName.Text & "', USN='" & txtUSN.Text & "', DOB=#" & dtpDOB.Text & "#, Gender='" & cmbGender.Text & "',Caste='" & cmbCaste.Text & "',Batch='" & cmbBatch.Text & "',Department='" & cmbDepartment.Text & "',AdmType='" & cmbAdmType.Text & "',   EntryType='" & cmbEntryType.Text & "',Scheme='" & cmbScheme.Text & "',   Mobile='" & txtMobile.Text & "', FatherName='" & txtFatherName.Text & "' , AltMobile='" & txtAltMobile.Text & "',   PermenentAddress='" & txtAddress.Text & "',   Email='" & txtEmail.Text & "',   SSLCP='" & txtSSLCP.Text & "',   PUCP='" & txtPUCP.Text & "',   DIPP='" & txtDiplomaP.Text & "', PUCP_DIPP = '" & txtPUCP_DIPP.Text & "',  Sem1Marks='" & txtSem11.Text & "',   Sem2Marks='" & txtSem22.Text & "',   Sem3Marks='" & txtSem33.Text & "',   Sem4Marks='" & txtSem44.Text & "',   Sem5Marks='" & txtSem55.Text & "',   Sem6Marks='" & txtSem66.Text & "',   Sem7Marks='" & txtSem77.Text & "',   Sem8Marks=='" & txtSem88.Text & "',   CGPA='" & txtAggregateCGPANC.Text & "',   BEP='" & txtBEPNC.Text & "',   Backlogs='" & txtBacklogNC.Text & "'where SID='" & txtStudentID.Text & "'       "
                ' Dim cb As String = "update Student set StudName='" & txtStudName.Text & "',USN='" & txtUSN.Text & "' ,DOB= #" & dtpDOB.Text & "#, Gender='" & cmbGender.Text & "', Caste='" & cmbCaste.Text & "',  Batch='" & cmbBatch.Text & "', Department='" & cmbDepartment.Text & "', AdmType='" & cmbAdmType.Text & "', EntryType='" & cmbEntryType.Text & "', Mobile='" & txtMobile.Text & "', AltMobile='" & txtAltMobile.Text & "',PermenentAddress='" & txtAddress.Text & "',      Email='" & txtEmail.Text & "', SSLCP='" & txtSSLCP.Text & "',PUCP='" & txtPUCP.Text & "', DIPP='" & txtDiplomaP.Text & "', Sem1Marks='" & txtSem1.Text & "',Sem2Marks='" & txtSem2.Text & "',Sem3Marks='" & txtSem3.Text & "',Sem4Marks='" & txtSem4.Text & "',Sem5Marks='" & txtSem5.Text & "',Sem6Marks='" & txtSem6.Text & "',Sem7Marks='" & txtSem7.Text & "',Sem8Marks='" & txtSem8.Text & "',BEAggregate='" & txtAggregateCGPA.Text & "',Backlogs='" & txtBacklog.Text & "' where SID='" & txtStudentID.Text & "'       "
                ' Dim cb As String = "update Student  set CautionMoney=" & txtCautionMoney.Text & ",RentalCharges=" & txtRentalCharges.Text & ",FormFee=" & txtFormFee.Text & ",PrevDue=" & txtPrevDue.Text & ",TotalCharges=" & txtTotalCharges.Text & ",PaymentDate= #" & dtpPaymentDate.Text & "#, AcadYear='" & cmbAcadYear.Text & "' where  HostelerID='" & cmbHostelerID.Text & "' and acadyear='" & cmbAcadYear.Text & "'"
                cmd = New OleDbCommand(cb)
                cmd.Connection = con
                cmd.ExecuteNonQuery()

                con.Close()
                con.Open()
                Dim cb1 As String = "update Placement set StudName='" & txtStudName.Text & "',USN='" & txtUSN.Text & "',Batch='" & cmbBatch.Text & "',Department='" & cmbDepartment.Text & "' where SID='" & txtStudentID.Text & "' "
                cmd = New OleDbCommand(cb1)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                btnUpdate.Enabled = False
                Reset()
                Reset_Save()
                Me.Refresh()
                con = New OleDbConnection(cs)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   

    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click
        FormStudentRecord.txtStudName.Text = ""
        FormStudentRecord.txtUSN.Text = ""
        FormStudentRecord.txtStudName.Focus()
        FormStudentRecord.Show()
        FormStudentRecord.GetData()
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
        Dim cb1 As String = "delete from Student where SID= '" & txtStudentID.Text & "' and USN ='" & txtUSN.Text & "'"
        cmd = New OleDbCommand(cb1)
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()


        con = New OleDbConnection(cs)
        con.Open()
        Dim cb2 As String = "delete from Placement where SID= '" & txtStudentID.Text & "' and USN ='" & txtUSN.Text & "'"
        cmd = New OleDbCommand(cb2)
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Reset()

    End Sub

   
   
    Private Sub chkSEM1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSEM1.CheckedChanged
        If (chkSEM1.Checked = True) Then
            txtSem1Total.Text = 24
            txtSem1.Enabled = True
            txtSem1.Text = ""
            txtSem1.Focus()
        Else
            txtSem1Total.Text = 0
            txtSem1.Text = 0
            txtSem1.Enabled = False
        End If
    End Sub
    Private Sub chkSEM11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSEM11.CheckedChanged
        If (chkSEM11.Checked = True) Then
            txtSem11Total.Text = 750
            txtSem11.Enabled = True
            txtSem11.Text = ""
            txtSem11.Focus()
        Else
            txtSem11Total.Text = 0
            txtSem11.Text = 0
            txtSem11.Enabled = False
        End If
    End Sub
    Private Sub chkSEM2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSEM2.CheckedChanged
        If (chkSEM2.Checked = True) Then
            txtSem2Total.Text = 24
            txtSem2.Enabled = True
            txtSem2.Text = ""
            txtSem2.Focus()
        Else
            txtSem2Total.Text = 0
            txtSem2.Text = 0
            txtSem2.Enabled = False
        End If
    End Sub
    Private Sub chkSEM22_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSEM22.CheckedChanged
        If (chkSEM22.Checked = True) Then
            txtSem22Total.Text = 750
            txtSem22.Enabled = True
            txtSem22.Text = ""
            txtSem22.Focus()
        Else
            txtSem22Total.Text = 0
            txtSem22.Text = 0
            txtSem22.Enabled = False
        End If
    End Sub
    Private Sub chkSEM3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSEM3.CheckedChanged
        If (chkSEM3.Checked = True) Then
            txtSem3Total.Text = 28
            txtSem3.Enabled = True
            txtSem3.Text = ""
            txtSem3.Focus()
        Else
            txtSem3Total.Text = 0
            txtSem3.Text = 0
            txtSem3.Enabled = False
        End If
    End Sub
    Private Sub chkSEM33_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSEM33.CheckedChanged
        If (chkSEM33.Checked = True) Then
            txtSem33Total.Text = 900
            txtSem33.Enabled = True
            txtSem33.Text = ""
            txtSem33.Focus()
        Else
            txtSem33Total.Text = 0
            txtSem33.Text = 0
            txtSem33.Enabled = False
        End If
    End Sub
    Private Sub chkSEM4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSEM4.CheckedChanged
        If (chkSEM4.Checked = True) Then
            txtSem4Total.Text = 28
            txtSem4.Enabled = True
            txtSem4.Text = ""
            txtSem4.Focus()
        Else
            txtSem4Total.Text = 0
            txtSem4.Text = 0
            txtSem4.Enabled = False
        End If
    End Sub
    Private Sub chkSEM44_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSEM44.CheckedChanged
        If (chkSEM44.Checked = True) Then
            txtSem44Total.Text = 900
            txtSem44.Enabled = True
            txtSem44.Text = ""
            txtSem44.Focus()
        Else
            txtSem44Total.Text = 0
            txtSem44.Text = 0
            txtSem44.Enabled = False
        End If
    End Sub
    Private Sub chkSEM5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSEM5.CheckedChanged
        If (chkSEM5.Checked = True) Then
            txtSem5Total.Text = 26
            txtSem5.Enabled = True
            txtSem5.Text = ""
            txtSem5.Focus()
        Else
            txtSem5Total.Text = 0
            txtSem5.Text = 0
            txtSem5.Enabled = False
        End If
    End Sub
    Private Sub chkSEM55_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSEM55.CheckedChanged
        If (chkSEM55.Checked = True) Then
            txtSem55Total.Text = 900
            txtSem55.Enabled = True
            txtSem55.Text = ""
            txtSem55.Focus()
        Else
            txtSem55Total.Text = 0
            txtSem55.Text = 0
            txtSem55.Enabled = False
        End If
    End Sub
    Private Sub chkSEM6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSEM6.CheckedChanged
        If (chkSEM6.Checked = True) Then
            txtSem6Total.Text = 26
            txtSem6.Enabled = True
            txtSem6.Text = ""
            txtSem6.Focus()
        Else
            txtSem6Total.Text = 0
            txtSem6.Text = 0
            txtSem6.Enabled = False
        End If
    End Sub
    Private Sub chkSEM66_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSEM66.CheckedChanged
        If (chkSEM66.Checked = True) Then
            txtSem66Total.Text = 900
            txtSem66.Enabled = True
            txtSem66.Text = ""
            txtSem66.Focus()
        Else
            txtSem66Total.Text = 0
            txtSem66.Text = 0
            txtSem66.Enabled = False
        End If
    End Sub
    Private Sub chkSEM7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSEM7.CheckedChanged
        If (chkSEM7.Checked = True) Then
            txtSem7Total.Text = 24
            txtSem7.Enabled = True

            txtSem7.Text = ""
            txtSem7.Focus()
        Else
            txtSem7Total.Text = 0
            txtSem7.Text = 0
            txtSem7.Enabled = False
        End If
    End Sub
    Private Sub chkSEM77_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSEM77.CheckedChanged
        If (chkSEM77.Checked = True) Then
            txtSem77Total.Text = 900
            txtSem77.Enabled = True

            txtSem77.Text = ""
            txtSem77.Focus()
        Else
            txtSem77Total.Text = 0
            txtSem77.Text = 0
            txtSem77.Enabled = False
        End If
    End Sub
    Private Sub chkSEM8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSEM8.CheckedChanged
        If (chkSEM8.Checked = True) Then
            txtSem8Total.Text = 20
            txtSem8.Enabled = True
            txtSem8.Text = ""
            txtSem8.Focus()
        Else
            txtSem8Total.Text = 0
            txtSem8.Text = 0
            txtSem8.Enabled = False
        End If
    End Sub
    Private Sub chkSEM88_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSEM88.CheckedChanged
        If (chkSEM88.Checked = True) Then
            txtSem88Total.Text = 600
            txtSem88.Enabled = True
            txtSem88.Text = ""
            txtSem88.Focus()
        Else
            txtSem88Total.Text = 0
            txtSem88.Text = 0
            txtSem88.Enabled = False
        End If
    End Sub

    
    Private Sub txtAggregateCGPA_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAggregateCGPA.TextChanged
        txtBEP.Text = (Val(txtAggregateCGPA.Text) - 0.75) * 10
    End Sub

    
    Private Sub txtBEPNC_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBEPNC.TextChanged
        
        txtAggregateCGPANC.Text = (Val(txtBEPNC.Text) / 10) + 0.75
    End Sub

    Private Sub cmbScheme_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbScheme.SelectedIndexChanged
        Dim Scheme As String
        Scheme = cmbScheme.SelectedItem.ToString()
        If Scheme = "CBCS" Then
            pnlCBCS.Visible = True
            pnlNonCBCS.Visible = False
            pnlCBCS.Enabled = True
            pnlNonCBCS.Enabled = False
            txtSem5.Enabled = False
            txtSem6.Enabled = False
            txtSem7.Enabled = False
            txtSem8.Enabled = False
            txtSem5.Text = 0
            txtSem6.Text = 0
            txtSem7.Text = 0
            txtSem8.Text = 0
            txtSem5Total.Text = 0
            txtSem6Total.Text = 0
            txtSem7Total.Text = 0
            txtSem8Total.Text = 0
        End If
        If Scheme = "NONCBCS" Then
            pnlNonCBCS.Enabled = True
            pnlCBCS.Enabled = False
            pnlCBCS.Visible = False
            pnlNonCBCS.Visible = True
            txtSem55.Enabled = False
            txtSem66.Enabled = False
            txtSem77.Enabled = False
            txtSem88.Enabled = False
            txtSem55.Text = 0
            txtSem66.Text = 0
            txtSem77.Text = 0
            txtSem88.Text = 0
            txtSem55Total.Text = 0
            txtSem66Total.Text = 0
            txtSem77Total.Text = 0
            txtSem88Total.Text = 0
        End If
    End Sub

   
    
    
   
   
    
    
   
    
    
End Class