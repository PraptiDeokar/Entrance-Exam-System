Public Class Instructionform

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        TestForm.ShowDialog()
    End Sub
End Class