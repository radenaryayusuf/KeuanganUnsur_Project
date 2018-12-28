Public Class Splashscreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            RectangleShape2.Width += 1
            If (RectangleShape2.Width >= 586) Then
                Timer1.Stop()
                Form_Utama.Show()
                Me.Hide()

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class