Imports System.Net
Imports System.IO

Module mFTP
    Friend Class Xrefs
        'This Friendly Class allows you to add text to images in ComboBox and ListBox items.
        Public Property Text As String
        Public Property Image As Image
        Public Property Color As System.Drawing.Brush
        Public Sub New()
            'Create new Instance with nothing value for all variables
            Me.New(Nothing, Nothing, Nothing)
        End Sub
        Public Sub New(ByVal Text As String)
            'Create new Instance with for Text variable
            Me.New(Text, Nothing, Nothing)
        End Sub
        'Create new Instance with value for all variables (Text, Image and Color)
        Public Sub New(ByVal Text As String, ByVal Image As Image, ByVal Color As System.Drawing.Brush)
            Me.Text = Text
            Me.Image = Image
            Me.Color = Color
        End Sub
    End Class

    Public Sub UploadFile(ByVal sFileName As String, ByVal sFTPHost As String, ByVal sFTPUploadPath As String, _
                          ByVal sFTPUserName As String, ByVal sFTPPwd As String, _
                          ByRef oProgressBar As ProgressBar, ByRef oListBox As ListBox)
        Dim oFileInfo As New System.IO.FileInfo(sFileName)

        Try
            Dim sUri As String
            'Checks if sFTPHost and sFTPUploadPath Variables ends with "/" and create a correct sUri variable, to set in Uri object
            If sFTPHost.EndsWith("/") = True And sFTPUploadPath.EndsWith("/") = True Then
                sUri = sFTPHost & sFTPUploadPath & System.IO.Path.GetFileName(sFileName.ToString)
            ElseIf sFTPHost.EndsWith("/") = True And sFTPUploadPath.EndsWith("/") = False Then
                sUri = sFTPHost & sFTPUploadPath & "/" & System.IO.Path.GetFileName(sFileName.ToString)
            ElseIf sFTPHost.EndsWith("/") = False And sFTPUploadPath.EndsWith("/") = False Then
                sUri = sFTPHost & "/" & sFTPUploadPath & "/" & System.IO.Path.GetFileName(sFileName.ToString)
            End If
            'Create FtpWebRequest object from the Uri provided and set the object Type
            Dim oFtpWebRequest As System.Net.FtpWebRequest = _
                CType(System.Net.FtpWebRequest.Create(New Uri(sUri)), System.Net.FtpWebRequest)

            'Insert Item in Listbox
            pStatus(oListBox, "Connecting to the server: " & sFTPHost, My.Resources.connect, Brushes.Blue)

            'Insert Item in Listbox
            pStatus(oListBox, String.Format("Host: {0} - Username: {1} - Password: {2}", sFTPHost, sFTPUserName, "******"), My.Resources.connect, Brushes.DarkBlue)

            'Informs to oFtpWebRequest Object, the WebPermission Credentials
            oFtpWebRequest.Credentials = New System.Net.NetworkCredential(sFTPUserName, sFTPPwd)

            ' The default KeepAlive value is True, but the control connection is not closed after a command is executed.
            oFtpWebRequest.KeepAlive = False

            'Insert Item in Listbox
            pStatus(oListBox, "Starting the connection...", My.Resources.accept, Brushes.Black)

            Application.DoEvents() : Application.DoEvents()

            'Set timeout to oFtpWebRequest Object for 30 seconds or more
            oFtpWebRequest.Timeout = 30000

            'Insert Item in Listbox
            pStatus(oListBox, "Connection accepted...", My.Resources.accept, Brushes.ForestGreen)

            Application.DoEvents() : Application.DoEvents()

            'Insert Item in Listbox
            pStatus(oListBox, "Sending the file: '" & System.IO.Path.GetFileName(sFileName.ToString) & "'", My.Resources.database_lightning, Brushes.Black)
            'Show information about filesize in KB, MB, GB
            'Insert Item in Listbox
            pStatus(oListBox, "Size: '" & ConvertBytes(oFileInfo.Length) & "'", My.Resources.database_lightning, Brushes.Black)

            Application.DoEvents() : Application.DoEvents()

            ' Specify to oFtpWebRequest the command that will be executed.
            oFtpWebRequest.Method = System.Net.WebRequestMethods.Ftp.UploadFile

            ' Specify the data transfer type. The binary is recommended
            oFtpWebRequest.UseBinary = True

            'Use Pasive mode
            oFtpWebRequest.UsePassive = True

            ' Informs the server about the size , in bytes, of the uploaded file
            oFtpWebRequest.ContentLength = oFileInfo.Length

            ' The buffer size is set to 2kb, but you can change to 1024 (more slow) or change to 4096 if your server permits
            Dim buffLength As Integer = 2048
            Dim buff(buffLength - 1) As Byte

            pStatus(oListBox, "Sending the file...", My.Resources.transmit_blue, Brushes.DeepSkyBlue)

            'Opens a file stream (using System.IO.FileStream) to read the file to be uploaded
            Dim oFileStream As System.IO.FileStream = oFileInfo.OpenRead()
            Application.DoEvents() : Application.DoEvents()

            'Stream to which the file to be uploaded is written on the Server Path
            Dim oStream As System.IO.Stream = oFtpWebRequest.GetRequestStream()

            'Read from the file stream 2kb at a time, but if you change the buffer value the size change too
            Dim contentLen As Integer = oFileStream.Read(buff, 0, buffLength)
            Application.DoEvents() : Application.DoEvents()

            oProgressBar.Maximum = oFileInfo.Length
            Application.DoEvents() : Application.DoEvents()
            ' Till Stream content ends
            Do While contentLen <> 0
                ' Write Content from the file stream to the FTP Upload Stream
                oStream.Write(buff, 0, contentLen)
                contentLen = oFileStream.Read(buff, 0, buffLength)
                oProgressBar.Value += contentLen
                Application.DoEvents() : Application.DoEvents()
            Loop

            ' Dispose and Close the file Stream and the Request Stream
            oStream.Close()
            oStream.Dispose()
            oFileStream.Close()
            oFileStream.Dispose()

            'Insert Item in Listbox
            pStatus(oListBox, "Upload successfully!", My.Resources.accept, Brushes.DarkGreen)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Insert Item in Listbox
            pStatus(oListBox, ex.Message, My.Resources.exclamation, Brushes.Red)
        Finally
            'Set zero value to ProgressBar object
            oProgressBar.Value = 0
        End Try
    End Sub
    ''' <summary>
    ''' Displays FTP status, on demand and according to information passed in Sub UploadFile
    ''' </summary>
    ''' <param name="olbox">Listbox control that will receive the text (sText), image (img) and text color lColor</param>
    ''' <param name="sText">Text to be displayed on item inserted in olbox control</param>
    ''' <param name="img">Image (16 x 16 px) to be displayed on item inserted in olbox control</param>
    ''' <param name="lColor">Text Color (ForeColor), which will be set to the text entered in the olbox control item.</param>
    ''' <remarks></remarks>
    Public Sub pStatus(ByRef olbox As ListBox, ByVal sText As String, img As System.Drawing.Bitmap, lColor As System.Drawing.Brush)
        Dim oXref As Xrefs
        oXref = New Xrefs(sText, img, lColor)
        olbox.Items.Add(oXref)
    End Sub
    ''' <summary>
    ''' Converter Filesize of Bytes to KB or MB or GB
    ''' </summary>
    ''' <param name="Bytes">File Size in bytes</param>
    ''' <returns>Return String value</returns>

    Public Function ConvertBytes(ByVal Bytes As Long) As String
        ' Converts bytes into a readable "1.44 MB", etc. string
        If Bytes >= 1073741824 Then 'if filesize higher than 1073741824 bytes convert to GB
            Return Format(Bytes / 1024 / 1024 / 1024, "#0.00") _
                & " GB"
        ElseIf Bytes >= 1048576 Then 'if filesize higher than 1048576 bytes convert to KB
            Return Format(Bytes / 1024 / 1024, "#0.00") & " MB"
        ElseIf Bytes >= 1024 Then
            Return Format(Bytes / 1024, "#0.00") & " KB"
        ElseIf Bytes > 0 And Bytes < 1024 Then 'if filesize minor than 1024 bytes isnot convert
            Return Fix(Bytes) & " Bytes"
        Else
            Return "0 Bytes"
        End If
    End Function
End Module