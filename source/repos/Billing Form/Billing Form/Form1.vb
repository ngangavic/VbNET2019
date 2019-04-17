Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lb_total_amount.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grb_payment_methods.Enter

    End Sub

    Private Sub lb_customer_name_Click(sender As Object, e As EventArgs) Handles lb_customer_name.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles tb_bill_amount.TextChanged

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        tb_customer_no.Text = ""
        tb_customer_name.Text = ""
        cb_item_name.Text = ""
        tb_quantity.Text = vbEmpty
        tb_price.Text = vbEmpty
        tb_total_amount.Text = vbEmpty
        rb_cash.Checked = False
        rb_credit.Checked = False
        tb_discount.Text = vbEmpty
        tb_bill_amount.Text = vbEmpty
    End Sub

    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        tb_total_amount.Text = Convert.ToInt32(tb_price.Text * Convert.ToInt32(tb_quantity.Text))
        If (rb_cash.Checked = True) Then
            tb_discount.Text = 0.1
        Else
            tb_discount.Text = 0.02

        End If

    End Sub

    Private Sub rb_cash_CheckedChanged(sender As Object, e As EventArgs) Handles rb_cash.CheckedChanged

    End Sub
End Class
