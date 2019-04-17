Module ConcatenateStrings
    Sub main()
        Dim userString As String = Nothing
        Dim programString As String = " student"
        Console.WriteLine("Write something")
        userString = Console.ReadLine()
        Console.WriteLine(userString + programString & " I am in you")
        Console.ReadLine()
    End Sub

End Module
