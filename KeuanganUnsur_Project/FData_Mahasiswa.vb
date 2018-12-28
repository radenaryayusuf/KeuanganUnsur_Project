Imports System.Data.OleDb
Imports System.Windows.Forms.Control
Imports System.IO
Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FData_Mahasiswa
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public dtSourcemhs As DataTable
    Public PageCount As Integer
    Public maxRec As Integer
    Public pageSize As Integer
    Public currentPage As Integer
    Public recNo As Integer
    Private WithEvents dastatus As OleDbDataAdapter
    Private dsstatus As New DataSet
    Private WithEvents bnd As BindingSource
    Private cb As OleDbCommandBuilder
    Declare Function ShellExecuteA Lib "shell32.dll" ( _
             ByVal hWnd As IntPtr, _
             ByVal lpOperation As String, _
             ByVal lpFile As String, _
             ByVal lpParameters As String, _
             ByVal lpDirectory As String, _
             ByVal nShowCmd As Integer) As IntPtr
    Public nokelipatan As String
   

    Public Sub datamhssemestersub()
        'Open Connection.
        Dim conn As OleDbConnection = New OleDbConnection( _
    "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_keuanganunsur.accdb")

        'Set the DataAdapter's query.
        da = New OleDbDataAdapter("select nama,npm,semester,angkatan,jk,tmp_lahir,tgl_lahir,agama from t_mhs where semester like '" & cbsubkategori.Text & "'", conn)
        ds = New DataSet()

        ' Fill the DataSet.
        da.Fill(ds, "t_mhs")

        ' Set the source table.
        dtSourcemhs = ds.Tables("t_mhs")
        Me.ToolStripStatusLabel1.Text = CStr(dtSourcemhs.Rows.Count) & " Data Mahasiswa"
    End Sub
   
    Public Sub datamhscari()
        'Open Connection.
        Dim conn As OleDbConnection = New OleDbConnection( _
    "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_keuanganunsur.accdb")

        'Set the DataAdapter's query.
        da = New OleDbDataAdapter(" select nama,npm,semester,angkatan,jk,tmp_lahir,tgl_lahir,agama from t_mhs where nomor like '%" & _
               tbcari.Text & "%' or nama  like '%" & tbcari.Text & _
               "%' or npm  like '%" & tbcari.Text & _
               "%' or ktp  like '%" & tbcari.Text & _
               "%' or  agama like '%" & tbcari.Text & _
                "%' or  semester like '%" & tbcari.Text & _
                 "%' or  tmp_lahir like '%" & tbcari.Text & _
               "%'", conn)
        ds = New DataSet()

        ' Fill the DataSet.
        da.Fill(ds, "t_mhs")

        ' Set the source table.
        dtSourcemhs = ds.Tables("t_mhs")
        Me.ToolStripStatusLabel1.Text = CStr(dtSourcemhs.Rows.Count) & " Data Mahasiswa"
    End Sub
    Public Sub datamhsangkatansub()
        'Open Connection.
        Dim conn As OleDbConnection = New OleDbConnection( _
    "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_keuanganunsur.accdb")

        'Set the DataAdapter's query.
        da = New OleDbDataAdapter("select nama,npm,semester,angkatan,jk,tmp_lahir,tgl_lahir,agama from t_mhs where angkatan like '" & cbsubkategori.Text & "'", conn)
        ds = New DataSet()

        ' Fill the DataSet.
        da.Fill(ds, "t_mhs")

        ' Set the source table.
        dtSourcemhs = ds.Tables("t_mhs")
        Me.ToolStripStatusLabel1.Text = CStr(dtSourcemhs.Rows.Count) & " Data Mahasiswa"
    End Sub
 
    Public Sub datamhsagamasub()
        'Open Connection.
        Dim conn As OleDbConnection = New OleDbConnection( _
    "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_keuanganunsur.accdb")

        'Set the DataAdapter's query.
        da = New OleDbDataAdapter("select nama,npm,semester,angkatan,jk,tmp_lahir,tgl_lahir,agama from t_mhs where agama like '" & cbsubkategori.Text & "'", conn)
        ds = New DataSet()

        ' Fill the DataSet.
        da.Fill(ds, "t_mhs")

        ' Set the source table.
        dtSourcemhs = ds.Tables("t_mhs")
        Me.ToolStripStatusLabel1.Text = CStr(dtSourcemhs.Rows.Count) & " Data Mahasiswa"
    End Sub
    Public Sub datamhs()
        'Open Connection.   
        Dim conn As OleDbConnection = New OleDbConnection( _
    "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_keuanganunsur.accdb")

        'Set the DataAdapter's query.
        da = New OleDbDataAdapter("select nama,npm,semester,angkatan,jk,tmp_lahir,tgl_lahir,agama from t_mhs", conn)
        ds = New DataSet()

        ' Fill the DataSet.
        da.Fill(ds, "t_mhs")

        ' Set the source table.
        dtSourcemhs = ds.Tables("t_mhs")
        Me.ToolStripStatusLabel1.Text = CStr(dtSourcemhs.Rows.Count) & " Data Mahasiswa"
    End Sub
    Public Sub DisplayPageInfo()
        lblStatus.Text = "Page " & currentPage.ToString & "/ " & PageCount.ToString
    End Sub
    Public Sub mulaimhs()
        'Set the start and max records. 
        pageSize = 20
        maxRec = dtSourcemhs.Rows.Count
        PageCount = maxRec \ pageSize

        ' Adjust the page number if the last page contains a partial page.
        If (maxRec Mod pageSize) > 0 Then
            PageCount = PageCount + 1
        End If

        'Initial seeings
        currentPage = 1
        recNo = 0

        ' Display the content of the current page.
        LoadPagemhs()
    End Sub
    Public Sub LoadPagemhs()
        Dim i As Integer
        Dim startRec As Integer
        Dim endRec As Integer
        Dim dtTemp As DataTable
        Dim dr As DataRow
        Dim hitungrow As String
        Dim columnButton As New DataGridViewButtonColumn
        'Duplicate or clone the source table to create the temporary table.
        dtTemp = dtSourcemhs.Clone

        If currentPage = PageCount Then
            endRec = maxRec
        Else
            endRec = pageSize * currentPage
        End If

        startRec = recNo
        hitungrow = dtSourcemhs.Rows.Count
        'Copy the rows from the source table to fill the temporary table.
        If hitungrow <> 0 Then
            For i = startRec To endRec - 1
                dtTemp.ImportRow(dtSourcemhs.Rows(i))
                recNo = recNo + 1

            Next

            dgv.DataSource = dtTemp
            columnButton.Text = "Data Lengkap"
            columnButton.HeaderText = "Perintah"
            columnButton.UseColumnTextForButtonValue = True
            columnButton.FlatStyle = FlatStyle.Popup
            columnButton.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            columnButton.DefaultCellStyle.ForeColor = Color.Maroon
            columnButton.Width = 100
            With dgv
                .RowHeadersVisible = True
                .Columns(0).HeaderCell.Value = "Nama"
                .Columns(1).HeaderCell.Value = "NPM"
                .Columns(2).HeaderCell.Value = "Semester"
                .Columns(3).HeaderCell.Value = "Angkatan"
                .Columns(4).HeaderCell.Value = "Jenis Kelamin"
                .Columns(5).HeaderCell.Value = "Tempat Lahir"
                .Columns(6).HeaderCell.Value = "Tanggal Lahir"
                .Columns(7).HeaderCell.Value = "Agama"
                .Columns.Add(columnButton)
            End With
            '     For baris As Integer = 0 To dgv.Rows.Count - 1
            '          Dim row As DataGridViewRow = dgv.Rows(baris)
            '         row.Height = 105
            '    Next
            '   For barislagi As Integer = 2 To dgv.Rows.Count - 1
            'Dim column As DataGridViewColumn = dgv.Columns(barislagi)
            'column.Width = 150
            'Next

        Else
            MsgBox("Data Mahasiswa tidak ditemukan!", MsgBoxStyle.Information, "Data Mahasiswa")
            Dim banyaktemu As DataGridViewRow
            For ia As Integer = dgv.Rows.Count - 1 To 0 Step -1
                banyaktemu = dgv.Rows(ia)
                dgv.Rows.Remove(banyaktemu)
            Next

        End If
        DisplayPageInfo()

    End Sub
    Private Sub bt_exit_Click(sender As Object, e As EventArgs) Handles bt_exit.Click
        If statusinput = "inputmahasiswa" Then
            With Form_Utama
                Me.Close()
                .Show()
                .Label6.Text = totaldosen()
                .Label7.Text = totalpegawai()
                .Label10.Text = totalmahasiswa()
            End With
        Else
            Me.Close()
        End If
    End Sub
  
    Private Sub FData_Mahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
       
        datamhs()
        cbkategori.Items.Add("Semester")
        cbkategori.Items.Add("Angkatan")
        cbkategori.Items.Add("Agama")
        cbsubkategori.Enabled = False
        Dim image As Image = image.FromFile("students.png")
        pb_logo.Image = image

        mulaimhs()
        nokelipatan = 1
        Call AutoNumberRowsForGridView()
    End Sub

    Private Sub bt_tambahkan_Click(sender As Object, e As EventArgs) Handles bt_tambahkan.Click
        statuspindah = "formdatamhs"
        statusproses = "insert"
        With FInput_Mahasiswa
            .Show()
            .tno.Enabled = False
            .tnamalengkap.Focus()

        End With
        Me.Hide()
    End Sub
    Public Sub tampilfoto()
        str = "SELECT foto FROM t_mhs WHERE nomor = @1"

        Using cmd As New OleDb.OleDbCommand(str, conn)
            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@1", dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value) ' keadaan where

                Using dtr As OleDb.OleDbDataReader = .ExecuteReader()
                    If dtr.HasRows Then
                        If dtr.Read() Then
                            Dim ms As New IO.MemoryStream(CType(dtr.Item("foto"), Byte()))
                            FInput_Mahasiswa.pb_foto.Image = Image.FromStream(ms) ' tampilkan gambarnya
                        End If
                    Else

                    End If

                End Using
            End With
        End Using
    End Sub

    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click
        ' Dim d As String = dgv.Rows(dgv.CurrentRow.Index).Cells(7).Value
        'Dim dt = DateTime.ParseExact(d, "yyyyMMddhhmm", Nothing)
        If dgv.Rows.Count <> 0 Then
            With FInput_Mahasiswa
                statusproses = "update"
                statuspindah = "formdatamhs"
                .Show()
                .tno.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value
                .tnamalengkap.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(2).Value
                .tnpm.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(3).Value
                .tsemester.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(4).Value
                .tangkatan.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(5).Value
                If dgv.Rows(dgv.CurrentRow.Index).Cells(6).Value = "Pria" Then
                    .rdpria.Checked = True
                ElseIf dgv.Rows(dgv.CurrentRow.Index).Cells(6).Value = "Wanita" Then
                    .rdwanita.Checked = False
                End If

                .ttempatlahir.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(7).Value
                '.dtptgllahir.Value = dgv.Rows(dgv.CurrentRow.Index).Cells(7).Value
                .tnik.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(9).Value
                .cbagama.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(10).Value
                .tjalan.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(11).Value
                .tdusun.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(12).Value
                .tkelurahan.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(13).Value
                .tkecamatan.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(14).Value
                .tkabupaten.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(15).Value
                .tnohp.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(16).Value
                .twa.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(17).Value
                .temail.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(18).Value
                .tpekerjaan.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(19).Value
                .talumni.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(20).Value
                .tgelar.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(21).Value
                .tnamaibu.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(22).Value
                .tibuttl.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(23).Value
                .tnamaayah.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(24).Value
                .tayahttl.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(25).Value
                .tayahkerja.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(26).Value
                .tayahhasil.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(27).Value
                '.tjalan.Text = dgv.Rows(dgv.CurrentRow.Index).Cells(27).Value
                .dtptgllahir.Value = dgv.Rows(dgv.CurrentRow.Index).Cells(8).Value

                .tno.Enabled = False
                .tnamalengkap.Focus()
                Me.Hide()
            End With
        Else
            MsgBox("Data Tidak ditemukan" & vbNewLine & "Silahkan pilih salah satu data yang ingin di edit", MsgBoxStyle.Critical, "Edit Data Gagal")
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If dgv.Columns(e.ColumnIndex).HeaderText = "Perintah" Then
            MsgBox("Button : " & e.RowIndex & " Clicked !")
        End If
    End Sub



    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub bt_print_Click(sender As Object, e As EventArgs) Handles bt_print.Click

    End Sub


    Private Sub btbegin_Click(sender As Object, e As EventArgs) Handles btbegin.Click
        nokelipatan = "1"
        ' Check if you are already at the first page.
        If currentPage = 1 Then
            MsgBox("Anda berada di halaman pertama", MsgBoxStyle.Information, "Awal")
            Return
        End If

        currentPage = 1
        recNo = 0
        LoadPagemhs()
    End Sub

    Private Sub btprevious_Click(sender As Object, e As EventArgs) Handles btprevious.Click
        nokelipatan = nokelipatan - 5
        If currentPage = PageCount Then
            recNo = pageSize * (currentPage - 2)
        End If

        currentPage = currentPage - 1

        'Check if you are already at the first page.
        If currentPage < 1 Then
            MsgBox("Anda berada di halaman pertama", MsgBoxStyle.Information, "Awal")
            currentPage = 1
            nokelipatan = "1"
            Return
        Else
            recNo = pageSize * (currentPage - 1)
        End If
        LoadPagemhs()
    End Sub

    Private Sub btnext_Click(sender As Object, e As EventArgs) Handles btnext.Click
        nokelipatan = nokelipatan + 5
        currentPage = currentPage + 1

        If currentPage > PageCount Then
            currentPage = PageCount

            'Check if you are already at the last page.
            If recNo = maxRec Then
                MsgBox("Anda berada di halaman terakhir", MsgBoxStyle.Information, "Akhir")
                Dim jak As DataTable
                jak = getsql("select count(npm) from t_mhs")
                nokelipatan = jak.Rows(0)(0).ToString()

                Return
            End If
        End If

        LoadPagemhs()


    End Sub

    Private Sub btlast_Click(sender As Object, e As EventArgs) Handles btlast.Click
        Dim jak As DataTable
        jak = getsql("select count(npm) from t_mhs")
        nokelipatan = jak.Rows(0)(0).ToString()

        ' Check if you are already at the last page.
        If recNo = maxRec Then
            MsgBox("Anda berada di halaman terakhir", MsgBoxStyle.Information, "Akhir")
            Return
        End If

        currentPage = PageCount

        recNo = pageSize * (currentPage - 1)
        LoadPagemhs()
    End Sub
    Private Sub cbagama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkategori.SelectedIndexChanged
        If cbkategori.Text <> "" Then
            cbsubkategori.Enabled = True
        End If
        If cbkategori.Text = "Semester" Then
            cbsubkategori.Items.Clear()
            cbsubkategori.Items.Add("1")
            cbsubkategori.Items.Add("2")
            cbsubkategori.Items.Add("3")
            cbsubkategori.Items.Add("4")
            cbsubkategori.Items.Add("5")
        ElseIf cbkategori.Text = "Angkatan" Then
            cbsubkategori.Items.Clear()
            cbsubkategori.Items.Add("1")
            cbsubkategori.Items.Add("2")
            cbsubkategori.Items.Add("3")
            cbsubkategori.Items.Add("4")
            cbsubkategori.Items.Add("5")
        ElseIf cbkategori.Text = "Agama" Then
            cbsubkategori.Items.Clear()
            cbsubkategori.Items.Add("Islam")
            cbsubkategori.Items.Add("Kristen Protestan")
            cbsubkategori.Items.Add("Kristen Katolik")
            cbsubkategori.Items.Add("Hindu")
            cbsubkategori.Items.Add("Buddha")
            cbsubkategori.Items.Add("Konghucu")
        End If

    End Sub

    Private Sub cbsubkategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsubkategori.SelectedIndexChanged
        If cbkategori.Text = "Semester" And cbsubkategori.Text <> "" Then
            datamhssemestersub()
            mulaimhs()
        ElseIf cbkategori.Text = "Angkatan" And cbsubkategori.Text <> "" Then
            datamhsangkatansub()
            mulaimhs()
        ElseIf cbkategori.Text = "Agama" And cbsubkategori.Text <> "" Then
            datamhsagamasub()
            mulaimhs()
        End If

    End Sub

    Private Sub btkosong_Click(sender As Object, e As EventArgs) Handles btkosong.Click

        cbkategori.Text = ""
        cbsubkategori.Text = ""
        tbcari.Text = ""
        cbsubkategori.Enabled = False
        If cbkategori.Text = "" And cbsubkategori.Text = "" Then
            datamhs()
            mulaimhs()

        End If
    End Sub

    Private Sub btrefresh_Click(sender As Object, e As EventArgs) Handles btrefresh.Click
        datamhs()
        mulaimhs()
    End Sub


    Private Sub bt_hapus_Click(sender As Object, e As EventArgs) Handles bt_hapus.Click
        If dgv.Rows.Count <> 0 Then
            If MsgBox("Apa anda yakin hapus '" & dgv.CurrentRow.Cells(2).Value & "'?", MsgBoxStyle.YesNo, "Peringatan") = Windows.Forms.DialogResult.Yes Then
                Try
                    Using cmddatamhs As New OleDbCommand("delete from t_mhs where nomor='" & dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value & "'", conn)
                        With cmddatamhs

                        End With
                        cmddatamhs.ExecuteNonQuery()


                        If MsgBox("Data " & dgv.Rows(dgv.CurrentRow.Index).Cells(2).Value & " telah dihapus", MsgBoxStyle.OkOnly, "Berhasil") = Windows.Forms.DialogResult.OK Then
                            datamhs()
                            mulaimhs()
                        End If

                    End Using


                Catch ex As Exception
                    MsgBox("Error Terjadi Saat Hapus Data Mahasiswa : " & vbNewLine & ex.Message)
                End Try
            Else
                Exit Sub
            End If
        Else
            MsgBox("Data Tidak ditemukan" & vbNewLine & "Silahkan pilih salah satu data yang ingin dihapus", MsgBoxStyle.Critical, "Hapus Data Gagal")

        End If

    End Sub

    Private Sub tbcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbcari.KeyPress
        If e.KeyChar = Chr(13) Then
            datamhscari()
            mulaimhs()
          
        End If
       
    End Sub

    Private Sub tbcari_TextChanged(sender As Object, e As EventArgs) Handles tbcari.TextChanged
        If tbcari.Text = "" Then
            datamhs()
            mulaimhs()
        End If

    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click

        datamhscari()
        mulaimhs()
    End Sub
    Private Sub dgv_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv.CellFormatting
        Call AutoNumberRowsForGridView()
    End Sub
    Private Sub AutoNumberRowsForGridView() ' membuat no otomatis pada datagridview
        If dgv IsNot Nothing Then
            Dim count As Integer = 0
            While (count <= (dgv.Rows.Count - 1))
                dgv.Rows(count).HeaderCell.Value = String.Format((count + Val(nokelipatan)).ToString(), "0")
                count += 1
            End While

        End If
    End Sub

  
End Class