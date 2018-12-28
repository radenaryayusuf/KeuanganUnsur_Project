Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO
Imports System.Data.OleDb
Public Class FReport_kas
    Public Con As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader

    Public a As String
    Declare Function ShellExecuteA Lib "shell32.dll" ( _
             ByVal hWnd As IntPtr, _
             ByVal lpOperation As String, _
             ByVal lpFile As String, _
             ByVal lpParameters As String, _
             ByVal lpDirectory As String, _
             ByVal nShowCmd As Integer) As IntPtr
    Private bulan As String
    Private Sub isibulan()
        If cbbulan.Text = "1" Then
            bulan = "Januari"
        ElseIf cbbulan.Text = "2" Then
            bulan = "Februari"
        ElseIf cbbulan.Text = "3" Then
            bulan = "Maret"
        ElseIf cbbulan.Text = "4" Then
            bulan = "April"
        ElseIf cbbulan.Text = "5" Then
            bulan = "Mei"
        ElseIf cbbulan.Text = "6" Then
            bulan = "Juni"
        ElseIf cbbulan.Text = "7" Then
            bulan = "Juli"
        ElseIf cbbulan.Text = "8" Then
            bulan = "Agustus"
        ElseIf cbbulan.Text = "9" Then
            bulan = "September"
        ElseIf cbbulan.Text = "10" Then
            bulan = "Oktober"
        ElseIf cbbulan.Text = "11" Then
            bulan = "November"
        ElseIf cbbulan.Text = "12" Then
            bulan = "Desember"
        End If
    End Sub

    Private Sub FReport_Kas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        For i As Integer = 1 To 12
            If i < 10 Then
                cbbulan.Items.Add(i)
            Else
                cbbulan.Items.Add(i)
            End If
        Next
        For i As Integer = 2010 To 2050
            cbtahun.Items.Add(i)
        Next


    End Sub
    Private Sub bt_keluar_Click(sender As Object, e As EventArgs) Handles bt_keluar.Click
        Me.Close()
    End Sub
    Private Sub CetakKondisi()
        Dim i As Integer
        Dim rpt As String
        Dim cPart, tContent As String
        Dim periode As String = Format(Now, "MMMM") & " " & Format(Now, "yyyy")
        Dim sekarang As String = "_TGL_" & Format(Now, "dd-MM-yy_mmss")
        Dim totalmasuk As Integer = 0
        Dim totalkeluar As Integer = 0
        Dim tanggalubah As String
        dt = New DataTable
        dt = getsql("select * from q_kas2 where Month(tanggal) = '" & cbbulan.Text & "' And Year(tanggal) = '" & cbtahun.Text & "' ")

        rpt = File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) & "\jurnal_keuangan.mht")
        rpt = Replace(rpt, "[pr]", periode)
        tContent = ""

        For i = 0 To (dt.Rows.Count - 1)
            cPart = File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) & "\jurnal_keuangan_content.mht")

            cPart = Replace(cPart, "[tgl]", dt.Rows(i)(0).ToString)
            cPart = Replace(cPart, "[nobuk]", dt.Rows(i)(1).ToString)
            cPart = Replace(cPart, "[uraian]", dt.Rows(i)(2).ToString)
            cPart = Replace(cPart, "[kode]", dt.Rows(i)(3).ToString)
            cPart = Replace(cPart, "[nama]", dt.Rows(i)(4).ToString)
            cPart = Replace(cPart, "[pen]", dt.Rows(i)(5).ToString)
            cPart = Replace(cPart, "[peng]", dt.Rows(i)(6).ToString)
            'cPart = Replace(cPart, "[penerimaan]", dt.Rows(i)("penerimaan").ToString)
            'cPart = Replace(cPart, "[pengeluaran]", dt.Rows(i)("sum(pengeluaran)").ToString)
            'cPart = Replace(cPart, "[saldo]", dt.Rows(i)("sum(penerimaan)-sum(pengeluaran)").ToString)

            totalmasuk = totalmasuk + Val(dt.Rows(i)(5).ToString)
            totalkeluar = totalkeluar + Val(dt.Rows(i)(6).ToString)
            tContent = tContent & vbCrLf & cPart
            ' MsgBox(total)
        Next
        rpt = Replace(rpt, "[tgl]", Format(Now, "dd-MM-yyyy"))
        rpt = Replace(rpt, "[penerimaan]", totalmasuk)
        rpt = Replace(rpt, "[pengeluaran]", totalkeluar)
        rpt = Replace(rpt, "[saldo]", Val(totalmasuk) - Val(totalkeluar))
        rpt = Replace(rpt, "[content]", tContent)


        ' rpt = Replace(rpt, "[tot]", total)


        File.WriteAllText("E:\Kas" & sekarang & ".xls", rpt)
        ShellExecuteA(Me.Handle, "open", "E:\Kas" & sekarang & ".xls", "", "", 1)
    End Sub



    Private Sub btprint_Click(sender As Object, e As EventArgs) Handles btprint.Click
        CetakKondisi()
    End Sub

    Private Sub cbbulan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbulan.SelectedIndexChanged
        If cbbulan.Text <> "" Then
            dgvsbp.DataSource = getsql("select * from q_kas where Month(tgl) = '" & cbbulan.Text & "'")

        End If
    End Sub

    Private Sub cbtahun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtahun.SelectedIndexChanged
        If cbtahun.Text <> "" Then
            dgvsbp.DataSource = getsql("select * from q_kas where  Month(tgl) = '" & cbbulan.Text & "' and Year(tgl) = '" & cbtahun.Text & "'")

        End If
    End Sub

    Private Sub dgvsbp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsbp.CellContentClick

    End Sub

    Private Sub dgvsbp_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsbp.CellDoubleClick

    End Sub
End Class
