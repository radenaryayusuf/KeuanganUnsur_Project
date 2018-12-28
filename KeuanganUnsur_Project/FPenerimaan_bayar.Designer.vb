<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPenerimaan_bayar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPenerimaan_bayar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CariToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KodeTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KodePemasukanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KodePengeluaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BesaranGajiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputMahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenerimaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengeluaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BelanjaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenggajianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeracaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KwitansiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KwitansiPemasukanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KwitansiPengeluaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KwitansiPenggajianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiwayatMahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerkategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_nomor = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.tb_nama = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_npm = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_semester = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_angkatan = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.rd_cash = New System.Windows.Forms.RadioButton()
        Me.rd_transfer = New System.Windows.Forms.RadioButton()
        Me.tb_bayar = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_kewajiban = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_sisa = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_total = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_penerima = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel14 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bt_save = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_cancel = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_edit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_tambahkan = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_exit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_print = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip6 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip7 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.dtp_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tb_no = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.panelcari = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuCustomTextbox1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.labeltitle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.g2 = New System.Windows.Forms.PictureBox()
        Me.g1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel16 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_uraian = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel15 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_kodeakun = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tb_akun = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.dgv = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.bt_cetak = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_banyaknya = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_jumlah = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbbanyak = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.bt_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_tambahkan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_print, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panelcari.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.MahasiswaToolStripMenuItem, Me.PenerimaanToolStripMenuItem, Me.PengeluaranToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.TentangToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1366, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem, Me.CariToolStripMenuItem, Me.RestoreToolStripMenuItem, Me.BackupToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'CariToolStripMenuItem
        '
        Me.CariToolStripMenuItem.Name = "CariToolStripMenuItem"
        Me.CariToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.CariToolStripMenuItem.Text = "Cari"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.BackupToolStripMenuItem.Text = "Backup"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.PegawaiToolStripMenuItem, Me.KodeTransaksiToolStripMenuItem, Me.BesaranGajiToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'PegawaiToolStripMenuItem
        '
        Me.PegawaiToolStripMenuItem.Name = "PegawaiToolStripMenuItem"
        Me.PegawaiToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.PegawaiToolStripMenuItem.Text = "Pegawai"
        '
        'KodeTransaksiToolStripMenuItem
        '
        Me.KodeTransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KodePemasukanToolStripMenuItem, Me.KodePengeluaranToolStripMenuItem})
        Me.KodeTransaksiToolStripMenuItem.Name = "KodeTransaksiToolStripMenuItem"
        Me.KodeTransaksiToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.KodeTransaksiToolStripMenuItem.Text = "Kode Transaksi"
        '
        'KodePemasukanToolStripMenuItem
        '
        Me.KodePemasukanToolStripMenuItem.Name = "KodePemasukanToolStripMenuItem"
        Me.KodePemasukanToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.KodePemasukanToolStripMenuItem.Text = "Kode Pemasukan"
        '
        'KodePengeluaranToolStripMenuItem
        '
        Me.KodePengeluaranToolStripMenuItem.Name = "KodePengeluaranToolStripMenuItem"
        Me.KodePengeluaranToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.KodePengeluaranToolStripMenuItem.Text = "Kode Pengeluaran"
        '
        'BesaranGajiToolStripMenuItem
        '
        Me.BesaranGajiToolStripMenuItem.Name = "BesaranGajiToolStripMenuItem"
        Me.BesaranGajiToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.BesaranGajiToolStripMenuItem.Text = "Besaran & Gaji"
        '
        'MahasiswaToolStripMenuItem
        '
        Me.MahasiswaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputMahasiswaToolStripMenuItem, Me.DataMahasiswaToolStripMenuItem})
        Me.MahasiswaToolStripMenuItem.Name = "MahasiswaToolStripMenuItem"
        Me.MahasiswaToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.MahasiswaToolStripMenuItem.Text = "Mahasiswa"
        '
        'InputMahasiswaToolStripMenuItem
        '
        Me.InputMahasiswaToolStripMenuItem.Name = "InputMahasiswaToolStripMenuItem"
        Me.InputMahasiswaToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.InputMahasiswaToolStripMenuItem.Text = "Input Mahasiswa"
        '
        'DataMahasiswaToolStripMenuItem
        '
        Me.DataMahasiswaToolStripMenuItem.Name = "DataMahasiswaToolStripMenuItem"
        Me.DataMahasiswaToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DataMahasiswaToolStripMenuItem.Text = "Data Mahasiswa"
        '
        'PenerimaanToolStripMenuItem
        '
        Me.PenerimaanToolStripMenuItem.Name = "PenerimaanToolStripMenuItem"
        Me.PenerimaanToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.PenerimaanToolStripMenuItem.Text = "Penerimaan"
        '
        'PengeluaranToolStripMenuItem
        '
        Me.PengeluaranToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BelanjaToolStripMenuItem, Me.PenggajianToolStripMenuItem})
        Me.PengeluaranToolStripMenuItem.Name = "PengeluaranToolStripMenuItem"
        Me.PengeluaranToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.PengeluaranToolStripMenuItem.Text = "Pengeluaran"
        '
        'BelanjaToolStripMenuItem
        '
        Me.BelanjaToolStripMenuItem.Name = "BelanjaToolStripMenuItem"
        Me.BelanjaToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.BelanjaToolStripMenuItem.Text = "Belanja"
        '
        'PenggajianToolStripMenuItem
        '
        Me.PenggajianToolStripMenuItem.Name = "PenggajianToolStripMenuItem"
        Me.PenggajianToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.PenggajianToolStripMenuItem.Text = "Penggajian"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KasToolStripMenuItem, Me.NeracaToolStripMenuItem, Me.KwitansiToolStripMenuItem, Me.RiwayatMahasiswaToolStripMenuItem, Me.PerkategoriToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'KasToolStripMenuItem
        '
        Me.KasToolStripMenuItem.Name = "KasToolStripMenuItem"
        Me.KasToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.KasToolStripMenuItem.Text = "Kas"
        '
        'NeracaToolStripMenuItem
        '
        Me.NeracaToolStripMenuItem.Name = "NeracaToolStripMenuItem"
        Me.NeracaToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.NeracaToolStripMenuItem.Text = "Neraca"
        '
        'KwitansiToolStripMenuItem
        '
        Me.KwitansiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KwitansiPemasukanToolStripMenuItem, Me.KwitansiPengeluaranToolStripMenuItem, Me.KwitansiPenggajianToolStripMenuItem})
        Me.KwitansiToolStripMenuItem.Name = "KwitansiToolStripMenuItem"
        Me.KwitansiToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.KwitansiToolStripMenuItem.Text = "Kwitansi"
        '
        'KwitansiPemasukanToolStripMenuItem
        '
        Me.KwitansiPemasukanToolStripMenuItem.Name = "KwitansiPemasukanToolStripMenuItem"
        Me.KwitansiPemasukanToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.KwitansiPemasukanToolStripMenuItem.Text = "Kwitansi Pemasukan"
        '
        'KwitansiPengeluaranToolStripMenuItem
        '
        Me.KwitansiPengeluaranToolStripMenuItem.Name = "KwitansiPengeluaranToolStripMenuItem"
        Me.KwitansiPengeluaranToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.KwitansiPengeluaranToolStripMenuItem.Text = "Kwitansi Pengeluaran"
        '
        'KwitansiPenggajianToolStripMenuItem
        '
        Me.KwitansiPenggajianToolStripMenuItem.Name = "KwitansiPenggajianToolStripMenuItem"
        Me.KwitansiPenggajianToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.KwitansiPenggajianToolStripMenuItem.Text = "Kwitansi Penggajian"
        '
        'RiwayatMahasiswaToolStripMenuItem
        '
        Me.RiwayatMahasiswaToolStripMenuItem.Name = "RiwayatMahasiswaToolStripMenuItem"
        Me.RiwayatMahasiswaToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.RiwayatMahasiswaToolStripMenuItem.Text = "Riwayat Mahasiswa"
        '
        'PerkategoriToolStripMenuItem
        '
        Me.PerkategoriToolStripMenuItem.Name = "PerkategoriToolStripMenuItem"
        Me.PerkategoriToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.PerkategoriToolStripMenuItem.Text = "Perkategori"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Gadugi", 19.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Ivory
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(13, 15)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(318, 31)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "Penerimaan Pembayaran"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Ivory
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(120, 76)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(56, 20)
        Me.BunifuCustomLabel2.TabIndex = 3
        Me.BunifuCustomLabel2.Text = "Nomor"
        '
        'tb_nomor
        '
        Me.tb_nomor.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_nomor.Cursor = System.Windows.Forms.Cursors.No
        Me.tb_nomor.Location = New System.Drawing.Point(208, 73)
        Me.tb_nomor.Name = "tb_nomor"
        Me.tb_nomor.ReadOnly = True
        Me.tb_nomor.Size = New System.Drawing.Size(83, 26)
        Me.tb_nomor.TabIndex = 4
        '
        'tb_nama
        '
        Me.tb_nama.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_nama.Location = New System.Drawing.Point(208, 110)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(205, 26)
        Me.tb_nama.TabIndex = 6
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Ivory
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(120, 113)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(51, 20)
        Me.BunifuCustomLabel3.TabIndex = 5
        Me.BunifuCustomLabel3.Text = "Nama"
        '
        'tb_npm
        '
        Me.tb_npm.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_npm.Cursor = System.Windows.Forms.Cursors.No
        Me.tb_npm.Location = New System.Drawing.Point(208, 146)
        Me.tb_npm.Name = "tb_npm"
        Me.tb_npm.ReadOnly = True
        Me.tb_npm.Size = New System.Drawing.Size(130, 26)
        Me.tb_npm.TabIndex = 8
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Ivory
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(120, 149)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(43, 20)
        Me.BunifuCustomLabel4.TabIndex = 7
        Me.BunifuCustomLabel4.Text = "NPM"
        '
        'tb_semester
        '
        Me.tb_semester.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_semester.Cursor = System.Windows.Forms.Cursors.No
        Me.tb_semester.Location = New System.Drawing.Point(208, 182)
        Me.tb_semester.Name = "tb_semester"
        Me.tb_semester.ReadOnly = True
        Me.tb_semester.Size = New System.Drawing.Size(83, 26)
        Me.tb_semester.TabIndex = 10
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Ivory
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(120, 185)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(78, 20)
        Me.BunifuCustomLabel5.TabIndex = 9
        Me.BunifuCustomLabel5.Text = "Semester"
        '
        'tb_angkatan
        '
        Me.tb_angkatan.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_angkatan.Cursor = System.Windows.Forms.Cursors.No
        Me.tb_angkatan.Location = New System.Drawing.Point(208, 218)
        Me.tb_angkatan.Name = "tb_angkatan"
        Me.tb_angkatan.ReadOnly = True
        Me.tb_angkatan.Size = New System.Drawing.Size(83, 26)
        Me.tb_angkatan.TabIndex = 12
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.Ivory
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(120, 221)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(78, 20)
        Me.BunifuCustomLabel6.TabIndex = 11
        Me.BunifuCustomLabel6.Text = "Angkatan"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.Ivory
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(120, 253)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(63, 20)
        Me.BunifuCustomLabel7.TabIndex = 13
        Me.BunifuCustomLabel7.Text = "Metode"
        '
        'rd_cash
        '
        Me.rd_cash.AutoSize = True
        Me.rd_cash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_cash.ForeColor = System.Drawing.Color.Gainsboro
        Me.rd_cash.Location = New System.Drawing.Point(208, 253)
        Me.rd_cash.Name = "rd_cash"
        Me.rd_cash.Size = New System.Drawing.Size(64, 24)
        Me.rd_cash.TabIndex = 14
        Me.rd_cash.TabStop = True
        Me.rd_cash.Text = "Cash"
        Me.rd_cash.UseVisualStyleBackColor = True
        '
        'rd_transfer
        '
        Me.rd_transfer.AutoSize = True
        Me.rd_transfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_transfer.ForeColor = System.Drawing.Color.Gainsboro
        Me.rd_transfer.Location = New System.Drawing.Point(305, 253)
        Me.rd_transfer.Name = "rd_transfer"
        Me.rd_transfer.Size = New System.Drawing.Size(86, 24)
        Me.rd_transfer.TabIndex = 15
        Me.rd_transfer.TabStop = True
        Me.rd_transfer.Text = "Transfer"
        Me.rd_transfer.UseVisualStyleBackColor = True
        '
        'tb_bayar
        '
        Me.tb_bayar.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_bayar.Location = New System.Drawing.Point(689, 110)
        Me.tb_bayar.Name = "tb_bayar"
        Me.tb_bayar.Size = New System.Drawing.Size(249, 26)
        Me.tb_bayar.TabIndex = 18
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.Ivory
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(586, 113)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(50, 20)
        Me.BunifuCustomLabel8.TabIndex = 17
        Me.BunifuCustomLabel8.Text = "Bayar"
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.Ivory
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(586, 76)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(46, 20)
        Me.BunifuCustomLabel9.TabIndex = 19
        Me.BunifuCustomLabel9.Text = "Akun"
        '
        'tb_kewajiban
        '
        Me.tb_kewajiban.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_kewajiban.Cursor = System.Windows.Forms.Cursors.No
        Me.tb_kewajiban.Location = New System.Drawing.Point(689, 211)
        Me.tb_kewajiban.Name = "tb_kewajiban"
        Me.tb_kewajiban.ReadOnly = True
        Me.tb_kewajiban.Size = New System.Drawing.Size(219, 26)
        Me.tb_kewajiban.TabIndex = 22
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.Ivory
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(586, 214)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(81, 20)
        Me.BunifuCustomLabel10.TabIndex = 21
        Me.BunifuCustomLabel10.Text = "Kewajiban"
        '
        'tb_sisa
        '
        Me.tb_sisa.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_sisa.Cursor = System.Windows.Forms.Cursors.No
        Me.tb_sisa.Location = New System.Drawing.Point(689, 247)
        Me.tb_sisa.Name = "tb_sisa"
        Me.tb_sisa.ReadOnly = True
        Me.tb_sisa.Size = New System.Drawing.Size(249, 26)
        Me.tb_sisa.TabIndex = 24
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.Ivory
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(586, 250)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(40, 20)
        Me.BunifuCustomLabel11.TabIndex = 23
        Me.BunifuCustomLabel11.Text = "Sisa"
        '
        'tb_total
        '
        Me.tb_total.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_total.Location = New System.Drawing.Point(689, 368)
        Me.tb_total.Multiline = True
        Me.tb_total.Name = "tb_total"
        Me.tb_total.Size = New System.Drawing.Size(249, 29)
        Me.tb_total.TabIndex = 26
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel12.ForeColor = System.Drawing.Color.Ivory
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(586, 285)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New System.Drawing.Size(66, 20)
        Me.BunifuCustomLabel12.TabIndex = 25
        Me.BunifuCustomLabel12.Text = "Tanggal"
        '
        'tb_penerima
        '
        Me.tb_penerima.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_penerima.Location = New System.Drawing.Point(689, 327)
        Me.tb_penerima.Name = "tb_penerima"
        Me.tb_penerima.Size = New System.Drawing.Size(249, 26)
        Me.tb_penerima.TabIndex = 28
        '
        'BunifuCustomLabel13
        '
        Me.BunifuCustomLabel13.AutoSize = True
        Me.BunifuCustomLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel13.ForeColor = System.Drawing.Color.Ivory
        Me.BunifuCustomLabel13.Location = New System.Drawing.Point(586, 330)
        Me.BunifuCustomLabel13.Name = "BunifuCustomLabel13"
        Me.BunifuCustomLabel13.Size = New System.Drawing.Size(76, 20)
        Me.BunifuCustomLabel13.TabIndex = 27
        Me.BunifuCustomLabel13.Text = "Penerima"
        '
        'BunifuCustomLabel14
        '
        Me.BunifuCustomLabel14.AutoSize = True
        Me.BunifuCustomLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel14.ForeColor = System.Drawing.Color.Ivory
        Me.BunifuCustomLabel14.Location = New System.Drawing.Point(586, 371)
        Me.BunifuCustomLabel14.Name = "BunifuCustomLabel14"
        Me.BunifuCustomLabel14.Size = New System.Drawing.Size(44, 20)
        Me.BunifuCustomLabel14.TabIndex = 29
        Me.BunifuCustomLabel14.Text = "Total"
        '
        'bt_save
        '
        Me.bt_save.BackColor = System.Drawing.Color.Transparent
        Me.bt_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_save.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bt_save.Image = CType(resources.GetObject("bt_save.Image"), System.Drawing.Image)
        Me.bt_save.ImageActive = Nothing
        Me.bt_save.Location = New System.Drawing.Point(32, 101)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.Size = New System.Drawing.Size(55, 49)
        Me.bt_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_save.TabIndex = 33
        Me.bt_save.TabStop = False
        Me.ToolTip1.SetToolTip(Me.bt_save, "Save")
        Me.bt_save.Zoom = 10
        '
        'bt_cancel
        '
        Me.bt_cancel.BackColor = System.Drawing.Color.Transparent
        Me.bt_cancel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bt_cancel.Image = CType(resources.GetObject("bt_cancel.Image"), System.Drawing.Image)
        Me.bt_cancel.ImageActive = Nothing
        Me.bt_cancel.Location = New System.Drawing.Point(231, 101)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(55, 49)
        Me.bt_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_cancel.TabIndex = 34
        Me.bt_cancel.TabStop = False
        Me.ToolTip2.SetToolTip(Me.bt_cancel, "Cancel")
        Me.bt_cancel.Zoom = 10
        '
        'bt_edit
        '
        Me.bt_edit.BackColor = System.Drawing.Color.Transparent
        Me.bt_edit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bt_edit.Image = CType(resources.GetObject("bt_edit.Image"), System.Drawing.Image)
        Me.bt_edit.ImageActive = Nothing
        Me.bt_edit.Location = New System.Drawing.Point(166, 101)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(55, 49)
        Me.bt_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_edit.TabIndex = 35
        Me.bt_edit.TabStop = False
        Me.ToolTip3.SetToolTip(Me.bt_edit, "Edit")
        Me.bt_edit.Zoom = 10
        '
        'bt_tambahkan
        '
        Me.bt_tambahkan.BackColor = System.Drawing.Color.Transparent
        Me.bt_tambahkan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bt_tambahkan.Image = CType(resources.GetObject("bt_tambahkan.Image"), System.Drawing.Image)
        Me.bt_tambahkan.ImageActive = Nothing
        Me.bt_tambahkan.Location = New System.Drawing.Point(100, 101)
        Me.bt_tambahkan.Name = "bt_tambahkan"
        Me.bt_tambahkan.Size = New System.Drawing.Size(55, 49)
        Me.bt_tambahkan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_tambahkan.TabIndex = 36
        Me.bt_tambahkan.TabStop = False
        Me.ToolTip4.SetToolTip(Me.bt_tambahkan, "Tambah")
        Me.bt_tambahkan.Zoom = 10
        '
        'bt_exit
        '
        Me.bt_exit.BackColor = System.Drawing.Color.Transparent
        Me.bt_exit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bt_exit.Image = CType(resources.GetObject("bt_exit.Image"), System.Drawing.Image)
        Me.bt_exit.ImageActive = Nothing
        Me.bt_exit.Location = New System.Drawing.Point(294, 101)
        Me.bt_exit.Name = "bt_exit"
        Me.bt_exit.Size = New System.Drawing.Size(55, 49)
        Me.bt_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_exit.TabIndex = 38
        Me.bt_exit.TabStop = False
        Me.ToolTip6.SetToolTip(Me.bt_exit, "Keluar")
        Me.bt_exit.Zoom = 10
        '
        'bt_print
        '
        Me.bt_print.BackColor = System.Drawing.Color.Transparent
        Me.bt_print.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bt_print.Image = CType(resources.GetObject("bt_print.Image"), System.Drawing.Image)
        Me.bt_print.ImageActive = Nothing
        Me.bt_print.Location = New System.Drawing.Point(32, 25)
        Me.bt_print.Name = "bt_print"
        Me.bt_print.Size = New System.Drawing.Size(317, 49)
        Me.bt_print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_print.TabIndex = 39
        Me.bt_print.TabStop = False
        Me.ToolTip7.SetToolTip(Me.bt_print, "Print Kwitansi")
        Me.bt_print.Zoom = 10
        '
        'tanggal
        '
        Me.tanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tanggal.Location = New System.Drawing.Point(157, 288)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(256, 26)
        Me.tanggal.TabIndex = 41
        '
        'dtp_tanggal
        '
        Me.dtp_tanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_tanggal.Location = New System.Drawing.Point(689, 285)
        Me.dtp_tanggal.Name = "dtp_tanggal"
        Me.dtp_tanggal.Size = New System.Drawing.Size(249, 26)
        Me.dtp_tanggal.TabIndex = 42
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.tb_no)
        Me.Panel1.Controls.Add(Me.panelcari)
        Me.Panel1.Controls.Add(Me.g1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel16)
        Me.Panel1.Controls.Add(Me.tb_uraian)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel15)
        Me.Panel1.Controls.Add(Me.tb_kodeakun)
        Me.Panel1.Controls.Add(Me.BunifuImageButton2)
        Me.Panel1.Controls.Add(Me.tb_akun)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.tb_total)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.dtp_tanggal)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.tanggal)
        Me.Panel1.Controls.Add(Me.tb_nomor)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.tb_nama)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel1.Controls.Add(Me.tb_npm)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel1.Controls.Add(Me.tb_semester)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel6)
        Me.Panel1.Controls.Add(Me.tb_angkatan)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel14)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel7)
        Me.Panel1.Controls.Add(Me.tb_penerima)
        Me.Panel1.Controls.Add(Me.rd_cash)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel13)
        Me.Panel1.Controls.Add(Me.rd_transfer)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel12)
        Me.Panel1.Controls.Add(Me.tb_bayar)
        Me.Panel1.Controls.Add(Me.tb_sisa)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel9)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel11)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel10)
        Me.Panel1.Controls.Add(Me.tb_kewajiban)
        Me.Panel1.Controls.Add(Me.dgv)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(-2, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1368, 748)
        Me.Panel1.TabIndex = 43
        '
        'tb_no
        '
        Me.tb_no.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_no.Cursor = System.Windows.Forms.Cursors.No
        Me.tb_no.Location = New System.Drawing.Point(-87, 49)
        Me.tb_no.Name = "tb_no"
        Me.tb_no.ReadOnly = True
        Me.tb_no.Size = New System.Drawing.Size(83, 26)
        Me.tb_no.TabIndex = 205
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
        Me.panelcari.Location = New System.Drawing.Point(411, 138)
        Me.panelcari.Name = "panelcari"
        Me.panelcari.Size = New System.Drawing.Size(465, 504)
        Me.panelcari.TabIndex = 203
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
        Me.BunifuCustomTextbox1.Size = New System.Drawing.Size(373, 26)
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
        Me.Panel3.Size = New System.Drawing.Size(302, 43)
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
        Me.PictureBox3.Location = New System.Drawing.Point(393, 132)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(46, 26)
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
        'g1
        '
        Me.g1.Image = CType(resources.GetObject("g1.Image"), System.Drawing.Image)
        Me.g1.Location = New System.Drawing.Point(850, 116)
        Me.g1.Name = "g1"
        Me.g1.Size = New System.Drawing.Size(50, 50)
        Me.g1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.g1.TabIndex = 202
        Me.g1.TabStop = False
        '
        'BunifuCustomLabel16
        '
        Me.BunifuCustomLabel16.AutoSize = True
        Me.BunifuCustomLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel16.ForeColor = System.Drawing.Color.Ivory
        Me.BunifuCustomLabel16.Location = New System.Drawing.Point(586, 178)
        Me.BunifuCustomLabel16.Name = "BunifuCustomLabel16"
        Me.BunifuCustomLabel16.Size = New System.Drawing.Size(56, 20)
        Me.BunifuCustomLabel16.TabIndex = 200
        Me.BunifuCustomLabel16.Text = "Uraian"
        '
        'tb_uraian
        '
        Me.tb_uraian.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_uraian.Cursor = System.Windows.Forms.Cursors.No
        Me.tb_uraian.Location = New System.Drawing.Point(689, 175)
        Me.tb_uraian.Name = "tb_uraian"
        Me.tb_uraian.ReadOnly = True
        Me.tb_uraian.Size = New System.Drawing.Size(219, 26)
        Me.tb_uraian.TabIndex = 201
        '
        'BunifuCustomLabel15
        '
        Me.BunifuCustomLabel15.AutoSize = True
        Me.BunifuCustomLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel15.ForeColor = System.Drawing.Color.Ivory
        Me.BunifuCustomLabel15.Location = New System.Drawing.Point(586, 145)
        Me.BunifuCustomLabel15.Name = "BunifuCustomLabel15"
        Me.BunifuCustomLabel15.Size = New System.Drawing.Size(87, 20)
        Me.BunifuCustomLabel15.TabIndex = 198
        Me.BunifuCustomLabel15.Text = "Kode Akun"
        '
        'tb_kodeakun
        '
        Me.tb_kodeakun.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_kodeakun.Cursor = System.Windows.Forms.Cursors.No
        Me.tb_kodeakun.Location = New System.Drawing.Point(689, 142)
        Me.tb_kodeakun.Name = "tb_kodeakun"
        Me.tb_kodeakun.ReadOnly = True
        Me.tb_kodeakun.Size = New System.Drawing.Size(219, 26)
        Me.tb_kodeakun.TabIndex = 199
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Snow
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(900, 73)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(41, 26)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 86
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'tb_akun
        '
        Me.tb_akun.BorderColor = System.Drawing.Color.SeaGreen
        Me.tb_akun.Location = New System.Drawing.Point(689, 73)
        Me.tb_akun.Name = "tb_akun"
        Me.tb_akun.Size = New System.Drawing.Size(219, 26)
        Me.tb_akun.TabIndex = 85
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bt_exit)
        Me.GroupBox1.Controls.Add(Me.bt_save)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.bt_cancel)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.bt_edit)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.bt_tambahkan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.bt_print)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(980, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 179)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tools"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(238, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 18)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Batal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(167, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 18)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Cetak"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(297, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 18)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Keluar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(96, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Tambah"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Simpan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(176, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 18)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Edit"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Snow
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(411, 110)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(41, 26)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 83
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
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
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.DoubleBuffered = True
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dgv.HeaderForeColor = System.Drawing.Color.Honeydew
        Me.dgv.Location = New System.Drawing.Point(3, 403)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv.Size = New System.Drawing.Size(1365, 341)
        Me.dgv.TabIndex = 204
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.tbnama)
        Me.Panel2.Controls.Add(Me.bt_cetak)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.tb_banyaknya)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.tb_jumlah)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.tbbanyak)
        Me.Panel2.Location = New System.Drawing.Point(466, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(435, 437)
        Me.Panel2.TabIndex = 44
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(400, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 29)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Lanjutkan mencetak kwitansi ?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Transaksi telah selesai "
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(95, 65)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.ReadOnly = True
        Me.tbnama.Size = New System.Drawing.Size(119, 20)
        Me.tbnama.TabIndex = 48
        '
        'bt_cetak
        '
        Me.bt_cetak.Location = New System.Drawing.Point(336, 65)
        Me.bt_cetak.Name = "bt_cetak"
        Me.bt_cetak.Size = New System.Drawing.Size(86, 35)
        Me.bt_cetak.TabIndex = 32
        Me.bt_cetak.Text = "CETAK "
        Me.bt_cetak.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Banyaknya"
        '
        'tb_banyaknya
        '
        Me.tb_banyaknya.Location = New System.Drawing.Point(95, 118)
        Me.tb_banyaknya.Name = "tb_banyaknya"
        Me.tb_banyaknya.ReadOnly = True
        Me.tb_banyaknya.Size = New System.Drawing.Size(204, 20)
        Me.tb_banyaknya.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Jumlah"
        '
        'tb_jumlah
        '
        Me.tb_jumlah.Location = New System.Drawing.Point(95, 92)
        Me.tb_jumlah.Name = "tb_jumlah"
        Me.tb_jumlah.ReadOnly = True
        Me.tb_jumlah.Size = New System.Drawing.Size(119, 20)
        Me.tb_jumlah.TabIndex = 44
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Nama"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(13, 144)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(409, 281)
        Me.DataGridView2.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(383, 121)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Copies"
        '
        'tbbanyak
        '
        Me.tbbanyak.Location = New System.Drawing.Point(346, 118)
        Me.tbbanyak.Name = "tbbanyak"
        Me.tbbanyak.Size = New System.Drawing.Size(31, 20)
        Me.tbbanyak.TabIndex = 40
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FPenerimaan_bayar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FPenerimaan_bayar"
        Me.Text = "FPenerimaan_bayar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.bt_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_tambahkan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_print, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelcari.ResumeLayout(False)
        Me.panelcari.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CariToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KodeTransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KodePemasukanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KodePengeluaranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BesaranGajiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MahasiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputMahasiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataMahasiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenerimaanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengeluaranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BelanjaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenggajianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeracaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KwitansiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KwitansiPemasukanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KwitansiPengeluaranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KwitansiPenggajianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RiwayatMahasiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerkategoriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_nomor As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents tb_nama As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_npm As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_semester As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_angkatan As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents rd_cash As System.Windows.Forms.RadioButton
    Friend WithEvents rd_transfer As System.Windows.Forms.RadioButton
    Friend WithEvents tb_bayar As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_kewajiban As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_sisa As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_total As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_penerima As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel13 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel14 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bt_save As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents bt_cancel As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents bt_edit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
    Friend WithEvents bt_tambahkan As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ToolTip4 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip5 As System.Windows.Forms.ToolTip
    Friend WithEvents bt_exit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ToolTip6 As System.Windows.Forms.ToolTip
    Friend WithEvents bt_print As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ToolTip7 As System.Windows.Forms.ToolTip
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tb_akun As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel16 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_uraian As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel15 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_kodeakun As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents g1 As System.Windows.Forms.PictureBox
    Friend WithEvents panelcari As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BunifuCustomTextbox1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents labeltitle As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents g2 As System.Windows.Forms.PictureBox
    Friend WithEvents dgv As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents tb_no As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbnama As System.Windows.Forms.TextBox
    Friend WithEvents bt_cetak As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_banyaknya As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tb_jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbbanyak As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
