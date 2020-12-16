Public Class StatusFrm
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form1.ResetBtnColor()
        Form1.BtnClickk = 2
        Form1.Label9.BackColor = Color.AliceBlue
        Form1.Label9.ForeColor = Color.FromArgb(109, 213, 237)
        Form1.SwitchForm(ProtectionFrm)
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Label2.BackColor = Color.FromArgb(12, 183, 84)
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.BackColor = Color.FromArgb(89, 193, 86)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProtectionFrm.GroupBox2.Text = "0 Virus" Then
            Label8.Visible = True
            PictureBox1.Visible = True
            Label1.Visible = False
            PictureBox2.Visible = False
            Label2.BackColor = Color.FromArgb(89, 193, 86)
        Else
            Label8.Visible = False
            PictureBox1.Visible = False
            Label1.Visible = True
            PictureBox2.Visible = True
            Label2.BackColor = Color.FromArgb(244, 104, 104)
        End If
    End Sub

    Private Sub StatusFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class