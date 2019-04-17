Public Class Form1
    Dim basicSalary, travelAllowance, houseAllowance, sales, commission, grossPay, tax, netPay As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.Print("Visual basic")


        basicSalary = InputBox("What is the basic salary?", "Basic Salary")
        travelAllowance = InputBox("What is the travel allowance?", "Travel Allowance")
        houseAllowance = InputBox("What is the house allowance?", "House Allowance")
        sales = InputBox("What are the sales?", "Sales")
    End Sub

    Private Sub Btn_Calculate_Click(sender As Object, e As EventArgs) Handles Btn_Calculate.Click

        If (sales < 15000) Then
            commission = Convert.ToInt32((0 / 100) * sales)
        ElseIf (sales < 25000) Then
            commission = Convert.ToInt32((8 / 100) * sales)
        ElseIf (sales < 35000) Then
            commission = Convert.ToInt32((12 / 100) * sales)
        Else
            commission = Convert.ToInt32((15 / 100) * sales)
        End If
        grossPay = basicSalary + travelAllowance + houseAllowance + commission

        If (grossPay < 15000) Then
            tax = Convert.ToInt32((0 / 100) * grossPay)
        ElseIf (grossPay < 25000) Then
            tax = Convert.ToInt32((10 / 100) * grossPay)
        ElseIf (grossPay < 35000) Then
            tax = Convert.ToInt32((20 / 100) * grossPay)
        Else
            tax = Convert.ToInt32((30 / 100) * grossPay)
        End If
        netPay = grossPay - Convert.ToInt32(tax)
        MsgBox("Commisison: " & commission & " Tax: " & Convert.ToInt32(tax) & " Net pay: " & netPay)

    End Sub
End Class
