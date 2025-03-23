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
        Label1 = New Label()
        TxtUser = New TextBox()
        Label2 = New Label()
        TxtPass = New TextBox()
        passShow = New CheckBox()
        BtnLogIn = New Button()
        BtnReset = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(94, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 25)
        Label1.TabIndex = 3
        Label1.Text = "Username"
        ' 
        ' TxtUser
        ' 
        TxtUser.Location = New Point(94, 84)
        TxtUser.Name = "TxtUser"
        TxtUser.Size = New Size(348, 31)
        TxtUser.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(98, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 5
        Label2.Text = "Password"
        ' 
        ' TxtPass
        ' 
        TxtPass.Location = New Point(94, 146)
        TxtPass.Name = "TxtPass"
        TxtPass.Size = New Size(348, 31)
        TxtPass.TabIndex = 6
        ' 
        ' passShow
        ' 
        passShow.AutoSize = True
        passShow.Location = New Point(94, 183)
        passShow.Name = "passShow"
        passShow.Size = New Size(162, 29)
        passShow.TabIndex = 7
        passShow.Text = "show password"
        passShow.UseVisualStyleBackColor = True
        ' 
        ' BtnLogIn
        ' 
        BtnLogIn.Location = New Point(94, 218)
        BtnLogIn.Name = "BtnLogIn"
        BtnLogIn.Size = New Size(348, 34)
        BtnLogIn.TabIndex = 8
        BtnLogIn.Text = "Log In"
        BtnLogIn.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Location = New Point(94, 283)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(348, 34)
        BtnReset.TabIndex = 9
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(511, 383)
        Controls.Add(BtnReset)
        Controls.Add(BtnLogIn)
        Controls.Add(passShow)
        Controls.Add(TxtPass)
        Controls.Add(Label2)
        Controls.Add(TxtUser)
        Controls.Add(Label1)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents passShow As CheckBox
    Friend WithEvents BtnLogIn As Button
    Friend WithEvents BtnReset As Button
End Class
