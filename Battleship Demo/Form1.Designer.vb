<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SelectedGrid = New System.Windows.Forms.Label()
        Me.BeginBtn = New System.Windows.Forms.Button()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.RotateBtn = New System.Windows.Forms.Button()
        Me.FlipBtn = New System.Windows.Forms.Button()
        Me.ReturnToMenuBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SelectedGrid
        '
        Me.SelectedGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.SelectedGrid.Location = New System.Drawing.Point(800, 107)
        Me.SelectedGrid.Name = "SelectedGrid"
        Me.SelectedGrid.Size = New System.Drawing.Size(80, 40)
        Me.SelectedGrid.TabIndex = 2
        Me.SelectedGrid.Text = "(none)"
        '
        'BeginBtn
        '
        Me.BeginBtn.Location = New System.Drawing.Point(363, 169)
        Me.BeginBtn.Name = "BeginBtn"
        Me.BeginBtn.Size = New System.Drawing.Size(244, 103)
        Me.BeginBtn.TabIndex = 101
        Me.BeginBtn.Text = "Begin Game"
        Me.BeginBtn.UseVisualStyleBackColor = True
        '
        'LoginBtn
        '
        Me.LoginBtn.Location = New System.Drawing.Point(363, 322)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(244, 104)
        Me.LoginBtn.TabIndex = 104
        Me.LoginBtn.Text = "Users"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'RotateBtn
        '
        Me.RotateBtn.Location = New System.Drawing.Point(800, 200)
        Me.RotateBtn.Name = "RotateBtn"
        Me.RotateBtn.Size = New System.Drawing.Size(80, 40)
        Me.RotateBtn.TabIndex = 105
        Me.RotateBtn.Text = "Rotate Ships"
        Me.RotateBtn.UseVisualStyleBackColor = True
        Me.RotateBtn.Visible = False
        '
        'FlipBtn
        '
        Me.FlipBtn.Location = New System.Drawing.Point(800, 150)
        Me.FlipBtn.Name = "FlipBtn"
        Me.FlipBtn.Size = New System.Drawing.Size(80, 40)
        Me.FlipBtn.TabIndex = 106
        Me.FlipBtn.Text = "Flip panels"
        Me.FlipBtn.UseVisualStyleBackColor = True
        Me.FlipBtn.Visible = False
        '
        'ReturnToMenuBtn
        '
        Me.ReturnToMenuBtn.Location = New System.Drawing.Point(805, 29)
        Me.ReturnToMenuBtn.Name = "ReturnToMenuBtn"
        Me.ReturnToMenuBtn.Size = New System.Drawing.Size(80, 40)
        Me.ReturnToMenuBtn.TabIndex = 107
        Me.ReturnToMenuBtn.Text = "Close"
        Me.ReturnToMenuBtn.UseVisualStyleBackColor = True
        Me.ReturnToMenuBtn.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 626)
        Me.Controls.Add(Me.ReturnToMenuBtn)
        Me.Controls.Add(Me.FlipBtn)
        Me.Controls.Add(Me.RotateBtn)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.BeginBtn)
        Me.Controls.Add(Me.SelectedGrid)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SelectedGrid As Label
    Friend WithEvents BeginBtn As Button
    Friend WithEvents LoginBtn As Button
    Friend WithEvents RotateBtn As Button
    Friend WithEvents FlipBtn As Button
    Friend WithEvents ReturnToMenuBtn As Button
End Class
