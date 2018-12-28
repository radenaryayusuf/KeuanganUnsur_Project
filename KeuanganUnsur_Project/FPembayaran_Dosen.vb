Public Class FPembayaran_Dosen
    Public status As String
    Public Sub datarefresh()
        dgv.DataSource = getsql("select * from t_kodebayardosen")
        With dgv
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Kode Akun"
            .Columns(1).HeaderCell.Value = "Nama Akun"
            .Columns(2).HeaderCell.Value = "Mata Kuliah"
            .Columns(3).HeaderCell.Value = "SKS"
            .Columns(4).HeaderCell.Value = "Jumlah"
            .Columns(4).DefaultCellStyle.Format = "C"
        End With
    End Sub
    Public Sub urutindex()
        tb_nama.TabIndex = 0
        tb_mk.TabIndex = 1
        tb_sks.TabIndex = 2
        tb_jumlah.TabIndex = 3
    End Sub

    Private Sub FPembayaran_Dosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyParent(Me)
        Call koneksi()
        datarefresh()
        urutindex()
        tb_kode.Text = getkodepembayarandosen()
        tb_kode.Enabled = False
        tb_nama.Focus()
        panelcari.Hide()
        g1.Hide()
        tb_mk.Enabled = False
        tb_sks.Enabled = False
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
        status = "ubah"

        If tb_kode.Text = getkodepembayarandosen() Then
            tb_kode.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value
            tb_nama.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(1).Value
            tb_mk.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(2).Value
            tb_sks.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(3).Value
            tb_jumlah.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(4).Value
            tb_nama.Focus()
        ElseIf tb_kode.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value Then
            setsql("update t_kodebayardosen set namaakun ='" & tb_nama.Text & "', matakuliah ='" & tb_mk.Text & "',  sks ='" & tb_sks.Text & "',  jumlah ='" & tb_jumlah.Text & "' where kodeakun ='" & tb_kode.Text & "'")
            datarefresh()
            hapussemua()
            tb_nama.Focus()
            status = "input"
            tb_kode.Text = getkodepembayarandosen()
        ElseIf tb_kode.Text <> getkodepembayarandosen() Then
            tb_kode.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value
            tb_nama.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(1).Value
            tb_mk.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(2).Value
            tb_sks.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(3).Value
            tb_jumlah.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(4).Value
            tb_nama.Focus()
        End If
    End Sub
    Public Sub input()
        status = "input"
        setsql("insert into t_kodebayardosen values('" & tb_kode.Text & "','" & tb_nama.Text & "','" & tb_mk.Text & "','" & tb_sks.Text & "','" & tb_jumlah.Text & "')")
        datarefresh()
        hapussemua()
        tb_nama.Focus()
    End Sub

    Private Sub tb_kode_TextChanged(sender As Object, e As EventArgs) Handles tb_kode.TextChanged
        If status = "input" Then
            tb_kode.Text = getkodepembayarandosen()
        ElseIf status = "ubah" Then

        End If
    End Sub

    Private Sub tb_jumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_jumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            If status = "input" Then
                input()
            Else
                ubah()
            End If
        End If
    End Sub

    Private Sub tb_jumlah_TextChanged(sender As Object, e As EventArgs) Handles tb_jumlah.TextChanged

    End Sub

    Private Sub bt_hapus_Click(sender As Object, e As EventArgs) Handles bt_hapus.Click
        setsql("delete from t_kodepengeluaran where kodeakun = '" & dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value & "'")
        datarefresh()
        tb_nama.Focus()
    End Sub

    Private Sub bt_ubah_Click(sender As Object, e As EventArgs) Handles bt_ubah.Click
        ubah()

    End Sub

    Private Sub bt_tambah_Click(sender As Object, e As EventArgs) Handles bt_tambah.Click
        input()

    End Sub

    Private Sub bt_keluar_Click(sender As Object, e As EventArgs) Handles bt_keluar.Click
        Tutup(Me)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Tutup(Me)
    End Sub
    Public Sub cariid()

        DataGridView1.DataSource = getsql("select nomor,nama, nik,jk,tmp_lahir, tgl_lahir,ktp, agama from t_dosen")
        End Sub
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        status = "mhs"
        labeltitle.Text = "Cari Data Dosen"
        panelcari.Show()
        g1.Show()
    End Sub

    Private Sub panelcari_Paint(sender As Object, e As PaintEventArgs) Handles panelcari.Paint
        cariid()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        kode_dosen.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
        tb_nama.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
        panelcari.Hide()
        g1.Hide()
        tb_nama.Focus()
        tb_mk.Enabled = True
        tb_sks.Enabled = True

        tb_mk.Items.Clear()
        tb_sks.Items.Clear()
        Dim dtplat As New DataTable
        dtplat = getsql("select * from t_dosen where nomor = '" & kode_dosen.Text & "'")
        For k As Integer = 0 To dtplat.Rows.Count - 1
            tb_mk.Items.Add(dtplat.Rows(k)(8).ToString)
            tb_mk.Items.Add(dtplat.Rows(k)(10).ToString)
            tb_mk.Items.Add(dtplat.Rows(k)(12).ToString)
            tb_mk.Items.Add(dtplat.Rows(k)(14).ToString)
            tb_sks.Items.Add(dtplat.Rows(k)(9).ToString)
            tb_sks.Items.Add(dtplat.Rows(k)(11).ToString)
            tb_sks.Items.Add(dtplat.Rows(k)(13).ToString)
            tb_sks.Items.Add(dtplat.Rows(k)(15).ToString)

        Next
    End Sub

    Private Sub tb_mk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tb_mk.SelectedIndexChanged
       
    End Sub
End Class