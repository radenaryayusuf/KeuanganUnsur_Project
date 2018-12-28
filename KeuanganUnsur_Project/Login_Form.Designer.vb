<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btlogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tpass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tuser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btsave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel2.Controls.Add(Me.btlogin)
        Me.Panel2.Controls.Add(Me.tpass)
        Me.Panel2.Controls.Add(Me.tuser)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'BunifuCustomLabel1
        '
        resources.ApplyResources(Me.BunifuCustomLabel1, "BunifuCustomLabel1")
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        '
        'btlogin
        '
        Me.btlogin.Activecolor = System.Drawing.Color.DarkGray
        Me.btlogin.BackColor = System.Drawing.Color.Firebrick
        resources.ApplyResources(Me.btlogin, "btlogin")
        Me.btlogin.BorderRadius = 3
        Me.btlogin.ButtonText = "LOGIN"
        Me.btlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btlogin.DisabledColor = System.Drawing.Color.Gray
        Me.btlogin.Iconcolor = System.Drawing.Color.Transparent
        Me.btlogin.Iconimage = CType(resources.GetObject("btlogin.Iconimage"), System.Drawing.Image)
        Me.btlogin.Iconimage_right = Nothing
        Me.btlogin.Iconimage_right_Selected = Nothing
        Me.btlogin.Iconimage_Selected = Nothing
        Me.btlogin.IconMarginLeft = 0
        Me.btlogin.IconMarginRight = 0
        Me.btlogin.IconRightVisible = False
        Me.btlogin.IconRightZoom = 0.0R
        Me.btlogin.IconVisible = False
        Me.btlogin.IconZoom = 90.0R
        Me.btlogin.IsTab = False
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Normalcolor = System.Drawing.Color.Firebrick
        Me.btlogin.OnHovercolor = System.Drawing.Color.Firebrick
        Me.btlogin.OnHoverTextColor = System.Drawing.Color.White
        Me.btlogin.selected = False
        Me.btlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btlogin.Textcolor = System.Drawing.Color.White
        Me.btlogin.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tpass
        '
        Me.tpass.Cursor = System.Windows.Forms.Cursors.IBeam
        resources.ApplyResources(Me.tpass, "tpass")
        Me.tpass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tpass.HintForeColor = System.Drawing.Color.Empty
        Me.tpass.HintText = ""
        Me.tpass.isPassword = True
        Me.tpass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpass.LineIdleColor = System.Drawing.Color.DarkGray
        Me.tpass.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpass.LineThickness = 3
        Me.tpass.Name = "tpass"
        Me.tpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tuser
        '
        Me.tuser.Cursor = System.Windows.Forms.Cursors.IBeam
        resources.ApplyResources(Me.tuser, "tuser")
        Me.tuser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tuser.HintForeColor = System.Drawing.Color.Empty
        Me.tuser.HintText = ""
        Me.tuser.isPassword = False
        Me.tuser.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tuser.LineIdleColor = System.Drawing.Color.DarkGray
        Me.tuser.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tuser.LineThickness = 3
        Me.tuser.Name = "tuser"
        Me.tuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KeuanganUnsur_Project.My.Resources.Resources.Logo_MIHU_3D
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'btsave
        '
        Me.btsave.Activecolor = System.Drawing.Color.Red
        Me.btsave.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btsave, "btsave")
        Me.btsave.BorderRadius = 0
        Me.btsave.ButtonText = "X"
        Me.btsave.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btsave.DisabledColor = System.Drawing.Color.Gray
        Me.btsave.ForeColor = System.Drawing.Color.White
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
        Me.btsave.Name = "btsave"
        Me.btsave.Normalcolor = System.Drawing.Color.Transparent
        Me.btsave.OnHovercolor = System.Drawing.Color.Red
        Me.btsave.OnHoverTextColor = System.Drawing.Color.White
        Me.btsave.selected = False
        Me.btsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btsave.Textcolor = System.Drawing.Color.White
        Me.btsave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.Firebrick
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.BunifuFlatButton1, "BunifuFlatButton1")
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "_"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0.0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.IndianRed
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Login_Form
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.btsave)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login_Form"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btlogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tpass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tuser As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btsave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
End Class
