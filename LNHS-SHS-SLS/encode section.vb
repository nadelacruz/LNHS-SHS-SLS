Imports System.Data
Imports System.Data.OleDb

Public Class encode_section

    Dim cancel As Boolean = False
    Dim search As Boolean = False

    Private Sub SectionInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SectionInfoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SectionInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._LNHS_SHS_SLS_DATABASEDataSet)
    End Sub

    Dim bool As Boolean = False

    Private Sub encode_section_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_LNHS_SHS_SLS_DATABASEDataSet.ScheduleInfo' table. You can move, or remove it, as needed.
        Me.ScheduleInfoTableAdapter.Fill(Me._LNHS_SHS_SLS_DATABASEDataSet.ScheduleInfo)
        'TODO: This line of code loads data into the '_LNHS_SHS_SLS_DATABASEDataSet.SectionInfo' table. You can move, or remove it, as needed.
        Me.SectionInfoTableAdapter.Fill(Me._LNHS_SHS_SLS_DATABASEDataSet.SectionInfo)
        Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = LNHS-SHS-SLS-DATABASE.accdb")
        Dim cmd As New OleDbCommand("Select * from ScheduleInfo", con)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        schedid_cbox.DataSource = table
        schedid_cbox.DisplayMember = "ScheduleID"
        bool = True
        Dim x As String = SectionInfoDataGridView.Rows(0).Cells(5).Value
        ScheduleIDTextBox.Text = x
        schedid_cbox.DropDownStyle = ComboBoxStyle.DropDown
        schedid_cbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        schedid_cbox.AutoCompleteSource = AutoCompleteSource.ListItems
        If SectionInfoDataGridView.RowCount - 1 <= 0 Then
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

    Private Sub encode_section_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles prev_btn.Click
        SectionInfoBindingNavigator.MovePreviousItem.PerformClick()
        srch_chkbox.CheckState = CheckState.Unchecked
        search = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        SectionInfoBindingNavigator.MoveNextItem.PerformClick()
        srch_chkbox.CheckState = CheckState.Unchecked
        search = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles new_btn.Click
        If SectionTextBox.Text = "" And SectionTextBox.Enabled = True And ScheduleIDTextBox.Text = "" And GradeLevelTextBox.Text = "" And StrandTextBox.Text = "" Then
        Else
            SectionInfoBindingNavigator.AddNewItem.PerformClick()
            prev_btn.Enabled = False
            next_btn.Enabled = False
            edit_btn.Enabled = False
            new_btn.Enabled = False
            sav_btn.Enabled = True
            del_btn.Text = "Cancel"
            del_btn.Enabled = True
            srch_chkbox.CheckState = CheckState.Unchecked
            srch_chkbox.Enabled = False
            search = False
            schedid_cbox.Visible = True
            strand_cbox.Visible = True
            track_cbox.Visible = True
            glevel_cbox.Visible = True
            schedid_cbox.SelectedIndex = -1
            strand_cbox.SelectedIndex = -1
            track_cbox.SelectedIndex = -1
            glevel_cbox.SelectedIndex = -1
            SectionTextBox.Enabled = True
            SectionAdviserTextBox.Enabled = True
            GradeLevelTextBox.Enabled = True
            TrackTextBox.Enabled = True
            StrandTextBox.Enabled = True
            ScheduleIDTextBox.Enabled = True
            schedid_cbox.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
        cancel = True
        prev_btn.Enabled = False
        next_btn.Enabled = False
        edit_btn.Enabled = False
        new_btn.Enabled = False
        sav_btn.Enabled = True
        srch_chkbox.Enabled = False
        schedid_cbox.Visible = True
        strand_cbox.Visible = True
        track_cbox.Visible = True
        glevel_cbox.Visible = True
        schedid_cbox.SelectedIndex = -1
        strand_cbox.SelectedIndex = -1
        track_cbox.SelectedIndex = -1
        glevel_cbox.SelectedIndex = -1
        SectionTextBox.Enabled = True
        SectionAdviserTextBox.Enabled = True
        GradeLevelTextBox.Enabled = True
        TrackTextBox.Enabled = True
        StrandTextBox.Enabled = True
        ScheduleIDTextBox.Enabled = True
        schedid_cbox.Enabled = True
        For i = 0 To glevel_cbox.Items.Count - 1
            If GradeLevelTextBox.Text = glevel_cbox.Items(i).ToString Then
                glevel_cbox.SelectedIndex = i
            End If
        Next
        For i = 0 To track_cbox.Items.Count - 1
            If TrackTextBox.Text = track_cbox.Items(i).ToString Then
                track_cbox.SelectedIndex = i
            End If
        Next
        For i = 0 To strand_cbox.Items.Count - 1
            If SectionInfoDataGridView.Item(4, SectionInfoDataGridView.CurrentCell.RowIndex).Value.ToString = strand_cbox.Items(i).ToString Then
                strand_cbox.SelectedIndex = i
            End If
        Next
        For i = 0 To ScheduleInfoDataGridView.RowCount - 1
            If ScheduleInfoDataGridView.Item(30, i).Value = Nothing Then
            ElseIf ScheduleIDTextBox.Text = ScheduleInfoDataGridView.Item(30, i).Value.ToString Then
                schedid_cbox.SelectedIndex = i
            End If
        Next
        If search = True Then
            SectionTextBox.Visible = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles sav_btn.Click
        If SectionTextBox.Text <> "" And SectionAdviserTextBox.Text <> "" And ScheduleIDTextBox.Text <> "" And GradeLevelTextBox.Text <> "" And StrandTextBox.Text <> "" And ScheduleIDTextBox.Text = schedid_cbox.Text Then
            Dim err As Boolean = False
            Try
                SectionInfoBindingNavigatorSaveItem.PerformClick()
            Catch ex1 As ConstraintException
                MessageBox.Show("The inputted section already exists in the database, type a unique section.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                err = True
                SectionTextBox.Clear()
            Catch ex2 As OleDbException
                MessageBox.Show("The Schedule ID inputted already exists in a different section, pick another ScheduleID.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                err = True
                ScheduleIDTextBox.Clear()
                schedid_cbox.SelectedIndex = -1
            End Try
            If err = False Then
                prev_btn.Enabled = True
                next_btn.Enabled = True
                edit_btn.Enabled = True
                new_btn.Enabled = True
                sav_btn.Enabled = False
                srch_chkbox.Enabled = True
                del_btn.Text = "Delete"
                schedid_cbox.Visible = False
                strand_cbox.Visible = False
                track_cbox.Visible = False
                glevel_cbox.Visible = False
                SectionTextBox.Enabled = False
                SectionAdviserTextBox.Enabled = False
                GradeLevelTextBox.Enabled = False
                TrackTextBox.Enabled = False
                StrandTextBox.Enabled = False
                ScheduleIDTextBox.Enabled = False
                cancel = False
                sch_txtbox.Clear()
            End If
        ElseIf SectionTextBox.Text = "" Then
            MessageBox.Show("Please do not leave the Section field empty.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf SectionAdviserTextBox.Text = "" Then
            MessageBox.Show("Please do not leave the Section Adviser field empty.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf GradeLevelTextBox.Text = "" Then
            MessageBox.Show("Please do not leave the Grade Level selection empty.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf TrackTextBox.Text = "" Then
            MessageBox.Show("Please do not leave the Track selection empty.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf StrandTextBox.Text = "" Then
            MessageBox.Show("Please do not leave the Strand selection empty.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf ScheduleIDTextBox.Text = "" Then
            MessageBox.Show("Please select a valid ScheduleID from the options.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            schedid_cbox.Text = ""
        ElseIf ScheduleIDTextBox.Text <> schedid_cbox.Text Then
            MessageBox.Show("Please select ScheduleID from the available options.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            schedid_cbox.Text = ScheduleIDTextBox.Text
        End If
        If search = True Then
            SectionTextBox.Visible = True
            prev_btn.Enabled = False
            next_btn.Enabled = False
            new_btn.Enabled = False
            edit_btn.Enabled = False
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles track_cbox.SelectedIndexChanged
        If track_cbox.Text = "Academic" Then
            strand_cbox.Items.Clear()
            strand_cbox.Items.Add("ABM")
            strand_cbox.Items.Add("GA")
            strand_cbox.Items.Add("HUMMS")
            strand_cbox.Items.Add("STEM")
        ElseIf track_cbox.Text = "Technical Vocational Livelihood" Then
            strand_cbox.Items.Clear()
            strand_cbox.Items.Add("HE")
            strand_cbox.Items.Add("ICT")
        End If
        If cancel = True And track_cbox.SelectedIndex = -1 Then
        Else
            TrackTextBox.Text = track_cbox.Text
            StrandTextBox.Text = strand_cbox.Text
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles glevel_cbox.SelectedIndexChanged
        If cancel = True And glevel_cbox.SelectedIndex = -1 Then
        Else
            GradeLevelTextBox.Text = glevel_cbox.Text
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles strand_cbox.SelectedIndexChanged
        If cancel = True And strand_cbox.SelectedIndex = -1 Then
        Else
            StrandTextBox.Text = strand_cbox.Text
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
            SectionInfoBindingNavigator.DeleteItem.PerformClick()
            SectionInfoBindingNavigatorSaveItem.PerformClick()
            prev_btn.Enabled = True
            next_btn.Enabled = True
            edit_btn.Enabled = True
            new_btn.Enabled = True
            sav_btn.Enabled = False
            del_btn.Text = "Delete"
            schedid_cbox.Visible = False
            strand_cbox.Visible = False
            track_cbox.Visible = False
            glevel_cbox.Visible = False
            SectionTextBox.Enabled = False
            SectionAdviserTextBox.Enabled = False
            GradeLevelTextBox.Enabled = False
            TrackTextBox.Enabled = False
            StrandTextBox.Enabled = False
            ScheduleIDTextBox.Enabled = False
            cancel = False
            If SectionInfoDataGridView.RowCount - 1 <= 0 Then
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles schedid_cbox.SelectedIndexChanged
        If bool = False Then
            If cancel = True And schedid_cbox.SelectedIndex = -1 Then
            Else
                ScheduleIDTextBox.Text = schedid_cbox.Text
            End If
        ElseIf bool = True Then
            bool = False
        End If
    End Sub

    Private Sub SectionTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SectionTextBox.KeyPress, sch_txtbox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SectionAdviserTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SectionAdviserTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub sch_txtbox_TextChanged(sender As Object, e As EventArgs) Handles sch_txtbox.TextChanged
        Me.SectionInfoTableAdapter.FillBy(Me._LNHS_SHS_SLS_DATABASEDataSet.SectionInfo, sch_txtbox.Text)
        If sch_txtbox.Text = SectionTextBox.Text And sch_txtbox.Text <> "" Then
            edit_btn.Enabled = True
        Else
            edit_btn.Enabled = False
        End If
    End Sub

    Private Sub srch_chkbox_CheckedChanged(sender As Object, e As EventArgs) Handles srch_chkbox.CheckedChanged
        If search = False Then
            search = True
            sch_txtbox.Visible = True
            sch_txtbox.Text = "run"
            sch_txtbox.Clear()
            SectionTextBox.Clear()
            prev_btn.Enabled = False
            next_btn.Enabled = False
            new_btn.Enabled = False
            edit_btn.Enabled = False
        Else
            search = False
            SectionTextBox.Clear()
            sch_txtbox.Visible = False
            prev_btn.Enabled = True
            next_btn.Enabled = True
            new_btn.Enabled = True
            edit_btn.Enabled = True
            sch_txtbox.Clear()
            Me.SectionInfoTableAdapter.Fill(Me._LNHS_SHS_SLS_DATABASEDataSet.SectionInfo)
            If SectionInfoDataGridView.RowCount - 1 <= 0 Then
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
End Class