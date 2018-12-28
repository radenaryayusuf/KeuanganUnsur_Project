<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FReport_UMHS
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_banyaknya = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_jumlah = New System.Windows.Forms.TextBox()
        Me.cb_nama = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bt_keluar = New System.Windows.Forms.Button()
        Me.bt_cetak = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.tbbanyak = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(47, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(201, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Banyaknya"
        '
        'tb_banyaknya
        '
        Me.tb_banyaknya.Location = New System.Drawing.Point(129, 98)
        Me.tb_banyaknya.Name = "tb_banyaknya"
        Me.tb_banyaknya.Size = New System.Drawing.Size(204, 20)
        Me.tb_banyaknya.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Jumlah"
        '
        'tb_jumlah
        '
        Me.tb_jumlah.Location = New System.Drawing.Point(129, 72)
        Me.tb_jumlah.Name = "tb_jumlah"
        Me.tb_jumlah.Size = New System.Drawing.Size(119, 20)
        Me.tb_jumlah.TabIndex = 18
        '
        'cb_nama
        '
        Me.cb_nama.FormattingEnabled = True
        Me.cb_nama.Location = New System.Drawing.Point(129, 45)
        Me.cb_nama.Name = "cb_nama"
        Me.cb_nama.Size = New System.Drawing.Size(119, 21)
        Me.cb_nama.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nama"
        '
        'bt_keluar
        '
        Me.bt_keluar.Location = New System.Drawing.Point(772, 37)
        Me.bt_keluar.Name = "bt_keluar"
        Me.bt_keluar.Size = New System.Drawing.Size(86, 35)
        Me.bt_keluar.TabIndex = 15
        Me.bt_keluar.Text = "EXIT"
        Me.bt_keluar.UseVisualStyleBackColor = True
        '
        'bt_cetak
        '
        Me.bt_cetak.Location = New System.Drawing.Point(662, 37)
        Me.bt_cetak.Name = "bt_cetak"
        Me.bt_cetak.Size = New System.Drawing.Size(86, 35)
        Me.bt_cetak.TabIndex = 14
        Me.bt_cetak.Text = "CETAK "
        Me.bt_cetak.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(47, 124)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(811, 281)
        Me.dgv.TabIndex = 13
        '
        'tbbanyak
        '
        Me.tbbanyak.Location = New System.Drawing.Point(302, 12)
        Me.tbbanyak.Name = "tbbanyak"
        Me.tbbanyak.Size = New System.Drawing.Size(31, 20)
        Me.tbbanyak.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(339, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Copies"
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
        'FReport_UMHS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 422)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbbanyak)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_banyaknya)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_jumlah)
        Me.Controls.Add(Me.cb_nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bt_keluar)
        Me.Controls.Add(Me.bt_cetak)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "FReport_UMHS"
        Me.Text = "FReport_UMHS"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_banyaknya As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_jumlah As System.Windows.Forms.TextBox
    Friend WithEvents cb_nama As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_keluar As System.Windows.Forms.Button
    Friend WithEvents bt_cetak As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents tbbanyak As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
