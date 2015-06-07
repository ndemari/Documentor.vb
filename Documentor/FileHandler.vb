Imports System.IO
Imports System.Linq

Public Class FileHandler

    Private Property outFile As StreamWriter
    Private Property inFile As StreamReader
    Public Property fileDoc As New List(Of FileInfo)
    Public Property filePdf As New List(Of FileInfo)
    Public Property filePath As String

    Public Sub FileCreate(ByVal fileName As String)

        outFile = File.AppendText(fileName)

    End Sub

    Public Sub FileClose()

        outFile.Close()

    End Sub

    Public Sub CloseinFile()

        inFile.Close()

    End Sub

    Public Sub AllFileDocCreate(ByVal directory As DirectoryInfo)

        For Each docFile In directory.EnumerateFiles("*.doc*", SearchOption.AllDirectories)
            If Not docFile.Name.Contains("~") AndAlso Not docFile.FullName.Contains(".FileSlack") Then
                outFile.Write(docFile.Name & ",")
                outFile.Write(docFile.CreationTime.ToString)
                outFile.WriteLine()
                fileDoc.Add(docFile)
            End If
        Next

    End Sub

    Public Sub AllFilePdfCreate(ByVal directory As DirectoryInfo)

        For Each pdfDoc In directory.EnumerateFiles("*.pdf", SearchOption.AllDirectories)
            If Not pdfDoc.Name.Contains("~") AndAlso Not pdfDoc.FullName.Contains(".FileSlack") Then
                outFile.Write(pdfDoc.Name & ",")
                outFile.Write(pdfDoc.CreationTime.ToString)
                outFile.WriteLine()
                filePdf.Add(pdfDoc)
            End If
        Next

    End Sub

    Public Sub FolderFileDocCreate(ByVal directory As DirectoryInfo)

        For Each docFile In directory.EnumerateFiles("*.doc*")
            If Not docFile.Name.Contains("~") AndAlso Not docFile.FullName.Contains(".FileSlack") Then
                outFile.Write(docFile.Name & ",")
                outFile.Write(docFile.CreationTime.ToString)
                outFile.WriteLine()
                fileDoc.Add(docFile)
            End If
        Next

    End Sub

    Public Sub FolderFilePdfCreate(ByVal directory As DirectoryInfo)

        For Each pdfDoc In directory.EnumerateFiles("*.pdf")
            If Not pdfDoc.Name.Contains("~") AndAlso Not pdfDoc.FullName.Contains(".FileSlack") Then
                outFile.Write(pdfDoc.Name & ",")
                outFile.Write(pdfDoc.CreationTime.ToString)
                outFile.WriteLine()
                filePdf.Add(pdfDoc)
            End If
        Next

    End Sub

    Public Sub AllFullFileDocCreate(ByVal directory As DirectoryInfo)

        For Each docFile In directory.EnumerateFiles("*.doc*", SearchOption.AllDirectories)
            If Not docFile.Name.Contains("~") AndAlso Not docFile.FullName.Contains(".FileSlack") Then
                outFile.Write(docFile.FullName & ",")
                outFile.Write(docFile.CreationTime.ToString)
                outFile.WriteLine()
                fileDoc.Add(docFile)
            End If
        Next

    End Sub

    Public Sub AllFullFilePdfCreate(ByVal directory As DirectoryInfo)

        For Each pdfDoc In directory.EnumerateFiles("*.pdf", SearchOption.AllDirectories)
            If Not pdfDoc.Name.Contains("~") AndAlso Not pdfDoc.FullName.Contains(".FileSlack") Then
                outFile.Write(pdfDoc.FullName & ",")
                outFile.Write(pdfDoc.CreationTime.ToString)
                outFile.WriteLine()
            End If
        Next

    End Sub

    Public Sub FolderFullFileDocCreate(ByVal directory As DirectoryInfo)

        For Each docFile In directory.EnumerateFiles("*.doc*")
            If Not docFile.Name.Contains("~") AndAlso Not docFile.FullName.Contains(".FileSlack") Then
                outFile.Write(docFile.FullName & ",")
                outFile.Write(docFile.CreationTime.ToString)
                outFile.WriteLine()
                fileDoc.Add(docFile)
            End If
        Next

    End Sub

    Public Sub FolderFullFilePdfCreate(ByVal directory As DirectoryInfo)

        For Each pdfDoc In directory.EnumerateFiles("*.pdf")
            If Not pdfDoc.Name.Contains("~") AndAlso Not pdfDoc.FullName.Contains(".FileSlack") Then
                outFile.Write(pdfDoc.FullName & ",")
                outFile.Write(pdfDoc.CreationTime.ToString)
                outFile.WriteLine()
            End If
        Next

    End Sub

    Public Function CountCSVRecords(ByVal fileName As String) As Integer

        Dim intCount As Integer

        If File.Exists(fileName) Then
            inFile = File.OpenText(fileName)
            Dim strFile As String
            Do Until inFile.Peek = -1
                strFile = inFile.ReadLine
                intCount += 1
            Loop
            inFile.Close()
        Else
            MessageBox.Show("File does not exist")
        End If

        Return intCount

    End Function

    Public Function FillCSVListbox(ByVal fileName) As List(Of String)

        FillCSVListbox = New List(Of String)
        If File.Exists(fileName) Then
            inFile = File.OpenText(fileName)
            Do Until inFile.Peek = -1
                Dim strIndexOf As String = inFile.ReadLine
                Dim intIndex As Integer = strIndexOf.IndexOf(",")
                Dim strFileName As String = strIndexOf.Substring(0, intIndex)

                FillCSVListbox.Add(strFileName)
            Loop
            inFile.Close()
        Else
            MessageBox.Show("File does not exist")
        End If

        Return FillCSVListbox

    End Function

End Class