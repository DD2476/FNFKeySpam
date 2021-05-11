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

    Private Sub clicc_Tick(sender As Object, e As EventArgs) Handles left.Tick

        If (pr = True) Then

            My.Computer.Keyboard.SendKeys("{LEFT}")

        End If

    End Sub

    Private Sub always_Tick(sender As Object, e As EventArgs) Handles always.Tick

        If (pr = False) Then

            prp.Image = My.Resources.disabled

        ElseIf (pr = True) Then

            prp.Image = My.Resources.enabled

        End If

    End Sub

    Private Sub down_Tick(sender As Object, e As EventArgs) Handles down.Tick

        If (pr = True) Then

            My.Computer.Keyboard.SendKeys("{DOWN}")

        End If

    End Sub

    Private Sub up_Tick(sender As Object, e As EventArgs) Handles up.Tick

        If (pr = True) Then

            My.Computer.Keyboard.SendKeys("{UP}")

        End If

    End Sub

    Private Sub right_Tick(sender As Object, e As EventArgs) Handles right.Tick

        If (pr = True) Then

            My.Computer.Keyboard.SendKeys("{RIGHT}")

        End If

    End Sub

End Class
