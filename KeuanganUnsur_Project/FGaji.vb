Public Class FGaji
    Public x, status As String
    Public Sub buatkolom()
        dgv.Columns.Add("nomor", "Nomor")
        dgv.Columns.Add("tanggal", "Tanggal")
        dgv.Columns.Add("kode", "Kode Akun")
        dgv.Columns.Add("akun", "Nama Akun")
        dgv.Columns.Add("namapegawai", "Nama Pegawai")
        dgv.Columns.Add("rincian", "Rincian")
        dgv.Columns.Add("jumlah", "Jumlah")
        dgv.Columns.Add("notransaksi", "No Transaksi")

        dgv.RowHeadersVisible = False
    End Sub

    Private Sub FGaji_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call buatkolom()
        panelcari.Hide()
        g1.Hide()
        kode.Text = getgaji()
        tanggal.Format = DateTimePickerFormat.Custom
        tanggal.CustomFormat = "yyyy-MM-dd"
        tb_no.Text = getuangpengeluaran()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        Me.Close()
    End Sub
    Public Sub input()
        status = "input"
        Dim pemasukan As Integer = 0
        Dim ket As String = "uang keluar"
        Dim nomor, tanggal, kodeakun, namaakun, nama, rincian, jumlah, notransaksi As String
        For baris As Integer = 0 To dgv.Rows.Count - 1
            nomor = dgv.Rows(baris).Cells(0).Value
            tanggal = dgv.Rows(baris).Cells(1).Value
            kodeakun = dgv.Rows(baris).Cells(2).Value
            namaakun = dgv.Rows(baris).Cells(3).Value
            nama = dgv.Rows(baris).Cells(4).Value
            rincian = dgv.Rows(baris).Cells(5).Value
            jumlah = dgv.Rows(baris).Cells(6).Value
            notransaksi = dgv.Rows(baris).Cells(7).Value
            setsql("INSERT INTO t_keluar(nomor, tgl, nama_pegawai, nama_akun, kode_akun, uraian, jumlah) VALUES ('" & notransaksi & "','" & tanggal & "','" & nama & "','" & namaakun & "','" & kodeakun & "','" & rincian & "','" & jumlah & "')")
            setsql("insert into t_ugaji(nomer, tgl, nama_pegawai, kode_akun, nama_akun, uraian, jumlah) values ('" & nomor & "','" & tanggal & "','" & nama & "','" & kodeakun & "','" & namaakun & "','" & rincian & "','" & jumlah & "')")
            setsql("INSERT INTO t_kas VALUES ('" & notransaksi & "','" & tanggal & "','" & rincian & "','" & kodeakun & "','" & namaakun & "','" & pemasukan & "','" & jumlah & "','" & ket & "')")

        Next
         
    End Sub
    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click

        If status = "input" Then
            If namapegawai.Text = "" Or namaakun.Text = "" Or kodeakun.Text = "" Or tanggal.Text = "" Then
                MsgBox("Data Belum Lengkap, Mohon Periksa Lagi")
            Else
                If dgv.Rows.Count = 0 Then
                    dgv.Rows.Add(kode.Text, tanggal.Text, kodeakun.Text, namaakun.Text, namapegawai.Text, rinciangaji.Text, jumlah.Text)
                Else
                    x = 0
                    While ((namaakun.Text <> dgv.Rows(x).Cells(3).Value) And (namapegawai.Text <> dgv.Rows(x).Cells(4).Value) And (kode.Text <> dgv.Rows(x).Cells(0).Value) And (x <= dgv.Rows.Count - 2))
                        x += 1
                    End While
                    If namapegawai.Text = dgv.Rows(x).Cells(4).Value Or kodeakun.Text = dgv.Rows(x).Cells(2).Value Then
                        kode.Text = Val(Microsoft.VisualBasic.Right(kode.Text, 4) - 1)
                        dgv.Rows(x).Cells(6).Value += Val(jumlah.Text)
                    Else
                        dgv.Rows.Add(kode.Text, tanggal.Text, kodeakun.Text, namaakun.Text, namapegawai.Text, rinciangaji.Text, jumlah.Text)

                    End If

                End If
                Call bersihkan()
                namapegawai.Focus()
                Dim kodegaji As String = kode.Text
                If dgv.Rows.Count <> 0 Then
                    kodegaji = kode.Text.ToString
                    kodegaji = Val(Microsoft.VisualBasic.Right(kode.Text, 4) + 1)
                    kode.Text = "GJI" & Microsoft.VisualBasic.Left("0000", 4 - Microsoft.VisualBasic.Len(kodegaji)) & kodegaji

                End If
            End If
        Else
            ubah()
        End If
    End Sub
    Sub bersihkan()
        namapegawai.Text = ""
        namaakun.Text = ""
        kodeakun.Text = ""
        rinciangaji.Text = ""
        bayar.Text = ""
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, PictureBox3.Click
        status = "pegawai"
        labeltitle.Text = "Cari Data Pegawai"
        panelcari.Show()
        g1.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        status = "akun"
        labeltitle.Text = "Cari Kode Akun"
        panelcari.Show()
        g1.Show()
    End Sub

    Private Sub g2_Click(sender As Object, e As EventArgs) Handles g2.Click
        panelcari.Hide()
        g1.Hide()
    End Sub

    Private Sub g1_Click(sender As Object, e As EventArgs) Handles g1.Click
        panelcari.Hide()
        g1.Hide()
    End Sub
    Public Sub cariid()
        If status = "pegawai" Then
            DataGridView1.DataSource = getsql("select * from t_pegawai")

        ElseIf status = "akun" Then
            DataGridView1.DataSource = getsql("select * from t_kodeugaji")
        End If
    End Sub
    Private Sub panelcari_Paint(sender As Object, e As PaintEventArgs) Handles panelcari.Paint
        cariid()
    End Sub
    Private Sub labeltitle_TextChanged(sender As Object, e As EventArgs) Handles labeltitle.TextChanged
        cariid()
    End Sub

    
    Public Sub refreshkode()
        kode.Text = getgaji()
    End Sub
    Private Sub rinciangaji_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rinciangaji.KeyPress

        If e.KeyChar = Chr(13) Then
            bayar.Focus()

            
        End If

    End Sub

    Private Sub rinciangaji_KeyUp(sender As Object, e As KeyEventArgs) Handles rinciangaji.KeyUp
        
    End Sub

    Private Sub rinciangaji_TextChanged(sender As Object, e As EventArgs) Handles rinciangaji.TextChanged
       
    End Sub

    Private Sub BunifuCustomTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuCustomTextbox1.KeyPress

    End Sub

    Private Sub BunifuCustomTextbox1_TextChanged(sender As Object, e As EventArgs) Handles BunifuCustomTextbox1.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        input()
        MsgBox("Data Tersimpan", MsgBoxStyle.Information, "Success")
        Call bersihkan()
        dgv.Rows.Clear
        namapegawai.Focus()
        kode.Text = getgaji()
    End Sub

    Private Sub labeltitle_Click(sender As Object, e As EventArgs) Handles labeltitle.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub kode_TextChanged(sender As Object, e As EventArgs) Handles kode.TextChanged
       
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        MsgBox("Yakin Cancel?", MsgBoxStyle.YesNo, "INFO")
        If MsgBoxResult.Yes Then
            dgv.Rows.Clear()
            kode.Text = getgaji()
            namapegawai.Focus()
            tb_no.Text = getuangpengeluaran()
        End If
    End Sub
    Public Sub ubah()
        status = "ubah"

        If kode.Text = getgaji() Then
            namapegawai.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(4).Value
            kodeakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(3).Value
            namaakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(2).Value
            rinciangaji.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(5).Value
            bayar.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(6).Value
            namapegawai.Focus()
        ElseIf kode.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value Then
            If namapegawai.Text = "" Or namaakun.Text = "" Or kodeakun.Text = "" Or tanggal.Text = "" Then
                MsgBox("Data Belum Lengkap, Mohon Periksa Lagi")
            Else
                
                    x = 0
                    While ((namaakun.Text <> dgv.Rows(x).Cells(3).Value) And (namapegawai.Text <> dgv.Rows(x).Cells(4).Value) And (kode.Text <> dgv.Rows(x).Cells(0).Value) And (x <= dgv.Rows.Count - 2))
                        x += 1
                    End While
                    If namapegawai.Text = dgv.Rows(x).Cells(4).Value Or kodeakun.Text = dgv.Rows(x).Cells(2).Value Then
                        kode.Text = Val(Microsoft.VisualBasic.Right(kode.Text, 4) - 1)
                        dgv.Rows(x).Cells(6).Value += Val(bayar.Text)
                    Else
                        dgv.Rows.Add(kode.Text, tanggal.Text, kodeakun.Text, namaakun.Text, namapegawai.Text, rinciangaji.Text, bayar.Text)
                    End If

                    Call bersihkan()
                    namapegawai.Focus()
                    Dim kodegaji As String = kode.Text
                    If dgv.Rows.Count <> 0 Then
                        kodegaji = kode.Text.ToString
                        kodegaji = Val(Microsoft.VisualBasic.Right(kode.Text, 4) + 1)
                        kode.Text = "GJI" & Microsoft.VisualBasic.Left("0000", 4 - Microsoft.VisualBasic.Len(kodegaji)) & kodegaji

                    End If
                End If

        ElseIf kode.Text <> getkodepengeluaran() Then
            namapegawai.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(4).Value
            kodeakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(3).Value
            namaakun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(2).Value
            rinciangaji.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(5).Value
            bayar.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(6).Value
            namapegawai.Focus()
        End If
    End Sub
    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
        ubah()
    End Sub
    Function gettotalbelanja()

        Dim hitungbelanja As Integer = 0
        For I As Integer = 0 To dgv.Rows.Count - 1
            hitungbelanja = hitungbelanja + Val(dgv.Rows(I).Cells(6).Value)
        Next
        Return hitungbelanja
    End Function
    Private Sub bayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bayar.KeyPress
        If e.KeyChar = Chr(13) Then
                If namapegawai.Text = "" Or namaakun.Text = "" Or kodeakun.Text = "" Or tanggal.Text = "" Then
                    MsgBox("Data Belum Lengkap, Mohon Periksa Lagi")
                Else
                    If dgv.Rows.Count = 0 Then

                    dgv.Rows.Add(kode.Text, tanggal.Text, kodeakun.Text, namaakun.Text, namapegawai.Text, rinciangaji.Text, bayar.Text, tb_no.Text)

                    Else

                        x = 0
                        While ((namaakun.Text <> dgv.Rows(x).Cells(3).Value) And (namapegawai.Text <> dgv.Rows(x).Cells(4).Value) And (kode.Text <> dgv.Rows(x).Cells(0).Value) And (x <= dgv.Rows.Count - 2))
                            x += 1
                        End While
                        If namapegawai.Text = dgv.Rows(x).Cells(4).Value Or kodeakun.Text = dgv.Rows(x).Cells(2).Value Then
                            kode.Text = Val(Microsoft.VisualBasic.Right(kode.Text, 4) - 1)
                            dgv.Rows(x).Cells(6).Value += Val(jumlah.Text)
                        tb_no.Text = Val(Microsoft.VisualBasic.Right(tb_no.Text, 4) - 1)
                        Else


                        dgv.Rows.Add(kode.Text, tanggal.Text, kodeakun.Text, namaakun.Text, namapegawai.Text, rinciangaji.Text, bayar.Text, tb_no.Text)

                        End If

                    End If
                    Call bersihkan()
                    namapegawai.Focus()
                Dim kodegaji As String = kode.Text
                Dim kodetransaksi As String = tb_no.Text
                    If dgv.Rows.Count <> 0 Then
                        kodegaji = kode.Text.ToString
                        kodegaji = Val(Microsoft.VisualBasic.Right(kode.Text, 4) + 1)
                        kode.Text = "GJI" & Microsoft.VisualBasic.Left("0000", 4 - Microsoft.VisualBasic.Len(kodegaji)) & kodegaji
                    kodetransaksi = tb_no.Text.ToString
                    kodetransaksi = Val(Microsoft.VisualBasic.Right(tb_no.Text, 4) + 1)
                    tb_no.Text = "UKLR" & Microsoft.VisualBasic.Left("0000", 4 - Microsoft.VisualBasic.Len(kodetransaksi)) & kodetransaksi
                    End If
                End If
            jumlah.Text = gettotalbelanja()
        End If
    End Sub

    Private Sub bayar_TextChanged(sender As Object, e As EventArgs) Handles bayar.TextChanged

    End Sub

    Private Sub BunifuImageButton9_Click(sender As Object, e As EventArgs) Handles BunifuImageButton9.Click

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

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If status = "pegawai" Then
            namapegawai.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            panelcari.Hide()
            g1.Hide()
            namaakun.Focus()

        ElseIf status = "akun" Then
            namaakun.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            kodeakun.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
            bayar.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
            panelcari.Hide()
            g1.Hide()
            rinciangaji.Focus()
        End If
    End Sub
End Class