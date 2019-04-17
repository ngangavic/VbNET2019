Public Class Salary


    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        tb_allowances.Text = vbEmpty
        tb_basic_salary.Text = vbEmpty
        tb_deduction.Text = vbEmpty
        tb_employee_name.Text = ""
        tb_employee_no.Text = vbEmpty
        tb_gloss_salary.Text = vbEmpty
        tb_net_salary.Text = vbEmpty
        rb_a.Checked = False
        rb_b.Checked = False
        rb_c.Checked = False
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        If (rb_a.Checked = True) Then
            tb_allowances.Text = 10000
            tb_deduction.Text = (10 / 100) * Convert.ToInt32(tb_basic_salary.Text)
            tb_gloss_salary.Text = Convert.ToInt32(tb_basic_salary.Text) + Convert.ToInt32(tb_allowances.Text)
            tb_net_salary.Text = Convert.ToInt32(tb_gloss_salary.Text) - Convert.ToInt32(tb_deduction.Text)
        ElseIf (rb_b.Checked = True) Then
            tb_allowances.Text = 5000
            tb_deduction.Text = (5 / 100) * Convert.ToInt32(tb_basic_salary.Text)
            tb_gloss_salary.Text = Convert.ToInt32(tb_basic_salary.Text) + Convert.ToInt32(tb_allowances.Text)
            tb_net_salary.Text = Convert.ToInt32(tb_gloss_salary.Text) - Convert.ToInt32(tb_deduction.Text)
        Else
            tb_allowances.Text = 2000
            tb_deduction.Text = (2 / 100) * Convert.ToInt32(tb_basic_salary.Text)
            tb_gloss_salary.Text = Convert.ToInt32(tb_basic_salary.Text) + Convert.ToInt32(tb_allowances.Text)
            tb_net_salary.Text = Convert.ToInt32(tb_gloss_salary.Text) - Convert.ToInt32(tb_deduction.Text)
        End If
    End Sub
End Class
