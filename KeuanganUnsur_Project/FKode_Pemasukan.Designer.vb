<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FKode_Pemasukan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FKode_Pemasukan))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_exit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bt_edit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tcatatan = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.turaian = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tnamaakun = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tkodeakun = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tkewajiban = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bt_Keluar = New System.Windows.Forms.ToolStripButton()
        Me.tbnomor = New System.Windows.Forms.TextBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(268, 313)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(782, 345)
        Me.dgv.TabIndex = 162
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.White
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(982, 238)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(55, 49)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 161
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'bt_exit
        '
        Me.bt_exit.BackColor = System.Drawing.Color.White
        Me.bt_exit.Image = CType(resources.GetObject("bt_exit.Image"), System.Drawing.Image)
        Me.bt_exit.ImageActive = Nothing
        Me.bt_exit.Location = New System.Drawing.Point(903, 238)
        Me.bt_exit.Name = "bt_exit"
        Me.bt_exit.Size = New System.Drawing.Size(55, 49)
        Me.bt_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_exit.TabIndex = 160
        Me.bt_exit.TabStop = False
        Me.bt_exit.Zoom = 10
        '
        'bt_edit
        '
        Me.bt_edit.BackColor = System.Drawing.Color.White
        Me.bt_edit.Image = CType(resources.GetObject("bt_edit.Image"), System.Drawing.Image)
        Me.bt_edit.ImageActive = Nothing
        Me.bt_edit.Location = New System.Drawing.Point(824, 238)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(55, 49)
        Me.bt_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bt_edit.TabIndex = 159
        Me.bt_edit.TabStop = False
        Me.bt_edit.Zoom = 10
        '
        'tcatatan
        '
        Me.tcatatan.BorderColor = System.Drawing.Color.SeaGreen
        Me.tcatatan.Location = New System.Drawing.Point(432, 238)
        Me.tcatatan.Multiline = True
        Me.tcatatan.Name = "tcatatan"
        Me.tcatatan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tcatatan.Size = New System.Drawing.Size(269, 65)
        Me.tcatatan.TabIndex = 158
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(314, 236)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(66, 20)
        Me.BunifuCustomLabel4.TabIndex = 157
        Me.BunifuCustomLabel4.Text = "Catatan"
        '
        'turaian
        '
        Me.turaian.BorderColor = System.Drawing.Color.SeaGreen
        Me.turaian.Location = New System.Drawing.Point(432, 176)
        Me.turaian.Name = "turaian"
        Me.turaian.Size = New System.Drawing.Size(269, 20)
        Me.turaian.TabIndex = 156
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(314, 174)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(56, 20)
        Me.BunifuCustomLabel3.TabIndex = 155
        Me.BunifuCustomLabel3.Text = "Uraian"
        '
        'tnamaakun
        '
        Me.tnamaakun.BorderColor = System.Drawing.Color.SeaGreen
        Me.tnamaakun.Location = New System.Drawing.Point(432, 141)
        Me.tnamaakun.Name = "tnamaakun"
        Me.tnamaakun.Size = New System.Drawing.Size(269, 20)
        Me.tnamaakun.TabIndex = 154
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(314, 139)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(92, 20)
        Me.BunifuCustomLabel2.TabIndex = 153
        Me.BunifuCustomLabel2.Text = "Nama Akun"
        '
        'tkodeakun
        '
        Me.tkodeakun.BorderColor = System.Drawing.Color.SeaGreen
        Me.tkodeakun.Location = New System.Drawing.Point(432, 110)
        Me.tkodeakun.Name = "tkodeakun"
        Me.tkodeakun.Size = New System.Drawing.Size(269, 20)
        Me.tkodeakun.TabIndex = 152
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(314, 108)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(87, 20)
        Me.BunifuCustomLabel6.TabIndex = 151
        Me.BunifuCustomLabel6.Text = "Kode Akun"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Gadugi", 19.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(16, 12)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(77, 31)
        Me.BunifuCustomLabel1.TabIndex = 148
        Me.BunifuCustomLabel1.Text = "Kode"
        '
        'tkewajiban
        '
        Me.tkewajiban.BorderColor = System.Drawing.Color.SeaGreen
        Me.tkewajiban.Location = New System.Drawing.Point(432, 208)
        Me.tkewajiban.Name = "tkewajiban"
        Me.tkewajiban.Size = New System.Drawing.Size(269, 20)
        Me.tkewajiban.TabIndex = 164
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(314, 206)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(81, 20)
        Me.BunifuCustomLabel7.TabIndex = 163
        Me.BunifuCustomLabel7.Text = "Kewajiban"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Location = New System.Drawing.Point(-5, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1376, 56)
        Me.Panel1.TabIndex = 165
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Gadugi", 19.0!)
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(85, 13)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(144, 30)
        Me.BunifuCustomLabel8.TabIndex = 148
        Me.BunifuCustomLabel8.Text = "Pemasukan"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(-3, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(265, 709)
        Me.Panel2.TabIndex = 166
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(33, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 195)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.White
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(744, 238)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(55, 49)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 159
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(983, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "Keluar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(903, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Hapus"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(828, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 176
        Me.Label2.Text = "Ubah"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(740, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "Tambah"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bt_Keluar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1062, 25)
        Me.ToolStrip1.TabIndex = 178
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
        'tbnomor
        '
        Me.tbnomor.Location = New System.Drawing.Point(1063, 108)
        Me.tbnomor.Name = "tbnomor"
        Me.tbnomor.Size = New System.Drawing.Size(100, 20)
        Me.tbnomor.TabIndex = 179
        '
        'FKode_Pemasukan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1062, 670)
        Me.Controls.Add(Me.tbnomor)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.tkewajiban)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.bt_exit)
        Me.Controls.Add(Me.BunifuImageButton2)
        Me.Controls.Add(Me.bt_edit)
        Me.Controls.Add(Me.tcatatan)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.turaian)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.tnamaakun)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.tkodeakun)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FKode_Pemasukan"
        Me.Text = "FKode_Pemasukan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_edit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_exit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bt_edit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tcatatan As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents turaian As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tnamaakun As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tkodeakun As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tkewajiban As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bt_Keluar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbnomor As System.Windows.Forms.TextBox
End Class
