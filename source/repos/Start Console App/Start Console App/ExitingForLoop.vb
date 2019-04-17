Module ExitingForLoop
    Sub main()
        Console.WriteLine("Normal for loop")
        For num = 1 To 20
            Console.WriteLine(num)
        Next
        Console.WriteLine("For loop exit before it is finished")
        For num = 1 To 20
            Console.WriteLine(num)
            If num = 13 Then
                Exit For
            End If
        Next
        Console.ReadLine()
    End Sub

End Module
