Imports System.IO
Public Class Freport_Pengeluaran
    Public a As String
    Declare Function ShellExecuteA Lib "shell32.dll" ( _
             ByVal hWnd As IntPtr, _
             ByVal lpOperation As String, _
             ByVal lpFile As String, _
             ByVal lpParameters As String, _
             ByVal lpDirectory As String, _
             ByVal nShowCmd As Integer) As IntPtr
    Private Sub Freport_Pengeluaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        tb_jumlah.Enabled = False
        tb_banyaknya.Enabled = False

    End Sub

    Private Sub cb_penerima_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_penerima.SelectedIndexChanged
        If DateTimePicker1.Text <> "" And cb_penerima.Text <> "" Then
            dgv.DataSource = getsql("select * from q_kwkeluar where tgl = '" & DateTimePicker1.Text & "' and penerima = '" & cb_penerima.Text & "'")
            Dim jumlahuang As Double
            jumlahuang = 0
            For t As Integer = 0 To dgv.Rows.Count - 1
                jumlahuang = jumlahuang + Val(dgv.Rows(t).Cells(5).Value)
            Next
            tb_jumlah.Text = jumlahuang
        End If
        If tb_jumlah.Text <> "" Then
            tb_banyaknya.Text = TERBILANG(Val(tb_jumlah.Text))
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        dgv.DataSource = getsql("select * from q_kwkeluar where tgl = '" & DateTimePicker1.Text & "'")
        cb_penerima.Text = ""
        cb_penerima.Items.Clear()

        For x As Integer = 0 To dgv.Rows.Count - 1
            cb_penerima.Items.Add(dgv.Rows(x).Cells(7).Value)

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
        Dim nominal As Integer = 0
        dt = New DataTable
        dt = getsql("select * from q_kwkeluar where penerima = '" & cb_penerima.Text & "'")

        For s = 0 To (dt.Rows.Count - 1)
            rpt = File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) & "\kwitansikeluar.mht")
            rpt = Replace(rpt, "[kalimat]", tb_banyaknya.Text)

            nominal = nominal + Val(dt.Rows(s)("jumlah").ToString)
            rpt = Replace(rpt, "[nominal]", nominal)
            tContent = ""
        Next
        For i = 0 To (dt.Rows.Count - 1)
            cPart = File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) & "\kwitansikeluar_content.mht")
            For o = 0 To (dgv.Rows.Count - 1)
                cPart = Replace(cPart, "[no]", dt.Rows(i)(o).ToString)
            Next
            cPart = Replace(cPart, "[tg]", dt.Rows(i)("tgl").ToString)
            cPart = Replace(cPart, "[kode]", dt.Rows(i)("kode_akun").ToString)
            cPart = Replace(cPart, "[akun]", dt.Rows(i)("nama_akun").ToString)
            cPart = Replace(cPart, "[uraian]", dt.Rows(i)("uraian").ToString)
            cPart = Replace(cPart, "[bayar]", dt.Rows(i)("jumlah").ToString)
            cPart = Replace(cPart, "[ket]", dt.Rows(i)("ket").ToString)
            total = total + Val(dt.Rows(i)("jumlah").ToString)
            tContent = tContent & vbCrLf & cPart

        Next
        For l = 0 To (dt.Rows.Count - 1)
            rpt = Replace(rpt, "[content]", tContent)
            rpt = Replace(rpt, "[tgl]", "" & Format(Now, "dd MM yyyy"))
            rpt = Replace(rpt, "[pn]", dt.Rows(0)("penerima").ToString)
            rpt = Replace(rpt, "[jml]", total)
        Next
        File.WriteAllText("E:\Pengeluaran" & sekarang & ".xls", rpt)
        ShellExecuteA(Me.Handle, "open", "E:\Pengeluaran" & sekarang & ".xls", "", "", 1)
    End Sub
    Private Sub bt_cetak_Click(sender As Object, e As EventArgs) Handles bt_cetak.Click
        CetakKondisi()
    End Sub


End Class