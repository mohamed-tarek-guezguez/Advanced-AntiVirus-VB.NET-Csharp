Public Class AboutFrm
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        System.Diagnostics.Process.Start("https://www.facebook.com/tarak.guezguez")
    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As EventArgs) Handles Label9.MouseEnter
        Label9.ForeColor = Color.FromArgb(59, 88, 148)
    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave
        Label9.ForeColor = Color.FromArgb(64, 64, 64)
    End Sub

    Dim x As Integer = -1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label8.Left += x
        If Label8.Left <= -480 Then
            Label8.Left = 600
        End If
    End Sub
End Class