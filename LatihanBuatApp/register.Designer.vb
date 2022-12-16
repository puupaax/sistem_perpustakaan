<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbConfirm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.regBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(165, 43)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(156, 22)
        Me.tbPassword.TabIndex = 9
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(165, 13)
        Me.tbUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(156, 22)
        Me.tbUsername.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username"
        '
        'tbConfirm
        '
        Me.tbConfirm.Location = New System.Drawing.Point(165, 73)
        Me.tbConfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbConfirm.Name = "tbConfirm"
        Me.tbConfirm.Size = New System.Drawing.Size(156, 22)
        Me.tbConfirm.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Confirm Password"
        '
        'regBtn
        '
        Me.regBtn.Location = New System.Drawing.Point(190, 103)
        Me.regBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.regBtn.Name = "regBtn"
        Me.regBtn.Size = New System.Drawing.Size(131, 24)
        Me.regBtn.TabIndex = 12
        Me.regBtn.Text = "Register"
        Me.regBtn.UseVisualStyleBackColor = True
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 143)
        Me.Controls.Add(Me.regBtn)
        Me.Controls.Add(Me.tbConfirm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "register"
        Me.Text = "register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbConfirm As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents regBtn As Button
End Class
