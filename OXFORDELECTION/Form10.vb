Public Class Form10
    Public A As Integer = My.Settings.W
    Public B As Integer = My.Settings.X
    Public C As Integer = My.Settings.W1
    Dim Z As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            A = A + 1
        ElseIf RadioButton3.Checked = True Then
            B = B + 1
        ElseIf RadioButton4.Checked = True Then
            C = C + 1
        End If
        My.Settings.W = A
        My.Settings.Save()
        My.Settings.X = B
        My.Settings.Save()
        My.Settings.W1 = C
        My.Settings.Save()
        
        RadioButton1.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        ProgressBar1.Visible = True
        ProgressBar1.PerformStep()
        For Me.Z = 1 To 2
            Threading.Thread.Sleep(100)
            Application.DoEvents()
        Next
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button1.Visible = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Button1.Visible = True
    End Sub
End Class