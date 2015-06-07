Imports System.IO
Imports System.Linq
Imports System.Windows.Forms

Public Class frmMain
    Dim FileName As String = "filename.csv"
    Dim document As New FileHandler
    Dim folder As String

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim di As New DirectoryInfo(folder)

        Try

            Dim intFiles As Integer

            document.FileCreate(FileName)
            If chkSubfolders.Checked AndAlso rdoFile.Checked Then

                document.AllFileDocCreate(di)
                document.AllFilePdfCreate(di)

                document.FileClose()

                ProgressBar1.Maximum = document.CountCSVRecords(FileName)

                Dim intLoop As Integer
                Do Until intLoop = ProgressBar1.Maximum

                    ProgressBar1.Increment(1)
                    intLoop += 1

                Loop

            ElseIf chkSubfolders.Checked AndAlso rdoFilePath.Checked Then

                document.AllFullFileDocCreate(di)
                document.AllFullFilePdfCreate(di)

                document.FileClose()

                ProgressBar1.Maximum = document.CountCSVRecords(FileName)

                Dim intLoop As Integer
                Do Until intLoop = ProgressBar1.Maximum

                    ProgressBar1.Increment(1)
                    intLoop += 1

                Loop

            ElseIf Not chkSubfolders.Checked AndAlso rdoFile.Checked Then

                document.FolderFileDocCreate(di)
                document.FolderFilePdfCreate(di)

                document.FileClose()

                ProgressBar1.Maximum = document.CountCSVRecords(FileName)

                Dim intLoop As Integer
                Do Until intLoop = ProgressBar1.Maximum

                    ProgressBar1.Increment(1)
                    intLoop += 1

                Loop

            ElseIf Not chkSubfolders.Checked AndAlso rdoFilePath.Checked Then

                document.FolderFullFileDocCreate(di)
                document.FolderFullFilePdfCreate(di)

                document.FileClose()

                ProgressBar1.Maximum = document.CountCSVRecords(FileName)

                Dim intLoop As Integer
                Do Until intLoop = ProgressBar1.Maximum

                    ProgressBar1.Increment(1)
                    intLoop += 1

                Loop

            End If
            lstFileContents.DataSource = document.FillCSVListbox(FileName)

            intFiles = ProgressBar1.Maximum
            lblNumberOfFiles.Text = "Number of Entries: " & CStr(intFiles)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
            document.FileClose()
        End Try

    End Sub

    Private Sub BrowseFolders(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim folderBrowser As New FolderBrowserDialog
        If txtFolder.Text = String.Empty Then
            txtFolder.Text = folderBrowser.SelectedPath
            folder = txtFolder.Text

            If folderBrowser.ShowDialog() = DialogResult.OK Then
                txtFolder.Text = folderBrowser.SelectedPath
                folder = folderBrowser.SelectedPath
            End If

        Else
            folderBrowser.SelectedPath = txtFolder.Text
            If folderBrowser.ShowDialog() = DialogResult.OK Then
                txtFolder.Text = folderBrowser.SelectedPath
                folder = folderBrowser.SelectedPath
            End If
        End If

    End Sub

    Private Sub ClearProgressbar(sender As Object, e As EventArgs) Handles rdoFile.CheckedChanged, chkSubfolders.CheckedChanged, btnBrowse.Click

        If ProgressBar1.Maximum <> 0 Then
            ProgressBar1.Maximum = 0
        End If

        lblNumberOfFiles.Text = String.Empty

    End Sub

    Private Sub OpenNotepadPlusPlus(sender As Object, e As EventArgs) Handles btnNotepadPP.Click

        Process.Start("notepad++.exe", "filename.csv")

    End Sub
    Private Sub OpenExcel(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim document As New FileHandler

        Process.Start("EXCEL.EXE", "filename.csv")

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        folder = "Enter starting folder"

        Dim userName = My.User.Name
        lblUser.Text = userName

    End Sub

    Private Sub lstFileContents_DoubleClick(sender As Object, e As EventArgs) Handles lstFileContents.DoubleClick

        Dim intSelectedIndex As Integer = lstFileContents.SelectedIndex
        Dim FullPath As String
        Dim docArray = From file As FileInfo In document.fileDoc
                        Where Not file.FullName.Contains("~") AndAlso Not file.FullName.Contains(".FileSlack")
                        Select file
        Dim PdfArray = From file As FileInfo In document.filePdf
                       Where Not file.FullName.Contains("~") AndAlso Not file.FullName.Contains(".FileSlack")
                       Select file

        Dim joinArrays = docArray.Union(PdfArray).ToArray()

        Dim lstJoined As New List(Of String)
        For Each record As FileInfo In joinArrays
            lstJoined.Add(record.FullName)
        Next

        FullPath = lstJoined(intSelectedIndex)

        Process.Start(FullPath)

    End Sub

End Class