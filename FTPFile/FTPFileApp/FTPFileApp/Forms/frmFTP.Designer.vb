<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFTP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFTP))
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstStatus = New System.Windows.Forms.ListBox()
        Me.btnUploadFile = New System.Windows.Forms.Button()
        Me.pBar = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFTPHost = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPathUpload = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFileUpload = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(9, 197)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Status:"
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(540, 86)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 68)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close App"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lstStatus
        '
        Me.lstStatus.DisplayMember = "Text"
        Me.lstStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.lstStatus.FormattingEnabled = True
        Me.lstStatus.HorizontalScrollbar = True
        Me.lstStatus.ItemHeight = 24
        Me.lstStatus.Location = New System.Drawing.Point(12, 213)
        Me.lstStatus.Name = "lstStatus"
        Me.lstStatus.Size = New System.Drawing.Size(604, 255)
        Me.lstStatus.TabIndex = 10
        Me.lstStatus.ValueMember = "Image"
        '
        'btnUploadFile
        '
        Me.btnUploadFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadFile.Image = CType(resources.GetObject("btnUploadFile.Image"), System.Drawing.Image)
        Me.btnUploadFile.Location = New System.Drawing.Point(540, 12)
        Me.btnUploadFile.Name = "btnUploadFile"
        Me.btnUploadFile.Size = New System.Drawing.Size(76, 68)
        Me.btnUploadFile.TabIndex = 9
        Me.btnUploadFile.Text = "&Upload File"
        Me.btnUploadFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUploadFile.UseVisualStyleBackColor = True
        '
        'pBar
        '
        Me.pBar.Location = New System.Drawing.Point(12, 484)
        Me.pBar.Name = "pBar"
        Me.pBar.Size = New System.Drawing.Size(604, 23)
        Me.pBar.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "FTP Host:"
        '
        'txtFTPHost
        '
        Me.txtFTPHost.Location = New System.Drawing.Point(12, 28)
        Me.txtFTPHost.Name = "txtFTPHost"
        Me.txtFTPHost.Size = New System.Drawing.Size(522, 20)
        Me.txtFTPHost.TabIndex = 13
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(12, 73)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(256, 20)
        Me.txtUsername.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "FTP Username:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(284, 73)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(250, 20)
        Me.txtPassword.TabIndex = 17
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(281, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "FTP Password:"
        '
        'txtPathUpload
        '
        Me.txtPathUpload.Location = New System.Drawing.Point(12, 122)
        Me.txtPathUpload.Name = "txtPathUpload"
        Me.txtPathUpload.Size = New System.Drawing.Size(522, 20)
        Me.txtPathUpload.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "FTP Path Upload:"
        '
        'txtFileUpload
        '
        Me.txtFileUpload.Location = New System.Drawing.Point(12, 162)
        Me.txtFileUpload.Name = "txtFileUpload"
        Me.txtFileUpload.ReadOnly = True
        Me.txtFileUpload.Size = New System.Drawing.Size(485, 20)
        Me.txtFileUpload.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "FTP File Upload:"
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(503, 161)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(31, 23)
        Me.btnOpenFile.TabIndex = 22
        Me.btnOpenFile.Text = "..."
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'frmFTP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 519)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.txtFileUpload)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPathUpload)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFTPHost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lstStatus)
        Me.Controls.Add(Me.btnUploadFile)
        Me.Controls.Add(Me.pBar)
        Me.Controls.Add(Me.lblStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFTP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple FTP File App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lstStatus As System.Windows.Forms.ListBox
    Friend WithEvents btnUploadFile As System.Windows.Forms.Button
    Friend WithEvents pBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFTPHost As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPathUpload As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFileUpload As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button

End Class
