Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Public Class FPenerimaan_bayar
    Public pembayaran, status As String
    Private keterangan As String
    Public ketkas As String = "uang terima"
    Public pengeluaran As Integer = 0
    Public a As String
    Declare Function ShellExecuteA Lib "shell32.dll" ( _
             ByVal hWnd As IntPtr, _
             ByVal lpOperation As String, _
             ByVal lpFile As String, _
             ByVal lpParameters As String, _
             ByVal lpDirectory As String, _
             ByVal nShowCmd As Integer) As IntPtr
    Private Sub CetakKondisi()
        Dim i As Integer
        Dim rpt As String
        Dim cPart, tContent As String
        Dim sekarang As String = "_TGL_" & Format(Now, "dd-MM-yy_mmss")
        Dim total As Integer = 0
        Dim totalsisa As Integer = 0
        Dim nominal As Integer = 0
        dt = New DataTable
        dt = getsql("select * from q_umhs where nama = '" & tbnama.Text & "'")
        rpt = File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) & "\kwitansiumhs.mht")
        tContent = ""

        For i = 0 To (dt.Rows.Count - 1)
            cPart = File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) & "\kwitansiumhs_content.mht")
            For o = 0 To (dgv.Rows.Count - 1)
                cPart = Replace(cPart, "[no]", dt.Rows(i)(o).ToString)
            Next
            cPart = Replace(cPart, "[tanggal]", dt.Rows(i)(1).ToString)
            cPart = Replace(cPart, "[kode]", dt.Rows(i)(6).ToString)
            cPart = Replace(cPart, "[akun]", dt.Rows(i)(7).ToString)
            cPart = Replace(cPart, "[uraian]", dt.Rows(i)(8).ToString)
            cPart = Replace(cPart, "[kewajiban]", dt.Rows(i)(9).ToString)
            cPart = Replace(cPart, "[bayar]", dt.Rows(i)(10).ToString)
            cPart = Replace(cPart, "[sisa]", dt.Rows(i)(11).ToString)
            cPart = Replace(cPart, "[ket]", dt.Rows(i)(12).ToString)
            'total = total + Val(dt.Rows(i)("jumlah").ToString)
            total = total + Val(dt.Rows(i)(10).ToString)
            totalsisa = dt.Rows(0)(9).ToString - total
            tContent = tContent & vbCrLf & cPart

        Next
        rpt = Replace(rpt, "[tgl]", "" & Format(Now, "dd MM yyyy"))
        rpt = Replace(rpt, "[totbayar]", total)
        rpt = Replace(rpt, "[totsisa]", totalsisa)
        rpt = Replace(rpt, "[terbilang]", tb_banyaknya.Text)

        'rpt = Replace(rpt, "[tf]", "" & Format(Now, "dd MM yyyy"))
        ' rpt = Replace(rpt, "[pn]", dt.Rows(0)("penerima").ToString)
        'rpt = Replace(rpt, "[jml]", total)
        rpt = Replace(rpt, "[n]", dt.Rows(0)(0).ToString)
        rpt = Replace(rpt, "[nama]", dt.Rows(0)(5).ToString)
        rpt = Replace(rpt, "[npm]", dt.Rows(0)(2).ToString)
        rpt = Replace(rpt, "[sem]", dt.Rows(0)(3).ToString)
        rpt = Replace(rpt, "[ang]", dt.Rows(0)(4).ToString)
        rpt = Replace(rpt, "[content]", tContent)


        'nominal = nominal + Val(dt.Rows(s)("jumlah").ToString)
        'rpt = Replace(rpt, "[nominal]", nominal)
        ' tContent = ""
        File.WriteAllText("D:\Data" & sekarang & ".xls", rpt)
        ShellExecuteA(Me.Handle, "open", "D:\Data" & sekarang & ".xls", "", "", 1)
    End Sub
    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles bt_exit.Click
        Me.Close()
    End Sub
    Public Sub datarefresh()
        dgv.DataSource = getsql("select nomor, tgl, kode_akun, nama_akun, dibayar, sisa, ket from t_umasuk")
        With dgv
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "No"
            .Columns(1).HeaderCell.Value = "Tanggal"
            .Columns(2).HeaderCell.Value = "Kode Akun"
            .Columns(3).HeaderCell.Value = "Nama Akun"
            .Columns(4).HeaderCell.Value = "Jumlah"
            .Columns(5).HeaderCell.Value = "Sisa"
            .Columns(6).HeaderCell.Value = "Keterangan"
            .Columns(0).Width = 150
            .Columns(1).Width = 120
            .Columns(2).Width = 150
            .Columns(3).Width = 200
            .Columns(4).Width = 200
            .Columns(5).Width = 200
            .Columns(6).Width = 344
        End With
    End Sub
    Public Sub matikan()
        tb_nama.Enabled = False
        tb_nomor.Enabled = False
        tb_semester.Enabled = False
        tb_angkatan.Enabled = False
        tb_bayar.Enabled = False
        rd_cash.Enabled = False
        rd_transfer.Enabled = False
        BunifuImageButton1.Enabled = False
        BunifuImageButton2.Enabled = False
        tb_akun.Enabled = False
        tb_kodeakun.Enabled = False
        tb_uraian.Enabled = False
        tb_kewajiban.Enabled = False
        tb_sisa.Enabled = False
        dtp_tanggal.Enabled = False
        tb_penerima.Enabled = False
        tb_total.Enabled = False

    End Sub
    Public Sub hidupkan()
        tb_nama.Enabled = True
        tb_nomor.Enabled = True
        tb_semester.Enabled = True
        tb_angkatan.Enabled = True
        tb_bayar.Enabled = True
        rd_cash.Enabled = True
        rd_transfer.Enabled = True
        BunifuImageButton1.Enabled = True
        BunifuImageButton2.Enabled = True
        tb_akun.Enabled = True
        tb_kodeakun.Enabled = True
        tb_uraian.Enabled = True
        tb_kewajiban.Enabled = True
        tb_sisa.Enabled = True
        dtp_tanggal.Enabled = True
        tb_penerima.Enabled = True
        tb_total.Enabled = True

    End Sub
    Private Sub FPenerimaan_bayar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call datarefresh()
        tb_nomor.Text = getnopenerimaanbayar()
        matikan()
        tanggal.Hide()
        tanggal.Format = DateTimePickerFormat.Custom
        tanggal.CustomFormat = "yyyy-MM-dd"
        panelcari.Hide()
        g1.Hide()
        bt_cancel.Enabled = False
        Label2.Enabled = False
        bt_save.Enabled = False
        Label1.Enabled = False
        bt_edit.Enabled = False
        Label3.Enabled = False
        bt_print.Enabled = False
        Label7.Enabled = False
        status = "input"
        Panel2.Hide()
    End Sub

    Private Sub rd_cash_CheckedChanged(sender As Object, e As EventArgs) Handles rd_cash.CheckedChanged
        If rd_cash.Checked = True Then
            pembayaran = "Cash"
            keterangan = "Cash"
        End If
    End Sub

    Private Sub rd_transfer_CheckedChanged(sender As Object, e As EventArgs) Handles rd_transfer.CheckedChanged
        If rd_transfer.Checked = True Then
            pembayaran = "Transfer"
            tanggal.Show()
            tanggal.Format = DateTimePickerFormat.Custom
            tanggal.CustomFormat = "yyyy-MM-dd"
            keterangan = "Transfer"
        Else
            tanggal.Hide()
        End If
    End Sub
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        status = "akun"
        labeltitle.Text = "Cari Data Akun"
        panelcari.Show()
        g1.Show()
    End Sub
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        status = "mhs"
        labeltitle.Text = "Cari Data Dosen"
        panelcari.Show()
        g1.Show()
    End Sub
    Public Sub ubah()
        status = "update"

        If tb_nomor.Text = getnopenerimaanbayar() Then
            tb_nomor.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value
            tb_kodeakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(2).Value
            tb_akun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(3).Value
            tb_bayar.Text = 0
            tb_sisa.Text = Val(dgv.Rows(dgv.CurrentRow.Index).Cells(5).Value) + Val(dgv.Rows(dgv.CurrentRow.Index).Cells(4).Value)
            If tb_nomor.Text <> "" Then
                dt = New DataTable
                dt = getsql("Select * from t_umasuk where nomor = '" & tb_nomor.Text & "'")
                If dt.Rows.Count > 0 Then
                    tb_nama.Text = dt.Rows(0)(3).ToString
                    tb_npm.Text = dt.Rows(0)(2).ToString
                    tb_penerima.Text = dt.Rows(0)(10).ToString
                    tb_uraian.Text = dt.Rows(0)(6).ToString
                    tb_kewajiban.Text = dt.Rows(0)(7).ToString
                Else
                    MsgBox("Kode tidak terdaftar")
                End If
            Else
                MsgBox("Kode harus diisi")
            End If
            If tb_npm.Text <> "" Then
                dt = New DataTable
                dt = getsql("Select * from t_mhs where npm = '" & tb_npm.Text & "'")
                If dt.Rows.Count > 0 Then
                    tb_semester.Text = dt.Rows(0)(3).ToString
                    tb_angkatan.Text = dt.Rows(0)(4).ToString
                Else
                    MsgBox("Kode tidak terdaftar")
                End If
            Else
                MsgBox("Kode harus diisi")
            End If

            tb_bayar.Focus()
        ElseIf tb_nomor.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value Then
            If pembayaran = "Cash" Then
                setsql("update t_umasuk set tgl ='" & Today.ToString("yyyy-MM-dd") & "', npm ='" & tb_npm.Text & "', nama ='" & tb_nama.Text & "', kode_akun ='" & tb_kodeakun.Text & "', nama_akun ='" & tb_akun.Text & "', uraian ='" & tb_uraian.Text & "', kewajiban ='" & tb_kewajiban.Text & "', dibayar ='" & tb_bayar.Text & "',sisa ='" & tb_sisa.Text & "',penerima ='" & tb_penerima.Text & "',ket ='" & keterangan & "' where nomor ='" & tb_nomor.Text & "'")
                setsql("update t_ukwajib set jumlah='" & tb_sisa.Text & "' where  kode_akun ='" & tb_kodeakun.Text & "'")
                setsql("update t_kas set tgl ='" & Today.ToString("yyyy-MM-dd") & "', uraian ='" & tb_uraian.Text & "', kode_akun ='" & tb_kodeakun.Text & "', nama_akun ='" & tb_akun.Text & "', penerimaan ='" & tb_bayar.Text & "' where no ='" & tb_nomor.Text & "'")
                datarefresh()
                hapussemua()
                tb_nama.Focus()
                status = "input"
                bt_save.Visible = True
                Label1.Visible = True
                tb_nomor.Text = getnopenerimaanbayar()
            ElseIf pembayaran = "Transfer" Then
                setsql("update t_umasuk set tgl ='" & tanggal.Text & "', npm ='" & tb_npm.Text & "', nama ='" & tb_nama.Text & "', kode_akun ='" & tb_kodeakun.Text & "', nama_akun ='" & tb_akun.Text & "', uraian ='" & tb_uraian.Text & "', kewajiban ='" & tb_kewajiban.Text & "', dibayar ='" & tb_bayar.Text & "',sisa ='" & tb_sisa.Text & "',penerima ='" & tb_penerima.Text & "',ket ='" & keterangan & "' where nomor ='" & tb_nomor.Text & "'")
                setsql("update t_ukwajib set jumlah='" & tb_sisa.Text & "' where  kode_akun ='" & tb_kodeakun.Text & "'")
                setsql("update t_kas set tgl ='" & tanggal.Text & "', uraian ='" & tb_uraian.Text & "', kode_akun ='" & tb_kodeakun.Text & "', nama_akun ='" & tb_akun.Text & "', penerimaan ='" & tb_bayar.Text & "' where no ='" & tb_nomor.Text & "'")
                datarefresh()
                hapussemua()
                tb_nama.Focus()
                status = "input"
                bt_save.Visible = True
                Label1.Visible = True
                tb_nomor.Text = getnopenerimaanbayar()
            Else
                MsgBox("Mohon untuk diisi Metode pembayaran nya", MsgBoxStyle.Information, "Perhatian")
                rd_cash.Focus()
            End If
        ElseIf tb_nomor.Text <> getnopenerimaanbayar() Then
            tb_nomor.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value
            tb_kodeakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(2).Value
            tb_akun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(3).Value
            tb_bayar.Text = 0
            tb_sisa.Text = Val(dgv.Rows(dgv.CurrentRow.Index).Cells(5).Value) + Val(dgv.Rows(dgv.CurrentRow.Index).Cells(4).Value)
            If tb_nomor.Text <> "" Then
                dt = New DataTable
                dt = getsql("Select * from t_umasuk where nomor = '" & tb_nomor.Text & "'")
                If dt.Rows.Count > 0 Then
                    tb_nama.Text = dt.Rows(0)(3).ToString
                    tb_npm.Text = dt.Rows(0)(2).ToString
                    tb_penerima.Text = dt.Rows(0)(10).ToString
                    tb_uraian.Text = dt.Rows(0)(6).ToString
                    tb_kewajiban.Text = dt.Rows(0)(7).ToString
                Else
                    MsgBox("Kode tidak terdaftar")
                End If
            Else
                MsgBox("Kode harus diisi")
            End If
            If tb_npm.Text <> "" Then
                dt = New DataTable
                dt = getsql("Select * from t_mhs where npm = '" & tb_npm.Text & "'")
                If dt.Rows.Count > 0 Then
                    tb_semester.Text = dt.Rows(0)(3).ToString
                    tb_angkatan.Text = dt.Rows(0)(4).ToString
                Else
                    MsgBox("Kode tidak terdaftar")
                End If
            Else
                MsgBox("Kode harus diisi")
            End If

            tb_bayar.Focus()
        End If
    End Sub

    Private Sub tb_bayar_Click(sender As Object, e As EventArgs) Handles tb_bayar.Click

    End Sub

    Private Sub tb_bayar_CursorChanged(sender As Object, e As EventArgs) Handles tb_bayar.CursorChanged

    End Sub

    Private Sub tb_bayar_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_bayar.KeyDown

    End Sub

    Private Sub tb_bayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_bayar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
        If e.KeyChar = Chr(13) Then
            tb_total.Text = tb_bayar.Text
            tb_penerima.Focus()
        End If

    End Sub

    Private Sub tb_bayar_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_bayar.KeyUp

        If tb_bayar.Text = "" Then
            tb_bayar.Text = "0"
        ElseIf tb_bayar.Text <> "0" Then
            If status = "update" Then
                Dim dtubahsisaup As New DataTable
                dtubahsisaup = getsql("select * from t_umasuk where nomor = '" & tb_nomor.Text & "'")
                tb_sisa.Text = (Val(dtubahsisaup.Rows(0)(8)) + Val(dtubahsisaup.Rows(0)(9))) - Val(tb_bayar.Text)
            Else
                Dim dtp As New DataTable
                dtp = getsql("select * from t_ukwajib where kode_akun = '" & tb_kodeakun.Text & "'")
                If dt.Rows.Count > 0 Then
                    tb_sisa.Text = dtp.Rows(0)(4).ToString - tb_bayar.Text
                Else
                    MsgBox("Kode Akun tidak terdaftar")
                End If
            End If


        Else
        End If
    End Sub

    Private Sub tb_bayar_ModifiedChanged(sender As Object, e As EventArgs) Handles tb_bayar.ModifiedChanged

    End Sub
    Public Sub hapussemua(Optional ByVal ctlcol As Control.ControlCollection = Nothing)
        If ctlcol Is Nothing Then ctlcol = Me.Controls
        For Each ctl As Control In ctlcol
            If TypeOf (ctl) Is TextBox Then
                DirectCast(ctl, TextBox).Clear()
            Else
                If Not ctl.Controls Is Nothing OrElse ctl.Controls.Count <> 0 Then
                    hapussemua(ctl.Controls)
                End If
            End If
        Next
    End Sub
    Public Sub input()
        status = "input"
        If pembayaran = "Cash" Then
            setsql("insert into t_umasuk values('" & tb_nomor.Text & "','" & Today.ToString("yyyy-MM-dd") & "','" & tb_npm.Text & "','" & tb_nama.Text & "','" & tb_kodeakun.Text & "','" & tb_akun.Text & "','" & tb_uraian.Text & "','" & tb_kewajiban.Text & "','" & tb_bayar.Text & "','" & tb_sisa.Text & "','" & tb_penerima.Text & "','" & keterangan & "')")
            setsql("update t_ukwajib set jumlah='" & tb_sisa.Text & "' where  kode_akun ='" & tb_kodeakun.Text & "'")
            setsql("insert into t_kas values('" & tb_nomor.Text & "','" & Today.ToString("yyyy-MM-dd") & "','" & tb_uraian.Text & "','" & tb_kodeakun.Text & "','" & tb_akun.Text & "','" & tb_bayar.Text & "','" & pengeluaran & "','" & ketkas & "')")

            Panel2.Show()

        ElseIf pembayaran = "Transfer" Then
            setsql("insert into t_umasuk values('" & tb_nomor.Text & "','" & tanggal.Text & "','" & tb_npm.Text & "','" & tb_nama.Text & "','" & tb_kodeakun.Text & "','" & tb_akun.Text & "','" & tb_uraian.Text & "','" & tb_kewajiban.Text & "','" & tb_bayar.Text & "','" & tb_sisa.Text & "','" & tb_penerima.Text & "','" & keterangan & "')")
            setsql("update t_ukwajib set jumlah='" & tb_sisa.Text & "' where  kode_akun ='" & tb_kodeakun.Text & "'")
            setsql("insert into t_kas values('" & tb_nomor.Text & "','" & tanggal.Text & "','" & tb_uraian.Text & "','" & tb_kodeakun.Text & "','" & tb_akun.Text & "','" & tb_bayar.Text & "','" & pengeluaran & "','" & ketkas & "')")

            hapussemua()
            rd_transfer.Checked = False
            MsgBox("Pembayaran Berhasil")
            tb_nomor.Text = getnopenerimaanbayar()
            tb_nama.Focus()
        End If
    End Sub
    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        input()
        datarefresh()
        Panel2.Show()
        tbbanyak.Text = "2"
        tbnama.Text = tb_nama.Text
        tb_jumlah.Text = tb_bayar.Text
        If tb_jumlah.Text <> "" Then
            tb_banyaknya.Text = TERBILANG(Val(tb_jumlah.Text))
        End If
    End Sub
    Public Sub cariid()
        If status = "mhs" Then
            DataGridView1.DataSource = getsql("select * from t_mhs")

        ElseIf status = "akun" Then
            DataGridView1.DataSource = getsql("select * from t_ukwajib")
        End If
    End Sub
    Private Sub panelcari_Paint_1(sender As Object, e As PaintEventArgs) Handles panelcari.Paint
        cariid()

    End Sub
    Private Sub DataGridView1_CellDoubleClick1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        If status = "mhs" Then
            tb_nama.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            tb_npm.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
            tb_semester.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
            tb_angkatan.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
            panelcari.Hide()
            g1.Hide()
            tb_nama.Focus()
        ElseIf status = "akun" Then

            tb_akun.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
            tb_kodeakun.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            tb_uraian.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
            If tb_akun.Text <> "" Then
                dt = New DataTable
                dt = getsql("Select * from t_kodepemasukan where nama_akun = '" & tb_akun.Text & "'")
                If dt.Rows.Count > 0 Then
                    tb_kewajiban.Text = dt.Rows(0)(3).ToString
                Else
                    MsgBox("Kode tidak terdaftar")
                End If
            Else
                MsgBox("Kode harus diisi")
            End If
            tb_sisa.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
            panelcari.Hide()
            g1.Hide()
            tb_bayar.Text = "0"
            tb_bayar.Focus()
        End If

    End Sub

    Private Sub tb_sisa_TextChanged(sender As Object, e As EventArgs) Handles tb_sisa.TextChanged


    End Sub

    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click
        hidupkan()
        ubah()
        bt_save.Visible = False
        Label1.Visible = False
        bt_cancel.Visible = True
        Label2.Visible = True
    End Sub

    Private Sub bt_status_Click(sender As Object, e As EventArgs)
        FStatus_Bayar_Siswa.Show()
    End Sub

    Private Sub tb_bayar_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tb_bayar.MouseDoubleClick

    End Sub

    Private Sub tb_bayar_TextChanged(sender As Object, e As EventArgs) Handles tb_bayar.TextChanged
        If tb_bayar.Text = "0" Then
            If status = "update" Then
                Dim dtubahsisaup As New DataTable
                dtubahsisaup = getsql("select * from t_umasuk where nomor = '" & tb_nomor.Text & "'")
                tb_sisa.Text = Val(dtubahsisaup.Rows(0)(8)) + Val(dtubahsisaup.Rows(0)(9))
            Else
                Dim dtss As New DataTable
                dtss = getsql("select * from t_ukwajib where kode_akun = '" & tb_kodeakun.Text & "'")
                If dt.Rows.Count > 0 Then
                    tb_sisa.Text = dtss.Rows(0)(4).ToString
                Else
                End If

            End If

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click

    End Sub

    Private Sub bt_tambahkan_Click(sender As Object, e As EventArgs) Handles bt_tambahkan.Click
        hidupkan()
        tb_nama.Focus()
        bt_save.Enabled = True
        Label1.Enabled = True
        bt_cancel.Enabled = True
        Label2.Enabled = True
        If dgv.Rows.Count <> 0 Then
            bt_edit.Enabled = True
            Label3.Enabled = True
        Else
            bt_edit.Enabled = False
            Label3.Enabled = False
        End If
        status = "input"
    End Sub

    Private Sub tanggal_ValueChanged(sender As Object, e As EventArgs) Handles tanggal.ValueChanged

    End Sub

    Private Sub g2_Click(sender As Object, e As EventArgs) Handles g2.Click

    End Sub

    Private Sub g1_Click(sender As Object, e As EventArgs) Handles g1.Click
        panelcari.Hide()
        g1.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub bt_cancel_Click(sender As Object, e As EventArgs) Handles bt_cancel.Click
        hapussemua()
        matikan()
        bt_save.Enabled = False
        Label1.Enabled = False
        bt_tambahkan.Enabled = True
        Label4.Enabled = True
        bt_cancel.Enabled = False
        Label2.Enabled = False
    End Sub

    Private Sub tb_total_TextChanged(sender As Object, e As EventArgs) Handles tb_total.TextChanged

    End Sub

    Private Sub tb_penerima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_penerima.KeyPress
        If e.KeyChar = Chr(13) Then
            If status = "input" Then
                input()
                datarefresh()
            ElseIf status = "update" Then
                ubah()
                datarefresh()

            End If
        End If

    End Sub

    Private Sub tb_penerima_TextChanged(sender As Object, e As EventArgs) Handles tb_penerima.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel2.Hide()
        hapussemua()
        rd_cash.Checked = False
        MsgBox("Pembayaran Berhasil")
        tb_nomor.Text = getnopenerimaanbayar()
        tb_nama.Focus()
        bt_cancel.Visible = False
        Label2.Visible = False
        status = "input"
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub

    Private Sub bt_cetak_Click(sender As Object, e As EventArgs) Handles bt_cetak.Click
        ' PrintDialog1.Document = PrintDocument1
        'PrintDialog1.PrinterSettings.Collate = True
        ' If Not IsNumeric(tbbanyak.Text) Then
        'ErrorProvider1.SetError(tbbanyak, "Silahkan isi terlebih dahulu banyak copy yang diinginkan")
        ' Else
        ' ErrorProvider1.SetError(tbbanyak, "")
        'PrintDialog1.PrinterSettings.Copies = CInt(tbbanyak.Text)
        'PrintDialog1.PrinterSettings.FromPage = 1
        'PrintDialog1.PrinterSettings.ToPage = 5
        'If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        'PrintDocument1.Print()
        'End If
        'End If
        CetakKondisi()

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

    End Sub
End Class