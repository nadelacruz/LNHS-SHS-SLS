Public Class map

    Private Sub map_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub map_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Locate.Visible = True Then
        Else
            main.Show()
        End If
    End Sub
End Class