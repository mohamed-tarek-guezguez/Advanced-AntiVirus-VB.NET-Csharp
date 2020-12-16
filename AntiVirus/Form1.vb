Imports System.Diagnostics
Public Class Form1
    Public BtnClickk As Integer = 1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            'Disk Usage
            Dim DiskTotalSpace As Integer = CInt(My.Computer.FileSystem.Drives.Item(0).TotalSize.ToString.Substring(0, 3))
            Dim DiskFreeSpace As Integer = CInt(My.Computer.FileSystem.Drives.Item(0).AvailableFreeSpace.ToString.Substring(0, 3))
            BunifuCircleProgressbar1.MaxValue = DiskTotalSpace
            BunifuCircleProgressbar1.Value = DiskTotalSpace - DiskFreeSpace

            'Ram Usage
            Dim RamTotalSpace As Integer = CInt(My.Computer.Info.TotalPhysicalMemory.ToString.Substring(0, 3))
            Dim RamFreeSpace As Integer = CInt(My.Computer.Info.AvailablePhysicalMemory.ToString.Substring(0, 3))
            BunifuCircleProgressbar2.MaxValue = RamTotalSpace
            BunifuCircleProgressbar2.Value = RamTotalSpace - RamFreeSpace

            'battery usage
            Dim power As PowerStatus = SystemInformation.PowerStatus
            Dim percent As Single = power.BatteryLifePercent
            BunifuCircleProgressbar5.Value = percent * 100
            Label12.Text = CStr(percent * 100) + "%"
            Label12.Location = New Point(BunifuCircleProgressbar5.Location.X + 32, BunifuCircleProgressbar5.Location.Y + 41)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        BunifuCircleProgressbar3.Value = CPU.NextValue
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        ResetBtnColor()
        BtnClickk = 1
        Label8.BackColor = Color.AliceBlue
        Label8.ForeColor = Color.FromArgb(109, 213, 237)
        SwitchForm(StatusFrm)
    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As EventArgs) Handles Label8.MouseEnter
        Label8.BackColor = Color.AliceBlue
        Label8.ForeColor = Color.FromArgb(109, 213, 237)
    End Sub

    Private Sub Label8_MouseLeave(sender As Object, e As EventArgs) Handles Label8.MouseLeave
        If BtnClickk <> 1 Then
            Label8.BackColor = Color.Transparent
            Label8.ForeColor = Color.White
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        ResetBtnColor()
        BtnClickk = 2
        Label9.BackColor = Color.AliceBlue
        Label9.ForeColor = Color.FromArgb(109, 213, 237)
        SwitchForm(ProtectionFrm)
    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As EventArgs) Handles Label9.MouseEnter
        Label9.BackColor = Color.AliceBlue
        Label9.ForeColor = Color.FromArgb(109, 213, 237)
    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave
        If BtnClickk <> 2 Then
            Label9.BackColor = Color.Transparent
            Label9.ForeColor = Color.White
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        ResetBtnColor()
        BtnClickk = 3
        Label10.BackColor = Color.AliceBlue
        Label10.ForeColor = Color.FromArgb(109, 213, 237)
        SwitchForm(FrmMain)
    End Sub

    Private Sub Label10_MouseEnter(sender As Object, e As EventArgs) Handles Label10.MouseEnter
        Label10.BackColor = Color.AliceBlue
        Label10.ForeColor = Color.FromArgb(109, 213, 237)
    End Sub

    Private Sub Label10_MouseLeave(sender As Object, e As EventArgs) Handles Label10.MouseLeave
        If BtnClickk <> 3 Then
            Label10.BackColor = Color.Transparent
            Label10.ForeColor = Color.White
        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        ResetBtnColor()
        BtnClickk = 4
        Label11.BackColor = Color.AliceBlue
        Label11.ForeColor = Color.FromArgb(109, 213, 237)
        SwitchForm(AboutFrm)
    End Sub

    Private Sub Label11_MouseEnter(sender As Object, e As EventArgs) Handles Label11.MouseEnter
        Label11.BackColor = Color.AliceBlue
        Label11.ForeColor = Color.FromArgb(109, 213, 237)
    End Sub

    Private Sub Label11_MouseLeave(sender As Object, e As EventArgs) Handles Label11.MouseLeave
        If BtnClickk <> 4 Then
            Label11.BackColor = Color.Transparent
            Label11.ForeColor = Color.White
        End If
    End Sub

    Public Sub ResetBtnColor()
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = Color.White
        Label9.BackColor = Color.Transparent
        Label9.ForeColor = Color.White
        Label10.BackColor = Color.Transparent
        Label10.ForeColor = Color.White
        Label11.BackColor = Color.Transparent
        Label11.ForeColor = Color.White
    End Sub

    Sub SwitchForm(ByVal frm As Form)
        FormsPannel.Controls.Clear()
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        FormsPannel.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub Label13_Click_1(sender As Object, e As EventArgs) Handles Label13.Click
        End
    End Sub

    Private Sub Label13_MouseEnter(sender As Object, e As EventArgs) Handles Label13.MouseEnter
        Label13.BackColor = Color.Snow
        Label13.ForeColor = Color.FromArgb(109, 213, 237)
    End Sub

    Private Sub Label13_MouseLeave(sender As Object, e As EventArgs) Handles Label13.MouseLeave
        Label13.BackColor = Color.White
        Label13.ForeColor = Color.Silver
    End Sub

    Private Sub Label14_Click_1(sender As Object, e As EventArgs) Handles Label14.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label14_MouseEnter(sender As Object, e As EventArgs) Handles Label14.MouseEnter
        Label14.BackColor = Color.Snow
        Label14.ForeColor = Color.FromArgb(109, 213, 237)
    End Sub

    Private Sub Label14_MouseLeave(sender As Object, e As EventArgs) Handles Label14.MouseLeave
        Label14.BackColor = Color.White
        Label14.ForeColor = Color.Silver
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchForm(StatusFrm)
    End Sub

End Class
