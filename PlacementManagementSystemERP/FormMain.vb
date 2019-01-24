Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FormMain
    Dim rdr As OleDbDataReader = Nothing
    Dim con As OleDbConnection = Nothing
    Dim cmd As OleDbCommand = Nothing
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PMS_DB.accdb;Persist Security Info=False;"

    Private Sub btnStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudent.Click
        Me.Hide()
        FormStudentEntry.Show()
    End Sub

    Private Sub btnCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompany.Click
        Me.Hide()
        FormCompanyEntry.Show()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Me.Dispose()
        FormLogin.Show()
        FormLogin.UserName.Text = ""
        FormLogin.Password.Text = ""
    End Sub

    Private Sub btnBatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatch.Click
        Me.Hide()
        FormAddBatchDept.Show()


    End Sub

    Private Sub btnDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepartment.Click
        Me.Hide()
        FormNewDepartment.Show()


    End Sub

    Private Sub FormMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        FormLogin.Show()
        FormLogin.UserName.Text = ""
        FormLogin.Password.Text = ""
    End Sub


    Private Sub btnRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistration.Click
        Me.Hide()
        FormPlacementRegistration.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Now
    End Sub

   
   
    Private Sub btnPlacement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlacement.Click
        Me.Hide()
        FormPlacement.Show()
    End Sub

    Private Sub btnElegibilityList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElegibilityList.Click
        Me.Hide()
        FormElegibility.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Hide()
        frmAbout.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        Me.Hide()
        FormReport.Show()
    End Sub

    Private Sub btnDataBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataBackup.Click
        Me.Hide()
        FormDataBackUp.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Hide()
        FormRegistrationStatistics.Show()
    End Sub
End Class