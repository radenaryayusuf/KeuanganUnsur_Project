<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FData_Keuangan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FData_Keuangan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbsubkategori = New System.Windows.Forms.ComboBox()
        Me.label_sub = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cbkategori = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bt_print = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_exit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_tambahkan = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_edit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_cancel = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_save = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tanggal_pertama = New System.Windows.Forms.DateTimePicker()
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tanggal_kedua = New System.Windows.Forms.DateTimePicker()
        Me.nav = New System.Windows.Forms.Panel()
        Me.BunifuImageButton6 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tcari = New System.Windows.Forms.TextBox()
        Me.lblStatus = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton7 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton8 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton10 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton11 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.header = New System.Windows.Forms.Panel()
        Me.bt_min = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.dgv = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuCheckbox2 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btmulaiawal = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.bt_print, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_tambahkan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_save, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nav.SuspendLayout()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.header.SuspendLayout()
        CType(Me.bt_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbsubkategori
        '
        Me.cbsubkategori.FormattingEnabled = True
        Me.cbsubkategori.Location = New System.Drawing.Point(132, 445)
        Me.cbsubkategori.Name = "cbsubkategori"
        Me.cbsubkategori.Size = New System.Drawing.Size(117, 21)
        Me.cbsubkategori.TabIndex = 108
        '
        'label_sub
        '
        Me.label_sub.AutoSize = True
        Me.label_sub.Location = New System.Drawing.Point(58, 448)
        Me.label_sub.Name = "label_sub"
        Me.label_sub.Size = New System.Drawing.Size(68, 13)
        Me.label_sub.TabIndex = 107
        Me.label_sub.Text = "Sub Kategori"
        '
        'cbkategori
        '
        Me.cbkategori.FormattingEnabled = True
        Me.cbkategori.Location = New System.Drawing.Point(132, 421)
        Me.cbkategori.Name = "cbkategori"
        Me.cbkategori.Size = New System.Drawing.Size(117, 21)
        Me.cbkategori.TabIndex = 106
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(58, 424)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(46, 13)
        Me.BunifuCustomLabel10.TabIndex = 105
        Me.BunifuCustomLabel10.Text = "Kategori"
        '
        'bt_print
        '
        Me.bt_print.BackColor = System.Drawing.Color.White
        Me.bt_print.Image = CType(resources.GetObject("bt_print.Image"), System.Drawing.Image)
        Me.bt_print.ImageActive = Nothing
        Me.bt_print.Location = New System.Drawing.Point(602, 74)
        Me.bt_print.Name = "bt_print"
        Me.bt_print.Size = New System.Drawing.Size(44, 39)
        Me.bt_print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_print.TabIndex = 98
        Me.bt_print.TabStop = False
        Me.bt_print.Zoom = 10
        '
        'bt_exit
        '
        Me.bt_exit.BackColor = System.Drawing.Color.White
        Me.bt_exit.Image = CType(resources.GetObject("bt_exit.Image"), System.Drawing.Image)
        Me.bt_exit.ImageActive = Nothing
        Me.bt_exit.Location = New System.Drawing.Point(539, 74)
        Me.bt_exit.Name = "bt_exit"
        Me.bt_exit.Size = New System.Drawing.Size(44, 39)
        Me.bt_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_exit.TabIndex = 97
        Me.bt_exit.TabStop = False
        Me.bt_exit.Zoom = 10
        '
        'bt_tambahkan
        '
        Me.bt_tambahkan.BackColor = System.Drawing.Color.White
        Me.bt_tambahkan.Image = CType(resources.GetObject("bt_tambahkan.Image"), System.Drawing.Image)
        Me.bt_tambahkan.ImageActive = Nothing
        Me.bt_tambahkan.Location = New System.Drawing.Point(479, 74)
        Me.bt_tambahkan.Name = "bt_tambahkan"
        Me.bt_tambahkan.Size = New System.Drawing.Size(44, 39)
        Me.bt_tambahkan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_tambahkan.TabIndex = 96
        Me.bt_tambahkan.TabStop = False
        Me.bt_tambahkan.Zoom = 10
        '
        'bt_edit
        '
        Me.bt_edit.BackColor = System.Drawing.Color.White
        Me.bt_edit.Image = CType(resources.GetObject("bt_edit.Image"), System.Drawing.Image)
        Me.bt_edit.ImageActive = Nothing
        Me.bt_edit.Location = New System.Drawing.Point(416, 74)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(44, 39)
        Me.bt_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_edit.TabIndex = 95
        Me.bt_edit.TabStop = False
        Me.bt_edit.Zoom = 10
        '
        'bt_cancel
        '
        Me.bt_cancel.BackColor = System.Drawing.Color.White
        Me.bt_cancel.Image = CType(resources.GetObject("bt_cancel.Image"), System.Drawing.Image)
        Me.bt_cancel.ImageActive = Nothing
        Me.bt_cancel.Location = New System.Drawing.Point(356, 74)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(44, 39)
        Me.bt_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_cancel.TabIndex = 94
        Me.bt_cancel.TabStop = False
        Me.bt_cancel.Zoom = 10
        '
        'bt_save
        '
        Me.bt_save.BackColor = System.Drawing.Color.White
        Me.bt_save.Image = CType(resources.GetObject("bt_save.Image"), System.Drawing.Image)
        Me.bt_save.ImageActive = Nothing
        Me.bt_save.Location = New System.Drawing.Point(296, 74)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.Size = New System.Drawing.Size(44, 39)
        Me.bt_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_save.TabIndex = 93
        Me.bt_save.TabStop = False
        Me.bt_save.Zoom = 10
        '
        'tanggal_pertama
        '
        Me.tanggal_pertama.Location = New System.Drawing.Point(868, 74)
        Me.tanggal_pertama.Name = "tanggal_pertama"
        Me.tanggal_pertama.Size = New System.Drawing.Size(189, 20)
        Me.tanggal_pertama.TabIndex = 112
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(745, 76)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New System.Drawing.Size(117, 14)
        Me.BunifuCustomLabel12.TabIndex = 111
        Me.BunifuCustomLabel12.Text = "Periode dari Tanggal"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(1063, 76)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(26, 14)
        Me.BunifuCustomLabel3.TabIndex = 113
        Me.BunifuCustomLabel3.Text = "s/d"
        '
        'tanggal_kedua
        '
        Me.tanggal_kedua.Location = New System.Drawing.Point(1095, 74)
        Me.tanggal_kedua.Name = "tanggal_kedua"
        Me.tanggal_kedua.Size = New System.Drawing.Size(189, 20)
        Me.tanggal_kedua.TabIndex = 114
        '
        'nav
        '
        Me.nav.BackColor = System.Drawing.Color.DarkCyan
        Me.nav.Controls.Add(Me.BunifuImageButton6)
        Me.nav.Controls.Add(Me.tcari)
        Me.nav.Controls.Add(Me.lblStatus)
        Me.nav.Controls.Add(Me.PictureBox1)
        Me.nav.Controls.Add(Me.BunifuCustomLabel2)
        Me.nav.Controls.Add(Me.BunifuImageButton7)
        Me.nav.Controls.Add(Me.BunifuImageButton8)
        Me.nav.Controls.Add(Me.cbsubkategori)
        Me.nav.Controls.Add(Me.BunifuImageButton10)
        Me.nav.Controls.Add(Me.label_sub)
        Me.nav.Controls.Add(Me.BunifuImageButton11)
        Me.nav.Controls.Add(Me.cbkategori)
        Me.nav.Controls.Add(Me.BunifuCustomLabel10)
        Me.nav.Dock = System.Windows.Forms.DockStyle.Left
        Me.nav.Location = New System.Drawing.Point(0, 0)
        Me.nav.Name = "nav"
        Me.nav.Size = New System.Drawing.Size(280, 768)
        Me.nav.TabIndex = 115
        '
        'BunifuImageButton6
        '
        Me.BunifuImageButton6.BackColor = System.Drawing.Color.DarkCyan
        Me.BunifuImageButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton6.Image = CType(resources.GetObject("BunifuImageButton6.Image"), System.Drawing.Image)
        Me.BunifuImageButton6.ImageActive = Nothing
        Me.BunifuImageButton6.Location = New System.Drawing.Point(216, 282)
        Me.BunifuImageButton6.Name = "BunifuImageButton6"
        Me.BunifuImageButton6.Size = New System.Drawing.Size(41, 32)
        Me.BunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton6.TabIndex = 125
        Me.BunifuImageButton6.TabStop = False
        Me.BunifuImageButton6.Zoom = 10
        '
        'tcari
        '
        Me.tcari.BackColor = System.Drawing.Color.DarkCyan
        Me.tcari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tcari.ForeColor = System.Drawing.Color.White
        Me.tcari.Location = New System.Drawing.Point(61, 290)
        Me.tcari.Name = "tcari"
        Me.tcari.Size = New System.Drawing.Size(150, 20)
        Me.tcari.TabIndex = 124
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblStatus.Enabled = False
        Me.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStatus.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(130, 352)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(58, 16)
        Me.lblStatus.TabIndex = 118
        Me.lblStatus.Text = "Page 0/0"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(61, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Gadugi", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(55, 9)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(201, 31)
        Me.BunifuCustomLabel2.TabIndex = 4
        Me.BunifuCustomLabel2.Text = "Data Keuangan"
        '
        'BunifuImageButton7
        '
        Me.BunifuImageButton7.BackColor = System.Drawing.Color.DarkCyan
        Me.BunifuImageButton7.Image = CType(resources.GetObject("BunifuImageButton7.Image"), System.Drawing.Image)
        Me.BunifuImageButton7.ImageActive = Nothing
        Me.BunifuImageButton7.Location = New System.Drawing.Point(47, 344)
        Me.BunifuImageButton7.Name = "BunifuImageButton7"
        Me.BunifuImageButton7.Size = New System.Drawing.Size(34, 32)
        Me.BunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton7.TabIndex = 83
        Me.BunifuImageButton7.TabStop = False
        Me.BunifuImageButton7.Zoom = 10
        '
        'BunifuImageButton8
        '
        Me.BunifuImageButton8.BackColor = System.Drawing.Color.DarkCyan
        Me.BunifuImageButton8.Image = CType(resources.GetObject("BunifuImageButton8.Image"), System.Drawing.Image)
        Me.BunifuImageButton8.ImageActive = Nothing
        Me.BunifuImageButton8.Location = New System.Drawing.Point(87, 344)
        Me.BunifuImageButton8.Name = "BunifuImageButton8"
        Me.BunifuImageButton8.Size = New System.Drawing.Size(34, 32)
        Me.BunifuImageButton8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton8.TabIndex = 84
        Me.BunifuImageButton8.TabStop = False
        Me.BunifuImageButton8.Zoom = 10
        '
        'BunifuImageButton10
        '
        Me.BunifuImageButton10.BackColor = System.Drawing.Color.DarkCyan
        Me.BunifuImageButton10.Image = CType(resources.GetObject("BunifuImageButton10.Image"), System.Drawing.Image)
        Me.BunifuImageButton10.ImageActive = Nothing
        Me.BunifuImageButton10.Location = New System.Drawing.Point(195, 344)
        Me.BunifuImageButton10.Name = "BunifuImageButton10"
        Me.BunifuImageButton10.Size = New System.Drawing.Size(34, 32)
        Me.BunifuImageButton10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton10.TabIndex = 85
        Me.BunifuImageButton10.TabStop = False
        Me.BunifuImageButton10.Zoom = 10
        '
        'BunifuImageButton11
        '
        Me.BunifuImageButton11.BackColor = System.Drawing.Color.DarkCyan
        Me.BunifuImageButton11.Image = CType(resources.GetObject("BunifuImageButton11.Image"), System.Drawing.Image)
        Me.BunifuImageButton11.ImageActive = Nothing
        Me.BunifuImageButton11.Location = New System.Drawing.Point(235, 344)
        Me.BunifuImageButton11.Name = "BunifuImageButton11"
        Me.BunifuImageButton11.Size = New System.Drawing.Size(34, 32)
        Me.BunifuImageButton11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton11.TabIndex = 86
        Me.BunifuImageButton11.TabStop = False
        Me.BunifuImageButton11.Zoom = 10
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.DarkCyan
        Me.header.Controls.Add(Me.bt_min)
        Me.header.Controls.Add(Me.bt_close)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(280, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1086, 51)
        Me.header.TabIndex = 116
        '
        'bt_min
        '
        Me.bt_min.BackColor = System.Drawing.Color.DarkCyan
        Me.bt_min.Image = CType(resources.GetObject("bt_min.Image"), System.Drawing.Image)
        Me.bt_min.ImageActive = Nothing
        Me.bt_min.Location = New System.Drawing.Point(982, 0)
        Me.bt_min.Name = "bt_min"
        Me.bt_min.Size = New System.Drawing.Size(52, 51)
        Me.bt_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_min.TabIndex = 2
        Me.bt_min.TabStop = False
        Me.bt_min.Zoom = 10
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.Color.DarkCyan
        Me.bt_close.Image = CType(resources.GetObject("bt_close.Image"), System.Drawing.Image)
        Me.bt_close.ImageActive = Nothing
        Me.bt_close.Location = New System.Drawing.Point(1034, 0)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(52, 51)
        Me.bt_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_close.TabIndex = 0
        Me.bt_close.TabStop = False
        Me.bt_close.Zoom = 10
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.header
        Me.BunifuDragControl1.Vertical = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.DoubleBuffered = True
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.HeaderBgColor = System.Drawing.Color.DarkCyan
        Me.dgv.HeaderForeColor = System.Drawing.Color.SeaShell
        Me.dgv.Location = New System.Drawing.Point(280, 131)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv.Size = New System.Drawing.Size(1086, 637)
        Me.dgv.TabIndex = 117
        '
        'BunifuCheckbox2
        '
        Me.BunifuCheckbox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox2.Checked = False
        Me.BunifuCheckbox2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox2.ForeColor = System.Drawing.Color.White
        Me.BunifuCheckbox2.Location = New System.Drawing.Point(748, 93)
        Me.BunifuCheckbox2.Name = "BunifuCheckbox2"
        Me.BunifuCheckbox2.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox2.TabIndex = 119
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(774, 97)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(111, 14)
        Me.BunifuCustomLabel1.TabIndex = 120
        Me.BunifuCustomLabel1.Text = "Batasi akhir tanggal"
        '
        'btmulaiawal
        '
        Me.btmulaiawal.Activecolor = System.Drawing.Color.Silver
        Me.btmulaiawal.BackColor = System.Drawing.Color.Transparent
        Me.btmulaiawal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btmulaiawal.BorderRadius = 0
        Me.btmulaiawal.ButtonText = "Mulai Awal"
        Me.btmulaiawal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btmulaiawal.DisabledColor = System.Drawing.Color.Gray
        Me.btmulaiawal.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmulaiawal.Iconcolor = System.Drawing.Color.Transparent
        Me.btmulaiawal.Iconimage = Nothing
        Me.btmulaiawal.Iconimage_right = Nothing
        Me.btmulaiawal.Iconimage_right_Selected = Nothing
        Me.btmulaiawal.Iconimage_Selected = Nothing
        Me.btmulaiawal.IconMarginLeft = 0
        Me.btmulaiawal.IconMarginRight = 0
        Me.btmulaiawal.IconRightVisible = True
        Me.btmulaiawal.IconRightZoom = 0.0R
        Me.btmulaiawal.IconVisible = True
        Me.btmulaiawal.IconZoom = 90.0R
        Me.btmulaiawal.IsTab = False
        Me.btmulaiawal.Location = New System.Drawing.Point(893, 100)
        Me.btmulaiawal.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btmulaiawal.Name = "btmulaiawal"
        Me.btmulaiawal.Normalcolor = System.Drawing.Color.Transparent
        Me.btmulaiawal.OnHovercolor = System.Drawing.Color.Silver
        Me.btmulaiawal.OnHoverTextColor = System.Drawing.Color.White
        Me.btmulaiawal.selected = False
        Me.btmulaiawal.Size = New System.Drawing.Size(391, 26)
        Me.btmulaiawal.TabIndex = 176
        Me.btmulaiawal.Text = "Mulai Awal"
        Me.btmulaiawal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btmulaiawal.Textcolor = System.Drawing.Color.Black
        Me.btmulaiawal.TextFont = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FData_Keuangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.btmulaiawal)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuCheckbox2)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.tanggal_kedua)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.tanggal_pertama)
        Me.Controls.Add(Me.BunifuCustomLabel12)
        Me.Controls.Add(Me.bt_print)
        Me.Controls.Add(Me.bt_exit)
        Me.Controls.Add(Me.bt_tambahkan)
        Me.Controls.Add(Me.bt_edit)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_save)
        Me.Controls.Add(Me.nav)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FData_Keuangan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FData_Keuangan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.bt_print, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_tambahkan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_save, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nav.ResumeLayout(False)
        Me.nav.PerformLayout()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header.ResumeLayout(False)
        CType(Me.bt_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbsubkategori As System.Windows.Forms.ComboBox
    Friend WithEvents label_sub As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cbkategori As System.Windows.Forms.ComboBox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bt_print As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_exit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_tambahkan As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_edit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_cancel As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_save As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tanggal_pertama As System.Windows.Forms.DateTimePicker
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tanggal_kedua As System.Windows.Forms.DateTimePicker
    Friend WithEvents nav As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton7 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton8 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton10 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton11 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents header As System.Windows.Forms.Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents bt_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_min As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents dgv As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents lblStatus As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCheckbox2 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btmulaiawal As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuImageButton6 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tcari As System.Windows.Forms.TextBox
End Class
