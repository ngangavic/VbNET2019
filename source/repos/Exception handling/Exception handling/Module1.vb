Module Module1

    Sub Main()
        Dim A As Integer
        Try
            Console.WriteLine("Write any number")
            A = Convert.ToInt32(Console.ReadLine())
        Catch ex As Exception
            Console.WriteLine(ex)

        End Try
        Console.ReadKey()

    End Sub

End Module
