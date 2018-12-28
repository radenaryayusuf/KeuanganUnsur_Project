Imports System.Data.OleDb
Public Class FKode_Pemasukan
    Public kode, status As String
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Tutup(Me)

    End Sub


    Public Sub datarefresh()
        dgv.DataSource = getsql("select * from t_kodepemasukan")
        With dgv
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Kode Akun"
            .Columns(1).HeaderCell.Value = "Nama Akun"
            .Columns(2).HeaderCell.Value = "Uraian"
            .Columns(3).HeaderCell.Value = "Kewajiban"
            .Columns(4).HeaderCell.Value = "Catatan"
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
        tkodeakun.TabIndex = 0
        tnamaakun.TabIndex = 1
        turaian.TabIndex = 2
        tkewajiban.TabIndex = 3
        tcatatan.TabIndex = 4
    End Sub
    Public Sub ubah()
        status = "update"
        If tkodeakun.Text = "" Then
            tkodeakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value
            tnamaakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(1).Value
            turaian.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(2).Value
            tkewajiban.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(3).Value
            tcatatan.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(4).Value
            tnamaakun.Focus()
        ElseIf tkodeakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value Then
            setsql("update t_kodepemasukan set nama_akun ='" & tnamaakun.Text & "', uraian ='" & turaian.Text & "', kewajiban ='" & tkewajiban.Text & "', catatan ='" & tcatatan.Text & "' where kode_akun ='" & tkodeakun.Text & "'")
            setsql("update t_ukwajib set nama_akun ='" & tnamaakun.Text & "', uraian ='" & turaian.Text & "', jumlah='" & tkewajiban.Text & "' where nomer ='" & tbnomor.Text & "'")
            datarefresh()
            hapussemua()
            tnamaakun.Focus()
            status = "input"

        ElseIf tkodeakun.Text <> "" Then
            tkodeakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value
            tnamaakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(1).Value
            turaian.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(2).Value
            tkewajiban.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(3).Value
            tcatatan.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(4).Value
            tnamaakun.Focus()
        End If

    End Sub

    Private Sub FKode_Pemasukan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyParent(Me)
        Call koneksi()
        datarefresh()
        urutindex()
        tbnomor.Text = getkodeukwajib()
        tbnomor.Enabled = False
        tkodeakun.Focus()
    End Sub
    Public Sub input()
        status = "input"
        setsql("insert into t_kodepemasukan values('" & tkodeakun.Text & "','" & tnamaakun.Text & "','" & turaian.Text & "','" & tkewajiban.Text & "','" & tcatatan.Text & "')")
        setsql("insert into t_ukwajib values('" & tbnomor.Text & "', '" & tkodeakun.Text & "','" & tnamaakun.Text & "','" & turaian.Text & "','" & tkewajiban.Text & "')")
        datarefresh()
        hapussemua()
        tkodeakun.Focus()
    End Sub
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        input()
        tbnomor.Text = getkodeukwajib()
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

    Private Sub bt_exit_Click(sender As Object, e As EventArgs) Handles bt_exit.Click
        If MsgBox("Apa anda yakin hapus '" & dgv.CurrentRow.Cells(1).Value & "'?", MsgBoxStyle.YesNo, "Peringatan") = Windows.Forms.DialogResult.Yes Then
            Try
                Using cmddatamasuk As New OleDbCommand("delete from t_kodepemasukan where kode_akun = '" & dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value & "'", conn)
                    Using cmddatauk As New OleDbCommand("delete from t_ukwajib where nomer = '" & tbnomor.Text & "'", conn)

                        cmddatamasuk.ExecuteNonQuery()
                        cmddatauk.ExecuteNonQuery()



                        If MsgBox("Data " & dgv.Rows(dgv.CurrentRow.Index).Cells(1).Value & " telah dihapus", MsgBoxStyle.OkOnly, "Berhasil") = Windows.Forms.DialogResult.OK Then


                            datarefresh()
                            tkodeakun.Text = ""
                            tbnomor.Text = getkodeukwajib()
                            tnamaakun.Focus()


                        End If

                    End Using
                End Using

            Catch ex As Exception
                MsgBox("Error Terjadi Saat Hapus Data Mahasiswa : " & vbNewLine & ex.Message)
            End Try
        End If
    End Sub

    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click
        ubah()
    End Sub

    Private Sub bt_Keluar_Click(sender As Object, e As EventArgs)
        Tutup(Me)
    End Sub

    Private Sub bt_Keluar_Click_1(sender As Object, e As EventArgs) Handles bt_Keluar.Click
        Tutup(Me)
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        
    End Sub

    Private Sub dgv_Click(sender As Object, e As EventArgs) Handles dgv.Click
        Dim dtmasuk As DataTable
        dtmasuk = getsql("select * from t_ukwajib where kode_akun = '" & dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value & "'")
        tbnomor.Text = dtmasuk.Rows(0)(0).ToString
    End Sub

    Private Sub tcatatan_TextChanged(sender As Object, e As EventArgs) Handles tcatatan.TextChanged

    End Sub
End Class