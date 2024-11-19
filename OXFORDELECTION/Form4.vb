Public Class Form4
    Public A As Integer = My.Settings.F
    Public B As Integer = My.Settings.G
    Public C As Integer = My.Settings.H
    Public D As Integer = My.Settings.FF
    Public F As Integer = My.Settings.GG
    Public G As Integer = My.Settings.HH
    Dim Z As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            A = A + 1
        ElseIf RadioButton4.Checked = True Then
            C = C + 1
        ElseIf RadioButton2.Checked = True Then
            B = B + 1
        ElseIf RadioButton3.Checked = True Then
            D = D + 1
        ElseIf RadioButton5.Checked = True Then
            F = F + 1
        ElseIf RadioButton6.Checked = True Then
            G = G + 1
        End If
        My.Settings.F = A
        My.Settings.Save()
        My.Settings.G = B
        My.Settings.Save()
        My.Settings.H = C
        My.Settings.Save()
        My.Settings.FF = D
        My.Settings.Save()
        My.Settings.GG = F
        My.Settings.Save()
        My.Settings.HH = G
        My.Settings.Save()
        RadioButton1.Checked = False
        RadioButton4.Checked = False
        RadioButton3.Checked = False
        RadioButton2.Checked = False
        RadioButton6.Checked = False
        RadioButton5.Checked = False
        ProgressBar1.Visible = True
        ProgressBar1.PerformStep()
        For Me.Z = 1 To 5
            Threading.Thread.Sleep(100)
            Application.DoEvents()
        Next
        Me.Close()
        Form15.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        Button1.Visible = True
    End Sub
End Class