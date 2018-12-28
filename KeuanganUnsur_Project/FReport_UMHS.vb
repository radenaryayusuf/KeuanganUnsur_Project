Imports System.IO
Public Class FReport_UMHS
    Public a As String
    Declare Function ShellExecuteA Lib "shell32.dll" ( _
             ByVal hWnd As IntPtr, _
             ByVal lpOperation As String, _
             ByVal lpFile As String, _
             ByVal lpParameters As String, _
             ByVal lpDirectory As String, _
             ByVal nShowCmd As Integer) As IntPtr
    Private Sub FReport_UMHS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        tb_jumlah.Enabled = False
        tb_banyaknya.Enabled = False
    End Sub

    Private Sub cb_nama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_nama.SelectedIndexChanged
        If DateTimePicker1.Text <> "" And cb_nama.Text <> "" Then
            dgv.DataSource = getsql("select * from  q_umhs where tgl = '" & DateTimePicker1.Text & "' and nama = '" & cb_nama.Text & "'")
            Dim jumlahuang As Double
            jumlahuang = 0
            For t As Integer = 0 To dgv.Rows.Count - 1
                jumlahuang = Val(dgv.Rows(t).Cells(10).Value)
            Next
            tb_jumlah.Text = jumlahuang
        End If
        If tb_jumlah.Text <> "" Then
            tb_banyaknya.Text = TERBILANG(Val(tb_jumlah.Text))
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        dgv.DataSource = getsql("select * from q_umhs where tgl = '" & DateTimePicker1.Text & "'")
        cb_nama.Text = ""
        cb_nama.Items.Clear()

        For x As Integer = 0 To dgv.Rows.Count - 1
            cb_nama.Items.Add(dgv.Rows(x).Cells(5).Value)

        Next
    End Sub

    Private Sub bt_keluar_Click(sender As Object, e As EventArgs) Handles bt_keluar.Click
        Me.Close()
    End Sub
    Private Sub CetakKondisi()
        Dim i As Integer
        Dim rpt As String
        Dim cPart, tContent As String
        Dim sekarang As String = "_TGL_" & Format(Now, "dd-MM-yy_mmss")
        Dim total As Integer = 0
        Dim totalsisa As Integer = 0
        Dim nominal As Integer = 0
        dt = New DataTable
        dt = getsql("select * from q_umhs where nama = '" & cb_nama.Text & "'")
        rpt = File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) & "\kwitansiumhs.mht")
        tContent = ""

        For i = 0 To (dt.Rows.Count - 1)
            cPart = File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) & "\kwitansiumhs_content.mht")
            For o = 0 To (dgv.Rows.Count - 1)
                cPart = Replace(cPart, "[no]", dt.Rows(i)(o).ToString)
            Next
            cPart = Replace(cPart, "[tanggal]", dt.Rows(i)(1).ToString)
            cPart = Replace(cPart, "[kode]", dt.Rows(i)(6).ToString)
            cPart = Replace(cPart, "[akun]", dt.Rows(i)(7).ToString)
            cPart = Replace(cPart, "[uraian]", dt.Rows(i)(8).ToString)
            cPart = Replace(cPart, "[kewajiban]", dt.Rows(i)(9).ToString)
            cPart = Replace(cPart, "[bayar]", dt.Rows(i)(10).ToString)
            cPart = Replace(cPart, "[sisa]", dt.Rows(i)(11).ToString)
            cPart = Replace(cPart, "[ket]", dt.Rows(i)(12).ToString)
            'total = total + Val(dt.Rows(i)("jumlah").ToString)
            total = total + Val(dt.Rows(i)(10).ToString)
            totalsisa = dt.Rows(0)(9).ToString - total
            tContent = tContent & vbCrLf & cPart

        Next
        rpt = Replace(rpt, "[tgl]", "" & Format(Now, "dd MM yyyy"))
        rpt = Replace(rpt, "[totbayar]", total)
        rpt = Replace(rpt, "[totsisa]", totalsisa)
        rpt = Replace(rpt, "[terbilang]", tb_banyaknya.Text)

        'rpt = Replace(rpt, "[tf]", "" & Format(Now, "dd MM yyyy"))
        ' rpt = Replace(rpt, "[pn]", dt.Rows(0)("penerima").ToString)
        'rpt = Replace(rpt, "[jml]", total)
        rpt = Replace(rpt, "[n]", dt.Rows(0)(0).ToString)
        rpt = Replace(rpt, "[nama]", dt.Rows(0)(5).ToString)
        rpt = Replace(rpt, "[npm]", dt.Rows(0)(2).ToString)
        rpt = Replace(rpt, "[sem]", dt.Rows(0)(3).ToString)
        rpt = Replace(rpt, "[ang]", dt.Rows(0)(4).ToString)
        rpt = Replace(rpt, "[content]", tContent)


            'nominal = nominal + Val(dt.Rows(s)("jumlah").ToString)
            'rpt = Replace(rpt, "[nominal]", nominal)
            ' tContent = ""
        File.WriteAllText("E:\Data" & sekarang & ".xls", rpt)
        ShellExecuteA(Me.Handle, "open", "E:\Data" & sekarang & ".xls", "", "", 1)
    End Sub

    Private Sub bt_cetak_Click(sender As Object, e As EventArgs) Handles bt_cetak.Click
        '     PrintDialog1.Document = PrintDocument1
        '    PrintDialog1.PrinterSettings.Collate = True
        '   If Not IsNumeric(tbbanyak.Text) Then
        'ErrorProvider1.SetError(tbbanyak, "Silahkan isi terlebih dahulu banyak copy yang diinginkan")
        ' Else
        ' ErrorProvider1.SetError(tbbanyak, "")
        ' PrintDialog1.PrinterSettings.Copies = CInt(tbbanyak.Text)
        ' PrintDialog1.PrinterSettings.FromPage = 1
        ' PrintDialog1.PrinterSettings.ToPage = 5
        ' If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        'PrintDocument1.Print()
        'End If
        'End If
        CetakKondisi()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' CetakKondisi()
    End Sub

    Private Sub tbbanyak_TextChanged(sender As Object, e As EventArgs) Handles tbbanyak.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub tb_jumlah_TextChanged(sender As Object, e As EventArgs) Handles tb_jumlah.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub tb_banyaknya_TextChanged(sender As Object, e As EventArgs) Handles tb_banyaknya.TextChanged

    End Sub
End Class