Module Module1

    Sub Main()
        Dim regular As Double = 71.35
        Dim petrol As Double = 77.55
        Dim diesel As Double = 65.0
        Dim carWash As Integer = 300
        Dim fuelType As String = Nothing
        Dim washCar As Boolean = Nothing
        Dim liters As Integer = Nothing
        Dim totalPrice As Double = Nothing

        Console.WriteLine("Enter type of fuel")
        fuelType = Console.ReadLine()
        Console.WriteLine("Enter number of liters")
        liters = Console.ReadLine()
        Console.WriteLine("Is the car going to be washed?")
        washCar = Console.ReadLine()
        If (fuelType.Equals(Convert.ToString(regular)) And washCar = True) Then
            totalPrice = (regular * liters) + carWash
        ElseIf (fuelType.Equals(Convert.ToString(petrol)) And washCar = True) Then
            totalPrice = (petrol * liters) + carWash
        ElseIf (fuelType.Equals(Convert.ToString(diesel)) And washCar = True) Then
            totalPrice = (diesel * liters) + carWash
        ElseIf (fuelType.Equals(Convert.ToString(regular)) And washCar = False) Then
            totalPrice = regular * liters
        ElseIf (fuelType.Equals(Convert.ToString(petrol)) And washCar = False) Then
            totalPrice = regular * liters
        Else
            totalPrice = diesel * liters
        End If
        Console.WriteLine(totalPrice)

    End Sub

End Module
