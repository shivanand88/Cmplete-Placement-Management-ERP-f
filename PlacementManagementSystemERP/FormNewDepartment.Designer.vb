<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewDepartment
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNewDepartment))
        Me.grpDepartment = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDID = New System.Windows.Forms.TextBox()
        Me.txtDummyDept = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnResetDep = New System.Windows.Forms.Button()
        Me.btnDeleteDep = New System.Windows.Forms.Button()
        Me.btnUpdateDep = New System.Windows.Forms.Button()
        Me.btnSaveDep = New System.Windows.Forms.Button()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.grpDepartment.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDepartment
        '
        Me.grpDepartment.Controls.Add(Me.DataGridView2)
        Me.grpDepartment.Controls.Add(Me.Label2)
        Me.grpDepartment.Controls.Add(Me.txtDID)
        Me.grpDepartment.Controls.Add(Me.txtDummyDept)
        Me.grpDepartment.Controls.Add(Me.Label1)
        Me.grpDepartment.Controls.Add(Me.GroupBox3)
        Me.grpDepartment.Controls.Add(Me.txtDepartment)
        Me.grpDepartment.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDepartment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpDepartment.Location = New System.Drawing.Point(7, 16)
        Me.grpDepartment.Name = "grpDepartment"
        Me.grpDepartment.Size = New System.Drawing.Size(479, 295)
        Me.grpDepartment.TabIndex = 5
        Me.grpDepartment.TabStop = False
        Me.grpDepartment.Text = "Department  Entry"
        '
        'DataGridView2
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.OldLace
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.Location = New System.Drawing.Point(251, 17)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(222, 260)
        Me.DataGridView2.TabIndex = 102
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(15, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 18)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Old Department Name"
        '
        'txtDID
        '
        Me.txtDID.Enabled = False
        Me.txtDID.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDID.Location = New System.Drawing.Point(165, 17)
        Me.txtDID.Multiline = True
        Me.txtDID.Name = "txtDID"
        Me.txtDID.Size = New System.Drawing.Size(80, 24)
        Me.txtDID.TabIndex = 99
        Me.txtDID.Visible = False
        '
        'txtDummyDept
        '
        Me.txtDummyDept.Enabled = False
        Me.txtDummyDept.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDummyDept.Location = New System.Drawing.Point(18, 61)
        Me.txtDummyDept.Multiline = True
        Me.txtDummyDept.Name = "txtDummyDept"
        Me.txtDummyDept.Size = New System.Drawing.Size(166, 24)
        Me.txtDummyDept.TabIndex = 96
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(15, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 18)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "New Department Name"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox3.Controls.Add(Me.btnResetDep)
        Me.GroupBox3.Controls.Add(Me.btnDeleteDep)
        Me.GroupBox3.Controls.Add(Me.btnUpdateDep)
        Me.GroupBox3.Controls.Add(Me.btnSaveDep)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(15, 166)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(230, 111)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " Controls"
        '
        'btnResetDep
        '
        Me.btnResetDep.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnResetDep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnResetDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetDep.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetDep.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.Refresh_icon5
        Me.btnResetDep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResetDep.Location = New System.Drawing.Point(9, 21)
        Me.btnResetDep.Name = "btnResetDep"
        Me.btnResetDep.Size = New System.Drawing.Size(101, 39)
        Me.btnResetDep.TabIndex = 0
        Me.btnResetDep.Text = "RESET"
        Me.btnResetDep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnResetDep.UseVisualStyleBackColor = False
        '
        'btnDeleteDep
        '
        Me.btnDeleteDep.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnDeleteDep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDeleteDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteDep.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteDep.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.delete5
        Me.btnDeleteDep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteDep.Location = New System.Drawing.Point(124, 66)
        Me.btnDeleteDep.Name = "btnDeleteDep"
        Me.btnDeleteDep.Size = New System.Drawing.Size(96, 39)
        Me.btnDeleteDep.TabIndex = 3
        Me.btnDeleteDep.Text = "DELETE"
        Me.btnDeleteDep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteDep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteDep.UseVisualStyleBackColor = False
        '
        'btnUpdateDep
        '
        Me.btnUpdateDep.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnUpdateDep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUpdateDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateDep.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateDep.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.update3
        Me.btnUpdateDep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateDep.Location = New System.Drawing.Point(9, 66)
        Me.btnUpdateDep.Name = "btnUpdateDep"
        Me.btnUpdateDep.Size = New System.Drawing.Size(101, 39)
        Me.btnUpdateDep.TabIndex = 2
        Me.btnUpdateDep.Text = " UPDATE"
        Me.btnUpdateDep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdateDep.UseVisualStyleBackColor = False
        '
        'btnSaveDep
        '
        Me.btnSaveDep.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSaveDep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSaveDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveDep.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveDep.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.save2
        Me.btnSaveDep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveDep.Location = New System.Drawing.Point(124, 21)
        Me.btnSaveDep.Name = "btnSaveDep"
        Me.btnSaveDep.Size = New System.Drawing.Size(96, 39)
        Me.btnSaveDep.TabIndex = 1
        Me.btnSaveDep.Text = " SAVE"
        Me.btnSaveDep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveDep.UseVisualStyleBackColor = False
        '
        'txtDepartment
        '
        Me.txtDepartment.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDepartment.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment.Location = New System.Drawing.Point(18, 110)
        Me.txtDepartment.Multiline = True
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(166, 24)
        Me.txtDepartment.TabIndex = 94
        '
        'FormNewDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(493, 328)
        Me.Controls.Add(Me.grpDepartment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormNewDepartment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Department"
        Me.grpDepartment.ResumeLayout(False)
        Me.grpDepartment.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDepartment As System.Windows.Forms.GroupBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDID As System.Windows.Forms.TextBox
    Friend WithEvents txtDummyDept As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnResetDep As System.Windows.Forms.Button
    Friend WithEvents btnDeleteDep As System.Windows.Forms.Button
    Friend WithEvents btnUpdateDep As System.Windows.Forms.Button
    Friend WithEvents btnSaveDep As System.Windows.Forms.Button
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
End Class
