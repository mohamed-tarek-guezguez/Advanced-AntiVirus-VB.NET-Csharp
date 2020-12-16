Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Public Class ProtectionFrm

    Dim Md5Hash As String

    Sub GetFiles()
        Try
            For i As Integer = 0 To ListBox1.Items.Count - 1
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(ListBox1.Items(i))
                    ListBox2.Items.Add(foundFile)
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub
    Sub GetDirectories(ByVal StartPath As String, ByRef DirectoryList As ArrayList)
        Try
            Dim Dirs() As String = Directory.GetDirectories(StartPath)
            DirectoryList.AddRange(Dirs)
            For Each item In DirectoryList
                ListBox1.Items.Add(item)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Function GetFileHash(ByVal FileHash As String)
        Dim md5code As String
        Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
        Dim f As FileStream = New FileStream(FileHash, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        f = New FileStream(FileHash, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        md5.ComputeHash(f)
        Dim ObjFSO As Object = CreateObject("Scripting.FileSystemObject")
        Dim objFile = ObjFSO.GetFile(FileHash)
        Dim hash As Byte() = md5.Hash
        Dim buff As StringBuilder = New StringBuilder
        Dim hashByte As Byte
        For Each hashByte In hash
            buff.Append(String.Format("{0:X1}", hashByte))
        Next
        md5code = buff.ToString()
        Return md5code
    End Function


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Clipboard.SetText(Label2.Text)
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Label2.Text = GetFileHash(ListBox2.Items(ListBox2.SelectedIndex))
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        Try
            Dim dlg As FolderBrowserDialog = New FolderBrowserDialog()
            dlg.Description = "Select a folder"
            If dlg.ShowDialog() = DialogResult.OK Then
                TextBox1.Text = dlg.SelectedPath
            End If

            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()
            FastColoredTextBox1.Text = ""
            FastColoredTextBox1.Text = File.ReadAllText("D:\My Projects\Visual Studio\AntiVirus\AntiVirus\AntiVirus\bin\Debug\Hash.txt")

            Dim Directory As String = TextBox1.Text

            Dim DirList As New ArrayList
            ListBox1.Items.Add(Directory)
            GetDirectories(Directory, DirList)
            GetFiles()
            GroupBox1.Text = CStr(ListBox2.Items.Count) + " Files"

            For i As Integer = 0 To ListBox2.Items.Count - 1
                Md5Hash = GetFileHash(ListBox2.Items(i))
                If FastColoredTextBox1.Text.ToUpper.IndexOf(Md5Hash) <> -1 Then
                    ListBox3.Items.Add(ListBox2.Items(i))
                End If
            Next
            GroupBox2.Text = CStr(ListBox3.Items.Count) + " Virus"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.BackColor = Color.FromArgb(12, 183, 84)
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.BackColor = Color.FromArgb(89, 193, 86)
    End Sub
End Class