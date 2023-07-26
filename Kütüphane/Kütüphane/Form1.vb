Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EkleToolStripMenuItem.Click
        Ekle.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = My.Settings.l2
        Label3.Text = My.Settings.l3
        Label4.Text = My.Settings.l4
        Label5.Text = My.Settings.l5
        Label6.Text = My.Settings.l6
        Label7.Text = My.Settings.l7
        Label8.Text = My.Settings.l8
        Label9.Text = My.Settings.l9
        Label10.Text = My.Settings.l10
        GroupBox1.Hide()


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Label5.ForeColor = Color.White
        Label34.Text = Label5.Text


    End Sub

    Private Sub Label5_DoubleClick(sender As Object, e As EventArgs) Handles Label5.DoubleClick
        Process.Start(My.Settings.p5)

    End Sub
End Class
