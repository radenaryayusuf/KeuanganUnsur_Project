<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FNeraca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FNeraca))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bt_print = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_exit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_tambahkan = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_edit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_cancel = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_save = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tbsaldo = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbjumlahpengeluaran = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbjumlahpendapatan = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.header = New System.Windows.Forms.Panel()
        Me.bt_min = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.nav = New System.Windows.Forms.Panel()
        Me.BunifuTextbox1 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblStatus = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton7 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton8 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton10 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton11 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.dgv1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.dgv2 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.lblStatus1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.bt_print, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_tambahkan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_save, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.header.SuspendLayout()
        CType(Me.bt_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nav.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_print
        '
        Me.bt_print.BackColor = System.Drawing.Color.White
        Me.bt_print.Image = CType(resources.GetObject("bt_print.Image"), System.Drawing.Image)
        Me.bt_print.ImageActive = Nothing
        Me.bt_print.Location = New System.Drawing.Point(643, 109)
        Me.bt_print.Name = "bt_print"
        Me.bt_print.Size = New System.Drawing.Size(55, 49)
        Me.bt_print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_print.TabIndex = 124
        Me.bt_print.TabStop = False
        Me.bt_print.Zoom = 10
        '
        'bt_exit
        '
        Me.bt_exit.BackColor = System.Drawing.Color.White
        Me.bt_exit.Image = CType(resources.GetObject("bt_exit.Image"), System.Drawing.Image)
        Me.bt_exit.ImageActive = Nothing
        Me.bt_exit.Location = New System.Drawing.Point(582, 109)
        Me.bt_exit.Name = "bt_exit"
        Me.bt_exit.Size = New System.Drawing.Size(55, 49)
        Me.bt_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_exit.TabIndex = 123
        Me.bt_exit.TabStop = False
        Me.bt_exit.Zoom = 10
        '
        'bt_tambahkan
        '
        Me.bt_tambahkan.BackColor = System.Drawing.Color.White
        Me.bt_tambahkan.Image = CType(resources.GetObject("bt_tambahkan.Image"), System.Drawing.Image)
        Me.bt_tambahkan.ImageActive = Nothing
        Me.bt_tambahkan.Location = New System.Drawing.Point(520, 109)
        Me.bt_tambahkan.Name = "bt_tambahkan"
        Me.bt_tambahkan.Size = New System.Drawing.Size(55, 49)
        Me.bt_tambahkan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_tambahkan.TabIndex = 122
        Me.bt_tambahkan.TabStop = False
        Me.bt_tambahkan.Zoom = 10
        '
        'bt_edit
        '
        Me.bt_edit.BackColor = System.Drawing.Color.White
        Me.bt_edit.Image = CType(resources.GetObject("bt_edit.Image"), System.Drawing.Image)
        Me.bt_edit.ImageActive = Nothing
        Me.bt_edit.Location = New System.Drawing.Point(459, 109)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(55, 49)
        Me.bt_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_edit.TabIndex = 121
        Me.bt_edit.TabStop = False
        Me.bt_edit.Zoom = 10
        '
        'bt_cancel
        '
        Me.bt_cancel.BackColor = System.Drawing.Color.White
        Me.bt_cancel.Image = CType(resources.GetObject("bt_cancel.Image"), System.Drawing.Image)
        Me.bt_cancel.ImageActive = Nothing
        Me.bt_cancel.Location = New System.Drawing.Point(398, 109)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(55, 49)
        Me.bt_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_cancel.TabIndex = 120
        Me.bt_cancel.TabStop = False
        Me.bt_cancel.Zoom = 10
        '
        'bt_save
        '
        Me.bt_save.BackColor = System.Drawing.Color.White
        Me.bt_save.Image = CType(resources.GetObject("bt_save.Image"), System.Drawing.Image)
        Me.bt_save.ImageActive = Nothing
        Me.bt_save.Location = New System.Drawing.Point(337, 109)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.Size = New System.Drawing.Size(55, 49)
        Me.bt_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_save.TabIndex = 119
        Me.bt_save.TabStop = False
        Me.bt_save.Zoom = 10
        '
        'tbsaldo
        '
        Me.tbsaldo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tbsaldo.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.tbsaldo.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsaldo.Location = New System.Drawing.Point(100, 333)
        Me.tbsaldo.Name = "tbsaldo"
        Me.tbsaldo.Size = New System.Drawing.Size(151, 20)
        Me.tbsaldo.TabIndex = 132
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(44, 335)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(42, 15)
        Me.BunifuCustomLabel5.TabIndex = 131
        Me.BunifuCustomLabel5.Text = "Saldo"
        '
        'tbjumlahpengeluaran
        '
        Me.tbjumlahpengeluaran.BorderColor = System.Drawing.Color.SeaGreen
        Me.tbjumlahpengeluaran.Location = New System.Drawing.Point(1189, 578)
        Me.tbjumlahpengeluaran.Name = "tbjumlahpengeluaran"
        Me.tbjumlahpengeluaran.Size = New System.Drawing.Size(151, 20)
        Me.tbjumlahpengeluaran.TabIndex = 138
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(1071, 581)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(112, 14)
        Me.BunifuCustomLabel4.TabIndex = 137
        Me.BunifuCustomLabel4.Text = "Jumlah Pengeluaran"
        '
        'tbjumlahpendapatan
        '
        Me.tbjumlahpendapatan.BorderColor = System.Drawing.Color.SeaGreen
        Me.tbjumlahpendapatan.Location = New System.Drawing.Point(659, 578)
        Me.tbjumlahpendapatan.Name = "tbjumlahpendapatan"
        Me.tbjumlahpendapatan.Size = New System.Drawing.Size(151, 20)
        Me.tbjumlahpendapatan.TabIndex = 140
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(545, 581)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(108, 14)
        Me.BunifuCustomLabel6.TabIndex = 139
        Me.BunifuCustomLabel6.Text = "Jumlah Pendapatan"
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
        Me.header.TabIndex = 142
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
        'nav
        '
        Me.nav.BackColor = System.Drawing.Color.DarkCyan
        Me.nav.Controls.Add(Me.BunifuTextbox1)
        Me.nav.Controls.Add(Me.PictureBox1)
        Me.nav.Controls.Add(Me.BunifuCustomLabel7)
        Me.nav.Controls.Add(Me.tbsaldo)
        Me.nav.Controls.Add(Me.BunifuCustomLabel5)
        Me.nav.Dock = System.Windows.Forms.DockStyle.Left
        Me.nav.Location = New System.Drawing.Point(0, 0)
        Me.nav.Name = "nav"
        Me.nav.Size = New System.Drawing.Size(280, 768)
        Me.nav.TabIndex = 141
        '
        'BunifuTextbox1
        '
        Me.BunifuTextbox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BunifuTextbox1.BackgroundImage = CType(resources.GetObject("BunifuTextbox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox1.ForeColor = System.Drawing.Color.DarkCyan
        Me.BunifuTextbox1.Icon = CType(resources.GetObject("BunifuTextbox1.Icon"), System.Drawing.Image)
        Me.BunifuTextbox1.Location = New System.Drawing.Point(29, 272)
        Me.BunifuTextbox1.Name = "BunifuTextbox1"
        Me.BunifuTextbox1.Size = New System.Drawing.Size(222, 42)
        Me.BunifuTextbox1.TabIndex = 118
        Me.BunifuTextbox1.text = "Cari"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(47, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Gadugi", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(89, 9)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(99, 31)
        Me.BunifuCustomLabel7.TabIndex = 4
        Me.BunifuCustomLabel7.Text = "Neraca"
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
        Me.lblStatus.Location = New System.Drawing.Point(369, 586)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(58, 16)
        Me.lblStatus.TabIndex = 118
        Me.lblStatus.Text = "Page 0/0"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuImageButton7
        '
        Me.BunifuImageButton7.BackColor = System.Drawing.Color.Snow
        Me.BunifuImageButton7.Image = CType(resources.GetObject("BunifuImageButton7.Image"), System.Drawing.Image)
        Me.BunifuImageButton7.ImageActive = Nothing
        Me.BunifuImageButton7.Location = New System.Drawing.Point(286, 578)
        Me.BunifuImageButton7.Name = "BunifuImageButton7"
        Me.BunifuImageButton7.Size = New System.Drawing.Size(34, 32)
        Me.BunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton7.TabIndex = 83
        Me.BunifuImageButton7.TabStop = False
        Me.BunifuImageButton7.Zoom = 10
        '
        'BunifuImageButton8
        '
        Me.BunifuImageButton8.BackColor = System.Drawing.Color.Snow
        Me.BunifuImageButton8.Image = CType(resources.GetObject("BunifuImageButton8.Image"), System.Drawing.Image)
        Me.BunifuImageButton8.ImageActive = Nothing
        Me.BunifuImageButton8.Location = New System.Drawing.Point(326, 578)
        Me.BunifuImageButton8.Name = "BunifuImageButton8"
        Me.BunifuImageButton8.Size = New System.Drawing.Size(34, 32)
        Me.BunifuImageButton8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton8.TabIndex = 84
        Me.BunifuImageButton8.TabStop = False
        Me.BunifuImageButton8.Zoom = 10
        '
        'BunifuImageButton10
        '
        Me.BunifuImageButton10.BackColor = System.Drawing.Color.Snow
        Me.BunifuImageButton10.Image = CType(resources.GetObject("BunifuImageButton10.Image"), System.Drawing.Image)
        Me.BunifuImageButton10.ImageActive = Nothing
        Me.BunifuImageButton10.Location = New System.Drawing.Point(434, 578)
        Me.BunifuImageButton10.Name = "BunifuImageButton10"
        Me.BunifuImageButton10.Size = New System.Drawing.Size(34, 32)
        Me.BunifuImageButton10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton10.TabIndex = 85
        Me.BunifuImageButton10.TabStop = False
        Me.BunifuImageButton10.Zoom = 10
        '
        'BunifuImageButton11
        '
        Me.BunifuImageButton11.BackColor = System.Drawing.Color.Snow
        Me.BunifuImageButton11.Image = CType(resources.GetObject("BunifuImageButton11.Image"), System.Drawing.Image)
        Me.BunifuImageButton11.ImageActive = Nothing
        Me.BunifuImageButton11.Location = New System.Drawing.Point(474, 578)
        Me.BunifuImageButton11.Name = "BunifuImageButton11"
        Me.BunifuImageButton11.Size = New System.Drawing.Size(34, 32)
        Me.BunifuImageButton11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton11.TabIndex = 86
        Me.BunifuImageButton11.TabStop = False
        Me.BunifuImageButton11.Zoom = 10
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.DoubleBuffered = True
        Me.dgv1.EnableHeadersVisualStyles = False
        Me.dgv1.HeaderBgColor = System.Drawing.Color.DarkCyan
        Me.dgv1.HeaderForeColor = System.Drawing.Color.Honeydew
        Me.dgv1.Location = New System.Drawing.Point(286, 245)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv1.Size = New System.Drawing.Size(524, 327)
        Me.dgv1.TabIndex = 143
        '
        'dgv2
        '
        Me.dgv2.AllowUserToAddRows = False
        Me.dgv2.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv2.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgv2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.DoubleBuffered = True
        Me.dgv2.EnableHeadersVisualStyles = False
        Me.dgv2.HeaderBgColor = System.Drawing.Color.DarkCyan
        Me.dgv2.HeaderForeColor = System.Drawing.Color.Honeydew
        Me.dgv2.Location = New System.Drawing.Point(816, 245)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.ReadOnly = True
        Me.dgv2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv2.Size = New System.Drawing.Size(524, 327)
        Me.dgv2.TabIndex = 144
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.header
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.nav
        Me.BunifuDragControl2.Vertical = True
        '
        'lblStatus1
        '
        Me.lblStatus1.AutoSize = True
        Me.lblStatus1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblStatus1.Enabled = False
        Me.lblStatus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStatus1.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus1.ForeColor = System.Drawing.Color.Black
        Me.lblStatus1.Location = New System.Drawing.Point(899, 586)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(58, 16)
        Me.lblStatus1.TabIndex = 149
        Me.lblStatus1.Text = "Page 0/0"
        Me.lblStatus1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Snow
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(816, 578)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(34, 32)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 145
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Snow
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(856, 578)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(34, 32)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 146
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Snow
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(964, 578)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(34, 32)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 147
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Snow
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(1004, 578)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(34, 32)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 148
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label1.Location = New System.Drawing.Point(1033, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 14)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "Data Pengeluaran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label2.Location = New System.Drawing.Point(494, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 14)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Data Pendapatan"
        '
        'FNeraca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.BunifuImageButton2)
        Me.Controls.Add(Me.BunifuImageButton3)
        Me.Controls.Add(Me.BunifuImageButton4)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.nav)
        Me.Controls.Add(Me.BunifuImageButton7)
        Me.Controls.Add(Me.BunifuImageButton8)
        Me.Controls.Add(Me.tbjumlahpendapatan)
        Me.Controls.Add(Me.BunifuImageButton10)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.BunifuImageButton11)
        Me.Controls.Add(Me.tbjumlahpengeluaran)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.bt_print)
        Me.Controls.Add(Me.bt_exit)
        Me.Controls.Add(Me.bt_tambahkan)
        Me.Controls.Add(Me.bt_edit)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_save)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FNeraca"
        Me.RightToLeftLayout = True
        Me.Text = "FNeraca"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.bt_print, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_tambahkan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_save, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header.ResumeLayout(False)
        CType(Me.bt_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nav.ResumeLayout(False)
        Me.nav.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_print As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_exit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_tambahkan As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_edit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_cancel As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_save As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tbsaldo As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbjumlahpengeluaran As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbjumlahpendapatan As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents header As System.Windows.Forms.Panel
    Friend WithEvents bt_min As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents nav As System.Windows.Forms.Panel
    Friend WithEvents BunifuTextbox1 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents lblStatus As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton7 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton8 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton10 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton11 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents dgv1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents dgv2 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents lblStatus1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
