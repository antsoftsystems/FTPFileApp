# FTPFileApp
Introduction
When your application needs to send a file to the server via FTP, you don't need a third party DLL, just a module, which allows you to send a file directly to the server on a command line. In this article, we will show how it is possible to upload a file via FTP and upload progress through a ProgressBar and show status progress in ListBox control.

The purpose of this article is to introduce developers to the basic routine of sending files via FTP, but it opens up numerous possibilities for the implementation of new routines, which may even create an FTP application.

Another important issue to be highlighted in this article refers to resources. The project uses five image (icons) in the resource files. These are made available in the source code file.

Requirements
    .NET Framework 4.5 or higher
    System.Windows.Forms
    System.Net
    System.Drawing
