Public Class Form16
    Public A As Integer = My.Settings.J1
    Public B As Integer = My.Settings.K1
    Public C As Integer = My.Settings.L1
    Public D As Integer = My.Settings.M1
    Dim Z As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            A = A + 1
        ElseIf RadioButton2.Checked = True Then
            B = B + 1
        ElseIf RadioButton4.Checked = True Then
            C = C + 1
        ElseIf RadioButton5.Checked = True Then
            D = D + 1
        End If

        My.Settings.J1 = A
        My.Settings.Save()
        My.Settings.K1 = B
        My.Settings.Save()
        My.Settings.L1 = C
        My.Settings.Save()
        My.Settings.M1 = D
        My.Settings.Save()
        For Me.Z = 1 To 5
            Threading.Thread.Sleep(100)
            Application.DoEvents()
        Next
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        Button1.Visible = True
    End Sub

    Private Sub Form16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub
End Class