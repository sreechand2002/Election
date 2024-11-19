Public Class Form19
    Public A As Integer = My.Settings.I1
    Public C As Integer = My.Settings.H1
    Dim Z As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            A = A + 1
        End If

        My.Settings.I1 = A
        My.Settings.Save()
        Me.Close()
        'MsgBox("THANKS FOR VOTING" + Environment.NewLine + "THANKS FOR USING A LEGEND'S PRODUCT")
        'For Me.C = 1 To 50
        'Threading.Thread.Sleep(100)
        'Application.DoEvents()
        'Next
        Form9.Show()
    End Sub

    Private Sub Form19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Visible = True
    End Sub
End Class