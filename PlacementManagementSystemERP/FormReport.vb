Public Class FormReport

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click
        Me.Hide()
        FormMain.Show()
    End Sub

    Private Sub btnStudentReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudentReport.Click
        FormStudentReport.Show()
    End Sub

    Private Sub btnCompanyReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompanyReport.Click
        FormCompanyReport.Show()
    End Sub

    Private Sub btnPlacementReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlacementReport.Click
        FormPlacementReport.Show()
    End Sub

    Private Sub btnElegibilityList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElegibilityList.Click

        FormElegibility.Show()
    End Sub

    Private Sub btnRegistrationReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrationReport.Click
        FormRegistrationReport.Show()
    End Sub

End Class
