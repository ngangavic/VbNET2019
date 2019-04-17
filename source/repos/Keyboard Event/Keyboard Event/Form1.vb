Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged

    End Sub

    Private Sub TextBoxName_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxName.KeyUp
        MessageBox.Show("Key up")

    End Sub
End Class
