Imports System.Windows.Forms.Design
Imports MySql.Data.MySqlClient
Public Class DataGrid
    Dim dataAdapter As MySqlDataAdapter
    Dim dset As DataSet
    Dim source1 As New BindingSource
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim conn As New MySqlConnection("server=127.0.0.1; username=root; 
           password=''; database=student;")

        Try
            conn.Open()

            dset = New DataSet
            dataAdapter = New MySqlDataAdapter("Select * FROM Student", conn)
            dataAdapter.Fill(dset, "student")

            If dset.Tables.Count > 0 Then
                Dim view As New DataView(dset.Tables(0))
                source1.DataSource = view
                DataGridView1.DataSource = source1

            End If
            If conn.State = ConnectionState.Open Then
                MessageBox.Show("Connected")
            Else
                MessageBox.Show("not Connected")
            End If
        Catch ex As Exception
            MessageBox.Show("Not Connected")
        Finally
            conn.Close()
        End Try
    End Sub
End Class
