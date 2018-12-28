Imports System.Windows.Forms.Control
Imports System.IO
Imports System.Data.OleDb
Public Class FData_Pengguna

    Public status As String
    Public Sub matikantb()
        t_fakultas.Enabled = False
        t_studi.Enabled = False
        t_akreditasi.Enabled = False
        t_no.Enabled = False
        t_alamat.Enabled = False
        t_ben.Enabled = False
        t_email.Enabled = False
        t_dekan.Enabled = False
        t_guru.Enabled = False
        bt_browse.Visible = False
        t_web.Enabled = False
        t_ketua.Enabled = False
        t_rektor.Enabled = False
        t_telp.Enabled = False
        t_sek.Enabled = False
        bt_cancel.Visible = False
    End Sub
    Private Sub FData_Pengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        bt_edit.Focus()
        bt_cancel.Visible = False
        Dim dtawal As DataTable
        dtawal = getsql("select * from t_pengguna")
        If dtawal.Rows.Count = 0 Then

            matikantb()
        ElseIf dtawal.Rows.Count <> 0 Then
            datarefresh()
            matikantb()
        End If
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Public Sub tampilfoto()
        str = "SELECT logo FROM t_pengguna WHERE nama_perguruan = @1"

        Using cmd As New OleDb.OleDbCommand(str, conn)
            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@1", t_guru.Text) ' keadaan where

                Using dtr As OleDb.OleDbDataReader = .ExecuteReader()
                    If dtr.HasRows Then
                        If dtr.Read() Then
                            Dim ms As New IO.MemoryStream(CType(dtr.Item("logo"), Byte()))
                            pb_foto.Image = Image.FromStream(ms) ' tampilkan gambarnya
                        End If
                    End If
                End Using
            End With
        End Using
    End Sub
    Public Sub datarefresh()
        Dim dtp As DataTable
        dtp = getsql("select * from t_pengguna")
        t_guru.Text = dtp.Rows(0)(0).ToString
        t_fakultas.Text = dtp.Rows(0)(1).ToString
        t_studi.Text = dtp.Rows(0)(2).ToString
        t_akreditasi.Text = dtp.Rows(0)(3).ToString
        t_no.Text = dtp.Rows(0)(4).ToString
        t_alamat.Text = dtp.Rows(0)(5).ToString
        t_telp.Text = dtp.Rows(0)(6).ToString
        t_email.Text = dtp.Rows(0)(7).ToString
        t_web.Text = dtp.Rows(0)(8).ToString
        t_rektor.Text = dtp.Rows(0)(9).ToString
        t_dekan.Text = dtp.Rows(0)(10).ToString
        t_ketua.Text = dtp.Rows(0)(11).ToString
        t_sek.Text = dtp.Rows(0)(12).ToString
        t_ben.Text = dtp.Rows(0)(13).ToString
        tampilfoto()
    End Sub
    Dim connection_string As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_keuanganunsur.accdb;Persist Security Info=False;"
    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        If status = "input" Then
           Using iKon = New OleDbConnection(connection_string)
                If iKon.State = ConnectionState.Open Then iKon.Close()
                iKon.Open()
                Dim transaction = iKon.BeginTransaction
                Try
                    Using iCmd = New OleDbCommand("insert into t_pengguna values (@a0, @a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9, @a10, @a11, @a12, @a13, @a14)", iKon)
                        With iCmd
                            .Transaction = transaction
                            .Parameters.Add(New OleDbParameter("@a0", t_guru.Text))
                            .Parameters.Add(New OleDbParameter("@a1", t_fakultas.Text))
                            .Parameters.Add(New OleDbParameter("@a2", t_studi.Text))
                            .Parameters.Add(New OleDbParameter("@a3", t_akreditasi.Text))
                            .Parameters.Add(New OleDbParameter("@a4", t_no.Text))
                            .Parameters.Add(New OleDbParameter("@a5", t_alamat.Text))
                            .Parameters.Add(New OleDbParameter("@a6", t_telp.Text))
                            .Parameters.Add(New OleDbParameter("@a7", t_email.Text))
                            .Parameters.Add(New OleDbParameter("@a8", t_web.Text))
                            .Parameters.Add(New OleDbParameter("@a9", t_rektor.Text))
                            .Parameters.Add(New OleDbParameter("@a10", t_dekan.Text))
                            .Parameters.Add(New OleDbParameter("@a11", t_ketua.Text))
                            .Parameters.Add(New OleDbParameter("@a12", t_sek.Text))
                            .Parameters.Add(New OleDbParameter("@a13", t_ben.Text))


                        End With
                        Dim gambar() As Byte
                        Dim img As New Bitmap(pb_foto.Image)
                        Using memStream As System.IO.MemoryStream = New System.IO.MemoryStream
                            img.Save(memStream, Imaging.ImageFormat.Jpeg)
                            Dim imgArray = memStream.GetBuffer
                            gambar = imgArray
                        End Using
                        iCmd.Parameters.Add(New OleDbParameter("@a14", gambar))
                        iCmd.ExecuteNonQuery()
                    End Using
                    transaction.Commit()

                    MsgBox("Data Mahasiswa Berhasil Di Input")
                    

                Catch ex As Exception
                    transaction.Rollback()
                    MsgBox("Error Input Mahasiswa : " & vbNewLine & ex.Message)
                End Try
            End Using
            datarefresh()
            matikantb()

        ElseIf status = "update" Then

            Dim update As String = "update t_pengguna set nama_perguruan = '" & t_guru.Text & "', fakultas = '" & t_fakultas.Text & "'," & _
                "program_studi = '" & t_studi.Text & "', akreditasi = '" & t_akreditasi.Text & "', nomor_akreditasi = '" & t_no.Text & "'," & _
                " alamat = '" & t_alamat.Text & "', no_telp = '" & t_telp.Text & "', email = '" & t_email.Text & "', website = '" & t_web.Text & "'," & _
                "rektor = '" & t_rektor.Text & "', nama_dad = '" & t_dekan.Text & "', ketua_program = '" & t_ketua.Text & "'," & _
                "sekretaris_program = '" & t_sek.Text & "', bendahara = '" & t_ben.Text & "'," & _
                "logo = @photo"

            Try
                Dim gambar() As Byte
                Dim img As New Bitmap(pb_foto.Image)
                Dim memStreamupdate As New MemoryStream
                img.Save(memStreamupdate, Imaging.ImageFormat.Jpeg)
                Dim imgArray = memStreamupdate.GetBuffer
                gambar = imgArray.ToArray
                Dim Kon As New OleDbConnection(str)
                Kon.Open()
                Dim cmdupdate As New OleDbCommand(update, Kon)
                cmdupdate.Parameters.Add(New OleDbParameter("@photo", gambar))
                cmdupdate.ExecuteNonQuery()
                MsgBox("Data Pengguna berhasil di Update", MsgBoxStyle.Information, "Success")
          



            Catch ex As Exception
                MsgBox("Error Update Mahasiswa : " & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "Alert")
            End Try
            datarefresh()
            matikantb()

        End If
    End Sub

    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Close()

    End Sub

    Private Sub bt_min_Click(sender As Object, e As EventArgs) Handles bt_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click
        MsgBox("Yakin Edit Data Pengguna?", MsgBoxStyle.YesNo)
        If DialogResult.Yes Then
            Dim dtpengguna As DataTable
            dtpengguna = getsql("select * from t_pengguna")
            If dtpengguna.Rows.Count = 0 Then
                status = "input"
                bt_cancel.Visible = True
                t_fakultas.Enabled = True
                t_studi.Enabled = True
                t_akreditasi.Enabled = True
                t_no.Enabled = True
                t_alamat.Enabled = True
                t_ben.Enabled = True
                t_email.Enabled = True
                t_dekan.Enabled = True
                t_guru.Enabled = True
                bt_browse.Visible = True
                t_web.Enabled = True
                t_ketua.Enabled = True
                t_rektor.Enabled = True
                t_telp.Enabled = True
                t_sek.Enabled = True
                t_guru.Focus()
            ElseIf dtpengguna.Rows.Count <> 0 Then
                status = "update"
                t_fakultas.Text = dtpengguna.Rows(0)(1).ToString
                t_studi.Text = dtpengguna.Rows(0)(2).ToString
                t_akreditasi.Text = dtpengguna.Rows(0)(3).ToString
                t_no.Text = dtpengguna.Rows(0)(4).ToString
                t_alamat.Text = dtpengguna.Rows(0)(5).ToString
                t_ben.Text = dtpengguna.Rows(0)(13).ToString
                t_email.Text = dtpengguna.Rows(0)(7).ToString
                t_dekan.Text = dtpengguna.Rows(0)(10).ToString
                t_guru.Text = dtpengguna.Rows(0)(0).ToString
                bt_browse.Visible = True
                t_web.Text = dtpengguna.Rows(0)(8).ToString
                t_ketua.Text = dtpengguna.Rows(0)(11).ToString
                t_rektor.Text = dtpengguna.Rows(0)(9).ToString
                t_telp.Text = dtpengguna.Rows(0)(6).ToString
                t_sek.Text = dtpengguna.Rows(0)(12).ToString
                t_fakultas.Enabled = True
                t_studi.Enabled = True
                t_akreditasi.Enabled = True
                t_no.Enabled = True
                t_alamat.Enabled = True
                t_ben.Enabled = True
                t_email.Enabled = True
                t_dekan.Enabled = True
                t_guru.Enabled = True
                bt_browse.Visible = True
                t_web.Enabled = True
                t_ketua.Enabled = True
                t_rektor.Enabled = True
                t_telp.Enabled = True
                t_sek.Enabled = True
                bt_cancel.Visible = True
                t_guru.Focus()
            End If

        Else
        End If

    End Sub

    Private Sub bt_exit_Click(sender As Object, e As EventArgs) Handles bt_exit.Click
        Me.Close()

    End Sub

    Private Sub bt_browse_Click(sender As Object, e As EventArgs) Handles bt_browse.Click
        Dim lebar As Integer = 138
        Dim tinggi As Integer = 157
        'deklarasi open file dialog untuk memilih gambar yang ingin dimasukan kedalam database
        Dim open_file As New OpenFileDialog
        With open_file
            'filter open file dialog hanya memunculkan file dengan extensi jpg
            .FileName = ""
            .Filter = "*.BMP;*.JPG;*.GIF;*.PNG|*.BMP;*.JPG;*.GIF;*.PNG"
            .FilterIndex = 1
            'jika dialog open file di cancel batalkan operasi.
            If .ShowDialog = DialogResult.Cancel Then Exit Sub
            Dim igambar As Image = Image.FromStream(.OpenFile())
            'buat bitmap dengan ukuran lebar dan tinggi sesuai dengan yang dideklarasikan
            Dim ngambar As New Bitmap(lebar, tinggi)
            Dim grap As Graphics = Graphics.FromImage(ngambar)
            With grap
                .FillRectangle(Brushes.White, New Rectangle(0, 0, lebar, tinggi))
                .DrawImage(igambar, 3, 3, lebar - 6, tinggi - 6)
                .Flush()
                .Dispose()
            End With
            pb_foto.Image = ngambar
        End With
    End Sub

    Private Sub bt_cancel_Click(sender As Object, e As EventArgs) Handles bt_cancel.Click
        matikantb()
    End Sub
End Class