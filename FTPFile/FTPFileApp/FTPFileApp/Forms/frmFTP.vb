Imports System.IO

Public Class frmFTP

    Private Sub frmFTP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = String.Format("{0} v {1}", My.Application.Info.Title, My.Application.Info.Version.ToString)
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Dim oDlg As New OpenFileDialog
        With oDlg
            .Title = "Open file to Upload"
            .Filter = "All files (*.*)|*.*"
            .ShowReadOnly = False
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                txtFileUpload.Text = .FileName
            End If
        End With
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.ExitThread()
        Application.Exit()
    End Sub

    Private Sub btnUploadFile_Click(sender As Object, e As EventArgs) Handles btnUploadFile.Click
        'Checks if all required fields have been filled
        If CheckField(txtFTPHost, "FTP Host") = False Then Exit Sub
        If CheckField(txtUsername, "FTP Username") = False Then Exit Sub
        If CheckField(txtPassword, "FTP Password") = False Then Exit Sub
        If CheckField(txtPathUpload, "FTP Path Upload") = False Then Exit Sub
        If CheckField(txtFileUpload, "FTP File Upload") = False Then Exit Sub
        Try
            'Checks if FileUpload Exists
            If File.Exists(txtFileUpload.Text) = False Then
                MessageBox.Show("The file you are trying to upload via FTP does not exist or has been moved!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            lstStatus.Items.Clear()
            UploadFile(txtFileUpload.Text, txtFTPHost.Text, txtPathUpload.Text, txtUsername.Text, txtPassword.Text, pBar, lstStatus)

        Catch ex As Exception
            MessageBox.Show(ex.ToString, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub lstStatus_DrawItem(sender As Object, e As DrawItemEventArgs) Handles lstStatus.DrawItem
        Try
            If e.Index > -1 Then
                'Create instance of the oXref Class with lstStatus item
                Dim oXref As Xrefs = lstStatus.Items(e.Index)
                e.DrawBackground()
                'Draw image in Listbox Item
                e.Graphics.DrawImage(oXref.Image, e.Bounds.Left, e.Bounds.Top)
                'Draw text (string) in Listbox Item
                e.Graphics.DrawString(oXref.Text, Me.Font, oXref.Color, e.Bounds.Left + 20, e.Bounds.Top)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try

    End Sub
    Public Function CheckField(ByRef ctl As Control, ByVal sCampo As String) As Boolean
        Dim bResult As Boolean = False
        'check Object type
        If TypeOf ctl Is TextBox Then
            If Trim(ctl.Text) <> String.Empty Then bResult = True
        End If
        If TypeOf ctl Is ComboBox Then
            If Trim(ctl.Text) <> String.Empty Then bResult = True
        End If
        If TypeOf ctl Is RichTextBox Then
            If Trim(ctl.Text) <> String.Empty Then bResult = True
        End If
        'Check bResult Variable 
        'if False, Show MessageBox and achange backcolor of the control to Coral
        'if True, change the BackColor Property of the control to DEfaul (White or Tranparent)
        If bResult = False Then
            MessageBox.Show("The field '" & sCampo & "' can't be empty!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ctl.BackColor = Color.Coral
            ctl.Focus()
            Return bResult
        Else
            If TypeOf ctl Is Label Then
                ctl.BackColor = Color.Transparent
            Else
                ctl.BackColor = Color.White
            End If
            Return bResult
        End If
    End Function

End Class
