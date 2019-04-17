Module StepOperator
    Sub main()
        Console.WriteLine("Normal loop")
        For num = 1 To 20
            Console.WriteLine(num)
        Next
        Console.WriteLine("Step by 5")
        For num = 1 To 20 Step 5
            Console.WriteLine(num)
        Next
        Console.WriteLine("Step by -4")
        For num = 20 To 1 Step -4
            Console.WriteLine(num)
        Next
        Console.ReadLine()
    End Sub

End Module
