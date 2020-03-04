Public Class Form1
    Private Sub hintbutton_Click(sender As Object, e As EventArgs) Handles hintbutton.Click
        MessageBox.Show("何も入力しない状態でどれかボタンを押すべし。そうすると新機能がわかる",
                "アプリのヒント",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim timer As Timer = New Timer()
        Dim strhour As String
        Dim strminute As String
        Dim strsecond As String

        Dim inthour As Integer
        Dim intminute As Integer
        Dim intsecond As Integer


        ' strhour = TextBox1.Text
        'strminute = TextBox2.Text
        strsecond = TextBox3.Text

        ' inthour = Integer.Parse(strhour)
        'intminute = Integer.Parse(strminute)
        intsecond = Integer.Parse(strsecond)

        intsecond = intsecond * 1000

        timer.Interval = intsecond
        timer.Enabled = True


        Label6.Text = timer.ToString










    End Sub
End Class
