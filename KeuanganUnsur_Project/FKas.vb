Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class FKas
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public dtSourcemasuk As DataTable
    Public PageCount As Integer
    Public maxRec As Integer
    Public pageSize As Integer
    Public currentPage As Integer
    Public recNo As Integer
    Public Sub datapemasukan()
        'Open Connection.
        Dim conn As OleDbConnection = New OleDbConnection( _
    "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_keuanganunsur.accdb")

        'Set the DataAdapter's query.
        da = New OleDbDataAdapter("select * from q_kas", conn)
        ds = New DataSet()

        ' Fill the DataSet.
        da.Fill(ds, "q_kas")

        ' Set the source table.
        dtSourcemasuk = ds.Tables("q_kas")
    End Sub
    Private Sub DisplayPageInfo()
        lblStatus.Text = "Page " & currentPage.ToString & "/ " & PageCount.ToString
    End Sub
    Private Sub LoadPagekas()
        Dim i As Integer
        Dim startRec As Integer
        Dim endRec As Integer
        Dim dtTemp As DataTable
        Dim dr As DataRow

        'Duplicate or clone the source table to create the temporary table.
        dtTemp = dtSourcemasuk.Clone

        If currentPage = PageCount Then
            endRec = maxRec
        Else
            endRec = pageSize * currentPage
        End If

        startRec = recNo

        'Copy the rows from the source table to fill the temporary table.
        For i = startRec To endRec - 1
            dtTemp.ImportRow(dtSourcemasuk.Rows(i))
            recNo = recNo + 1
        Next

        dgv.DataSource = dtTemp
        DisplayPageInfo()

    End Sub
  
    Private Sub bt_tambahkan_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub datarefresh()
        dgv.DataSource = getsql("select * from q_kas")
        With dgv
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "No"
            .Columns(1).HeaderCell.Value = "Tanggal"
            .Columns(2).HeaderCell.Value = "Uraian"
            .Columns(3).HeaderCell.Value = "Kode Akun"
            .Columns(4).HeaderCell.Value = "Nama Akun"
            .Columns(5).HeaderCell.Value = "Penerimaan"
            .Columns(6).HeaderCell.Value = "Pengeluaran"
            .Columns(0).Width = 120
            .Columns(1).Width = 120
            .Columns(2).Width = 150
            .Columns(3).Width = 150
            .Columns(4).Width = 150
            .Columns(5).Width = 200
            .Columns(6).Width = 200
            .Columns(5).DefaultCellStyle.Format = "C"
            .Columns(6).DefaultCellStyle.Format = "C"


        End With
    End Sub
    Function getTotalsaldomasuk()

        Dim hitungsaldo As Integer = 0
        For I As Integer = 0 To dgv.Rows.Count - 1
            hitungsaldo = hitungsaldo + Val(dgv.Rows(I).Cells(5).Value)
        Next
        Return hitungsaldo
    End Function
    Function getTotalsaldokeluar()

        Dim hitungsaldo As Integer = 0
        For I As Integer = 0 To dgv.Rows.Count - 1
            hitungsaldo = hitungsaldo + Val(dgv.Rows(I).Cells(6).Value)
        Next
        Return hitungsaldo
    End Function
    Public Sub mulaikas()
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
        LoadPagekas()

    End Sub
    Private Sub FKas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        datapemasukan()
        koneksi()
        tbcari.Focus()
        BunifuGradientPanel1.Hide()
        Me.WindowState = FormWindowState.Maximized
        Call datarefresh()
        tbsaldo.Enabled = False

        tbsaldo.Text = getTotalsaldomasuk() - getTotalsaldokeluar()
        mulaikas()
        
    End Sub

    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Close()
    End Sub

    Private Sub bt_min_Click(sender As Object, e As EventArgs) Handles bt_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv.CellFormatting

    End Sub

    Private Sub tbsaldo_TextChanged(sender As Object, e As EventArgs) Handles tbsaldo.TextChanged
        Dim f As Long
        If tbsaldo.Text = "" Or Not IsNumeric(tbsaldo.Text) Then
            Exit Sub
        End If
        f = tbsaldo.Text
        tbsaldo.Text = Format(f, "Rp, ##,##0")
        tbsaldo.SelectionStart = Len(tbsaldo.Text)
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
        LoadPagekas()
    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        ' Check if you are already at the first page.
        If currentPage = 1 Then
            MessageBox.Show("You are at the First Page!")
            Return
        End If

        currentPage = 1
        recNo = 0
        LoadPagekas()

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
        LoadPagekas()
    End Sub

    Private Sub BunifuImageButton11_Click(sender As Object, e As EventArgs) Handles BunifuImageButton11.Click
        ' Check if you are already at the last page.
        If recNo = maxRec Then
            MessageBox.Show("You are at the Last Page!")
            Return
        End If

        currentPage = PageCount

        recNo = pageSize * (currentPage - 1)
        LoadPagekas()
    End Sub
    Public Sub carikas()
        dgv.DataSource = getsql("select * from q_kas where no like '%" & _
               tbcari.text & "%' or kode_akun  like '%" & tbcari.text & _
               "%' or nama_akun  like '%" & tbcari.text & _
               "%' or uraian  like '%" & tbcari.text & _
               "%' or  tgl like '%" & tbcari.text & _
                "%' or penerimaan like '%" & tbcari.text & _
                 "%' or pengeluaran like '%" & tbcari.text & _
                 "%' or no like '%" & tbcari.text & _
               "%'  ")
    End Sub


    Private Sub btbatal_Click(sender As Object, e As EventArgs) Handles btbatal.Click
        BunifuGradientPanel1.Hide()
    End Sub

    Private Sub bttutup_Click(sender As Object, e As EventArgs) Handles bttutup.Click
        BunifuGradientPanel1.Hide()
    End Sub

    Private Sub bt_tambahkan_Click_1(sender As Object, e As EventArgs) Handles bt_tambahkan.Click
        BunifuGradientPanel1.Show()
        BunifuGradientPanel1.Location = New System.Drawing.Point(563, 122)
        cb_kategori.Focus()
        cb_sub.Enabled = False
    End Sub

    Private Sub cb_kategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_kategori.SelectedIndexChanged
        If cb_kategori.Text = "Pengeluaran" Then
            cb_sub.Enabled = True
        Else
            cb_sub.Enabled = False
        End If
    End Sub

    Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click
        If cb_kategori.Text = "Pemasukan" Then
            FPenerimaan_bayar.Show()
          
        ElseIf cb_kategori.Text = "Pengeluaran" And cb_sub.Text = "Penggajian" Then
            FGaji.Show()
        ElseIf cb_kategori.Text = "Pengeluaran" And cb_sub.Text = "Pembayaran Dosen" Then
            FBayar_Dosen.Show()
        ElseIf cb_kategori.Text = "Pengeluaran" And cb_sub.Text = "Transaksi Pembelian" Then
            FPembelanjaan.Show()
            statuspindah = "Kas"
        End If
    End Sub

    Private Sub bt_exit_Click(sender As Object, e As EventArgs) Handles bt_exit.Click
        Me.Close()
    End Sub

    Private Sub btrefresh_Click(sender As Object, e As EventArgs) Handles btrefresh.Click
        datapemasukan()
        mulaikas()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbcari.KeyPress
        If e.KeyChar = Chr(13) Then
            carikas()
        End If
    End Sub

    Private Sub tbcari_KeyUp(sender As Object, e As KeyEventArgs) Handles tbcari.KeyUp
        carikas()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbcari.TextChanged

    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
        carikas()
    End Sub
End Class