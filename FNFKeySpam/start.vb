Public Class start

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Process.Start("https://ci.appveyor.com/project/KadeDev/kade-engine-windows/build/artifacts")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        spm.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Application.Exit()

    End Sub

End Class