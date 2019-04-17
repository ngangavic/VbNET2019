Module GettingUserInput
    Sub main()
        Dim num1 As Integer = Nothing
        Dim num2 As Integer = Nothing
        Dim ans As Double = Nothing
        Console.WriteLine("Enter the first number")
        num1 = Console.ReadLine()
        Console.WriteLine("Enter the second number")
        num2 = Console.ReadLine()
        ans = num1 + num2
        Console.WriteLine("The answer is: " & ans)
        Console.ReadLine()
    End Sub

End Module
