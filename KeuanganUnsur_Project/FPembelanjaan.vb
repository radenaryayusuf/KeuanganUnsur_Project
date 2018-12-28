Imports System.IO
Public Class FPembelanjaan
    Declare Function ShellExecuteA Lib "shell32.dll" ( _
           ByVal hWnd As IntPtr, _
           ByVal lpOperation As String, _
           ByVal lpFile As String, _
           ByVal lpParameters As String, _
           ByVal lpDirectory As String, _
           ByVal nShowCmd As Integer) As IntPtr
    Public x, status As String
    Private kodekeluarpertama As String
    Public Sub buatkolom()
        dgv.Columns.Add("nomor", "Nomor")
        dgv.Columns.Add("tanggal", "Tanggal")
        dgv.Columns.Add("resi", "Resi")
        dgv.Columns.Add("akun", "Nama Akun")
        dgv.Columns.Add("kode", "Kode Akun")
        dgv.Columns.Add("uraian", "Uraian")
        dgv.Columns.Add("satuan", "Satuan")
        dgv.Columns.Add("jumlah", "Jumlah")
        dgv.Columns.Add("penerima", "Penerima")
        dgv.Columns.Add("notransaksi", "No Transaksi")
        dgv.RowHeadersVisible = False
    End Sub
    Public Sub input()

        status = "input"
        Dim pemasukan As Integer = 0
        Dim ket As String = "uang keluar"
        For baris As Integer = 0 To dgv.Rows.Count - 1

            setsql("INSERT INTO t_keluar(nomor, tgl, resi, nama_akun, kode_akun, uraian, satuan, jumlah, penerima) VALUES ('" & dgv.Rows(baris).Cells(9).Value & "','" & dgv.Rows(baris).Cells(1).Value & "','" & dgv.Rows(baris).Cells(2).Value & "','" & dgv.Rows(baris).Cells(3).Value & "','" & dgv.Rows(baris).Cells(4).Value & "','" & dgv.Rows(baris).Cells(5).Value & "','" & dgv.Rows(baris).Cells(6).Value & "','" & dgv.Rows(baris).Cells(7).Value & "','" & dgv.Rows(baris).Cells(8).Value & "')")
            setsql("INSERT INTO t_transaksi(nomer, tgl, resi, nama_akun, kode_akun, uraian, satuan, jumlah, penerima) VALUES ('" & dgv.Rows(baris).Cells(0).Value & "','" & dgv.Rows(baris).Cells(1).Value & "','" & dgv.Rows(baris).Cells(2).Value & "','" & dgv.Rows(baris).Cells(3).Value & "','" & dgv.Rows(baris).Cells(4).Value & "','" & dgv.Rows(baris).Cells(5).Value & "','" & dgv.Rows(baris).Cells(6).Value & "','" & dgv.Rows(baris).Cells(7).Value & "','" & dgv.Rows(baris).Cells(8).Value & "')")
            setsql("INSERT INTO t_kas VALUES ('" & dgv.Rows(baris).Cells(9).Value & "','" & dgv.Rows(baris).Cells(1).Value & "','" & dgv.Rows(baris).Cells(5).Value & "','" & dgv.Rows(baris).Cells(4).Value & "','" & dgv.Rows(baris).Cells(3).Value & "','" & pemasukan & "','" & dgv.Rows(baris).Cells(7).Value & "','" & ket & "')")

        Next


    End Sub
    Sub bersihkan()
        tb_nama.Clear()
        tb_kode.Clear()
        tb_uraian.Clear()
        tb_satuan.Clear()
        tb_resi.Clear()
        jumlah.Clear()
        tb_penerima.Clear()
        tb_bayar.Clear()
    End Sub
    Function gettotalbelanja()

        Dim hitungbelanja As Integer = 0
        For I As Integer = 0 To dgv.Rows.Count - 1
            hitungbelanja = hitungbelanja + Val(dgv.Rows(I).Cells(7).Value)
        Next
        Return hitungbelanja
    End Function
    Private Sub FPembelanjaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call buatkolom()
        tanggal.Format = DateTimePickerFormat.Custom
        tanggal.CustomFormat = "yyyy-MM-dd"
        panelcari.Hide()
        g1.Hide()
        kode.Text = getkodebelanja()
        tb_no.Text = getuangpengeluaran()
        'dgv.DataSource = getsql("select * from")_



    End Sub
    Private Sub g2_Click_1(sender As Object, e As EventArgs)
        panelcari.Hide()
        g1.Hide()
    End Sub
    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        labeltitle.Text = "Cari Kode Akun"
        panelcari.Show()
        g1.Show()
    End Sub


    Private Sub g1_Click_2(sender As Object, e As EventArgs) Handles g1.Click
        panelcari.Hide()
        g1.Hide()
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        Me.Close()
    End Sub

    Private Sub bt_save_Click_1(sender As Object, e As EventArgs) Handles bt_save.Click
        input()
        MsgBox("Data Tersimpan", MsgBoxStyle.Information, "Success")
        Call bersihkan()
        dgv.Rows.Clear()
        tb_nama.Focus()
        kode.Text = getkodebelanja()
        tb_no.Text = getuangpengeluaran()
    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        If tb_nama.Text = "" Or tb_kode.Text = "" Or tb_uraian.Text = "" Or tb_penerima.Text = "" Then
            MsgBox("Data Belum Lengkap, Mohon Periksa Lagi")
        Else
            If dgv.Rows.Count = 0 Then

                dgv.Rows.Add(kode.Text, tanggal.Text, tb_resi.Text, tb_nama.Text, tb_kode.Text, tb_uraian.Text, tb_satuan.Text, tb_bayar.Text, tb_penerima.Text, tb_no.Text)

            Else

                x = 0
                While ((tb_nama.Text <> dgv.Rows(x).Cells(3).Value) And (kode.Text <> dgv.Rows(x).Cells(0).Value) And (x <= dgv.Rows.Count - 2))
                    x += 1
                End While
                If tb_nama.Text = dgv.Rows(x).Cells(3).Value Or tb_kode.Text = dgv.Rows(x).Cells(2).Value Then
                    kode.Text = Val(Microsoft.VisualBasic.Right(kode.Text, 4) - 1)
                    dgv.Rows(x).Cells(7).Value += Val(jumlah.Text)

                Else

                    dgv.Rows.Add(kode.Text, tanggal.Text, tb_resi.Text, tb_nama.Text, tb_kode.Text, tb_uraian.Text, tb_satuan.Text, tb_bayar.Text, tb_penerima.Text, tb_no.Text)

                End If

            End If
            Call bersihkan()
            tb_nama.Focus()
            Dim kodebelanja As String = kode.Text
            If dgv.Rows.Count <> 0 Then
                kodebelanja = kode.Text.ToString
                kodebelanja = Val(Microsoft.VisualBasic.Right(kode.Text, 4) + 1)
                kode.Text = "B" & Microsoft.VisualBasic.Left("0000", 4 - Microsoft.VisualBasic.Len(kodebelanja)) & kodebelanja

            End If
        End If
    End Sub

    Private Sub tb_uraian_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles tb_uraian.KeyPress
        If e.KeyChar = Chr(13) Then
            tb_resi.Focus()

        End If
    End Sub

    Private Sub BunifuImageButton8_Click(sender As Object, e As EventArgs) Handles BunifuImageButton8.Click
        Dim i As Integer
        Dim rpt As String
        Dim cPart, tContent As String
        Dim periode As String = Format(Now, "MMMM") & " " & Format(Now, "yyyy")
        Dim sekarang As String = "_TGL_" & Format(Now, "dd-MM-yy_mmss")
        Dim total As Integer = 0

        dt = New DataTable
        dt = getsql("select * from t_transaksi")

        rpt = File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) & "\laporan_belanja.mht")
        rpt = Replace(rpt, "[pr]", periode)
        tContent = ""

        For i = 0 To (dt.Rows.Count - 1)
            cPart = File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) & "\laporan_belanja_content.mht")

            cPart = Replace(cPart, "[n]", dt.Rows(i)("nomer").ToString)
            cPart = Replace(cPart, "[tg]", dt.Rows(i)("tgl").ToString)
            cPart = Replace(cPart, "[ka]", dt.Rows(i)("kode_akun").ToString)
            cPart = Replace(cPart, "[a]", dt.Rows(i)("nama_akun").ToString)
            cPart = Replace(cPart, "[ur]", dt.Rows(i)("uraian").ToString)
            cPart = Replace(cPart, "[b]", dt.Rows(i)("jumlah").ToString)
            cPart = Replace(cPart, "[k]", dt.Rows(i)("ket").ToString)
            'total = total + Val(dt.Rows(i)("cash_bayar").ToString)
            tContent = tContent & vbCrLf & cPart
            ' MsgBox(total)
        Next

        rpt = Replace(rpt, "[content]", tContent)
        rpt = Replace(rpt, "[tgl]", Format(Now, "dd-MM-yyyy"))
        'rpt = Replace(rpt, "[pn]", dt.Rows(i)("penerima").ToString)
        ' rpt = Replace(rpt, "[tot]", total)
        File.WriteAllText("d:\Laporan_belanja" & sekarang & ".xls", rpt)
        ShellExecuteA(Me.Handle, "open", "d:\Laporan_belanja" & sekarang & ".xls", "", "", 1)
    End Sub
    Private Sub dgv2_DoubleClick(sender As Object, e As EventArgs) Handles dgv2.DoubleClick
        tb_nama.Text = dgv2.Rows(dgv2.CurrentRow.Index).Cells(1).Value
        tb_kode.Text = dgv2.Rows(dgv2.CurrentRow.Index).Cells(0).Value
        panelcari.Hide()
        g1.Hide()
        tb_uraian.Focus()
    End Sub

    Private Sub g2_Click_2(sender As Object, e As EventArgs) Handles g2.Click
        panelcari.Hide()
        g1.Hide()
    End Sub

    Private Sub tb_penerima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_penerima.KeyPress
        If e.KeyChar = Chr(13) Then
            If tb_nama.Text = "" Or tb_kode.Text = "" Or tb_uraian.Text = "" Or tb_penerima.Text = "" Then
                MsgBox("Data Belum Lengkap, Mohon Periksa Lagi")
            Else
                If dgv.Rows.Count = 0 Then

                    dgv.Rows.Add(kode.Text, tanggal.Text, tb_resi.Text, tb_nama.Text, tb_kode.Text, tb_uraian.Text, tb_satuan.Text, tb_bayar.Text, tb_penerima.Text, tb_no.Text)

                Else

                    x = 0
                    While ((kode.Text <> dgv.Rows(x).Cells(0).Value) And (x <= dgv.Rows.Count - 2))
                        x += 1
                    End While
                    If kode.Text = dgv.Rows(x).Cells(0).Value Then
                        tb_no.Text = Val(Microsoft.VisualBasic.Right(tb_no.Text, 4) - 1)
                        kode.Text = Val(Microsoft.VisualBasic.Right(kode.Text, 4) - 1)
                        dgv.Rows(x).Cells(7).Value += Val(jumlah.Text)

                    Else

                        dgv.Rows.Add(kode.Text, tanggal.Text, tb_resi.Text, tb_nama.Text, tb_kode.Text, tb_uraian.Text, tb_satuan.Text, tb_bayar.Text, tb_penerima.Text, tb_no.Text)

                    End If

                End If
                Call bersihkan()
                tb_nama.Focus()
                Dim kodebelanja As String = kode.Text
                Dim kodetransaksi As String = tb_no.Text
                If dgv.Rows.Count <> 0 Then
                    kodebelanja = kode.Text.ToString
                    kodebelanja = Val(Microsoft.VisualBasic.Right(kode.Text, 4) + 1)
                    kode.Text = "B" & Microsoft.VisualBasic.Left("0000", 4 - Microsoft.VisualBasic.Len(kodebelanja)) & kodebelanja
                    kodetransaksi = tb_no.Text.ToString
                    kodetransaksi = Val(Microsoft.VisualBasic.Right(tb_no.Text, 4) + 1)
                    tb_no.Text = "UKLR" & Microsoft.VisualBasic.Left("0000", 4 - Microsoft.VisualBasic.Len(kodetransaksi)) & kodetransaksi

                End If
            End If
              jumlah.Text = gettotalbelanja()
        End If
    End Sub
    Private Sub tb_bayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_bayar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True

        If e.KeyChar = Chr(13) Then
            tb_penerima.Focus()
        End If
    End Sub

    Private Sub tb_satuan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_satuan.KeyPress
        If e.KeyChar = Chr(13) Then
            tb_bayar.Focus()
        End If
    End Sub

    Private Sub tb_resi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_resi.KeyPress
        If e.KeyChar = Chr(13) Then
            tb_satuan.Focus()
        End If
    End Sub

    Private Sub panelcari_Paint(sender As Object, e As PaintEventArgs) Handles panelcari.Paint
        dgv2.DataSource = getsql("select * from t_kodepengeluaran")
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

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        bersihkan()
        dgv.Rows.Clear()
        tb_nama.Focus()
        kode.Text = getkodebelanja()
        tb_no.Text = getuangpengeluaran()
    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tb_penerima_TextChanged(sender As Object, e As EventArgs) Handles tb_penerima.TextChanged

    End Sub

    Private Sub tb_bayar_TextChanged(sender As Object, e As EventArgs) Handles tb_bayar.TextChanged

    End Sub

    Private Sub tb_no_TextChanged(sender As Object, e As EventArgs) Handles tb_no.TextChanged

    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class