Imports System.Data
Imports System.Data.OleDb

Public Class encode_students

    Dim cancel As Boolean = False
    Dim search As Boolean = False


    Private Sub StudentInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StudentInfoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._LNHS_SHS_SLS_DATABASEDataSet)

    End Sub

    Private Sub encode_students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_LNHS_SHS_SLS_DATABASEDataSet.SectionInfo' table. You can move, or remove it, as needed.
        Me.SectionInfoTableAdapter.Fill(Me._LNHS_SHS_SLS_DATABASEDataSet.SectionInfo)
        'TODO: This line of code loads data into the '_LNHS_SHS_SLS_DATABASEDataSet.StudentInfo' table. You can move, or remove it, as needed.
        Me.StudentInfoTableAdapter.Fill(Me._LNHS_SHS_SLS_DATABASEDataSet.StudentInfo)
        Dim con As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = LNHS-SHS-SLS-DATABASE.accdb")
        Dim cmd As New OleDbCommand("Select * from SectionInfo", con)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        sec_cbox.DataSource = table
        sec_cbox.ValueMember = table.Columns(0).ToString
        sec_cbox.DisplayMember = table.Columns(0).ToString
        Dim x As String = StudentInfoDataGridView.Rows(0).Cells(4).Value
        SectionTextBox.Text = x
        sec_cbox.DropDownStyle = ComboBoxStyle.DropDown
        sec_cbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        sec_cbox.AutoCompleteSource = AutoCompleteSource.ListItems
        For i = 0 To StudentInfoDataGridView.RowCount - 1
            Try
                If StudentInfoDataGridView.Item(6, i).Value.ToString = Nothing Then
                ElseIf StudentInfoDataGridView.Item(6, i).Value.ToString <> "" Then
                    StudentInfoDataGridView.Item(6, i).Value = System.IO.Directory.GetCurrentDirectory + "\images\" + System.IO.Path.GetFileName(StudentInfoDataGridView.Item(6, i).Value.ToString)
                End If
            Catch ex As Exception
            End Try
        Next
        If PhotoIDTextBox.Text <> "" Then
            pht_picbox.ImageLocation = PhotoIDTextBox.Text
        Else
            pht_picbox.ImageLocation = System.IO.Directory.GetCurrentDirectory + "\images\user.png"
        End If
        StudentInfoBindingNavigatorSaveItem.PerformClick()
        StudentInfoBindingNavigator.MoveNextItem.PerformClick()
        If PhotoIDTextBox.Text <> "" Then
            pht_picbox.ImageLocation = PhotoIDTextBox.Text
        Else
            pht_picbox.ImageLocation = System.IO.Directory.GetCurrentDirectory + "\images\user.png"
        End If
        pht_picbox.Refresh()
        StudentInfoBindingNavigator.MovePreviousItem.PerformClick()
        If PhotoIDTextBox.Text <> "" Then
            pht_picbox.ImageLocation = PhotoIDTextBox.Text
        Else
            pht_picbox.ImageLocation = System.IO.Directory.GetCurrentDirectory + "\images\user.png"
        End If
        pht_picbox.Refresh()
        PhotoIDTextBox.Refresh()
        Dim col, col2 As New AutoCompleteStringCollection
        For i = 0 To StudentInfoDataGridView.RowCount - 1
            If StudentInfoDataGridView.Item(1, i).Value = Nothing Then
            Else
                col.Add(StudentInfoDataGridView.Item(1, i).Value.ToString)
            End If
        Next
        For i = 0 To StudentInfoDataGridView.RowCount - 1
            If StudentInfoDataGridView.Item(2, i).Value = Nothing Then
            Else
                col2.Add(StudentInfoDataGridView.Item(2, i).Value.ToString)
            End If
        Next
        fnamesch_txtbox.AutoCompleteCustomSource = col2
        lnamesch_txtbox.AutoCompleteCustomSource = col
        If StudentInfoDataGridView.RowCount - 1 <= 0 Then
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

    Private Sub encode_students_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles prev_btn.Click
        StudentInfoBindingNavigator.MovePreviousItem.PerformClick()
        If PhotoIDTextBox.Text <> "" Then
            pht_picbox.ImageLocation = PhotoIDTextBox.Text
        Else
            pht_picbox.ImageLocation = System.IO.Directory.GetCurrentDirectory + "\images\user.png"
        End If
        pht_picbox.Refresh()
        srch_chkbox.CheckState = CheckState.Unchecked
        search = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles selpht_btn.Click
        OpenFileDialog1.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, System.IO.Directory.GetCurrentDirectory + "\images\" + System.IO.Path.GetFileName(OpenFileDialog1.FileName))
            pht_picbox.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory + "\images\" + System.IO.Path.GetFileName(OpenFileDialog1.FileName))
            PhotoIDTextBox.Text = System.IO.Directory.GetCurrentDirectory + "\images\" + System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        StudentInfoBindingNavigator.MoveNextItem.PerformClick()
        If PhotoIDTextBox.Text <> "" Then
            pht_picbox.ImageLocation = PhotoIDTextBox.Text
        Else
            pht_picbox.ImageLocation = System.IO.Directory.GetCurrentDirectory + "\images\user.png"
        End If
        pht_picbox.Refresh()
        srch_chkbox.CheckState = CheckState.Unchecked
        search = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles new_btn.Click
        pht_picbox.ImageLocation = System.IO.Directory.GetCurrentDirectory + "\images\user.png"
        pht_picbox.Refresh()
        If LRNTextBox.Text = "" And LRNTextBox.Enabled = True And LastNameTextBox.Text = "" And FirstNameTextBox.Text = "" And MiddleNameTextBox.Text = "" And SectionTextBox.Text = "" Then

        Else
            Try
                StudentInfoBindingNavigator.AddNewItem.PerformClick()
            Catch ex As Exception
                MessageBox.Show("LRN is Taken.")
                LRNTextBox.Text = ""
            End Try
            prev_btn.Enabled = False
            next_btn.Enabled = False
            edit_btn.Enabled = False
            selpht_btn.Enabled = True
            new_btn.Enabled = False
            sav_btn.Enabled = True
            del_btn.Text = "Cancel"
            del_btn.Enabled = True
            srch_chkbox.CheckState = CheckState.Unchecked
            search = False
            srch_chkbox.Enabled = False
            LRNTextBox.Enabled = True
            LastNameTextBox.Enabled = True
            FirstNameTextBox.Enabled = True
            LastNameTextBox.Enabled = True
            MiddleNameTextBox.Enabled = True
            SectionTextBox.Enabled = True
            sec_cbox.Visible = True
            sec_cbox.SelectedIndex = -1
            ContactNumberTextBox.Enabled = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
        prev_btn.Enabled = False
        next_btn.Enabled = False
        new_btn.Enabled = False
        selpht_btn.Enabled = True
        edit_btn.Enabled = False
        sav_btn.Enabled = True
        srch_chkbox.Enabled = False
        sec_cbox.SelectedIndex = -1
        LRNTextBox.Enabled = True
        LastNameTextBox.Enabled = True
        FirstNameTextBox.Enabled = True
        LastNameTextBox.Enabled = True
        MiddleNameTextBox.Enabled = True
        SectionTextBox.Enabled = True
        sec_cbox.Visible = True
        ContactNumberTextBox.Enabled = True
        cancel = True
        For i = 0 To SectionInfoDataGridView.RowCount - 1
            If SectionInfoDataGridView.Item(0, i).Value = Nothing Then
            ElseIf StudentInfoDataGridView.Item(4, StudentInfoDataGridView.CurrentCell.RowIndex).Value.ToString = SectionInfoDataGridView.Item(0, i).Value.ToString Then
                sec_cbox.SelectedIndex = i
            End If
        Next
        If search = True Then
            lnamesch_txtbox.Visible = False
            fnamesch_txtbox.Visible = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles sav_btn.Click
        If LRNTextBox.Text.Length = 12 And LastNameTextBox.Text <> "" And FirstNameTextBox.Text <> "" And SectionTextBox.Text <> "" And SectionTextBox.Text = sec_cbox.Text Then
            Dim err As Boolean = False
            Try
                StudentInfoBindingNavigatorSaveItem.PerformClick()
            Catch ex1 As ConstraintException
                MessageBox.Show("The inputted LRN already exists in the database, type a unique LRN.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                err = True
                LRNTextBox.Clear()
            End Try
            If err = False Then
                prev_btn.Enabled = True
                next_btn.Enabled = True
                edit_btn.Enabled = True
                new_btn.Enabled = True
                selpht_btn.Enabled = False
                new_btn.Enabled = True
                sav_btn.Enabled = False
                srch_chkbox.Enabled = True
                del_btn.Text = "Delete"
                LRNTextBox.Enabled = False
                LastNameTextBox.Enabled = False
                FirstNameTextBox.Enabled = False
                LastNameTextBox.Enabled = False
                MiddleNameTextBox.Enabled = False
                SectionTextBox.Enabled = False
                sec_cbox.Visible = False
                ContactNumberTextBox.Enabled = False
                PhotoIDTextBox.Enabled = False
                cancel = False
                lnamesch_txtbox.Clear()
                fnamesch_txtbox.Clear()
                If search = True Then
                    lnamesch_txtbox.Visible = True
                    fnamesch_txtbox.Visible = True
                    prev_btn.Enabled = False
                    next_btn.Enabled = False
                    new_btn.Enabled = False
                    edit_btn.Enabled = False
                End If
            End If
        ElseIf LRNTextBox.Text = "" Then
            MessageBox.Show("Please do not leave the LRN field empty.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf LRNTextBox.Text.Length <> 12 Then
            MessageBox.Show("The LRN input should contain twelve numbers.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf LastNameTextBox.Text = "" Then
            MessageBox.Show("Please do not leave the Last Name field empty.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf FirstNameTextBox.Text = "" Then
            MessageBox.Show("Please do not leave the First Name field empty.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf SectionTextBox.Text = "" Then
            MessageBox.Show("Please select the Section from the available options.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf SectionTextBox.Text <> sec_cbox.Text Then
            MessageBox.Show("Please select a valid Section from the options.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            sec_cbox.Text = SectionTextBox.Text
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
            StudentInfoBindingNavigator.DeleteItem.PerformClick()
            StudentInfoBindingNavigatorSaveItem.PerformClick()
            prev_btn.Enabled = True
            next_btn.Enabled = True
            edit_btn.Enabled = True
            new_btn.Enabled = True
            selpht_btn.Enabled = False
            new_btn.Enabled = True
            sav_btn.Enabled = False
            del_btn.Text = "Delete"
            LRNTextBox.Enabled = False
            LastNameTextBox.Enabled = False
            FirstNameTextBox.Enabled = False
            LastNameTextBox.Enabled = False
            MiddleNameTextBox.Enabled = False
            SectionTextBox.Enabled = False
            sec_cbox.Visible = False
            ContactNumberTextBox.Enabled = False
            PhotoIDTextBox.Enabled = False
            cancel = False
            If StudentInfoDataGridView.RowCount - 1 <= 0 Then
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sec_cbox.SelectedIndexChanged
        SectionTextBox.Text = sec_cbox.Text
    End Sub

    Private Sub LRNTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LRNTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ContactNumberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContactNumberTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub StudentInfoDataGridView_ColumnRemoved(sender As Object, e As DataGridViewColumnEventArgs) Handles StudentInfoDataGridView.ColumnRemoved
        MessageBox.Show(StudentInfoDataGridView.RowCount.ToString)
        If StudentInfoDataGridView.RowCount - 1 < 0 Then

        End If
    End Sub

    Private Sub LastNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LastNameTextBox.KeyPress, lnamesch_txtbox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FirstNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FirstNameTextBox.KeyPress, fnamesch_txtbox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MiddleNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MiddleNameTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub srch_chkbox_CheckedChanged(sender As Object, e As EventArgs) Handles srch_chkbox.CheckedChanged
        If search = False Then
            search = True
            lnamesch_txtbox.Visible = True
            lnamesch_txtbox.Text = "run"
            lnamesch_txtbox.Clear()
            fnamesch_txtbox.Visible = True
            fnamesch_txtbox.Text = "run"
            fnamesch_txtbox.Clear()
            prev_btn.Enabled = False
            next_btn.Enabled = False
            new_btn.Enabled = False
            edit_btn.Enabled = False
            If PhotoIDTextBox.Text <> "" Then
                pht_picbox.ImageLocation = PhotoIDTextBox.Text
            Else
                pht_picbox.ImageLocation = System.IO.Directory.GetCurrentDirectory + "\images\user.png"
            End If
            pht_picbox.Refresh()
        Else
            search = False
            SectionTextBox.Clear()
            lnamesch_txtbox.Visible = False
            fnamesch_txtbox.Visible = False
            prev_btn.Enabled = True
            next_btn.Enabled = True
            new_btn.Enabled = True
            edit_btn.Enabled = True
            lnamesch_txtbox.Clear()
            fnamesch_txtbox.Clear()
            Me.StudentInfoTableAdapter.Fill(Me._LNHS_SHS_SLS_DATABASEDataSet.StudentInfo)
            If StudentInfoDataGridView.RowCount - 1 <= 0 Then
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
            If PhotoIDTextBox.Text <> "" Then
                pht_picbox.ImageLocation = PhotoIDTextBox.Text
            Else
                pht_picbox.ImageLocation = System.IO.Directory.GetCurrentDirectory + "\images\user.png"
            End If
            pht_picbox.Refresh()
        End If
    End Sub

    Private Sub lnamesch_txtbox_TextChanged(sender As Object, e As EventArgs) Handles lnamesch_txtbox.TextChanged
        Me.StudentInfoTableAdapter.FillBy1(Me._LNHS_SHS_SLS_DATABASEDataSet.StudentInfo, lnamesch_txtbox.Text, fnamesch_txtbox.Text)
        If lnamesch_txtbox.Text = LastNameTextBox.Text And fnamesch_txtbox.Text = FirstNameTextBox.Text And lnamesch_txtbox.Text <> "" And fnamesch_txtbox.Text <> "" Then
            edit_btn.Enabled = True
        Else
            edit_btn.Enabled = False
        End If
        If PhotoIDTextBox.Text <> "" Then
            pht_picbox.ImageLocation = PhotoIDTextBox.Text
        Else
            pht_picbox.ImageLocation = System.IO.Directory.GetCurrentDirectory + "\images\user.png"
        End If
        pht_picbox.Refresh()
    End Sub

    Private Sub fnamesch_txtbox_TextChanged(sender As Object, e As EventArgs) Handles fnamesch_txtbox.TextChanged
        Me.StudentInfoTableAdapter.FillBy1(Me._LNHS_SHS_SLS_DATABASEDataSet.StudentInfo, lnamesch_txtbox.Text, fnamesch_txtbox.Text)
        If lnamesch_txtbox.Text = LastNameTextBox.Text And fnamesch_txtbox.Text = FirstNameTextBox.Text Then
            edit_btn.Enabled = True
        Else
            edit_btn.Enabled = False
        End If
        If PhotoIDTextBox.Text <> "" Then
            pht_picbox.ImageLocation = PhotoIDTextBox.Text
        Else
            pht_picbox.ImageLocation = System.IO.Directory.GetCurrentDirectory + "\images\user.png"
        End If
        pht_picbox.Refresh()
    End Sub
End Class