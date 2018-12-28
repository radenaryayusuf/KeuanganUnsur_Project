Imports System.Data.OleDb
Public Class Form_Utama

    Private Sub KodeTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KodeTransaksiToolStripMenuItem.Click

    End Sub


    Private Sub PenerimaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenerimaanToolStripMenuItem.Click
        FPenerimaan_bayar.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)
        FPenerimaan_bayar.Show()
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs)
        FInput_Mahasiswa.Show()
    End Sub

    Private Sub DataMahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FData_Mahasiswa.Show()
    End Sub

    Private Sub InputMahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FInput_Mahasiswa.Show()
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Form_Utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call koneksi()
        Label6.Text = totaldosen()
        Label7.Text = totalpegawai()
        Label10.Text = totalmahasiswa()

        TabControl1.Visible = False
        sembunyikan_task.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FInput_PegawaidanDosen.Show()
        statusinput = "inputpegawaidandosen"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FInput_PegawaidanDosen.Show()
        With FInput_PegawaidanDosen
            .TabControl1.SelectedIndex = 1
            statusinput = "inputpegawaidandosen"
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FData_Mahasiswa.Show()
        statusinput = "inputmahasiswa"
    End Sub

    Private Sub KodePemasukanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KodePemasukanToolStripMenuItem.Click
        If TabControl1.Visible = False Then
            TabControl1.Visible = True
            Tampilkan(FKode_Pemasukan)
        ElseIf TabControl1.Visible = True Then
            Tampilkan(FKode_Pemasukan)
        End If
    End Sub

    Private Sub KodePengeluaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KodePengeluaranToolStripMenuItem.Click
        If TabControl1.Visible = False Then
            TabControl1.Visible = True
            Tampilkan(FKode_Pengeluaran)
        ElseIf TabControl1.Visible = True Then
            Tampilkan(FKode_Pengeluaran)
        End If
    End Sub

    Private Sub BesaranGajiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BesaranGajiToolStripMenuItem.Click
        If TabControl1.Visible = False Then
            TabControl1.Visible = True
            Tampilkan(FPembayaran_Dosen)
        ElseIf TabControl1.Visible = True Then
            Tampilkan(FPembayaran_Dosen)
        End If
    End Sub

    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs)
        If MsgBox("Yakin keluar?" & vbNewLine & "Semua window akan ditutup", MsgBoxStyle.YesNo, "Log Out") = Windows.Forms.DialogResult.Yes Then
            End
        Else
            Exit Sub
        End If
        End
    End Sub

    Private Sub DataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataToolStripMenuItem.Click
        FData_Keuangan.Show()
    End Sub

    Private Sub MahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MahasiswaToolStripMenuItem.Click
        FData_Mahasiswa.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub PegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegawaiToolStripMenuItem.Click
        If TabControl1.Visible = False Then
            TabControl1.Visible = True
            Tampilkan(FPenggajian)
        ElseIf TabControl1.Visible = True Then
            Tampilkan(FPenggajian)
        End If
    End Sub

    Private Sub BelanjaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BelanjaToolStripMenuItem.Click
        FPembelanjaan.Show()
    End Sub

    Private Sub PenggajianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenggajianToolStripMenuItem.Click
        FGaji.Show()
    End Sub

    Private Sub DosenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DosenToolStripMenuItem.Click
        FBayar_Dosen.Show()
    End Sub

    Private Sub KwitansiPengeluaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KwitansiPengeluaranToolStripMenuItem.Click
        Freport_Pengeluaran.Show()

    End Sub

    Private Sub KwitansiPenggajianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KwitansiPenggajianToolStripMenuItem.Click

    End Sub

    Private Sub DosenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DosenToolStripMenuItem1.Click
        FReport_peggajianDosen.Show()
    End Sub

    Private Sub PegawaiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PegawaiToolStripMenuItem1.Click
        FReport_Penggajian.Show()

    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click

    End Sub

    Private Sub KasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KasToolStripMenuItem.Click
        FReport_kas.Show()

    End Sub


    Private Sub KwitansiPemasukanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KwitansiPemasukanToolStripMenuItem.Click
        FReport_UMHS.Show()
    End Sub

    Private Sub Form_Utama_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        FPenerimaan_bayar.Show()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        FBayar_Dosen.Show()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        FPembelanjaan.Show()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        If TabControl1.Visible = False Then
            TabControl1.Visible = True
            Tampilkan(FStatus_Bayar_Siswa)
        ElseIf TabControl1.Visible = True Then
            Tampilkan(FStatus_Bayar_Siswa)
        End If
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        FKas.Show()
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        FNeraca.Show()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        statuspindah = "formdatamhs"
        statusproses = "insert"
        With FInput_Mahasiswa
            .Show()
            .tno.Enabled = False
            .tnamalengkap.Focus()

        End With
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        FGaji.Show()
    End Sub
    Private Sub btsave_Click_1(sender As Object, e As EventArgs) Handles btsave.Click
        If MsgBox("Yakin keluar?" & vbNewLine & "Semua window akan ditutup", MsgBoxStyle.YesNo, "Log Out") = Windows.Forms.DialogResult.Yes Then
            End
        Else
            Exit Sub
        End If
        End
    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles  tampilkan_task.Click
        tampilkan_task.Hide()
        While (task_keluarmasuk.Height < 89)
            task_keluarmasuk.Height += 1
        End While
        sembunyikan_task.Location = New System.Drawing.Point(804, 64)
        sembunyikan_task.Visible = True
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gb_tasknya.Enter

    End Sub


    Private Sub sembunyikan_task_Click(sender As Object, e As EventArgs) Handles sembunyikan_task.Click
        sembunyikan_task.Visible = False

        While (task_keluarmasuk.Height > 9)
            task_keluarmasuk.Height -= 1
        End While
        tampilkan_task.Show()
    End Sub
End Class
