Imports System.Windows.Forms.Control
Imports System.IO
Imports System.Data.OleDb

Public Class FInput_Mahasiswa
    Dim i As New Integer
    Dim open_file As New OpenFileDialog
    Public jenis_kelamin As String
    Private Property setsql As String
    Dim bytImage() As Byte
    Dim indexmhs As Integer = 0
    Dim tablemhs As New DataTable()
    Private Function GetImageFromByteArray(ByVal picData As Byte()) As Image
        If picData Is Nothing Then
            Return Nothing
        End If

        Dim bmData As Integer = IIf((picData(0) = 21 AndAlso picData(1) = 28), 78, 0)

        ' load the picture 
        Dim img As Image = Nothing
        Try
            Dim ms As New MemoryStream(picData, bmData, picData.Length - bmData)
            img = Image.FromStream(ms)
        Catch
        End Try ' return what we got Return img
        Return img

    End Function
   
    Public Sub showData(position As Integer)

        Dim commandmhs As New OleDbCommand("select * from t_mhs ", conn)
        Dim adaptermhs As New OleDbDataAdapter(commandmhs)

        adaptermhs.Fill(tablemhs)
        If tablemhs.Rows.Count = 0 Then
            MsgBox("Belum Ada Data", MsgBoxStyle.Information, "Perhatian")
        Else
            tno.Text = tablemhs.Rows(position)(0).ToString()
            tnamalengkap.Text = tablemhs.Rows(position)(1).ToString()
            tnpm.Text = tablemhs.Rows(position)(2).ToString()
            tsemester.Text = tablemhs.Rows(position)(3).ToString()
            tangkatan.Text = tablemhs.Rows(position)(4).ToString()
            If tablemhs.Rows(position)(5).ToString() = "Pria" Then
                rdpria.Checked = True
            Else
                rdwanita.Checked = True
            End If
            ttempatlahir.Text = tablemhs.Rows(position)(6).ToString()
            dtptgllahir.Text = tablemhs.Rows(position)(7).ToString()
            tnik.Text = tablemhs.Rows(position)(8).ToString()
            cbagama.Text = tablemhs.Rows(position)(9).ToString()
            tjalan.Text = tablemhs.Rows(position)(10).ToString()
            tdusun.Text = tablemhs.Rows(position)(11).ToString()
            tkelurahan.Text = tablemhs.Rows(position)(12).ToString()
            tkecamatan.Text = tablemhs.Rows(position)(13).ToString()
            tkabupaten.Text = tablemhs.Rows(position)(14).ToString()
            tnohp.Text = tablemhs.Rows(position)(15).ToString()
            twa.Text = tablemhs.Rows(position)(16).ToString()
            temail.Text = tablemhs.Rows(position)(17).ToString()
            tpekerjaan.Text = tablemhs.Rows(position)(18).ToString()
            talumni.Text = tablemhs.Rows(position)(19).ToString()
            tgelar.Text = tablemhs.Rows(position)(20).ToString()
            tnamaibu.Text = tablemhs.Rows(position)(21).ToString()
            tibuttl.Text = tablemhs.Rows(position)(22).ToString()
            tnamaayah.Text = tablemhs.Rows(position)(23).ToString()
            tayahttl.Text = tablemhs.Rows(position)(24).ToString()
            tayahkerja.Text = tablemhs.Rows(position)(25).ToString()
            tayahhasil.Text = tablemhs.Rows(position)(26).ToString()
            pb_foto.Image = GetImageFromByteArray(tablemhs.Rows(position)(27))
            tb_catatan.Text = tablemhs.Rows(position)(28).ToString()
        End If
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
    Private Sub BunifuCustomLabel18_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel18.Click

    End Sub

    Private Sub FInput_Mahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        panelcarimhs.Hide()
        If statusproses = "insert" Then
            Dim image As Image = image.FromFile("question.png")
            pb_foto.Image = image
        ElseIf statusproses = "update" And statuspindah = "formdatamhs" Then

            With FData_Mahasiswa
                .tampilfoto()
            End With
        End If
        cbagama.Items.Add("Islam")
        cbagama.Items.Add("Kristen Protestan")
        cbagama.Items.Add("Kristen Katolik")
        cbagama.Items.Add("Hindu")
        cbagama.Items.Add("Buddha")
        cbagama.Items.Add("Konghucu")
        Call koneksi()
        Dim i As Integer
        Dim TBs As ControlCollection
        Dim TB As TextBox
        TBs = Me.Controls
        For i = 0 To TBs.Count - 1
            If TypeOf TBs.Item(i) Is TextBox Then
                TB = TBs.Item(i)
                TB.ReadOnly = False
                TB.Text = ""
            End If
        Next

        tno.Text = getidmahasiswa()
        tno.ReadOnly = True
        rdpria.Enabled = True
        rdwanita.Enabled = True
        cbagama.Enabled = True
        dtptgllahir.Enabled = True
        If statusproses = "insert" Then
            bt_update.Visible = False
            Label3.Visible = False
            bt_cancel.Visible = False
            panelcarimhs.Hide()
            Label4.Visible = False
            BunifuImageButton4.Visible = False
        ElseIf statusproses = "update" And statuspindah = "formdatamhs" Then
            bt_save.Visible = False
            Label2.Visible = False
            BunifuImageButton2.Visible = False
            Label1.Visible = False
            panelcarimhs.Hide()
            bt_update.Location = New System.Drawing.Point(621, 652)
            Label3.Location = New System.Drawing.Point(626, 720)
            bt_cancel.Location = New System.Drawing.Point(844, 652)
            Label4.Location = New System.Drawing.Point(849, 720)
            BunifuImageButton4.Visible = False
        ElseIf statusproses = "ubah" And statuspindah = "stay" Then
            panelcarimhs.Hide()
        End If

    End Sub

    Private Sub BunifuCustomLabel30_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub rdpria_CheckedChanged(sender As Object, e As EventArgs) Handles rdpria.CheckedChanged
        If rdpria.Checked = True Then
            jenis_kelamin = "Pria"
            
        End If
        If statusproses = "insert" Then
            Dim image As Image = image.FromFile("student.png")
            pb_foto.Image = image
        ElseIf statusproses = "update" Then
            With FData_Mahasiswa
                .tampilfoto()
            End With
        End If
    End Sub

    Private Sub rdwanita_CheckedChanged(sender As Object, e As EventArgs) Handles rdwanita.CheckedChanged
        If rdwanita.Checked = True Then
            jenis_kelamin = "Wanita"
            
        End If
        If statusproses = "insert" Then
            Dim image As Image = image.FromFile("student_w.png")
            pb_foto.Image = image
        ElseIf statusproses = "update" Then
            With FData_Mahasiswa
                .tampilfoto()
            End With
        End If

    End Sub

    Dim connection_string As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_keuanganunsur.accdb;Persist Security Info=False;"
    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        If statuspindah = "formdatamhs" And statusproses = "insert" Then
            Try
                If tno.Text <> "" And rdpria.Checked = True Or rdwanita.Checked = True Then
                    Using cmdmhs As New OleDbCommand("insert into t_mhs values (@a0, @a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9, @a10, @a11, @a12, @a13, @a14, @a15, @a16, @a17, @a18, @a19, @a20, @a21, @a22, @a23, @a24, @a25, @a26, @a27, @a28)", conn)
                        With cmdmhs
                            .Parameters.Add(New OleDbParameter("@a0", tno.Text))
                            .Parameters.Add(New OleDbParameter("@a1", tnamalengkap.Text))
                            .Parameters.Add(New OleDbParameter("@a2", tnpm.Text))
                            .Parameters.Add(New OleDbParameter("@a3", tsemester.Text))
                            .Parameters.Add(New OleDbParameter("@a4", tangkatan.Text))
                            .Parameters.Add(New OleDbParameter("@a5", jenis_kelamin))
                            .Parameters.Add(New OleDbParameter("@a6", ttempatlahir.Text))
                            .Parameters.Add(New OleDbParameter("@a7", dtptgllahir.Text))
                            .Parameters.Add(New OleDbParameter("@a8", tnik.Text))
                            .Parameters.Add(New OleDbParameter("@a9", cbagama.Text))
                            .Parameters.Add(New OleDbParameter("@a10", tjalan.Text))
                            .Parameters.Add(New OleDbParameter("@a11", tdusun.Text))
                            .Parameters.Add(New OleDbParameter("@a12", tkelurahan.Text))
                            .Parameters.Add(New OleDbParameter("@a13", tkecamatan.Text))
                            .Parameters.Add(New OleDbParameter("@a14", tkabupaten.Text))
                            .Parameters.Add(New OleDbParameter("@a15", tnohp.Text))
                            .Parameters.Add(New OleDbParameter("@a16", twa.Text))
                            .Parameters.Add(New OleDbParameter("@a17", temail.Text))
                            .Parameters.Add(New OleDbParameter("@a18", tpekerjaan.Text))
                            .Parameters.Add(New OleDbParameter("@a19", talumni.Text))
                            .Parameters.Add(New OleDbParameter("@a20", tgelar.Text))
                            .Parameters.Add(New OleDbParameter("@a21", tnamaibu.Text))
                            .Parameters.Add(New OleDbParameter("@a22", tibuttl.Text))
                            .Parameters.Add(New OleDbParameter("@a23", tnamaayah.Text))
                            .Parameters.Add(New OleDbParameter("@a24", tayahttl.Text))
                            .Parameters.Add(New OleDbParameter("@a25", tayahhasil.Text))
                            .Parameters.Add(New OleDbParameter("@a26", tayahkerja.Text))

                            Dim gambar() As Byte
                            Dim img As New Bitmap(pb_foto.Image)
                            Using memStream As System.IO.MemoryStream = New System.IO.MemoryStream
                                img.Save(memStream, Imaging.ImageFormat.Jpeg)
                                Dim imgArray = memStream.GetBuffer
                                gambar = imgArray
                            End Using
                            .Parameters.Add(New OleDbParameter("@a27", gambar))
                            .Parameters.Add(New OleDbParameter("@a28", tb_catatan.Text))
                        End With
                        cmdmhs.ExecuteNonQuery()
                        Dim strBasePath As String
                        Dim strFilePath As String
                        Dim strFileName As String

                        strFileName = "" & tno.Text & "-" & tnamalengkap.Text & ".jpg"
                        strBasePath = "C:\Documents\KeuanganUnsur\Image\DataMahasiswa"
                        ' >> Check if Folder Exists 
                        If Directory.Exists(strBasePath) = False Then
                            Call Directory.CreateDirectory(strBasePath)
                        End If
                        ' >> Save Picture 
                        Call pb_foto.Image.Save(strBasePath & "\" & strFileName, System.Drawing.Imaging.ImageFormat.Jpeg)

                        MsgBox("Data Mahasiswa " & tnamalengkap.Text & " Berhasil Di Input", MsgBoxStyle.Information, "Success")
                        If MsgBoxResult.Yes Then
                            hapussemua()
                            Dim getidmhs As String
                            getidmhs = getidmahasiswa()
                            tno.Text = getidmhs
                            tnamalengkap.Focus()
                            Dim image As Image = image.FromFile("question.png")
                            pb_foto.Image = image
                        End If

                    End Using
                Else
                    MsgBox("Data tidak boleh kosong" & vbNewLine & "Silahkan periksa kembali kelengkapan data", MsgBoxStyle.Critical, "Input Data Gagal")

                End If
            Catch ex As Exception
                MsgBox("Error Terjadi Input Mahasiswa : " & vbNewLine & ex.Message)
            End Try
        End If
    End Sub

    Private Sub bt_browse_Click(sender As Object, e As EventArgs) Handles bt_browse.Click
        Dim lebar As Integer = 138
        Dim tinggi As Integer = 157
        'deklarasi open file dialog untuk memilih gambar yang ingin dimasukan kedalam database

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



    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        If statuspindah = "formdatamhs" Then
            Me.Close()
            FData_Mahasiswa.Show()
            FData_Mahasiswa.datamhs()
            FData_Mahasiswa.mulaimhs()
        End If


    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tnamalengkap_TextChanged(sender As Object, e As EventArgs) Handles tnamalengkap.TextChanged
        Data.lnama.Text = tnamalengkap.Text

    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tno_TextChanged(sender As Object, e As EventArgs) Handles tno.TextChanged

    End Sub

    Private Sub BunifuImageButton10_Click(sender As Object, e As EventArgs) Handles nextdata.Click
        indexmhs += 1
        If indexmhs > tablemhs.Rows.Count() - 1 Then

            indexmhs = tablemhs.Rows.Count() - 1

        End If
        showData(indexmhs)

    End Sub

    Private Sub tayahhasil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tayahhasil.KeyPress

    End Sub

    Private Sub tayahhasil_TextChanged(sender As Object, e As EventArgs) Handles tayahhasil.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FData_Mahasiswa.Show()
        FData_Mahasiswa.datamhs()
        FData_Mahasiswa.mulaimhs()
    End Sub
    Sub ReplaceFile(ByVal FileToMoveAndDelete As String, ByVal FileToReplace As String, ByVal BackupOfFileToReplace As String)

        ' Replace the file.
        File.Replace(FileToMoveAndDelete, FileToReplace, BackupOfFileToReplace, False)

    End Sub
    Private Sub bt_update_Click(sender As Object, e As EventArgs) Handles bt_update.Click
        If statusproses = "update" And statuspindah = "formdatamhs" Then
            Dim update As String = "update t_mhs set nama = '" & tnamalengkap.Text & "', npm = '" & tnpm.Text & "', semester = '" & tsemester.Text & "'," & _
                "angkatan = '" & tangkatan.Text & "' , jk = '" & jenis_kelamin & "', tmp_lahir = '" & ttempatlahir.Text & "'," & _
                "tgl_lahir = '" & dtptgllahir.Text & "', ktp = '" & tnik.Text & "', agama = '" & cbagama.Text & "', al_jalan = '" & tjalan.Text & "'," & _
                " al_dusun = '" & tdusun.Text & "', al_kelurahan = '" & tkelurahan.Text & "', al_kecamatan = '" & tkecamatan.Text & "'," & _
                " al_kabupaten = '" & tkabupaten.Text & "', no_telp = '" & tnohp.Text & "', wa = '" & twa.Text & "', email = '" & temail.Text & "'," & _
                " pekerjaan = '" & tpekerjaan.Text & "', alumni_s1 = '" & talumni.Text & "', prodi_s1 = '" & tgelar.Text & "'," & _
                " namaibu = '" & tnamaibu.Text & "', itgllahir = '" & tibuttl.Text & "', namaayah = '" & tnamaayah.Text & "'," & _
                " atgllahir = '" & tayahttl.Text & "', apenghasilan = '" & tayahhasil.Text & "', apekerjaan = '" & tayahkerja.Text & "'," & _
                " foto = @photo, catatan = '" & tb_catatan.Text & "' where nomor = '" & tno.Text & "'"

            Try
                Dim gambar() As Byte
                Dim img As New Bitmap(pb_foto.Image)
                Dim memStreamupdate As New MemoryStream
                img.Save(memStreamupdate, Imaging.ImageFormat.Jpeg)
                Dim imgArray = memStreamupdate.GetBuffer
                gambar = imgArray.ToArray
                Dim cmdupdate As New OleDbCommand(update, conn)
                cmdupdate.Parameters.Add(New OleDbParameter("@photo", gambar))
                Dim dtmhsbefore As DataTable
                dtmhsbefore = getsql("select nomor, nama from t_mhs where nomor = '" & tno.Text & "'")
                If System.IO.File.Exists("C:\Documents\KeuanganUnsur\Image\DataMahasiswa\" & dtmhsbefore.Rows(0)(0).ToString & "-" & dtmhsbefore.Rows(0)(1) & ".jpg") = False Then
                    cmdupdate.ExecuteNonQuery()
                ElseIf System.IO.File.Exists("C:\Documents\KeuanganUnsur\Image\DataMahasiswa\" & dtmhsbefore.Rows(0)(0).ToString & "-" & dtmhsbefore.Rows(0)(1) & ".jpg") = True Then
                    System.IO.File.Delete("C:\Documents\KeuanganUnsur\Image\DataMahasiswa\" & dtmhsbefore.Rows(0)(0).ToString & "-" & dtmhsbefore.Rows(0)(1) & ".jpg")
                    cmdupdate.ExecuteNonQuery()
                End If
                Dim strBasePath As String
                Dim strFileName As String
                strFileName = "" & tno.Text & "-" & tnamalengkap.Text & ".jpg"
                strBasePath = "C:\Documents\KeuanganUnsur\Image\DataMahasiswa"
                ' >> Check if Folder Exists 
                If Directory.Exists(strBasePath) = False Then
                    Call Directory.CreateDirectory(strBasePath)
                End If
                ' >> Save Picture 

                Call pb_foto.Image.Save(strBasePath & "\" & strFileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                MsgBox("Data Mahasiswa Berhasil Di Update", MsgBoxStyle.Information, "Perhatian")
                Me.Close()
                FData_Mahasiswa.Show()
                FData_Mahasiswa.datamhs()
                FData_Mahasiswa.mulaimhs()



            Catch ex As Exception
                MsgBox("Error Update Mahasiswa : " & vbNewLine & ex.Message)
            End Try
        ElseIf statusproses = "ubah" And statuspindah = "stay" Then
            Dim update As String = "update t_mhs set nama = '" & tnamalengkap.Text & "', npm = '" & tnpm.Text & "', semester = '" & tsemester.Text & "'," & _
               "angkatan = '" & tangkatan.Text & "' , jk = '" & jenis_kelamin & "', tmp_lahir = '" & ttempatlahir.Text & "'," & _
               "tgl_lahir = '" & dtptgllahir.Text & "', ktp = '" & tnik.Text & "', agama = '" & cbagama.Text & "', al_jalan = '" & tjalan.Text & "'," & _
               " al_dusun = '" & tdusun.Text & "', al_kelurahan = '" & tkelurahan.Text & "', al_kecamatan = '" & tkecamatan.Text & "'," & _
               " al_kabupaten = '" & tkabupaten.Text & "', no_telp = '" & tnohp.Text & "', wa = '" & twa.Text & "', email = '" & temail.Text & "'," & _
               " pekerjaan = '" & tpekerjaan.Text & "', alumni_s1 = '" & talumni.Text & "', prodi_s1 = '" & tgelar.Text & "'," & _
               " namaibu = '" & tnamaibu.Text & "', itgllahir = '" & tibuttl.Text & "', namaayah = '" & tnamaayah.Text & "'," & _
               " atgllahir = '" & tayahttl.Text & "', apenghasilan = '" & tayahhasil.Text & "', apekerjaan = '" & tayahkerja.Text & "'," & _
               " foto = @photo , catatan = '" & tb_catatan.Text & "' where nomor = '" & tno.Text & "'"

            Try

           
            Dim gambar() As Byte
            Dim img As New Bitmap(pb_foto.Image)
            Dim memStreamupdate As New MemoryStream
            img.Save(memStreamupdate, Imaging.ImageFormat.Jpeg)
            Dim imgArray = memStreamupdate.GetBuffer
            gambar = imgArray.ToArray
            Dim cmdupdate As New OleDbCommand(update, conn)
            cmdupdate.Parameters.Add(New OleDbParameter("@photo", gambar))
            Dim dtmhsbefore As DataTable
            dtmhsbefore = getsql("select nomor, nama from t_mhs where nomor = '" & tno.Text & "'")
            If System.IO.File.Exists("C:\Documents\KeuanganUnsur\Image\DataMahasiswa\" & dtmhsbefore.Rows(0)(0).ToString & "-" & dtmhsbefore.Rows(0)(1) & ".jpg") = False Then
                cmdupdate.ExecuteNonQuery()
            ElseIf System.IO.File.Exists("C:\Documents\KeuanganUnsur\Image\DataMahasiswa\" & dtmhsbefore.Rows(0)(0).ToString & "-" & dtmhsbefore.Rows(0)(1) & ".jpg") = True Then
                System.IO.File.Delete("C:\Documents\KeuanganUnsur\Image\DataMahasiswa\" & dtmhsbefore.Rows(0)(0).ToString & "-" & dtmhsbefore.Rows(0)(1) & ".jpg")
                cmdupdate.ExecuteNonQuery()
            End If
            Dim strBasePath As String
            Dim strFileName As String
            strFileName = "" & tno.Text & "-" & tnamalengkap.Text & ".jpg"
            strBasePath = "C:\Documents\KeuanganUnsur\Image\DataMahasiswa"
            ' >> Check if Folder Exists 
            If Directory.Exists(strBasePath) = False Then
                Call Directory.CreateDirectory(strBasePath)
            End If
            ' >> Save Picture 

            Call pb_foto.Image.Save(strBasePath & "\" & strFileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                MsgBox("Data Mahasiswa Berhasil Di Update", MsgBoxStyle.Information, "Perhatian")
                Me.Close()
                FData_Mahasiswa.Show()
                FData_Mahasiswa.datamhs()
                FData_Mahasiswa.mulaimhs()

            Catch ex As Exception
                MsgBox("Error Update Mahasiswa : " & vbNewLine & ex.Message)
            End Try
        End If
      
    End Sub

    Private Sub tnpm_TextChanged(sender As Object, e As EventArgs) Handles tnpm.TextChanged

    End Sub

    Private Sub tsemester_TextChanged(sender As Object, e As EventArgs) Handles tsemester.TextChanged

    End Sub

    Private Sub tangkatan_TextChanged(sender As Object, e As EventArgs) Handles tangkatan.TextChanged

    End Sub

    Private Sub ttempatlahir_TextChanged(sender As Object, e As EventArgs) Handles ttempatlahir.TextChanged

    End Sub
    Public Sub cariid()
       
        DataGridView1.DataSource = getsql("select * from t_mhs")

    End Sub
    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles bt_cari.Click
        panelcarimhs.Show()

    End Sub

    Private Sub bt_cancel_Click(sender As Object, e As EventArgs) Handles bt_cancel.Click
        If statusproses = "update" And statuspindah = "formdatamhs" Then
            Me.close()
            FData_Mahasiswa.Show()
        ElseIf statusproses = "ubah" And statuspindah = "stay" Then

            hapussemua()
            Dim getidmhs As String
            getidmhs = getidmahasiswa()
            tno.Text = getidmhs
            tnamalengkap.Focus()
            BunifuImageButton3.Visible = True
            BunifuImageButton4.Visible = False
            Dim image As Image = image.FromFile("question.png")
            pb_foto.Image = image
            bt_update.Visible = False
            Label3.Visible = False
            bt_cancel.Visible = False
            Label4.Visible = False
            bt_save.Visible = True
            Label2.Visible = True
            BunifuImageButton2.Visible = True
            Label1.Visible = True
            statusproses = "insert"
            statuspindah = "formdatamhs"

        End If
    End Sub

    Private Sub lastdata_Click(sender As Object, e As EventArgs) Handles lastdata.Click
        indexmhs = tablemhs.Rows.Count() - 1
        showData(indexmhs)
    End Sub

    Private Sub begindata_Click(sender As Object, e As EventArgs) Handles begindata.Click
        indexmhs = 0
        showData(indexmhs)
    End Sub

    Private Sub previousdata_Click(sender As Object, e As EventArgs) Handles previousdata.Click
        indexmhs -= 1
        If indexmhs < 0 Then
            indexmhs = 0
        End If
        showData(indexmhs)

    End Sub

    Private Sub BunifuImageButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click

        statusproses = "ubah"
        statuspindah = "stay"
        showData(indexmhs)
        bt_save.Visible = False
        Label2.Visible = False
        BunifuImageButton2.Visible = False
        Label1.Visible = False
        bt_update.Visible = True
        Label3.Visible = True
        bt_cancel.Visible = True
        Label4.Visible = True
        bt_update.Location = New System.Drawing.Point(621, 652)
        Label3.Location = New System.Drawing.Point(626, 720)
        bt_cancel.Location = New System.Drawing.Point(844, 652)
        Label4.Location = New System.Drawing.Point(849, 720)
        BunifuImageButton4.Visible = True
        BunifuImageButton4.Location = New System.Drawing.Point(130, 408)

        panelcarimhs.Hide()

    End Sub

   


  

    Private Sub btbatal_Click(sender As Object, e As EventArgs)
        Dim datagajadi As DataTable
        datagajadi = getsql("select * from t_mhs where nomor = '" & tno.Text & "'")
        If MsgBox("Apa anda yakin hapus '" & tno.Text & "'?", MsgBoxStyle.YesNo, "Peringatan") = Windows.Forms.DialogResult.Yes Then
            Try
                Using cmddatamhs As New OleDbCommand("delete from t_mhs where nomor='" & tno.Text & "'", conn)
                    cmddatamhs.ExecuteNonQuery()

                    If MsgBox("Data " & tno.Text & " telah dihapus", MsgBoxStyle.OkOnly, "Berhasil") = Windows.Forms.DialogResult.OK Then

                        panelcarimhs.Hide()
                        hapussemua()
                        Dim getidmhs As String
                        getidmhs = getidmahasiswa()
                        tno.Text = getidmhs
                        tnamalengkap.Focus()
                        statusproses = "input"
                        statuspindah = "formdatamhs"
                    End If

                End Using


            Catch ex As Exception
                MsgBox("Error Terjadi Saat Hapus Data Mahasiswa : " & vbNewLine & ex.Message)
            End Try
        Else
            Exit Sub
        End If

    End Sub



    Private Sub close_Click(sender As Object, e As EventArgs)
        Dim datagajadi As DataTable
        datagajadi = getsql("select * from t_mhs where nomor = '" & tno.Text & "'")
        If MsgBox("Apa anda yakin hapus '" & tno.Text & "'?", MsgBoxStyle.YesNo, "Peringatan") = Windows.Forms.DialogResult.Yes Then
            Try
                Using cmddatamhs As New OleDbCommand("delete from t_mhs where nomor='" & tno.Text & "'", conn)
                    cmddatamhs.ExecuteNonQuery()

                    If MsgBox("Data " & tno.Text & " telah dihapus", MsgBoxStyle.OkOnly, "Berhasil") = Windows.Forms.DialogResult.OK Then

                        Dim getidmhs As String
                        getidmhs = getidmahasiswa()
                        tno.Text = getidmhs
                        tnamalengkap.Focus()
                        statusproses = "input"
                        statuspindah = "formdatamhs"
                    End If

                End Using


            Catch ex As Exception
                MsgBox("Error Terjadi Saat Hapus Data Mahasiswa : " & vbNewLine & ex.Message)
            End Try
        Else
            Exit Sub
        End If

    End Sub

   

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BunifuImageButton4_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        hapussemua()
        Dim getidmhs As String
        getidmhs = getidmahasiswa()
        tno.Text = getidmhs
        tnamalengkap.Focus()
        BunifuImageButton3.Visible = True
        BunifuImageButton4.Visible = False
        Dim image As Image = image.FromFile("question.png")
        pb_foto.Image = image
        bt_update.Visible = False
        Label3.Visible = False
        bt_cancel.Visible = False
        Label4.Visible = False
        bt_save.Visible = True
        Label2.Visible = True
        BunifuImageButton2.Visible = True
        Label1.Visible = True
        statusproses = "insert"
        statuspindah = "formdatamhs"
        panelcarimhs.Hide()
    End Sub

    Private Sub tb_cari_TextChanged(sender As Object, e As EventArgs)

    End Sub

  
    Private Sub keluarcari_Click(sender As Object, e As EventArgs) Handles keluarcari.Click
        panelcarimhs.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        tno.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
        tnamalengkap.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
        tnpm.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
        tsemester.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
        tangkatan.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
        If DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(5).Value = "Pria" Then
            rdpria.Checked = True
        Else
            rdwanita.Checked = True
        End If
        ttempatlahir.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(6).Value
        dtptgllahir.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value
        tnik.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(8).Value
        cbagama.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(9).Value
        tjalan.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(10).Value
        tdusun.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(11).Value
        tkelurahan.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(12).Value
        tkecamatan.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(13).Value
        tkabupaten.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(14).Value
        tnohp.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(15).Value
        twa.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(16).Value
        temail.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(17).Value
        tpekerjaan.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(18).Value
        talumni.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(19).Value
        tgelar.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(20).Value
        tnamaibu.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(21).Value
        tibuttl.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(22).Value
        tnamaayah.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(23).Value
        tayahttl.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(24).Value
        tayahkerja.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(25).Value
        tayahhasil.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(26).Value
        pb_foto.Image = GetImageFromByteArray(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(27).Value)
        tb_catatan.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(28).Value
        panelcarimhs.Hide()

    End Sub
    Public Sub carimhs()
        DataGridView1.DataSource = getsql("select * from t_mhs where nomor like '%" & _
               tb_cari.Text & "%' or nama  like '%" & tb_cari.Text & _
               "%' or npm  like '%" & tb_cari.Text & _
               "%' or ktp  like '%" & tb_cari.Text & _
               "%' or  agama like '%" & tb_cari.Text & _
                "%' or  semester like '%" & tb_cari.Text & _
                 "%' or  tmp_lahir like '%" & tb_cari.Text & _
               "%'")
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        carimhs()
    End Sub

    Private Sub panelcarimhs_Paint(sender As Object, e As PaintEventArgs) Handles panelcarimhs.Paint
        cariid()
    End Sub

    Private Sub panellanjut_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class