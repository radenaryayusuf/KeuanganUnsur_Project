Imports System.Data.OleDb

Public Class FStatus_Bayar_Siswa
    Public Sub datarefresh()
        dgv.DataSource = getsql("select * from q_status")
        With dgv
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Kode Akun"
            .Columns(1).HeaderCell.Value = "Nama Akun"
            .Columns(2).HeaderCell.Value = "Nama Mahasiswa"
            .Columns(3).HeaderCell.Value = "NPM"
            .Columns(4).HeaderCell.Value = "Kewajiban"
            .Columns(5).HeaderCell.Value = "Pembayaran"
            .Columns(6).HeaderCell.Value = "Tunggakan"
            .Columns(7).HeaderCell.Value = "Keterangan"
            .Columns(4).DefaultCellStyle.Format = "C"
            .Columns(5).DefaultCellStyle.Format = "C"
            .Columns(6).DefaultCellStyle.Format = "C"
        End With
    End Sub
    Public Sub matikan()
        tb_nomor.Enabled = False
        tb_nama.Enabled = False
        tb_angkatan.Enabled = False
        tb_npm.Enabled = False
        tb_semester.Enabled = False
        tb_bayar.Enabled = False
        tb_kewajiban.Enabled = False
        tb_tunggakan.Enabled = False
    End Sub
    Private Sub FStatus_Bayar_Siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyParent(Me)
        Call koneksi()
        Call datarefresh()
        panelcari.Hide()
        matikan()
        g1.Hide()
        bt_save.Enabled = False
        tb_nama.Focus()
    End Sub

    Private Sub FStatus_Bayar_Siswa_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call koneksi()
        Call datarefresh()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        tb_nama.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(2).Value
        If tb_nama.Text <> "" Then
            dt = New DataTable
            dt = getsql("Select * from t_ukwajib where kode_akun = '" & dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value & "'")
            If dt.Rows.Count > 0 Then
                tb_nomor.Text = dt.Rows(0)(0).ToString
            Else
                MsgBox("Nama tidak terdaftar")
            End If
        Else
            MsgBox("Nama harus diisi")
        End If
        tb_npm.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(3).Value
        If tb_npm.Text <> "" Then
            Dim dtm As New DataTable
            dtm = getsql("Select * from t_mhs where npm = '" & tb_npm.Text & "'")
            If dt.Rows.Count > 0 Then
                tb_semester.Text = dtm.Rows(0)(3).ToString
                tb_angkatan.Text = dtm.Rows(0)(4).ToString
            Else
                MsgBox("Nama tidak terdaftar")
            End If
        Else
            MsgBox("Nama harus diisi")
        End If
        tb_kewajiban.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(4).Value
        tb_bayar.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(5).Value
        tb_tunggakan.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(6).Value
        dgv2.DataSource = getsql("select tgl, kode_akun, nama_akun, dibayar, ket from t_umasuk where kode_akun = '" & dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value & "' order by tgl")
        With dgv2
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Tanggal"
            .Columns(1).HeaderCell.Value = "Kode Akun"
            .Columns(2).HeaderCell.Value = "Nama Akun"
            .Columns(3).HeaderCell.Value = "Pembayaran"
            .Columns(4).HeaderCell.Value = "Keterangan"
            .Columns(3).DefaultCellStyle.Format = "C"
        End With
        matikan()
    End Sub
    
    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Tutup(Me)
    End Sub
    Private Sub panelcari_Paint(sender As Object, e As PaintEventArgs) Handles panelcari.Paint
        DataGridView1.DataSource = getsql("select * from t_mhs")
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        tb_nama.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
        If tb_nama.Text <> "" Then
            dt = New DataTable
            dt = getsql("Select * from t_umasuk where nama= '" & tb_nama.Text & "'")
            If dt.Rows.Count > 0 Then
                tb_nomor.Text = dt.Rows(0)(0).ToString
            Else
                MsgBox("Nama tidak terdaftar")
            End If
        Else
            MsgBox("Nama harus diisi")
        End If
        tb_npm.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
        If tb_npm.Text <> "" Then
            Dim dtm As New DataTable
            dtm = getsql("Select * from t_mhs where npm = '" & tb_npm.Text & "'")
            If dt.Rows.Count > 0 Then
                tb_semester.Text = dtm.Rows(0)(3).ToString
                tb_angkatan.Text = dtm.Rows(0)(4).ToString
                Else
                MsgBox("NPM tidak terdaftar")
            End If
        Else
            MsgBox("NPM harus diisi")
        End If
        If tb_npm.Text <> "" Then
            Dim dtm As New DataTable
            dtm = getsql("Select * from q_status where npm = '" & tb_npm.Text & "'")
            If dt.Rows.Count > 0 Then
                tb_kewajiban.Text = dtm.Rows(0)(4).ToString
                tb_bayar.Text = dtm.Rows(0)(5).ToString
                tb_tunggakan.Text = dtm.Rows(0)(6).ToString
            Else
                MsgBox("NPM tidak terdaftar")
            End If
        Else
            MsgBox("NPM harus diisi")
        End If
        dgv2.DataSource = getsql("select tgl, kode_akun, nama_akun, dibayar, ket from t_umasuk where kode_akun = '" & DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value & "'")
        With dgv2
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Tanggal"
            .Columns(1).HeaderCell.Value = "Kode Akun"
            .Columns(2).HeaderCell.Value = "Nama Akun"
            .Columns(3).HeaderCell.Value = "Pembayaran"
            .Columns(4).HeaderCell.Value = "Keterangan"
            .Columns(3).DefaultCellStyle.Format = "C"
        End With
        panelcari.Hide()
        g1.Hide()
        tb_nama.Focus()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        labeltitle.Text = "Cari Data Mahasiswa"
        panelcari.Show()
        g1.Show()
    End Sub

    Private Sub bt_Keluar_Click(sender As Object, e As EventArgs) Handles bt_Keluar.Click
        Tutup(Me)
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
    Public Sub ubah()
        If tb_npm.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(3).Value Then
            setsql("update t_ukwajib set jumlah='" & tb_tunggakan.Text & "' where nomer ='" & tb_nomor.Text & "'")
            hapussemua()
            datarefresh()
        End If
    End Sub
    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click
        tb_tunggakan.Enabled = True
        tb_tunggakan.Focus()
        bt_save.Enabled = True
        bt_print.Enabled = False
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        ubah()
        bt_save.Enabled = False
        bt_edit.Enabled = True
        bt_print.Enabled = True
    End Sub

    Private Sub tb_kewajiban_TextChanged(sender As Object, e As EventArgs) Handles tb_kewajiban.TextChanged
        Dim f As Long
        If tb_kewajiban.Text = "" Or Not IsNumeric(tb_kewajiban.Text) Then
            Exit Sub
        End If
        f = tb_kewajiban.Text
        tb_kewajiban.Text = Format(f, "Rp, ##,##0")
        tb_kewajiban.SelectionStart = Len(tb_kewajiban.Text)
    End Sub

    Private Sub tb_bayar_TextChanged(sender As Object, e As EventArgs) Handles tb_bayar.TextChanged
        Dim f As Long
        If tb_bayar.Text = "" Or Not IsNumeric(tb_bayar.Text) Then
            Exit Sub
        End If
        f = tb_bayar.Text
        tb_bayar.Text = Format(f, "Rp, ##,##0")
        tb_bayar.SelectionStart = Len(tb_bayar.Text)
    End Sub

    Private Sub tb_tunggakan_TextChanged(sender As Object, e As EventArgs) Handles tb_tunggakan.TextChanged
   
    End Sub

    Private Sub btrefresh_Click(sender As Object, e As EventArgs) Handles btrefresh.Click
        Call datarefresh()
    End Sub
End Class