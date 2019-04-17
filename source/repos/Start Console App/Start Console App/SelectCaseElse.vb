Module SelectCaseElse
    Sub main()
        Dim myInt As Integer = Nothing
        Console.WriteLine("Write a number between 0 and 3")
        myInt = Console.ReadLine()
        Select Case myInt
            Case 0
                Console.WriteLine("Good morning")
            Case 1
                Console.WriteLine("Good afternoon")
            Case 2
                Console.WriteLine("Good evening")
            Case 3
                Console.WriteLine("Good night")
            Case Else
                Console.WriteLine("I won't greet you:-)")
        End Select
        Console.ReadLine()
    End Sub

End Module
