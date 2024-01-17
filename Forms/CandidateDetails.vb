Public Class CandidateDetails
    Dim id As Integer

    Private Sub CandidateDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnectToDB()
        FillListView(CanListView, "Select CanId,CanName,CanAddress from CandInfo")
        SearchFieldComboBox.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveButton.Click
        If saveButton.Text = "&Save" Then
            Dim sql As String
            sql = String.Format("Insert into CandInfo (CanName,CanAddress,ContactNo,Email) values('{0}','{1}',{2},'{3}')", NameTextBox.Text, AddressTextBox.Text, ContactNoTextBox.Text, EmailTextBox.Text)
            ExecuteCommand(sql, "New Candidate Information is Saved...")
        Else
            Dim sql As String
            sql = String.Format("Update CandInfo set CanName='{0}',CanAddress='{1}',ContactNo={2},Email='{3}' where CanId={4}", NameTextBox.Text, AddressTextBox.Text, ContactNoTextBox.Text, EmailTextBox.Text, id)
            ExecuteCommand(sql, "Candidate Information is Updated...")
        End If
        FillListView(CanListView, "Select CanId,CanName,CanAddress from CandInfo")
        ResetForm()
    End Sub
    Sub ResetForm()
        IdTextBox.Text = "(Auto)"
        NameTextBox.Clear()
        AddressTextBox.Clear()
        ContactNoTextBox.Clear()
        EmailTextBox.Clear()
        saveButton.Text = "&Save"
        NameTextBox.Focus()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton1.Click
        ResetForm()
    End Sub



    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        If CanListView.SelectedItems.Count > 0 Then
            id = CanListView.SelectedItems(0).Text
            Dim dt As DataTable = GetTable("Select * from CandInfo where CanId=" & id)

            IdTextBox.Text = dt.Rows(0)(0)
            NameTextBox.Text = dt.Rows(0)(1)
            AddressTextBox.Text = dt.Rows(0)(2)
            ContactNoTextBox.Text = dt.Rows(0)(3)
            EmailTextBox.Text = dt.Rows(0)(4)
            saveButton.Text = "&Update"
            NameTextBox.Focus()
        Else
            displayWarning("Please select Candidate Record...")
        End If
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If CanListView.SelectedItems.Count > 0 Then
            If confirm("Do you want to delete selected Candidate record?") = DialogResult.Yes Then
                id = CanListView.SelectedItems(0).Text
                ExecuteCommand("Delete from CandInfo where CanId=" & id, " Candidate Information is deleted...")
                FillListView(CanListView, "Select CanId,CanName,CanAddress from CandInfo")
            End If
        Else
            displayWarning("Please select Candidate Record...")
        End If
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        FillListView(CanListView, "Select CanId,CanName,CanAddress from CandInfo")
    End Sub

    Private Sub closeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        On Error GoTo xxx
        If SearchTextBox.Text = "" Then
            FillListView(CanListView, "Select CanId,CanName,CanAddress from CandInfo")
        Else
            Select Case SearchFieldComboBox.Text
                Case "CandidateId"
                    FillListView(CanListView, "Select CanId,CanName,CanAddress from CandInfo where CanId=" & SearchTextBox.Text)
                Case "Name"
                    FillListView(CanListView, "Select CanId,CanName,CanAddress from CandInfo where CanName like '%" & SearchTextBox.Text & "%'")
                Case "Address"
                    FillListView(CanListView, "Select CanId,CanName,CanAddress from CandInfo where CanAddress like '%" & SearchTextBox.Text & "%'")
            End Select
        End If
xxx:
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        Dim f As New ReportViewerForm1()
        f.ShowCandReport()
        f.Show()
    End Sub

    Private Sub NameTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NameTextBox.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) Then
            e.Handled = True
            ToolTip1.Show("Please enter only numbers", NameTextBox, 2000)

        End If
    End Sub

    Private Sub ContactNoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContactNoTextBox.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
            ToolTip1.Show("Please enter only numbers", ContactNoTextBox, 2000)

        End If
    End Sub
End Class