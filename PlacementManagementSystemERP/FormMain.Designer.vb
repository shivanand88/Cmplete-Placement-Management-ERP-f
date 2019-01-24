<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDataBackup = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.btnPlacement = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnElegibilityList = New System.Windows.Forms.Button()
        Me.btnCompany = New System.Windows.Forms.Button()
        Me.btnDepartment = New System.Windows.Forms.Button()
        Me.btnRegistration = New System.Windows.Forms.Button()
        Me.btnBatch = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUser, Me.ToolStripStatusLabel3, Me.lblDateTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 498)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(618, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(86, 17)
        Me.ToolStripStatusLabel1.Text = "Logged in As :"
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(129, 17)
        Me.lblUser.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(259, 17)
        Me.ToolStripStatusLabel3.Spring = True
        '
        'lblDateTime
        '
        Me.lblDateTime.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(129, 17)
        Me.lblDateTime.Text = "ToolStripStatusLabel4"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Teal
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Button8.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.about
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(212, 318)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(193, 78)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "About "
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label2.Location = New System.Drawing.Point(152, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Developed By"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label3.Location = New System.Drawing.Point(6, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 22)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Prof. Shivanand Ullegaddi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(162, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Dept of CSE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label5.Location = New System.Drawing.Point(141, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "SGBIT Belagavi"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Font = New System.Drawing.Font("Stencil", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(617, 44)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "SGBIT PLACEMENT MANAGEMENT SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(363, 404)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(241, 77)
        Me.Panel1.TabIndex = 22
        '
        'btnDataBackup
        '
        Me.btnDataBackup.BackColor = System.Drawing.Color.Crimson
        Me.btnDataBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDataBackup.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataBackup.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnDataBackup.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.Downloads_icon_2
        Me.btnDataBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDataBackup.Location = New System.Drawing.Point(13, 404)
        Me.btnDataBackup.Name = "btnDataBackup"
        Me.btnDataBackup.Size = New System.Drawing.Size(344, 78)
        Me.btnDataBackup.TabIndex = 23
        Me.btnDataBackup.Text = "Data Backup and Restore"
        Me.btnDataBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDataBackup.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.OrangeRed
        Me.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.Lime
        Me.btnReports.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.custom_reports_icon
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.Location = New System.Drawing.Point(212, 234)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(193, 78)
        Me.btnReports.TabIndex = 21
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Teal
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnLogout.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.logout1
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(411, 318)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(193, 78)
        Me.btnLogout.TabIndex = 14
        Me.btnLogout.Text = " Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.OrangeRed
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Lime
        Me.Button11.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.stat
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.Location = New System.Drawing.Point(411, 234)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(193, 78)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "Reg Statistics"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button11.UseVisualStyleBackColor = False
        '
        'btnPlacement
        '
        Me.btnPlacement.BackColor = System.Drawing.Color.Firebrick
        Me.btnPlacement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPlacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlacement.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlacement.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPlacement.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.celebration1
        Me.btnPlacement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlacement.Location = New System.Drawing.Point(411, 66)
        Me.btnPlacement.Name = "btnPlacement"
        Me.btnPlacement.Size = New System.Drawing.Size(193, 78)
        Me.btnPlacement.TabIndex = 8
        Me.btnPlacement.Text = "Placement"
        Me.btnPlacement.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPlacement.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Teal
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Button6.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.Admin_icon2
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(13, 318)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(193, 78)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Add User"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnElegibilityList
        '
        Me.btnElegibilityList.BackColor = System.Drawing.Color.OrangeRed
        Me.btnElegibilityList.BackgroundImage = Global.SGBITPlacementManagementSystem.My.Resources.Resources.Groups_Meeting_Dark_icon
        Me.btnElegibilityList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnElegibilityList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElegibilityList.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElegibilityList.ForeColor = System.Drawing.Color.Lime
        Me.btnElegibilityList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnElegibilityList.Location = New System.Drawing.Point(13, 234)
        Me.btnElegibilityList.Name = "btnElegibilityList"
        Me.btnElegibilityList.Size = New System.Drawing.Size(193, 78)
        Me.btnElegibilityList.TabIndex = 6
        Me.btnElegibilityList.Text = "Eligibility List"
        Me.btnElegibilityList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnElegibilityList.UseVisualStyleBackColor = False
        '
        'btnCompany
        '
        Me.btnCompany.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCompany.BackgroundImage = Global.SGBITPlacementManagementSystem.My.Resources.Resources.company
        Me.btnCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompany.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompany.ForeColor = System.Drawing.Color.Blue
        Me.btnCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompany.Location = New System.Drawing.Point(13, 150)
        Me.btnCompany.Name = "btnCompany"
        Me.btnCompany.Size = New System.Drawing.Size(193, 78)
        Me.btnCompany.TabIndex = 4
        Me.btnCompany.Text = "Add Company"
        Me.btnCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCompany.UseVisualStyleBackColor = False
        '
        'btnDepartment
        '
        Me.btnDepartment.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepartment.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepartment.ForeColor = System.Drawing.Color.Blue
        Me.btnDepartment.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.school_icon2
        Me.btnDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDepartment.Location = New System.Drawing.Point(411, 150)
        Me.btnDepartment.Name = "btnDepartment"
        Me.btnDepartment.Size = New System.Drawing.Size(193, 78)
        Me.btnDepartment.TabIndex = 3
        Me.btnDepartment.Text = "Add Branch"
        Me.btnDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDepartment.UseVisualStyleBackColor = False
        '
        'btnRegistration
        '
        Me.btnRegistration.BackColor = System.Drawing.Color.Firebrick
        Me.btnRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistration.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistration.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRegistration.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.registration_96
        Me.btnRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistration.Location = New System.Drawing.Point(212, 66)
        Me.btnRegistration.Name = "btnRegistration"
        Me.btnRegistration.Size = New System.Drawing.Size(193, 78)
        Me.btnRegistration.TabIndex = 2
        Me.btnRegistration.Text = "Registration"
        Me.btnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistration.UseVisualStyleBackColor = False
        '
        'btnBatch
        '
        Me.btnBatch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatch.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatch.ForeColor = System.Drawing.Color.Blue
        Me.btnBatch.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.batch
        Me.btnBatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatch.Location = New System.Drawing.Point(212, 150)
        Me.btnBatch.Name = "btnBatch"
        Me.btnBatch.Size = New System.Drawing.Size(193, 78)
        Me.btnBatch.TabIndex = 1
        Me.btnBatch.Text = "Add Batch"
        Me.btnBatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatch.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.Firebrick
        Me.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudent.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnStudent.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.add_suer
        Me.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudent.Location = New System.Drawing.Point(13, 66)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(193, 78)
        Me.btnStudent.TabIndex = 0
        Me.btnStudent.Text = "Add Student"
        Me.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(618, 520)
        Me.Controls.Add(Me.btnDataBackup)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.btnPlacement)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnElegibilityList)
        Me.Controls.Add(Me.btnCompany)
        Me.Controls.Add(Me.btnDepartment)
        Me.Controls.Add(Me.btnRegistration)
        Me.Controls.Add(Me.btnBatch)
        Me.Controls.Add(Me.btnStudent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMain"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStudent As System.Windows.Forms.Button
    Friend WithEvents btnBatch As System.Windows.Forms.Button
    Friend WithEvents btnDepartment As System.Windows.Forms.Button
    Friend WithEvents btnRegistration As System.Windows.Forms.Button
    Friend WithEvents btnCompany As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnElegibilityList As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents btnPlacement As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDateTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDataBackup As System.Windows.Forms.Button
End Class
