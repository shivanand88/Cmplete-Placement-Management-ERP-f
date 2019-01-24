<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPlacementReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPlacementReport))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbBatch1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnReset1 = New System.Windows.Forms.Button()
        Me.btnExportExcel1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbCompanyName1 = New System.Windows.Forms.ComboBox()
        Me.btnGetDataBatch = New System.Windows.Forms.Button()
        Me.btnReset3 = New System.Windows.Forms.Button()
        Me.btnExpoerExcel3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbBatch2 = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbBatch5 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGetDataBranch = New System.Windows.Forms.Button()
        Me.btnReset2 = New System.Windows.Forms.Button()
        Me.btnExportExcel2 = New System.Windows.Forms.Button()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnGetAll = New System.Windows.Forms.Button()
        Me.btnReset8 = New System.Windows.Forms.Button()
        Me.btnExportExcelAll = New System.Windows.Forms.Button()
        Me.DataGridView8 = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1189, 755)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1181, 724)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "By Batch"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmbBatch1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.btnReset1)
        Me.Panel1.Controls.Add(Me.btnExportExcel1)
        Me.Panel1.Location = New System.Drawing.Point(3, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 59)
        Me.Panel1.TabIndex = 134
        '
        'cmbBatch1
        '
        Me.cmbBatch1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbBatch1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBatch1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBatch1.FormattingEnabled = True
        Me.cmbBatch1.Location = New System.Drawing.Point(13, 28)
        Me.cmbBatch1.Name = "cmbBatch1"
        Me.cmbBatch1.Size = New System.Drawing.Size(172, 26)
        Me.cmbBatch1.TabIndex = 94
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(10, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 18)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Batch"
        '
        'btnReset1
        '
        Me.btnReset1.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnReset1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReset1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset1.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.Refresh_icon7
        Me.btnReset1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset1.Location = New System.Drawing.Point(196, 9)
        Me.btnReset1.Name = "btnReset1"
        Me.btnReset1.Size = New System.Drawing.Size(80, 45)
        Me.btnReset1.TabIndex = 93
        Me.btnReset1.Text = "&Reset"
        Me.btnReset1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset1.UseVisualStyleBackColor = False
        '
        'btnExportExcel1
        '
        Me.btnExportExcel1.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnExportExcel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExportExcel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportExcel1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel1.Image = Global.SGBITPlacementManagementSystem.My.Resources.Resources.Excel_icon4
        Me.btnExportExcel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportExcel1.Location = New System.Drawing.Point(282, 9)
        Me.btnExportExcel1.Name = "btnExportExcel1"
        Me.btnExportExcel1.Size = New System.Drawing.Size(115, 45)
        Me.btnExportExcel1.TabIndex = 2
        Me.btnExportExcel1.Text = "&Export Excel"
        Me.btnExportExcel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportExcel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportExcel1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.OldLace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1175, 654)
        Me.DataGridView1.TabIndex = 133
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1181, 724)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "By Batch & Company"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.cmbCompanyName1)
        Me.Panel3.Controls.Add(Me.btnGetDataBatch)
        Me.Panel3.Controls.Add(Me.btnReset3)
        Me.Panel3.Controls.Add(Me.btnExpoerExcel3)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.cmbBatch2)
        Me.Panel3.Location = New System.Drawing.Point(3, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(803, 59)
        Me.Panel3.TabIndex = 136
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(190, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 18)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "Company Name"
        '
        'cmbCompanyName1
        '
        Me.cmbCompanyName1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCompanyName1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCompanyName1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCompanyName1.FormattingEnabled = True
        Me.cmbCompanyName1.Location = New System.Drawing.Point(193, 28)
        Me.cmbCompanyName1.Name = "cmbCompanyName1"
        Me.cmbCompanyName1.Size = New System.Drawing.Size(284, 26)
        Me.cmbCompanyName1.TabIndex = 102
        '
        'btnGetDataBatch
        '
        Me.btnGetDataBatch.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnGetDataBatch.BackgroundImage = Global.SGBITPlacementManagementSystem.My.Resources.Resources.Ok_icon1
        Me.btnGetDataBatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGetDataBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetDataBatch.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDataBatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGetDataBatch.Location = New System.Drawing.Point(482, 9)
        Me.btnGetDataBatch.Name = "btnGetDataBatch"
        Me.btnGetDataBatch.Size = New System.Drawing.Size(110, 45)
        Me.btnGetDataBatch.TabIndex = 101
        Me.btnGetDataBatch.Text = "&Get Data"
        Me.btnGetDataBatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGetDataBatch.UseVisualStyleBackColor = False
        '
        'btnReset3
        '
        Me.btnReset3.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnReset3.BackgroundImage = Global.SGBITPlacementManagementSystem.My.Resources.Resources.Ok_icon1
        Me.btnReset3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReset3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset3.Location = New System.Drawing.Point(598, 9)
        Me.btnReset3.Name = "btnReset3"
        Me.btnReset3.Size = New System.Drawing.Size(80, 45)
        Me.btnReset3.TabIndex = 100
        Me.btnReset3.Text = "&Reset"
        Me.btnReset3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset3.UseVisualStyleBackColor = False
        '
        'btnExpoerExcel3
        '
        Me.btnExpoerExcel3.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnExpoerExcel3.BackgroundImage = Global.SGBITPlacementManagementSystem.My.Resources.Resources.Excel_icon
        Me.btnExpoerExcel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExpoerExcel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpoerExcel3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpoerExcel3.Location = New System.Drawing.Point(684, 10)
        Me.btnExpoerExcel3.Name = "btnExpoerExcel3"
        Me.btnExpoerExcel3.Size = New System.Drawing.Size(111, 45)
        Me.btnExpoerExcel3.TabIndex = 99
        Me.btnExpoerExcel3.Text = "&Export Excel"
        Me.btnExpoerExcel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExpoerExcel3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExpoerExcel3.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(12, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Batch"
        '
        'cmbBatch2
        '
        Me.cmbBatch2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbBatch2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBatch2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBatch2.FormattingEnabled = True
        Me.cmbBatch2.Location = New System.Drawing.Point(15, 28)
        Me.cmbBatch2.Name = "cmbBatch2"
        Me.cmbBatch2.Size = New System.Drawing.Size(172, 26)
        Me.cmbBatch2.TabIndex = 7
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.OldLace
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView2.Location = New System.Drawing.Point(3, 70)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1175, 651)
        Me.DataGridView2.TabIndex = 134
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Controls.Add(Me.DataGridView3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1181, 724)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "By Department"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cmbBatch5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnGetDataBranch)
        Me.Panel2.Controls.Add(Me.btnReset2)
        Me.Panel2.Controls.Add(Me.btnExportExcel2)
        Me.Panel2.Controls.Add(Me.cmbBranch)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(3, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(688, 62)
        Me.Panel2.TabIndex = 135
        '
        'cmbBatch5
        '
        Me.cmbBatch5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbBatch5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBatch5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBatch5.FormattingEnabled = True
        Me.cmbBatch5.Location = New System.Drawing.Point(3, 28)
        Me.cmbBatch5.Name = "cmbBatch5"
        Me.cmbBatch5.Size = New System.Drawing.Size(172, 26)
        Me.cmbBatch5.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(0, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 18)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Batch"
        '
        'btnGetDataBranch
        '
        Me.btnGetDataBranch.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnGetDataBranch.BackgroundImage = Global.SGBITPlacementManagementSystem.My.Resources.Resources.Ok_icon1
        Me.btnGetDataBranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGetDataBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetDataBranch.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDataBranch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGetDataBranch.Location = New System.Drawing.Point(359, 9)
        Me.btnGetDataBranch.Name = "btnGetDataBranch"
        Me.btnGetDataBranch.Size = New System.Drawing.Size(110, 45)
        Me.btnGetDataBranch.TabIndex = 101
        Me.btnGetDataBranch.Text = "&Get Data"
        Me.btnGetDataBranch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGetDataBranch.UseVisualStyleBackColor = False
        '
        'btnReset2
        '
        Me.btnReset2.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnReset2.BackgroundImage = Global.SGBITPlacementManagementSystem.My.Resources.Resources.Ok_icon1
        Me.btnReset2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReset2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset2.Location = New System.Drawing.Point(475, 9)
        Me.btnReset2.Name = "btnReset2"
        Me.btnReset2.Size = New System.Drawing.Size(80, 45)
        Me.btnReset2.TabIndex = 100
        Me.btnReset2.Text = "&Reset"
        Me.btnReset2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset2.UseVisualStyleBackColor = False
        '
        'btnExportExcel2
        '
        Me.btnExportExcel2.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnExportExcel2.BackgroundImage = Global.SGBITPlacementManagementSystem.My.Resources.Resources.Excel_icon
        Me.btnExportExcel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExportExcel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportExcel2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel2.Location = New System.Drawing.Point(561, 9)
        Me.btnExportExcel2.Name = "btnExportExcel2"
        Me.btnExportExcel2.Size = New System.Drawing.Size(111, 45)
        Me.btnExportExcel2.TabIndex = 99
        Me.btnExportExcel2.Text = "&Export Excel"
        Me.btnExportExcel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportExcel2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportExcel2.UseVisualStyleBackColor = False
        '
        'cmbBranch
        '
        Me.cmbBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBranch.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Location = New System.Drawing.Point(181, 28)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(172, 26)
        Me.cmbBranch.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(178, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Select Branch"
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.OldLace
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView3.Location = New System.Drawing.Point(3, 71)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(1175, 650)
        Me.DataGridView3.TabIndex = 134
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TabPage5.Controls.Add(Me.Panel6)
        Me.TabPage5.Controls.Add(Me.DataGridView8)
        Me.TabPage5.Location = New System.Drawing.Point(4, 27)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1181, 724)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "All Records"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.btnGetAll)
        Me.Panel6.Controls.Add(Me.btnReset8)
        Me.Panel6.Controls.Add(Me.btnExportExcelAll)
        Me.Panel6.Location = New System.Drawing.Point(3, 6)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(329, 59)
        Me.Panel6.TabIndex = 139
        '
        'btnGetAll
        '
        Me.btnGetAll.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnGetAll.BackgroundImage = Global.SGBITPlacementManagementSystem.My.Resources.Resources.Ok_icon1
        Me.btnGetAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetAll.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGetAll.Location = New System.Drawing.Point(7, 8)
        Me.btnGetAll.Name = "btnGetAll"
        Me.btnGetAll.Size = New System.Drawing.Size(110, 45)
        Me.btnGetAll.TabIndex = 101
        Me.btnGetAll.Text = "&Get Data"
        Me.btnGetAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGetAll.UseVisualStyleBackColor = False
        '
        'btnReset8
        '
        Me.btnReset8.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnReset8.BackgroundImage = Global.SGBITPlacementManagementSystem.My.Resources.Resources.Ok_icon1
        Me.btnReset8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReset8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset8.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset8.Location = New System.Drawing.Point(123, 8)
        Me.btnReset8.Name = "btnReset8"
        Me.btnReset8.Size = New System.Drawing.Size(80, 45)
        Me.btnReset8.TabIndex = 100
        Me.btnReset8.Text = "&Reset"
        Me.btnReset8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset8.UseVisualStyleBackColor = False
        '
        'btnExportExcelAll
        '
        Me.btnExportExcelAll.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnExportExcelAll.BackgroundImage = Global.SGBITPlacementManagementSystem.My.Resources.Resources.Excel_icon
        Me.btnExportExcelAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExportExcelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportExcelAll.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcelAll.Location = New System.Drawing.Point(209, 9)
        Me.btnExportExcelAll.Name = "btnExportExcelAll"
        Me.btnExportExcelAll.Size = New System.Drawing.Size(111, 45)
        Me.btnExportExcelAll.TabIndex = 99
        Me.btnExportExcelAll.Text = "&Export Excel"
        Me.btnExportExcelAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportExcelAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportExcelAll.UseVisualStyleBackColor = False
        '
        'DataGridView8
        '
        Me.DataGridView8.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView8.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView8.BackgroundColor = System.Drawing.Color.OldLace
        Me.DataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView8.Location = New System.Drawing.Point(3, 69)
        Me.DataGridView8.Name = "DataGridView8"
        Me.DataGridView8.Size = New System.Drawing.Size(1175, 652)
        Me.DataGridView8.TabIndex = 134
        '
        'FormPlacementReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 764)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPlacementReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Placement Report"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnReset1 As System.Windows.Forms.Button
    Friend WithEvents btnExportExcel1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbCompanyName1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnGetDataBatch As System.Windows.Forms.Button
    Friend WithEvents btnReset3 As System.Windows.Forms.Button
    Friend WithEvents btnExpoerExcel3 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbBatch2 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnGetDataBranch As System.Windows.Forms.Button
    Friend WithEvents btnReset2 As System.Windows.Forms.Button
    Friend WithEvents btnExportExcel2 As System.Windows.Forms.Button
    Friend WithEvents cmbBranch As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnGetAll As System.Windows.Forms.Button
    Friend WithEvents btnReset8 As System.Windows.Forms.Button
    Friend WithEvents btnExportExcelAll As System.Windows.Forms.Button
    Friend WithEvents DataGridView8 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbBatch1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbBatch5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
