Public Class main

    Private Sub main_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit application?", "SHS-SLS Student Locator System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            splash.Show()
        ElseIf result = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub lctstud_btn_Click(sender As Object, e As EventArgs) Handles lctstud_btn.Click
        Me.Hide()
        Locate.Show()
    End Sub

    Private Sub shwmap_btn_Click(sender As Object, e As EventArgs) Handles shwmap_btn.Click
        Me.Hide()
        map.Show()
    End Sub

    Private Sub abt_btn_Click(sender As Object, e As EventArgs) Handles abt_btn.Click
        Me.Hide()
        about.Show()
    End Sub

    Private Sub ecdstud_btn_Click(sender As Object, e As EventArgs) Handles ecdstud_btn.Click
        Me.Hide()
        encode_students.Show()
    End Sub

    Private Sub ecdsec_btn_Click(sender As Object, e As EventArgs) Handles ecdsec_btn.Click
        Me.Hide()
        encode_section.Show()
    End Sub

    Private Sub ecdschd_btn_Click(sender As Object, e As EventArgs) Handles ecdschd_btn.Click
        Me.Hide()
        encode_schedule.Show()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If logn_frm.uname = "admin" Then
        ElseIf logn_frm.uname = "user" Then
            ecdschd_btn.Visible = False
            ecdsec_btn.Visible = False
            ecdstud_btn.Visible = False
        End If
    End Sub

End Class