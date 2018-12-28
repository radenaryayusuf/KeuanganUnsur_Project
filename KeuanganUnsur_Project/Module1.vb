Imports System.Data.OleDb
Imports VB = Microsoft.VisualBasic
Module Module1
    Public conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Public dt As DataTable
    Public sql As String
    Public str As String
    Public Params As New List(Of OleDbParameter)
    Public RecordCount As Integer
    Public Exception As String
    Public statusproses, statuspindah, statusinput As String
    Public NIK_petugas, User, Typeuser As String

    Public Function Tampilkan(ByVal xForm As Form)
        For i As Integer = 0 To Form_Utama.TabControl1.TabPages.Count - 1
            If Form_Utama.TabControl1.TabPages(i).Name = xForm.Name Then
                Form_Utama.TabControl1.SelectedTab = Form_Utama.TabControl1.TabPages(xForm.Name)
                Return xForm
            End If
        Next i

        Form_Utama.TabControl1.TabPages.Add(xForm.Name, xForm.Text)
        Form_Utama.TabControl1.SelectedTab = Form_Utama.TabControl1.TabPages(xForm.Name)
        xForm.TopLevel = False
        xForm.Parent = Form_Utama.TabControl1.TabPages(xForm.Name)
        xForm.Show()
        Return xForm
    End Function
    Public Function MyParent(ByVal xForm As Form)
        With xForm
            .FormBorderStyle = Windows.Forms.BorderStyle.None
            .ControlBox = False
            .Parent = Form_Utama.TabControl1.TabPages(xForm.Name)
            .Height = Form_Utama.TabControl1.TabPages(xForm.Name).Height
            .Width = Form_Utama.TabControl1.TabPages(xForm.Name).Width
        End With
        Return xForm
    End Function
    Public Function Tutup(ByVal xForm As Form)
        xForm.Dispose()
        Form_Utama.TabControl1.TabPages(xForm.Name).Dispose()
        If Form_Utama.TabControl1.TabCount = 0 Then
            Form_Utama.TabControl1.Visible = False
        End If
        Return xForm
    End Function
    Public Sub koneksi()
        str = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_keuanganunsur.accdb;"
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
   

    Public Sub setsql(ByVal sql)
        Try
            cmd = New OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("error pada setsql" + ex.Message)
        End Try
    End Sub


    Function getsql(ByVal sql) As DataTable
        Try
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
        Catch ex As Exception
            MsgBox("error pada getsql " + ex.Message)
        End Try
        Return dt
    End Function
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)
    End Sub
    Public Sub ExecQuery(Query As String)
        RecordCount = 0
        Exception = ""
        Try
            cmd = New OleDbCommand(Query, conn)
            Params.ForEach(Sub(p) cmd.Parameters.Add(p))
            Params.Clear()
            dt = New DataTable
            da = New OleDbDataAdapter(cmd)
            RecordCount = da.Fill(dt)
        Catch ex As Exception
            Exception = ex.Message
        End Try
    End Sub
   
    Function GetUserName() As String
        If TypeOf My.User.CurrentPrincipal Is 
          Security.Principal.WindowsPrincipal Then
            ' The application is using Windows authentication.
            ' The name format is DOMAIN\USERNAME.
            Dim parts() As String = Split(My.User.Name, "\")
            Dim username As String = parts(1)
            Return username
        Else
            ' The application is using custom authentication.
            Return My.User.Name
        End If
    End Function

    Function getidmahasiswa() As String
        Dim text As String = "M0001"
        Try
            sql = "select nomor from t_mhs order by nomor desc"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
                text = Val(Right(text, 4) + 1)
                text = "M" & Left("0000", 4 - Len(text)) & text
            End If
        Catch ex As Exception
            MsgBox("error pada getnomhs = " + ex.Message)

        End Try
        Return text
    End Function
    Function getiddosen() As String
        Dim text As String = "D0001"
        Try
            sql = "select nomor from t_dosen order by nomor desc"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
                text = Val(Right(text, 4) + 1)
                text = "D" & Left("0000", 4 - Len(text)) & text
            End If
        Catch ex As Exception
            MsgBox("error pada getnodosen = " + ex.Message)

        End Try
        Return text
    End Function
    Function getidpegawai() As String
        Dim text As String = "P0001"
        Try
            sql = "select nomor from t_pegawai order by nomor desc"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
                text = Val(Right(text, 4) + 1)
                text = "P" & Left("0000", 4 - Len(text)) & text
            End If
        Catch ex As Exception
            MsgBox("error pada getnodosen = " + ex.Message)

        End Try
        Return text
    End Function
    Function getkodepenerimaanbayar() As String
        Dim text As String = "D0001"
        Try
            sql = "select no from t_pegawai order by no desc"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
                text = Val(Right(text, 4) + 1)
                text = "D" & Left("0000", 4 - Len(text)) & text
            End If
        Catch ex As Exception
            MsgBox("error pada getnodosen = " + ex.Message)

        End Try
        Return text
    End Function

    Function totaldosen() As String
        Dim text As String = ""
        Try
            sql = "select count(nomor) from t_dosen"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
            End If
        Catch ex As Exception
            MsgBox("error pada jumlahdosen= " + ex.Message)

        End Try
        Return text
    End Function
    Function totalpegawai() As String
        Dim text As String = ""
        Try
            sql = "select count(no) from t_pegawai"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
            End If
        Catch ex As Exception
            MsgBox("error pada totalpegawai = " + ex.Message)

        End Try
        Return text
    End Function
    Function totalmahasiswa() As String
        Dim text As String = ""
        Try
            sql = "select count(nomor) from t_mhs"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
            End If
        Catch ex As Exception
            MsgBox("error pada totalmahasiswa = " + ex.Message)

        End Try
        Return text
    End Function
    Function getkodepemasukan() As String
        Dim text As String = "MSK0001"
        Try
            sql = "select kode_akun from t_kodepemasukan order by kode_akun desc"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
                text = Val(Right(text, 4) + 1)
                text = "MSK" & Left("0000", 4 - Len(text)) & text
            End If
        Catch ex As Exception
            MsgBox("error pada getkodepemasukan = " + ex.Message)

        End Try
        Return text
    End Function
    Function getuangpengeluaran() As String
        Dim text As String = "UKLR0001"
        Try
            sql = "select nomor from t_keluar order by nomor desc"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
                text = Val(Right(text, 4) + 1)
                text = "UKLR" & Left("0000", 4 - Len(text)) & text
            End If
        Catch ex As Exception
            MsgBox("error pada getuangpengeluaran = " + ex.Message)

        End Try
        Return text
    End Function
    Function getkodepengeluaran() As String
        Dim text As String = "KLR0001"
        Try
            sql = "select kodeakun from t_kodepengeluaran order by kodeakun desc"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
                text = Val(Right(text, 4) + 1)
                text = "KLR" & Left("0000", 4 - Len(text)) & text
            End If
        Catch ex As Exception
            MsgBox("error pada getkodepengeluaran = " + ex.Message)

        End Try
        Return text
    End Function
    Function getkodepembayarandosen() As String
        Dim text As String = "KPD0001"
        Try
            sql = "select kode_akun from t_kodebayardosen order by kode_akun desc"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
                text = Val(Right(text, 4) + 1)
                text = "KPD" & Left("0000", 4 - Len(text)) & text
            End If
        Catch ex As Exception
            MsgBox("error pada getkodepembayarandosen = " + ex.Message)

        End Try
        Return text
    End Function
    Function getkodegaji() As String
        Dim text As String = "KGJI0001"
        Try
            sql = "select kode_akun from t_kodeugaji order by kode_akun desc"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
                text = Val(Right(text, 4) + 1)
                text = "KGJI" & Left("0000", 4 - Len(text)) & text
            End If
        Catch ex As Exception
            MsgBox("error pada getkodegaji = " + ex.Message)

        End Try
        Return text
    End Function
    Function getgaji() As String
        Dim text As String = "GJI0001"
        Try
            sql = "select nomer from t_ugaji order by nomer desc"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
                text = Val(Right(text, 4) + 1)
                text = "GJI" & Left("0000", 4 - Len(text)) & text
            End If
        Catch ex As Exception
            MsgBox("error pada getgaji = " + ex.Message)

        End Try
        Return text
    End Function
    
    Function getkodebelanja() As String
        Dim text As String = "B0001"
        Try
            sql = "select nomer from t_transaksi order by nomer desc"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
                text = Val(Right(text, 4) + 1)
                text = "B" & Left("0000", 4 - Len(text)) & text
            End If
        Catch ex As Exception
            MsgBox("error pada getkodebelanja = " + ex.Message)

        End Try
        Return text
    End Function
    Function getkodeumasuk() As String
        Dim text As String = "KUM0001"
        Try
            sql = "select kode_akun from t_kodeumasuk order by kode_akun desc"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
                text = Val(Right(text, 4) + 1)
                text = "KUM" & Left("0000", 4 - Len(text)) & text
            End If
        Catch ex As Exception
            MsgBox("error pada getkodeumasuk= " + ex.Message)

        End Try
        Return text
    End Function
    Function getkodeukwajib() As String
        Dim text As String = "KUK0001"
        Try
            sql = "select nomer from t_ukwajib order by nomer desc"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
                text = Val(Right(text, 4) + 1)
                text = "KUK" & Left("0000", 4 - Len(text)) & text
            End If
        Catch ex As Exception
            MsgBox("error pada getkodeukeluar= " + ex.Message)

        End Try
        Return text
    End Function
    Function getkodetransaksi() As String
        Dim text As String = "KT0001"
        Try
            sql = "select kode_akun from t_kodeutransaksi order by kode_akun desc"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
                text = Val(Right(text, 4) + 1)
                text = "KT" & Left("0000", 4 - Len(text)) & text
            End If
        Catch ex As Exception
            MsgBox("error pada getkodetransaksi = " + ex.Message)

        End Try
        Return text
    End Function
    Function getbayardosen() As String
        Dim text As String = "BD0001"
        Try
            sql = "select nomer from t_ubayardosen order by nomer desc"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
                text = Val(Right(text, 4) + 1)
                text = "BD" & Left("0000", 4 - Len(text)) & text
            End If
        Catch ex As Exception
            MsgBox("error pada getbayardosen = " + ex.Message)

        End Try
        Return text
    End Function
    Function getnopenerimaanbayar() As String
        Dim text As String = "PB0001"
        Try
            sql = "select nomor from t_umasuk order by nomor desc"
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                text = dt.Rows(0)(0).ToString
                text = Val(Right(text, 4) + 1)
                text = "PB" & Left("0000", 4 - Len(text)) & text
            End If
        Catch ex As Exception
            MsgBox("error pada getpenerimaanbayar = " + ex.Message)

        End Try
        Return text
    End Function
End Module
