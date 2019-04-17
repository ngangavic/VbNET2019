Module GetStringLength
    Sub main()
        Dim username As String
        Console.WriteLine("Write your username")
        username = Console.ReadLine()
        If username.Length = 10 Then
            Console.WriteLine("Granted access")
        Else
            Console.WriteLine("Denied access")
        End If
        Console.ReadLine()
    End Sub

End Module
