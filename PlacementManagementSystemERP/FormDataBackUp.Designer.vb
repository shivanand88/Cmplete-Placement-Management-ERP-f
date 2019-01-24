<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataBackUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataBackUp))
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnrestore = New System.Windows.Forms.Button()
        Me.btnbackup = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblTO = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox2.Controls.Add(Me.btnrestore)
        Me.GroupBox2.Controls.Add(Me.btnbackup)
        Me.GroupBox2.Controls.Add(Me.btnBrowse)
        Me.GroupBox2.Controls.Add(Me.lblTO)
        Me.GroupBox2.Controls.Add(Me.lblFrom)
        Me.GroupBox2.Controls.Add(Me.txtDestination)
        Me.GroupBox2.Controls.Add(Me.txtLocation)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(32, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 172)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Database Backup and Restore"
        '
        'btnrestore
        '
        Me.btnrestore.BackColor = System.Drawing.Color.SpringGreen
        Me.btnrestore.BackgroundImage = Global.SGBITPlacementManagementSystem.My.Resources.Resources.data
        Me.btnrestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnrestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrestore.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrestore.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnrestore.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnrestore.Location = New System.Drawing.Point(244, 110)
        Me.btnrestore.Name = "btnrestore"
        Me.btnrestore.Size = New System.Drawing.Size(164, 40)
        Me.btnrestore.TabIndex = 6
        Me.btnrestore.Text = "Restore Backup"
        Me.btnrestore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnrestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnrestore.UseVisualStyleBackColor = False
        '
        'btnbackup
        '
        Me.btnbackup.BackColor = System.Drawing.Color.SpringGreen
        Me.btnbackup.BackgroundImage = Global.SGBITPlacementManagementSystem.My.Resources.Resources.training
        Me.btnbackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnbackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbackup.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbackup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnbackup.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnbackup.Location = New System.Drawing.Point(83, 110)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(155, 40)
        Me.btnbackup.TabIndex = 5
        Me.btnbackup.Text = "Create Backup"
        Me.btnbackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnbackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnbackup.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.SpringGreen
        Me.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBrowse.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBrowse.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.Search_icon1
        Me.btnBrowse.Location = New System.Drawing.Point(413, 40)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(101, 54)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'lblTO
        '
        Me.lblTO.AutoSize = True
        Me.lblTO.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTO.Location = New System.Drawing.Point(15, 76)
        Me.lblTO.Name = "lblTO"
        Me.lblTO.Size = New System.Drawing.Size(35, 18)
        Me.lblTO.TabIndex = 3
        Me.lblTO.Text = "To  :"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(15, 45)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(48, 18)
        Me.lblFrom.TabIndex = 2
        Me.lblFrom.Text = "From :"
        '
        'txtDestination
        '
        Me.txtDestination.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestination.Location = New System.Drawing.Point(83, 70)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(324, 25)
        Me.txtDestination.TabIndex = 1
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(83, 41)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(325, 25)
        Me.txtLocation.TabIndex = 0
        '
        'FormDataBackUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(631, 208)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDataBackUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataBackUp"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnrestore As System.Windows.Forms.Button
    Friend WithEvents btnbackup As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblTO As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents txtDestination As System.Windows.Forms.TextBox
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
End Class
