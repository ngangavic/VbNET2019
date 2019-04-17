Module ComparingStrings
    Sub main()
        Dim userString As String = Nothing
        Dim compString As String = "Iam"
        Console.WriteLine("Enter a string")
        userString = Console.ReadLine()
        Console.WriteLine(String.Compare(userString, compString))
        Console.ReadLine()
    End Sub

End Module
