Public Class splash

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Label1.Text - 1

        If Label1.Text = 0 Then
            Me.Close()
            main.Show()
        End If
    End Sub
End Class