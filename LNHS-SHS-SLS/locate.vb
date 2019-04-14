Public Class Locate

    Dim chk1 As Boolean = False, chk2 As Boolean = False

    Private Sub Locate_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        main.Show()
    End Sub

    Private Sub StudentInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StudentInfoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._LNHS_SHS_SLS_DATABASEDataSet)
    End Sub

    Private Sub Locate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_LNHS_SHS_SLS_DATABASEDataSet.ScheduleInfo' table. You can move, or remove it, as needed.
        Me.ScheduleInfoTableAdapter.Fill(Me._LNHS_SHS_SLS_DATABASEDataSet.ScheduleInfo)
        'TODO: This line of code loads data into the '_LNHS_SHS_SLS_DATABASEDataSet.SectionInfo' table. You can move, or remove it, as needed.
        Me.SectionInfoTableAdapter.Fill(Me._LNHS_SHS_SLS_DATABASEDataSet.SectionInfo)
        'TODO: This line of code loads data into the '_LNHS_SHS_SLS_DATABASEDataSet.StudentInfo' table. You can move, or remove it, as needed.
        Me.StudentInfoTableAdapter.Fill(Me._LNHS_SHS_SLS_DATABASEDataSet.StudentInfo)
        For i = 0 To StudentInfoDataGridView.RowCount - 1
            Try
                If StudentInfoDataGridView.Item(6, i).Value.ToString = Nothing Then
                ElseIf StudentInfoDataGridView.Item(6, i).Value.ToString <> "" Then
                    StudentInfoDataGridView.Item(6, i).Value = System.IO.Directory.GetCurrentDirectory + "\images\" + System.IO.Path.GetFileName(StudentInfoDataGridView.Item(6, i).Value.ToString)
                End If
            Catch ex As Exception
            End Try
            StudentInfoBindingNavigatorSaveItem.PerformClick()
        Next
        If PhotoIDTextBox.Text <> "" Then
            pht_picbox.ImageLocation = PhotoIDTextBox.Text
        Else
            pht_picbox.ImageLocation = System.IO.Directory.GetCurrentDirectory + "\images\user.png"
        End If
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
        lrnsch_txtbox.Text = "run"
        lrnsch_txtbox.Clear()
        If PhotoIDTextBox.Text <> "" Then
            pht_picbox.ImageLocation = PhotoIDTextBox.Text
        Else
            pht_picbox.ImageLocation = System.IO.Directory.GetCurrentDirectory + "\images\user.png"
        End If
        TextBox4.Text = "run"
        TextBox5.Text = "run"
        TextBox4.Clear()
        TextBox5.Clear()
        
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles lrnsch_txtbox.TextChanged
        Me.StudentInfoTableAdapter.FillBy(Me._LNHS_SHS_SLS_DATABASEDataSet.StudentInfo, lrnsch_txtbox.Text, lnamesch_txtbox.Text, fnamesch_txtbox.Text)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles lnamesch_txtbox.TextChanged
        Me.StudentInfoTableAdapter.FillBy(Me._LNHS_SHS_SLS_DATABASEDataSet.StudentInfo, lrnsch_txtbox.Text, lnamesch_txtbox.Text, fnamesch_txtbox.Text)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles fnamesch_txtbox.TextChanged
        Me.StudentInfoTableAdapter.FillBy(Me._LNHS_SHS_SLS_DATABASEDataSet.StudentInfo, lrnsch_txtbox.Text, lnamesch_txtbox.Text, fnamesch_txtbox.Text)
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Me.SectionInfoTableAdapter.FillBy(Me._LNHS_SHS_SLS_DATABASEDataSet.SectionInfo, TextBox4.Text)
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Me.ScheduleInfoTableAdapter.FillBy(Me._LNHS_SHS_SLS_DATABASEDataSet.ScheduleInfo, TextBox5.Text)
    End Sub

    Private Sub SectionTextBox_TextChanged(sender As Object, e As EventArgs) Handles SectionTextBox.TextChanged
        TextBox4.Text = SectionTextBox.Text
    End Sub

    Private Sub ScheduleIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles ScheduleIDTextBox.TextChanged
        TextBox5.Text = ScheduleIDTextBox.Text
    End Sub

    Private Sub PhotoIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles PhotoIDTextBox.TextChanged
        If PhotoIDTextBox.Text <> "" Then
            pht_picbox.ImageLocation = PhotoIDTextBox.Text
        Else
            pht_picbox.ImageLocation = System.IO.Directory.GetCurrentDirectory + "\images\user.png"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If chk1 = False Or chk1 = False And chk2 = True Then
            CheckBox2.Checked = False
            chk2 = False
            chk1 = True
            lrnsch_txtbox.ReadOnly = False
            fnamesch_txtbox.Clear()
            lnamesch_txtbox.Clear()
        Else
            If chk1 = True Then
                chk1 = False
                lrnsch_txtbox.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If chk2 = False Or chk2 = False And chk1 = True Then
            CheckBox1.Checked = False
            chk1 = False
            chk2 = True
            lnamesch_txtbox.ReadOnly = False
            fnamesch_txtbox.ReadOnly = False
            lrnsch_txtbox.Clear()
        Else
            If chk2 = True Then
                chk2 = False
                lnamesch_txtbox.ReadOnly = True
                fnamesch_txtbox.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        map.Show()
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

    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        Dim msg = MessageBox.Show("Do you want to print this form?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msg = Windows.Forms.DialogResult.Yes Then
            If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                PrintDocument1.DefaultPageSettings.Landscape = True
                PrintDocument1.Print()
            End If
        End If
    End Sub

    Private Sub lrnsch_txtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lrnsch_txtbox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class