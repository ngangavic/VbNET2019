Module IfStatement
    Sub main()
        Console.WriteLine("Enter your username")
        Dim uname As String = Console.ReadLine()
        Console.WriteLine("Enter your password")
        Dim pass As String = Console.ReadLine()

        If uname.Equals("vic") Then
            Console.WriteLine("Username correct")
        Else
            Console.WriteLine("Username wrong")
        End If

        If pass.Equals("0000") Then
            Console.WriteLine("Password correct")
        Else
            Console.WriteLine("Password wrong")
        End If
        Console.ReadLine()
    End Sub

End Module
