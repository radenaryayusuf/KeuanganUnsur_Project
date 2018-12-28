<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Freport_Pengeluaran
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.bt_cetak = New System.Windows.Forms.Button()
        Me.bt_keluar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_penerima = New System.Windows.Forms.ComboBox()
        Me.tb_jumlah = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_banyaknya = New System.Windows.Forms.TextBox()
        Me.kas = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(46, 184)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(811, 281)
        Me.dgv.TabIndex = 0
        '
        'bt_cetak
        '
        Me.bt_cetak.Location = New System.Drawing.Point(661, 108)
        Me.bt_cetak.Name = "bt_cetak"
        Me.bt_cetak.Size = New System.Drawing.Size(86, 35)
        Me.bt_cetak.TabIndex = 2
        Me.bt_cetak.Text = "CETAK "
        Me.bt_cetak.UseVisualStyleBackColor = True
        '
        'bt_keluar
        '
        Me.bt_keluar.Location = New System.Drawing.Point(771, 108)
        Me.bt_keluar.Name = "bt_keluar"
        Me.bt_keluar.Size = New System.Drawing.Size(86, 35)
        Me.bt_keluar.TabIndex = 3
        Me.bt_keluar.Text = "EXIT"
        Me.bt_keluar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(46, 75)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(201, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Penerima"
        '
        'cb_penerima
        '
        Me.cb_penerima.FormattingEnabled = True
        Me.cb_penerima.Location = New System.Drawing.Point(128, 105)
        Me.cb_penerima.Name = "cb_penerima"
        Me.cb_penerima.Size = New System.Drawing.Size(119, 21)
        Me.cb_penerima.TabIndex = 8
        '
        'tb_jumlah
        '
        Me.tb_jumlah.Location = New System.Drawing.Point(128, 132)
        Me.tb_jumlah.Name = "tb_jumlah"
        Me.tb_jumlah.Size = New System.Drawing.Size(119, 20)
        Me.tb_jumlah.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Banyaknya"
        '
        'tb_banyaknya
        '
        Me.tb_banyaknya.Location = New System.Drawing.Point(128, 158)
        Me.tb_banyaknya.Name = "tb_banyaknya"
        Me.tb_banyaknya.Size = New System.Drawing.Size(204, 20)
        Me.tb_banyaknya.TabIndex = 11
        '
        'kas
        '
        Me.kas.AutoSize = True
        Me.kas.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kas.Location = New System.Drawing.Point(336, 26)
        Me.kas.Name = "kas"
        Me.kas.Size = New System.Drawing.Size(252, 31)
        Me.kas.TabIndex = 37
        Me.kas.Text = "Report Pengeluaran "
        '
        'Freport_Pengeluaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 500)
        Me.Controls.Add(Me.kas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_banyaknya)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_jumlah)
        Me.Controls.Add(Me.cb_penerima)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_keluar)
        Me.Controls.Add(Me.bt_cetak)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Freport_Pengeluaran"
        Me.Text = "Freport_Pengeluaran"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents bt_cetak As System.Windows.Forms.Button
    Friend WithEvents bt_keluar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cb_penerima As System.Windows.Forms.ComboBox
    Friend WithEvents tb_jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_banyaknya As System.Windows.Forms.TextBox
    Friend WithEvents kas As System.Windows.Forms.Label
End Class
