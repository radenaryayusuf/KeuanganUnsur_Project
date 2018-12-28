Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
    Public Class FNeraca
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public dtSourcemasuk As DataTable
    Public dtSourcekeluar As DataTable
    Public PageCountmasuk As Integer
    Public PageCountkeluar As Integer
    Public maxRecmasuk As Integer
    Public maxReckeluar As Integer
    Public pageSizemasuk As Integer
    Public pageSizekeluar As Integer
    Public currentPagemasuk As Integer
    Public currentPagekeluar As Integer
    Public currentdataawalkeluar As Integer
    Public currentdataakhirkeluar As Integer
    Public recNomasuk As Integer
    Public recNokeluar As Integer

    Public nokelipatan As String
   
    Public Sub datapemasukan()
        'Open Connection.
        Dim conn As OleDbConnection = New OleDbConnection( _
    "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_keuanganunsur.accdb")

        'Set the DataAdapter's query.
        da = New OleDbDataAdapter("select * from q_neracapendapatan", conn)
        ds = New DataSet()

        ' Fill the DataSet.
        da.Fill(ds, "q_neracapendapatan")

        ' Set the source table.
        dtSourcemasuk = ds.Tables("q_neracapendapatan")
    End Sub
    Public Sub datakeluaran()
        'Open Connection.
        Dim conn As OleDbConnection = New OleDbConnection( _
    "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_keuanganunsur.accdb")

        'Set the DataAdapter's query.
        da = New OleDbDataAdapter("select * from q_neracapengeluaran", conn)
        ds = New DataSet()

        ' Fill the DataSet.
        da.Fill(ds, "q_neracapengeluaran")

        ' Set the source table.
        dtSourcekeluar = ds.Tables("q_neracapengeluaran")
    End Sub
    Private Sub DisplayPageInfomasuk()
        lblStatus.Text = "Page " & currentPagemasuk.ToString & "/ " & PageCountmasuk.ToString
    End Sub
    Private Sub DisplayPageInfokeluar()
        lblStatus1.Text = "Page " & currentPagekeluar.ToString & "/ " & PageCountkeluar.ToString
    End Sub
    Private Sub Displaydatakeluar()
        Label2.Text = "Data Pengeluaran " & currentdataawalkeluar.ToString & " - " & currentdataakhirkeluar.ToString
    End Sub
    Private Sub LoadPagepemasukan()
        Dim i As Integer
        Dim startRec As Integer
        Dim endRec As Integer
        Dim dtTemp As DataTable
        Dim dr As DataRow

        'Duplicate or clone the source table to create the temporary table.
        dtTemp = dtSourcemasuk.Clone

        If currentPagemasuk = PageCountmasuk Then
            endRec = maxRecmasuk
        Else
            endRec = pageSizemasuk * currentPagemasuk
        End If

        startRec = recNomasuk

        'Copy the rows from the source table to fill the temporary table.
        For i = startRec To endRec - 1
            dtTemp.ImportRow(dtSourcemasuk.Rows(i))
            recNomasuk = recNomasuk + 1
        Next

        dgv1.DataSource = dtTemp
        DisplayPageInfomasuk()

    End Sub
    Private Sub loadnourut()
        Dim ik As Integer
        Dim startReck As Integer
        Dim endReck As Integer
        Dim dtTempk As DataTable
        Dim dr As DataRow

        For ik = startReck To endReck - 1
            dtTempk.ImportRow(dtSourcekeluar.Rows(ik))
            recNokeluar = recNokeluar + 1
        Next

    End Sub
    Private Sub LoadPagekeluaran()
        Dim ik As Integer
        Dim startReck As Integer
        Dim endReck As Integer
        Dim dtTempk As DataTable
        Dim dr As DataRow

        'Duplicate or clone the source table to create the temporary table.
        dtTempk = dtSourcekeluar.Clone

        If currentPagekeluar = PageCountkeluar Then
            endReck = maxReckeluar
        Else
            endReck = pageSizekeluar * currentPagekeluar
        End If

        startReck = recNokeluar

        'Copy the rows from the source table to fill the temporary table.
        For ik = startReck To endReck - 1
            dtTempk.ImportRow(dtSourcekeluar.Rows(ik))
            recNokeluar = recNokeluar + 1
        Next

        dgv2.DataSource = dtTempk
        DisplayPageInfokeluar()

    End Sub
    Public Sub mulaimasuk()
        'Set the start and max records. 
        pageSizemasuk = 13
        maxRecmasuk = dtSourcemasuk.Rows.Count
        PageCountmasuk = maxRecmasuk \ pageSizemasuk

        ' Adjust the page number if the last page contains a partial page.
        If (maxRecmasuk Mod pageSizemasuk) > 0 Then
            PageCountmasuk = PageCountmasuk + 1
        End If

        'Initial seeings
        currentPagemasuk = 1
        recNomasuk = 0

        ' Display the content of the current page.
        LoadPagepemasukan()

    End Sub
    Public Sub mulaikeluar()
        'Set the start and max records. 
        pageSizekeluar = 13
        maxReckeluar = dtSourcekeluar.Rows.Count
        PageCountkeluar = maxReckeluar \ pageSizekeluar

        ' Adjust the page number if the last page contains a partial page.
        If (maxReckeluar Mod pageSizekeluar) > 0 Then
            PageCountkeluar = PageCountkeluar + 1
        End If

        'Initial seeings
        currentPagekeluar = 1
        recNokeluar = 0

        ' Display the content of the current page.
        LoadPagekeluaran()

    End Sub
    Private Sub bt_tambahkan_Click(sender As Object, e As EventArgs) Handles bt_tambahkan.Click

    End Sub
        Public Sub datarefreshpendapatan()
            dgv1.DataSource = getsql("select * from q_neracapendapatan")
            With dgv1
            .RowHeadersVisible = True
                .Columns(0).HeaderCell.Value = "Kode"
                .Columns(1).HeaderCell.Value = "Akun"
                .Columns(2).HeaderCell.Value = "Nominal"
                .Columns(0).Width = 170
                .Columns(1).Width = 170
            .Columns(2).Width = 183
            .Columns(2).DefaultCellStyle.Format = "C"


            End With
        End Sub
        Public Sub datarefreshpengeluaran()
            dgv2.DataSource = getsql("select * from q_neracapengeluaran")
            With dgv2

            .RowHeadersVisible = True
                .Columns(0).HeaderCell.Value = "Kode"
                .Columns(1).HeaderCell.Value = "Akun"
                .Columns(2).HeaderCell.Value = "Nominal"
                .Columns(0).Width = 170
                .Columns(1).Width = 170
            .Columns(2).Width = 183
            .Columns(2).DefaultCellStyle.Format = "C"
            End With
        End Sub
        Function gettotalpendapatan()

            Dim hitungpendapatan As Integer = 0
            For I As Integer = 0 To dgv1.Rows.Count - 1
                hitungpendapatan = hitungpendapatan + Val(dgv1.Rows(I).Cells(2).Value)
            Next
            Return hitungpendapatan
        End Function
        Function gettotalpengeluaran()

            Dim hitungpengeluaran As Integer = 0
            For I As Integer = 0 To dgv2.Rows.Count - 1
                hitungpengeluaran = hitungpengeluaran + Val(dgv2.Rows(I).Cells(2).Value)
            Next
            Return hitungpengeluaran
        End Function
        Private Sub FNeraca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        datapemasukan()
        datakeluaran()
        tbsaldo.Enabled = False
        nokelipatan = 1

            datarefreshpendapatan()
            datarefreshpengeluaran()
            tbjumlahpendapatan.Enabled = False
            tbjumlahpengeluaran.Enabled = False
            tbjumlahpendapatan.Text = gettotalpendapatan()
            tbjumlahpengeluaran.Text = gettotalpengeluaran()
            tbsaldo.Text = gettotalpendapatan() - gettotalpengeluaran()
        mulaikeluar()
        mulaimasuk()
        Call AutoNumberRowsForGridView()

        
    End Sub

        Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

        End Sub

        Private Sub BunifuCustomTextbox1_TextChanged(sender As Object, e As EventArgs) Handles tbsaldo.TextChanged
            Dim f As Long
            If tbsaldo.Text = "" Or Not IsNumeric(tbsaldo.Text) Then
                Exit Sub
            End If
            f = tbsaldo.Text
            tbsaldo.Text = Format(f, "Rp, ##,##0")
            tbsaldo.SelectionStart = Len(tbsaldo.Text)
        End Sub

        Private Sub BunifuCustomLabel5_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel5.Click

        End Sub

        Private Sub BunifuCustomDataGrid2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv2.CellContentClick

        End Sub

        Private Sub bt_min_Click(sender As Object, e As EventArgs) Handles bt_min.Click
            Me.WindowState = FormWindowState.Minimized
        End Sub

        Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
            Me.Close()
        End Sub

        Private Sub tbjumlahpendapatan_TextChanged(sender As Object, e As EventArgs) Handles tbjumlahpendapatan.TextChanged
            Dim f As Long
            If tbjumlahpendapatan.Text = "" Or Not IsNumeric(tbjumlahpendapatan.Text) Then
                Exit Sub
            End If
            f = tbjumlahpendapatan.Text
            tbjumlahpendapatan.Text = Format(f, "Rp, ##,##0")
            tbjumlahpendapatan.SelectionStart = Len(tbjumlahpendapatan.Text)
        End Sub

        Private Sub tbjumlahpengeluaran_TextChanged(sender As Object, e As EventArgs) Handles tbjumlahpengeluaran.TextChanged
            Dim f As Long
            If tbjumlahpengeluaran.Text = "" Or Not IsNumeric(tbjumlahpengeluaran.Text) Then
                Exit Sub
            End If
            f = tbjumlahpengeluaran.Text
            tbjumlahpengeluaran.Text = Format(f, "Rp, ##,##0")
            tbjumlahpengeluaran.SelectionStart = Len(tbjumlahpengeluaran.Text)
        End Sub

        Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
            Me.Close()

        End Sub

        Private Sub BunifuImageButton8_Click(sender As Object, e As EventArgs) Handles BunifuImageButton8.Click
        nokelipatan = nokelipatan - 5
        If currentPagemasuk = PageCountmasuk Then
            recNomasuk = pageSizemasuk * (currentPagemasuk - 2)
        End If

        currentPagemasuk = currentPagemasuk - 1

        'Check if you are already at the first page.
        If currentPagemasuk < 1 Then
            MessageBox.Show("You are at the First Page!")
            currentPagemasuk = 1
            nokelipatan = "1"
            Return
        Else
            recNomasuk = pageSizemasuk * (currentPagemasuk - 1)
        End If
        LoadPagepemasukan()
        End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        ' Check if you are already at the first page.
        nokelipatan = "1"
        If currentPagemasuk = 1 Then
            MessageBox.Show("You are at the First Page!")
            Return
        End If

        currentPagemasuk = 1
        recNomasuk = 0
        LoadPagepemasukan()
    End Sub

    Private Sub BunifuImageButton10_Click(sender As Object, e As EventArgs) Handles BunifuImageButton10.Click
        nokelipatan = nokelipatan + 5
        currentPagemasuk = currentPagemasuk + 1

        If currentPagemasuk > PageCountmasuk Then
            currentPagemasuk = PageCountmasuk

            'Check if you are already at the last page.
            If recNomasuk = maxRecmasuk Then
                MessageBox.Show("You are at the Last Page!")
                Dim jak As DataTable
                jak = getsql("select count(kode_akun) from q_neracapengeluaran")
                nokelipatan = jak.Rows(0)(0).ToString()
                Return
            End If
        End If
        LoadPagepemasukan()
    End Sub

    Private Sub BunifuImageButton11_Click(sender As Object, e As EventArgs) Handles BunifuImageButton11.Click
        Dim jak As DataTable
        jak = getsql("select count(kode_akun) from q_neracapengeluaran")
        nokelipatan = jak.Rows(0)(0).ToString()
        ' Check if you are already at the last page.
        If recNomasuk = maxRecmasuk Then
            MessageBox.Show("You are at the Last Page!")
            Return
        End If

        currentPagemasuk = PageCountmasuk

        recNomasuk = pageSizemasuk * (currentPagemasuk - 1)
        LoadPagepemasukan()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        nokelipatan = "1"
        ' Check if you are already at the first page.
        If currentPagekeluar = 1 Then
            MsgBox("Anda berada di halaman pertama", MsgBoxStyle.Information, "Awal")
            Return
        End If

        currentPagekeluar = 1
        recNokeluar = 0
        LoadPagekeluaran()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        nokelipatan = nokelipatan - 5
        If currentPagekeluar = PageCountkeluar Then
            recNokeluar = pageSizekeluar * (currentPagekeluar - 2)
        End If

        currentPagekeluar = currentPagekeluar - 1

        'Check if you are already at the first page.
        If currentPagekeluar < 1 Then
            MsgBox("Anda berada di halaman pertama", MsgBoxStyle.Information, "Awal")
            currentPagekeluar = 1
            nokelipatan = "1"
            Return
        Else
            recNokeluar = pageSizekeluar * (currentPagekeluar - 1)
        End If
        LoadPagekeluaran()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        nokelipatan = nokelipatan + 5
        currentPagekeluar = currentPagekeluar + 1

        If currentPagekeluar > PageCountkeluar Then
            currentPagekeluar = PageCountkeluar

            'Check if you are already at the last page.
            If recNokeluar = maxReckeluar Then
                MsgBox("Anda berada di halaman terakhir", MsgBoxStyle.Information, "Akhir")
                Dim jak As DataTable
                jak = getsql("select count(kode_akun) from q_neracapengeluaran")
                nokelipatan = jak.Rows(0)(0).ToString()

                Return 
            End If
        End If
        LoadPagekeluaran()
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        Dim jak As DataTable
        jak = getsql("select count(kode_akun) from q_neracapengeluaran")
        nokelipatan = jak.Rows(0)(0).ToString()

        ' Check if you are already at the last page.
        If recNokeluar = maxReckeluar Then
            MsgBox("Anda berada di halaman terakhir", MsgBoxStyle.Information, "Akhir")
            Return
        End If

        currentPagekeluar = PageCountkeluar

        recNokeluar = pageSizekeluar * (currentPagekeluar - 1)
        LoadPagekeluaran()
    End Sub

    Private Sub bt_exit_Click(sender As Object, e As EventArgs) Handles bt_exit.Click
        Me.Close()
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub dgv1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv1.CellFormatting

        Call AutoNumberRowsForGridViewmasuk()
    End Sub
    Private Sub autonumbernext()
        Dim dtkeluar As New DataTable
        dtkeluar = getsql("select * from q_neracapengeluaran")
        Dim countdgv2 As Integer
        countdgv2 = dgv2.Rows.Count

        If dgv2 IsNot Nothing Then
            Dim count As Integer = 5
            While (count <= (dgv2.Rows.Count - 1))
                dgv2.Rows(count).HeaderCell.Value = String.Format((countdgv2 + 1).ToString(), "0")
                count += 1
            End While

        End If
    End Sub
    Private Sub AutoNumberRowsForGridView() ' membuat no otomatis pada datagridview
        If dgv2 IsNot Nothing Then
            Dim count As Integer = 0
            While (count <= (dgv2.Rows.Count - 1))
                dgv2.Rows(count).HeaderCell.Value = String.Format((count + Val(nokelipatan)).ToString(), "0")
                count += 1
            End While

        End If
    End Sub
    Private Sub AutoNumberRowsForGridViewmasuk() ' membuat no otomatis pada datagridview
        If dgv1 IsNot Nothing Then
            Dim count As Integer = 0
            While (count <= (dgv1.Rows.Count - 1))
                dgv1.Rows(count).HeaderCell.Value = String.Format((count + Val(nokelipatan)).ToString(), "0")
                count += 1
            End While

        End If
    End Sub

    Private Sub dgv2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv2.CellFormatting
        Call AutoNumberRowsForGridView()




    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BunifuCustomLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomLabel3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer2_Load(sender As Object, e As EventArgs)

    End Sub


    Private Sub lblStatus1_Click(sender As Object, e As EventArgs) Handles lblStatus1.Click

    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange

    End Sub
End Class