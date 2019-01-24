<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckOut))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNewRecord = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtHosteler = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHostelerName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHostelName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRoomNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAcadYear = New System.Windows.Forms.TextBox()
        Me.txtHostelerID = New System.Windows.Forms.TextBox()
        Me.txtTotalDueAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoOfBeds = New System.Windows.Forms.TextBox()
        Me.txtBedAvailable = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtUSN = New System.Windows.Forms.TextBox()
        Me.panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.btnSave)
        Me.panel1.Controls.Add(Me.btnNewRecord)
        Me.panel1.Location = New System.Drawing.Point(14, 443)
        Me.panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(483, 82)
        Me.panel1.TabIndex = 79
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(290, 17)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(174, 41)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Check Out"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNewRecord
        '
        Me.btnNewRecord.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRecord.Location = New System.Drawing.Point(15, 17)
        Me.btnNewRecord.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(174, 41)
        Me.btnNewRecord.TabIndex = 0
        Me.btnNewRecord.Text = "&Refresh"
        Me.btnNewRecord.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(501, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 18)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Search Hostelers"
        '
        'txtHosteler
        '
        Me.txtHosteler.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHosteler.Location = New System.Drawing.Point(502, 42)
        Me.txtHosteler.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHosteler.Multiline = True
        Me.txtHosteler.Name = "txtHosteler"
        Me.txtHosteler.Size = New System.Drawing.Size(170, 30)
        Me.txtHosteler.TabIndex = 81
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridView2.Location = New System.Drawing.Point(504, 80)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView2.Size = New System.Drawing.Size(393, 494)
        Me.DataGridView2.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Hosteler ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hosteler Name"
        '
        'txtHostelerName
        '
        Me.txtHostelerName.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHostelerName.Location = New System.Drawing.Point(152, 57)
        Me.txtHostelerName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHostelerName.Name = "txtHostelerName"
        Me.txtHostelerName.ReadOnly = True
        Me.txtHostelerName.Size = New System.Drawing.Size(317, 24)
        Me.txtHostelerName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Hostel Name"
        '
        'txtHostelName
        '
        Me.txtHostelName.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHostelName.Location = New System.Drawing.Point(152, 89)
        Me.txtHostelName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHostelName.Name = "txtHostelName"
        Me.txtHostelName.ReadOnly = True
        Me.txtHostelName.Size = New System.Drawing.Size(317, 24)
        Me.txtHostelName.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Room No."
        '
        'txtRoomNo
        '
        Me.txtRoomNo.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomNo.Location = New System.Drawing.Point(152, 121)
        Me.txtRoomNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRoomNo.Name = "txtRoomNo"
        Me.txtRoomNo.ReadOnly = True
        Me.txtRoomNo.Size = New System.Drawing.Size(116, 24)
        Me.txtRoomNo.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "CheckOut  Date"
        '
        'dtpPaymentDate
        '
        Me.dtpPaymentDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpPaymentDate.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPaymentDate.Location = New System.Drawing.Point(152, 185)
        Me.dtpPaymentDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpPaymentDate.Name = "dtpPaymentDate"
        Me.dtpPaymentDate.Size = New System.Drawing.Size(156, 24)
        Me.dtpPaymentDate.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 161)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 18)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Academic Year"
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.groupBox1.Controls.Add(Me.txtAcadYear)
        Me.groupBox1.Controls.Add(Me.txtHostelerID)
        Me.groupBox1.Controls.Add(Me.Label13)
        Me.groupBox1.Controls.Add(Me.dtpPaymentDate)
        Me.groupBox1.Controls.Add(Me.Label2)
        Me.groupBox1.Controls.Add(Me.Label5)
        Me.groupBox1.Controls.Add(Me.txtTotalDueAmount)
        Me.groupBox1.Controls.Add(Me.txtRoomNo)
        Me.groupBox1.Controls.Add(Me.Label7)
        Me.groupBox1.Controls.Add(Me.txtHostelName)
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Controls.Add(Me.txtHostelerName)
        Me.groupBox1.Controls.Add(Me.Label3)
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.Black
        Me.groupBox1.Location = New System.Drawing.Point(10, 80)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox1.Size = New System.Drawing.Size(486, 341)
        Me.groupBox1.TabIndex = 78
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Registration Charges Info"
        '
        'txtAcadYear
        '
        Me.txtAcadYear.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcadYear.Location = New System.Drawing.Point(152, 153)
        Me.txtAcadYear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAcadYear.Name = "txtAcadYear"
        Me.txtAcadYear.ReadOnly = True
        Me.txtAcadYear.Size = New System.Drawing.Size(116, 24)
        Me.txtAcadYear.TabIndex = 28
        '
        'txtHostelerID
        '
        Me.txtHostelerID.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHostelerID.Location = New System.Drawing.Point(152, 25)
        Me.txtHostelerID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHostelerID.Name = "txtHostelerID"
        Me.txtHostelerID.ReadOnly = True
        Me.txtHostelerID.Size = New System.Drawing.Size(184, 24)
        Me.txtHostelerID.TabIndex = 27
        '
        'txtTotalDueAmount
        '
        Me.txtTotalDueAmount.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDueAmount.Location = New System.Drawing.Point(295, 264)
        Me.txtTotalDueAmount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalDueAmount.Name = "txtTotalDueAmount"
        Me.txtTotalDueAmount.ReadOnly = True
        Me.txtTotalDueAmount.Size = New System.Drawing.Size(153, 47)
        Me.txtTotalDueAmount.TabIndex = 83
        Me.txtTotalDueAmount.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 28)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Due Amount Remaining"
        Me.Label2.Visible = False
        '
        'txtNoOfBeds
        '
        Me.txtNoOfBeds.Location = New System.Drawing.Point(181, 22)
        Me.txtNoOfBeds.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNoOfBeds.Name = "txtNoOfBeds"
        Me.txtNoOfBeds.ReadOnly = True
        Me.txtNoOfBeds.Size = New System.Drawing.Size(153, 24)
        Me.txtNoOfBeds.TabIndex = 84
        Me.txtNoOfBeds.Visible = False
        '
        'txtBedAvailable
        '
        Me.txtBedAvailable.Location = New System.Drawing.Point(10, 22)
        Me.txtBedAvailable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBedAvailable.Name = "txtBedAvailable"
        Me.txtBedAvailable.ReadOnly = True
        Me.txtBedAvailable.Size = New System.Drawing.Size(153, 24)
        Me.txtBedAvailable.TabIndex = 85
        Me.txtBedAvailable.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(671, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(161, 18)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "Search Hostelers By USN"
        '
        'txtUSN
        '
        Me.txtUSN.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUSN.Location = New System.Drawing.Point(675, 41)
        Me.txtUSN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUSN.Multiline = True
        Me.txtUSN.Name = "txtUSN"
        Me.txtUSN.Size = New System.Drawing.Size(184, 31)
        Me.txtUSN.TabIndex = 86
        '
        'frmCheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(908, 586)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtUSN)
        Me.Controls.Add(Me.txtBedAvailable)
        Me.Controls.Add(Me.txtNoOfBeds)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtHosteler)
        Me.Controls.Add(Me.DataGridView2)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(130, 30)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCheckOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CheckOut"
        Me.panel1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents panel1 As System.Windows.Forms.Panel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents btnNewRecord As System.Windows.Forms.Button
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtHosteler As System.Windows.Forms.TextBox
    Private WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHostelerName As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtHostelName As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRoomNo As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpPaymentDate As System.Windows.Forms.DateTimePicker
    Private WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalDueAmount As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoOfBeds As System.Windows.Forms.TextBox
    Friend WithEvents txtBedAvailable As System.Windows.Forms.TextBox
    Friend WithEvents txtHostelerID As System.Windows.Forms.TextBox
    Friend WithEvents txtAcadYear As System.Windows.Forms.TextBox
    Private WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtUSN As System.Windows.Forms.TextBox
End Class
