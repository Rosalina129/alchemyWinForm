Public Class NewProgressForm

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        With ComboBox1
            Label3.Text = LangStr.s_theme(.SelectedIndex, MainForm.LangID)
            TextBox1.Text = LangStr.s_theme(.SelectedIndex + 16, MainForm.LangID)
        End With
    End Sub

    Private Sub NewProgressForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub
End Class