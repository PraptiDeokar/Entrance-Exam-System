Public Class CourseForm
    Dim mode As Boolean = True
    Dim ID As Integer

    Private Sub CourseTableForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnectToDB()
        FillListView(ListView1, "select * from CourseTable")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If CourseTextBox.Text = "" Then
            displayWarning("Please enter course Name")
            Return
        End If
        If mode Then      'true==> insert
            ExecuteCommand("Insert into CourseTable (CourseName) values('" & CourseTextBox.Text & "')", "New Course Information is Saved...")
        Else
            ExecuteCommand("Update CourseTable set CourseName='" & CourseTextBox.Text & "' where CId=" & ID, "Course Information is Updated...")
        End If
        CourseTextBox.Clear()
        mode = True
        FillListView(ListView1, "Select * from CourseTable")
        CourseTextBox.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CourseTextBox.Clear()
        mode = True
        CourseTextBox.Focus()
    End Sub

    Private Sub CourseTableForm_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F3 Then
            If ListView1.SelectedItems.Count > 0 Then
                ID = ListView1.SelectedItems(0).Text
                If confirm("Do you want to delete selected Course record?") = DialogResult.Yes Then
                    ExecuteCommand("Delete from CourseTable where CId=" & ID, "Course Information is deleted....")
                    FillListView(ListView1, "Select * from CourseTable")
                End If
            Else
                displayWarning("Please select Course Record...")
            End If
        End If
        If e.KeyCode = Keys.F4 Then
            If ListView1.SelectedItems.Count > 0 Then
                ID = ListView1.SelectedItems(0).Text
                CourseTextBox.Text = ListView1.SelectedItems(0).SubItems(1).Text
                mode = False 'update
                CourseTextBox.Focus()
            Else
                displayWarning("Please select Course Record...")
            End If
        End If
        If e.KeyCode = Keys.F5 Then
            Dim f As New ReportViewerForm1()
            f.coursereportview()
            f.Show()
        End If
    End Sub

   
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class