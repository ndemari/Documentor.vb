<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblNumberOfFiles = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.rdoFilePath = New System.Windows.Forms.RadioButton()
        Me.rdoFile = New System.Windows.Forms.RadioButton()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtFolder = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.chkSubfolders = New System.Windows.Forms.CheckBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstFileContents = New System.Windows.Forms.ListBox()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnNotepadPP = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblNumberOfFiles, Me.lblUser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 551)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(991, 22)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblNumberOfFiles
        '
        Me.lblNumberOfFiles.Name = "lblNumberOfFiles"
        Me.lblNumberOfFiles.Size = New System.Drawing.Size(0, 17)
        '
        'lblUser
        '
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(0, 17)
        '
        'rdoFilePath
        '
        Me.rdoFilePath.AutoSize = True
        Me.rdoFilePath.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFilePath.Location = New System.Drawing.Point(32, 305)
        Me.rdoFilePath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoFilePath.Name = "rdoFilePath"
        Me.rdoFilePath.Size = New System.Drawing.Size(97, 24)
        Me.rdoFilePath.TabIndex = 18
        Me.rdoFilePath.TabStop = True
        Me.rdoFilePath.Text = "File + Path"
        Me.rdoFilePath.UseVisualStyleBackColor = True
        '
        'rdoFile
        '
        Me.rdoFile.AutoSize = True
        Me.rdoFile.Checked = True
        Me.rdoFile.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFile.Location = New System.Drawing.Point(32, 271)
        Me.rdoFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoFile.Name = "rdoFile"
        Me.rdoFile.Size = New System.Drawing.Size(50, 24)
        Me.rdoFile.TabIndex = 17
        Me.rdoFile.TabStop = True
        Me.rdoFile.Text = "File"
        Me.rdoFile.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(32, 110)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(100, 35)
        Me.btnStart.TabIndex = 16
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtFolder
        '
        Me.txtFolder.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolder.Location = New System.Drawing.Point(32, 48)
        Me.txtFolder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFolder.Name = "txtFolder"
        Me.txtFolder.Size = New System.Drawing.Size(196, 27)
        Me.txtFolder.TabIndex = 15
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(251, 44)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(149, 35)
        Me.btnBrowse.TabIndex = 14
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'chkSubfolders
        '
        Me.chkSubfolders.AutoSize = True
        Me.chkSubfolders.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSubfolders.Location = New System.Drawing.Point(32, 225)
        Me.chkSubfolders.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkSubfolders.Name = "chkSubfolders"
        Me.chkSubfolders.Size = New System.Drawing.Size(153, 24)
        Me.chkSubfolders.TabIndex = 13
        Me.chkSubfolders.Text = "Include SubFolders"
        Me.chkSubfolders.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(32, 447)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(900, 32)
        Me.ProgressBar1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(513, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Filenames.csv Contents:"
        '
        'lstFileContents
        '
        Me.lstFileContents.FormattingEnabled = True
        Me.lstFileContents.HorizontalScrollbar = True
        Me.lstFileContents.Location = New System.Drawing.Point(513, 67)
        Me.lstFileContents.Name = "lstFileContents"
        Me.lstFileContents.Size = New System.Drawing.Size(419, 342)
        Me.lstFileContents.TabIndex = 22
        '
        'btnExcel
        '
        Me.btnExcel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.Location = New System.Drawing.Point(251, 185)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(149, 35)
        Me.btnExcel.TabIndex = 21
        Me.btnExcel.Text = "Open Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnNotepadPP
        '
        Me.btnNotepadPP.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotepadPP.Location = New System.Drawing.Point(251, 116)
        Me.btnNotepadPP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNotepadPP.Name = "btnNotepadPP"
        Me.btnNotepadPP.Size = New System.Drawing.Size(149, 35)
        Me.btnNotepadPP.TabIndex = 20
        Me.btnNotepadPP.Text = "Open Notepad++"
        Me.btnNotepadPP.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 573)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.rdoFilePath)
        Me.Controls.Add(Me.rdoFile)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtFolder)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.chkSubfolders)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstFileContents)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnNotepadPP)
        Me.Name = "frmMain"
        Me.Text = "Documentor"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblNumberOfFiles As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents rdoFilePath As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFile As System.Windows.Forms.RadioButton
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents chkSubfolders As System.Windows.Forms.CheckBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstFileContents As System.Windows.Forms.ListBox
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnNotepadPP As System.Windows.Forms.Button
    Friend WithEvents txtFolder As System.Windows.Forms.TextBox

End Class
