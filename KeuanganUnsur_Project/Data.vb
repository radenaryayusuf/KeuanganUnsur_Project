Public Class Data
    ' Public Sub urutindex_um()
    '      tb_namaum.TabIndex = 0
    '     tb_uraian.TabIndex = 1
    '    tb_kewajiban.TabIndex = 2
    '   tb_catatan.TabIndex = 3
    'End Sub
    'Public Sub urutindex_uk()
    '   tb_kodeuk.TabIndex = 0
    '  tb_namauk.TabIndex = 1
    ' tb_uraianuk.TabIndex = 2
    'tb_jumlahuk.TabIndex = 3
    'End Sub
    ' Public Sub urutindex_ug()
    '    tb_namaug.TabIndex = 0
    '   tb_besaranug.TabIndex = 1
    '  tb_ketug.TabIndex = 2
    'End Sub
    'Public Sub urutindex_ut()
    '    tb_namaut.TabIndex = 0
    '   tb_ketut.TabIndex = 1
    'End Sub
    Public Sub showkomponenmasuk()
        lmhs1.Show()
        lmhs2.Show()
        lmhs3.Show()
        lmhs4.Show()
        lmhs5.Show()
        lmhs6.Show()
        lmhs7.Show()
        lmhs8.Show()
        lmhs9.Show()
        lmhs10.Show()
        lmhs11.Show()
        lmhs12.Show()
        lmhs13.Show()
        lmhs14.Show()
        lmhs15.Show()
        lmhs16.Show()
        lmhs17.Show()
        lmhs18.Show()
        lmhs19.Show()
        lmhs20.Show()
        lmhs21.Show()
        lmhs22.Show()
        lmhs23.Show()
        lmhs24.Show()
        lmhs25.Show()
        lmhs26.Show()
        lmhs27.Show()
        lmhs28.Show()
        lmhs29.Show()
        Label30.Show()
        Label31.Show()
        Label32.Show()
        Label33.Show()
        Label34.Show()
        Label35.Show()
        Label36.Show()
        lnpm.Show()
        lnama.Show()
        lsemester.Show()
        langkatan.Show()
        lalamat.Show()
        ljk.Show()
        lttl.Show()
        lagama.Show()
        pb_fotomhs.Show()
        tbkodemasuk.Show()
        tbnamamasuk.Show()
        tburaianwajib.Show()
        tburaianmasuk.Show()
        tbcatatanmasuk.Show()
        tbkewajibanmasuk.Show()
        tbkodeakunwajib.Show()
        tbnamaakunwajib.Show()
        tbnomerwajib.Show()
        tbjumlahwajib.Show()
        btsave.Show()
        btcancel.Show()


    End Sub
    Public Sub hidekomponenmasuk()
        lmhs1.Hide()
        lmhs2.Hide()
        lmhs3.Hide()
        lmhs4.Hide()
        lmhs5.Hide()
        lmhs6.Hide()
        lmhs7.Hide()
        lmhs8.Hide()
        lmhs9.Hide()
        lmhs10.Hide()
        lmhs11.Hide()
        lmhs12.Hide()
        lmhs13.Hide()
        lmhs14.Hide()
        lmhs15.Hide()
        lmhs16.Hide()
        lmhs17.Hide()
        lmhs18.Hide()
        lmhs19.Hide()
        lmhs20.Hide()
        lmhs21.Hide()
        lmhs22.Hide()
        lmhs23.Hide()
        lmhs24.Hide()
        lmhs25.Hide()
        lmhs26.Hide()
        lmhs27.Hide()
        lmhs28.Hide()
        lmhs29.Hide()
        Label30.Hide()
        Label31.Hide()
        Label32.Hide()
        Label33.Hide()
        Label34.Hide()
        Label35.Hide()
        Label36.Hide()
        lnpm.Hide()
        lnama.Hide()
        lsemester.Hide()
        langkatan.Hide()
        lalamat.Hide()
        ljk.Hide()
        lttl.Hide()
        lagama.Hide()
        pb_fotomhs.Hide()
        tbkodemasuk.Hide()
        tbnamamasuk.Hide()
        tburaianwajib.Hide()
        tburaianmasuk.Hide()
        tbcatatanmasuk.Hide()
        tbkewajibanmasuk.Hide()
        tbkodeakunwajib.Hide()
        tbnamaakunwajib.Hide()
        tbnomerwajib.Hide()
        tbjumlahwajib.Hide()
        btsave.Hide()
        btcancel.Hide()


    End Sub
    Private Sub Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        hidekomponenmasuk()



        '    tb_kodeum.Text = getkodepemasukan()
        '   tb_nomeruk.Text = getkodeukeluar()
        'tb_kodeug.Text = getkodegaji()
        '  tb_kodeut.Text = getkodetransaksi()
        ' tb_kodeum.Enabled = False
        ' tb_nomeruk.Enabled = False
        'tb_kodeug.Enabled = False
        'tb_kodeut.Enabled = False
        ' Panel2.Focus()
    End Sub
    ' Public Sub bersihkan_um()
    'tb_namaum.Clear()
    'tb_uraian.Clear()
    'tb_kewajiban.Clear()
    '   tb_catatan.Clear()

    ' End Sub
    '   Public Sub bersihkan_uk()
    '      tb_kodeuk.Clear()
    '     tb_namauk.Clear()
    '    tb_uraianuk.Clear()
    '   tb_jumlahuk.Clear()

    'End Sub
    '   Public Sub bersihkan_ug()
    '      tb_namaug.Clear()
    '     tb_besaranug.Clear()
    '    tb_ketug.Clear()

    'End Sub
    ' Public Sub bersihkan_ut()
    ' tb_namaut.Clear()
    '   tb_ketut.Clear()

    ' End Sub

    ' Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)
    '  Call urutindex_um()

    '  End Sub

    'Private Sub bt_save_Click(sender As Object, e As EventArgs)
    ' If tb_namaum.Text = "" Or tb_uraian.Text = "" Or tb_kewajiban.Text = "" Or tb_catatan.Text = "" Then
    'MsgBox("Mohon Lengkapi Semua data!")
    ' Else
    ' setsql("insert into t_kodepemasukan values('" & tb_kodeum.Text & "','" & tb_namaum.Text & "','" & tb_uraian.Text & "','" & tb_kewajiban.Text & "','" & tb_catatan.Text & "')")
    ' bersihkan_um()
    '  tb_kodeum.Text = getkodepemasukan()
    '  tb_namaum.Focus()

    '   End If
    '  End Sub

    ' Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)
    '    Call urutindex_uk()

    '  End Sub

    ' Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)
    '    If tb_kodeuk.Text = "" Or tb_namauk.Text = "" Or tb_uraianuk.Text = "" Or tb_jumlahuk.Text = "" Then
    '        MsgBox("Mohon Lengkapi Semua data!")
    '    Else
    '         setsql("insert into t_ukwajib values('" & tb_nomeruk.Text & "','" & tb_kodeuk.Text & "','" & tb_namauk.Text & "','" & tb_uraianuk.Text & "','" & tb_jumlahuk.Text & "')")
    '        bersihkan_uk()
    '        tb_nomeruk.Text = getkodeukeluar()
    '        tb_kodeuk.Focus()

    '    End If
    ' End Sub

    'Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs)
    '   If tb_namaug.Text = "" Or tb_besaranug.Text = "" Or tb_ketug.Text = "" Then
    '      MsgBox("Mohon Lengkapi Semua data!")
    '   Else
    '       setsql("insert into t_kodeugaji values('" & tb_kodeug.Text & "','" & tb_namaug.Text & "','" & tb_besaranug.Text & "','" & tb_ketug.Text & "')")
    '       bersihkan_ug()
    '       tb_kodeug.Text = getkodegaji()
    '      tb_namaug.Focus()

    '    End If
    'End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)
        '  Call urutindex_ug()

    End Sub

    'Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs)
    'If tb_namaut.Text = "" Or tb_ketut.Text = "" Then
    ' MsgBox("Mohon Lengkapi Semua data!")
    '  Else
    ' setsql("insert into t_kodeutransaksi values('" & tb_kodeut.Text & "','" & tb_namaut.Text & "','" & tb_ketut.Text & "')")
    ' bersihkan_ut()
    ' tb_kodeut.Text = getkodetransaksi()
    ' tb_namaut.Focus()

    '   End If
    '  End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)
        '  Call urutindex_ut()

    End Sub



    Private Sub tb_ketug_KeyPress(sender As Object, e As KeyPressEventArgs)
        '  If e.KeyChar = Chr(13) Then
        'If tb_namaug.Text = "" Or tb_besaranug.Text = "" Or tb_ketug.Text = "" Then
        MsgBox("Mohon Lengkapi Semua data!")
        '  Else
        ' setsql("insert into t_kodeugaji values('" & tb_kodeug.Text & "','" & tb_namaug.Text & "','" & tb_besaranug.Text & "','" & tb_ketug.Text & "')")
        ' bersihkan_ug()
        ' tb_kodeug.Text = getkodegaji()
        ' tb_namaug.Focus()

        '  End If

        '  End If
    End Sub

    Private Sub tb_ketum_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            '  If tb_namaum.Text = "" Or tb_uraian.Text = "" Or tb_kewajiban.Text = "" Or tb_catatan.Text = "" Then
            MsgBox("Mohon Lengkapi Semua data!")
        Else
            '    setsql("insert into t_kodepemasukan values('" & tb_kodeum.Text & "','" & tb_namaum.Text & "','" & tb_uraian.Text & "','" & tb_kewajiban.Text & "','" & tb_catatan.Text & "')")
            '   bersihkan_um()
            '  tb_kodeum.Text = getkodepemasukan()
            '  tb_namaum.Focus()

        End If
        ' End If
    End Sub
    Private Sub tb_jumlahuk_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            'If tb_kodeuk.Text = "" Or tb_namauk.Text = "" Or tb_uraianuk.Text = "" Or tb_jumlahuk.Text = "" Then
            '  MsgBox("Mohon Lengkapi Semua data!")
            'Else
            '   setsql("insert into t_ukwajib values('" & tb_nomeruk.Text & "','" & tb_kodeuk.Text & "','" & tb_namauk.Text & "','" & tb_uraianuk.Text & "','" & tb_jumlahuk.Text & "')")
            '    bersihkan_uk()
            '   tb_nomeruk.Text = getkodeukeluar()
            '    tb_kodeuk.Focus()

        End If
        '  End If
    End Sub

    Private Sub tb_ketut_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            ' If tb_namaut.Text = "" Or tb_ketut.Text = "" Then
            MsgBox("Mohon Lengkapi Semua data!")
        Else
            'setsql("insert into t_kodeutransaksi values('" & tb_kodeut.Text & "','" & tb_namaut.Text & "','" & tb_ketut.Text & "')")
            '  bersihkan_ut()
            '  tb_kodeut.Text = getkodetransaksi()
            '   tb_namaut.Focus()

        End If
        '  End If
    End Sub

    Private Sub tb_catatan_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Close()
    End Sub

    Private Sub bt_min_Click(sender As Object, e As EventArgs) Handles bt_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BunifuSeparator1.Left = Button1.Left
        BunifuSeparator1.Width = Button1.Width
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BunifuSeparator1.Left = Button2.Left
        BunifuSeparator1.Width = Button2.Width
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BunifuSeparator1.Left = Button3.Left
        BunifuSeparator1.Width = Button3.Width
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BunifuSeparator1.Left = Button4.Left
        BunifuSeparator1.Width = Button4.Width
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        statuspindah = "formdata"
        statusproses = "insert"
        FInput_Mahasiswa.Show()
        Me.Hide()

    End Sub



    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        statuspindah = "formdata"
        statusproses = "insert"
        FInput_Mahasiswa.Show()
        Me.Hide()
    End Sub

    Private Sub lnpm_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lnpm_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lnama_Click(sender As Object, e As EventArgs) Handles lnama.Click

    End Sub

    Private Sub lnama_TextChanged(sender As Object, e As EventArgs) Handles lnama.TextChanged
       
    End Sub

    Private Sub lsemester_Click(sender As Object, e As EventArgs) Handles lsemester.Click

    End Sub

    Private Sub lsemester_TextChanged(sender As Object, e As EventArgs) Handles lsemester.TextChanged
        
    End Sub

    Private Sub langkatan_Click(sender As Object, e As EventArgs) Handles langkatan.Click
       
    End Sub

    Private Sub lttl_Click(sender As Object, e As EventArgs) Handles lttl.Click

    End Sub

    Private Sub lttl_TextChanged(sender As Object, e As EventArgs) Handles lttl.TextChanged
      
    End Sub

    Private Sub tbnamamasuk_TextChanged(sender As Object, e As EventArgs) Handles tbnamamasuk.TextChanged

    End Sub
End Class