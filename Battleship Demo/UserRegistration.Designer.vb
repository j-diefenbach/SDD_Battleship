<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserRegistration
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.UserTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PassTxt = New System.Windows.Forms.TextBox()
        Me.ErrorOutput = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PlayerNum = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PlayerNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserTxt
        '
        Me.UserTxt.Location = New System.Drawing.Point(187, 97)
        Me.UserTxt.Name = "UserTxt"
        Me.UserTxt.Size = New System.Drawing.Size(100, 20)
        Me.UserTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'PassTxt
        '
        Me.PassTxt.Location = New System.Drawing.Point(187, 166)
        Me.PassTxt.Name = "PassTxt"
        Me.PassTxt.Size = New System.Drawing.Size(100, 20)
        Me.PassTxt.TabIndex = 2
        Me.PassTxt.UseSystemPasswordChar = True
        '
        'ErrorOutput
        '
        Me.ErrorOutput.BackColor = System.Drawing.Color.LightSlateGray
        Me.ErrorOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorOutput.ForeColor = System.Drawing.SystemColors.Control
        Me.ErrorOutput.Location = New System.Drawing.Point(12, 287)
        Me.ErrorOutput.Name = "ErrorOutput"
        Me.ErrorOutput.Size = New System.Drawing.Size(491, 37)
        Me.ErrorOutput.TabIndex = 4
        Me.ErrorOutput.Text = "Please enter your username and password"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(114, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Signup"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(24, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "TestFileStream"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SteelBlue
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(215, 250)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 34)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Login"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PlayerNum
        '
        Me.PlayerNum.Location = New System.Drawing.Point(383, 115)
        Me.PlayerNum.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.PlayerNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PlayerNum.Name = "PlayerNum"
        Me.PlayerNum.Size = New System.Drawing.Size(41, 20)
        Me.PlayerNum.TabIndex = 8
        Me.PlayerNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(369, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Player To Sign In"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightBlue
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(421, 17)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 38)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'UserRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PlayerNum)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ErrorOutput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PassTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserTxt)
        Me.Name = "UserRegistration"
        Me.Size = New System.Drawing.Size(506, 334)
        CType(Me.PlayerNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PassTxt As TextBox
    Friend WithEvents ErrorOutput As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PlayerNum As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
End Class
