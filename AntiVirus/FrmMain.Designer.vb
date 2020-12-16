<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CHRESULT As System.Windows.Forms.ColumnHeader
        Dim CHENGINE As System.Windows.Forms.ColumnHeader
        Dim CHStatus As System.Windows.Forms.ColumnHeader
        Dim CHNome As System.Windows.Forms.ColumnHeader
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.GList = New System.Windows.Forms.ImageList(Me.components)
        CHRESULT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CHENGINE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CHStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CHNome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'CHRESULT
        '
        CHRESULT.Text = "RESULT"
        CHRESULT.Width = 198
        '
        'CHENGINE
        '
        CHENGINE.Text = "ENGINE"
        CHENGINE.Width = 207
        '
        'CHStatus
        '
        CHStatus.Text = "STATUS"
        CHStatus.Width = 198
        '
        'CHNome
        '
        CHNome.Text = "NOME"
        CHNome.Width = 210
        '
        'GList
        '
        Me.GList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.GList.ImageSize = New System.Drawing.Size(16, 16)
        Me.GList.TransparentColor = System.Drawing.Color.Transparent
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GList As ImageList
End Class
