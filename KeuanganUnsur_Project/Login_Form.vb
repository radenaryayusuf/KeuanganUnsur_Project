Public Class Login_Form

    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tuser.Focus()
        tuser.TabIndex = 0
        tpass.TabIndex = 1
        Call koneksi()
        FadeIn()
    End Sub
    Public Sub FadeIn()
        Dim fade As Double
        For fade = 0.0 To 1.1 Step 0.1
            Me.Opacity = fade
            Me.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub


    Public Sub fadeout()
        Dim Fade As Double
        For Fade = 1.1 To 0.0 Step -0.5
            Me.Opacity = Fade
            Me.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
    Public Sub login()
        Dim datauser As DataTable
        datauser = getsql("select * from t_user where username = '" & Trim(tuser.Text) & "' and password = '" & Trim(tpass.Text) & "'")
        If datauser.Rows.Count <> 0 Then
            Form_Utama.show()
            Me.Hide()
        Else
            MsgBox("Username atau Password tidak sesuai", MsgBoxStyle.Critical)
            tuser.Text = ""
            tpass.Text = ""
            tuser.Focus()
        End If
    End Sub

    Private Sub tuser_Click(sender As Object, e As EventArgs) Handles tuser.Click
        If tuser.Text = "Username" Then
            tuser.Text = ""
        End If
    End Sub

    Private Sub tuser_OnValueChanged(sender As Object, e As EventArgs) Handles tuser.OnValueChanged

    End Sub

    Private Sub tpass_Click(sender As Object, e As EventArgs) Handles tpass.Click
        If tpass.Text = "Password" Then
            tpass.Text = ""
        End If
    End Sub

    Private Sub tpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tpass.KeyPress
        If e.KeyChar = Chr(13) Then
            login()
        End If
    End Sub

    Private Sub tpass_OnValueChanged(sender As Object, e As EventArgs) Handles tpass.OnValueChanged

    End Sub

    Private Sub btlogin_Click(sender As Object, e As EventArgs) Handles btlogin.Click
        login()
    End Sub

    Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click
        fadeout()
        End
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class