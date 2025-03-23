
Imports Mysql
Imports System.Windows.Forms.VisualStyles

Public Class StudentInfo
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtAge.Clear()
        txtEmail.Clear()
        txtFN.Clear()
        txtHomeAdd.Clear()
        txtLN.Clear()
        txtLRN.Clear()
        txtMajor.Clear()
        txtMN.Clear()
        txtPN.Clear()
        txtPOB.Clear()
        txtSex.Clear()
        txtYL.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtFN.Text = "" Or txtAge.Text = "" Or txtEmail.Text = "" Or txtHomeAdd.Text = "" Or txtLN.Text = "" Or txtLRN.Text = "" Or txtMajor.Text = "" Or txtMN.Text = "" Or txtPN.Text = "" Or txtPOB.Text = "" Or txtSex.Text = "" Or txtYL.Text = "" Then
            MessageBox.Show("Full fill the form")
        Else
            MessageBox.Show("Successfully added")
            Dim DataGrid As New DataGrid()
            DataGrid.Show()
        End If
    End Sub
End Class