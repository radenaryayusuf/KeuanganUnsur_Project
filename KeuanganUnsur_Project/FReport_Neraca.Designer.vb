<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FReport_Neraca
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
        Me.btprint = New System.Windows.Forms.Button()
        Me.dgvsbp = New System.Windows.Forms.DataGridView()
        Me.cbtahun = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbbulan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kas = New System.Windows.Forms.Label()
        CType(Me.dgvsbp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btprint
        '
        Me.btprint.Location = New System.Drawing.Point(471, 79)
        Me.btprint.Name = "btprint"
        Me.btprint.Size = New System.Drawing.Size(107, 40)
        Me.btprint.TabIndex = 60
        Me.btprint.Text = "Print"
        Me.btprint.UseVisualStyleBackColor = True
        '
        'dgvsbp
        '
        Me.dgvsbp.AllowUserToAddRows = False
        Me.dgvsbp.AllowUserToDeleteRows = False
        Me.dgvsbp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsbp.Location = New System.Drawing.Point(87, 160)
        Me.dgvsbp.Name = "dgvsbp"
        Me.dgvsbp.ReadOnly = True
        Me.dgvsbp.Size = New System.Drawing.Size(539, 281)
        Me.dgvsbp.TabIndex = 59
        '
        'cbtahun
        '
        Me.cbtahun.FormattingEnabled = True
        Me.cbtahun.Location = New System.Drawing.Point(257, 90)
        Me.cbtahun.Name = "cbtahun"
        Me.cbtahun.Size = New System.Drawing.Size(121, 21)
        Me.cbtahun.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Tahun"
        '
        'cbbulan
        '
        Me.cbbulan.FormattingEnabled = True
        Me.cbbulan.Location = New System.Drawing.Point(78, 90)
        Me.cbbulan.Name = "cbbulan"
        Me.cbbulan.Size = New System.Drawing.Size(121, 21)
        Me.cbbulan.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Bulan"
        '
        'kas
        '
        Me.kas.AutoSize = True
        Me.kas.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kas.Location = New System.Drawing.Point(273, 15)
        Me.kas.Name = "kas"
        Me.kas.Size = New System.Drawing.Size(181, 31)
        Me.kas.TabIndex = 54
        Me.kas.Text = "Report Neraca"
        '
        'FReport_Neraca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 456)
        Me.Controls.Add(Me.btprint)
        Me.Controls.Add(Me.dgvsbp)
        Me.Controls.Add(Me.cbtahun)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbbulan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.kas)
        Me.Name = "FReport_Neraca"
        Me.Text = "FReport_Neraca"
        CType(Me.dgvsbp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btprint As System.Windows.Forms.Button
    Friend WithEvents dgvsbp As System.Windows.Forms.DataGridView
    Friend WithEvents cbtahun As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbbulan As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents kas As System.Windows.Forms.Label
End Class
