<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FKas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FKas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbsaldo = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.header = New System.Windows.Forms.Panel()
        Me.bt_min = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.nav = New System.Windows.Forms.Panel()
        Me.BunifuImageButton6 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tbcari = New System.Windows.Forms.TextBox()
        Me.lblStatus = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton7 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton8 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton10 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton11 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dgv = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.bt_print = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_exit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_tambahkan = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btbatal = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btsave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bttutup = New System.Windows.Forms.Button()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cb_sub = New System.Windows.Forms.ComboBox()
        Me.cb_kategori = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btrefresh = New Bunifu.Framework.UI.BunifuImageButton()
        Me.header.SuspendLayout()
        CType(Me.bt_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nav.SuspendLayout()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_print, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_tambahkan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.btrefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbsaldo
        '
        Me.tbsaldo.BorderColor = System.Drawing.Color.SeaGreen
        Me.tbsaldo.Location = New System.Drawing.Point(1118, 87)
        Me.tbsaldo.Name = "tbsaldo"
        Me.tbsaldo.Size = New System.Drawing.Size(151, 20)
        Me.tbsaldo.TabIndex = 151
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.DarkCyan
        Me.header.Controls.Add(Me.bt_min)
        Me.header.Controls.Add(Me.bt_close)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(280, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1090, 51)
        Me.header.TabIndex = 155
        '
        'bt_min
        '
        Me.bt_min.BackColor = System.Drawing.Color.DarkCyan
        Me.bt_min.Image = CType(resources.GetObject("bt_min.Image"), System.Drawing.Image)
        Me.bt_min.ImageActive = Nothing
        Me.bt_min.Location = New System.Drawing.Point(992, 0)
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
        Me.bt_close.Location = New System.Drawing.Point(1044, 0)
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
        Me.nav.Controls.Add(Me.BunifuImageButton6)
        Me.nav.Controls.Add(Me.tbcari)
        Me.nav.Controls.Add(Me.lblStatus)
        Me.nav.Controls.Add(Me.PictureBox1)
        Me.nav.Controls.Add(Me.BunifuCustomLabel2)
        Me.nav.Controls.Add(Me.BunifuImageButton7)
        Me.nav.Controls.Add(Me.BunifuImageButton8)
        Me.nav.Controls.Add(Me.BunifuImageButton10)
        Me.nav.Controls.Add(Me.BunifuImageButton11)
        Me.nav.Dock = System.Windows.Forms.DockStyle.Left
        Me.nav.Location = New System.Drawing.Point(0, 0)
        Me.nav.Name = "nav"
        Me.nav.Size = New System.Drawing.Size(280, 772)
        Me.nav.TabIndex = 154
        '
        'BunifuImageButton6
        '
        Me.BunifuImageButton6.BackColor = System.Drawing.Color.DarkCyan
        Me.BunifuImageButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton6.Image = CType(resources.GetObject("BunifuImageButton6.Image"), System.Drawing.Image)
        Me.BunifuImageButton6.ImageActive = Nothing
        Me.BunifuImageButton6.Location = New System.Drawing.Point(201, 268)
        Me.BunifuImageButton6.Name = "BunifuImageButton6"
        Me.BunifuImageButton6.Size = New System.Drawing.Size(41, 32)
        Me.BunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton6.TabIndex = 123
        Me.BunifuImageButton6.TabStop = False
        Me.BunifuImageButton6.Zoom = 10
        '
        'tbcari
        '
        Me.tbcari.BackColor = System.Drawing.Color.DarkCyan
        Me.tbcari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbcari.ForeColor = System.Drawing.Color.White
        Me.tbcari.Location = New System.Drawing.Point(46, 276)
        Me.tbcari.Name = "tbcari"
        Me.tbcari.Size = New System.Drawing.Size(150, 20)
        Me.tbcari.TabIndex = 122
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
        Me.lblStatus.Location = New System.Drawing.Point(115, 352)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(58, 16)
        Me.lblStatus.TabIndex = 118
        Me.lblStatus.Text = "Page 0/0"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(46, 55)
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
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(109, 9)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(56, 31)
        Me.BunifuCustomLabel2.TabIndex = 4
        Me.BunifuCustomLabel2.Text = "Kas"
        '
        'BunifuImageButton7
        '
        Me.BunifuImageButton7.BackColor = System.Drawing.Color.DarkCyan
        Me.BunifuImageButton7.Image = CType(resources.GetObject("BunifuImageButton7.Image"), System.Drawing.Image)
        Me.BunifuImageButton7.ImageActive = Nothing
        Me.BunifuImageButton7.Location = New System.Drawing.Point(32, 344)
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
        Me.BunifuImageButton8.Location = New System.Drawing.Point(72, 344)
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
        Me.BunifuImageButton10.Location = New System.Drawing.Point(180, 344)
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
        Me.BunifuImageButton11.Location = New System.Drawing.Point(220, 344)
        Me.BunifuImageButton11.Name = "BunifuImageButton11"
        Me.BunifuImageButton11.Size = New System.Drawing.Size(34, 32)
        Me.BunifuImageButton11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton11.TabIndex = 86
        Me.BunifuImageButton11.TabStop = False
        Me.BunifuImageButton11.Zoom = 10
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(1075, 90)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(37, 14)
        Me.BunifuCustomLabel5.TabIndex = 168
        Me.BunifuCustomLabel5.Text = "Saldo"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.DoubleBuffered = True
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.HeaderBgColor = System.Drawing.Color.DarkCyan
        Me.dgv.HeaderForeColor = System.Drawing.Color.Honeydew
        Me.dgv.Location = New System.Drawing.Point(280, 137)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv.Size = New System.Drawing.Size(1098, 640)
        Me.dgv.TabIndex = 169
        '
        'bt_print
        '
        Me.bt_print.BackColor = System.Drawing.Color.White
        Me.bt_print.Image = CType(resources.GetObject("bt_print.Image"), System.Drawing.Image)
        Me.bt_print.ImageActive = Nothing
        Me.bt_print.Location = New System.Drawing.Point(548, 72)
        Me.bt_print.Name = "bt_print"
        Me.bt_print.Size = New System.Drawing.Size(55, 49)
        Me.bt_print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_print.TabIndex = 161
        Me.bt_print.TabStop = False
        Me.bt_print.Zoom = 10
        '
        'bt_exit
        '
        Me.bt_exit.BackColor = System.Drawing.Color.White
        Me.bt_exit.Image = CType(resources.GetObject("bt_exit.Image"), System.Drawing.Image)
        Me.bt_exit.ImageActive = Nothing
        Me.bt_exit.Location = New System.Drawing.Point(662, 72)
        Me.bt_exit.Name = "bt_exit"
        Me.bt_exit.Size = New System.Drawing.Size(55, 49)
        Me.bt_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_exit.TabIndex = 160
        Me.bt_exit.TabStop = False
        Me.bt_exit.Zoom = 10
        '
        'bt_tambahkan
        '
        Me.bt_tambahkan.BackColor = System.Drawing.Color.White
        Me.bt_tambahkan.Image = CType(resources.GetObject("bt_tambahkan.Image"), System.Drawing.Image)
        Me.bt_tambahkan.ImageActive = Nothing
        Me.bt_tambahkan.Location = New System.Drawing.Point(311, 72)
        Me.bt_tambahkan.Name = "bt_tambahkan"
        Me.bt_tambahkan.Size = New System.Drawing.Size(55, 49)
        Me.bt_tambahkan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_tambahkan.TabIndex = 159
        Me.bt_tambahkan.TabStop = False
        Me.bt_tambahkan.Zoom = 10
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
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.btbatal)
        Me.BunifuGradientPanel1.Controls.Add(Me.btsave)
        Me.BunifuGradientPanel1.Controls.Add(Me.bttutup)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.BunifuGradientPanel1.Controls.Add(Me.cb_sub)
        Me.BunifuGradientPanel1.Controls.Add(Me.cb_kategori)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Silver
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Gainsboro
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.LightGray
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(1370, 90)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(431, 463)
        Me.BunifuGradientPanel1.TabIndex = 170
        '
        'btbatal
        '
        Me.btbatal.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btbatal.BackColor = System.Drawing.Color.Transparent
        Me.btbatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btbatal.BorderRadius = 0
        Me.btbatal.ButtonText = "Batal"
        Me.btbatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btbatal.DisabledColor = System.Drawing.Color.Gray
        Me.btbatal.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbatal.Iconcolor = System.Drawing.Color.Transparent
        Me.btbatal.Iconimage = Nothing
        Me.btbatal.Iconimage_right = Nothing
        Me.btbatal.Iconimage_right_Selected = Nothing
        Me.btbatal.Iconimage_Selected = Nothing
        Me.btbatal.IconMarginLeft = 0
        Me.btbatal.IconMarginRight = 0
        Me.btbatal.IconRightVisible = True
        Me.btbatal.IconRightZoom = 0.0R
        Me.btbatal.IconVisible = True
        Me.btbatal.IconZoom = 90.0R
        Me.btbatal.IsTab = False
        Me.btbatal.Location = New System.Drawing.Point(104, 393)
        Me.btbatal.Margin = New System.Windows.Forms.Padding(5)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Normalcolor = System.Drawing.Color.Transparent
        Me.btbatal.OnHovercolor = System.Drawing.Color.Silver
        Me.btbatal.OnHoverTextColor = System.Drawing.Color.White
        Me.btbatal.selected = False
        Me.btbatal.Size = New System.Drawing.Size(219, 54)
        Me.btbatal.TabIndex = 179
        Me.btbatal.Text = "Batal"
        Me.btbatal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btbatal.Textcolor = System.Drawing.Color.Black
        Me.btbatal.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btsave
        '
        Me.btsave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btsave.BackColor = System.Drawing.Color.Transparent
        Me.btsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btsave.BorderRadius = 0
        Me.btsave.ButtonText = "Tambah"
        Me.btsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btsave.DisabledColor = System.Drawing.Color.Gray
        Me.btsave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsave.Iconcolor = System.Drawing.Color.Transparent
        Me.btsave.Iconimage = Nothing
        Me.btsave.Iconimage_right = Nothing
        Me.btsave.Iconimage_right_Selected = Nothing
        Me.btsave.Iconimage_Selected = Nothing
        Me.btsave.IconMarginLeft = 0
        Me.btsave.IconMarginRight = 0
        Me.btsave.IconRightVisible = True
        Me.btsave.IconRightZoom = 0.0R
        Me.btsave.IconVisible = True
        Me.btsave.IconZoom = 90.0R
        Me.btsave.IsTab = False
        Me.btsave.Location = New System.Drawing.Point(104, 308)
        Me.btsave.Margin = New System.Windows.Forms.Padding(5)
        Me.btsave.Name = "btsave"
        Me.btsave.Normalcolor = System.Drawing.Color.Transparent
        Me.btsave.OnHovercolor = System.Drawing.Color.Silver
        Me.btsave.OnHoverTextColor = System.Drawing.Color.White
        Me.btsave.selected = False
        Me.btsave.Size = New System.Drawing.Size(219, 54)
        Me.btsave.TabIndex = 178
        Me.btsave.Text = "Tambah"
        Me.btsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btsave.Textcolor = System.Drawing.Color.Black
        Me.btsave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bttutup
        '
        Me.bttutup.BackColor = System.Drawing.Color.Transparent
        Me.bttutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.bttutup.Location = New System.Drawing.Point(396, 3)
        Me.bttutup.Name = "bttutup"
        Me.bttutup.Size = New System.Drawing.Size(31, 28)
        Me.bttutup.TabIndex = 177
        Me.bttutup.Text = "X"
        Me.bttutup.UseVisualStyleBackColor = False
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(14, 182)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(137, 24)
        Me.BunifuCustomLabel4.TabIndex = 4
        Me.BunifuCustomLabel4.Text = "Sub Kategori"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(14, 80)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(94, 24)
        Me.BunifuCustomLabel3.TabIndex = 3
        Me.BunifuCustomLabel3.Text = "Kategori"
        '
        'cb_sub
        '
        Me.cb_sub.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sub.FormattingEnabled = True
        Me.cb_sub.Items.AddRange(New Object() {"Penggajian", "Pembayaran Dosen", "Transaksi Pembelian"})
        Me.cb_sub.Location = New System.Drawing.Point(104, 222)
        Me.cb_sub.Name = "cb_sub"
        Me.cb_sub.Size = New System.Drawing.Size(230, 25)
        Me.cb_sub.TabIndex = 2
        '
        'cb_kategori
        '
        Me.cb_kategori.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_kategori.FormattingEnabled = True
        Me.cb_kategori.Items.AddRange(New Object() {"Pemasukan", "Pengeluaran"})
        Me.cb_kategori.Location = New System.Drawing.Point(104, 118)
        Me.cb_kategori.Name = "cb_kategori"
        Me.cb_kategori.Size = New System.Drawing.Size(230, 25)
        Me.cb_kategori.TabIndex = 1
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(144, 15)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(190, 25)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Tambahkan Data"
        '
        'btrefresh
        '
        Me.btrefresh.BackColor = System.Drawing.Color.Transparent
        Me.btrefresh.Image = CType(resources.GetObject("btrefresh.Image"), System.Drawing.Image)
        Me.btrefresh.ImageActive = Nothing
        Me.btrefresh.Location = New System.Drawing.Point(427, 72)
        Me.btrefresh.Name = "btrefresh"
        Me.btrefresh.Size = New System.Drawing.Size(55, 49)
        Me.btrefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btrefresh.TabIndex = 171
        Me.btrefresh.TabStop = False
        Me.btrefresh.Zoom = 10
        '
        'FKas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1370, 772)
        Me.Controls.Add(Me.btrefresh)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.bt_tambahkan)
        Me.Controls.Add(Me.bt_exit)
        Me.Controls.Add(Me.bt_print)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.nav)
        Me.Controls.Add(Me.tbsaldo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FKas"
        Me.Text = "FKas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.header.ResumeLayout(False)
        CType(Me.bt_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nav.ResumeLayout(False)
        Me.nav.PerformLayout()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_print, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_tambahkan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.btrefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbsaldo As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents header As System.Windows.Forms.Panel
    Friend WithEvents bt_min As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents nav As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton7 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton8 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton10 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton11 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dgv As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents bt_print As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_exit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_tambahkan As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cb_sub As System.Windows.Forms.ComboBox
    Friend WithEvents cb_kategori As System.Windows.Forms.ComboBox
    Friend WithEvents btbatal As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btsave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bttutup As System.Windows.Forms.Button
    Friend WithEvents btrefresh As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton6 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tbcari As System.Windows.Forms.TextBox
End Class
