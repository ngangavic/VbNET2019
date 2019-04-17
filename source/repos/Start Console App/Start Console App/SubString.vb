Module SubString
    Sub main()
        Dim userString As String = Nothing
        Console.WriteLine("Enter a string")
        userString = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine(userString.Length.ToString())
        Console.WriteLine(userString.Substring(0, 3))
        Console.WriteLine(userString.Substring(3, 3))
        Console.WriteLine(userString.Substring(6))
        Console.ReadLine()

    End Sub

End Module
