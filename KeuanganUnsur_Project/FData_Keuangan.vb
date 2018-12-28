Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class FData_Keuangan
    Public status As String
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public dtSourcemasuk As DataTable
    Public dtSourcekeluargaji As DataTable
    Public dtSourcekeluardosen As DataTable
    Public dtSourcekeluarpembelian As DataTable
    Public dtSourceawal As DataTable
    Public PageCount As Integer
    Public maxRec As Integer
    Public pageSize As Integer
    Public currentPage As Integer
    Public recNo As Integer
    Public Sub dataawal()
        'Open Connection.
        Dim conn As OleDbConnection = New OleDbConnection( _
    "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_keuanganunsur.accdb")

        'Set the DataAdapter's query.
        da = New OleDbDataAdapter("select * from q_kas", conn)
        ds = New DataSet()

        ' Fill the DataSet.
        da.Fill(ds, "q_kas")

        ' Set the source table.
        dtSourceawal = ds.Tables("q_kas")
    End Sub
    Public Sub datapemasukan()
        'Open Connection.
        Dim conn As OleDbConnection = New OleDbConnection( _
    "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_keuanganunsur.accdb")

        'Set the DataAdapter's query.
        da = New OleDbDataAdapter("select * from q_masuk", conn)
        ds = New DataSet()

        ' Fill the DataSet.
        da.Fill(ds, "q_masuk")

        ' Set the source table.
        dtSourcemasuk = ds.Tables("q_masuk")
    End Sub
    Private Sub datakeluargaji()
        'Open Connection.
        Dim conn As OleDbConnection = New OleDbConnection( _
    "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_keuanganunsur.accdb")

        'Set the DataAdapter's query.
        da = New OleDbDataAdapter("select * from q_gajikeluar", conn)
        ds = New DataSet()

        ' Fill the DataSet.
        da.Fill(ds, "q_gajikeluar")

        ' Set the source table.
        dtSourcekeluargaji = ds.Tables("q_gajikeluar")
    End Sub
    Private Sub datakeluardosen()
        'Open Connection.
        Dim conn As OleDbConnection = New OleDbConnection( _
    "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_keuanganunsur.accdb")

        'Set the DataAdapter's query.
        da = New OleDbDataAdapter("select * from q_keluardosen", conn)
        ds = New DataSet()

        ' Fill the DataSet.
        da.Fill(ds, "q_keluardosen")

        ' Set the source table.
        dtSourcekeluardosen = ds.Tables("q_keluardosen")
    End Sub
    Private Sub datakeluarpembelian()
        'Open Connection.
        Dim conn As OleDbConnection = New OleDbConnection( _
    "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_keuanganunsur.accdb")

        'Set the DataAdapter's query.
        da = New OleDbDataAdapter("select * from q_pembeliankeluar", conn)
        ds = New DataSet()

        ' Fill the DataSet.
        da.Fill(ds, "q_pembeliankeluar")

        ' Set the source table.
        dtSourcekeluarpembelian = ds.Tables("q_pembeliankeluar")
    End Sub
    Private Sub LoadPagepemasukan()
        Dim i As Integer
        Dim startRec As Integer
        Dim endRec As Integer
        Dim dtTemp As DataTable
        Dim dr As DataRow
        Dim hitungrow As String

        'Duplicate or clone the source table to create the temporary table.
        dtTemp = dtSourcemasuk.Clone

        If currentPage = PageCount Then
            endRec = maxRec
        Else
            endRec = pageSize * currentPage
        End If

        startRec = recNo
        hitungrow = dtSourcemasuk.Rows.Count
        'Copy the rows from the source table to fill the temporary table.
        If hitungrow <> 0 Then
            For i = startRec To endRec - 1
                dtTemp.ImportRow(dtSourcemasuk.Rows(i))
                recNo = recNo + 1
            Next

            dgv.DataSource = dtTemp
        Else
            MsgBox("Data Keuangan Kosong!" & vbNewLine & "Untuk mengisi nya silahkan lakukan Transaksi pemasukan atau pengeluaran", MsgBoxStyle.Information, "Data Keuangan")
            Dim banyaktemu As DataGridViewRow
            For ia As Integer = dgv.Rows.Count - 1 To 0 Step -1
                banyaktemu = dgv.Rows(ia)
                dgv.Rows.Remove(banyaktemu)
            Next

        End If
        DisplayPageInfo()

    End Sub
    Private Sub LoadPagekeluargaji()
        Dim i As Integer
        Dim startRec As Integer
        Dim endRec As Integer
        Dim dtTemp As DataTable
        Dim dr As DataRow
        Dim hitungrow As String

        'Duplicate or clone the source table to create the temporary table.
        dtTemp = dtSourcekeluargaji.Clone

        If currentPage = PageCount Then
            endRec = maxRec
        Else
            endRec = pageSize * currentPage
        End If

        startRec = recNo
        hitungrow = dtSourcekeluargaji.Rows.Count
        'Copy the rows from the source table to fill the temporary table.
        If hitungrow <> 0 Then
            For i = startRec To endRec - 1
                dtTemp.ImportRow(dtSourcekeluargaji.Rows(i))
                recNo = recNo + 1
            Next

            dgv.DataSource = dtTemp
        Else
            MsgBox("Data Keuangan Kosong!" & vbNewLine & "Untuk mengisi nya silahkan lakukan Transaksi pemasukan atau pengeluaran", MsgBoxStyle.Information, "Data Keuangan")
            Dim banyaktemu As DataGridViewRow
            For ia As Integer = dgv.Rows.Count - 1 To 0 Step -1
                banyaktemu = dgv.Rows(ia)
                dgv.Rows.Remove(banyaktemu)
            Next

        End If
        DisplayPageInfo()

    End Sub
    Private Sub LoadPagekeluardosen()
        Dim i As Integer
        Dim startRec As Integer
        Dim endRec As Integer
        Dim dtTemp As DataTable
        Dim dr As DataRow
        Dim hitungrow As String

        'Duplicate or clone the source table to create the temporary table.
        dtTemp = dtSourcekeluardosen.Clone

        If currentPage = PageCount Then
            endRec = maxRec
        Else
            endRec = pageSize * currentPage
        End If

        startRec = recNo
        hitungrow = dtSourcekeluardosen.Rows.Count
        'Copy the rows from the source table to fill the temporary table.
        If hitungrow <> 0 Then
            For i = startRec To endRec - 1
                dtTemp.ImportRow(dtSourcekeluardosen.Rows(i))
                recNo = recNo + 1
            Next

            dgv.DataSource = dtTemp
        Else
            MsgBox("Data Keuangan Kosong!" & vbNewLine & "Untuk mengisi nya silahkan lakukan Transaksi pemasukan atau pengeluaran", MsgBoxStyle.Information, "Data Keuangan")
            Dim banyaktemu As DataGridViewRow
            For ia As Integer = dgv.Rows.Count - 1 To 0 Step -1
                banyaktemu = dgv.Rows(ia)
                dgv.Rows.Remove(banyaktemu)
            Next

        End If
        DisplayPageInfo()

    End Sub
    Private Sub LoadPagepembelian()
        Dim i As Integer
        Dim startRec As Integer
        Dim endRec As Integer
        Dim dtTemp As DataTable
        Dim dr As DataRow
        Dim hitungrow As String

        'Duplicate or clone the source table to create the temporary table.
        dtTemp = dtSourcekeluarpembelian.Clone

        If currentPage = PageCount Then
            endRec = maxRec
        Else
            endRec = pageSize * currentPage
        End If

        startRec = recNo
        hitungrow = dtSourcekeluarpembelian.Rows.Count
        'Copy the rows from the source table to fill the temporary table.
        If hitungrow <> 0 Then
            For i = startRec To endRec - 1
                dtTemp.ImportRow(dtSourcekeluarpembelian.Rows(i))
                recNo = recNo + 1
            Next

            dgv.DataSource = dtTemp
        Else
            MsgBox("Data Keuangan Kosong!" & vbNewLine & "Untuk mengisi nya silahkan lakukan Transaksi pemasukan atau pengeluaran", MsgBoxStyle.Information, "Data Keuangan")
            Dim banyaktemu As DataGridViewRow
            For ia As Integer = dgv.Rows.Count - 1 To 0 Step -1
                banyaktemu = dgv.Rows(ia)
                dgv.Rows.Remove(banyaktemu)
            Next

        End If
        DisplayPageInfo()

    End Sub
    Private Sub LoadPageawal()
        Dim i As Integer
        Dim startRec As Integer
        Dim endRec As Integer
        Dim dtTemp As DataTable
        Dim dr As DataRow
        Dim hitungrow As String

        'Duplicate or clone the source table to create the temporary table.
        dtTemp = dtSourceawal.Clone

        If currentPage = PageCount Then
            endRec = maxRec
        Else
            endRec = pageSize * currentPage
        End If

        startRec = recNo
        hitungrow = dtSourceawal.Rows.Count
        'Copy the rows from the source table to fill the temporary table.
        If hitungrow <> 0 Then
            For i = startRec To endRec - 1
                dtTemp.ImportRow(dtSourceawal.Rows(i))
                recNo = recNo + 1
            Next

            dgv.DataSource = dtTemp
        Else
            MsgBox("Data Keuangan Kosong!" & vbNewLine & "Untuk mengisi nya silahkan lakukan Transaksi pemasukan atau pengeluaran", MsgBoxStyle.Information, "Data Keuangan")
            Dim banyaktemu As DataGridViewRow
            For ia As Integer = dgv.Rows.Count - 1 To 0 Step -1
                banyaktemu = dgv.Rows(ia)
                dgv.Rows.Remove(banyaktemu)
            Next

        End If

        DisplayPageInfo()

    End Sub
    Public Sub cariawaltanggal()
        dgv.DataSource = getsql("select * from q_kas where tgl like '%" & _
       tanggal_pertama.Text & "%'")
    End Sub
    Public Sub cariawaltanggalbatasi()
        dgv.DataSource = getsql("select * from q_kas where tgl between '" & tanggal_pertama.Text & "' and '" & tanggal_kedua.Text & "'")
    End Sub

    Public Sub caripemasukantanggal()
        dgv.DataSource = getsql("select * from q_masuk where tgl like '%" & _
        tanggal_pertama.Text & "%'")
    End Sub
    Public Sub caripemasukantanggalbatasi()
        dgv.DataSource = getsql("select * from q_masuk where tgl between '" & tanggal_pertama.Text & "' and '" & tanggal_kedua.Text & "'")
    End Sub

    Public Sub caritanggalgaji()
        dgv.DataSource = getsql("select * from q_gajikeluar where tgl like '%" & _
        tanggal_pertama.Text & "%'")
    End Sub
    Public Sub caritanggalgajibatasi()
        dgv.DataSource = getsql("select * from q_gajikeluar where tgl between '" & tanggal_pertama.Text & "' and '" & tanggal_kedua.Text & "'")
    End Sub

    Public Sub caritanggaldosen()
        dgv.DataSource = getsql("select * from q_keluardosen where tgl like '%" & _
        tanggal_pertama.Text & "%'")
    End Sub
    Public Sub caritanggaldosenbatasi()
        dgv.DataSource = getsql("select * from q_keluardosen where tgl between '" & tanggal_pertama.Text & "' and '" & tanggal_kedua.Text & "'")
    End Sub

    Public Sub caritanggalpembelian()
        dgv.DataSource = getsql("select * from q_pembeliankeluar where tgl like '%" & _
        tanggal_pertama.Text & "%'")
    End Sub
    Public Sub caritanggalpembelianbatasi()
        dgv.DataSource = getsql("select * from q_pembeliankeluar where tgl between '" & tanggal_pertama.Text & "' and '" & tanggal_kedua.Text & "'")
    End Sub

    Public Sub cariawal()
        dgv.DataSource = getsql("select * from q_kas where no like '%" & _
        tcari.Text & "%' or kode_akun  like '%" & tcari.Text & _
        "%' or nama_akun  like '%" & tcari.Text & _
        "%' or penerimaan  like '%" & tcari.Text & _
        "%' or pengeluaran  like '%" & tcari.Text & _
        "%' ")
    End Sub
    Public Sub caripemasukan()
        dgv.DataSource = getsql("select * from q_masuk where nomor like '%" & _
        tcari.text & "%' or kode_akun  like '%" & tcari.text & _
        "%' or nama_akun  like '%" & tcari.text & _
        "%' or dibayar  like '%" & tcari.text & _
        "%' ")
    End Sub
    Public Sub caridosen()
        dgv.DataSource = getsql("select * from q_keluardosen where nomer like '%" & _
        tcari.text & "%' or kode_akun  like '%" & tcari.text & _
        "%' or nama_akun  like '%" & tcari.text & _
        "%' or jumlah  like '%" & tcari.text & _
        "%' ")
    End Sub
    Public Sub carigaji()
        dgv.DataSource = getsql("select * from q_gajikeluar where nomer like '%" & _
        tcari.text & "%' or kode_akun  like '%" & tcari.text & _
        "%' or nama_akun  like '%" & tcari.text & _
        "%' or jumlah  like '%" & tcari.text & _
        "%' ")
    End Sub
    Public Sub caripembelian()
        dgv.DataSource = getsql("select * from q_pembeliankeluar where nomer like '%" & _
        tcari.text & "%' or kode_akun  like '%" & tcari.text & _
        "%' or nama_akun  like '%" & tcari.text & _
        "%' or jumlah  like '%" & tcari.text & _
        "%' ")
    End Sub
    Public Sub datarefreshawal()
        With dgv
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Tanggal"
            .Columns(1).HeaderCell.Value = "No"
            .Columns(2).HeaderCell.Value = "Uraian"
            .Columns(3).HeaderCell.Value = "Kode Akun"
            .Columns(4).HeaderCell.Value = "Nama Akun"
            .Columns(5).HeaderCell.Value = "Penerimaan"
            .Columns(5).HeaderCell.Value = "Penerimaan"
        End With

    End Sub

    Public Sub datarefreshpemasukan()
        With dgv
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Tanggal"
            .Columns(1).HeaderCell.Value = "No"
            .Columns(2).HeaderCell.Value = "Uraian"
            .Columns(3).HeaderCell.Value = "Kode Akun"
            .Columns(4).HeaderCell.Value = "Nama Akun"
            .Columns(5).HeaderCell.Value = "Penerimaan"
        End With

    End Sub
    Public Sub datarefreshpengeluarangaji()
        With dgv
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Tanggal"
            .Columns(1).HeaderCell.Value = "No"
            .Columns(2).HeaderCell.Value = "Uraian"
            .Columns(3).HeaderCell.Value = "Kode Akun"
            .Columns(4).HeaderCell.Value = "Nama Akun"
            .Columns(5).HeaderCell.Value = "Pengeluaran"


        End With
    End Sub
    Public Sub datarefreshdosen()
        With dgv
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Tanggal"
            .Columns(1).HeaderCell.Value = "No"
            .Columns(2).HeaderCell.Value = "Uraian"
            .Columns(3).HeaderCell.Value = "Kode Akun"
            .Columns(4).HeaderCell.Value = "Nama Akun"
            .Columns(5).HeaderCell.Value = "Pengeluaran"

        End With
    End Sub
    Public Sub datarefreshpembelian()
        With dgv
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Tanggal"
            .Columns(1).HeaderCell.Value = "No"
            .Columns(2).HeaderCell.Value = "Uraian"
            .Columns(3).HeaderCell.Value = "Kode Akun"
            .Columns(4).HeaderCell.Value = "Nama Akun"
            .Columns(5).HeaderCell.Value = "Pengeluaran"

        End With
    End Sub
    Private Sub FData_Keuangan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dataawal()
        mulaiawal()
        datapemasukan()
        datakeluardosen()
        datakeluargaji()
        datakeluarpembelian()
        tanggal_pertama.Format = DateTimePickerFormat.Custom
        tanggal_pertama.CustomFormat = "yyyy-MM-dd"
        tanggal_kedua.Format = DateTimePickerFormat.Custom
        tanggal_kedua.CustomFormat = "yyyy-MM-dd"
        cbkategori.Items.Add("Pemasukan")
        cbkategori.Items.Add("Pengeluaran")
        cbkategori.Items.Add("Semua")
        cbsubkategori.Items.Add("Dosen")
        cbsubkategori.Items.Add("Penggajian")
        cbsubkategori.Items.Add("Pembelian")
        cbsubkategori.Enabled = False
        header.BringToFront()
        nav.SendToBack()
        BunifuCustomLabel3.Visible = False
        tanggal_kedua.Visible = False

        Me.WindowState = FormWindowState.Maximized
    End Sub
    Public Sub mulaimasuk()
        'Set the start and max records. 
        pageSize = 28
        maxRec = dtSourcemasuk.Rows.Count
        PageCount = maxRec \ pageSize

        ' Adjust the page number if the last page contains a partial page.
        If (maxRec Mod pageSize) > 0 Then
            PageCount = PageCount + 1
        End If

        'Initial seeings
        currentPage = 1
        recNo = 0

        ' Display the content of the current page.
        LoadPagepemasukan()
    End Sub
    Public Sub mulaikeluargaji()
        'Set the start and max records. 
        pageSize = 28
        maxRec = dtSourcekeluargaji.Rows.Count
        PageCount = maxRec \ pageSize

        ' Adjust the page number if the last page contains a partial page.
        If (maxRec Mod pageSize) > 0 Then
            PageCount = PageCount + 1
        End If

        'Initial seeings
        currentPage = 1
        recNo = 0

        ' Display the content of the current page.
        LoadPagekeluargaji()
    End Sub
    Public Sub mulaikeluardosen()
        'Set the start and max records. 
        pageSize = 28
        maxRec = dtSourcekeluardosen.Rows.Count
        PageCount = maxRec \ pageSize

        ' Adjust the page number if the last page contains a partial page.
        If (maxRec Mod pageSize) > 0 Then
            PageCount = PageCount + 1
        End If

        'Initial seeings
        currentPage = 1
        recNo = 0

        ' Display the content of the current page.
        LoadPagekeluardosen()
    End Sub
    Public Sub mulaikeluarpembelian()
        'Set the start and max records. 
        pageSize = 28
        maxRec = dtSourcekeluarpembelian.Rows.Count
        PageCount = maxRec \ pageSize

        ' Adjust the page number if the last page contains a partial page.
        If (maxRec Mod pageSize) > 0 Then
            PageCount = PageCount + 1
        End If

        'Initial seeings
        currentPage = 1
        recNo = 0

        ' Display the content of the current page.
        LoadPagepembelian()
    End Sub
    Public Sub mulaiawal()
        'Set the start and max records. 
        pageSize = 28
        maxRec = dtSourceawal.Rows.Count
        PageCount = maxRec \ pageSize

        ' Adjust the page number if the last page contains a partial page.
        If (maxRec Mod pageSize) > 0 Then
            PageCount = PageCount + 1
        End If

        'Initial seeings
        currentPage = 1
        recNo = 0

        ' Display the content of the current page.
        LoadPageawal()
    End Sub
    Private Sub cbkategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkategori.SelectedIndexChanged
        If cbkategori.Text = "Pemasukan" Then
            cbsubkategori.Enabled = False
            mulaimasuk()
            tcari.Focus()

        ElseIf cbkategori.Text = "Pengeluaran" Then
            cbsubkategori.Enabled = True

        ElseIf cbkategori.Text = "Semua" Then
            cbsubkategori.Text = ""
            mulaiawal()
        End If
    End Sub

    Private Sub tcari_KeyUp(sender As Object, e As KeyEventArgs)


    End Sub

    Private Sub tcari_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub cbsubkategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsubkategori.SelectedIndexChanged
        If cbsubkategori.Text = "Dosen" Then
            mulaikeluardosen()
            tcari.Focus()
        ElseIf cbsubkategori.Text = "Penggajian" Then
            mulaikeluargaji()
            tcari.Focus()
        ElseIf cbsubkategori.Text = "Pembelian" Then
            mulaikeluarpembelian()
            tcari.Focus()
      
        End If
    End Sub

    Private Sub tanggal_pertama_ValueChanged(sender As Object, e As EventArgs) Handles tanggal_pertama.ValueChanged
        
        If cbkategori.Text = "Pemasukan" Then
            caripemasukantanggal()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Dosen" Then
            caritanggaldosen()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Penggajian" Then
            caritanggalgaji()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Pembelian" Then
            caritanggalpembelian()
        ElseIf cbkategori.Text = "" Or cbkategori.Text = "Semua" Then
            cariawaltanggal()
        Else
            MsgBox("Data Tidak Valid!", MsgBoxStyle.Information)
        End If
        If status = "tidakadabatas" Then
            
            If cbkategori.Text = "Pemasukan" Then
                caripemasukantanggal()
            ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Dosen" Then
                caritanggaldosen()
            ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Penggajian" Then
                caritanggalgaji()
            ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Pembelian" Then
                caritanggalpembelian()
            ElseIf cbkategori.Text = "" Or cbkategori.Text = "Semua" Then
                cariawaltanggal()

            Else
                MsgBox("Data Tidak Valid!", MsgBoxStyle.Information)
            End If
        ElseIf status = "batasi" Then

            If cbkategori.Text = "Pemasukan" Then
                caripemasukantanggalbatasi()
            ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Dosen" Then
                caritanggaldosenbatasi()
            ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Penggajian" Then
                caritanggalgajibatasi()
            ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Pembelian" Then
                caritanggalpembelianbatasi()
            ElseIf cbkategori.Text = "" Or cbkategori.Text = "Semua" Then
                cariawaltanggalbatasi()

            Else
                MsgBox("Data Tidak Valid!", MsgBoxStyle.Information)
            End If
            End If

    End Sub

    Private Sub tanggal_kedua_ValueChanged(sender As Object, e As EventArgs) Handles tanggal_kedua.ValueChanged
       If cbkategori.Text = "Pemasukan" Then
            caripemasukantanggalbatasi()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Dosen" Then
            caritanggaldosenbatasi()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Penggajian" Then
            caritanggalgajibatasi()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Pembelian" Then
            caritanggalpembelianbatasi()
        ElseIf cbkategori.Text = "" Or cbkategori.Text = "Semua" Then
            cariawaltanggalbatasi()

        Else
            MsgBox("Data Tidak Valid!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)
        If cbkategori.Text = "" Then
            MsgBox("Kategori Belum Dipilih!", MsgBoxStyle.Information)
            tcari.text = ""
            cbkategori.Focus()
        ElseIf cbkategori.Text = "Pemasukan" Then
            caripemasukan()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Dosen" Then
            caridosen()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Penggajian" Then
            carigaji()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Pembelian" Then
            caripembelian()
        Else
            MsgBox("Kategori Tidak Valid!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub bt_exit_Click(sender As Object, e As EventArgs) Handles bt_exit.Click
        Me.Close()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles header.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles nav.Paint

    End Sub


    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles bt_min.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub


    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Close()
    End Sub

    Private Sub tcari_KeyPress1(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub tcari_TextChanged_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub tcari_KeyDown(sender As Object, e As KeyEventArgs) Handles tcari.KeyDown

    End Sub

    Private Sub BunifuTextbox1_KeyPress(sender As Object, e As EventArgs)
        If cbkategori.Text = "Pemasukan" And tcari.text = "" Then
            datarefreshpemasukan()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Dosen" And tcari.text = "" Then
            datarefreshdosen()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Penggajian" And tcari.text = "" Then
            datarefreshpengeluarangaji()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Pembelian" And tcari.text = "" Then
            datarefreshpembelian()
        Else
        End If
    End Sub
    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub tcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcari.KeyPress
        If e.KeyChar = Chr(13) Then
            If cbkategori.Text = "Pemasukan" Then
                caripemasukan()
            ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Dosen" Then
                caridosen()
            ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Penggajian" Then
                carigaji()
            ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Pembelian" Then
                caripembelian()
            ElseIf cbkategori.Text = "" Or cbkategori.Text = "Semua" Then
                cariawal()
            Else
                MsgBox("Data Tidak Valid!", MsgBoxStyle.Information)
            End If
        End If
    End Sub


    Private Sub tcari_KeyUp1(sender As Object, e As EventArgs)
      End Sub


    Private Sub tcari_OnTextChange(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgv_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
    Private Sub DisplayPageInfo()
        lblStatus.Text = "Page " & currentPage.ToString & "/ " & PageCount.ToString
    End Sub

    Private Sub BunifuImageButton10_Click(sender As Object, e As EventArgs) Handles BunifuImageButton10.Click
        currentPage = currentPage + 1

        If currentPage > PageCount Then
            currentPage = PageCount

            'Check if you are already at the last page.
            If recNo = maxRec Then
                MessageBox.Show("You are at the Last Page!")
                Return
            End If
        End If
        If cbkategori.Text = "Pemasukan" Then
            LoadPagepemasukan()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Dosen" And tcari.text = "" Then
            LoadPagekeluardosen()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Penggajian" And tcari.text = "" Then
            LoadPagekeluargaji()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Pembelian" And tcari.text = "" Then
            LoadPagepembelian()
        ElseIf cbkategori.Text = "" Or cbkategori.Text = "Semua" Then
            LoadPageawal()
        End If
    End Sub

    Private Sub BunifuImageButton8_Click(sender As Object, e As EventArgs) Handles BunifuImageButton8.Click
        If currentPage = PageCount Then
            recNo = pageSize * (currentPage - 2)
        End If

        currentPage = currentPage - 1

        'Check if you are already at the first page.
        If currentPage < 1 Then
            MessageBox.Show("You are at the First Page!")
            currentPage = 1
            Return
        Else
            recNo = pageSize * (currentPage - 1)
        End If

        If cbkategori.Text = "Pemasukan" Then
            LoadPagepemasukan()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Dosen" And tcari.text = "" Then
            LoadPagekeluardosen()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Penggajian" And tcari.text = "" Then
            LoadPagekeluargaji()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Pembelian" And tcari.text = "" Then
            LoadPagepembelian()
        ElseIf cbkategori.Text = "" Or cbkategori.Text = "Semua" Then
            LoadPageawal()
        End If
    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click

        ' Check if you are already at the first page.
        If currentPage = 1 Then
            MessageBox.Show("You are at the First Page!")
            Return
        End If

        currentPage = 1
        recNo = 0

        If cbkategori.Text = "Pemasukan" Then
            LoadPagepemasukan()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Dosen" And tcari.text = "" Then
            LoadPagekeluardosen()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Penggajian" And tcari.text = "" Then
            LoadPagekeluargaji()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Pembelian" And tcari.text = "" Then
            LoadPagepembelian()
        ElseIf cbkategori.Text = "" Or cbkategori.Text = "Semua" Then
            LoadPageawal()

        End If
    End Sub

    Private Sub BunifuImageButton11_Click(sender As Object, e As EventArgs) Handles BunifuImageButton11.Click
        ' Check if you are already at the last page.
        If recNo = maxRec Then
            MessageBox.Show("You are at the Last Page!")
            Return
        End If

        currentPage = PageCount

        recNo = pageSize * (currentPage - 1)

        If cbkategori.Text = "Pemasukan" Then
            LoadPagepemasukan()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Dosen" And tcari.text = "" Then
            LoadPagekeluardosen()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Penggajian" And tcari.text = "" Then
            LoadPagekeluargaji()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Pembelian" And tcari.text = "" Then
            LoadPagepembelian()
        ElseIf cbkategori.Text = "" Or cbkategori.Text = "Semua" Then
            LoadPageawal()
        End If
    End Sub

    Private Sub BunifuCustomLabel3_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel3.Click

    End Sub

    Private Sub BunifuCustomLabel12_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel12.Click

    End Sub

    Private Sub BunifuCheckbox2_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox2.OnChange
        If BunifuCheckbox2.Checked = True Then
            status = "batasi"
            BunifuCustomLabel3.Visible = True
            tanggal_kedua.Visible = True
        ElseIf BunifuCheckbox2.Checked = False Then
            status = "tidakadabatas"
            BunifuCustomLabel3.Visible = False
            tanggal_kedua.Visible = False
        End If
    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click

    End Sub

    Private Sub btmulaiawal_Click(sender As Object, e As EventArgs) Handles btmulaiawal.Click
        dataawal()
        mulaiawal()
        BunifuCheckbox2.Checked = False
        tcari.Focus()
        BunifuCustomLabel3.Visible = False
        tanggal_kedua.Visible = False
    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
        If cbkategori.Text = "Pemasukan" Then
            caripemasukan()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Dosen" Then
            caridosen()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Penggajian" Then
            carigaji()
        ElseIf cbkategori.Text = "Pengeluaran" And cbsubkategori.Text = "Pembelian" Then
            caripembelian()
        ElseIf cbkategori.Text = "" Or cbkategori.Text = "Semua" Then
            cariawal()
        Else
            MsgBox("Data Tidak Valid!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub tcari_KeyUp2(sender As Object, e As KeyEventArgs) Handles tcari.KeyUp


    End Sub

    Private Sub tbcari_TextChanged(sender As Object, e As EventArgs) Handles tcari.TextChanged

    End Sub

    Private Sub bt_tambahkan_Click(sender As Object, e As EventArgs) Handles bt_tambahkan.Click

    End Sub

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click

    End Sub

    Private Sub bt_cancel_Click(sender As Object, e As EventArgs) Handles bt_cancel.Click

    End Sub

    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click

    End Sub
End Class