Module DoUntil
    Sub main()
        Dim num As Integer = 0
        Do Until num = 10
            Console.WriteLine(num)
            num += 1
        Loop
        Console.ReadLine()
    End Sub

End Module
