<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.showPassCheck = New System.Windows.Forms.CheckBox()
        Me.regBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(101, 13)
        Me.tbUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(147, 22)
        Me.tbUsername.TabIndex = 2
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(101, 43)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(147, 22)
        Me.tbPassword.TabIndex = 3
        '
        'loginBtn
        '
        Me.loginBtn.Location = New System.Drawing.Point(101, 101)
        Me.loginBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(65, 24)
        Me.loginBtn.TabIndex = 4
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'showPassCheck
        '
        Me.showPassCheck.AutoSize = True
        Me.showPassCheck.Location = New System.Drawing.Point(101, 73)
        Me.showPassCheck.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.showPassCheck.Name = "showPassCheck"
        Me.showPassCheck.Size = New System.Drawing.Size(125, 20)
        Me.showPassCheck.TabIndex = 5
        Me.showPassCheck.Text = "Show Password"
        Me.showPassCheck.UseVisualStyleBackColor = True
        '
        'regBtn
        '
        Me.regBtn.Location = New System.Drawing.Point(174, 101)
        Me.regBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.regBtn.Name = "regBtn"
        Me.regBtn.Size = New System.Drawing.Size(74, 24)
        Me.regBtn.TabIndex = 6
        Me.regBtn.Text = "Register"
        Me.regBtn.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 146)
        Me.Controls.Add(Me.regBtn)
        Me.Controls.Add(Me.showPassCheck)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Login"
        Me.Text = "Show"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents loginBtn As Button
    Friend WithEvents showPassCheck As CheckBox
    Friend WithEvents regBtn As Button
End Class
