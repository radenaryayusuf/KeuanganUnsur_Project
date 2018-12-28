Public Class FPenggajian
    Public kode, status As String

    Private Sub FPenggajian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyParent(Me)
        Call koneksi()
        urutindex()
        Call datarefresh()
        kodeakun.Focus()
        status = "input"
    End Sub
    Public Sub datarefresh()
        dgv.DataSource = getsql("select * from t_kodeugaji")
        With dgv
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Kode Akun"
            .Columns(1).HeaderCell.Value = "Nama Akun"
            .Columns(2).HeaderCell.Value = "Besaran"
            .Columns(3).HeaderCell.Value = "Keterangan"
            .Columns(2).DefaultCellStyle.Format = "C"
        End With
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
    Public Sub urutindex()
        kodeakun.TabIndex = 0
        namaakun.TabIndex = 1
        besaran.TabIndex = 2
        keterangan.TabIndex = 3
    End Sub
    Public Sub ubah()
        status = "update"
        If kodeakun.Text = getkodegaji() Then
            kodeakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value
            namaakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(1).Value
            besaran.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(2).Value
            keterangan.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(3).Value
            namaakun.Focus()
        ElseIf kodeakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value Then
            setsql("update t_kodeugaji set nama_akun ='" & namaakun.Text & "', besaran ='" & besaran.Text & "', keterangan ='" & keterangan.Text & "' where kode_akun ='" & kodeakun.Text & "'")
            datarefresh()
            hapussemua()
            kodeakun.Focus()
            status = "input"
        ElseIf kodeakun.Text <> getkodegaji() Then
            kodeakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value
            namaakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(1).Value
            besaran.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(2).Value
            keterangan.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(3).Value
            namaakun.Focus()
        End If
    End Sub
    Public Sub input()
        status = "input"
        setsql("insert into t_kodeugaji values('" & kodeakun.Text & "','" & namaakun.Text & "','" & besaran.Text & "','" & keterangan.Text & "')")
        datarefresh()
        hapussemua()
        kodeakun.Focus()
    End Sub
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Tutup(Me)
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        input()
    End Sub

    Private Sub keterangan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles keterangan.KeyPress
        If e.KeyChar = Chr(13) Then
            If status = "input" Then
                input()
            Else
                ubah()
            End If
        End If
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        setsql("delete from t_kodeugaji where kode_akun = '" & dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value & "'")
        datarefresh()
        kodeakun.Focus()
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        ubah()
    End Sub

    Private Sub kodeakun_TextChanged(sender As Object, e As EventArgs) Handles kodeakun.TextChanged

    End Sub

    Private Sub bt_Keluar_Click(sender As Object, e As EventArgs) Handles bt_Keluar.Click
        Tutup(Me)
    End Sub
End Class