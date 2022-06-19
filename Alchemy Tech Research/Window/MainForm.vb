Imports System
Imports System.IO
Public Class MainForm

    'Boolean Data
    Dim progress As Boolean
    Dim isHaveSave As Boolean

    Dim AnimationFrame As UInteger

    'Project Workspace Folder
    Dim IniPathFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\WinFormGame\Alchemy Tech Research"
    Dim SaveFileFolder As String = Environment.CurrentDirectory & "\Saves"

    Private Sub MsgShow(Text As String, typ As Integer)
        MsgBox(Text, typ, Me.Text)
    End Sub
    Private Sub CheckDirectory(ByVal DName As String)
        If Not Directory.Exists(DName) Then
            Directory.CreateDirectory(DName)
        End If
    End Sub
    Private Sub DefaultIni()
        If File.Exists(IniPathFolder & "\Config.ini") Then
        Else
            Dim fs As FileStream
            fs = File.Create(IniPathFolder & "\Config.ini")
            fs.Close()
            writeINI(IniPathFolder & "\Config.ini", "Options", "Language", "en_us")
        End If
    End Sub
    '---Program Start---
    Private Sub FilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilesToolStripMenuItem.Click

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDirectory(IniPathFolder)
        CheckDirectory(SaveFileFolder)
        DefaultIni()
        GameTitlePanel.Location = New Point(0, 27)
        Me.Size = New Point(832, 572)
    End Sub
    Private Sub NewProgress(sender As Object, e As EventArgs) Handles NewResearchToolStripMenuItem.Click, Button3.Click
        Me.Size = New Point(1020, 705)
        isHaveSave = True
    End Sub

    Private Sub TimerProgress_Tick(sender As Object, e As EventArgs) Handles TimerProgress.Tick
        If Not isHaveSave Then
            LoadToolStripMenuItem.Enabled = False
            SaveToolStripMenuItem.Enabled = False
            SaveAsToolStripMenuItem.Enabled = False
            GameTitlePanel.Visible = True
        Else
            LoadToolStripMenuItem.Enabled = False
            SaveToolStripMenuItem.Enabled = False
            SaveAsToolStripMenuItem.Enabled = False
            GameTitlePanel.Visible = False
        End If
        If progress Then
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
