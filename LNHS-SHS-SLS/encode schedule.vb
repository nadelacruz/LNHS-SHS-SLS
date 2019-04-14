Imports System.Data.OleDb

Public Class encode_schedule

    Dim search As Boolean = False
    Dim cancel As Boolean = False
    Dim section, sem As String

    Private Sub ScheduleInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ScheduleInfoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ScheduleInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._LNHS_SHS_SLS_DATABASEDataSet)
    End Sub

    Private Sub encode_schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_LNHS_SHS_SLS_DATABASEDataSet.ScheduleInfo' table. You can move, or remove it, as needed.
        Me.ScheduleInfoTableAdapter.Fill(Me._LNHS_SHS_SLS_DATABASEDataSet.ScheduleInfo)
        If ScheduleInfoDataGridView.RowCount - 1 <= 0 Then
            edit_btn.Enabled = False
            del_btn.Enabled = False
            prev_btn.Enabled = False
            next_btn.Enabled = False
        Else
            edit_btn.Enabled = True
            del_btn.Enabled = True
            prev_btn.Enabled = True
            next_btn.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles prev_btn.Click
        ScheduleInfoBindingNavigator.MovePreviousItem.PerformClick()
        srch_chkbox.CheckState = CheckState.Unchecked
        search = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        ScheduleInfoBindingNavigator.MoveNextItem.PerformClick()
        srch_chkbox.CheckState = CheckState.Unchecked
        search = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles new_btn.Click
        If ScheduleIDTextBox.Text = "" And ScheduleIDTextBox.Enabled = True Then

        Else
            SectionTextBox.Clear()
            sem_txtbox.Clear()
            section = ""
            sem = ""
            prev_btn.Enabled = False
            next_btn.Enabled = False
            edit_btn.Enabled = False
            new_btn.Enabled = False
            sav_btn.Enabled = True
            srch_chkbox.CheckState = CheckState.Unchecked
            search = False
            srch_chkbox.Enabled = False
            del_btn.Text = "Cancel"
            del_btn.Enabled = True
            sem_cbox.Visible = True
            Label21.Visible = True
            SectionTextBox.Visible = True
            Label20.Visible = True
            sem_txtbox.Visible = True
            sem_cbox.SelectedIndex = -1
            SubjectOneTextBox.Enabled = True
            SubjectTwoTextBox.Enabled = True
            SubjectThreeTextBox.Enabled = True
            SubjectFourTextBox.Enabled = True
            SubjectFiveTextBox.Enabled = True
            SubjectSixTextBox.Enabled = True
            SubectSevenTextBox.Enabled = True
            SubjectEightTextBox.Enabled = True
            SubjectNineTextBox.Enabled = True
            SubjectTenTextBox.Enabled = True
            TeacherOneTextBox.Enabled = True
            TeacherTwoTextBox.Enabled = True
            TeacherThreeTextBox.Enabled = True
            TeacherFourTextBox.Enabled = True
            TeacherFiveTextBox.Enabled = True
            TeacherSixTextBox.Enabled = True
            TeacherSevenTextBox.Enabled = True
            TeacherEightTextBox.Enabled = True
            TeacherNineTextBox.Enabled = True
            TeacherTenTextBox.Enabled = True
            LocationOneTextBox.Enabled = True
            LocationTwoTextBox.Enabled = True
            LocationThreeTextBox.Enabled = True
            LocationFourTextBox.Enabled = True
            LocationFIveTextBox.Enabled = True
            LocationSixTextBox.Enabled = True
            LocationSevenTextBox.Enabled = True
            LocationEightTextBox.Enabled = True
            LocationNineTextBox.Enabled = True
            LocationTenTextBox.Enabled = True
            ScheduleInfoBindingNavigator.AddNewItem.PerformClick()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
        prev_btn.Enabled = False
        next_btn.Enabled = False
        edit_btn.Enabled = False
        new_btn.Enabled = False
        sav_btn.Enabled = True
        srch_chkbox.Enabled = False
        sem_cbox.SelectedIndex = -1
        SubjectOneTextBox.Enabled = True
        SubjectTwoTextBox.Enabled = True
        SubjectThreeTextBox.Enabled = True
        SubjectFourTextBox.Enabled = True
        SubjectFiveTextBox.Enabled = True
        SubjectSixTextBox.Enabled = True
        SubectSevenTextBox.Enabled = True
        SubjectEightTextBox.Enabled = True
        SubjectNineTextBox.Enabled = True
        SubjectTenTextBox.Enabled = True
        TeacherOneTextBox.Enabled = True
        TeacherTwoTextBox.Enabled = True
        TeacherThreeTextBox.Enabled = True
        TeacherFourTextBox.Enabled = True
        TeacherFiveTextBox.Enabled = True
        TeacherSixTextBox.Enabled = True
        TeacherSevenTextBox.Enabled = True
        TeacherEightTextBox.Enabled = True
        TeacherNineTextBox.Enabled = True
        TeacherTenTextBox.Enabled = True
        LocationOneTextBox.Enabled = True
        LocationTwoTextBox.Enabled = True
        LocationThreeTextBox.Enabled = True
        LocationFourTextBox.Enabled = True
        LocationFIveTextBox.Enabled = True
        LocationSixTextBox.Enabled = True
        LocationSevenTextBox.Enabled = True
        LocationEightTextBox.Enabled = True
        LocationNineTextBox.Enabled = True
        LocationTenTextBox.Enabled = True
        cancel = True
        If search = True Then
            sem_cbox.Visible = False
            Label21.Visible = False
            SectionTextBox.Visible = False
            Label20.Visible = False
            sem_txtbox.Visible = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles sav_btn.Click
        If ScheduleIDTextBox.Text <> "" Then
            Dim err As Boolean = False
            Try
                ScheduleInfoBindingNavigatorSaveItem.PerformClick()
            Catch ex1 As ConstraintException
                MessageBox.Show("The inputted ScheduleID already exists in the database, type a unique ScheduleID.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                err = True
                SectionTextBox.Clear()
                sem_cbox.SelectedIndex = -1
                section = ""
                sem = ""
                sch_txtbox.Clear()
                ScheduleIDTextBox.Clear()
            End Try
            If err = False Then
                prev_btn.Enabled = True
                next_btn.Enabled = True
                edit_btn.Enabled = True
                new_btn.Enabled = True
                sav_btn.Enabled = False
                srch_chkbox.Enabled = True
                del_btn.Text = "Delete"
                sem_cbox.Visible = False
                Label21.Visible = False
                SectionTextBox.Visible = False
                Label20.Visible = False
                sem_txtbox.Visible = False
                SubjectOneTextBox.Enabled = False
                SubjectTwoTextBox.Enabled = False
                SubjectThreeTextBox.Enabled = False
                SubjectFourTextBox.Enabled = False
                SubjectFiveTextBox.Enabled = False
                SubjectSixTextBox.Enabled = False
                SubectSevenTextBox.Enabled = False
                SubjectEightTextBox.Enabled = False
                SubjectNineTextBox.Enabled = False
                SubjectTenTextBox.Enabled = False
                TeacherOneTextBox.Enabled = False
                TeacherTwoTextBox.Enabled = False
                TeacherThreeTextBox.Enabled = False
                TeacherFourTextBox.Enabled = False
                TeacherFiveTextBox.Enabled = False
                TeacherSixTextBox.Enabled = False
                TeacherSevenTextBox.Enabled = False
                TeacherEightTextBox.Enabled = False
                TeacherNineTextBox.Enabled = False
                TeacherTenTextBox.Enabled = False
                LocationOneTextBox.Enabled = False
                LocationTwoTextBox.Enabled = False
                LocationThreeTextBox.Enabled = False
                LocationFourTextBox.Enabled = False
                LocationFIveTextBox.Enabled = False
                LocationSixTextBox.Enabled = False
                LocationSevenTextBox.Enabled = False
                LocationEightTextBox.Enabled = False
                LocationNineTextBox.Enabled = False
                LocationTenTextBox.Enabled = False
                cancel = False
                section = ""
                sem = ""
                sch_txtbox.Clear()
                If search = True Then
                    sem_cbox.Visible = True
                    Label21.Visible = True
                    SectionTextBox.Visible = True
                    Label20.Visible = True
                    sem_txtbox.Visible = True
                    prev_btn.Enabled = False
                    next_btn.Enabled = False
                    new_btn.Enabled = False
                    edit_btn.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles del_btn.Click
        Dim del As String = ""
        If new_btn.Enabled = False And cancel = False Then
            del = "cancel"
        Else
            del = "delete"
        End If
        Dim confirm As String = MessageBox.Show("Are you sure you want to " + del + " this record?", "Confirm", MessageBoxButtons.OKCancel)
        If confirm = MsgBoxResult.Ok Then
            If cancel = False Then
                ScheduleInfoBindingNavigator.DeleteItem.PerformClick()
                Try
                    ScheduleInfoBindingNavigatorSaveItem.PerformClick()
                Catch ex1 As OleDbException
                    MessageBox.Show("Cannot delete the record because it is used in an instance of a section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Me.Close()
                    encode_schedule_redraw.Show()
                    main.Hide()
                End Try
            End If
            prev_btn.Enabled = True
            next_btn.Enabled = True
            edit_btn.Enabled = True
            new_btn.Enabled = True
            sav_btn.Enabled = False
            srch_chkbox.CheckState = CheckState.Unchecked
            search = False
            srch_chkbox.Enabled = True
            del_btn.Text = "Delete"
            sem_cbox.Visible = False
            Label21.Visible = False
            SectionTextBox.Visible = False
            Label20.Visible = False
            sem_txtbox.Visible = False
            SubjectOneTextBox.Enabled = False
            SubjectTwoTextBox.Enabled = False
            SubjectThreeTextBox.Enabled = False
            SubjectFourTextBox.Enabled = False
            SubjectFiveTextBox.Enabled = False
            SubjectSixTextBox.Enabled = False
            SubectSevenTextBox.Enabled = False
            SubjectEightTextBox.Enabled = False
            SubjectNineTextBox.Enabled = False
            SubjectTenTextBox.Enabled = False
            TeacherOneTextBox.Enabled = False
            TeacherTwoTextBox.Enabled = False
            TeacherThreeTextBox.Enabled = False
            TeacherFourTextBox.Enabled = False
            TeacherFiveTextBox.Enabled = False
            TeacherSixTextBox.Enabled = False
            TeacherSevenTextBox.Enabled = False
            TeacherEightTextBox.Enabled = False
            TeacherNineTextBox.Enabled = False
            TeacherTenTextBox.Enabled = False
            LocationOneTextBox.Enabled = False
            LocationTwoTextBox.Enabled = False
            LocationThreeTextBox.Enabled = False
            LocationFourTextBox.Enabled = False
            LocationFIveTextBox.Enabled = False
            LocationSixTextBox.Enabled = False
            LocationSevenTextBox.Enabled = False
            LocationEightTextBox.Enabled = False
            LocationNineTextBox.Enabled = False
            LocationTenTextBox.Enabled = False
            cancel = False
            If ScheduleInfoDataGridView.RowCount - 1 <= 0 Then
                edit_btn.Enabled = False
                del_btn.Enabled = False
                prev_btn.Enabled = False
                next_btn.Enabled = False
            Else
                edit_btn.Enabled = True
                del_btn.Enabled = True
                prev_btn.Enabled = True
                next_btn.Enabled = True
            End If
        End If
    End Sub

    Private Sub encode_schedule_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        main.Show()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sem_cbox.SelectedIndexChanged
        sem_txtbox.Text = sem_cbox.Text
    End Sub


    Private Sub SectionTextBox_TextChanged(sender As Object, e As EventArgs) Handles SectionTextBox.TextChanged
        If SectionTextBox.Text <> "" Then
            section = SectionTextBox.Text
        End If
        If search = False Then
            If section <> "" And sem <> "" Then
                ScheduleIDTextBox.Text = section + sem
            End If
        Else
            If section <> "" And sem <> "" Then
                sch_txtbox.Text = section + sem
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles sem_txtbox.TextChanged
        If sem_txtbox.Text <> "" Then
            sem = sem_txtbox.Text(0)
        End If
        If search = False Then
            If section <> "" And sem <> "" Then
                ScheduleIDTextBox.Text = section + sem
            End If
        Else
            If section <> "" And sem <> "" Then
                sch_txtbox.Text = section + sem
            End If
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim myImage As New Bitmap(Me.Width, Me.Height)
        Dim PrintSize As Size = e.MarginBounds.Size
        Dim scale As Double = 1
        Me.DrawToBitmap(myImage, New Rectangle(Point.Empty, Me.Size))
        PrintSize.Width *= 0.96
        PrintSize.Height *= 0.96
        If myImage.Width > PrintSize.Width Then
            scale = PrintSize.Width / myImage.Width
            e.Graphics.ScaleTransform(scale, scale)
        End If
        If (myImage.Height * scale) > PrintSize.Height Then
            scale = PrintSize.Height / (myImage.Height * scale)
            e.Graphics.ScaleTransform(scale, scale)
        End If
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        e.Graphics.DrawImage(myImage, e.MarginBounds.Location)
        myImage.Dispose()
    End Sub

    'Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
    'Dim msg = MessageBox.Show("Do you want to print this form?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '  If msg = Windows.Forms.DialogResult.Yes Then
    '      If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
    '          PrintDocument1.DefaultPageSettings.Landscape = True
    '          PrintDocument1.Print()
    '       End If
    '     End If
    ' End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles srch_chkbox.CheckedChanged
        If search = False Then
            search = True
            sch_txtbox.Visible = True
            sch_txtbox.Text = "run"
            sch_txtbox.Clear()
            SectionTextBox.Clear()
            sem_txtbox.Clear()
            section = ""
            sem = ""
            sch_txtbox.Clear()
            sem_cbox.SelectedIndex = -1
            sem_cbox.Visible = True
            Label21.Visible = True
            SectionTextBox.Visible = True
            Label20.Visible = True
            sem_txtbox.Visible = True
            prev_btn.Enabled = False
            next_btn.Enabled = False
            new_btn.Enabled = False
            edit_btn.Enabled = False
        Else
            search = False
            SectionTextBox.Clear()
            sem_txtbox.Clear()
            sch_txtbox.Visible = False
            sem_cbox.Visible = False
            Label21.Visible = False
            SectionTextBox.Visible = False
            Label20.Visible = False
            sem_txtbox.Visible = False
            prev_btn.Enabled = True
            next_btn.Enabled = True
            new_btn.Enabled = True
            edit_btn.Enabled = True
            sch_txtbox.Clear()
            Me.ScheduleInfoTableAdapter.Fill(Me._LNHS_SHS_SLS_DATABASEDataSet.ScheduleInfo)
            If ScheduleInfoDataGridView.RowCount - 1 <= 0 Then
                edit_btn.Enabled = False
                del_btn.Enabled = False
                prev_btn.Enabled = False
                next_btn.Enabled = False
            Else
                edit_btn.Enabled = True
                del_btn.Enabled = True
                prev_btn.Enabled = True
                next_btn.Enabled = True
            End If
        End If
    End Sub

    Private Sub sch_txtbox_TextChanged(sender As Object, e As EventArgs) Handles sch_txtbox.TextChanged
        Me.ScheduleInfoTableAdapter.FillBy(Me._LNHS_SHS_SLS_DATABASEDataSet.ScheduleInfo, sch_txtbox.Text)
        If sch_txtbox.Text = ScheduleIDTextBox.Text Then
            edit_btn.Enabled = True
        Else
            edit_btn.Enabled = False
        End If
    End Sub


    Private Sub TeacherOneTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TeacherTwoTextBox.KeyPress, TeacherThreeTextBox.KeyPress, TeacherTenTextBox.KeyPress, TeacherSixTextBox.KeyPress, TeacherSevenTextBox.KeyPress, TeacherOneTextBox.KeyPress, TeacherNineTextBox.KeyPress, TeacherFourTextBox.KeyPress, TeacherFiveTextBox.KeyPress, TeacherEightTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubjectOneTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubjectTwoTextBox.KeyPress, SubjectThreeTextBox.KeyPress, SubjectTenTextBox.KeyPress, SubjectSixTextBox.KeyPress, SubjectOneTextBox.KeyPress, SubjectNineTextBox.KeyPress, SubjectFourTextBox.KeyPress, SubjectFiveTextBox.KeyPress, SubjectEightTextBox.KeyPress, SubectSevenTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SectionTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SectionTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class