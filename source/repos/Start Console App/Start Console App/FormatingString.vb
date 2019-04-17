Module FormatingString
    Sub main()
        Dim myString As String = Nothing
        Dim myDecimal As Double = Nothing
        Console.WriteLine("Write a string")
        myString = Console.ReadLine()
        Console.WriteLine("Enter a decimal number")
        myDecimal = Console.ReadLine()
        Console.WriteLine("{0:n2}", myDecimal)
        Console.WriteLine(myString.ToUpper)
        Console.WriteLine(myString.ToLower)
        Console.ReadLine()
    End Sub

End Module
