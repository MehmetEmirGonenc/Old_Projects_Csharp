Public Class Ekle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        My.Settings.d1 = OpenFileDialog1.FileName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog2.ShowDialog()
        My.Settings.d2 = OpenFileDialog2.FileName
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.d3 = TextBox1.Text
        If My.Settings.s1 = 0 Then
            Form1.Label2.Text = My.Settings.d3
            My.Settings.l2 = My.Settings.d3
            My.Settings.p2 = My.Settings.d1
            My.Settings.r2 = My.Settings.d2
            My.Settings.s1 = My.Settings.s1 + 1
            My.Settings.d1 = ("")
            My.Settings.d2 = ("")
            My.Settings.d3 = ("")

        ElseIf My.Settings.s1 = 1 Then
            Form1.Label3.Text = My.Settings.d3
            My.Settings.l3 = My.Settings.d3
            My.Settings.p3 = My.Settings.d1
            My.Settings.r3 = My.Settings.d2
            My.Settings.s1 = My.Settings.s1 + 1
            My.Settings.d1 = ("")
            My.Settings.d2 = ("")
            My.Settings.d3 = ("")
        ElseIf My.Settings.s1 = 2 Then
            Form1.Label4.Text = My.Settings.d3
            My.Settings.l4 = My.Settings.d3
            My.Settings.p4 = My.Settings.d1
            My.Settings.r4 = My.Settings.d2
            My.Settings.s1 = My.Settings.s1 + 1
            My.Settings.d1 = ("")
            My.Settings.d2 = ("")
            My.Settings.d3 = ("")


        ElseIf My.Settings.s1 = 3 Then
            Form1.Label5.Text = My.Settings.d3
            My.Settings.l5 = My.Settings.d3
            My.Settings.p5 = My.Settings.d1
            My.Settings.r5 = My.Settings.d2
            My.Settings.s1 = My.Settings.s1 + 1
            My.Settings.d1 = ("")
            My.Settings.d2 = ("")
            My.Settings.d3 = ("")
        ElseIf My.Settings.s1 = 4 Then
            Form1.Label6.Text = My.Settings.d3
            My.Settings.l6 = My.Settings.d3
            My.Settings.p6 = My.Settings.d1
            My.Settings.r6 = My.Settings.d2
            My.Settings.s1 = My.Settings.s1 + 1
            My.Settings.d1 = ("")
            My.Settings.d2 = ("")
            My.Settings.d3 = ("")

        ElseIf My.Settings.s1 = 5 Then
            Form1.Label7.Text = My.Settings.d3
            My.Settings.l7 = My.Settings.d3
            My.Settings.p7 = My.Settings.d1
            My.Settings.r7 = My.Settings.d2
            My.Settings.s1 = My.Settings.s1 + 1
            My.Settings.d1 = ("")
            My.Settings.d2 = ("")
            My.Settings.d3 = ("")
        ElseIf My.Settings.s1 = 6 Then
            Form1.Label8.Text = My.Settings.d3
            My.Settings.l8 = My.Settings.d3
            My.Settings.p8 = My.Settings.d1
            My.Settings.r8 = My.Settings.d2
            My.Settings.s1 = My.Settings.s1 + 1
            My.Settings.d1 = ("")
            My.Settings.d2 = ("")
            My.Settings.d3 = ("")

        ElseIf My.Settings.s1 = 7 Then
            Form1.Label9.Text = My.Settings.d3
            My.Settings.l9 = My.Settings.d3
            My.Settings.p9 = My.Settings.d1
            My.Settings.r9 = My.Settings.d2
            My.Settings.s1 = My.Settings.s1 + 1
            My.Settings.d1 = ("")
            My.Settings.d2 = ("")
            My.Settings.d3 = ("")
        ElseIf My.Settings.s1 = 8 Then
            Form1.Label10.Text = My.Settings.d3
            My.Settings.l10 = My.Settings.d3
            My.Settings.p10 = My.Settings.d1
            My.Settings.r10 = My.Settings.d2
            My.Settings.s1 = My.Settings.s1 + 1
            My.Settings.d1 = ("")
            My.Settings.d2 = ("")
            My.Settings.d3 = ("")



        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class