Public Class ChapterForm
    Public id As Integer

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        On Error GoTo xxx
        If SearchTextBox.Text = "" Then
            FillListView(ChListView, "select * from CSChView")
        Else
            Select Case SearchComboBox.Text
                Case "Course"
                    FillListView(ChListView, "Select * from CSChView where CourseName like '%" & SearchTextBox.Text & "%'")
                Case "Subject"
                    FillListView(ChListView, "Select * from CSChView where SName like '%" & SearchTextBox.Text & "%'")
                Case "ChapterNo"
                    FillListView(ChListView, "Select * from CSChView where ChapterNo like '%" & SearchTextBox.Text & "%'")
                Case "Chapter"
                    FillListView(ChListView, "Select * from CSChView where Chapter like '%" & SearchTextBox.Text & "%'")
            End Select
        End If
xxx:
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Dim sql As String
        If SaveButton.Text = "Save" Then
            sql = String.Format("Insert into ChapterTable(CourseId,SubId,Chapter) values({0},{1},'{2}')", CourseComboBox.SelectedValue, SubjectComboBox.SelectedValue, ChTextBox.Text)
            ExecuteCommand(sql, "New Chapter Information is Saved...")
        Else
            sql = String.Format("Update  ChapterTable set CourseId={0},SubId={1},Chapter='{2}' where ChapterNo={3}", CourseComboBox.SelectedValue, SubjectComboBox.SelectedValue, ChTextBox.Text, ChNumberTextBox.Text)
            ExecuteCommand(sql, "New Chapter Information is updated...")
        End If
        FillListView(ChListView, "select * from CSChView")
        ResetForm()

    End Sub
    Sub ResetForm()
        SaveButton.Text = "Save"
        ChTextBox.Clear()
    End Sub
    Private Sub ChapterForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnectToDB()

        FillListView(ChListView, "select * from CSChView")
        FillCombo(SubjectComboBox, "select * from SubTable", "SName", "SubID")
        FillCombo(CourseComboBox, "Select * from CourseTable", "CourseName", "CId")

        SearchComboBox.SelectedIndex = 0

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ChListView.SelectedItems.Count > 0 Then
            CourseComboBox.Text = ChListView.SelectedItems(0).Text
            SubjectComboBox.Text = ChListView.SelectedItems(0).SubItems(1).Text
            ChNumberTextBox.Text = ChListView.SelectedItems(0).SubItems(2).Text
            ChTextBox.Text = ChListView.SelectedItems(0).SubItems(3).Text
            ChNumberTextBox.ReadOnly = True
            SaveButton.Text = "Update"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ChListView.SelectedItems.Count > 0 Then
            If confirm("Do you want to delete selected Chapter record?") = DialogResult.Yes Then
                id = ChListView.SelectedItems(0).SubItems(2).Text
                ExecuteCommand("Delete from ChapterTable where ChapterNo=" & id, " Chapter Information is deleted...")
                FillListView(ChListView, "select * from CSChView")
            End If
        Else
            displayWarning("Please select Record...")
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As New ReportViewerForm1()
        f.ShowChapterReport()
        f.Show()

    End Sub

   End Class