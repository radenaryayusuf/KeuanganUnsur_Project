Imports System.Data.OleDb

Public Class FBayar_Dosen
    Public x, status As String
    Public Sub buatkolom()
        dgv.Columns.Add("nomor", "Nomor")
        dgv.Columns.Add("kode", "Kode")
        dgv.Columns.Add("tanggal", "Tanggal")
        dgv.Columns.Add("kode", "Kode Akun")
        dgv.Columns.Add("akun", "Nama Akun")
        dgv.Columns.Add("namadosen", "Nama Dosen")
        dgv.Columns.Add("matakuliah", "Mata Kuliah")
        dgv.Columns.Add("sks", "SKS")
        dgv.Columns.Add("sesi", "Sesi")
        dgv.Columns.Add("jumlah", "Jumlah")
        dgv.RowHeadersVisible = False
    End Sub
    Private Sub FBayar_Dosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call buatkolom()
        dtptgl.Format = DateTimePickerFormat.Custom
        dtptgl.CustomFormat = "yyyy-MM-dd"
        panelcari.Hide()
        g1.Hide()
        kode.Text = getbayardosen()
        tb_no.Text = getuangpengeluaran()

    End Sub
    Public Sub input()
        Dim pemasukan As Integer = 0
        Dim ket As String = "uang keluar"
        Dim rincian As String = "Null"
        status = "input"
        For baris As Integer = 0 To dgv.Rows.Count - 1
            setsql("INSERT INTO t_keluar(nomor, tgl, kode_akun, nama_akun, nama_dosen, matakuliah, sks, sesi, jumlah) VALUES ('" & dgv.Rows(baris).Cells(0).Value & "','" & dgv.Rows(baris).Cells(2).Value & "','" & dgv.Rows(baris).Cells(3).Value & "','" & dgv.Rows(baris).Cells(4).Value & "','" & dgv.Rows(baris).Cells(5).Value & "','" & dgv.Rows(baris).Cells(6).Value & "','" & dgv.Rows(baris).Cells(7).Value & "','" & dgv.Rows(baris).Cells(8).Value & "','" & dgv.Rows(baris).Cells(9).Value & "')")
            setsql("INSERT INTO t_ubayardosen VALUES ('" & dgv.Rows(baris).Cells(1).Value & "','" & dgv.Rows(baris).Cells(2).Value & "','" & dgv.Rows(baris).Cells(3).Value & "','" & dgv.Rows(baris).Cells(4).Value & "','" & dgv.Rows(baris).Cells(5).Value & "','" & dgv.Rows(baris).Cells(6).Value & "','" & dgv.Rows(baris).Cells(7).Value & "','" & dgv.Rows(baris).Cells(8).Value & "','" & dgv.Rows(baris).Cells(9).Value & "')")
            setsql("INSERT INTO t_kas VALUES ('" & dgv.Rows(baris).Cells(0).Value & "','" & dgv.Rows(baris).Cells(2).Value & "','" & rincian & "','" & dgv.Rows(baris).Cells(3).Value & "','" & dgv.Rows(baris).Cells(4).Value & "','" & pemasukan & "','" & dgv.Rows(baris).Cells(9).Value & "','" & ket & "')")

        Next

    End Sub
    Sub bersihkan()
        tb_namadosen.Clear()
        tb_namakun.Clear()
        tb_kodeakun.Clear()
        tb_mk.Clear()
        tb_sks.Clear()
        tb_sesi.Clear()
        tb_bayar.Clear()
        jumlah.Clear()
    End Sub
    Public Sub cariid()
        If status = "dosen" Then
            dgv2.DataSource = getsql("select * from t_dosen")

        ElseIf status = "akun" Then
            dgv2.DataSource = getsql("select * from t_kodebayardosen")
        End If
    End Sub

    Public Sub ubah()
        status = "ubah"

        If kode.Text = getbayardosen() Then
            tb_namadosen.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(4).Value
            tb_kodeakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(3).Value
            tb_namakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(2).Value
            tb_mk.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(5).Value
            tb_sks.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(6).Value
            tb_sesi.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(7).Value
            tb_bayar.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(8).Value
            tb_namadosen.Focus()
        ElseIf kode.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value Then
            If tb_namadosen.Text = "" Or tb_namakun.Text = "" Or tb_kodeakun.Text = "" Or tb_mk.Text = "" Or tb_sks.Text = "" Or tb_sesi.Text = "" Or dtptgl.Text = "" Then
                MsgBox("Data Belum Lengkap, Mohon Periksa Lagi")
            Else
                If dgv.Rows.Count = 0 Then

                    dgv.Rows.Add(tb_no.Text, kode.Text, dtptgl.Text, tb_kodeakun.Text, tb_namakun.Text, tb_namadosen.Text, tb_mk.Text, tb_sks.Text, tb_sesi.Text, jumlah.Text)

                Else

                    x = 0
                    While ((kode.Text <> dgv.Rows(x).Cells(0).Value) And (x <= dgv.Rows.Count - 2))
                        x += 1
                    End While
                    If tb_namadosen.Text = dgv.Rows(x).Cells(4).Value Or tb_kodeakun.Text = dgv.Rows(x).Cells(2).Value Then
                        kode.Text = Val(Microsoft.VisualBasic.Right(kode.Text, 4) - 1)
                        dgv.Rows(x).Cells(9).Value += Val(jumlah.Text)

                    Else

                        dgv.Rows.Add(kode.Text, dtptgl.Text, tb_kodeakun.Text, tb_namakun.Text, tb_namadosen.Text, tb_mk.Text, tb_sks.Text, tb_sesi.Text, jumlah.Text)
                    End If

                End If
                Call bersihkan()
                tb_namadosen.Focus()
                Dim kodedosen As String = kode.Text
                If dgv.Rows.Count <> 0 Then
                    kodedosen = kode.Text.ToString
                    kodedosen = Val(Microsoft.VisualBasic.Right(kode.Text, 4) + 1)
                    kode.Text = "BD" & Microsoft.VisualBasic.Left("0000", 4 - Microsoft.VisualBasic.Len(kodedosen)) & kodedosen

                End If
            End If

        ElseIf kode.Text <> getbayardosen() Then
            tb_namadosen.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(4).Value
            tb_kodeakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(3).Value
            tb_namakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(2).Value
            tb_mk.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(5).Value
            tb_sks.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(6).Value
            tb_sesi.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(7).Value
            tb_bayar.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(8).Value
            tb_namadosen.Focus()
        End If
    End Sub
    Private Sub bt_exit_Click_1(sender As Object, e As EventArgs) Handles bt_exit.Click
        Me.Close()
    End Sub

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        input()
        MsgBox("Data Tersimpan", MsgBoxStyle.Information, "Success")
        Call bersihkan()
        dgv.Rows.Clear()
        tb_namadosen.Focus()
        kode.Text = getbayardosen()
    End Sub

    Private Sub tb_sesi_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles tb_sesi.KeyPress
        If e.KeyChar = Chr(13) Then
            tb_bayar.Focus()
        End If
    End Sub

    Private Sub tb_bayar_Click(sender As Object, e As EventArgs) Handles tb_bayar.Click

    End Sub
    Function gettotalbelanja()

        Dim hitungdosen As Integer = 0
        For I As Integer = 0 To dgv.Rows.Count - 1
            hitungdosen = hitungdosen + Val(dgv.Rows(I).Cells(9).Value)
        Next
        Return hitungdosen
    End Function
    Private Sub tb_bayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_bayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If tb_namadosen.Text = "" Or tb_namakun.Text = "" Or tb_kodeakun.Text = "" Or tb_mk.Text = "" Or tb_sks.Text = "" Or tb_sesi.Text = "" Or dtptgl.Text = "" Then
                MsgBox("Data Belum Lengkap, Mohon Periksa Lagi")
            Else
                If dgv.Rows.Count = 0 Then

                    dgv.Rows.Add(tb_no.Text, kode.Text, dtptgl.Text, tb_kodeakun.Text, tb_namakun.Text, tb_namadosen.Text, tb_mk.Text, tb_sks.Text, tb_sesi.Text, tb_bayar.Text)

                Else

                    x = 0
                    While ((tb_namakun.Text <> dgv.Rows(x).Cells(3).Value) And (tb_namadosen.Text <> dgv.Rows(x).Cells(4).Value) And (kode.Text <> dgv.Rows(x).Cells(0).Value) And (x <= dgv.Rows.Count - 2))
                        x += 1
                    End While
                    If tb_namadosen.Text = dgv.Rows(x).Cells(4).Value Or tb_kodeakun.Text = dgv.Rows(x).Cells(2).Value Then
                        kode.Text = Val(Microsoft.VisualBasic.Right(kode.Text, 4) - 1)
                        tb_no.Text = Val(Microsoft.VisualBasic.Right(tb_no.Text, 4) - 1)
                        dgv.Rows(x).Cells(9).Value += Val(jumlah.Text)

                    Else

                        dgv.Rows.Add(tb_no.Text, kode.Text, dtptgl.Text, tb_kodeakun.Text, tb_namakun.Text, tb_namadosen.Text, tb_mk.Text, tb_sks.Text, tb_sesi.Text, tb_bayar.Text)
                    End If

                End If
                Call bersihkan()
                tb_namadosen.Focus()
                Dim kodedosen As String = kode.Text
                If dgv.Rows.Count <> 0 Then
                    kodedosen = kode.Text.ToString
                    kodedosen = Val(Microsoft.VisualBasic.Right(kode.Text, 4) + 1)
                    kode.Text = "BD" & Microsoft.VisualBasic.Left("0000", 4 - Microsoft.VisualBasic.Len(kodedosen)) & kodedosen
                    Dim kodeukeluar As String = tb_no.Text

                    kodeukeluar = tb_no.Text.ToString
                    kodeukeluar = Val(Microsoft.VisualBasic.Right(tb_no.Text, 4) + 1)
                    tb_no.Text = "UKLR" & Microsoft.VisualBasic.Left("0000", 4 - Microsoft.VisualBasic.Len(kodeukeluar)) & kodeukeluar

            End If
               
            End If
            jumlah.Text = gettotalbelanja()

        End If
    End Sub

    Private Sub tb_bayar_MouseClick(sender As Object, e As MouseEventArgs) Handles tb_bayar.MouseClick

    End Sub

    Private Sub dgv2_DoubleClick(sender As Object, e As EventArgs) Handles dgv2.DoubleClick
        If status = "dosen" Then
            tb_namadosen.Text = dgv2.Rows(dgv2.CurrentRow.Index).Cells(1).Value
            panelcari.Hide()
            g1.Hide()
            tb_namakun.Focus()
        ElseIf status = "akun" Then
            tb_namakun.Text = dgv2.Rows(dgv2.CurrentRow.Index).Cells(1).Value
            tb_kodeakun.Text = dgv2.Rows(dgv2.CurrentRow.Index).Cells(0).Value
            tb_mk.Text = dgv2.Rows(dgv2.CurrentRow.Index).Cells(2).Value
            tb_sks.Text = dgv2.Rows(dgv2.CurrentRow.Index).Cells(3).Value
            tb_bayar.Text = dgv2.Rows(dgv2.CurrentRow.Index).Cells(4).Value
            panelcari.Hide()
            g1.Hide()
            tb_sesi.Focus()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        status = "akun"
        labeltitle.Text = "Cari Kode Akun"
        panelcari.Show()
        g1.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        status = "dosen"
        labeltitle.Text = "Cari Data Dosen"
        panelcari.Show()
        g1.Show()
    End Sub

    Private Sub labeltitle_Click(sender As Object, e As EventArgs) Handles labeltitle.Click
        cariid()
    End Sub

    Private Sub g2_Click(sender As Object, e As EventArgs) Handles g2.Click
        panelcari.Hide()
        g1.Hide()
    End Sub

    Private Sub bt_tambahkan_Click(sender As Object, e As EventArgs) Handles bt_tambahkan.Click

        If tb_namadosen.Text = "" Or tb_namakun.Text = "" Or tb_kodeakun.Text = "" Or tb_mk.Text = "" Or tb_sks.Text = "" Or tb_sesi.Text = "" Or dtptgl.Text = "" Then
            MsgBox("Data Belum Lengkap, Mohon Periksa Lagi")
        Else
            If dgv.Rows.Count = 0 Then

                dgv.Rows.Add(kode.Text, dtptgl.Text, tb_kodeakun.Text, tb_namakun.Text, tb_namadosen.Text, tb_mk.Text, tb_sks.Text, tb_sesi.Text, jumlah.Text)

            Else

                x = 0
                While ((tb_namakun.Text <> dgv.Rows(x).Cells(3).Value) And (tb_namadosen.Text <> dgv.Rows(x).Cells(4).Value) And (kode.Text <> dgv.Rows(x).Cells(0).Value) And (x <= dgv.Rows.Count - 2))
                    x += 1
                End While
                If tb_namadosen.Text = dgv.Rows(x).Cells(4).Value Or tb_kodeakun.Text = dgv.Rows(x).Cells(2).Value Then
                    kode.Text = Val(Microsoft.VisualBasic.Right(kode.Text, 4) - 1)
                    dgv.Rows(x).Cells(8).Value += Val(jumlah.Text)

                Else

                    dgv.Rows.Add(kode.Text, dtptgl.Text, tb_kodeakun.Text, tb_namakun.Text, tb_namadosen.Text, tb_mk.Text, tb_sks.Text, tb_sesi.Text, jumlah.Text)
                End If

            End If
            Call bersihkan()
            tb_namadosen.Focus()
            Dim kodedosen As String = kode.Text
            If dgv.Rows.Count <> 0 Then
                kodedosen = kode.Text.ToString
                kodedosen = Val(Microsoft.VisualBasic.Right(kode.Text, 4) + 1)
                kode.Text = "BD" & Microsoft.VisualBasic.Left("0000", 4 - Microsoft.VisualBasic.Len(kodedosen)) & kodedosen

            End If
        End If
    End Sub

    Private Sub g1_Click(sender As Object, e As EventArgs) Handles g1.Click
        panelcari.Hide()
        g1.Hide()
    End Sub

    Private Sub panelcari_Paint(sender As Object, e As PaintEventArgs) Handles panelcari.Paint
        cariid()
    End Sub

    Private Sub jumlah_TextChanged(sender As Object, e As EventArgs) Handles jumlah.TextChanged
        Dim f As Long
        If jumlah.Text = "" Or Not IsNumeric(jumlah.Text) Then
            Exit Sub
        End If
        f = jumlah.Text
        jumlah.Text = Format(f, "Rp, ##,##0")
        jumlah.SelectionStart = Len(jumlah.Text)
    End Sub

    Private Sub tb_bayar_TextChanged(sender As Object, e As EventArgs) Handles tb_bayar.TextChanged

    End Sub

    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click
        ubah()
        jumlah.Text = gettotalbelanja()
    End Sub

    Private Sub bt_cancel_Click(sender As Object, e As EventArgs) Handles bt_cancel.Click
        MsgBox("Yakin Cancel?", MsgBoxStyle.YesNo, "INFO")
        If MsgBoxResult.Yes Then
            bersihkan()
            tb_namadosen.Focus()
            dgv.Rows.Clear()
            kode.Text = getbayardosen()
            tb_no.Text = getuangpengeluaran()


        End If
        End Sub
End Class