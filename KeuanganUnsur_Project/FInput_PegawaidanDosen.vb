Imports System.Windows.Forms.Control
Imports System.IO
Imports System.Data.OleDb
Public Class FInput_PegawaidanDosen
    Public jeniskelamin As String
    Dim connection_string As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_keuanganunsur.accdb;Persist Security Info=False;"
    Private Sub bt_exit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    
    Public Sub readonlysemua(Optional ByVal ctlcol As Control.ControlCollection = Nothing)
        Dim i As Integer
        Dim TBs As ControlCollection
        Dim TB As TextBox
        TBs = Me.Controls
        For i = 0 To TBs.Count - 1
            If TypeOf TBs.Item(i) Is TextBox Then
                TB = TBs.Item(i)
                TB.ReadOnly = True
            End If
        Next
    End Sub
    Private Sub BunifuImageButton14_Click(sender As Object, e As EventArgs) Handles BunifuImageButton14.Click

        Using iKon = New OleDbConnection(connection_string)
            If iKon.State = ConnectionState.Open Then iKon.Close()
            iKon.Open()
            Dim transaction = iKon.BeginTransaction
            Try
                Using iCmd = New OleDbCommand("insert into t_dosen values (@a0, @a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9, @a10, @a11, @a12, @a13, @a14, @a15, @a16, @a17, @a18, @a19, @a20, @a21, @a22, @a23, @a24,@a25)", iKon)
                    With iCmd
                        .Transaction = transaction
                        .Parameters.Add(New OleDbParameter("@a0", tno.Text))
                        .Parameters.Add(New OleDbParameter("@a1", tnamalengkap.Text))
                        .Parameters.Add(New OleDbParameter("@a2", tnik.Text))
                        .Parameters.Add(New OleDbParameter("@a3", jeniskelamin))
                        .Parameters.Add(New OleDbParameter("@a4", ttempatlahir.Text))
                        .Parameters.Add(New OleDbParameter("@a5", dtptgllahir.Text))
                        .Parameters.Add(New OleDbParameter("@a6", tktp.Text))
                        .Parameters.Add(New OleDbParameter("@a7", cbagama.Text))
                        .Parameters.Add(New OleDbParameter("@a8", mk1.Text))
                        .Parameters.Add(New OleDbParameter("@a9", sks1.Text))
                        .Parameters.Add(New OleDbParameter("@a10", mk2.Text))
                        .Parameters.Add(New OleDbParameter("@a11", sks2.Text))
                        .Parameters.Add(New OleDbParameter("@a12", mk3.Text))
                        .Parameters.Add(New OleDbParameter("@a13", sks3.Text))
                        .Parameters.Add(New OleDbParameter("@a14", mk4.Text))
                        .Parameters.Add(New OleDbParameter("@a15", sks4.Text))
                        .Parameters.Add(New OleDbParameter("@a16", jabatan.Text))
                        .Parameters.Add(New OleDbParameter("@a17", pangkat.Text))
                        .Parameters.Add(New OleDbParameter("@a18", homebase.Text))
                        .Parameters.Add(New OleDbParameter("@a19", notelp.Text))
                        .Parameters.Add(New OleDbParameter("@a20", wa.Text))
                        .Parameters.Add(New OleDbParameter("@a21", email.Text))
                        .Parameters.Add(New OleDbParameter("@a22", alamat.Text))
                        .Parameters.Add(New OleDbParameter("@a23", nosks.Text))
                        .Parameters.Add(New OleDbParameter("@a24", catatan.Text))
                    End With
                    Dim gambar() As Byte
                    Dim img As New Bitmap(pb_foto.Image)
                    Using memStream As System.IO.MemoryStream = New System.IO.MemoryStream
                        img.Save(memStream, Imaging.ImageFormat.Jpeg)
                        Dim imgArray = memStream.GetBuffer
                        gambar = imgArray
                    End Using
                    iCmd.Parameters.Add(New OleDbParameter("@a25", gambar))
                    iCmd.ExecuteNonQuery()
                End Using
                transaction.Commit()
                hapussemua()
                Dim getiddos As String = getiddosen()
                tno.Text = getiddos
                tnamalengkap.Focus()
                MsgBox("Data Dosen Berhasil Di Input")
            Catch ex As Exception
                transaction.Rollback()
                MsgBox("Error Input Dosen : " & vbNewLine & ex.Message)
            End Try
        End Using
        tno.Text = getiddosen()
        tpno.Text = getidpegawai()
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click

        If statusinput = "inputpegawaidandosen" Then
            With Form_Utama
                Me.Close()
                .Show()
                .Label6.Text = totaldosen()
                .Label7.Text = totalpegawai()
                .Label10.Text = totalmahasiswa()
            End With
        End If
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click

        If statusinput = "inputpegawaidandosen" Then
            With Form_Utama
                Me.Close()
                .show()
                .Label6.Text = totaldosen()
                .Label7.Text = totalpegawai()
                .Label10.Text = totalmahasiswa()
            End With
        End If
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

    Private Sub rdpria_CheckedChanged(sender As Object, e As EventArgs) Handles rdpria.CheckedChanged
        If rdpria.Checked = True Then
            jeniskelamin = "Pria"
        End If
    End Sub

    Private Sub rdwanita_CheckedChanged(sender As Object, e As EventArgs) Handles rdwanita.CheckedChanged
        If rdwanita.Checked = True Then
            jeniskelamin = "Wanita"
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
    Private Sub FInput_PegawaidanDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        tno.Text = getiddosen()
        tpno.Text = getidpegawai()

        cbagama.Items.Add("Islam")
        cbagama.Items.Add("Kristen Protestan")
        cbagama.Items.Add("Kristen Katolik")
        cbagama.Items.Add("Hindu")
        cbagama.Items.Add("Buddha")
        cbagama.Items.Add("Konghucu")
    End Sub

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        Using iKon = New OleDbConnection(connection_string)
            If iKon.State = ConnectionState.Open Then iKon.Close()
            iKon.Open()
            Dim transaction = iKon.BeginTransaction
            Try
                Using iCmd = New OleDbCommand("insert into t_pegawai values (@a0, @a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9, @a10, @a11, @a12, @a13, @a14, @a15,@a16)", iKon)
                    With iCmd
                        .Transaction = transaction
                        .Parameters.Add(New OleDbParameter("@a0", tpno.Text))
                        .Parameters.Add(New OleDbParameter("@a1", tpnamalengkap.Text))
                        .Parameters.Add(New OleDbParameter("@a2", tpnik.Text))
                        .Parameters.Add(New OleDbParameter("@a3", jeniskelamin))
                        .Parameters.Add(New OleDbParameter("@a4", tptempat.Text))
                        .Parameters.Add(New OleDbParameter("@a5", tptanggal.Text))
                        .Parameters.Add(New OleDbParameter("@a6", tpktp.Text))
                        .Parameters.Add(New OleDbParameter("@a7", tpagama.Text))
                        .Parameters.Add(New OleDbParameter("@a8", tpjabatan.Text))
                        .Parameters.Add(New OleDbParameter("@a9", tppendidikan.Text))
                        .Parameters.Add(New OleDbParameter("@a10", tpnotelp.Text))
                        .Parameters.Add(New OleDbParameter("@a11", tpwa.Text))
                        .Parameters.Add(New OleDbParameter("@a12", tpemail.Text))
                        .Parameters.Add(New OleDbParameter("@a13", tpalamat.Text))
                        .Parameters.Add(New OleDbParameter("@a14", tpskp.Text))
                        .Parameters.Add(New OleDbParameter("@a15", tpcatatan.Text))
                    End With
                    Dim gambar() As Byte
                    Dim img As New Bitmap(pb_foto.Image)
                    Using memStream As System.IO.MemoryStream = New System.IO.MemoryStream
                        img.Save(memStream, Imaging.ImageFormat.Jpeg)
                        Dim imgArray = memStream.GetBuffer
                        gambar = imgArray
                    End Using
                    iCmd.Parameters.Add(New OleDbParameter("@a16", gambar))
                    iCmd.ExecuteNonQuery()
                End Using
                transaction.Commit()
                hapussemua()
                Dim getidpeg As String = getidpegawai()
                tpno.Text = getidpeg
                tnamalengkap.Focus()
                MsgBox("Data Pegawai Berhasil Di Input")
                
            Catch ex As Exception
                transaction.Rollback()
                MsgBox("Error Input Pegawai : " & vbNewLine & ex.Message)
            End Try
        End Using
        tno.Text = getiddosen()
        tpno.Text = getidpegawai()
    End Sub

    Private Sub tppria_CheckedChanged(sender As Object, e As EventArgs) Handles tppria.CheckedChanged
        If tppria.Checked = True Then
            jeniskelamin = "Pria"
        End If
    End Sub

    Private Sub tpwanita_CheckedChanged(sender As Object, e As EventArgs) Handles tpwanita.CheckedChanged
        If tpwanita.Checked = True Then
            jeniskelamin = "Wanita"
        End If
    End Sub
   


    Private Sub tpnamalengkap_TextChanged(sender As Object, e As EventArgs) Handles tpnamalengkap.TextChanged
        tpno.Text = getidpegawai()
    End Sub

    Private Sub tnamalengkap_TextChanged(sender As Object, e As EventArgs) Handles tnamalengkap.TextChanged
        tno.Text = getiddosen()
    End Sub

    Private Sub btrefresh_Click(sender As Object, e As EventArgs) Handles btrefresh.Click

    End Sub
End Class