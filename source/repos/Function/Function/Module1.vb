Module Module1

    Sub Main()
        Dim a, b, e As Integer
        Console.WriteLine("Enter the first number")
        a = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the second number")
        b = Convert.ToInt32(Console.ReadLine())
        e = add(a, b)
        Console.WriteLine("The total is " & e)
    End Sub
    Public Function add(d As Integer, e As Integer) As Integer
        Dim c As Integer
        c = d + e
        add = c
    End Function

End Module
