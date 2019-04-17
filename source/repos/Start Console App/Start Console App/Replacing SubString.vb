Module Replacing_SubString
    Sub main()
        Dim myString As String = Nothing
        Dim finalString As String = Nothing
        Console.WriteLine("Enter a string")
        myString = Console.ReadLine()
        finalString = myString.Replace("i", "o")
        Console.WriteLine(finalString)
        Console.ReadLine()
    End Sub

End Module
