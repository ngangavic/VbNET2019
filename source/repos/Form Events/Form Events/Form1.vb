Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("form is loaded")
    End Sub
    Private Sub Form1_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        MessageBox.Show("close form")
        Me.Close()
    End Sub

End Class
