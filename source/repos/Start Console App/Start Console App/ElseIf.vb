Module Else_If
    Sub main()
        Console.WriteLine("Enter username")
        Dim uname As String = Console.ReadLine()
        If uname = "tim" Then
            Console.WriteLine("Welcome Tim!")
        ElseIf uname = "vic" Then
            Console.WriteLine("Welcome Vic")
        Else
            Console.WriteLine("I don't know who you are")
        End If
        Console.ReadLine()
    End Sub

End Module
