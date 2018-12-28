<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FStatus_Bayar_Siswa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FStatus_Bayar_Siswa))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.bt_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_edit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_npm = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_nama = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_bayar = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_kewajiban = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_nomor = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bt_print = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tb_angkatan = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_semester = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_tunggakan = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bt_save = New Bunifu.Framework.UI.BunifuImageButton()
        Me.g1 = New System.Windows.Forms.PictureBox()
        Me.panelcari = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuCustomTextbox1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.labeltitle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.g2 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bt_Keluar = New System.Windows.Forms.ToolStripButton()
        Me.btrefresh = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_print, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelcari.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.btrefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(21, 189)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(982, 190)
        Me.dgv.TabIndex = 164
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.Color.White
        Me.bt_close.Image = CType(resources.GetObject("bt_close.Image"), System.Drawing.Image)
        Me.bt_close.ImageActive = Nothing
        Me.bt_close.Location = New System.Drawing.Point(948, 50)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(55, 49)
        Me.bt_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_close.TabIndex = 163
        Me.bt_close.TabStop = False
        Me.bt_close.Zoom = 10
        '
        'bt_edit
        '
        Me.bt_edit.BackColor = System.Drawing.Color.White
        Me.bt_edit.Image = CType(resources.GetObject("bt_edit.Image"), System.Drawing.Image)
        Me.bt_edit.ImageActive = Nothing
        Me.bt_edit.Location = New System.Drawing.Point(854, 50)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(55, 49)
        Me.bt_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_edit.TabIndex = 161
        Me.bt_edit.TabStop = False
        Me.bt_edit.Zoom = 10
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(336, 132)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(89, 13)
        Me.BunifuCustomLabel7.TabIndex = 159
        Me.BunifuCustomLabel7.Text = "Total Tunggakan"
        '
        'tb_npm
        '
        Me.tb_npm.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_npm.Location = New System.Drawing.Point(79, 128)
        Me.tb_npm.Name = "tb_npm"
        Me.tb_npm.Size = New System.Drawing.Size(194, 20)
        Me.tb_npm.TabIndex = 158
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(18, 131)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(31, 13)
        Me.BunifuCustomLabel4.TabIndex = 157
        Me.BunifuCustomLabel4.Text = "NPM"
        '
        'tb_nama
        '
        Me.tb_nama.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_nama.Location = New System.Drawing.Point(79, 99)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(194, 20)
        Me.tb_nama.TabIndex = 156
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(18, 102)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(35, 13)
        Me.BunifuCustomLabel3.TabIndex = 155
        Me.BunifuCustomLabel3.Text = "Nama"
        '
        'tb_bayar
        '
        Me.tb_bayar.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_bayar.Location = New System.Drawing.Point(426, 96)
        Me.tb_bayar.Name = "tb_bayar"
        Me.tb_bayar.Size = New System.Drawing.Size(194, 20)
        Me.tb_bayar.TabIndex = 154
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(336, 99)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(61, 13)
        Me.BunifuCustomLabel2.TabIndex = 153
        Me.BunifuCustomLabel2.Text = "Total Bayar"
        '
        'tb_kewajiban
        '
        Me.tb_kewajiban.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_kewajiban.Location = New System.Drawing.Point(426, 61)
        Me.tb_kewajiban.Name = "tb_kewajiban"
        Me.tb_kewajiban.Size = New System.Drawing.Size(194, 20)
        Me.tb_kewajiban.TabIndex = 152
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(336, 64)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(83, 13)
        Me.BunifuCustomLabel6.TabIndex = 151
        Me.BunifuCustomLabel6.Text = "Total Kewajiban"
        '
        'tb_nomor
        '
        Me.tb_nomor.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_nomor.Location = New System.Drawing.Point(79, 64)
        Me.tb_nomor.Name = "tb_nomor"
        Me.tb_nomor.Size = New System.Drawing.Size(118, 20)
        Me.tb_nomor.TabIndex = 150
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(18, 64)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(38, 13)
        Me.BunifuCustomLabel5.TabIndex = 149
        Me.BunifuCustomLabel5.Text = "Nomor"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(17, 31)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(217, 21)
        Me.BunifuCustomLabel1.TabIndex = 148
        Me.BunifuCustomLabel1.Text = "Status Pembayaran Siswa"
        '
        'bt_print
        '
        Me.bt_print.BackColor = System.Drawing.Color.White
        Me.bt_print.Image = CType(resources.GetObject("bt_print.Image"), System.Drawing.Image)
        Me.bt_print.ImageActive = Nothing
        Me.bt_print.Location = New System.Drawing.Point(854, 114)
        Me.bt_print.Name = "bt_print"
        Me.bt_print.Size = New System.Drawing.Size(149, 49)
        Me.bt_print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_print.TabIndex = 165
        Me.bt_print.TabStop = False
        Me.bt_print.Zoom = 10
        '
        'tb_angkatan
        '
        Me.tb_angkatan.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_angkatan.Location = New System.Drawing.Point(191, 163)
        Me.tb_angkatan.Name = "tb_angkatan"
        Me.tb_angkatan.Size = New System.Drawing.Size(53, 20)
        Me.tb_angkatan.TabIndex = 169
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(132, 166)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(53, 13)
        Me.BunifuCustomLabel8.TabIndex = 168
        Me.BunifuCustomLabel8.Text = "Angkatan"
        '
        'tb_semester
        '
        Me.tb_semester.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_semester.Location = New System.Drawing.Point(79, 163)
        Me.tb_semester.Name = "tb_semester"
        Me.tb_semester.Size = New System.Drawing.Size(47, 20)
        Me.tb_semester.TabIndex = 167
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(18, 166)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(51, 13)
        Me.BunifuCustomLabel9.TabIndex = 166
        Me.BunifuCustomLabel9.Text = "Semester"
        '
        'tb_tunggakan
        '
        Me.tb_tunggakan.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_tunggakan.Location = New System.Drawing.Point(426, 128)
        Me.tb_tunggakan.Name = "tb_tunggakan"
        Me.tb_tunggakan.Size = New System.Drawing.Size(194, 20)
        Me.tb_tunggakan.TabIndex = 170
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Snow
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(279, 99)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(24, 20)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 171
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'dgv2
        '
        Me.dgv2.AllowUserToAddRows = False
        Me.dgv2.AllowUserToDeleteRows = False
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Location = New System.Drawing.Point(21, 417)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.ReadOnly = True
        Me.dgv2.Size = New System.Drawing.Size(982, 193)
        Me.dgv2.TabIndex = 172
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(18, 392)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(107, 13)
        Me.BunifuCustomLabel10.TabIndex = 173
        Me.BunifuCustomLabel10.Text = "Riwayat Pembayaran"
        '
        'bt_save
        '
        Me.bt_save.BackColor = System.Drawing.Color.Transparent
        Me.bt_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_save.Image = CType(resources.GetObject("bt_save.Image"), System.Drawing.Image)
        Me.bt_save.ImageActive = Nothing
        Me.bt_save.Location = New System.Drawing.Point(746, 50)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.Size = New System.Drawing.Size(69, 49)
        Me.bt_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_save.TabIndex = 224
        Me.bt_save.TabStop = False
        Me.bt_save.Zoom = 10
        '
        'g1
        '
        Me.g1.Image = CType(resources.GetObject("g1.Image"), System.Drawing.Image)
        Me.g1.Location = New System.Drawing.Point(718, 102)
        Me.g1.Name = "g1"
        Me.g1.Size = New System.Drawing.Size(50, 50)
        Me.g1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.g1.TabIndex = 225
        Me.g1.TabStop = False
        '
        'panelcari
        '
        Me.panelcari.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.panelcari.Controls.Add(Me.Label8)
        Me.panelcari.Controls.Add(Me.BunifuCustomTextbox1)
        Me.panelcari.Controls.Add(Me.DataGridView1)
        Me.panelcari.Controls.Add(Me.Panel3)
        Me.panelcari.Controls.Add(Me.PictureBox3)
        Me.panelcari.Controls.Add(Me.g2)
        Me.panelcari.Location = New System.Drawing.Point(279, 122)
        Me.panelcari.Name = "panelcari"
        Me.panelcari.Size = New System.Drawing.Size(465, 504)
        Me.panelcari.TabIndex = 226
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 475)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(208, 13)
        Me.Label8.TabIndex = 198
        Me.Label8.Text = "Double Click Untuk Memilih Data Tersebut"
        '
        'BunifuCustomTextbox1
        '
        Me.BunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomTextbox1.Location = New System.Drawing.Point(25, 132)
        Me.BunifuCustomTextbox1.Name = "BunifuCustomTextbox1"
        Me.BunifuCustomTextbox1.Size = New System.Drawing.Size(373, 20)
        Me.BunifuCustomTextbox1.TabIndex = 197
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(440, 314)
        Me.DataGridView1.TabIndex = 196
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Controls.Add(Me.labeltitle)
        Me.Panel3.Location = New System.Drawing.Point(-4, 24)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(253, 43)
        Me.Panel3.TabIndex = 195
        '
        'labeltitle
        '
        Me.labeltitle.AutoSize = True
        Me.labeltitle.Font = New System.Drawing.Font("Gadugi", 19.0!, System.Drawing.FontStyle.Bold)
        Me.labeltitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labeltitle.Location = New System.Drawing.Point(7, 5)
        Me.labeltitle.Name = "labeltitle"
        Me.labeltitle.Size = New System.Drawing.Size(74, 31)
        Me.labeltitle.TabIndex = 131
        Me.labeltitle.Text = "####"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(395, 132)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(46, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 193
        Me.PictureBox3.TabStop = False
        '
        'g2
        '
        Me.g2.Image = CType(resources.GetObject("g2.Image"), System.Drawing.Image)
        Me.g2.Location = New System.Drawing.Point(439, -22)
        Me.g2.Name = "g2"
        Me.g2.Size = New System.Drawing.Size(50, 50)
        Me.g2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.g2.TabIndex = 194
        Me.g2.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bt_Keluar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1062, 25)
        Me.ToolStrip1.TabIndex = 227
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bt_Keluar
        '
        Me.bt_Keluar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bt_Keluar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bt_Keluar.Image = CType(resources.GetObject("bt_Keluar.Image"), System.Drawing.Image)
        Me.bt_Keluar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bt_Keluar.Name = "bt_Keluar"
        Me.bt_Keluar.Size = New System.Drawing.Size(23, 22)
        Me.bt_Keluar.Text = "Tutup"
        '
        'btrefresh
        '
        Me.btrefresh.BackColor = System.Drawing.Color.Transparent
        Me.btrefresh.Image = CType(resources.GetObject("btrefresh.Image"), System.Drawing.Image)
        Me.btrefresh.ImageActive = Nothing
        Me.btrefresh.Location = New System.Drawing.Point(746, 114)
        Me.btrefresh.Name = "btrefresh"
        Me.btrefresh.Size = New System.Drawing.Size(69, 49)
        Me.btrefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btrefresh.TabIndex = 228
        Me.btrefresh.TabStop = False
        Me.btrefresh.Zoom = 10
        '
        'FStatus_Bayar_Siswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1062, 670)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.g1)
        Me.Controls.Add(Me.panelcari)
        Me.Controls.Add(Me.bt_save)
        Me.Controls.Add(Me.BunifuCustomLabel10)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.BunifuImageButton2)
        Me.Controls.Add(Me.tb_tunggakan)
        Me.Controls.Add(Me.tb_angkatan)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.tb_semester)
        Me.Controls.Add(Me.BunifuCustomLabel9)
        Me.Controls.Add(Me.bt_print)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.bt_close)
        Me.Controls.Add(Me.bt_edit)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.tb_npm)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.tb_nama)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.tb_bayar)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.tb_kewajiban)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.tb_nomor)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.btrefresh)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FStatus_Bayar_Siswa"
        Me.Text = "FStatus_Bayar_Siswa"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_print, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelcari.ResumeLayout(False)
        Me.panelcari.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.btrefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents bt_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_edit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_npm As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_nama As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_bayar As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_kewajiban As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_nomor As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bt_print As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tb_angkatan As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_semester As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_tunggakan As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bt_save As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents g1 As System.Windows.Forms.PictureBox
    Friend WithEvents panelcari As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BunifuCustomTextbox1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents labeltitle As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents g2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bt_Keluar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btrefresh As Bunifu.Framework.UI.BunifuImageButton
End Class
