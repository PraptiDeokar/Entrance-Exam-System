Public Class ExamListForm
    Public ID As Integer
    Dim examdetails As String = ""
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ExamListView.SelectedItems.Count > 0 Then
            ID = ExamListView.SelectedItems(0).Text
            SetExam.CComboBox.Text = ExamListView.SelectedItems(0).SubItems(2).Text
            SetExam.SubjectComboBox.Text = ExamListView.SelectedItems(0).SubItems(3).Text
            Dim dt As DataTable = GetTable("Select * from SetExamTable where EId=" & ID)

            SetExam.EIdTextBox.Text = dt.Rows(0)(0)
            SetExam.ENameTextBox.Text = dt.Rows(0)(1)

            SetExam.NOQTextBox.Text = dt.Rows(0)(4)
            SetExam.TotalTextBox.Text = dt.Rows(0)(5)
            SetExam.TPTextBox.Text = dt.Rows(0)(6)
            SetExam.EDateTextBox.Text = dt.Rows(0)(7)
            SetExam.DateTimePicker1.Text = dt.Rows(0)(8)
            SetExam.LocTextBox.Text = dt.Rows(0)(9)
            SetExam.ScheduleButton.Text = "&Update"
            Me.Hide()
            SetExam.ENameTextBox.Focus()
            SetExam.Show()
        Else
            displayWarning("Please select Record...")
        End If
    End Sub

    Private Sub ExamListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnectToDB()
        FillListView(ExamListView, "select * from SchExamCSubView")
        SearchFieldComboBox.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ExamListView.SelectedItems.Count > 0 Then
            ID = ExamListView.SelectedItems(0).Text
            If confirm("Do you want to delete selected Exam record?") = DialogResult.Yes Then
                ExecuteCommand("Delete from SetExamTable where EId=" & ID, "Record is deleted....")
                FillListView(ExamListView, "Select * from SchExamCSubView")
            End If
        Else
            displayWarning("Please select Record...")
        End If
    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        On Error GoTo xxx
        If SearchTextBox.Text = "" Then
            FillListView(ExamListView, "Select EId,EName,EDate,ETime,Location from SetExamTable")
        Else
            Select Case SearchFieldComboBox.Text
                Case "ExamId"
                    FillListView(ExamListView, "Select * SchExamCSubView where EId=" & SearchTextBox.Text)
                Case "ExamName"
                    FillListView(ExamListView, "Select * from SChExamCSubView where EName like '%" & SearchTextBox.Text & "%'")
                Case "Course"
                    FillListView(ExamListView, "Select * from SchExamCSubView where CourseName like '%" & SearchTextBox.Text & "%'")
                Case "ExamTime"
                    FillListView(ExamListView, "Select * from SchExanCSubView where ETime like '%" & SearchTextBox.Text & "%'")
                Case "Location"
                    FillListView(ExamListView, "Select * from SchExamCSubView where Location like '%" & SearchTextBox.Text & "%'")
            End Select
        End If
xxx:
    End Sub

    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ExamListView.SelectedItems.Count > 0 Then
            RegForms.ExamLabel.Text = "Exam Id: " & ExamListView.SelectedItems(0).Text & " Exam Name: " & ExamListView.SelectedItems(0).SubItems(1).Text
            RegForms.ExamLabel.Tag = ExamListView.SelectedItems(0).Text
            Me.Close()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim f As New ExamReportForm()
        f.ShowExamReport()
        f.Show()


    End Sub
End Class