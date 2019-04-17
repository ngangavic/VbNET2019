Module Module1

    Sub Main()
        Dim Sum As Integer = 0
        Dim C As Integer = 1
        Dim x, Average As Integer
        Do Until C >= 10
            Console.WriteLine("Input x")
            If (x Mod 2 = 0) Then
                Continue Do
            Else
                C = C + 1
                Sum = Sum
                Continue Do
            End If
        Loop
        Average = Sum / 10
        Console.WriteLine(Average)

    End Sub

End Module
