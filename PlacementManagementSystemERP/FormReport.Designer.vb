<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReport))
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.btnElegibilityList = New System.Windows.Forms.Button()
        Me.btnPlacementReport = New System.Windows.Forms.Button()
        Me.btnRegistrationReport = New System.Windows.Forms.Button()
        Me.btnCompanyReport = New System.Windows.Forms.Button()
        Me.btnStudentReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGoBack
        '
        Me.btnGoBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoBack.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.ForeColor = System.Drawing.Color.Lime
        Me.btnGoBack.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.logout2
        Me.btnGoBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGoBack.Location = New System.Drawing.Point(286, 178)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(265, 78)
        Me.btnGoBack.TabIndex = 14
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGoBack.UseVisualStyleBackColor = False
        '
        'btnElegibilityList
        '
        Me.btnElegibilityList.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnElegibilityList.BackgroundImage = Global.SGBITPlacementManagementSystem.My.Resources.Resources.Groups_Meeting_Dark_icon
        Me.btnElegibilityList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnElegibilityList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElegibilityList.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElegibilityList.ForeColor = System.Drawing.Color.Lime
        Me.btnElegibilityList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnElegibilityList.Location = New System.Drawing.Point(9, 178)
        Me.btnElegibilityList.Name = "btnElegibilityList"
        Me.btnElegibilityList.Size = New System.Drawing.Size(271, 78)
        Me.btnElegibilityList.TabIndex = 13
        Me.btnElegibilityList.Text = "Eligibility List"
        Me.btnElegibilityList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnElegibilityList.UseVisualStyleBackColor = False
        '
        'btnPlacementReport
        '
        Me.btnPlacementReport.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnPlacementReport.BackgroundImage = Global.SGBITPlacementManagementSystem.My.Resources.Resources.company
        Me.btnPlacementReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPlacementReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlacementReport.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlacementReport.ForeColor = System.Drawing.Color.Blue
        Me.btnPlacementReport.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.celebration2
        Me.btnPlacementReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlacementReport.Location = New System.Drawing.Point(9, 94)
        Me.btnPlacementReport.Name = "btnPlacementReport"
        Me.btnPlacementReport.Size = New System.Drawing.Size(271, 78)
        Me.btnPlacementReport.TabIndex = 12
        Me.btnPlacementReport.Text = "Placement Report"
        Me.btnPlacementReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPlacementReport.UseVisualStyleBackColor = False
        '
        'btnRegistrationReport
        '
        Me.btnRegistrationReport.BackColor = System.Drawing.Color.DarkRed
        Me.btnRegistrationReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRegistrationReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrationReport.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrationReport.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnRegistrationReport.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.registration_96
        Me.btnRegistrationReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrationReport.Location = New System.Drawing.Point(286, 10)
        Me.btnRegistrationReport.Name = "btnRegistrationReport"
        Me.btnRegistrationReport.Size = New System.Drawing.Size(265, 78)
        Me.btnRegistrationReport.TabIndex = 11
        Me.btnRegistrationReport.Text = "Registration Report"
        Me.btnRegistrationReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrationReport.UseVisualStyleBackColor = False
        '
        'btnCompanyReport
        '
        Me.btnCompanyReport.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCompanyReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCompanyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompanyReport.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompanyReport.ForeColor = System.Drawing.Color.Blue
        Me.btnCompanyReport.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.company1
        Me.btnCompanyReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompanyReport.Location = New System.Drawing.Point(286, 94)
        Me.btnCompanyReport.Name = "btnCompanyReport"
        Me.btnCompanyReport.Size = New System.Drawing.Size(265, 78)
        Me.btnCompanyReport.TabIndex = 10
        Me.btnCompanyReport.Text = "Company Report"
        Me.btnCompanyReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCompanyReport.UseVisualStyleBackColor = False
        '
        'btnStudentReport
        '
        Me.btnStudentReport.BackColor = System.Drawing.Color.DarkRed
        Me.btnStudentReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStudentReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentReport.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentReport.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnStudentReport.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.add_suer
        Me.btnStudentReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudentReport.Location = New System.Drawing.Point(9, 10)
        Me.btnStudentReport.Name = "btnStudentReport"
        Me.btnStudentReport.Size = New System.Drawing.Size(271, 78)
        Me.btnStudentReport.TabIndex = 9
        Me.btnStudentReport.Text = "Student Report"
        Me.btnStudentReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStudentReport.UseVisualStyleBackColor = False
        '
        'FormReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(562, 264)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.btnElegibilityList)
        Me.Controls.Add(Me.btnPlacementReport)
        Me.Controls.Add(Me.btnRegistrationReport)
        Me.Controls.Add(Me.btnCompanyReport)
        Me.Controls.Add(Me.btnStudentReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Report"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    Friend WithEvents btnElegibilityList As System.Windows.Forms.Button
    Friend WithEvents btnPlacementReport As System.Windows.Forms.Button
    Friend WithEvents btnRegistrationReport As System.Windows.Forms.Button
    Friend WithEvents btnCompanyReport As System.Windows.Forms.Button
    Friend WithEvents btnStudentReport As System.Windows.Forms.Button
End Class
