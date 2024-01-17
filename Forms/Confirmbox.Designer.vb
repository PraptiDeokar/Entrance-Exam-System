<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Confirmbox
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Yes = New System.Windows.Forms.Button()
        Me.No = New System.Windows.Forms.Button()
        Me.msgLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(4, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(146, 128)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.HotPink
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.EntranceExamApplication.My.Resources.Resources.thq
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Yes
        '
        Me.Yes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Yes.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Yes.Location = New System.Drawing.Point(198, 98)
        Me.Yes.Name = "Yes"
        Me.Yes.Size = New System.Drawing.Size(62, 27)
        Me.Yes.TabIndex = 1
        Me.Yes.Text = "Yes"
        Me.Yes.UseVisualStyleBackColor = False
        '
        'No
        '
        Me.No.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.No.DialogResult = System.Windows.Forms.DialogResult.No
        Me.No.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No.Location = New System.Drawing.Point(321, 98)
        Me.No.Name = "No"
        Me.No.Size = New System.Drawing.Size(61, 27)
        Me.No.TabIndex = 2
        Me.No.Text = "No"
        Me.No.UseVisualStyleBackColor = False
        '
        'msgLabel
        '
        Me.msgLabel.AutoSize = True
        Me.msgLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.msgLabel.Location = New System.Drawing.Point(171, 24)
        Me.msgLabel.Name = "msgLabel"
        Me.msgLabel.Size = New System.Drawing.Size(76, 16)
        Me.msgLabel.TabIndex = 3
        Me.msgLabel.Text = "msgLabel"
        '
        'Confirmbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(412, 151)
        Me.Controls.Add(Me.msgLabel)
        Me.Controls.Add(Me.No)
        Me.Controls.Add(Me.Yes)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Confirmbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmbox"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Yes As System.Windows.Forms.Button
    Friend WithEvents No As System.Windows.Forms.Button
    Friend WithEvents msgLabel As System.Windows.Forms.Label
End Class
