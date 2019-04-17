Module ContinueFor
    Sub main()
        Console.WriteLine("Normal for loop")
        For num = 1 To 20
            Console.WriteLine(num)
        Next
        Console.WriteLine("Continue for loop")
        For num = 1 To 20
            If num = 5 Or num = 10 Then
                Continue For
            End If
            Console.WriteLine(num)
        Next
        Console.ReadLine()
    End Sub

End Module
