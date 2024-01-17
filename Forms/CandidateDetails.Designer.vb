<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CandidateDetails
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.CancelButton1 = New System.Windows.Forms.Button()
        Me.CanListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ContactNoTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SearchFieldComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(30, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "::Candidate Information ::"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(887, 441)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 11
        Me.LineShape1.X2 = 334
        Me.LineShape1.Y1 = 56
        Me.LineShape1.Y2 = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Candidate ID"
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(136, 17)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(53, 21)
        Me.IdTextBox.TabIndex = 3
        Me.IdTextBox.Text = "(Auto)"
        '
        'saveButton
        '
        Me.saveButton.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.Location = New System.Drawing.Point(50, 323)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(71, 29)
        Me.saveButton.TabIndex = 4
        Me.saveButton.Text = "&Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'CancelButton1
        '
        Me.CancelButton1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton1.Location = New System.Drawing.Point(198, 324)
        Me.CancelButton1.Name = "CancelButton1"
        Me.CancelButton1.Size = New System.Drawing.Size(74, 29)
        Me.CancelButton1.TabIndex = 5
        Me.CancelButton1.Text = "&Cancel"
        Me.CancelButton1.UseVisualStyleBackColor = True
        '
        'CanListView
        '
        Me.CanListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.CanListView.FullRowSelect = True
        Me.CanListView.GridLines = True
        Me.CanListView.Location = New System.Drawing.Point(339, 56)
        Me.CanListView.MultiSelect = False
        Me.CanListView.Name = "CanListView"
        Me.CanListView.Size = New System.Drawing.Size(545, 342)
        Me.CanListView.TabIndex = 6
        Me.CanListView.UseCompatibleStateImageBehavior = False
        Me.CanListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CandidateID"
        Me.ColumnHeader1.Width = 94
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "CandidateName"
        Me.ColumnHeader2.Width = 111
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "CandidateAddress"
        Me.ColumnHeader3.Width = 269
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(136, 81)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(167, 21)
        Me.NameTextBox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Candidate Name"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(136, 108)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(167, 85)
        Me.AddressTextBox.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Candidate Address"
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.Location = New System.Drawing.Point(136, 210)
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.Size = New System.Drawing.Size(167, 21)
        Me.ContactNoTextBox.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Contact No."
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(136, 257)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(167, 21)
        Me.EmailTextBox.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Email"
        '
        'EditButton
        '
        Me.EditButton.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Location = New System.Drawing.Point(399, 407)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(74, 33)
        Me.EditButton.TabIndex = 17
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(488, 407)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(74, 33)
        Me.DeleteButton.TabIndex = 18
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.Location = New System.Drawing.Point(586, 404)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(74, 33)
        Me.RefreshButton.TabIndex = 19
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(351, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Search Fields"
        '
        'SearchFieldComboBox
        '
        Me.SearchFieldComboBox.FormattingEnabled = True
        Me.SearchFieldComboBox.Items.AddRange(New Object() {"CandidateId", "Name", "Address"})
        Me.SearchFieldComboBox.Location = New System.Drawing.Point(472, 17)
        Me.SearchFieldComboBox.Name = "SearchFieldComboBox"
        Me.SearchFieldComboBox.Size = New System.Drawing.Size(131, 23)
        Me.SearchFieldComboBox.TabIndex = 21
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(626, 17)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(201, 21)
        Me.SearchTextBox.TabIndex = 22
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(683, 404)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(74, 33)
        Me.PrintButton.TabIndex = 23
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.Location = New System.Drawing.Point(785, 404)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(74, 34)
        Me.closeButton.TabIndex = 24
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ContactNoTextBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.saveButton)
        Me.GroupBox1.Controls.Add(Me.CancelButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 359)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'CandidateDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(887, 441)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.SearchFieldComboBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.CanListView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CandidateDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Candidate Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton1 As System.Windows.Forms.Button
    Friend WithEvents CanListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ContactNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SearchFieldComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents closeButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
