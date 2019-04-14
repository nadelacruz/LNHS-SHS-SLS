Public Class logn_frm

    Public uname As String
    Public pwd As String

    Private Sub logn_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pwd = "pwd"
    End Sub

    Private Sub clrlogn_btn_Click(sender As Object, e As EventArgs) Handles clrlogn_btn.Click
        uname_txtbox.Clear()
        pwd_txtbox.Clear()
        uname_txtbox.Focus()
    End Sub

    Private Sub logn_btn_Click(sender As Object, e As EventArgs) Handles logn_btn.Click
        If uname_txtbox.Text = "admin" And pwd_txtbox.Text = pwd Then
            MessageBox.Show("Log-in successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            uname = "admin"
            Me.Hide()
            splash.Show()
        ElseIf uname_txtbox.Text = "user" And pwd_txtbox.Text = pwd Then
            MessageBox.Show("Log-in successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            uname = "user"
            Me.Hide()
            splash.Show()

        Else
            MessageBox.Show("Log-in failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub uname_txtbox_KeyDown(sender As Object, e As KeyEventArgs) Handles uname_txtbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            logn_btn_Click(sender, e)
        End If
    End Sub

    Private Sub pwd_txtbox_KeyDown(sender As Object, e As KeyEventArgs) Handles pwd_txtbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            logn_btn_Click(sender, e)
        End If
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        pwd_txtbox.PasswordChar = ""
    End Sub

    Private Sub Button1_MouseCaptureChanged(sender As Object, e As EventArgs) Handles Button1.MouseCaptureChanged
        pwd_txtbox.PasswordChar = "*"
    End Sub
End Class
