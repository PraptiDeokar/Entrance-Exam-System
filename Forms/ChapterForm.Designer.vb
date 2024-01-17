<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChapterForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CourseComboBox = New System.Windows.Forms.ComboBox()
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox()
        Me.ChNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ChTextBox = New System.Windows.Forms.TextBox()
        Me.ChListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchComboBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(62, 355)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(99, 27)
        Me.SaveButton.TabIndex = 9
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chapter Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 184)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Subject"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 230)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Chapter No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 276)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Chapter Name"
        '
        'CourseComboBox
        '
        Me.CourseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CourseComboBox.FormattingEnabled = True
        Me.CourseComboBox.Location = New System.Drawing.Point(122, 114)
        Me.CourseComboBox.Name = "CourseComboBox"
        Me.CourseComboBox.Size = New System.Drawing.Size(271, 26)
        Me.CourseComboBox.TabIndex = 5
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Location = New System.Drawing.Point(122, 181)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.Size = New System.Drawing.Size(271, 26)
        Me.SubjectComboBox.TabIndex = 6
        '
        'ChNumberTextBox
        '
        Me.ChNumberTextBox.Location = New System.Drawing.Point(122, 230)
        Me.ChNumberTextBox.Name = "ChNumberTextBox"
        Me.ChNumberTextBox.Size = New System.Drawing.Size(100, 24)
        Me.ChNumberTextBox.TabIndex = 7
        Me.ChNumberTextBox.Text = "(AUTO)"
        '
        'ChTextBox
        '
        Me.ChTextBox.Location = New System.Drawing.Point(122, 276)
        Me.ChTextBox.Name = "ChTextBox"
        Me.ChTextBox.Size = New System.Drawing.Size(271, 24)
        Me.ChTextBox.TabIndex = 8
        '
        'ChListView
        '
        Me.ChListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ChListView.FullRowSelect = True
        Me.ChListView.GridLines = True
        Me.ChListView.Location = New System.Drawing.Point(426, 83)
        Me.ChListView.MultiSelect = False
        Me.ChListView.Name = "ChListView"
        Me.ChListView.Size = New System.Drawing.Size(396, 318)
        Me.ChListView.TabIndex = 14
        Me.ChListView.UseCompatibleStateImageBehavior = False
        Me.ChListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Course "
        Me.ColumnHeader1.Width = 68
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Subject"
        Me.ColumnHeader2.Width = 77
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Chapter No."
        Me.ColumnHeader3.Width = 92
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Chapter"
        Me.ColumnHeader4.Width = 141
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(221, 355)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(103, 27)
        Me.CancelButton.TabIndex = 10
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(548, 408)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 27)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(426, 408)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 27)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Edit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(601, 42)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(191, 24)
        Me.SearchTextBox.TabIndex = 13
        '
        'SearchComboBox
        '
        Me.SearchComboBox.FormattingEnabled = True
        Me.SearchComboBox.Items.AddRange(New Object() {"Course", "Subject", "ChapterNo", "Chapter"})
        Me.SearchComboBox.Location = New System.Drawing.Point(432, 40)
        Me.SearchComboBox.Name = "SearchComboBox"
        Me.SearchComboBox.Size = New System.Drawing.Size(163, 26)
        Me.SearchComboBox.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(333, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 18)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Search fields"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(667, 408)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 27)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ChapterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(835, 439)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.SearchComboBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ChListView)
        Me.Controls.Add(Me.ChTextBox)
        Me.Controls.Add(Me.ChNumberTextBox)
        Me.Controls.Add(Me.SubjectComboBox)
        Me.Controls.Add(Me.CourseComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ChapterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChapterForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CourseComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubjectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ChNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SearchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
