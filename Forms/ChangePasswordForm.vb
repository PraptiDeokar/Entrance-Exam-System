Public Class ChangePasswordForm

    Private Sub ChangePasswordForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        usernameLabel.Text = "admin"
    End Sub

    Private Sub ChangeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeButton.Click
        If OldTextBox.Text <> password Then
            MessageBox.Show("Please enter your original password....")
            Return
        End If
        If newTextBox.Text <> ConfirmTextBox.Text Then
            MessageBox.Show("New And confirm password mismatching....")
            Return
        End If
        Dim i As Integer = ExecuteCommand(String.Format("Update LoginTable set Password='{0}' where Username='{1}'", newTextBox.Text, usernameLabel.Text))
        If i = 1 Then
            MessageBox.Show("Password is changed successfully....")
        Else
            MessageBox.Show("Unable to change Password ....")
        End If
        Me.Close()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class