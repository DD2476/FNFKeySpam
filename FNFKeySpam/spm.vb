Public Class spm

    Dim pr As Boolean = False

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles prp.Click

        If (pr = False) Then

            pr = True

            Me.WindowState = FormWindowState.Minimized

        ElseIf (pr = True) Then

            pr = False

        End If

    End Sub

    Private Sub clicc_Tick(sender As Object, e As EventArgs) Handles clicc.Tick

        If (pr = True) Then

            My.Computer.Keyboard.SendKeys("{LEFT}")
            My.Computer.Keyboard.SendKeys("{UP}")
            My.Computer.Keyboard.SendKeys("{DOWN}")
            My.Computer.Keyboard.SendKeys("{RIGHT}")

        End If

    End Sub

    Private Sub always_Tick(sender As Object, e As EventArgs) Handles always.Tick

        If (pr = False) Then

            prp.Image = My.Resources.disabled

        ElseIf (pr = True) Then

            prp.Image = My.Resources.enabled

        End If

    End Sub

End Class
