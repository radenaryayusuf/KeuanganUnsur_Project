Public Class FKode_Pengeluaran
    Public status, kode As String
    Private Sub FKode_Pengeluaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyParent(Me)
        Call koneksi()
        datarefresh()
        urutindex()
        tkodeakun.Focus()
    End Sub
    Public Sub datarefresh()
        dgv.DataSource = getsql("select * from t_kodepengeluaran")
        With dgv
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Kode Akun"
            .Columns(1).HeaderCell.Value = "Nama Akun"
            .Columns(2).HeaderCell.Value = "Uraian"
            .Columns(3).HeaderCell.Value = "Catatan"
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
    Public Sub input()
        status = "input"
        setsql("insert into t_kodepengeluaran values('" & tkodeakun.Text & "','" & tnamaakun.Text & "','" & turaian.Text & "','" & tcatatan.Text & "')")
        datarefresh()
        hapussemua()
        tkodeakun.Focus()
    End Sub
    Public Sub urutindex()
        tkodeakun.TabIndex = 0
        tnamaakun.TabIndex = 1
        turaian.TabIndex = 2
        tcatatan.TabIndex = 3
    End Sub
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Tutup(Me)
    End Sub
    Public Sub ubah()
        status = "ubah"

        If tkodeakun.Text = "" Then
            tkodeakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value
            tnamaakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(1).Value
            turaian.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(2).Value
            tcatatan.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(3).Value
            tnamaakun.Focus()
        ElseIf tkodeakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value Then
            setsql("update t_kodepengeluaran set namaakun ='" & tnamaakun.Text & "', uraian ='" & turaian.Text & "',  catatan ='" & tcatatan.Text & "' where kodeakun ='" & tkodeakun.Text & "'")
            datarefresh()
            hapussemua()
            tnamaakun.Focus()
            status = "input"
        ElseIf tkodeakun.Text <> "" Then
            tkodeakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value
            tnamaakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(1).Value
            turaian.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(2).Value
            tcatatan.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(3).Value
            tnamaakun.Focus()
        End If
    End Sub
    Private Sub tkodeakun_TextChanged(sender As Object, e As EventArgs) Handles tkodeakun.TextChanged
        
    End Sub

    Private Sub tcatatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcatatan.KeyPress
        If e.KeyChar = Chr(13) Then
            If status = "input" Then
                input()
            Else
                ubah()
            End If
        End If
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        setsql("delete from t_kodepengeluaran where kodeakun = '" & dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value & "'")
        datarefresh()
        tnamaakun.Focus()
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        ubah()
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        input()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub tcatatan_TextChanged(sender As Object, e As EventArgs) Handles tcatatan.TextChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub bt_Keluar_Click(sender As Object, e As EventArgs) Handles bt_Keluar.Click
        Tutup(Me)
    End Sub
End Class