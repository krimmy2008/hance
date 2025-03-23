<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentInfo
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
        txtLRN = New TextBox()
        Label2 = New Label()
        txtLN = New TextBox()
        txtMN = New TextBox()
        txtFN = New TextBox()
        txtMajor = New TextBox()
        txtYL = New TextBox()
        txtSex = New TextBox()
        txtAge = New TextBox()
        Label16 = New Label()
        txtPN = New TextBox()
        txtHomeAdd = New TextBox()
        txtEmail = New TextBox()
        txtPOB = New TextBox()
        Button1 = New Button()
        BtnClear = New Button()
        DateTimePicker1 = New DateTimePicker()
        BtnDelete = New Button()
        BtnEdit = New Button()
        SuspendLayout()
        ' 
        ' txtLRN
        ' 
        txtLRN.Location = New Point(12, 61)
        txtLRN.Name = "txtLRN"
        txtLRN.PlaceholderText = "LRN:"
        txtLRN.Size = New Size(220, 31)
        txtLRN.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(360, 46)
        Label2.TabIndex = 2
        Label2.Text = "Student Information"
        ' 
        ' txtLN
        ' 
        txtLN.Location = New Point(12, 218)
        txtLN.Name = "txtLN"
        txtLN.PlaceholderText = "LastName:"
        txtLN.Size = New Size(247, 31)
        txtLN.TabIndex = 12
        ' 
        ' txtMN
        ' 
        txtMN.Location = New Point(12, 181)
        txtMN.Name = "txtMN"
        txtMN.PlaceholderText = "MiddleName:"
        txtMN.Size = New Size(247, 31)
        txtMN.TabIndex = 13
        ' 
        ' txtFN
        ' 
        txtFN.Location = New Point(12, 144)
        txtFN.Name = "txtFN"
        txtFN.PlaceholderText = "FirstName:"
        txtFN.Size = New Size(247, 31)
        txtFN.TabIndex = 14
        ' 
        ' txtMajor
        ' 
        txtMajor.Location = New Point(238, 98)
        txtMajor.Name = "txtMajor"
        txtMajor.PlaceholderText = "Major:"
        txtMajor.Size = New Size(221, 31)
        txtMajor.TabIndex = 15
        ' 
        ' txtYL
        ' 
        txtYL.Location = New Point(12, 98)
        txtYL.Name = "txtYL"
        txtYL.PlaceholderText = "Year_level"
        txtYL.Size = New Size(220, 31)
        txtYL.TabIndex = 16
        ' 
        ' txtSex
        ' 
        txtSex.Location = New Point(238, 61)
        txtSex.Name = "txtSex"
        txtSex.PlaceholderText = "Sex:"
        txtSex.Size = New Size(221, 31)
        txtSex.TabIndex = 17
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(12, 255)
        txtAge.Name = "txtAge"
        txtAge.PlaceholderText = "Age:"
        txtAge.Size = New Size(247, 31)
        txtAge.TabIndex = 20
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(669, 144)
        Label16.Name = "Label16"
        Label16.Size = New Size(0, 25)
        Label16.TabIndex = 25
        ' 
        ' txtPN
        ' 
        txtPN.Location = New Point(265, 218)
        txtPN.Name = "txtPN"
        txtPN.PlaceholderText = "PhoneNumber:"
        txtPN.Size = New Size(484, 31)
        txtPN.TabIndex = 31
        ' 
        ' txtHomeAdd
        ' 
        txtHomeAdd.Location = New Point(12, 292)
        txtHomeAdd.Name = "txtHomeAdd"
        txtHomeAdd.PlaceholderText = "HomeAddress:"
        txtHomeAdd.Size = New Size(737, 31)
        txtHomeAdd.TabIndex = 32
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(265, 255)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email:"
        txtEmail.Size = New Size(484, 31)
        txtEmail.TabIndex = 38
        ' 
        ' txtPOB
        ' 
        txtPOB.Location = New Point(265, 181)
        txtPOB.Name = "txtPOB"
        txtPOB.PlaceholderText = "Place of birth:"
        txtPOB.Size = New Size(484, 31)
        txtPOB.TabIndex = 39
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(557, 55)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 42
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Location = New Point(675, 55)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(112, 34)
        BtnClear.TabIndex = 43
        BtnClear.Text = "display"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(265, 144)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 44
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(675, 95)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(112, 34)
        BtnDelete.TabIndex = 45
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' BtnEdit
        ' 
        BtnEdit.Location = New Point(557, 95)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(112, 34)
        BtnEdit.TabIndex = 46
        BtnEdit.Text = "Edit"
        BtnEdit.UseVisualStyleBackColor = True
        ' 
        ' StudentInfo
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(811, 337)
        Controls.Add(BtnEdit)
        Controls.Add(BtnDelete)
        Controls.Add(DateTimePicker1)
        Controls.Add(BtnClear)
        Controls.Add(Button1)
        Controls.Add(txtPOB)
        Controls.Add(txtEmail)
        Controls.Add(txtHomeAdd)
        Controls.Add(txtPN)
        Controls.Add(Label16)
        Controls.Add(txtAge)
        Controls.Add(txtSex)
        Controls.Add(txtYL)
        Controls.Add(txtMajor)
        Controls.Add(txtFN)
        Controls.Add(txtMN)
        Controls.Add(txtLN)
        Controls.Add(Label2)
        Controls.Add(txtLRN)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "StudentInfo"
        Text = "StudentInfo"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtLRN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLN As TextBox
    Friend WithEvents txtMN As TextBox
    Friend WithEvents txtFN As TextBox
    Friend WithEvents txtMajor As TextBox
    Friend WithEvents txtYL As TextBox
    Friend WithEvents txtSex As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPN As TextBox
    Friend WithEvents txtHomeAdd As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPOB As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
End Class
