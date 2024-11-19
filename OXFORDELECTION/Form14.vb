Public Class Form14

    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
        'School captain boy
        Label1.Text = My.Settings.A
        Label2.Text = My.Settings.B
        Label3.Text = My.Settings.C

        'sports captain girl
        Label4.Text = My.Settings.X
        Label5.Text = My.Settings.W
        Label47.Text = My.Settings.W1

        Label6.Text = My.Settings.D
        Label7.Text = My.Settings.DD
        Label8.Text = My.Settings.E

        Label9.Text = My.Settings.B1
        Label10.Text = My.Settings.A1

        Label11.Text = My.Settings.F
        Label12.Text = My.Settings.G
        Label13.Text = My.Settings.H
        Label14.Text = My.Settings.FF
        Label15.Text = My.Settings.GG
        Label16.Text = My.Settings.HH

        Label17.Text = My.Settings.I
        Label18.Text = My.Settings.J
        Label19.Text = My.Settings.II
        Label20.Text = My.Settings.K
        Label21.Text = My.Settings.L

        Label22.Text = My.Settings.Y
        Label23.Text = My.Settings.Z

        Label24.Text = My.Settings.QQ
        Label48.Text = My.Settings.R
        Label49.Text = My.Settings.Q

        Label25.Text = My.Settings.C1
        Label26.Text = My.Settings.D1
        Label27.Text = My.Settings.E1

        Label28.Text = My.Settings.S
        Label29.Text = My.Settings.SS
        Label30.Text = My.Settings.T
        Label31.Text = My.Settings.U
        Label32.Text = My.Settings.V

        Label33.Text = My.Settings.H1
        Label34.Text = My.Settings.G1
        Label35.Text = My.Settings.F1
        Label50.Text = My.Settings.Z1

        Label36.Text = My.Settings.M1
        Label37.Text = My.Settings.L1
        Label38.Text = My.Settings.K1
        Label39.Text = My.Settings.J1

        Label40.Text = My.Settings.P1
        Label41.Text = My.Settings.O1

        Label42.Text = My.Settings.N
        Label43.Text = My.Settings.NN
        Label44.Text = My.Settings.OO
        Label45.Text = My.Settings.O
        Label46.Text = My.Settings.P
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Settings.Reset()
        Form1.GroupBox1.Visible = False
    End Sub
End Class