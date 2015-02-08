<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReverse = New System.Windows.Forms.Button()
        Me.btnCountWords = New System.Windows.Forms.Button()
        Me.btnCountVowels = New System.Windows.Forms.Button()
        Me.txtSentence = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtField6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtField5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtField4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtField3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtField2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtField1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPutTogether = New System.Windows.Forms.Button()
        Me.txtRecord = New System.Windows.Forms.TextBox()
        Me.btnBreakApart = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnFormatPhoneNumber = New System.Windows.Forms.Button()
        Me.lblFormattedPhoneNumber = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReverse)
        Me.GroupBox1.Controls.Add(Me.btnCountWords)
        Me.GroupBox1.Controls.Add(Me.btnCountVowels)
        Me.GroupBox1.Controls.Add(Me.txtSentence)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 126)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step 1"
        '
        'btnReverse
        '
        Me.btnReverse.Location = New System.Drawing.Point(341, 79)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(75, 23)
        Me.btnReverse.TabIndex = 4
        Me.btnReverse.Text = "Reverse"
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'btnCountWords
        '
        Me.btnCountWords.Location = New System.Drawing.Point(218, 79)
        Me.btnCountWords.Name = "btnCountWords"
        Me.btnCountWords.Size = New System.Drawing.Size(94, 23)
        Me.btnCountWords.TabIndex = 3
        Me.btnCountWords.Text = "Count Words"
        Me.btnCountWords.UseVisualStyleBackColor = True
        '
        'btnCountVowels
        '
        Me.btnCountVowels.Location = New System.Drawing.Point(99, 79)
        Me.btnCountVowels.Name = "btnCountVowels"
        Me.btnCountVowels.Size = New System.Drawing.Size(88, 23)
        Me.btnCountVowels.TabIndex = 2
        Me.btnCountVowels.Text = "Count Vowels"
        Me.btnCountVowels.UseVisualStyleBackColor = True
        '
        'txtSentence
        '
        Me.txtSentence.Location = New System.Drawing.Point(99, 42)
        Me.txtSentence.Name = "txtSentence"
        Me.txtSentence.Size = New System.Drawing.Size(317, 20)
        Me.txtSentence.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sentence :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtField6)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtField5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtField4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtField3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtField2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtField1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnPutTogether)
        Me.GroupBox2.Controls.Add(Me.txtRecord)
        Me.GroupBox2.Controls.Add(Me.btnBreakApart)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 161)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 225)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Step 2"
        '
        'txtField6
        '
        Me.txtField6.Location = New System.Drawing.Point(291, 190)
        Me.txtField6.Name = "txtField6"
        Me.txtField6.Size = New System.Drawing.Size(99, 20)
        Me.txtField6.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(226, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Field 6:"
        '
        'txtField5
        '
        Me.txtField5.Location = New System.Drawing.Point(291, 153)
        Me.txtField5.Name = "txtField5"
        Me.txtField5.Size = New System.Drawing.Size(99, 20)
        Me.txtField5.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(226, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Field 5:"
        '
        'txtField4
        '
        Me.txtField4.Location = New System.Drawing.Point(291, 119)
        Me.txtField4.Name = "txtField4"
        Me.txtField4.Size = New System.Drawing.Size(99, 20)
        Me.txtField4.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(226, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Field 4:"
        '
        'txtField3
        '
        Me.txtField3.Location = New System.Drawing.Point(99, 190)
        Me.txtField3.Name = "txtField3"
        Me.txtField3.Size = New System.Drawing.Size(99, 20)
        Me.txtField3.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Field 3:"
        '
        'txtField2
        '
        Me.txtField2.Location = New System.Drawing.Point(99, 153)
        Me.txtField2.Name = "txtField2"
        Me.txtField2.Size = New System.Drawing.Size(99, 20)
        Me.txtField2.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Field 2:"
        '
        'txtField1
        '
        Me.txtField1.Location = New System.Drawing.Point(99, 119)
        Me.txtField1.Name = "txtField1"
        Me.txtField1.Size = New System.Drawing.Size(99, 20)
        Me.txtField1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Field 1:"
        '
        'btnPutTogether
        '
        Me.btnPutTogether.Location = New System.Drawing.Point(260, 73)
        Me.btnPutTogether.Name = "btnPutTogether"
        Me.btnPutTogether.Size = New System.Drawing.Size(94, 23)
        Me.btnPutTogether.TabIndex = 7
        Me.btnPutTogether.Text = "Put Together"
        Me.btnPutTogether.UseVisualStyleBackColor = True
        '
        'txtRecord
        '
        Me.txtRecord.Location = New System.Drawing.Point(99, 31)
        Me.txtRecord.Name = "txtRecord"
        Me.txtRecord.Size = New System.Drawing.Size(317, 20)
        Me.txtRecord.TabIndex = 5
        '
        'btnBreakApart
        '
        Me.btnBreakApart.Location = New System.Drawing.Point(141, 73)
        Me.btnBreakApart.Name = "btnBreakApart"
        Me.btnBreakApart.Size = New System.Drawing.Size(88, 23)
        Me.btnBreakApart.TabIndex = 6
        Me.btnBreakApart.Text = "Break Apart"
        Me.btnBreakApart.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sentence :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnClear)
        Me.GroupBox3.Controls.Add(Me.btnExit)
        Me.GroupBox3.Controls.Add(Me.btnFormatPhoneNumber)
        Me.GroupBox3.Controls.Add(Me.lblFormattedPhoneNumber)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 392)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(435, 141)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Step 3"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(291, 112)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnFormatPhoneNumber
        '
        Me.btnFormatPhoneNumber.Location = New System.Drawing.Point(291, 38)
        Me.btnFormatPhoneNumber.Name = "btnFormatPhoneNumber"
        Me.btnFormatPhoneNumber.Size = New System.Drawing.Size(125, 23)
        Me.btnFormatPhoneNumber.TabIndex = 15
        Me.btnFormatPhoneNumber.Text = "Format Phone Number"
        Me.btnFormatPhoneNumber.UseVisualStyleBackColor = True
        '
        'lblFormattedPhoneNumber
        '
        Me.lblFormattedPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFormattedPhoneNumber.Location = New System.Drawing.Point(165, 77)
        Me.lblFormattedPhoneNumber.Name = "lblFormattedPhoneNumber"
        Me.lblFormattedPhoneNumber.Size = New System.Drawing.Size(102, 23)
        Me.lblFormattedPhoneNumber.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Formatted Phone Number:"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(165, 38)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(102, 20)
        Me.txtPhoneNumber.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Phone Number:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(291, 77)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 23)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 545)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Assignment 16"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReverse As System.Windows.Forms.Button
    Friend WithEvents btnCountWords As System.Windows.Forms.Button
    Friend WithEvents btnCountVowels As System.Windows.Forms.Button
    Friend WithEvents txtSentence As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtField6 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtField5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtField4 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtField3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtField2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtField1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnPutTogether As System.Windows.Forms.Button
    Friend WithEvents txtRecord As System.Windows.Forms.TextBox
    Friend WithEvents btnBreakApart As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFormatPhoneNumber As System.Windows.Forms.Button
    Friend WithEvents lblFormattedPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
