Imports System
Imports System.IO
Public Class MainForm

    'Boolean Data
    Dim progress As Boolean
    Dim isHaveSave As Boolean
    'Project Workspace Folder
    Dim IniPathFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\WinFormGame\Alchemy Tech Research"
    Dim IniPathFile As String = IniPathFolder & "\Config.ini"
    Dim SaveFileFolder As String = Environment.CurrentDirectory & "\Saves"
    Public Shared LangID As Byte

    Private Sub MsgShow(Text As String, typ As Integer)
        MsgBox(Text, typ, Me.Text)
    End Sub
    Private Sub CheckDirectory(ByVal DName As String)
        If Not Directory.Exists(DName) Then
            Directory.CreateDirectory(DName)
        End If
    End Sub
    Private Sub DefaultIni()
        If File.Exists(IniPathFile) Then
            Dim a As String = sGetINI(IniPathFile, "Options", "Language", "en_us")
            Select Case a
                Case "en_us"
                    LangID = 0
                Case "zh_cn"
                    LangID = 1
            End Select
        Else
            Dim fs As FileStream
            fs = File.Create(IniPathFile)
            fs.Close()
            writeINI(IniPathFile, "Options", "Language", "en_us")
        End If
    End Sub
    '---Program Start---
    Private Sub FilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilesToolStripMenuItem.Click

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDirectory(IniPathFolder)
        CheckDirectory(SaveFileFolder)
        DefaultIni()
        DefaultIni()
        GameTitlePanel.Location = New Point(0, 27)
    End Sub
    Private Sub NewProgress(sender As Object, e As EventArgs) Handles NewResearchToolStripMenuItem.Click, Button3.Click
        NewProgressForm.ShowDialog()
    End Sub

    Private Sub TimerProgress_Tick(sender As Object, e As EventArgs) Handles TimerProgress.Tick
        If Not isHaveSave Then
            SaveToolStripMenuItem.Enabled = False
            SaveAsToolStripMenuItem.Enabled = False
            GameTitlePanel.Visible = True
            Me.Size = New Point(832, 572)
        Else
            SaveToolStripMenuItem.Enabled = True
            SaveAsToolStripMenuItem.Enabled = True
            GameTitlePanel.Visible = False
            Me.Size = New Point(1020, 705)
        End If
        If progress Then
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
